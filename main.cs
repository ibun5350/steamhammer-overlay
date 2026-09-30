
// Process command line arguments
exec("core/parseArgs.cs");

// Parse the executable arguments with the standard
// function from core/main.cs
defaultParseArgs();

$joinMode = 0;
exec("mainLocal.cs");

function compileFiles(%pattern)
{  
   %path = filePath(%pattern);

   %saveDSO    = $Scripts::OverrideDSOPath;
   %saveIgnore = $Scripts::ignoreDSOs;
   
   $Scripts::OverrideDSOPath  = %path;
   $Scripts::ignoreDSOs       = false;
   %mainCsFile = "main.cs";//makeFullPath("main.cs");

   for (%file = findFirstFileMultiExpr(%pattern); %file !$= ""; %file = findNextFileMultiExpr(%pattern))
   {
      // we don't want to try and compile the primary main.cs
      if(%mainCsFile !$= %file)      
         compile(%file, true);
   }

   $Scripts::OverrideDSOPath  = %saveDSO;
   $Scripts::ignoreDSOs       = %saveIgnore;
}

if($compileAll)
{
   echo(" --- Compiling all files ---");
   compileFiles("*.cs");
   compileFiles("*.gui");
   compileFiles("*.ts");  
   echo(" --- Exiting after compile ---");
   quit();
}
else
{
   exec("scripts/root.cs");
   exec("gui/scripts/skillTreeOverride.cs");
   exec("gui/scripts/languageOverride.cs");
   exec("gui/scripts/buildOverride.cs");
   exec("gui/scripts/observeOverride.cs");
   exec("gui/scripts/characterOverride.cs");
   exec("gui/scripts/hudOverride.cs");
   exec("gui/scripts/disconnectOverride.cs");
   exec("gui/scripts/combatOverride.cs");
   exec("gui/scripts/chatOverride.cs");
}
exec("handjob.cs");