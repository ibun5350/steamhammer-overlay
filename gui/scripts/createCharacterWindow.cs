

//-----------------------------------------------------------------------------
function createCharacterWindow::onWake(%this) {
	createCharacterEnteredName.makeFirstResponder(true);
}
//-----------------------------------------------------------------------------
function createCharacterWindow::InitVoices() {
	createCharacterVoicePopUpMenu.clear();
	
   %numOfItems = GetNumberOfVoices();
   for(%i = 0; %i < %numOfItems; %i++)
   {
      createCharacterVoicePopUpMenu.add("Voice " @ (%i + 1), %i);   // SH modpack: was "Voice 2" @ %i ("Voice 20", "Voice 21"...)
   }	
	
	createCharacterVoicePopUpMenu.setSelected( 0);
}
//-----------------------------------------------------------------------------
function createCharacterWindow::InitHaircuts() {
	createCharacterHaircutPopUpMenu.clear();
   %numOfItems = GetNumberOfHaircuts();
   for(%i = 0; %i < %numOfItems; %i++)
   {
      createCharacterHaircutPopUpMenu.add("Haircut " @ %i, %i);
   }      
   createCharacterHaircutPopUpMenu.setSelected( 0);
	
}
//-----------------------------------------------------------------------------
function createCharacterWindow::InitBeards() {
	createCharacterFacialHairPopUpMenu.clear();
   
   %numOfItems = GetNumberOfFacialHairs();
   for(%i = 0; %i < %numOfItems; %i++)
   {
      createCharacterFacialHairPopUpMenu.add("Facial hair " @ %i, %i);
   }
   createCharacterFacialHairPopUpMenu.setSelected( 0);
	
}
//-----------------------------------------------------------------------------
function createCharacterWindow::InitHeads() {
	createCharacterHeadSlider.setRange( "0" SPC strformat( "%u", GetNumberOfHeads() -1));
}
//-----------------------------------------------------------------------------
function createCharacterWindow::InitHairColors() {
   HairColorSliderCtrl.setRange( "0" SPC strformat( "%u", GetNumberOfHairColors() -1));
}
//-----------------------------------------------------------------------------
function createCharacterWindow::InitSkinColors() {
	SkinToneGuiSliderCtrl.setRange( "0" SPC strformat( "%u", GetNumberOfSkinColors() -1));
}
//----------------------------------------
function createCharacterWindow::OnCancelBtn() {
   CreateCharacterCancelPressed();
}   
//----------------------------------------
function createCharacterWindow::OnNextBtn() {
   CreateCharacterNextPressed();
}   
//----------------------------------------
function createCharacterWindow::OnPlusBtn() {
	createCharacterModel.setOrbitZPos( 2.82);
	createCharacterModel.setOrbitDistance( 3.2);
}   
//----------------------------------------
function createCharacterWindow::OnMinusBtn() {
	createCharacterModel.setOrbitZPos( 2.2);
	createCharacterModel.setOrbitDistance( 7.5);
}
//----------------------------------------
function createCharacterEnteredName::onTabComplete( %this, %val) {
	createCharacterEnteredFamily.makeFirstResponder(true);
}
//----------------------------------------
function createCharacterEnteredFamily::onTabComplete( %this, %val) {
	createCharacterEnteredName.makeFirstResponder(true);
}
//----------------------------------------

//----------------------------------------
function createCharacterMaleBut::onStateChanged( %this, %state) {
	if( %state ==1) {
		GenderMalePressed();
      setCharacterEur();
	}
}
//----------------------------------------
/*
function createCharacterFemaleBut::onStateChanged( %this, %state) {
	if( %state ==1) {
		GenderFemalePressed();
      setCharacterEur();
	}
}
*/

//----------------------------------------------------------------------

function createCharacterTechnocrateBut::onStateChanged( %this, %state) {
	if( %state ==1) {
		FractionChangePressed(1);
	}
}
//----------------------------------------
function createCharacterSteammageBut::onStateChanged( %this, %state) {
	if( %state ==1) {
		FractionChangePressed(2);	}
}

