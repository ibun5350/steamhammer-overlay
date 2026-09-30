//-----------------------------------------------------------------------------
// SteamHammer modpack: enables Female and Acribian characters in the
// character creator.
//
// Stock gui/forms/createCharacterWindow.gui turned the Female button into a
// push button that only shows "Female characters will be available later"
// (CharacterWomenErrorMessage), and gui/scripts/createCharacterWindow.cs has
// the female handler commented out. Female players now use
// art/ModelsSH/3D/Mobiles/Characters/sh_female.dts (LiF female body + SH
// clothing, see art/datablocks/player.cs) with the female parts in
// data/cm_customisation.xml.
//
// Here the Female button becomes a normal radio button in the same group as
// Male, and selecting it calls the engine's GenderFemalePressed(), exactly as
// the commented-out stock handler did.
//-----------------------------------------------------------------------------

function createCharacterFemaleBut::onStateChanged(%this, %state)
{
   if (%state == 1)
   {
      GenderFemalePressed();
      setCharacterEur();
   }
}

//-----------------------------------------------------------------------------
// Acribian characters without touching sh_client.exe.
//
// The engine's CreateCharacterNextPressed() refuses faction 2 (Acribians) with
// message 5021 before it builds the create request. So when the player has
// Acribians selected, Next sends the character as faction 1 with race 2 as a
// marker (SH has race selection disabled and always uses race 1), and the
// database trigger `sh_acribian_on_create` (sh_acribian_trigger.sql, on
// sh_1.character, BEFORE INSERT) turns Fraction=1/Race=2 back into
// Fraction=2 (Acribian) / Race=1 as the character is created.
// The marker values must match the trigger.
//-----------------------------------------------------------------------------
$SH_Char::FactionVictorian   = 1;
$SH_Char::FactionAcribian    = 2;
$SH_Char::RaceDefault        = 1;   // Auriunian - what setCharacterEur() selects
$SH_Char::RaceAcribianMarker = 2;   // Jorgrithian - never chosen by players in SH

package SH_CharacterOverride
{
   function createCharacterWindow::OnNextBtn()
   {
      if (GetFraction() != $SH_Char::FactionAcribian)
      {
         Parent::OnNextBtn();
         return;
      }

      FractionChangePressed($SH_Char::FactionVictorian);
      RaceChangePressed($SH_Char::RaceAcribianMarker);
      CreateCharacterNextPressed();

      // Still in the creator (e.g. the name was rejected): restore the
      // Acribian selection so the player sees what they chose.
      if (isObject(createCharacterWindow) && createCharacterWindow.isAwake())
      {
         RaceChangePressed($SH_Char::RaceDefault);
         FractionChangePressed($SH_Char::FactionAcribian);
      }
   }

   function createComboStackSex(%combo_stack_ctrl, %group_num)
   {
      Parent::createComboStackSex(%combo_stack_ctrl, %group_num);

      if (isObject(createCharacterFemaleBut))
      {
         createCharacterFemaleBut.command    = "";
         createCharacterFemaleBut.groupNum   = createCharacterMaleBut.groupNum;
         createCharacterFemaleBut.buttonType = "RadioButton";
      }
   }
};
activatePackage(SH_CharacterOverride);
