//-----------------------------------------------------------------------------
// Torque
// Copyright GarageGames, LLC 2011
//-----------------------------------------------------------------------------

exec("art/ModelsSH/3D/Mobiles/Characters/animation.cs");

//----------------------------------------------------------------------------
// Splash
//----------------------------------------------------------------------------


// datablock SplashData(PlayerSplash)
// {
   // numSegments = 15;
   // ejectionFreq = 15;
   // ejectionAngle = 40;
   // ringLifetime = 0.5;
   // lifetimeMS = 300;
   // velocity = 4.0;
   // startRadius = 0.0;
   // acceleration = -3.0;
   // texWrap = 5.0;

   // texture = "art/shapes/particles/millsplash01";

   // emitter[0] = PlayerSplashEmitter;
   // emitter[1] = PlayerSplashMistEmitter;

   // colors[0] = "0.7 0.8 1.0 0.0";
   // colors[1] = "0.7 0.8 1.0 0.3";
   // colors[2] = "0.7 0.8 1.0 0.7";
   // colors[3] = "0.7 0.8 1.0 0.0";
   // times[0] = 0.0;
   // times[1] = 0.4;
   // times[2] = 0.8;
   // times[3] = 1.0;
// };


//----------------------------------------------------------------------------

// datablock DecalData(PlayerFootprint)
// {
   // size = 0.4;
   // material = CommonPlayerFootprint;
// };

// datablock DebrisData( PlayerDebris )
// {
   // explodeOnMaxBounce = false;

   // elasticity = 0.15;
   // friction = 0.5;

   // lifetime = 4.0;
   // lifetimeVariance = 0.0;

   // minSpinSpeed = 40;
   // maxSpinSpeed = 600;

   // numBounces = 5;
   // bounceVariance = 0;

   // staticOnMaxBounce = true;
   // gravModifier = 1.0;

   // useRadiusMass = true;
   // baseRadius = 1;

   // velocity = 20.0;
   // velocityVariance = 12.0;
// };

// ----------------------------------------------------------------------------
// This is our default player datablock that all others will derive from.
// ----------------------------------------------------------------------------