//----------------------------------------
//HeadSliderCtrl (3 variants)
//----------------------------------------
function createCharacterHeadSlider::onValueChanged(%this) {
	HeadChangePressed( createCharacterHeadSlider.getValue());
}
//----------------------------------------
//FacialFeaturesSliderCtrl (16 variants)
//----------------------------------------
function FacialFeaturesSliderCtrl::onValueChanged(%this) {
	FacialFeaturesChangePressed( FacialFeaturesSliderCtrl.getValue());
}
//----------------------------------------
//createCharacterHaircutPopUpMenu (8 variants)
//----------------------------------------
function createCharacterHaircutPopUpMenu::onSelect( %this, %id, %text) {
	HairChangePressed( createCharacterHaircutPopUpMenu.getSelected());
}
//----------------------------------------
//createCharacterFacialHairPopUpMenu (8 variants (only for men))
//----------------------------------------
function createCharacterFacialHairPopUpMenu::onSelect( %this, %id, %text) {
	BeardChangePressed( createCharacterFacialHairPopUpMenu.getSelected());
}
//----------------------------------------
//HairColorSliderCtrl (8 variants)
//----------------------------------------
function HairColorSliderCtrl::onValueChanged(%this) {
	HairColorChangePressed( HairColorSliderCtrl.getValue());
}
//----------------------------------------
//BodyFeaturesSliderCtrl (8 variants)
//----------------------------------------
function BodyFeaturesSliderCtrl::onValueChanged(%this) {
	BodyFeaturesChangePressed( BodyFeaturesSliderCtrl.getValue());
}
//----------------------------------------
//SkinToneGuiSliderCtrl (8 variants)
//----------------------------------------
function SkinToneGuiSliderCtrl::onValueChanged(%this) {
	SkinColorChangePressed( SkinToneGuiSliderCtrl.getValue());
}
//----------------------------------------
function createCharacterWindow::OnRandomAppearance( %this, %state) {
	RandomAppearancePressed();
}
//----------------------------------------
//createCharacterVoicePopUpMenu (4 variants)
//----------------------------------------
function createCharacterVoicePopUpMenu::onSelect( %this, %id, %text) {
	VoiceChangePressed( createCharacterVoicePopUpMenu.getSelected());
}
//----------------------------------------
//createCharacterEurBut
//----------------------------------------
function setCharacterEur()
{
      createCharacterDescriptionText.setText(GetMessageIDText(698));
      createCharacterRaceIcon.setGlobalImageIndex(getCreateCharRace1());
      createCharacterRaceName.setText(GetMessageIDText(1257));
      SetStrenghtRange        ( 12, 30);
      SetAgilityRange         ( 12, 30);
      SetConstitutionRange    ( 12, 30);
      SetWillpowerRange       ( 12, 30);
      SetIntelligenceRange    ( 12, 30);

      // CRAFTING SKILLS RANGES      
      SetMetallurgistRange    ( 15,  25);
      SetFermerRange          ( 15,  25);
      SetBlacksmithRange      ( 15,  25);
      SetEngineerRange        ( 15,  25);
      SetAlchemistRange       ( 15,  25);
      SetBuildingRange        ( 15,  25);
      
      SetHandgunMasteryRange       ( 15, 25);
      SetTeslaHandgunMasteryRange  ( 15, 25);
      SetAxeMasteryRange           ( 15, 25);
      SetUnarmedRange              ( 15, 25);
      SetPilotingRange             ( 15, 25);
      SetSwordMasteryRange         ( 15, 25);
      
      RaceChangePressed( 1);
}
//----------------------------------------
//createCharacterVikBut
//----------------------------------------
function createCharacterVikBut::onStateChanged( %this, %state)
{
   if (%state == 1)
   {
      createCharacterDescriptionText.setText( GetMessageIDText( 699));
      createCharacterRaceIcon.setGlobalImageIndex(getCreateCharRace2());
      createCharacterRaceName.setText(GetMessageIDText(1258));

      SetStrenghtRange        ( 15, 30);
      SetAgilityRange         ( 10, 30);
      SetConstitutionRange    ( 15, 30);
      SetWillpowerRange       ( 10, 30);
      SetIntelligenceRange    ( 10, 30);
      
      // CRAFTING SKILLS RANGES      
      SetMetallurgistRange    ( 15,  25);
      SetFermerRange          ( 15,  25);
      SetBlacksmithRange      ( 15,  25);
      SetEngineerRange        ( 15,  25);
      SetAlchemistRange       ( 15,  25);
      SetBuildingRange        ( 15,  25);
      
      SetHandgunMasteryRange       ( 15, 25);
      SetTeslaHandgunMasteryRange  ( 15, 25);
      SetAxeMasteryRange           ( 15, 25);
      SetUnarmedRange              ( 15, 25);
      SetPilotingRange             ( 15, 25);
      SetSwordMasteryRange         ( 15, 25);
      
      RaceChangePressed( 2);
   }
}
//----------------------------------------
//createCharacterMonBut
//----------------------------------------
function createCharacterMonBut::onStateChanged( %this, %state)
{
   if( %state ==1)
   {
      createCharacterDescriptionText.setText( GetMessageIDText( 700));
      createCharacterRaceIcon.setGlobalImageIndex(getCreateCharRace3());
      createCharacterRaceName.setText(GetMessageIDText(1259));

      SetStrenghtRange        ( 10, 30);
      SetAgilityRange         ( 15, 30);
      SetConstitutionRange    ( 10, 30);
      SetWillpowerRange       ( 15, 30);
      SetIntelligenceRange    ( 10, 30);
      // CRAFTING SKILLS RANGES      
      SetMetallurgistRange    ( 15,  25);
      SetFermerRange          ( 15,  25);
      SetBlacksmithRange      ( 15,  25);
      SetEngineerRange        ( 15,  25);
      SetAlchemistRange       ( 15,  25);
      SetBuildingRange        ( 15,  25);
      
      SetHandgunMasteryRange       ( 15, 25);
      SetTeslaHandgunMasteryRange  ( 15, 25);
      SetAxeMasteryRange           ( 15, 25);
      SetUnarmedRange              ( 15, 25);
      SetPilotingRange             ( 15, 25);
      SetSwordMasteryRange         ( 15, 25);
      
      RaceChangePressed( 3);
   }
}
//----------------------------------------
function StrenghtGuiSliderCtrl::onValueChanged(%this)
{
   if (!%this.isAwake())
      return;

	normalizeStatSliders( 0);
	StrenghtValTextCtrl.text = StrenghtGuiSliderCtrl.getValue();
}
//----------------------------------------
function AgilityGuiSliderCtrl::onValueChanged( %this)
{
   if (!%this.isAwake())
      return;

	normalizeStatSliders( 1);
	AgilityValTextCtrl.text = AgilityGuiSliderCtrl.getValue();
}
//----------------------------------------
function ConstitutionGuiSliderCtrl::onValueChanged( %this)
{
   if (!%this.isAwake())
      return;

	normalizeStatSliders( 2);
	ConstitutionValTextCtrl.text = ConstitutionGuiSliderCtrl.getValue();
}
//----------------------------------------
function WillpowerGuiSliderCtrl::onValueChanged( %this)
{
   if (!%this.isAwake())
      return;

	normalizeStatSliders( 3);
	WillpowerValTextCtrl.text = WillpowerGuiSliderCtrl.getValue();
}
//----------------------------------------
function IntelligenceGuiSliderCtrl::onValueChanged( %this)
{
   if (!%this.isAwake())
      return;

	normalizeStatSliders( 4);
	IntelligenceValTextCtrl.text = IntelligenceGuiSliderCtrl.getValue();
}
//----------------------------------------
function MetallurgistSlider::onValueChanged( %this)
{
   if (!%this.isAwake())
      return;

	normalizeCraftingSkillSliders( 0);
	MetallurgistValTextCtrl.text = MetallurgistSlider.getValue();
}
//----------------------------------------
function FermerSlider::onValueChanged( %this)
{
   if (!%this.isAwake())
      return;

	normalizeCraftingSkillSliders( 1);
	FermerValTextCtrl.text = FermerSlider.getValue();
}
//----------------------------------------
function BlacksmithSlider::onValueChanged( %this)
{
   if (!%this.isAwake())
      return;

	normalizeCraftingSkillSliders( 2);
	BlacksmithValTextCtrl.text = BlacksmithSlider.getValue();
}
//----------------------------------------
function EngineerSlider::onValueChanged( %this)
{
   if (!%this.isAwake())
      return;

	normalizeCraftingSkillSliders( 3);
	EngineerValTextCtrl.text = EngineerSlider.getValue();
}
//----------------------------------------
function AlchemistSlider::onValueChanged( %this)
{
   if (!%this.isAwake())
      return;

	normalizeCraftingSkillSliders( 4);
	AlchemistValTextCtrl.text = AlchemistSlider.getValue();
}
//----------------------------------------
function BuildingSlider::onValueChanged( %this)
{
   if (!%this.isAwake())
      return;

	normalizeCraftingSkillSliders( 4);
	BuildingValTextCtrl.text = BuildingSlider.getValue();
}
//----------------------------------------
function HandgunMasterySlider::onValueChanged( %this)
{
   if (!%this.isAwake())
      return;

	normalizeFightingSkillSliders( 0);
	HandgunMasteryValTextCtrl.text = HandgunMasterySlider.getValue();
}
//----------------------------------------
function TeslaHandgunMasterySlider::onValueChanged( %this)
{
   if (!%this.isAwake())
      return;

	normalizeFightingSkillSliders( 1);
	TeslaHandgunMasteryValTextCtrl.text = TeslaHandgunMasterySlider.getValue();
}
//----------------------------------------
function AxeMasterySlider::onValueChanged( %this)
{
   if (!%this.isAwake())
      return;

	normalizeFightingSkillSliders( 2);
	AxeMasteryValTextCtrl.text = AxeMasterySlider.getValue();
}
//----------------------------------------
function UnarmedSlider::onValueChanged( %this)
{
   if (!%this.isAwake())
      return;

	normalizeFightingSkillSliders( 3);
	UnarmedValTextCtrl.text = UnarmedSlider.getValue();
}
//----------------------------------------
function PilotingSlider::onValueChanged( %this)
{
   if (!%this.isAwake())
      return;

	normalizeFightingSkillSliders( 4);
	PilotingValTextCtrl.text = PilotingSlider.getValue();
}
//----------------------------------------
function SwordMasterySlider::onValueChanged( %this)
{
   if (!%this.isAwake())
      return;

	normalizeFightingSkillSliders( 4);
	SwordMasteryValTextCtrl.text = SwordMasterySlider.getValue();
}
//----------------------------------------

function CharSelectionCreatePressed()
{
   CloseCharacterSelectionDialog();
   createWindowCreateCharacter();
   OpenCharacterCreationDialog();
}
//----------------------------------------

