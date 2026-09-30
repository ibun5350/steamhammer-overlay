//-----------------------------------------------------------------------------
// Torque
// Copyright GarageGames, LLC 2011
//-----------------------------------------------------------------------------

//-----------------------------------------------------------------------------

// Variables used by server scripts & code.  The ones marked with (c)
// are accessed from code.  Variables preceeded by Pref:: are server
// preferences and stored automatically in the ServerPrefs.cs file
// in between server sessions.
//
//    (c) Server::ServerType              {SinglePlayer, MultiPlayer}
//    (c) Server::GameType                Unique game name
//    (c) Server::Dedicated               Bool
//    ( ) Server::MissionFile             Mission .mis file name
//    (c) Server::MissionName             DisplayName from .mis file
//    (c) Server::MissionType             Not used
//    (c) Server::PlayerCount             Current player count
//    (c) Server::GuidList                Player GUID (record list?)
//    (c) Server::Status                  Current server status
//
//    (c) Pref::Server::Name              Server Name
//    (c) Pref::Server::Password          Password for client connections
//    ( ) Pref::Server::AdminPassword     Password for client admins
//    (c) Pref::Server::Info              Server description
//    //(c) Pref::Server::MaxPlayers        Max allowed players // $Server::MaxPlayers now
//    (c) Pref::Server::RegionMask        Registers this mask with master server
//    ( ) Pref::Server::BanTime           Duration of a player ban
//    ( ) Pref::Server::KickBanTime       Duration of a player kick & ban
//    ( ) Pref::Server::MaxChatLen        Max chat message len
//    ( ) Pref::Server::FloodProtectionEnabled Bool

//-----------------------------------------------------------------------------


/// Determine the IP address we can use locally
function determineNetwork()
{
	%ipLine = getIPLocal();
	if(getWordCount(%ipLine) <= 0)
	{
		error("Can't get IP address");
		return;
	}
	// get first ip
	$cm_config::localIpAddress = getWord(%ipLine, 0);
}

//-----------------------------------------------------------------------------

function initServer()
{
   echo("\n--------- Initializing " @ $appName @ ": Server Scripts ---------");

   // The common module provides the basic server functionality
   initBaseServer();

   // Load up game server support scripts
   exec("./commands.cs");
   exec("./game.cs");


	//CM_CHANGE

	exec("art/terrains/materials.cs");

	// init of config
	echo("Loading CmConfiguration");
	exec("scripts/server/cm_config.cs");
	CmConfiguration_init();

	// init of DB
	echo("Init of DB interface");
	CmDatabase_init();

	// check if we can use given world_id
	if(!CmServerInfoManager::setLocalWorldIDToLoad($cm_config::worldID))
	{
		error("Fatal: Can't set world to load (id=" @ $cm_config::worldID @ "). Terminating.");
		quit();
		return false;
	}
	$cm_config::worldID = CmServerInfoManager::getWorldIdToLoad(); // if world ID changed
	
	// check if our server already running
	if(!checkServerIdLockFile())
	{
		error("Can't init server... looks like another instance is already started! (id=" @ $cm_config::worldID @ "). Terminating.");
		quit();
		return;
	}
	
	// finally load current world
	if(!CmServerInfoManager::initLocalWorld())
	{
		error("Fatal: Can't init local world (id=" @ $cm_config::worldID @ "). Terminating.");
		quit();
		return false;
	}

	// indicate world ID
	$Con::WindowTitle = $Con::WindowTitle @ "," SPC "world ID" SPC $cm_config::worldID;
	enableWinConsole(true);

	// start client notification
	if(!CmServerInfoManager::isDedicatedServer())
		startSharingServerLoadingStatus();

	// Main DBI
	singleton DatabaseInterface(dbi);
	dbi.initialize(DBIPrimary);//dbi.schedule(32, initialize, DBIPrimary);
	// Inventory
	singleton DatabaseInterface(dbiInventory);
	dbiInventory.initialize(DBIInvLoad);//dbiInventory.schedule(32, initialize, DBIInvLoad);
	// InvHelper
	singleton DatabaseInterface(dbiInvHelper);
	dbiInvHelper.initialize(DBIInvHelper);//dbiInvHelper.schedule(32, initialize, DBIInvHelper);

	// load forest data
	exec("art/forest/cmForestData.cs");

	// Steam Hammer mod: chat tab counts + GM names for the client mod pack
	exec("scripts/server/sh_chatInfo.cs");

	// Init network
	determineNetwork();

	return true;
}

function startSharingServerLoadingStatus()
{
	if(!isObject($sharedLoadingStatus))
	{
		$sharedLoadingStatus = new CmServerSharedLoadingStatus();
		MissionCleanup.add($sharedLoadingStatus);
	}
}