datablock PlayerData(DefaultPlayerData)
{
   id = 3;

   sprintTime = 2;
   sprintCooldown = 2;

   className = Armor;
   shapeFile = "art/ModelsSH/3D/Mobiles/Characters/technocrate_male.dts";
   cameraMaxDist = 2.5;
   cameraMinDist = 0.8;
   cameraMaxDistWarStance = 2.5 + 1.2;
   cameraMinDistWarStance = 0.5;
   buildCameraMaxDist = 100;
   buildCameraMinDist = 5;
   buildScopeSize = 10;
   computeCRC = false;
   warstanceCamAngTheta = 0.4;
   peacestanceCamAngTheta = 0.0;

   canObserve = 1;
   cmdCategory = "Clients";

   cameraDefaultFov = 75; //100.0; //45;
   cameraMinFov = 5.0;
   cameraMaxFov = 120.0; //45;

   debrisShapeName = "art/shapes/actors/common/debris_player.dts";
   debris = playerDebris;

   aiAvoidThis = true;

   minLookAngle = -1.4;
   maxLookAngle =  1.4; //0.9;
   maxFreelookAngle = 3.0;

   lookupdown_animation_angle_min = -1.396; //80.0;
   lookupdown_animation_angle_max =  1.396; //80.0;

   mass = 100;
   drag = 1.3;
   maxdrag = 0.4;
   density = 1.1;
   maxDamage = 100;
   maxEnergy =  60;
   repairRate = 0.33;
   energyPerDamagePoint = 75;

   rechargeRate = 0.256;

   runForce = 4320;

   rotSpeedFirstPersonStay = 0.22;
   rotSpeedFirstPersonMove = 0.12;
   rotSpeedThirdPersonStay = 0.22;
   rotSpeedThirdPersonMove = 0.12;
   rotSpeedRotationAnim = 0.32;

   maxForwardSpeed = 4;
   maxBackwardSpeed = 3;
   maxSideSpeed = 3;
   maxRuningSpeed = 8;

   maxWarForwardSpeed = 4;
   maxWarBackwardSpeed = 2.5;
   maxWarSideSpeed = 4.5;
   maxWarRuningSpeed = 7;

   crouchForce = 405;
   maxCrouchForwardSpeed = 4.0;
   maxCrouchBackwardSpeed = 2.0;
   maxCrouchSideSpeed = 2.0;

   equipDrownCoeff = 0.35;
   waterStaminaRate = 0.1; // per second
   oxygenRate = 5; // per second

   maxUnderwaterForwardSpeed = 4;//8.4;
   maxUnderwaterBackwardSpeed = 3;//7.8;
   maxUnderwaterSideSpeed = 3;// 7.8;

   jumpForce = 900;
   pounceForce = 1200;

   jumpDelay = 15;
   airControl = 0.01;

   recoverDelay = 9;
   recoverRunForceScale = 1.2;

   minImpactSpeed = 15;
   
   impactGroundSpeed = 20;
   speedDamageScale = 0.4;

   boundingBox = "1.5 1 3.5";
   crouchBoundingBox = "1.5 1 3";
   swimBoundingBox = "1 2 2";
   standardRaycastBox = "4.244 4.747 4.246";
   mountingRaycastBox = "4.691 11.666 5.425";
   pickupRadius = 1;

   // Controls over slope of runnable/jumpable surfaces
   runSurfaceAngle  = 46;//70;//38;
   jumpSurfaceAngle = 80;
   maxStepHeight = 0.5;//1.5;  //two meters
   minJumpSpeed = 20;
   maxJumpSpeed = 30;
   knockedDownTicks = 50;

   horizMaxSpeed = 68;
   horizResistSpeed = 33;
   horizResistFactor = 0.2;

   upMaxSpeed = 80;
   upResistSpeed = 25;
   upResistFactor = 0.3;

   groundImpactMinSpeed    = 100.0; //45

   observeParameters = "0.5 4.5 4.5";

   mainWeapon = SwordWeapon;

   class = "armor";
};

datablock PlayerData( PlayerMaleTCData : DefaultPlayerData) {
   id = 1023;
   shapeFile = "art/ModelsSH/3D/Mobiles/Characters/technocrate_male.dts";
};

datablock PlayerData( PlayerMaleSMData : DefaultPlayerData) {
   id = 1022;
   shapeFile = "art/ModelsSH/3D/Mobiles/Characters/sh_acribian_male.dts"; // was steamage_male.dts (LiF male body on the SH skeleton + SH Acribian clothing)
};

datablock PlayerData( PlayerFemaleTCData : DefaultPlayerData) {
   id = 1021;
   shapeFile = "art/ModelsSH/3D/Mobiles/Characters/sh_female.dts"; // LiF female body on the SH skeleton (same bones/nodes/size as the SH male) + SH clothing
   imageScale = "1 1 1";
   horseScale = "1 1 1";
   shapeScale = "1 1 1";
   lightShapeName[0] = "lamp_light";
   lightShapeNode[0] = "head_light";
   lightShapeRadius[0] = 25;
   lightShapeColor[0] = "1.0 1.0 1.0";
   lightShapeBrightness[0] = 0.02;
};

datablock PlayerData( PlayerFemaleSMData : DefaultPlayerData) {
   id = 1020;
   shapeFile = "art/ModelsSH/3D/Mobiles/Characters/sh_female.dts"; // LiF female body on the SH skeleton (same bones/nodes/size as the SH male) + SH clothing
   imageScale = "1 1 1";
   horseScale = "1 1 1";
   shapeScale = "1 1 1";
   lightShapeName[0] = "lamp_light";
   lightShapeNode[0] = "head_light";
   lightShapeRadius[0] = 25;
   lightShapeColor[0] = "1.0 1.0 1.0";
   lightShapeBrightness[0] = 0.02;
};

datablock CameraData(Observer)
{
   id = 139;
   mode = "Observer";
   useEyePoint = true;
   firstPersonOnly = true;
};

datablock PathCameraData(PathCamData)
{
   id = 356;
   useEyePoint = true;
   firstPersonOnly = true;
};
