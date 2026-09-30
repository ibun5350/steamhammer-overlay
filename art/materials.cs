exec("art/customization_data.cs");
exec("art/female_materials.cs");
exec("art/sh_acribian_materials.cs"); // Acribian player model (sh_acribian_male.dts) body/head/hair materials
exec("art/materials_environment.cs");

//---------------------------------------------------------------------------------------------------------------
//---   envmap = true;
//---   fChrome = 0.1;
//-------------- translucent = "1"; — включает полупрозрачность; такие объекты освещаются только солнцем (поинтлайты не действуют)

//-------------- mipLODBias = -1.0; — дальность включения мипмапов

//-------------- useAnisotropic[0] = "1"; — включает анизотропную фильтрацию текстур

//-------------- doubleSided = "1"; — включает двухстороннее отображение

//-------------- skinned = true; — нужно включать для моделей со скелетной анимацией
//---------------------------------------------------------------------------------------------------------------


//----------------------------------------------------------------------
singleton Material(BedA)
{
   mapTo = "BedA";
   
   diffuseMap[0] = "art/TexturesSH/Construction/Furniture/BedA/Dif.dds";
   diffuseMap[1] = "art/TexturesSH/Construction/Furniture/BedA/Normal.dds";
   diffuseMap[2] = "art/TexturesSH/Construction/Furniture/BedA/Spec.dds";
   
   materialTag0 = "LiF";
};

singleton Material(BedB)
{
   mapTo = "BedB";
   diffuseMap[0] = "art/TexturesSH/Construction/Furniture/BedB/Dif.dds";
   diffuseMap[1] = "art/TexturesSH/Construction/Furniture/BedB/Norm.dds";
   diffuseMap[2] = "art/TexturesSH/Construction/Furniture/BedB/Spec.dds";
 
   materialTag0 = "LiF";
};

singleton Material(CaseA)
{
   mapTo = "CaseA";
   diffuseMap[0] = "art/TexturesSH/Construction/Furniture/CaseA/Case_Dif.dds";
   diffuseMap[1] = "art/TexturesSH/Construction/Furniture/CaseA/Case_Norm.dds";
   diffuseMap[2] = "art/TexturesSH/Construction/Furniture/CaseA/Case_Spec.dds";

   materialTag0 = "LiF";
};
singleton Material(CaseB)
{
   mapTo = "CaseB";
   diffuseMap[0] = "art/TexturesSH/Construction/Furniture/CaseB/CaseB_Dif.dds";
   diffuseMap[1] = "art/TexturesSH/Construction/Furniture/CaseB/CaseB_Norm.dds";
   diffuseMap[2] = "art/TexturesSH/Construction/Furniture/CaseB/CaseB_Spec.dds";
 
   materialTag0 = "LiF";
};

singleton Material(CaseC)
{
   mapTo = "CaseC";
   diffuseMap[0] = "art/TexturesSH/Construction/Furniture/CaseC/Case_Dif.dds";
   diffuseMap[1] = "art/TexturesSH/Construction/Furniture/CaseC/Case_Norm.dds";
   diffuseMap[2] = "art/TexturesSH/Construction/Furniture/CaseC/Case_Spec.dds";

   materialTag0 = "LiF";
};
singleton Material(DesserA_DresserA)
{
   mapTo = "DresserA";
   diffuseMap[0] = "art/TexturesSH/Construction/Furniture/DesserA/DresserA_Dif.dds";
   diffuseMap[1] = "art/TexturesSH/Construction/Furniture/DesserA/DresserA_norm.dds";
   diffuseMap[2] = "art/TexturesSH/Construction/Furniture/DesserA/DresserA_spec.dds";
 
   materialTag0 = "LiF";
};

singleton Material(DresserB)
{
   mapTo = "DresserB";
   diffuseMap[0] = "art/TexturesSH/Construction/Furniture/DresserB/DresserB_Dif.dds";
   diffuseMap[1] = "art/TexturesSH/Construction/Furniture/DresserB/DresserB_norm.dds";
   diffuseMap[2] = "art/TexturesSH/Construction/Furniture/DresserB/DresserB_spec.dds";

   materialTag0 = "LiF";
};
//--------------------------------------------------------------------------------------------Meh-------------------

singleton Material(MehA)
{
   mapTo = "MehA";
   diffuseMap[0] = "art/TexturesSH/Construction/Furniture/MehA/Meh_Dif.dds";
   diffuseMap[1] = "art/TexturesSH/Construction/Furniture/MehA/Meh_Norm.dds";
   diffuseMap[2] = "art/TexturesSH/Construction/Furniture/MehA/Meh_Spec.dds";

   rimIntensity = 1;    
};

singleton Material(MehB)
{
   mapTo = "MehB";
   diffuseMap[0] = "art/TexturesSH/Construction/Furniture/MehB/MehB_Dif.dds";
   diffuseMap[1] = "art/TexturesSH/Construction/Furniture/MehB/MehB_Norm.dds";
   diffuseMap[2] = "art/TexturesSH/Construction/Furniture/MehB/MehB_Spec.dds";

 rimIntensity = 1;    
};

singleton Material(MehC)
{
   mapTo = "MehC";
   diffuseMap[0] = "art/TexturesSH/Construction/Furniture/MehC/MehC_Dif.dds";
   diffuseMap[1] = "art/TexturesSH/Construction/Furniture/MehC/MehC_Norm.dds";
   diffuseMap[2] = "art/TexturesSH/Construction/Furniture/MehC/MehC_Spec.dds";
  
   rimIntensity = 1;    
};

singleton Material(MehD)
{
   mapTo = "MehD";
   diffuseMap[0] = "art/TexturesSH/Construction/Furniture/MehD/MehD_Dif.dds";
   diffuseMap[1] = "art/TexturesSH/Construction/Furniture/MehD/MehD_Norm.dds";
   diffuseMap[2] = "art/TexturesSH/Construction/Furniture/MehD/MehD_Spec.dds";
 
    rimIntensity = 1;    
};

singleton Material(MehE5)
{
   mapTo = "MehE5";
   diffuseMap[0] = "art/TexturesSH/Construction/Furniture/MehE/MehE_Dif.dds";
   diffuseMap[1] = "art/TexturesSH/Construction/Furniture/MehE/MehE_Norm.dds";
   diffuseMap[2] = "art/TexturesSH/Construction/Furniture/MehE/MehE_Spec.dds";

  rimIntensity = 1;    
};
singleton Material(MehF)
{
   mapTo = "MehF";
   diffuseMap[0] = "art/TexturesSH/Construction/Furniture/MehF/MehF_Dif.dds";
   diffuseMap[1] = "art/TexturesSH/Construction/Furniture/MehF/MehF_Norm.dds";
   diffuseMap[2] = "art/TexturesSH/Construction/Furniture/MehF/MehF_Spec.dds";

 rimIntensity = 1;    
    
};

singleton Material(MehG)
{
   mapTo = "MehG";
   diffuseMap[0] = "art/TexturesSH/Construction/Furniture/MehG/MehG_Dif.dds";
   diffuseMap[1] = "art/TexturesSH/Construction/Furniture/MehG/MehG_Norm.dds";
   diffuseMap[2] = "art/TexturesSH/Construction/Furniture/MehG/MehG_Spec.dds";

   rimIntensity = 1;    
};

singleton Material(MehH)
{
   mapTo = "MehH";
   diffuseMap[0] = "art/TexturesSH/Construction/Furniture/MehH/MehH_Dif.dds";
   diffuseMap[1] = "art/TexturesSH/Construction/Furniture/MehH/MehH_Norm.dds";
   diffuseMap[2] = "art/TexturesSH/Construction/Furniture/MehH/MehH_Spec.dds";
 
    rimIntensity = 1;    
};

singleton Material(MehI_I)
{
   mapTo = "MehI_I";
   diffuseMap[0] = "art/TexturesSH/Construction/Furniture/MehI_I/MehI_I_Dif.dds";
   diffuseMap[1] = "art/TexturesSH/Construction/Furniture/MehI_I/MehI_I_Norm.dds";
   diffuseMap[2] = "art/TexturesSH/Construction/Furniture/MehI_I/MehI_I_Spec.dds";

   rimIntensity = 1;    

};

singleton Material(MehI_L)
{
   mapTo = "MehI_L";
   diffuseMap[0] = "art/TexturesSH/Construction/Furniture/MehI_L/MehI_L_Dif.dds";
   diffuseMap[1] = "art/TexturesSH/Construction/Furniture/MehI_L/MehI_L_Norm.dds";
   diffuseMap[2] = "art/TexturesSH/Construction/Furniture/MehI_L/MehI_L_Spec.dds";

 rimIntensity = 1;    
};

singleton Material(MehI_T)
{
   mapTo = "MehI_T";
   diffuseMap[0] = "art/TexturesSH/Construction/Furniture/MehI_T/MehI_T_Dif.dds";
   diffuseMap[1] = "art/TexturesSH/Construction/Furniture/MehI_T/MehI_T_Norm.dds";
   rimIntensity = 1;    
};

singleton Material(MehJ)
{
   mapTo = "MehJ";
   diffuseMap[0] = "art/TexturesSH/Construction/Furniture/MehJ/MehJ_Dif.dds";
   diffuseMap[1] = "art/TexturesSH/Construction/Furniture/MehJ/MehJ_Norm.dds";
   diffuseMap[2] = "art/TexturesSH/Construction/Furniture/MehJ/MehJ_Spec.dds";
 
   rimIntensity = 1;    
};

singleton Material(MehK_I)
{
   mapTo = "MehK_I";
   diffuseMap[0] = "art/TexturesSH/Construction/Furniture/MehK_I/MehK_I_Dif.dds";
   diffuseMap[1] = "art/TexturesSH/Construction/Furniture/MehK_I/MehK_I_Norm.dds";
   diffuseMap[2] = "art/TexturesSH/Construction/Furniture/MehK_I/MehK_I_Spec.dds";

    rimIntensity = 1;    
};

singleton Material(MehK_L)
{
   mapTo = "MehK_L";
   diffuseMap[0] = "art/TexturesSH/Construction/Furniture/MehK_L/MehK_L_Dif.dds";
   diffuseMap[1] = "art/TexturesSH/Construction/Furniture/MehK_L/MehK_L_Norm.dds";
   diffuseMap[2] = "art/TexturesSH/Construction/Furniture/MehK_L/MehK_L_Spec.dds";

   rimIntensity = 1;    
};

singleton Material(MehK_T)
{
   mapTo = "MehK_T";
   diffuseMap[0] = "art/TexturesSH/Construction/Furniture/MehK_T/MehK_T_Dif.dds";
   diffuseMap[1] = "art/TexturesSH/Construction/Furniture/MehK_T/MehK_T_Norm.dds";
   diffuseMap[2] = "art/TexturesSH/Construction/Furniture/MehK_T/MehK_T_Spec.dds";

    rimIntensity = 1;    
};

singleton Material(MehL)
{
   mapTo = "MehL";
   diffuseMap[0] = "art/TexturesSH/Construction/Furniture/MehL/MehL_Dif.dds";
   diffuseMap[1] = "art/TexturesSH/Construction/Furniture/MehL/MehL_Norm.dds";
   diffuseMap[2] = "art/TexturesSH/Construction/Furniture/MehL/MehL_Spec.dds";

   rimIntensity = 1;    
};

singleton Material(MZS)
{
   mapTo = "MZS";
   diffuseMap[0] = "art/TexturesSH/Construction/Furniture/MZS/MZS_Dis.dds";
   diffuseMap[1] = "art/TexturesSH/Construction/Furniture/MZS/MZS_Norm.dds";
   diffuseMap[2] = "art/TexturesSH/Construction/Furniture/MZS/MZS_Spek.dds";

    rimIntensity = 1;    
};
singleton Material(OvenA)
{
   mapTo = "OvenA";
   diffuseMap[0] = "art/TexturesSH/Construction/Furniture/OvenA/OvenA_Dif.dds";
   diffuseMap[1] = "art/TexturesSH/Construction/Furniture/OvenA/Oven_A_Norm.dds";
   diffuseMap[2] = "art/TexturesSH/Construction/Furniture/OvenA/OvenA_Spec.dds";
 
    rimIntensity = 1;    
};

singleton Material(OvenB)
{
   mapTo = "OvenB";
   diffuseMap[0] = "art/TexturesSH/Construction/Furniture/OvenB/OverB_Dif.dds";
   diffuseMap[1] = "art/TexturesSH/Construction/Furniture/OvenB/OverB_Norm.dds";
   diffuseMap[2] = "art/TexturesSH/Construction/Furniture/OvenB/OverB_Spec.dds";
 
     rimIntensity = 1;    
};

singleton Material(OvenB_Fire)
{
   mapTo = "OvenB_Fire";
   diffuseMap[0] = "art/TexturesSH/Construction/Furniture/OvenB/Fire.dds";
   materialTag0 = "LiF";
    
     rimIntensity = 1;    
};
singleton Material(PhotoCam_color_map)
{
   mapTo = "PhotoCam_color_map";
   diffuseMap[0] = "art/TexturesSH/Construction/Furniture/PhotoCam/PhotoCam_color_map.dds";
   diffuseMap[1] = "art/TexturesSH/Construction/Furniture/PhotoCam/PhotoCam_Normal_map.dds";
   diffuseMap[2] = "art/TexturesSH/Construction/Furniture/PhotoCam/PhotoCam_Specular_Map.dds";

  rimIntensity = 1;    
};
singleton Material(Teleskope_Teleskop_COLOR)
{
   mapTo = "Teleskop_COLOR";
   diffuseMap[0] = "art/TexturesSH/Construction/Furniture/Teleskope/Teleskop_COLOR.dds";
   diffuseMap[1] = "art/TexturesSH/Construction/Furniture/Teleskope/Teleskop_Normal.dds";
   diffuseMap[2] = "art/TexturesSH/Construction/Furniture/Teleskope/Teleskop_Specular Map.dds";
  
    rimIntensity = 1;    
};

singleton Material(Wash_basin_mat)
{
   mapTo = "Wash_basin";
   diffuseMap[0] = "art/TexturesSH/Construction/Furniture/Wash_basin/Wash_Dif.dds";
   diffuseMap[1] = "art/TexturesSH/Construction/Furniture/Wash_basin/Wash_norm.dds";
   diffuseMap[2] = "art/TexturesSH/Construction/Furniture/Wash_basin/Wash_Spec.dds";

     rimIntensity = 1;    
};
//------------------------------------------------------>>>>>PROPS<<<<<<----------------
//-----------------------------------LittleSmithy-------

singleton Material(LittleSmithy_diff_mat)
{
   mapTo = "LittleSmithy_diff";
   diffuseMap[0] = "art/TexturesSH/Props/LittleSmithy/LittleSmithy_diff.dds";
   diffuseMap[1] = "art/TexturesSH/Props/LittleSmithy/LittleSmithy_normal.dds";
   diffuseMap[2] = "art/TexturesSH/Props/LittleSmithy/LittleSmithy_Spec.dds";
};
//--
singleton Material(F_LittleSmithy_diff_mat)
{
   mapTo = "F_LittleSmithy_diff";
   diffuseMap[0] = "art/TexturesSH/Props/LittleSmithy/LittleSmithy_diff.dds";
   diffuseMap[1] = "art/TexturesSH/Props/LittleSmithy/LittleSmithy_normal.dds";
   diffuseMap[2] = "art/TexturesSH/Props/LittleSmithy/LittleSmithy_Spec.dds";
   shader = "DefaultShaderData";
   stateBlock = "DefaultStateBlockData";
   useCustomColor = "1";
   diffuseColor[0] = "0.176471 0.176471 0.172549 0.29";
};
//-----------------------------------Leather_weaving_machine_Diff-------

singleton Material(leather_weaving_machine_Diff_mat)
{
   mapTo = "leather_weaving_machine_Diff";
   diffuseMap[0] = "art/TexturesSH/Props/leather_weaving_machine/leather_weaving_machine_Diff.dds";
   diffuseMap[1] = "art/TexturesSH/Props/leather_weaving_machine/leather_weaving_machine_Norm.dds";
   diffuseMap[2] = "art/TexturesSH/Props/leather_weaving_machine/leather_weaving_machine_SPEC.dds";
};
//--
singleton Material(F_leather_weaving_machine_Diff_mat)
{
   mapTo = "F_leather_weaving_machine_Diff";
   diffuseMap[0] = "art/TexturesSH/Props/leather_weaving_machine/leather_weaving_machine_Diff.dds";
   diffuseMap[1] = "art/TexturesSH/Props/leather_weaving_machine/leather_weaving_machine_Norm.dds";
   diffuseMap[2] = "art/TexturesSH/Props/leather_weaving_machine/leather_weaving_machine_SPEC.dds";
shader = "DefaultShaderData";
   stateBlock = "DefaultStateBlockData";
   useCustomColor = "1";
   diffuseColor[0] = "0.176471 0.176471 0.172549 0.29";
};

//-----------------------------------Small_foundry_tehnokrats-------

singleton Material(small_foundry_tehnokrats_lowpoly_diff_mat)
{
   mapTo = "small_foundry_tehnokrats_lowpoly_diff";
   
   diffuseMap[0] = "art/TexturesSH/Construction/Factory/Small_foundry_tehnokrats/small_foundry_tehnokrats_lowpoly_diff.dds";
   diffuseMap[1] = "art/TexturesSH/Construction/Factory/Small_foundry_tehnokrats/small_foundry_tehnokrats_lowpoly_nmap.dds";
   diffuseMap[2] = "art/TexturesSH/Construction/Factory/Small_foundry_tehnokrats/small_foundry_tehnokrats_lowpoly_SPEC.dds";

};
//--
singleton Material(F_small_foundry_tehnokrats_lowpoly_diff_mat)
{
   mapTo = "F_small_foundry_tehnokrats_lowpoly_diff";
   
   diffuseMap[0] = "art/TexturesSH/Construction/Factory/Small_foundry_tehnokrats/small_foundry_tehnokrats_lowpoly_diff.dds";
   diffuseMap[1] = "art/TexturesSH/Construction/Factory/Small_foundry_tehnokrats/small_foundry_tehnokrats_lowpoly_nmap.dds";
   diffuseMap[2] = "art/TexturesSH/Construction/Factory/Small_foundry_tehnokrats/small_foundry_tehnokrats_lowpoly_SPEC.dds";
shader = "DefaultShaderData";
   stateBlock = "DefaultStateBlockData";
   useCustomColor = "1";
   diffuseColor[0] = "0.176471 0.176471 0.172549 0.29";
};
//-----------------------------------carpenters_table_technokrats_lowpoly-------

singleton Material(carpenters_table_technokrats_lowpoly_Diff_mat)
{
   mapTo = "carpenters_table_technokrats_lowpoly_Diff";
   
   diffuseMap[0] = "art/TexturesSH/Props/Carpenters_table_technokrats/carpenters_table_technokrats_lowpoly_Diff.dds";
   diffuseMap[1] = "art/TexturesSH/Props/Carpenters_table_technokrats/carpenters_table_technokrats_lowpoly_Norm.dds";
   diffuseMap[2] = "art/TexturesSH/Props/Carpenters_table_technokrats/carpenters_table_technokrats_lowpoly_Spec.dds";
};
//--
singleton Material(F_carpenters_table_technokrats_lowpoly_Diff_mat)
{
   mapTo = "F_carpenters_table_technokrats_lowpoly_Diff";
   
   diffuseMap[0] = "art/TexturesSH/Props/Carpenters_table_technokrats/carpenters_table_technokrats_lowpoly_Diff.dds";
   diffuseMap[1] = "art/TexturesSH/Props/Carpenters_table_technokrats/carpenters_table_technokrats_lowpoly_Norm.dds";
   diffuseMap[2] = "art/TexturesSH/Props/Carpenters_table_technokrats/carpenters_table_technokrats_lowpoly_Spec.dds";
shader = "DefaultShaderData";
   stateBlock = "DefaultStateBlockData";
   useCustomColor = "1";
   diffuseColor[0] = "0.176471 0.176471 0.172549 0.29";
};
//-----------------------------------SteamHammer-------

singleton Material(MainPart_diff_mat)
{
   mapTo = "MainPart_diff";
   
   diffuseMap[0] = "art/TexturesSH/Construction/Factory/TCForge/SteamHammer/MainPart_diff.dds";
   diffuseMap[1] = "art/TexturesSH/Construction/Factory/TCForge/SteamHammer/MainPart_normal.dds";
   diffuseMap[2] = "art/TexturesSH/Construction/Factory/TCForge/SteamHammer/MainPart_metal.dds";

};

singleton Material(LowDetails_diff_mat)
{
   mapTo = "LowDetails_diff";
   diffuseMap[0] = "art/TexturesSH/Construction/Factory/TCForge/SteamHammer/LowDetails_diff.dds";
   diffuseMap[1] = "art/TexturesSH/Construction/Factory/TCForge/SteamHammer/LowDetails_normal.dds";
   diffuseMap[2] = "art/TexturesSH/Construction/Factory/TCForge/SteamHammer/LowDetails_metal.dds";

};
singleton Material(MainPanel_diff_mat)
{
   mapTo = "MainPanel_diff";
   diffuseMap[0] = "art/TexturesSH/Construction/Factory/TCForge/SteamHammer/MainPanel_diff.dds";
   diffuseMap[1] = "art/TexturesSH/Construction/Factory/TCForge/SteamHammer/MainPanel_normal.dds";
   diffuseMap[2] = "art/TexturesSH/Construction/Factory/TCForge/SteamHammer/MainPanel_metal.dds";
};
singleton Material(StairsPart_diff_mat)
{
   mapTo = "StairsPart_diff";
   diffuseMap[0] = "art/TexturesSH/Construction/Factory/TCForge/SteamHammer/StairsPart_diff.dds";
   diffuseMap[1] = "art/TexturesSH/Construction/Factory/TCForge/SteamHammer/StairsPart_normal.dds";
   diffuseMap[2] = "art/TexturesSH/Construction/Factory/TCForge/SteamHammer/StairsPart_metal.dds";
};
//---------------------------------------------------------------------------------------------------------------
//-----------------------------------Engineering_technocrats_smithy----------------
singleton Material(Engineering_technocrats_smithy_dif_mat)
{
   mapTo = "Engineering_technocrats_smithy_dif";
   diffuseMap[0] = "art/TexturesSH/Props/Engineering_technocrats_smithy/Engineering_technocrats_smithy_dif.dds"; 
   diffuseMap[1] = "art/TexturesSH/Props/Engineering_technocrats_smithy/Engineering_technocrats_smithy_norm.dds";
   diffuseMap[2] = "art/TexturesSH/Props/Engineering_technocrats_smithy/Engineering_technocrats_smithy_spec.dds"; 
};
//-----------------------------------engineering_machine_paromags----------------
singleton Material(engineering_machine_paromags_Diff_mat)
{
   mapTo = "engineering_machine_paromags_Diff";
   diffuseMap[0] = "art/TexturesSH/Props/engineering_machine_paromags/engineering_machine_paromags_Diff.dds"; 
   diffuseMap[1] = "art/TexturesSH/Props/engineering_machine_paromags/engineering_machine_paromags_Norm.dds";
   diffuseMap[2] = "art/TexturesSH/Props/engineering_machine_paromags/engineering_machine_paromags_SPEC.dds"; 
};
//-----------------------------------carpenter's table_paromags----------------
singleton Material(carpenters_table_paromags_Diff_mat)
{
   mapTo = "carpenters_table_paromags_Diff";
   diffuseMap[0] = "art/TexturesSH/Props/carpenters_table_paromags/carpenters_table_paromags_Diff.dds"; 
   diffuseMap[1] = "art/TexturesSH/Props/carpenters_table_paromags/carpenters_table_paromags_Norm.dds";
   diffuseMap[2] = "art/TexturesSH/Props/carpenters_table_paromags/carpenters_table_paromags_SPEC.dds"; 
};
//-----------------------------------small_stampings_paromags----------------
singleton Material(small_stampings_paromags_Diff_mat)
{
   mapTo = "small_stampings_paromags_Diff";
   diffuseMap[0] = "art/TexturesSH/Props/small_stampings_paromags/small_stampings_paromags_Diff.dds"; 
   diffuseMap[1] = "art/TexturesSH/Props/small_stampings_paromags/small_stampings_paromags_Norm.dds";
   diffuseMap[2] = "art/TexturesSH/Props/small_stampings_paromags/small_stampings_paromags_SPEC.dds"; 
};
//-----------------------------------smallEngeneeringTech----------------
singleton Material(SmallEngeneeringTech_diff_mat)
{
   mapTo = "SmallEngeneeringTech_diff";
   diffuseMap[0] = "art/TexturesSH/Props/smallEngeneeringTech/SmallEngeneeringTech_diff.dds"; 
   diffuseMap[1] = "art/TexturesSH/Props/smallEngeneeringTech/SmallEngeneeringTech_normal.dds";
   diffuseMap[2] = "art/TexturesSH/Props/smallEngeneeringTech/SmallEngeneeringTech_Spec.dds"; 
};
//--
singleton Material(F_SmallEngeneeringTech_diff_mat)
{
   mapTo = "F_SmallEngeneeringTech_diff";
   diffuseMap[0] = "art/TexturesSH/Props/smallEngeneeringTech/SmallEngeneeringTech_diff.dds"; 
   diffuseMap[1] = "art/TexturesSH/Props/smallEngeneeringTech/SmallEngeneeringTech_normal.dds";
   diffuseMap[2] = "art/TexturesSH/Props/smallEngeneeringTech/SmallEngeneeringTech_Spec.dds"; 
   shader = "DefaultShaderData";
   stateBlock = "DefaultStateBlockData";
   useCustomColor = "1";
   diffuseColor[0] = "0.176471 0.176471 0.172549 0.29";
};
//-----------------------------------boiler----------------
singleton Material(boiler_diff_mat)
{
   mapTo = "boiler_diff";
   diffuseMap[0] = "art/TexturesSH/Props/boiler/boiler_diff.dds"; 
   diffuseMap[1] = "art/TexturesSH/Props/boiler/boiler_normal.dds";
   diffuseMap[2] = "art/TexturesSH/Props/boiler/boiler_spec.dds";
};
//-----------------------------------Carpenter_technocrats----------------
singleton Material(carpenter_ground_dif_mat)
{
   mapTo = "carpenter_ground_dif";
   diffuseMap[0] = "art/TexturesSH/Props/Carpenter technocrats/carpenter_ground/carpenter_ground_dif.dds"; 
   diffuseMap[1] = "art/TexturesSH/Props/Carpenter technocrats/carpenter_ground/carpenter_ground_norm.dds";
   diffuseMap[2] = "art/TexturesSH/Props/Carpenter technocrats/carpenter_ground/carpenter_ground_spec.dds"; 
};
singleton Material(carpenter_mehan_dif_mat)
{
   mapTo = "carpenter_mehan_dif";
   diffuseMap[0] = "art/TexturesSH/Props/Carpenter technocrats/carpenter_mehan/carpenter_mehan_dif.dds";
   diffuseMap[1] = "art/TexturesSH/Props/Carpenter technocrats/carpenter_mehan/carpenter_mehan_norm.dds";
   diffuseMap[2] = "art/TexturesSH/Props/Carpenter technocrats/carpenter_mehan/carpenter_mehan_spec.dds";
};
singleton Material(carpenter_wall_dif_mat)
{
   mapTo = "carpenter_wall_dif";
   diffuseMap[0] = "art/TexturesSH/Props/Carpenter technocrats/carpenter_wall/carpenter_wall_dif.dds";
   diffuseMap[1] = "art/TexturesSH/Props/Carpenter technocrats/carpenter_wall/carpenter_wall_norm.dds";
   diffuseMap[2] = "art/TexturesSH/Props/Carpenter technocrats/carpenter_wall/carpenter_wall_spec.dds";  
};
//-----------------------------------Sawmill----------------
singleton Material(baked_ambient_base_and_Details_diff_hardsurface_details_mat)
{
   mapTo = "baked_ambient_base_and_Details_diff_hardsurface_details";
   diffuseMap[0] = "art/TexturesSH/Props/Sawmill/baked_ambient_base_and_Details_diff_hardsurface_details.dds";
   diffuseMap[1] = "art/TexturesSH/Props/Sawmill/baked_ambient_base_and_Details_normal_hardsurface_details.dds";
   diffuseMap[2] = "art/TexturesSH/Props/Sawmill/baked_ambient_base_and_Details_SPEC_hardsurface_details.dds";   
};
singleton Material(baked_ambient_base_and_Details_diff_hardsurface_base_mat)
{
   mapTo = "baked_ambient_base_and_Details_diff_hardsurface_base";
   diffuseMap[0] = "art/TexturesSH/Props/Sawmill/baked_ambient_base_and_Details_diff_hardsurface_base.dds";
   diffuseMap[1] = "art/TexturesSH/Props/Sawmill/baked_ambient_base_and_Details_normal_hardsurface_base.dds";
   diffuseMap[2] = "art/TexturesSH/Props/Sawmill/baked_ambient_base_and_Details_gloss_hardsurface_base.dds";    
};
singleton Material(baked_ambient_organic_saw_diff_mat)
{
   mapTo = "baked_ambient_organic_saw_diff";
   diffuseMap[0] = "art/TexturesSH/Props/Sawmill/baked_ambient_organic_saw_diff.dds";
   diffuseMap[1] = "art/TexturesSH/Props/Sawmill/baked_ambient_organic_saw_normal.dds";
   diffuseMap[2] = "art/TexturesSH/Props/Sawmill/baked_ambient_organic_saw_SPEC.dds";
};
singleton Material(baked_ambient_organic_slime_diff_organic_slime_A_mat)
{
   mapTo = "baked_ambient_organic_slime_diff_organic_slime_A";
   diffuseMap[0] = "art/TexturesSH/Props/Sawmill/baked_ambient_organic_slime_diff_organic_slime_a.dds";
   diffuseMap[1] = "art/TexturesSH/Props/Sawmill/baked_ambient_organic_slime_normal_organic_slime_1.dds";
   diffuseMap[2] = "art/TexturesSH/Props/Sawmill/baked_ambient_organic_slime_SPEC_organic_slime_1.dds";   
};
//----------------------------------workshop_paromagy----------------

singleton Material(Workshop_colorB_mat)
{
   mapTo = "Workshop_colorB";
   diffuseMap[0] = "art/TexturesSH/Props/workshop_paromagy/workshop_colorb.dds";
   diffuseMap[1] = "art/TexturesSH/Props/workshop_paromagy/workshop_paromags_2_nmap.dds";
   diffuseMap[2] = "art/TexturesSH/Props/workshop_paromagy/workshop_paromags_2_SPEC.dds";
};

singleton Material(Workshop_colorA_mat)
{
   mapTo = "Workshop_colorA";
   diffuseMap[0] = "art/TexturesSH/Props/workshop_paromagy/workshop_colora.dds";
   diffuseMap[1] = "art/TexturesSH/Props/workshop_paromagy/workshop_paromags_1_nmap.dds";
   diffuseMap[2] = "art/TexturesSH/Props/workshop_paromagy/workshop_paromags_1_SPEC.dds";
};

singleton Material(Workshop_colorC_mat)
{
   mapTo = "Workshop_colorC";
   diffuseMap[0] = "art/TexturesSH/Props/workshop_paromagy/workshop_colorc.dds";
   diffuseMap[1] = "art/TexturesSH/Props/workshop_paromagy/workshop_paromags_3_nmap.dds";
   diffuseMap[2] = "art/TexturesSH/Props/workshop_paromagy/workshop_paromags_3_SPEC.dds";
};
  //----------------------------------foundry_Teh---------------
singleton Material(Centr_Dif_mat)
{
   mapTo = "Centr_Dif";
   diffuseMap[0] = "art/TexturesSH/Props/Foundry_Par/Centr/Centr_Dif.dds";
   diffuseMap[1] = "art/TexturesSH/Props/Foundry_Par/Centr/Centr_Norm.dds";
   diffuseMap[2] = "art/TexturesSH/Props/Foundry_Par/Centr/Centr_Spec.dds";  
};
  //----------------------------------foundry_Teh---------------
singleton Material(Centr_Dif_mat)
{
   mapTo = "Centr_Dif";
   diffuseMap[0] = "art/TexturesSH/Props/Foundry_Par/flask_Dif.dds";
   diffuseMap[1] = "art/TexturesSH/Props/Foundry_Par/flask_Norm.dds";
   diffuseMap[2] = "art/TexturesSH/Props/Foundry_Par/flask_Spec.dds"; 
};
  //----------------------------------foundry_teh---------------
singleton Material(foundry_technocrats_dif_mat)
{
   mapTo = "foundry_technocrats_dif";
   diffuseMap[0] = "art/TexturesSH/Props/foundry_teh/foundry_technocrats_dif.dds";
   diffuseMap[1] = "art/TexturesSH/Props/foundry_teh/foundry_technocrats_norm.dds";
   diffuseMap[2] = "art/TexturesSH/Props/foundry_teh/foundry_technocrats_SPEC.dds";   
};

singleton Material(dop_foundry_machinen_diff_mat)
{
   mapTo = "dop_foundry_machinen_diff";
   diffuseMap[0] = "art/TexturesSH/Props/foundry_teh/dop_foundry_machinen_diff.dds";
   diffuseMap[1] = "art/TexturesSH/Props/foundry_teh/dop_foundry_machinen_normal.dds";
   diffuseMap[2] = "art/TexturesSH/Props/foundry_teh/dop_foundry_machinen_spec.dds";   
};
  //----------------------------------alchemy_lab_tehno----------------
singleton Material(alchemy_lab_diff_mat)
{
   mapTo = "alchemy_lab_diff";
   diffuseMap[0] = "art/TexturesSH/Props/alchemy_lab_tehno/alchemy_lab_diff.dds";
   diffuseMap[1] = "art/TexturesSH/Props/alchemy_lab_tehno/alchemy_lab_normal.dds";   
   diffuseMap[2] = "art/TexturesSH/Props/alchemy_lab_tehno/alchemy_lab_spec.dds"; 
};

//----------------------------------alchemy_lab_paromags----------------
singleton Material(alchemy_lab_paromags_1_color_mat)
{
   mapTo = "alchemy_lab_paromags_1_color";
   diffuseMap[0] = "art/TexturesSH/Props/alchemy_lab_paromags/alchemy_lab_paromags_1_color.dds";
   diffuseMap[1] = "art/TexturesSH/Props/alchemy_lab_paromags/alchemy_lab_mehan/alchemy_lab_paromags_1_nmap.dds";
   diffuseMap[2] = "art/TexturesSH/Props/alchemy_lab_paromags/alchemy_lab_mehan/alchemy_lab_paromags_1_SPEC.dds";  
};
singleton Material(alchemy_lab_paromags_2_color_mat)
{
   mapTo = "alchemy_lab_paromags_2_color";
   diffuseMap[0] = "art/TexturesSH/Props/alchemy_lab_paromags/alchemy_lab_paromags_2_color.dds";
   diffuseMap[1] = "art/TexturesSH/Props/alchemy_lab_paromags/alchemy_lab_mehan/alchemy_lab_paromags_2_nmap.dds";
   diffuseMap[2] = "art/TexturesSH/Props/alchemy_lab_paromags/alchemy_lab_mehan/alchemy_lab_paromags_2_SPEC.dds";
};
//----------------------------------------------Ruins----------------
singleton Material(mortar_Diffuse_mat)
{
   mapTo = "mortar_Diffuse";
   diffuseMap[0] = "art/TexturesSH/Environment/mortar/mortar_Diffuse.dds";
   diffuseMap[1] = "art/TexturesSH/Environment/mortar/mortar_Normal.dds";
};
//----------------------------------------------SupportBeams----------------

singleton Material(felling_02_diff_mat)
{
   mapTo = "felling_02_diff";
   diffuseMap[0] = "art/TexturesSH/Environment/SupportBeams/felling_02_diff.dds";
   diffuseMap[1] = "art/TexturesSH/Environment/SupportBeams/felling_02_nm.dds";
};
singleton Material(wood_diffuce_01_mat)
{
   mapTo = "wood_diffuce_01";
   diffuseMap[0] = "art/TexturesSH/Environment/SupportBeams/wood_diffuce_01.dds";
   diffuseMap[1] = "art/TexturesSH/Environment/SupportBeams/wood_normal_01.dds";
};





//----------------------------------------------Ruins----------------
singleton Material(R_Default_dif_mat)
{
   mapTo = "R_Default_dif";
   diffuseMap[0] = "art/TexturesSH/Environment/Ruins/R_Default_dif.dds";
   diffuseMap[1] = "art/TexturesSH/Environment/Ruins/Trap_Norm.dds";
};
//----------------------------------------------hammer_monument----------------
singleton Material(hammer_monument_Diff_mat)
{
   mapTo = "hammer_monument_Diff";
   diffuseMap[0] = "art/TexturesSH/Environment/monument/hammer_monument_Diff.dds";
   diffuseMap[1] = "art/TexturesSH/Environment/monument/hammer_monument_Norm.dds";
   diffuseMap[2] = "art/TexturesSH/Environment/monument/hammer_monument_SPEC.dds";
};
singleton Material(saber_monument_Diff_mat)
{
   mapTo = "saber_monument_Diff";
   diffuseMap[0] = "art/TexturesSH/Environment/monument/saber_monument_Diff.dds";
   diffuseMap[1] = "art/TexturesSH/Environment/monument/saber_monument_Norm.dds";
   diffuseMap[2] = "art/TexturesSH/Environment/monument/saber_monument_SPEC.dds";
};
//----------------------------------workshop_technokraty----------------

singleton Material(workshop_technokrat_1_color_mat)
{
   mapTo = "workshop_technokrat_1_color";
   diffuseMap[0] = "art/TexturesSH/Props/workshop_technokraty/workshop_technokrat_1_color.dds";
   diffuseMap[1] = "art/TexturesSH/Props/workshop_technokraty/workshop_technokrat_1_nmap.dds";
   diffuseMap[2] = "art/TexturesSH/Props/workshop_technokraty/workshop_technokrat_1_SPEC.dds";
};

singleton Material(workshop_technokrat_2_color_mat)
{
   mapTo = "workshop_technokrat_2_color";
   diffuseMap[0] = "art/TexturesSH/Props/workshop_technokraty/workshop_technokrat_2_color.dds";
   diffuseMap[1] = "art/TexturesSH/Props/workshop_technokraty/workshop_technokrat_2_nmap.dds";
   diffuseMap[2] = "art/TexturesSH/Props/workshop_technokraty/workshop_technokrat_2_SPEC.dds";
};

//----------------------------------------------engineering_machine_paromags----------------
singleton Material(engineering_machine_paromags_Diff_mat)
{
   mapTo = "engineering_machine_paromags_Diff";
   diffuseMap[0] = "art/TexturesSH/Props/engineering_machine_paromags/engineering_machine_paromags_Diff.dds";
   diffuseMap[1] = "art/TexturesSH/Props/engineering_machine_paromags/engineering_machine_paromags_Norm.dds";
   diffuseMap[2] = "art/TexturesSH/Props/engineering_machine_paromags/engineering_machine_paromags_SPEC.dds";
};

//------------------------------------------------------>>>>>BUILDINGS<<<<<<----------------
//-----------------------------------Elevator -------
singleton Material(elevator_diff_mat)
{
   mapTo = "elevator_diff";
   diffuseMap[0] = "art/TexturesSH/Buildings/Elevator/elevator_diff.dds";
   diffuseMap[1] = "art/TexturesSH/Buildings/Elevator/elevator_normal.dds";
   diffuseMap[2] = "art/TexturesSH/Buildings/Elevator/elevator_SPEC.dds";
};
//-----------------------------------Common -------

singleton Material(civil_door_medium_2_hovel_diff_mat)
{
   mapTo = "civil_door_medium_2_hovel_diff";
   diffuseMap[0] = "art/TexturesSH/Buildings/Common/civil_door_medium_2_hovel_diff.dds";
   diffuseMap[1] = "art/TexturesSH/Buildings/Common/civil_door_medium_2_hovel_normal.dds";
   diffuseMap[2] = "art/TexturesSH/Buildings/Common/civil_door_medium_2_hovel_SPEC.dds";
};
singleton Material(civil_floor_1_diff_mat)
{
   mapTo = "civil_floor_1_diff";
   diffuseMap[0] = "art/TexturesSH/Buildings/Common/civil_floor_1_diff.dds";
   diffuseMap[1] = "art/TexturesSH/Buildings/Common/civil_floor_1_normal.dds";
   diffuseMap[2] = "art/TexturesSH/Buildings/Common/civil_floor_1_SPEC.dds";
};
singleton Material(civil_roof_hovel_diff_mat)
{
   mapTo = "civil_roof_hovel_diff";
   diffuseMap[0] = "art/TexturesSH/Buildings/Common/civil_roof_hovel_diff.dds";
   diffuseMap[1] = "art/TexturesSH/Buildings/Common/civil_roof_hovel_normal.dds";
   diffuseMap[2] = "art/TexturesSH/Buildings/Common/civil_roof_hovel_SPEC.dds";
};
singleton Material(civil_windows_medium_2_hovel_diff_mat)
{
   mapTo = "civil_windows_medium_2_hovel_diff";
   diffuseMap[0] = "art/TexturesSH/Buildings/Common/civil_windows_medium_2_hovel_diff.dds";
   diffuseMap[1] = "art/TexturesSH/Buildings/Common/civil_windows_medium_2_hovel_normal.dds";
   diffuseMap[2] = "art/TexturesSH/Buildings/Common/civil_windows_medium_2_hovel_SPEC.dds";
};
singleton Material(industrial_bucket_1_diff_mat)
{
   mapTo = "industrial_bucket_1_diff";
   diffuseMap[0] = "art/TexturesSH/Buildings/Common/industrial_bucket_1_diff.dds";
   diffuseMap[1] = "art/TexturesSH/Buildings/Common/industrial_bucket_1_normall.dds";
   diffuseMap[2] = "art/TexturesSH/Buildings/Common/industrial_bucket_1_SPEC.dds";
};
singleton Material(industrial_burrel_1_diff_mat)
{
   mapTo = "industrial_burrel_1_diff";
   diffuseMap[0] = "art/TexturesSH/Buildings/Common/industrial_burrel_1_diff.dds";
   diffuseMap[1] = "art/TexturesSH/Buildings/Common/industrial_burrel_1_normal.dds";
   diffuseMap[2] = "art/TexturesSH/Buildings/Common/industrial_burrel_1_SPEC.dds";
};
singleton Material(industrial_false_door_1_diff_mat)
{
   mapTo = "industrial_false_door_1_diff";
   diffuseMap[0] = "art/TexturesSH/Buildings/Common/industrial_false_door_1_diff.dds";
   diffuseMap[2] = "art/TexturesSH/Buildings/Common/industrial_false_door_1_SPEC.dds";
};
singleton Material(industrial_farm_fence_1_diff_mat)
{
   mapTo = "industrial_farm_fence_1_diff";
   diffuseMap[0] = "art/TexturesSH/Buildings/Common/industrial_farm_fence_1_diff.dds";
   diffuseMap[1] = "art/TexturesSH/Buildings/Common/industrial_farm_fence_1_normal.dds";
   diffuseMap[2] = "art/TexturesSH/Buildings/Common/industrial_farm_fence_1_SPEC.dds";
};
singleton Material(industrial_farm_tool_1_diff_mat)
{
   mapTo = "industrial_farm_tool_1_diff";
   diffuseMap[0] = "art/TexturesSH/Buildings/Common/industrial_farm_tool_1_diff.dds";
   diffuseMap[1] = "art/TexturesSH/Buildings/Common/industrial_farm_tool_1_normal.dds";
   diffuseMap[2] = "art/TexturesSH/Buildings/Common/industrial_farm_tool_1_SPEC.dds";
};
singleton Material(industrial_floor_stone_1_diff_mat)
{
   mapTo = "industrial_floor_stone_1_diff";
   diffuseMap[0] = "art/TexturesSH/Buildings/Common/industrial_floor_stone_1_diff.dds";
   diffuseMap[1] = "art/TexturesSH/Buildings/Common/industrial_floor_stone_1_normal.dds";
};
singleton Material(industrial_floor_stone_1_2_diff_mat)
{
   mapTo = "industrial_floor_stone_1_2_diff";
   diffuseMap[0] = "art/TexturesSH/Buildings/Common/industrial_floor_stone_1_2_diff.dds";
   diffuseMap[1] = "art/TexturesSH/Buildings/Common/industrial_floor_stone_1_normal.dds";
};
singleton Material(industrial_hatch_1_diff_mat)
{
   mapTo = "industrial_hatch_1_diff";
   diffuseMap[0] = "art/TexturesSH/Buildings/Common/industrial_hatch_1_diff.dds";
   diffuseMap[1] = "art/TexturesSH/Buildings/Common/industrial_hatch_1_normal.dds";
   diffuseMap[2] = "art/TexturesSH/Buildings/Common/industrial_hatch_1_SPEC.dds";
};
singleton Material(industrial_pilon_3_diff_mat)
{
   mapTo = "industrial_pilon_3_diff";
   diffuseMap[0] = "art/TexturesSH/Buildings/Common/industrial_pilon_3_diff.dds";
   diffuseMap[1] = "art/TexturesSH/Buildings/Common/industrial_pilon_3_normal.dds";
   diffuseMap[2] = "art/TexturesSH/Buildings/Common/industrial_pilon_3_SPEC.dds";
};
singleton Material(industrial_roof_steam_farm_diff_mat)
{
   mapTo = "industrial_roof_steam_farm_diff";
   diffuseMap[0] = "art/TexturesSH/Buildings/Common/industrial_roof_steam_farm_diff.dds";
   diffuseMap[1] = "art/TexturesSH/Buildings/Common/industrial_roof_steam_farm_normal.dds";
   diffuseMap[2] = "art/TexturesSH/Buildings/Common/industrial_roof_steam_farm_SPEC.dds";
};
singleton Material(industrial_roof_tech_farm_diff_mat)
{
   mapTo = "industrial_roof_tech_farm_diff";
   diffuseMap[0] = "art/TexturesSH/Buildings/Common/industrial_roof_tech_farm_diff.dds";
   diffuseMap[1] = "art/TexturesSH/Buildings/Common/industrial_roof_tech_farm_normal.dds";
   diffuseMap[2] = "art/TexturesSH/Buildings/Common/industrial_roof_tech_farm_SPEC.dds";
};
singleton Material(industrial_socle_4_stone_diff_mat)
{
   mapTo = "industrial_socle_4_stone_diff";
   diffuseMap[0] = "art/TexturesSH/Buildings/Common/industrial_socle_4_stone_diff.dds";
   diffuseMap[1] = "art/TexturesSH/Buildings/Common/industrial_socle_4_stone_normal.dds";
   diffuseMap[2] = "art/TexturesSH/Buildings/Common/industrial_socle_4_stone_SPEC.dds";
};
singleton Material(industrial_straw_box_1_diff_mat)
{
   mapTo = "industrial_straw_box_1_diff";
   diffuseMap[0] = "art/TexturesSH/Buildings/Common/industrial_straw_box_1_diff.dds";
   diffuseMap[1] = "art/TexturesSH/Buildings/Common/industrial_straw_box_1_normal.dds";
   diffuseMap[2] = "art/TexturesSH/Buildings/Common/industrial_straw_box_1_spec.dds";
   doubleSided = "1"; 
   alphaTest = "1";
   alphaRef = "120"; 
};
singleton Material(industrial_trough_1_diff_mat)
{
   mapTo = "industrial_trough_1_diff";
   diffuseMap[0] = "art/TexturesSH/Buildings/Common/industrial_trough_1_diff.dds";
   diffuseMap[1] = "art/TexturesSH/Buildings/Common/industrial_trough_1_normal.dds";
   diffuseMap[2] = "art/TexturesSH/Buildings/Common/industrial_trough_1_SPEC.dds";
};
singleton Material(industrial_trough_2_diff_mat)
{
   mapTo = "industrial_trough_2_diff";
   diffuseMap[0] = "art/TexturesSH/Buildings/Common/industrial_trough_2_diff.dds";
   diffuseMap[1] = "art/TexturesSH/Buildings/Common/industrial_trough_2_normal.dds";
   diffuseMap[2] = "art/TexturesSH/Buildings/Common/industrial_trough_2_SPEC.dds";
};
singleton Material(industrial_vertical_stairs_1_diff_mat)
{
   mapTo = "industrial_vertical_stairs_1_diff";
   diffuseMap[0] = "art/TexturesSH/Buildings/Common/industrial_vertical_stairs_1_diff.dds";
   diffuseMap[2] = "art/TexturesSH/Buildings/Common/industrial_vertical_stairs_1_SPEC.dds";
};
singleton Material(industrial_walls_high_diff_mat)
{
   mapTo = "industrial_walls_high_diff";
   diffuseMap[0] = "art/TexturesSH/Buildings/Common/industrial_walls_high_diff.dds";
   diffuseMap[1] = "art/TexturesSH/Buildings/Common/industrial_walls_high_normal.dds";
   diffuseMap[2] = "art/TexturesSH/Buildings/Common/industrial_walls_high_SPEC.dds";
};
singleton Material(industrial_windows_for_farm_1_diff_mat)
{
   mapTo = "industrial_windows_for_farm_1_diff";
   diffuseMap[0] = "art/TexturesSH/Buildings/Common/industrial_windows_for_farm_1_diff.dds";
   diffuseMap[1] = "art/TexturesSH/Buildings/Common/industrial_windows_for_farm_1_normal.dds";
   diffuseMap[2] = "art/TexturesSH/Buildings/Common/industrial_windows_for_farm_1_SPEC.dds";
};

singleton Material(Wall_diff_mat)
{
   mapTo = "Wall_diff";
   diffuseMap[0] = "art/TexturesSH/Buildings/Common/Wall_diff.dds";
   diffuseMap[1] = "art/TexturesSH/Buildings/Common/Wall_Norm.dds";
};
//-----------------------------------Industrial -------

singleton Material(civil_carpets_1_diff_mat)
{
   mapTo = "civil_carpets_1_diff";
   diffuseMap[0] = "art/TexturesSH/Buildings/Industrial/civil_carpets_1_diff.dds";
   diffuseMap[1] = "art/TexturesSH/Buildings/Industrial/civil_overlaps_plaster_1_normal.dds";

};
singleton Material(civil_cornice_plaster_2_diff_mat)
{
   mapTo = "civil_cornice_plaster_2_diff";
   diffuseMap[0] = "art/TexturesSH/Buildings/Industrial/civil_cornice_plaster_2_diff.dds";
   diffuseMap[1] = "art/TexturesSH/Buildings/Industrial/civil_cornice_plaster_2_normal.dds";
};
singleton Material(civil_curtains_1_diff_mat)
{
   mapTo = "civil_curtains_1_diff";
   diffuseMap[0] = "art/TexturesSH/Buildings/Industrial/civil_curtains_1_diff.dds";
   diffuseMap[1] = "art/TexturesSH/Buildings/Industrial/civil_curtains_1_normal.dds";
   diffuseMap[2] = "art/TexturesSH/Buildings/Industrial/civil_curtains_1_spec.dds";
   doubleSided = "1";
};
singleton Material(civil_socle_plaster_2_diff_mat)
{
   mapTo = "civil_socle_plaster_2_diff";
   diffuseMap[0] = "art/TexturesSH/Buildings/Industrial/civil_socle_plaster_2_diff.dds";
   diffuseMap[1] = "art/TexturesSH/Buildings/Industrial/civil_socle_plaster_2_normal.dds";
};

singleton Material(industrial_socle_2_diff_mat)
{
   mapTo = "industrial_socle_2_diff";
   diffuseMap[0] = "art/TexturesSH/Buildings/Industrial/industrial_socle_2_diff.dds";
   diffuseMap[1] = "art/TexturesSH/Buildings/Industrial/industrial_socle_2_normal.dds";
};
singleton Material(industrial_barrel_4_diff_mat)
{
   mapTo = "industrial_barrel_4_diff";
   diffuseMap[0] = "art/TexturesSH/Buildings/Industrial/industrial_barrel_4_diff.dds";
   diffuseMap[1] = "art/TexturesSH/Buildings/Industrial/industrial_barrel_4_normal.dds";
   diffuseMap[2] = "art/TexturesSH/Buildings/Industrial/industrial_barrel_4_spec.dds";
};
singleton Material(industrial_barrel_3_diff_mat)
{
   mapTo = "industrial_barrel_3_diff";
   diffuseMap[0] = "art/TexturesSH/Buildings/Industrial/industrial_barrel_3_diff.dds";
   diffuseMap[1] = "art/TexturesSH/Buildings/Industrial/industrial_barrel_3_normal.dds";
   diffuseMap[2] = "art/TexturesSH/Buildings/Industrial/industrial_barrel_3_spec.dds";
};
singleton Material(industrial_barrel_2_diff_mat)
{
   mapTo = "industrial_barrel_2_diff";
   diffuseMap[0] = "art/TexturesSH/Buildings/Industrial/industrial_barrel_2_diff.dds";
   diffuseMap[1] = "art/TexturesSH/Buildings/Industrial/industrial_barrel_2_normal.dds";
   diffuseMap[2] = "art/TexturesSH/Buildings/Industrial/industrial_barrel_2_spec.dds";
};
singleton Material(industrial_Barrel_1_diff_mat)
{
   mapTo = "industrial_Barrel_1_diff";
   diffuseMap[0] = "art/TexturesSH/Buildings/Industrial/industrial_Barrel_1_diff.dds";
   diffuseMap[1] = "art/TexturesSH/Buildings/Industrial/industrial_Barrel_1_normal.dds";
   diffuseMap[2] = "art/TexturesSH/Buildings/Industrial/industrial_Barrel_1_spec.dds";
};

singleton Material(industrial_cornice_2_diff_mat)
{
   mapTo = "industrial_cornice_2_diff";
   diffuseMap[0] = "art/TexturesSH/Buildings/Industrial/industrial_cornice_2_diff.dds";
   diffuseMap[1] = "art/TexturesSH/Buildings/Industrial/industrial_cornice_2_normal.dds";
   diffuseMap[2] = "art/TexturesSH/Buildings/Industrial/industrial_cornice_2_spec.dds";
};
singleton Material(industrial_pilaster_3_diff_mat)
{
   mapTo = "industrial_pilaster_3_diff";
   diffuseMap[0] = "art/TexturesSH/Buildings/Industrial/industrial_pilaster_3_diff.dds";
   diffuseMap[1] = "art/TexturesSH/Buildings/Industrial/industrial_pilaster_3_normal.dds";
   diffuseMap[2] = "art/TexturesSH/Buildings/Industrial/industrial_pilaster_3_spec.dds";
};
singleton Material(industrial_roof_tech_foundry_1_diff_mat)
{
   mapTo = "industrial_roof_tech_foundry_1_diff";
   diffuseMap[0] = "art/TexturesSH/Buildings/Industrial/industrial_roof_tech_foundry_1_diff.dds";
   diffuseMap[1] = "art/TexturesSH/Buildings/Industrial/industrial_roof_tech_foundry_1_normal.dds";
   diffuseMap[2] = "art/TexturesSH/Buildings/Industrial/industrial_roof_tech_foundry_1_spec.dds";
};
singleton Material(industrial_roof_tech_foundry_2_diff_mat)
{
   mapTo = "industrial_roof_tech_foundry_2_diff";
   diffuseMap[0] = "art/TexturesSH/Buildings/Industrial/industrial_roof_tech_foundry_2_diff.dds";
   diffuseMap[1] = "art/TexturesSH/Buildings/Industrial/industrial_roof_tech_foundry_2_normal.dds";
   diffuseMap[2] = "art/TexturesSH/Buildings/Industrial/industrial_roof_tech_foundry_2_spec.dds";
};
singleton Material(industrial_socle_3_diff_mat)
{
   mapTo = "industrial_socle_3_diff";
   diffuseMap[0] = "art/TexturesSH/Buildings/Industrial/industrial_socle_3_diff.dds";
   diffuseMap[1] = "art/TexturesSH/Buildings/Industrial/industrial_socle_3_normal.dds";
   diffuseMap[2] = "art/TexturesSH/Buildings/Industrial/industrial_socle_3_spec.dds";
};
singleton Material(decor_arch_2_diff_mat)
{
   mapTo = "decor_arch_2_diff";
   diffuseMap[0] = "art/TexturesSH/Buildings/Industrial/decor_arch_2_diff.dds";
   diffuseMap[1] = "art/TexturesSH/Buildings/Industrial/decor_arch_2_normal.dds";
   diffuseMap[2] = "art/TexturesSH/Buildings/Industrial/decor_arch_2_spec.dds";
};
singleton Material(decor_arch_1_diff_mat)
{
   mapTo = "decor_arch_1_diff";
   diffuseMap[0] = "art/TexturesSH/Buildings/Industrial/decor_arch_1_diff.dds";
   diffuseMap[1] = "art/TexturesSH/Buildings/Industrial/decor_arch_1_normal.dds";
   diffuseMap[2] = "art/TexturesSH/Buildings/Industrial/decor_arch_1_spec.dds";
};
singleton Material(big_industrial_chimney_1_diff_mat)
{
   mapTo = "big_industrial_chimney_1_diff";
   diffuseMap[0] = "art/TexturesSH/Buildings/Industrial/big_industrial_chimney_1_diff.dds";
   diffuseMap[1] = "art/TexturesSH/Buildings/Industrial/big_industrial_chimney_1_normal.dds";
   diffuseMap[2] = "art/TexturesSH/Buildings/Industrial/big_industrial_chimney_1_spec.dds";
};
singleton Material(arh_tube_1_diff_mat)
{
   mapTo = "arh_tube_1_diff";
   diffuseMap[0] = "art/TexturesSH/Buildings/Industrial/arh_tube_1_diff.dds";
   diffuseMap[1] = "art/TexturesSH/Buildings/Industrial/arh_tube_1_normal.dds";
   diffuseMap[2] = "art/TexturesSH/Buildings/Industrial/arh_tube_1_spec.dds";
};

singleton Material(industrial_parapet_bridges_section_inner_1_diff_mat)
{
   mapTo = "industrial_parapet_bridges_section_inner_1_diff";
   diffuseMap[0] = "art/TexturesSH/Buildings/Industrial/industrial_parapet_bridges_section_inner_1_diff.dds";
   diffuseMap[1] = "art/TexturesSH/Buildings/Industrial/industrial_parapet_bridges_section_inner_1_normal.dds";
   diffuseMap[2] = "art/TexturesSH/Buildings/Industrial/industrial_parapet_bridges_section_inner_1_SPEC.dds";
};

singleton Material(civil_balcony_plaster_1_diff_mat)
{
   mapTo = "civil_balcony_plaster_1_diff";
   diffuseMap[0] = "art/TexturesSH/Buildings/Industrial/civil_balcony_plaster_1_diff.dds";
   diffuseMap[1] = "art/TexturesSH/Buildings/Industrial/civil_balcony_plaster_1_normal.dds";
   diffuseMap[2] = "art/TexturesSH/Buildings/Industrial/civil_balcony_plaster_1_SPEC.dds";
};
singleton Material(civil_chimney_1_diff_mat)
{
   mapTo = "civil_chimney_1_diff";
   diffuseMap[0] = "art/TexturesSH/Buildings/Industrial/civil_chimney_1_diff.dds";
   diffuseMap[1] = "art/TexturesSH/Buildings/Industrial/civil_chimney_1_normal.dds";
   diffuseMap[2] = "art/TexturesSH/Buildings/Industrial/civil_chimney_1_SPEC.dds";
};
singleton Material(civil_console_1_diff_mat)
{
   mapTo = "civil_console_1_diff";
   diffuseMap[0] = "art/TexturesSH/Buildings/Industrial/civil_console_1_diff.dds";
   diffuseMap[1] = "art/TexturesSH/Buildings/Industrial/civil_console_1_normal.dds";
   diffuseMap[2] = "art/TexturesSH/Buildings/Industrial/civil_console_1_SPEC.dds";
};
singleton Material(civil_cornice_3_diff_mat)
{
   mapTo = "civil_cornice_3_diff";
   diffuseMap[0] = "art/TexturesSH/Buildings/Industrial/civil_cornice_3_diff.dds";
   diffuseMap[1] = "art/TexturesSH/Buildings/Industrial/civil_cornice_3_normal.dds";
   diffuseMap[2] = "art/TexturesSH/Buildings/Industrial/civil_cornice_3_SPEC.dds";
};
singleton Material(civil_cornice_plaster_2_diff_mat)
{
   mapTo = "civil_cornice_plaster_2_diff";
   diffuseMap[0] = "art/TexturesSH/Buildings/Industrial/civil_cornice_plaster_2_diff.dds";
   diffuseMap[1] = "art/TexturesSH/Buildings/Industrial/civil_cornice_plaster_2_normal.dds";
   diffuseMap[2] = "art/TexturesSH/Buildings/Industrial/civil_cornice_plaster_2_SPEC.dds";
};
singleton Material(civil_door_medium_1_diff_mat)
{
   mapTo = "civil_door_medium_1_diff";
   diffuseMap[0] = "art/TexturesSH/Buildings/Industrial/civil_door_medium_1_diff.dds";
   diffuseMap[1] = "art/TexturesSH/Buildings/Industrial/civil_door_medium_1_normal.dds";
   diffuseMap[2] = "art/TexturesSH/Buildings/Industrial/civil_door_medium_1_SPEC.dds";
};
singleton Material(civil_door_medium_1_jamb_diff_mat)
{
   mapTo = "civil_door_medium_1_jamb_diff";
   diffuseMap[0] = "art/TexturesSH/Buildings/Industrial/civil_door_medium_1_jamb_diff.dds";
   diffuseMap[1] = "art/TexturesSH/Buildings/Industrial/civil_door_medium_1_jamb_normal.dds";
   diffuseMap[2] = "art/TexturesSH/Buildings/Industrial/civil_door_medium_1_jamb_SPEC.dds";
};
singleton Material(civil_dormer_window_1_diff_mat)
{
   mapTo = "civil_dormer_window_1_diff";
   diffuseMap[0] = "art/TexturesSH/Buildings/Industrial/civil_dormer_window_1_diff.dds";
   diffuseMap[1] = "art/TexturesSH/Buildings/Industrial/civil_dormer_window_1_normal.dds";
   diffuseMap[2] = "art/TexturesSH/Buildings/Industrial/civil_dormer_window_1_SPEC.dds";
};
singleton Material(civil_floor_roof_1_diff_mat)
{
   mapTo = "civil_floor_roof_1_diff";
   diffuseMap[0] = "art/TexturesSH/Buildings/Industrial/civil_floor_roof_1_diff.dds";
   diffuseMap[2] = "art/TexturesSH/Buildings/Industrial/civil_floor_roof_1_SPEC.dds";
};
singleton Material(civil_floor_wood_1_diff_mat)
{
   mapTo = "civil_floor_wood_1_diff";
   diffuseMap[0] = "art/TexturesSH/Buildings/Industrial/civil_floor_wood_1_diff.dds";
   diffuseMap[1] = "art/TexturesSH/Buildings/Industrial/civil_floor_wood_1_normal.dds";
   diffuseMap[2] = "art/TexturesSH/Buildings/Industrial/civil_floor_wood_1_SPEC.dds";
};
singleton Material(civil_overlaps_1_diff_mat)
{
   mapTo = "civil_overlaps_1_diff";
   diffuseMap[0] = "art/TexturesSH/Buildings/Industrial/civil_overlaps_1_diff.dds";
   diffuseMap[1] = "art/TexturesSH/Buildings/Industrial/civil_overlaps_1_normal.dds";
   diffuseMap[2] = "art/TexturesSH/Buildings/Industrial/civil_overlaps_1_SPEC.dds";
};
singleton Material(civil_overlaps_plaster_1_diff_mat)
{
   mapTo = "civil_overlaps_plaster_1_diff";
   diffuseMap[0] = "art/TexturesSH/Buildings/Industrial/civil_overlaps_plaster_1_diff.dds";
   diffuseMap[1] = "art/TexturesSH/Buildings/Industrial/civil_overlaps_plaster_1_normal.dds";
   diffuseMap[2] = "art/TexturesSH/Buildings/Industrial/civil_overlaps_plaster_1_SPEC.dds";
};
singleton Material(civil_pilaster_plaster_1_Diff_mat)
{
   mapTo = "civil_pilaster_plaster_1_Diff";
   diffuseMap[0] = "art/TexturesSH/Buildings/Industrial/civil_pilaster_plaster_1_Diff.dds";
   diffuseMap[1] = "art/TexturesSH/Buildings/Industrial/civil_pilaster_plaster_1_normal.dds";
   diffuseMap[2] = "art/TexturesSH/Buildings/Industrial/civil_pilaster_plaster_1_SPEC.dds";
};
singleton Material(civil_pilaster_plaster_3_diff_mat)
{
   mapTo = "civil_pilaster_plaster_3_diff";
   diffuseMap[0] = "art/TexturesSH/Buildings/Industrial/civil_pilaster_plaster_3_diff.dds";
   diffuseMap[1] = "art/TexturesSH/Buildings/Industrial/civil_pilaster_plaster_3_normal.dds";
   diffuseMap[2] = "art/TexturesSH/Buildings/Industrial/civil_pilaster_plaster_3_SPEC.dds";
};
singleton Material(civil_porch_1_plaster_diff_mat)
{
   mapTo = "civil_porch_1_plaster_diff";
   diffuseMap[0] = "art/TexturesSH/Buildings/Industrial/civil_porch_1_plaster_diff.dds";
   diffuseMap[1] = "art/TexturesSH/Buildings/Industrial/civil_porch_1_plaster_normal.dds";
   diffuseMap[2] = "art/TexturesSH/Buildings/Industrial/civil_porch_1_plaster_SPEC.dds";
};
singleton Material(civil_porch_2_diff_mat)
{
   mapTo = "civil_porch_2_diff";
   diffuseMap[0] = "art/TexturesSH/Buildings/Industrial/civil_porch_2_diff.dds";
   diffuseMap[1] = "art/TexturesSH/Buildings/Industrial/civil_porch_2_normal.dds";
   diffuseMap[2] = "art/TexturesSH/Buildings/Industrial/civil_porch_2_SPEC.dds";
};
singleton Material(civil_socle_1_diff_mat)
{
   mapTo = "civil_socle_1_diff";
   diffuseMap[0] = "art/TexturesSH/Buildings/Industrial/civil_socle_1_diff.dds";
   diffuseMap[1] = "art/TexturesSH/Buildings/Industrial/civil_socle_1_normal.dds";
   diffuseMap[2] = "art/TexturesSH/Buildings/Industrial/civil_socle_1_SPEC.dds";
};
singleton Material(civil_socle_plaster_2_diff_mat)
{
   mapTo = "civil_socle_plaster_2_diff";
   diffuseMap[0] = "art/TexturesSH/Buildings/Industrial/civil_socle_plaster_2_diff.dds";
   diffuseMap[1] = "art/TexturesSH/Buildings/Industrial/civil_socle_plaster_2_normal.dds";
   diffuseMap[2] = "art/TexturesSH/Buildings/Industrial/civil_socle_plaster_2_SPEC.dds";
};
singleton Material(civil_walls_wallpaper_1_diff_mat)
{
   mapTo = "civil_walls_wallpaper_1_diff";
   diffuseMap[0] = "art/TexturesSH/Buildings/Industrial/civil_walls_wallpaper_1_diff.dds";
   diffuseMap[2] = "art/TexturesSH/Buildings/Industrial/civil_walls_wallpaper_1_SPEC.dds";
};
singleton Material(civil_window_high_1_diff_mat)
{
   mapTo = "civil_window_high_1_diff";
   diffuseMap[0] = "art/TexturesSH/Buildings/Industrial/civil_window_high_1_diff.dds";
   diffuseMap[1] = "art/TexturesSH/Buildings/Industrial/civil_window_high_1_normal.dds";
   diffuseMap[2] = "art/TexturesSH/Buildings/Industrial/civil_window_high_1_SPEC.dds";
};
singleton Material(Civil_window_medium_1_plaster_diff_mat)
{
   mapTo = "Civil_window_medium_1_plaster_diff";
   diffuseMap[0] = "art/TexturesSH/Buildings/Industrial/Civil_window_medium_1_plaster_diff.dds";
   diffuseMap[1] = "art/TexturesSH/Buildings/Industrial/Civil_window_medium_1_plaster_normal.dds";
   diffuseMap[2] = "art/TexturesSH/Buildings/Industrial/Civil_window_medium_1_plaster_SPEC.dds";
};
singleton Material(ft_civil_base_1_diff_mat)
{
   mapTo = "ft_civil_base_1_diff";
   diffuseMap[0] = "art/TexturesSH/Buildings/Industrial/ft_civil_base_1_diff.dds";
   diffuseMap[1] = "art/TexturesSH/Buildings/Industrial/civil_overlaps_plaster_1_normal.dds";
   diffuseMap[2] = "art/TexturesSH/Buildings/Industrial/ft_civil_base_1_SPEC.dds";
};
singleton Material(ft_industrial_cornice_3__diff_mat)
{
   mapTo = "ft_industrial_cornice_3__diff";
   diffuseMap[0] = "art/TexturesSH/Buildings/Industrial/ft_industrial_cornice_3__diff.dds";
   diffuseMap[1] = "art/TexturesSH/Buildings/Industrial/ft_industrial_cornice_3__normal.dds";
   diffuseMap[2] = "art/TexturesSH/Buildings/Industrial/ft_industrial_cornice_3__SPEC.dds";
};
singleton Material(ft_Industrial_door_big_1_diff_mat)
{
   mapTo = "ft_Industrial_door_big_1_diff";
   diffuseMap[0] = "art/TexturesSH/Buildings/Industrial/ft_Industrial_door_big_1_diff.dds";
   diffuseMap[1] = "art/TexturesSH/Buildings/Industrial/ft_Industrial_door_big_1_normal.dds";
   diffuseMap[2] = "art/TexturesSH/Buildings/Industrial/ft_Industrial_door_big_1_SPEC.dds";
};
singleton Material(ft_Industrial_door_big_jamb_1_diff_mat)
{
   mapTo = "ft_Industrial_door_big_jamb_1_diff";
   diffuseMap[0] = "art/TexturesSH/Buildings/Industrial/ft_Industrial_door_big_jamb_1_diff.dds";
   diffuseMap[1] = "art/TexturesSH/Buildings/Industrial/ft_Industrial_door_big_jamb_1_normal.dds";
   diffuseMap[2] = "art/TexturesSH/Buildings/Industrial/ft_Industrial_door_big_jamb_1_SPEC.dds";

};
singleton Material(ft_industrial_downpipes_down_1_diff_mat)
{
   mapTo = "ft_industrial_downpipes_down_1_diff";
   diffuseMap[0] = "art/TexturesSH/Buildings/Industrial/ft_industrial_downpipes_down_1_diff.dds";
   diffuseMap[1] = "art/TexturesSH/Buildings/Industrial/ft_industrial_downpipes_down_1_normal.dds";
   diffuseMap[2] = "art/TexturesSH/Buildings/Industrial/ft_industrial_downpipes_down_1_SPEC.dds";
};
singleton Material(ft_industrial_downpipes_mid_1_diff_mat)
{
   mapTo = "ft_industrial_downpipes_mid_1_diff";
   diffuseMap[0] = "art/TexturesSH/Buildings/Industrial/ft_industrial_downpipes_mid_1_diff.dds";
   diffuseMap[1] = "art/TexturesSH/Buildings/Industrial/ft_industrial_downpipes_mid_1_normal.dds";
   diffuseMap[2] = "art/TexturesSH/Buildings/Industrial/ft_industrial_downpipes_mid_1_SPEC.dds";
};
singleton Material(ft_industrial_downpipes_up_1_diff_mat)
{
   mapTo = "ft_industrial_downpipes_up_1_diff";
   diffuseMap[0] = "art/TexturesSH/Buildings/Industrial/ft_industrial_downpipes_up_1_diff.dds";
   diffuseMap[1] = "art/TexturesSH/Buildings/Industrial/ft_industrial_downpipes_up_1_normal.dds";
   diffuseMap[2] = "art/TexturesSH/Buildings/Industrial/ft_industrial_downpipes_up_1_SPEC.dds";
};
singleton Material(ft_industrial_fences_1_diff_mat)
{
   mapTo = "ft_industrial_fences_1_diff";
   diffuseMap[0] = "art/TexturesSH/Buildings/Industrial/ft_industrial_fences_1_diff.dds";
   diffuseMap[1] = "art/TexturesSH/Buildings/Industrial/ft_industrial_fences_1_normal.dds";
   diffuseMap[2] = "art/TexturesSH/Buildings/Industrial/ft_industrial_fences_1_SPEC.dds";
};
singleton Material(ft_industrial_floor_1_diff_mat)
{
   mapTo = "ft_industrial_floor_1_diff";
   diffuseMap[0] = "art/TexturesSH/Buildings/Industrial/ft_industrial_floor_1_diff.dds";
   diffuseMap[1] = "art/TexturesSH/Buildings/Industrial/civil_overlaps_plaster_1_normal.dds";
   diffuseMap[2] = "art/TexturesSH/Buildings/Industrial/ft_industrial_floor_1_SPEC.dds";
};
singleton Material(ft_industrial_gas_pipeline_1_diff_mat)
{
   mapTo = "ft_industrial_gas_pipeline_1_diff";
   diffuseMap[0] = "art/TexturesSH/Buildings/Industrial/ft_industrial_gas_pipeline_1_diff.dds";
   diffuseMap[1] = "art/TexturesSH/Buildings/Industrial/ft_industrial_gas_pipeline_1_normal.dds";
   diffuseMap[2] = "art/TexturesSH/Buildings/Industrial/ft_industrial_gas_pipeline_1_SPEC.dds";
};
singleton Material(ft_industrial_girder_1_diff_mat)
{
   mapTo = "ft_industrial_girder_1_diff";
   diffuseMap[0] = "art/TexturesSH/Buildings/Industrial/ft_industrial_girder_1_diff.dds";
   diffuseMap[1] = "art/TexturesSH/Buildings/Industrial/ft_industrial_girder_1_normal.dds";
   diffuseMap[2] = "art/TexturesSH/Buildings/Industrial/ft_industrial_girder_1_SPEC.dds";
};
singleton Material(ft_industrial_lightning_rod_1_diff_mat)
{
   mapTo = "ft_industrial_lightning_rod_1_diff";
   diffuseMap[0] = "art/TexturesSH/Buildings/Industrial/ft_industrial_lightning_rod_1_diff.dds";
   diffuseMap[1] = "art/TexturesSH/Buildings/Industrial/ft_industrial_lightning_rod_1_normal.dds";
   diffuseMap[2] = "art/TexturesSH/Buildings/Industrial/ft_industrial_lightning_rod_1_SPEC.dds";
};
singleton Material(ft_industrial_overlap_1_diff_mat)
{
   mapTo = "ft_industrial_overlap_1_diff";
   diffuseMap[0] = "art/TexturesSH/Buildings/Industrial/ft_industrial_overlap_1_diff.dds";
   diffuseMap[1] = "art/TexturesSH/Buildings/Industrial/ft_industrial_overlap_1_normal.dds";
   diffuseMap[2] = "art/TexturesSH/Buildings/Industrial/ft_industrial_overlap_1_SPEC.dds";
};
singleton Material(ft_industrial_pilaster_1__diff_mat)
{
   mapTo = "ft_industrial_pilaster_1__diff";
   diffuseMap[0] = "art/TexturesSH/Buildings/Industrial/ft_industrial_pilaster_1__diff.dds";
   diffuseMap[1] = "art/TexturesSH/Buildings/Industrial/ft_industrial_pilaster_1__normal.dds";
   diffuseMap[2] = "art/TexturesSH/Buildings/Industrial/ft_industrial_pilaster_1__SPEC.dds";
};
singleton Material(ft_industrial_pilasters_2__diff_mat)
{
   mapTo = "ft_industrial_pilasters_2__diff";
   diffuseMap[0] = "art/TexturesSH/Buildings/Industrial/ft_industrial_pilasters_2__diff.dds";
   diffuseMap[1] = "art/TexturesSH/Buildings/Industrial/ft_industrial_pilasters_2__normal.dds";
   diffuseMap[2] = "art/TexturesSH/Buildings/Industrial/ft_industrial_pilasters_2_SPEC.dds";
};
singleton Material(ft_industrial_pilasters_6_diff_mat)
{
   mapTo = "ft_industrial_pilasters_6_diff";
   diffuseMap[0] = "art/TexturesSH/Buildings/Industrial/ft_industrial_pilasters_6_diff.dds";
   diffuseMap[1] = "art/TexturesSH/Buildings/Industrial/ft_industrial_pilasters_6_normal.dds";
   diffuseMap[2] = "art/TexturesSH/Buildings/Industrial/ft_industrial_pilasters_6_SPEC.dds";
};
singleton Material(ft_industrial_pilon_3_diff_mat)
{
   mapTo = "ft_industrial_pilon_3_diff";
   diffuseMap[0] = "art/TexturesSH/Buildings/Industrial/ft_industrial_pilon_3_diff.dds";
   diffuseMap[1] = "art/TexturesSH/Buildings/Industrial/ft_industrial_pilon_3_normal.dds";
   diffuseMap[2] = "art/TexturesSH/Buildings/Industrial/ft_industrial_pilon_3_SPEC.dds";
};
singleton Material(ft_industrial_pion_1_diff_mat)
{
   mapTo = "ft_industrial_pion_1_diff";
   diffuseMap[0] = "art/TexturesSH/Buildings/Industrial/ft_industrial_pion_1_diff.dds";
   diffuseMap[1] = "art/TexturesSH/Buildings/Industrial/ft_industrial_pion_1_normal.dds";
   diffuseMap[2] = "art/TexturesSH/Buildings/Industrial/ft_industrial_pion_1_SPEC.dds";
};
singleton Material(ft_industrial_plumbing_1_diff_mat)
{
   mapTo = "ft_industrial_plumbing_1_diff";
   diffuseMap[0] = "art/TexturesSH/Buildings/Industrial/ft_industrial_plumbing_1_diff.dds";
   diffuseMap[1] = "art/TexturesSH/Buildings/Industrial/ft_industrial_plumbing_1_normal.dds";
   diffuseMap[2] = "art/TexturesSH/Buildings/Industrial/ft_industrial_plumbing_1_SPEC.dds";
};
singleton Material(ft_industrial_power_cable_1_diff_mat)
{
   mapTo = "ft_industrial_power_cable_1_diff";
   diffuseMap[0] = "art/TexturesSH/Buildings/Industrial/ft_industrial_power_cable_1_diff.dds";
   diffuseMap[1] = "art/TexturesSH/Buildings/Industrial/ft_industrial_power_cable_1_normal.dds";
   diffuseMap[2] = "art/TexturesSH/Buildings/Industrial/ft_industrial_power_cable_1_SPEC.dds";
};
singleton Material(ft_industrial_roof__1_diff_mat)
{
   mapTo = "ft_industrial_roof__1_diff";
   diffuseMap[0] = "art/TexturesSH/Buildings/Industrial/ft_industrial_roof__1_diff.dds";
   diffuseMap[1] = "art/TexturesSH/Buildings/Industrial/ft_industrial_roof__1_normal.dds";
   diffuseMap[2] = "art/TexturesSH/Buildings/Industrial/ft_industrial_roof__1_SPEC.dds";
};
singleton Material(ft_industrial_roof__2_diff_mat)
{
   mapTo = "ft_industrial_roof__2_diff";
   diffuseMap[0] = "art/TexturesSH/Buildings/Industrial/ft_industrial_roof__2_diff.dds";
   diffuseMap[1] = "art/TexturesSH/Buildings/Industrial/ft_industrial_roof__2_normal.dds";
   diffuseMap[2] = "art/TexturesSH/Buildings/Industrial/ft_industrial_roof__2_SPEC.dds";
};
singleton Material(ft_industrial_roof_15_1_diff_mat)
{
   mapTo = "ft_industrial_roof_15_1_diff";
   diffuseMap[0] = "art/TexturesSH/Buildings/Industrial/ft_industrial_roof_15_1_diff.dds";
   diffuseMap[1] = "art/TexturesSH/Buildings/Industrial/ft_industrial_roof_15_1_normal.dds";
   diffuseMap[2] = "art/TexturesSH/Buildings/Industrial/ft_industrial_roof_15_1_SPEC.dds";
};
singleton Material(ft_industrial_socle_1_diff_mat)
{
   mapTo = "ft_industrial_socle_1_diff";
   diffuseMap[0] = "art/TexturesSH/Buildings/Industrial/ft_industrial_socle_1_diff.dds";
   diffuseMap[1] = "art/TexturesSH/Buildings/Industrial/ft_industrial_socle_1_normal.dds";
   diffuseMap[2] = "art/TexturesSH/Buildings/Industrial/ft_industrial_socle_1_SPEC.dds";
};
singleton Material(industrial_socle_2_diff_mat)
{
   mapTo = "industrial_socle_2_diff";
   diffuseMap[0] = "art/TexturesSH/Buildings/Industrial/industrial_socle_2_diff.dds";
   diffuseMap[1] = "art/TexturesSH/Buildings/Industrial/industrial_socle_2_normal.dds";
   diffuseMap[2] = "art/TexturesSH/Buildings/Industrial/industrial_socle_2_SPEC.dds";
};
singleton Material(ft_industrial_socle_4_diff_mat)
{
   mapTo = "ft_industrial_socle_4_diff";
   diffuseMap[0] = "art/TexturesSH/Buildings/Industrial/ft_industrial_socle_4_diff.dds";
   diffuseMap[1] = "art/TexturesSH/Buildings/Industrial/ft_industrial_socle_4_normal.dds";
   
};
singleton Material(ft_Industrial_tube_chimney_1_diff_mat)
{
   mapTo = "ft_Industrial_tube_chimney_1_diff";
   diffuseMap[0] = "art/TexturesSH/Buildings/Industrial/ft_Industrial_tube_chimney_1_diff.dds";
   diffuseMap[1] = "art/TexturesSH/Buildings/Industrial/ft_Industrial_tube_chimney_1_normal.dds";
   diffuseMap[2] = "art/TexturesSH/Buildings/Industrial/ft_Industrial_tube_chimney_1_SPEC.dds";
};
singleton Material(ft_industrial_ventilation_1_diff_mat)
{
   mapTo = "ft_industrial_ventilation_1_diff";
   diffuseMap[0] = "art/TexturesSH/Buildings/Industrial/ft_industrial_ventilation_1_diff.dds";
   diffuseMap[1] = "art/TexturesSH/Buildings/Industrial/ft_industrial_ventilation_1_normal.dds";
   diffuseMap[2] = "art/TexturesSH/Buildings/Industrial/ft_industrial_ventilation_1_SPEC.dds";
};
singleton Material(ft_industrial_ventilation_2_diff_mat)
{
   mapTo = "ft_industrial_ventilation_2_diff";
   diffuseMap[0] = "art/TexturesSH/Buildings/Industrial/ft_industrial_ventilation_2_diff.dds";
   diffuseMap[1] = "art/TexturesSH/Buildings/Industrial/ft_industrial_ventilation_2_normal.dds";
   diffuseMap[2] = "art/TexturesSH/Buildings/Industrial/ft_industrial_ventilation_2_SPEC.dds";
};
singleton Material(ft_industrial_wall_elements_1_diff_mat)
{
   mapTo = "ft_industrial_wall_elements_1_diff";
   diffuseMap[0] = "art/TexturesSH/Buildings/Industrial/ft_industrial_wall_elements_1_diff.dds";
   diffuseMap[1] = "art/TexturesSH/Buildings/Industrial/ft_industrial_wall_elements_1_normal.dds";
   diffuseMap[2] = "art/TexturesSH/Buildings/Industrial/ft_industrial_wall_elements_1_SPEC.dds";
};
singleton Material(ft_industrial_window_big_1_diff_mat)
{
   mapTo = "ft_industrial_window_big_1_diff";
   diffuseMap[0] = "art/TexturesSH/Buildings/Industrial/ft_industrial_window_big_1_diff.dds";
   diffuseMap[1] = "art/TexturesSH/Buildings/Industrial/ft_industrial_window_big_1_normal.dds";
   diffuseMap[2] = "art/TexturesSH/Buildings/Industrial/ft_industrial_window_big_1_SPEC.dds";
};
singleton Material(ft_industrial_window_big_2_diff_mat)
{
   mapTo = "ft_industrial_window_big_2_diff";
   diffuseMap[0] = "art/TexturesSH/Buildings/Industrial/ft_industrial_window_big_2_diff.dds";
   diffuseMap[1] = "art/TexturesSH/Buildings/Industrial/ft_industrial_window_big_2_normal.dds";
   diffuseMap[2] = "art/TexturesSH/Buildings/Industrial/ft_industrial_window_big_2_SPEC.dds";
};
singleton Material(ft_industrial_windows_medium_1_diff_mat)
{
   mapTo = "ft_industrial_windows_medium_1_diff";
   diffuseMap[0] = "art/TexturesSH/Buildings/Industrial/ft_industrial_windows_medium_1_diff.dds";
   diffuseMap[1] = "art/TexturesSH/Buildings/Industrial/ft_industrial_windows_medium_1_normal.dds";
   diffuseMap[2] = "art/TexturesSH/Buildings/Industrial/ft_industrial_windows_medium_1_SPEC.dds";
};
singleton Material(ft_wall_medium_1_diff_mat)
{
   mapTo = "ft_wall_medium_1_diff";
   diffuseMap[0] = "art/TexturesSH/Buildings/Industrial/ft_wall_medium_1_diff.dds";
   diffuseMap[1] = "art/TexturesSH/Buildings/Industrial/ft_wall_medium_1_normal.dds";
   diffuseMap[2] = "art/TexturesSH/Buildings/Industrial/ft_wall_medium_1_SPEC.dds";
};
singleton Material(industria_balcony_industria_balcony_Diff_mat)
{
   mapTo = "industria_balcony_industria_balcony_Diff";
   diffuseMap[0] = "art/TexturesSH/Buildings/Industrial/industria_balcony_industria_balcony_Diff.dds";
   diffuseMap[1] = "art/TexturesSH/Buildings/Industrial/industria_balcony_industria_balcony_Normal.dds";
   diffuseMap[2] = "art/TexturesSH/Buildings/Industrial/industria_balcony_industria_balcony_SPEC.dds";
};
singleton Material(industrial_base_1_diff_mat)
{
   mapTo = "industrial_base_1_diff";
   diffuseMap[0] = "art/TexturesSH/Buildings/Industrial/industrial_base_1_diff.dds";
   diffuseMap[1] = "art/TexturesSH/Buildings/Industrial/industrial_base_1_normal.dds";
 
};
singleton Material(industrial_big_chimney_2_diff_mat)
{
   mapTo = "industrial_big_chimney_2_diff";
   diffuseMap[0] = "art/TexturesSH/Buildings/Industrial/industrial_big_chimney_2_diff.dds";
   diffuseMap[1] = "art/TexturesSH/Buildings/Industrial/industrial_big_chimney_2_normal.dds";
   diffuseMap[2] = "art/TexturesSH/Buildings/Industrial/industrial_big_chimney_2_SPEC.dds";
};
singleton Material(industrial_buttresses_1_diff_mat)
{
   mapTo = "industrial_buttresses_1_diff";
   diffuseMap[0] = "art/TexturesSH/Buildings/Industrial/industrial_buttresses_1_diff.dds";
   diffuseMap[1] = "art/TexturesSH/Buildings/Industrial/industrial_buttresses_1_normal.dds";
   diffuseMap[2] = "art/TexturesSH/Buildings/Industrial/industrial_buttresses_1_SPEC.dds";
};
singleton Material(industrial_cornice_4_diff_mat)
{
   mapTo = "industrial_cornice_4_diff";
   diffuseMap[0] = "art/TexturesSH/Buildings/Industrial/industrial_cornice_4_diff.dds";
   diffuseMap[1] = "art/TexturesSH/Buildings/Industrial/industrial_cornice_4_normal.dds";
   diffuseMap[2] = "art/TexturesSH/Buildings/Industrial/industrial_cornice_4_SPEC.dds";
};
singleton Material(industrial_cornice_dark_stone_1_diff_mat)
{
   mapTo = "industrial_cornice_dark_stone_1_diff";
   diffuseMap[0] = "art/TexturesSH/Buildings/Industrial/industrial_cornice_dark_stone_1_diff.dds";
   diffuseMap[1] = "art/TexturesSH/Buildings/Industrial/industrial_cornice_dark_stone_1_normal.dds";
   diffuseMap[2] = "art/TexturesSH/Buildings/Industrial/industrial_cornice_dark_stone_1_SPEC.dds";
};
singleton Material(Industrial_deflector_1_diff_cupper_mat)
{
   mapTo = "Industrial_deflector_1_diff_cupper";
   diffuseMap[0] = "art/TexturesSH/Buildings/Industrial/Industrial_deflector_1_diff_cupper.dds";
   diffuseMap[1] = "art/TexturesSH/Buildings/Industrial/Industrial_deflector_1_normal_cupper.dds";
   diffuseMap[2] = "art/TexturesSH/Buildings/Industrial/Industrial_deflector_1_SPEC_cupper.dds";
};
singleton Material(industrial_door_big_2_diff_mat)
{
   mapTo = "industrial_door_big_2_diff";
   diffuseMap[0] = "art/TexturesSH/Buildings/Industrial/industrial_door_big_2_diff.dds";
   diffuseMap[1] = "art/TexturesSH/Buildings/Industrial/industrial_door_big_2_normal.dds";
   diffuseMap[2] = "art/TexturesSH/Buildings/Industrial/industrial_door_big_2_SPEC.dds";
};
singleton Material(Industrial_door_medium_jamb_2_diff_mat)
{
   mapTo = "Industrial_door_medium_jamb_2_diff";
   diffuseMap[0] = "art/TexturesSH/Buildings/Industrial/Industrial_door_medium_jamb_2_diff.dds";
   diffuseMap[1] = "art/TexturesSH/Buildings/Industrial/Industrial_door_medium_jamb_2_normal.dds";
   diffuseMap[2] = "art/TexturesSH/Buildings/Industrial/Industrial_door_medium_jamb_2_SPEC.dds";
};
singleton Material(industrial_doors_medium_3_diff_mat)
{
   mapTo = "industrial_doors_medium_3_diff";
   diffuseMap[0] = "art/TexturesSH/Buildings/Industrial/industrial_doors_medium_3_diff.dds";
   diffuseMap[1] = "art/TexturesSH/Buildings/Industrial/industrial_doors_medium_3_normal.dds";
   diffuseMap[2] = "art/TexturesSH/Buildings/Industrial/industrial_doors_medium_3_SPEC.dds";
};
singleton Material(industrial_extension_1_diff_mat)
{
   mapTo = "industrial_extension_1_diff";
   diffuseMap[0] = "art/TexturesSH/Buildings/Industrial/industrial_extension_1_diff.dds";
   diffuseMap[1] = "art/TexturesSH/Buildings/Industrial/industrial_extension_1_normal.dds";
   diffuseMap[2] = "art/TexturesSH/Buildings/Industrial/industrial_extension_1_SPEC.dds";
};
singleton Material(industrial_extension_2_diff_mat)
{
   mapTo = "industrial_extension_2_diff";
   diffuseMap[0] = "art/TexturesSH/Buildings/Industrial/industrial_extension_2_diff.dds";
   diffuseMap[1] = "art/TexturesSH/Buildings/Industrial/industrial_extension_2_normal.dds";
   diffuseMap[2] = "art/TexturesSH/Buildings/Industrial/industrial_extension_2_SPEC.dds";
};
singleton Material(industrial_extension_3_diff_mat)
{
   mapTo = "industrial_extension_3_diff";
   diffuseMap[0] = "art/TexturesSH/Buildings/Industrial/industrial_extension_3_diff.dds";
   diffuseMap[1] = "art/TexturesSH/Buildings/Industrial/industrial_extension_3_normal.dds";
   diffuseMap[2] = "art/TexturesSH/Buildings/Industrial/industrial_extension_3_SPEC.dds";
};
singleton Material(industrial_false_door_2_diff_mat)
{
   mapTo = "industrial_false_door_2_diff";
   diffuseMap[0] = "art/TexturesSH/Buildings/Industrial/industrial_false_door_2_diff.dds";
   diffuseMap[1] = "art/TexturesSH/Buildings/Industrial/industrial_false_door_2_normal.dds";
   diffuseMap[2] = "art/TexturesSH/Buildings/Industrial/industrial_false_door_2_SPEC.dds";
};
singleton Material(industrial_fences_1_diff_mat)
{
   mapTo = "industrial_fences_1_diff";
   diffuseMap[0] = "art/TexturesSH/Buildings/Industrial/industrial_fences_1_diff.dds";
   diffuseMap[1] = "art/TexturesSH/Buildings/Industrial/industrial_fences_1_normal.dds";
   diffuseMap[2] = "art/TexturesSH/Buildings/Industrial/industrial_fences_1_SPEC.dds";
};
singleton Material(industrial_floor_dark_stone_1_diff_mat)
{
   mapTo = "industrial_floor_dark_stone_1_diff";
   diffuseMap[0] = "art/TexturesSH/Buildings/Industrial/industrial_floor_dark_stone_1_diff.dds";
   diffuseMap[1] = "art/TexturesSH/Buildings/Industrial/industrial_floor_dark_stone_1_normal.dds";
   diffuseMap[2] = "art/TexturesSH/Buildings/Industrial/industrial_floor_dark_stone_1_SPEC.dds";
};
singleton Material(industrial_forge_anturage_Diffuse_mat)
{
   mapTo = "industrial_forge_anturage_Diffuse";
   diffuseMap[0] = "art/TexturesSH/Buildings/Industrial/industrial_forge_anturage_Diffuse.dds";
   diffuseMap[1] = "art/TexturesSH/Buildings/Industrial/industrial_forge_anturage_Normal.dds";
   diffuseMap[2] = "art/TexturesSH/Buildings/Industrial/industrial_forge_anturage_SPEC.dds";
};
singleton Material(industrial_forge_couchette_up_Diffuse_mat)
{
   mapTo = "industrial_forge_couchette_up_Diffuse";
   diffuseMap[0] = "art/TexturesSH/Buildings/Industrial/industrial_forge_couchette_up_Diffuse.dds";
   diffuseMap[1] = "art/TexturesSH/Buildings/Industrial/industrial_forge_couchette_up_Normal.dds";
   diffuseMap[2] = "art/TexturesSH/Buildings/Industrial/industrial_forge_couchette_up_SPEC.dds";
};
singleton Material(industrial_forge_crane_Diffuse_mat)
{
   mapTo = "industrial_forge_crane_Diffuse";
   diffuseMap[0] = "art/TexturesSH/Buildings/Industrial/industrial_forge_crane_Diffuse.dds";
   diffuseMap[1] = "art/TexturesSH/Buildings/Industrial/industrial_forge_crane_Normal.dds";
   diffuseMap[2] = "art/TexturesSH/Buildings/Industrial/industrial_forge_crane_SPEC.dds";
};
singleton Material(industrial_forge_down_roof_Diffuse_mat)
{
   mapTo = "industrial_forge_down_roof_Diffuse";
   diffuseMap[0] = "art/TexturesSH/Buildings/Industrial/industrial_forge_down_roof_Diffuse.dds";
   diffuseMap[1] = "art/TexturesSH/Buildings/Industrial/industrial_forge_down_roof_Normal.dds";
   diffuseMap[2] = "art/TexturesSH/Buildings/Industrial/industrial_forge_down_roof_SPEC.dds";
};
singleton Material(industrial_forge_lock_Diffuse_mat)
{
   mapTo = "industrial_forge_lock_Diffuse";
   diffuseMap[0] = "art/TexturesSH/Buildings/Industrial/industrial_forge_lock_Diffuse.dds";
   diffuseMap[1] = "art/TexturesSH/Buildings/Industrial/industrial_forge_lock_Normal.dds";
   diffuseMap[2] = "art/TexturesSH/Buildings/Industrial/industrial_forge_lock_SPEC.dds";
};
singleton Material(industrial_forge_up_cog_Diffuse_mat)
{
   mapTo = "industrial_forge_up_cog_Diffuse";
   diffuseMap[0] = "art/TexturesSH/Buildings/Industrial/industrial_forge_up_cog_Diffuse.dds";
   diffuseMap[1] = "art/TexturesSH/Buildings/Industrial/industrial_forge_up_cog_Normal.dds";
   diffuseMap[2] = "art/TexturesSH/Buildings/Industrial/industrial_forge_up_cog_SPEC.dds";
};
singleton Material(industrial_forge_up_railing_Diffuse_mat)
{
   mapTo = "industrial_forge_up_railing_Diffuse";
   diffuseMap[0] = "art/TexturesSH/Buildings/Industrial/industrial_forge_up_railing_Diffuse.dds";
   diffuseMap[1] = "art/TexturesSH/Buildings/Industrial/industrial_forge_up_railing_Normal.dds";
   diffuseMap[2] = "art/TexturesSH/Buildings/Industrial/industrial_forge_up_railing_SPEC.dds";
};
singleton Material(industrial_forge_up_roofB_Diffuse_mat)
{
   mapTo = "industrial_forge_up_roofB_Diffuse";
   diffuseMap[0] = "art/TexturesSH/Buildings/Industrial/industrial_forge_up_roofB_Diffuse.dds";
   diffuseMap[1] = "art/TexturesSH/Buildings/Industrial/industrial_forge_up_roofB_Normal.dds";
   diffuseMap[2] = "art/TexturesSH/Buildings/Industrial/industrial_forge_up_roofB_SPEC.dds";
};
singleton Material(industrial_forge_up_walls_Diffuse_mat)
{
   mapTo = "industrial_forge_up_walls_Diffuse";
   diffuseMap[0] = "art/TexturesSH/Buildings/Industrial/industrial_forge_up_walls_Diffuse.dds";
   diffuseMap[1] = "art/TexturesSH/Buildings/Industrial/industrial_forge_up_walls_Normal.dds";
   diffuseMap[2] = "art/TexturesSH/Buildings/Industrial/industrial_forge_up_walls_SPEC.dds";
};
singleton Material(industrial_lightning_rod_1_diff_mat)
{
   mapTo = "industrial_lightning_rod_1_diff";
   diffuseMap[0] = "art/TexturesSH/Buildings/Industrial/industrial_lightning_rod_1_diff.dds";
   diffuseMap[1] = "art/TexturesSH/Buildings/Industrial/industrial_lightning_rod_1_normal.dds";
   diffuseMap[2] = "art/TexturesSH/Buildings/Industrial/industrial_lightning_rod_1_SPEC.dds";
};
singleton Material(industrial_pilasters_5_diff_mat)
{
   mapTo = "industrial_pilasters_5_diff";
   diffuseMap[0] = "art/TexturesSH/Buildings/Industrial/industrial_pilasters_5_diff.dds";
   diffuseMap[1] = "art/TexturesSH/Buildings/Industrial/industrial_pilasters_5_normal.dds";
   diffuseMap[2] = "art/TexturesSH/Buildings/Industrial/industrial_pilasters_5_SPEC.dds";
};
singleton Material(industrial_pilasters_7_diff_mat)
{
   mapTo = "industrial_pilasters_7_diff";
   diffuseMap[0] = "art/TexturesSH/Buildings/Industrial/industrial_pilasters_7_diff.dds";
   diffuseMap[1] = "art/TexturesSH/Buildings/Industrial/industrial_pilasters_7_normal.dds";
   diffuseMap[2] = "art/TexturesSH/Buildings/Industrial/industrial_pilasters_7_SPEC.dds";
};
singleton Material(industrial_pilon_4_diff_mat)
{
   mapTo = "industrial_pilon_4_diff";
   diffuseMap[0] = "art/TexturesSH/Buildings/Industrial/industrial_pilon_4_diff.dds";
   diffuseMap[1] = "art/TexturesSH/Buildings/Industrial/industrial_pilon_4_normal.dds";
   diffuseMap[2] = "art/TexturesSH/Buildings/Industrial/industrial_pilon_4_SPEC.dds";
};
singleton Material(industrial_power_cable_1_diff_mat)
{
   mapTo = "industrial_power_cable_1_diff";
   diffuseMap[0] = "art/TexturesSH/Buildings/Industrial/industrial_power_cable_1_diff.dds";
   diffuseMap[1] = "art/TexturesSH/Buildings/Industrial/industrial_power_cable_1_normal.dds";
   diffuseMap[2] = "art/TexturesSH/Buildings/Industrial/industrial_power_cable_1_SPEC.dds";
};
singleton Material(industrial_roof__2_diff_mat)
{
   mapTo = "industrial_roof__2_diff";
   diffuseMap[0] = "art/TexturesSH/Buildings/Industrial/industrial_roof__2_diff.dds";
   diffuseMap[1] = "art/TexturesSH/Buildings/Industrial/industrial_roof__2_normal.dds";
   diffuseMap[2] = "art/TexturesSH/Buildings/Industrial/industrial_roof__2_SPEC.dds";
};
singleton Material(industrial_roof_steam_forge_2_diff_mat)
{
   mapTo = "industrial_roof_steam_forge_2_diff";
   diffuseMap[0] = "art/TexturesSH/Buildings/Industrial/industrial_roof_steam_forge_2_diff.dds";
   diffuseMap[1] = "art/TexturesSH/Buildings/Industrial/industrial_roof_steam_forge_2_normal.dds";
   diffuseMap[2] = "art/TexturesSH/Buildings/Industrial/industrial_roof_steam_forge_2_SPEC.dds";
};
singleton Material(industrial_roof_steam_forge_3_diff_mat)
{
   mapTo = "industrial_roof_steam_forge_3_diff";
   diffuseMap[0] = "art/TexturesSH/Buildings/Industrial/industrial_roof_steam_forge_3_diff.dds";
   diffuseMap[1] = "art/TexturesSH/Buildings/Industrial/industrial_roof_steam_forge_3_normal.dds";
   diffuseMap[2] = "art/TexturesSH/Buildings/Industrial/industrial_roof_steam_forge_3_SPEC.dds";
};
singleton Material(industrial_roof_steam_laboratory_1_diff_mat)
{
   mapTo = "industrial_roof_steam_laboratory_1_diff";
   diffuseMap[0] = "art/TexturesSH/Buildings/Industrial/industrial_roof_steam_laboratory_1_diff.dds";
   diffuseMap[1] = "art/TexturesSH/Buildings/Industrial/industrial_roof_steam_laboratory_1_normal.dds";
   diffuseMap[2] = "art/TexturesSH/Buildings/Industrial/industrial_roof_steam_laboratory_1_SPEC.dds";
};
singleton Material(industrial_roof_steam_laboratory_2_diff_mat)
{
   mapTo = "industrial_roof_steam_laboratory_2_diff";
   diffuseMap[0] = "art/TexturesSH/Buildings/Industrial/industrial_roof_steam_laboratory_2_diff.dds";
   diffuseMap[1] = "art/TexturesSH/Buildings/Industrial/industrial_roof_steam_laboratory_2_normal.dds";
   diffuseMap[2] = "art/TexturesSH/Buildings/Industrial/industrial_roof_steam_laboratory_2_SPEC.dds";
};
singleton Material(industrial_roof_steam_laboratory_3_diff_mat)
{
   mapTo = "industrial_roof_steam_laboratory_3_diff";
   diffuseMap[0] = "art/TexturesSH/Buildings/Industrial/industrial_roof_steam_laboratory_3_diff.dds";
   diffuseMap[1] = "art/TexturesSH/Buildings/Industrial/industrial_roof_steam_laboratory_3_normal.dds";
   diffuseMap[2] = "art/TexturesSH/Buildings/Industrial/industrial_roof_steam_laboratory_3_SPEC.dds";
};
singleton Material(industrial_roof_steam_laboratory_4_diff_mat)
{
   mapTo = "industrial_roof_steam_laboratory_4_diff";
   diffuseMap[0] = "art/TexturesSH/Buildings/Industrial/industrial_roof_steam_laboratory_4_diff.dds";
   diffuseMap[1] = "art/TexturesSH/Buildings/Industrial/industrial_roof_steam_laboratory_4_normal.dds";
   diffuseMap[2] = "art/TexturesSH/Buildings/Industrial/industrial_roof_steam_laboratory_4_SPEC.dds";
};
singleton Material(industrial_roof_textile_factory_1_diff_mat)
{
   mapTo = "industrial_roof_textile_factory_1_diff";
   diffuseMap[0] = "art/TexturesSH/Buildings/Industrial/industrial_roof_textile_factory_1_diff.dds";
   diffuseMap[1] = "art/TexturesSH/Buildings/Industrial/industrial_roof_textile_factory_1_normal.dds";
   diffuseMap[2] = "art/TexturesSH/Buildings/Industrial/industrial_roof_textile_factory_1_SPEC.dds";
};
singleton Material(industrial_socle_5_diff_mat)
{
   mapTo = "industrial_socle_5_diff";
   diffuseMap[0] = "art/TexturesSH/Buildings/Industrial/industrial_socle_5_diff.dds";
   diffuseMap[1] = "art/TexturesSH/Buildings/Industrial/industrial_socle_5_normal.dds";
   diffuseMap[2] = "art/TexturesSH/Buildings/Industrial/industrial_socle_5_SPEC.dds";
};
singleton Material(industrial_wall_elements_1_dark_stone_diff_mat)
{
   mapTo = "industrial_wall_elements_1_dark_stone_diff";
   diffuseMap[0] = "art/TexturesSH/Buildings/Industrial/industrial_wall_elements_1_dark_stone_diff.dds";
   diffuseMap[1] = "art/TexturesSH/Buildings/Industrial/industrial_wall_elements_1_dark_stone_normal.dds";
   diffuseMap[2] = "art/TexturesSH/Buildings/Industrial/industrial_wall_elements_1_dark_stone_SPEC.dds";
};
singleton Material(industrial_walls_2_diff_mat)
{
   mapTo = "industrial_walls_2_diff";
   diffuseMap[0] = "art/TexturesSH/Buildings/Industrial/industrial_walls_2_diff.dds";
   diffuseMap[1] = "art/TexturesSH/Buildings/Industrial/industrial_walls_2_normal.dds";
   diffuseMap[2] = "art/TexturesSH/Buildings/Industrial/industrial_walls_2_SPEC.dds";
};
singleton Material(industrial_walls_3_diff_mat)
{
   mapTo = "industrial_walls_3_diff";
   diffuseMap[0] = "art/TexturesSH/Buildings/Industrial/industrial_walls_3_diff.dds";
   diffuseMap[1] = "art/TexturesSH/Buildings/Industrial/industrial_walls_3_normal.dds";
   diffuseMap[2] = "art/TexturesSH/Buildings/Industrial/industrial_walls_3_SPEC.dds";
};
singleton Material(industrial_windows_medium_4_diff_mat)
{
   mapTo = "industrial_windows_medium_4_diff";
   diffuseMap[0] = "art/TexturesSH/Buildings/Industrial/industrial_windows_medium_4_diff.dds";
   diffuseMap[1] = "art/TexturesSH/Buildings/Industrial/industrial_windows_medium_4_normal.dds";
   diffuseMap[2] = "art/TexturesSH/Buildings/Industrial/industrial_windows_medium_4_SPEC.dds";
};
singleton Material(industrial_windows_stained_glass_1_diff_mat)
{
   mapTo = "industrial_windows_stained_glass_1_diff";
   diffuseMap[0] = "art/TexturesSH/Buildings/Industrial/industrial_windows_stained_glass_1_diff.dds";
   diffuseMap[1] = "art/TexturesSH/Buildings/Industrial/industrial_windows_stained_glass_1_normal.dds";
   diffuseMap[2] = "art/TexturesSH/Buildings/Industrial/industrial_windows_stained_glass_1_SPEC.dds";
};
singleton Material(industrial_windows_stained_glass_big_2_diff_mat)
{
   mapTo = "industrial_windows_stained_glass_big_2_diff";
   diffuseMap[0] = "art/TexturesSH/Buildings/Industrial/industrial_windows_stained_glass_big_2_diff.dds";
   diffuseMap[1] = "art/TexturesSH/Buildings/Industrial/industrial_windows_stained_glass_big_2_normal.dds";
   diffuseMap[2] = "art/TexturesSH/Buildings/Industrial/industrial_windows_stained_glass_big_2_SPEC.dds";
};
singleton Material(tft_Industrial_door_bid_arc_1_diff_mat)
{
   mapTo = "tft_Industrial_door_bid_arc_1_diff";
   diffuseMap[0] = "art/TexturesSH/Buildings/Industrial/tft_Industrial_door_bid_arc_1_diff.dds";
   diffuseMap[1] = "art/TexturesSH/Buildings/Industrial/tft_Industrial_door_bid_arc_1_normal.dds";
   diffuseMap[2] = "art/TexturesSH/Buildings/Industrial/tft_Industrial_door_bid_arc_1_SPEC.dds";
};
singleton Material(tft_industrial_door_bid_arc_jamb_1_diff_mat)
{
   mapTo = "tft_industrial_door_bid_arc_jamb_1_diff";
   diffuseMap[0] = "art/TexturesSH/Buildings/Industrial/tft_industrial_door_bid_arc_jamb_1_diff.dds";
   diffuseMap[1] = "art/TexturesSH/Buildings/Industrial/tft_industrial_door_bid_arc_jamb_1_normal.dds";
   diffuseMap[2] = "art/TexturesSH/Buildings/Industrial/tft_industrial_door_bid_arc_jamb_1_SPEC.dds";
};
singleton Material(tft_wall_medium_1_diff_mat)
{
   mapTo = "tft_wall_medium_1_diff";
   diffuseMap[0] = "art/TexturesSH/Buildings/Industrial/tft_wall_medium_1_diff.dds";
   diffuseMap[1] = "art/TexturesSH/Buildings/Industrial/tft_wall_medium_1_normal.dds";
   diffuseMap[2] = "art/TexturesSH/Buildings/Industrial/tft_wall_medium_1_Spec.dds";
};
singleton Material(universal_civil_door_jamb_diff_mat)
{
   mapTo = "universal_civil_door_jamb_diff";
   diffuseMap[0] = "art/TexturesSH/Buildings/Industrial/universal_civil_door_jamb_diff.dds";
   diffuseMap[1] = "art/TexturesSH/Buildings/Industrial/universal_civil_door_jamb_normal.dds";
   diffuseMap[2] = "art/TexturesSH/Buildings/Industrial/universal_civil_door_jamb_SPEC.dds";
};
singleton Material(industrial_walls_plaster_brick_1_diff_mat)
{
   mapTo = "industrial_walls_plaster_brick_1_diff";
   diffuseMap[0] = "art/TexturesSH/Buildings/Industrial/industrial_walls_plaster_brick_1_diff.dds";
   diffuseMap[1] = "art/TexturesSH/Buildings/Industrial/industrial_walls_plaster_brick_1_normal.dds";
   diffuseMap[2] = "art/TexturesSH/Buildings/Industrial/industrial_walls_plaster_brick_1_spec.dds";
};
singleton Material(civil_balcony_2_diff_mat)
{
   mapTo = "civil_balcony_2_diff";
   diffuseMap[0] = "art/TexturesSH/Buildings/Industrial/civil_balcony_2_diff.dds";
   diffuseMap[1] = "art/TexturesSH/Buildings/Industrial/civil_balcony_2_normal.dds";
   diffuseMap[2] = "art/TexturesSH/Buildings/Industrial/civil_balcony_2_spec.dds";
};
singleton Material(civil_cornice_1_diff_mat)
{
   mapTo = "civil_cornice_1_diff";
   diffuseMap[0] = "art/TexturesSH/Buildings/Industrial/civil_cornice_1_diff.dds";
   diffuseMap[1] = "art/TexturesSH/Buildings/Industrial/civil_cornice_1_normal.dds";
   diffuseMap[2] = "art/TexturesSH/Buildings/Industrial/civil_cornice_1_spec.dds";
};
singleton Material(industrial_walls_brick_1_down_1_diff_mat)
{
   mapTo = "industrial_walls_brick_1_down_1_diff";
   diffuseMap[0] = "art/TexturesSH/Buildings/Industrial/industrial_walls_brick_1_down_1_diff.dds";
   diffuseMap[1] = "art/TexturesSH/Buildings/Industrial/industrial_walls_brick_1_normal.dds";
   diffuseMap[2] = "art/TexturesSH/Buildings/Industrial/industrial_walls_brick_1_SPEC.dds";
};
singleton Material(industrial_walls_brick_1_up_3_diff_mat)
{
   mapTo = "industrial_walls_brick_1_up_3_diff";
   diffuseMap[0] = "art/TexturesSH/Buildings/Industrial/industrial_walls_brick_1_up_3_diff.dds";
   diffuseMap[1] = "art/TexturesSH/Buildings/Industrial/industrial_walls_brick_1_normal.dds";
   diffuseMap[2] = "art/TexturesSH/Buildings/Industrial/industrial_walls_brick_1_SPEC.dds";
};
singleton Material(industrial_walls_brick_1_up_2_diff_mat)
{
   mapTo = "industrial_walls_brick_1_up_2_diff";
   diffuseMap[0] = "art/TexturesSH/Buildings/Industrial/industrial_walls_brick_1_up_2_diff.dds";
   diffuseMap[1] = "art/TexturesSH/Buildings/Industrial/industrial_walls_brick_1_normal.dds";
   diffuseMap[2] = "art/TexturesSH/Buildings/Industrial/industrial_walls_brick_1_SPEC.dds";
};
singleton Material(industrial_walls_brick_1_up_1_diff_mat)
{
   mapTo = "industrial_walls_brick_1_up_1_diff";
   diffuseMap[0] = "art/TexturesSH/Buildings/Industrial/industrial_walls_brick_1_up_1_diff.dds";
   diffuseMap[1] = "art/TexturesSH/Buildings/Industrial/industrial_walls_brick_1_normal.dds";
   diffuseMap[2] = "art/TexturesSH/Buildings/Industrial/industrial_walls_brick_1_SPEC.dds";
};
singleton Material(industrial_walls_brick_1_down_3_diff_mat)
{
   mapTo = "industrial_walls_brick_1_down_3_diff";
   diffuseMap[0] = "art/TexturesSH/Buildings/Industrial/industrial_walls_brick_1_down_3_diff.dds";
   diffuseMap[1] = "art/TexturesSH/Buildings/Industrial/industrial_walls_brick_1_normal.dds";
   diffuseMap[2] = "art/TexturesSH/Buildings/Industrial/industrial_walls_brick_1_SPEC.dds";
};
singleton Material(industrial_walls_brick_1_down_2_diff_mat)
{
   mapTo = "industrial_walls_brick_1_down_2_diff";
   diffuseMap[0] = "art/TexturesSH/Buildings/Industrial/industrial_walls_brick_1_down_2_diff.dds";
   diffuseMap[1] = "art/TexturesSH/Buildings/Industrial/industrial_walls_brick_1_normal.dds";
   diffuseMap[2] = "art/TexturesSH/Buildings/Industrial/industrial_walls_brick_1_SPEC.dds";
};
singleton Material(industrial_walls_brick_1_diff_mat)
{
   mapTo = "industrial_walls_brick_1_diff";
   diffuseMap[0] = "art/TexturesSH/Buildings/Industrial/industrial_walls_brick_1_diff.dds";
   diffuseMap[1] = "art/TexturesSH/Buildings/Industrial/industrial_walls_brick_1_normal.dds";
   diffuseMap[2] = "art/TexturesSH/Buildings/Industrial/industrial_walls_brick_1_SPEC.dds";
};
singleton Material(civil_dormer_window_brick_1_diff_mat)
{
   mapTo = "civil_dormer_window_brick_1_diff";
   diffuseMap[0] = "art/TexturesSH/Buildings/Industrial/civil_dormer_window_brick_1_diff.dds";
   diffuseMap[1] = "art/TexturesSH/Buildings/Industrial/civil_dormer_window_brick_1_normal.dds";
   diffuseMap[2] = "art/TexturesSH/Buildings/Industrial/civil_dormer_window_brick_1_spec.dds";
};
singleton Material(industrial_floor_stone_2_diff_mat)
{
   mapTo = "industrial_floor_stone_2_diff";
   diffuseMap[0] = "art/TexturesSH/Buildings/Industrial/industrial_floor_stone_2_diff.dds";
   diffuseMap[1] = "art/TexturesSH/Buildings/Industrial/industrial_floor_stone_2_normal.dds";
   diffuseMap[2] = "art/TexturesSH/Buildings/Industrial/industrial_floor_stone_2_SPEC.dds";
};
singleton Material(industrial_overlap_brick_1_diff_mat)
{
   mapTo = "industrial_overlap_brick_1_diff";
   diffuseMap[0] = "art/TexturesSH/Buildings/Industrial/industrial_overlap_brick_1_diff.dds";
   diffuseMap[1] = "art/TexturesSH/Buildings/Industrial/industrial_overlap_brick_1_normal.dds";
   diffuseMap[2] = "art/TexturesSH/Buildings/Industrial/industrial_overlap_brick_1_SPEC.dds";
};
singleton Material(industrial_parapet_bridges_section_inner_1_diff_mat)
{
   mapTo = "industrial_parapet_bridges_section_inner_1_diff";
   diffuseMap[0] = "art/TexturesSH/Buildings/Industrial/industrial_parapet_bridges_section_inner_1_diff.dds";
   diffuseMap[1] = "art/TexturesSH/Buildings/Industrial/industrial_parapet_bridges_section_inner_1_normal.dds";
   diffuseMap[2] = "art/TexturesSH/Buildings/Industrial/industrial_parapet_bridges_section_inner_1_SPEC.dds";
};
singleton Material(industrial_pilaster_3_diff_mat)
{
   mapTo = "industrial_pilaster_3_diff";
   diffuseMap[0] = "art/TexturesSH/Buildings/Industrial/industrial_pilaster_3_diff.dds";
   diffuseMap[1] = "art/TexturesSH/Buildings/Industrial/industrial_pilaster_3_normal.dds";
   diffuseMap[2] = "art/TexturesSH/Buildings/Industrial/industrial_pilaster_3_SPEC.dds";
};
singleton Material(industrial_plumbing_1_diff_mat)
{
   mapTo = "industrial_plumbing_1_diff";
   diffuseMap[0] = "art/TexturesSH/Buildings/Industrial/industrial_plumbing_1_diff.dds";
   diffuseMap[1] = "art/TexturesSH/Buildings/Industrial/industrial_plumbing_1_normal.dds";
   diffuseMap[2] = "art/TexturesSH/Buildings/Industrial/industrial_plumbing_1_SPEC.dds";
};
singleton Material(industrial_roof_steam_foundry_1_diff_mat)
{
   mapTo = "industrial_roof_steam_foundry_1_diff";
   diffuseMap[0] = "art/TexturesSH/Buildings/Industrial/industrial_roof_steam_foundry_1_diff.dds";
   diffuseMap[1] = "art/TexturesSH/Buildings/Industrial/industrial_roof_steam_foundry_1_normal.dds";
   diffuseMap[2] = "art/TexturesSH/Buildings/Industrial/industrial_roof_steam_foundry_1_SPEC.dds";
};
singleton Material(industrial_roof_steam_foundry_2_diff_mat)
{
   mapTo = "industrial_roof_steam_foundry_2_diff";
   diffuseMap[0] = "art/TexturesSH/Buildings/Industrial/industrial_roof_steam_foundry_2_diff.dds";
   diffuseMap[1] = "art/TexturesSH/Buildings/Industrial/industrial_roof_steam_foundry_2_normal.dds";
   diffuseMap[2] = "art/TexturesSH/Buildings/Industrial/industrial_roof_steam_foundry_2_SPEC.dds";
};
singleton Material(industrial_roof_steam_foundry_3_diff_mat)
{
   mapTo = "industrial_roof_steam_foundry_3_diff";
   diffuseMap[0] = "art/TexturesSH/Buildings/Industrial/industrial_roof_steam_foundry_3_diff.dds";
   diffuseMap[1] = "art/TexturesSH/Buildings/Industrial/industrial_roof_steam_foundry_3_normal.dds";
   diffuseMap[2] = "art/TexturesSH/Buildings/Industrial/industrial_roof_steam_foundry_3_SPEC.dds";
};
singleton Material(industrial_socle_3_diff_mat)
{
   mapTo = "industrial_socle_3_diff";
   diffuseMap[0] = "art/TexturesSH/Buildings/Industrial/industrial_socle_3_diff.dds";
   diffuseMap[1] = "art/TexturesSH/Buildings/Industrial/industrial_socle_3_normal.dds";
   diffuseMap[2] = "art/TexturesSH/Buildings/Industrial/industrial_socle_3_SPEC.dds";
};
singleton Material(industrial_tank_1_diff_mat)
{
   mapTo = "industrial_tank_1_diff";
   diffuseMap[0] = "art/TexturesSH/Buildings/Industrial/industrial_tank_1_diff.dds";
   diffuseMap[1] = "art/TexturesSH/Buildings/Industrial/industrial_tank_1_normal.dds";
   diffuseMap[2] = "art/TexturesSH/Buildings/Industrial/industrial_tank_1_SPEC.dds";
};
singleton Material(industrial_wall_elements_brick_1_diff_mat)
{
   mapTo = "industrial_wall_elements_brick_1_diff";
   diffuseMap[0] = "art/TexturesSH/Buildings/Industrial/industrial_wall_elements_brick_1_diff.dds";
   diffuseMap[1] = "art/TexturesSH/Buildings/Industrial/industrial_wall_elements_brick_1_normal.dds";
   diffuseMap[2] = "art/TexturesSH/Buildings/Industrial/industrial_wall_elements_brick_1_SPEC.dds";
};

singleton Material(cracked_1_mat)
{
   mapTo = "cracked_1";
   diffuseMap[0] = "art/TexturesSH/Buildings/Industrial/cracked_1.dds";
   diffuseMap[1] = "art/TexturesSH/Buildings/Industrial/civil_overlaps_plaster_1_normal.dds"; 
   alphaTest = "1";
   alphaRef = "30";
};
singleton Material(dirt_2_mat)
{
   mapTo = "dirt_2";
   diffuseMap[0] = "art/TexturesSH/Buildings/Industrial/dirt_2.dds";
   alphaTest = "1";
   alphaRef = "30";
   translucent = "1";
};

singleton Material(spot_explosion_1_mat)
{
   mapTo = "spot_explosion_1";
   diffuseMap[0] = "art/TexturesSH/Buildings/Industrial/spot_explosion_1.dds";
   alphaTest = "1";
   alphaRef = "30";
   translucent = "1";
};
singleton Material(dirt_plane_1_diff_mat)
{
   mapTo = "dirt_plane_1_diff";
   diffuseMap[0] = "art/TexturesSH/Buildings/Industrial/dirt_plane_1_diff.dds";
  alphaTest = "1";
   alphaRef = "30";
   translucent = "1";
};
//-----------------------------------LODS--------------
singleton Material(Lods_01_mat)
{
   mapTo = "Lods_01";
   diffuseMap[0] = "art/TexturesSH/Buildings/Lods/Lods_01.dds";
   diffuseMap[1] = "art/TexturesSH/Buildings/Industrial/civil_overlaps_1_normal.dds";
   doubleSided = "1"; 
   alphaTest = "1";
     alphaRef = "30";
};
singleton Material(Lods_02_mat)
{
   mapTo = "Lods_02";
   diffuseMap[0] = "art/TexturesSH/Buildings/Lods/Lods_02.dds";
   diffuseMap[1] = "art/TexturesSH/Buildings/Industrial/civil_overlaps_1_normal.dds";
   doubleSided = "1"; 
   alphaTest = "1";
     alphaRef = "100";
};
singleton Material(Lods_03_mat)
{
   mapTo = "Lods_03";
   diffuseMap[0] = "art/TexturesSH/Buildings/Lods/Lods_03.dds";
   diffuseMap[1] = "art/TexturesSH/Buildings/Industrial/civil_overlaps_1_normal.dds";
   doubleSided = "1"; 
   alphaTest = "1";
     alphaRef = "100";
};
singleton Material(Lods_04_mat)
{
   mapTo = "Lods_04";
   diffuseMap[0] = "art/TexturesSH/Buildings/Lods/Lods_04.dds";
   diffuseMap[1] = "art/TexturesSH/Buildings/Industrial/civil_overlaps_1_normal.dds";
   doubleSided = "1"; 
   alphaTest = "1";
     alphaRef = "100";
};
singleton Material(Lods_05_mat)
{
   mapTo = "Lods_05";
   diffuseMap[0] = "art/TexturesSH/Buildings/Lods/Lods_05.dds";
   diffuseMap[1] = "art/TexturesSH/Buildings/Industrial/civil_overlaps_1_normal.dds";
   doubleSided = "1"; 
   alphaTest = "1";
     alphaRef = "100";
};
//-----------------------------------building_site--------------

singleton Material(building_site_Diffuse_mat)
{
   mapTo = "building_site_Diffuse";
   diffuseMap[0] = "art/TexturesSH/Buildings/building_site/building_site_Diffuse.dds";
   diffuseMap[1] = "art/TexturesSH/Buildings/building_site/building_site_Normal.dds";
};

//-----------------------------------bridge -------------------
singleton Material(bridge_constructor_Diff_mat)
{
   mapTo = "bridge_constructor_Diff";
   diffuseMap[0] = "art/TexturesSH/Buildings/Bridge/bridge_constructor_Diff.dds";
   diffuseMap[1] = "art/TexturesSH/Buildings/Bridge/bridge_constructor_Norm.dds";
   diffuseMap[2] = "art/TexturesSH/Buildings/Bridge/bridge_constructor_SPEC.dds";
};
//-----------------------------------tower_technokrats -------
singleton Material(tower_1_Diff_mat)
{
   mapTo = "tower_1_Diff";
   diffuseMap[0] = "art/TexturesSH/Buildings/Tower_technokrats/tower_1_Diff.dds";
   diffuseMap[1] = "art/TexturesSH/Buildings/Tower_technokrats/tower_1_Norm.dds";
   diffuseMap[2] = "art/TexturesSH/Buildings/Tower_technokrats/tower_1_SPEC.dds";
};

singleton Material(tower_2_Diff_mat)
{
   mapTo = "tower_2_Diff";
   diffuseMap[0] = "art/TexturesSH/Buildings/Tower_technokrats/tower_2_Diff.dds";
   diffuseMap[1] = "art/TexturesSH/Buildings/Tower_technokrats/tower_2_Norm.dds";
   diffuseMap[2] = "art/TexturesSH/Buildings/Tower_technokrats/tower_2_SPEC.dds";
   shader = "DefaultShaderData";
   stateBlock = "DefaultStateBlockData";
   useCustomColor = "0";
   diffuseColor[0] = "0.658824 0.423529 0.0862745 1";
};

   singleton Material(tower_3_Diff_mat)
{
   mapTo = "tower_3_Diff";
   diffuseMap[0] = "art/TexturesSH/Buildings/Tower_technokrats/tower_3_Diff.dds";
   diffuseMap[1] = "art/TexturesSH/Buildings/Tower_technokrats/tower_3_Norm.dds";
   diffuseMap[2] = "art/TexturesSH/Buildings/Tower_technokrats/tower_3_SPEC.dds";
};
//------
singleton Material(F_Technokrat_Swim_Cloth_color_mat)
{
   mapTo = "F_Technokrat_Swim_Cloth_color";
   diffuseMap[0] = "art/TexturesSH/CharacterTextures/Customization/enginer/Technokrat_Swim_Cloth_color.dds";
   diffuseMap[1] = "art/TexturesSH/CharacterTextures/Customization/enginer/Technokrat_Swim_Cloth_Normal.dds";
   doubleSided = "1";
};
//------------------------------------------------------>>>>>ANIMALS<<<<<<----------------

//---------------------------------------------------Boar-------

singleton Material(Boar_Diff_mat)
{
   mapTo = "Boar_Diff";
    diffuseMap[0] = "art/TexturesSH/Animals/Boar/Boar_Diff.dds";
   diffuseMap[1] = "art/TexturesSH/Animals/Boar/Boar_Norm.dds";
   diffuseMap[2] = "art/TexturesSH/Animals/Boar/Boar_SPEC.dds";
   skinned = true;
}; 

//---------------------------------------------------Turkey-------

singleton Material(turkey_nature_Diff_mat)
{
   mapTo = "turkey_nature_Diff";
    diffuseMap[0] = "art/TexturesSH/Animals/Turkey/turkey_nature_Diff.dds";
   diffuseMap[1] = "art/TexturesSH/Animals/Turkey/turkey_nature_Norm.dds";
   diffuseMap[2] = "art/TexturesSH/Animals/Turkey/turkey_nature_SPEC.dds";
   skinned = true;
}; 
//---------------------------------------------------Wolf-------

singleton Material(wolf_Diff_mat)
{
   mapTo = "wolf_Diff";
    diffuseMap[0] = "art/TexturesSH/Animals/Wolf/wolf_Diff.dds";
   diffuseMap[1] = "art/TexturesSH/Animals/Wolf/wolf_Norm.dds";
   diffuseMap[2] = "art/TexturesSH/Animals/Wolf/wolf_SPEC.dds";
   skinned = true;
}; 
//------------------------------------------------------>>>>>TRANSPORT<<<<<<----------------

//---------------------------------------------------moto_teh-------

singleton Material(moto_technocrats_dif_mat)
{
   mapTo = "moto_technocrats_dif";
    diffuseMap[0] = "art/TexturesSH/Transport/moto_teh/moto_technocrats_dif.dds";
   diffuseMap[1] = "art/TexturesSH/Transport/moto_teh/moto_technocrats_norm.dds";
   diffuseMap[2] = "art/TexturesSH/Transport/moto_teh/moto_technocrats_spec.dds";

}; 
singleton Material(moto_technocrats_kol_dif_mat)
{
   mapTo = "moto_technocrats_kol_dif";
   diffuseMap[0] = "art/TexturesSH/Transport/moto_teh/moto_technocrats_dif.dds";
   diffuseMap[1] = "art/TexturesSH/Transport/moto_teh/moto_technocrats_norm.dds";
   diffuseMap[2] = "art/TexturesSH/Transport/moto_teh/moto_technocrats_spec.dds";        
}; 

singleton Material(lampp_mat)
{
   mapTo = "lampp";
    diffuseMap[0] = "art/TexturesSH/weapon/SteamBow/SteamBowLamp.dds";
     doubleSided = "1";
    alphaTest = "1";
     alphaRef = "30";
    rimIntensity = "10";
}; 
singleton Material(lamp_Rad_mat)
{
   mapTo = "lamp_Rad";
    diffuseMap[0] = "art/TexturesSH/Environment/Lamp_Rad.dds";
     doubleSided = "1";
    alphaTest = "1";
     alphaRef = "30";
    rimIntensity = "10";
}; 
//---------------------------------------------------------------------------------------------------------------
//------------------------------------------------------>>>>>AIR FLEET<<<<<<----------------
singleton Material(Parts_Brass_mat)
{
   mapTo = "Parts_Brass";
   diffuseMap[0] = "art/TexturesSH/airship_teh/Airship_Steel_Diff.dds";
   diffuseMap[1] = "art/TexturesSH/Buildings/Industrial/civil_overlaps_plaster_1_normal.dds"; 
   shader = "DefaultShaderData";
   stateBlock = "DefaultStateBlockData";
   useCustomColor = "1";
   diffuseColor[0] = "0.694118 0.678431 0.454902 1";
};
singleton Material(Nose_Diff_mat)
{
   mapTo = "Nose_Diff";
   diffuseMap[0] = "art/TexturesSH/airship_teh/Nose_Diff.dds";
   diffuseMap[1] = "art/TexturesSH/airship_teh/Nose_Normal.dds";
   diffuseMap[2] = "art/TexturesSH/airship_teh/Nose_Spec.dds";  
};
singleton Material(Furnice_Diff_mat)
{
   mapTo = "Furnice_Diff";
   diffuseMap[0] = "art/TexturesSH/airship_teh/Furnice_Diff.dds";
   diffuseMap[1] = "art/TexturesSH/airship_teh/Furnice_Normal.dds";
   diffuseMap[2] = "art/TexturesSH/airship_teh/Furnice_Spec.dds";  
};
singleton Material(Airship_Ballon_Diff_mat)
{
   mapTo = "Airship_Ballon_Diff";
   diffuseMap[0] = "art/TexturesSH/airship_teh/Airship_Ballon_Diff.dds";
   diffuseMap[1] = "art/TexturesSH/airship_teh/Airship_Ballon_Normal.dds";
   diffuseMap[2] = "art/TexturesSH/airship_teh/Airship_Ballon_Spec.dds";  
};
singleton Material(Airship_Hold_Diff_mat)
{
   mapTo = "Airship_Hold_Diff";
   diffuseMap[0] = "art/TexturesSH/airship_teh/Airship_Hold_Diff.dds";
   diffuseMap[1] = "art/TexturesSH/Buildings/Industrial/civil_overlaps_plaster_1_normal.dds"; 
   diffuseMap[2] = "art/TexturesSH/airship_teh/Hold_Spec.dds";  
};
singleton Material(Airship_Lion_Diff_mat)
{
   mapTo = "Airship_Lion_Diff";
   diffuseMap[0] = "art/TexturesSH/airship_teh/Airship_Lion_Diff.dds";
   diffuseMap[1] = "art/TexturesSH/airship_teh/Airship_Lion_Normal.dds";
   diffuseMap[2] = "art/TexturesSH/airship_teh/Airship_Lion_Spec.dds";  
};
singleton Material(Airship_Metal_plates_Diff_mat)
{
   mapTo = "Airship_Metal_plates_Diff";
   diffuseMap[0] = "art/TexturesSH/airship_teh/Airship_Metal_plates_Diff.dds";
   diffuseMap[1] = "art/TexturesSH/airship_teh/Airship_Metal_plates_Normal.dds";
   diffuseMap[2] = "art/TexturesSH/airship_teh/Airship_Metal_plates_Spec.dds";  
};

singleton Material(Brass_plates_mat)
{
   mapTo = "Brass_plates";
   diffuseMap[0] = "art/TexturesSH/airship_teh/Airship_Metal_plates_Diff.dds";
   diffuseMap[1] = "art/TexturesSH/airship_teh/Airship_Metal_plates_Normal.dds";
   diffuseMap[2] = "art/TexturesSH/airship_teh/Airship_Metal_plates_Spec.dds";  
   shader = "DefaultShaderData";
   stateBlock = "DefaultStateBlockData";
   useCustomColor = "1";
   diffuseColor[0] = "0.945098 0.890196 0.635294 0";
};

singleton Material(Airship_Parts_Diff_mat)
{
   mapTo = "Airship_Parts_Diff";
   diffuseMap[0] = "art/TexturesSH/airship_teh/Airship_Parts_Diff.dds";
   diffuseMap[1] = "art/TexturesSH/airship_teh/Airship_Parts_Normal.dds";
   diffuseMap[2] = "art/TexturesSH/airship_teh/Airship_Parts_Spec.dds";  
};
singleton Material(Airship_Rope_Diff_mat)
{
   mapTo = "Airship_Rope_Diff";
   diffuseMap[0] = "art/TexturesSH/airship_teh/Airship_Rope_Diff.dds";
   diffuseMap[1] = "art/TexturesSH/airship_teh/Rope_Normal.dds";
   diffuseMap[2] = "art/TexturesSH/airship_teh/Rope_Spec.dds";  
};
singleton Material(Airship_Safe_Diff_mat)
{
   mapTo = "Airship_Safe_Diff";
   diffuseMap[0] = "art/TexturesSH/airship_teh/Airship_Safe_Diff.dds";
   diffuseMap[2] = "art/TexturesSH/airship_teh/Airship_Safe_Spec.dds";  
};
singleton Material(Airship_Steel_Diff_mat)
{
   mapTo = "Airship_Steel_Diff";
   diffuseMap[0] = "art/TexturesSH/airship_teh/Airship_Steel_Diff.dds";
   diffuseMap[1] = "art/TexturesSH/Buildings/Industrial/civil_overlaps_plaster_1_normal.dds"; 
};

singleton Material(Parts_Copper_mat)
{
   mapTo = "Parts_Copper";
   diffuseMap[0] = "art/TexturesSH/airship_teh/Airship_Steel_Diff.dds";
   diffuseMap[1] = "art/TexturesSH/Buildings/Industrial/civil_overlaps_plaster_1_normal.dds"; 
   diffuseMap[2] = "art/TexturesSH/airship_teh/Copper_Spec.dds"; 
   shader = "DefaultShaderData";
   stateBlock = "DefaultStateBlockData";
   useCustomColor = "1";
   diffuseColor[0] = "0.929412 0.431373 0.0862745 1";
   
};

singleton Material(Airship_Topka_Diff_mat)
{
   mapTo = "Airship_Topka_Diff";
   diffuseMap[0] = "art/TexturesSH/airship_teh/Airship_Topka_Diff.dds";
   diffuseMap[2] = "art/TexturesSH/airship_teh/Airship_Topka_Specular.dds";  
};
singleton Material(Airship_Wood_Diff_mat)
{
   mapTo = "Airship_Wood_Diff";
   diffuseMap[0] = "art/TexturesSH/airship_teh/Airship_Wood_Diff.dds";
   diffuseMap[1] = "art/TexturesSH/airship_teh/Airship_Wood_Normal.dds";
   diffuseMap[2] = "art/TexturesSH/airship_teh/Airship_Wood_Spec.dds";  
   shader = "DefaultShaderData";
   stateBlock = "DefaultStateBlockData";
   useCustomColor = "1";
   diffuseColor[0] = "0.678431 0.490196 0.313726 1";
};

//------------------------------------------------AIRSHIP_TEH---------------------------




//--------------------------------------------------------------------------------------------------------------

//-----------------------------------turel_m_teh--------------------------------
singleton Material(airship_turel_dif_mat)
{
   mapTo = "airship_turel_dif";
   diffuseMap[0] = "art/TexturesSH/turel_m_teh/airship_turel_dif.dds";
   diffuseMap[1] = "art/TexturesSH/turel_m_teh/airship_turel_norm.dds";
   diffuseMap[2] = "art/TexturesSH/turel_m_teh/airship_turel_spec.dds";  
};
//-----------------------------------Heavy_turret--------------------------------
singleton Material(Heavy_turret_Dif_mat)
{
   mapTo = "Heavy_turret_Dif";
   diffuseMap[0] = "art/TexturesSH/turel_m_teh/Heavy_turret_Dif.dds";
   diffuseMap[1] = "art/TexturesSH/turel_m_teh/Heavy_turret_Norm.dds";
   diffuseMap[2] = "art/TexturesSH/turel_m_teh/Heavy_turret_SPEC.dds";  
};
singleton Material(turrel_Platform_Diffuse_mat)
{
   mapTo = "turrel_Platform_Diffuse";
   diffuseMap[0] = "art/TexturesSH/turel_m_teh/turrel_Platform_Diffuse.dds";
   diffuseMap[1] = "art/TexturesSH/turel_m_teh/turrel_Platform_Normal.dds";
   diffuseMap[2] = "art/TexturesSH/turel_m_teh/turrel_Platform_Spec.dds";  
};
//------------------------------------------------------>>>>>WEAPON<<<<<<----------------
//-----------------------------------Hammer--------------------------------
singleton Material(Hammer_BC_mat)
{
   mapTo = "Hammer_BC";
   diffuseMap[0] = "art/TexturesSH/Weapon/Hammer/Hammer_BC.dds";
   diffuseMap[1] = "art/TexturesSH/Weapon/Hammer/Hammer_N.dds";
   diffuseMap[2] = "art/TexturesSH/Weapon/Hammer/Hammer_SPEC.dds";   
    
};
singleton Material(Hammer_steel_Diff_mat)
{
   mapTo = "Hammer_steel_Diff";
   diffuseMap[0] = "art/TexturesSH/Weapon/Hammer/Hammer_steel_Diff.dds";
   diffuseMap[1] = "art/TexturesSH/Weapon/Hammer/Hammer_steel_Norm.dds";
   diffuseMap[2] = "art/TexturesSH/Weapon/Hammer/Hammer_steel_SPEC.dds";   
    
};
singleton Material(Hammer_arcanum_Diff_mat)
{
   mapTo = "Hammer_arcanum_Diff";
   diffuseMap[0] = "art/TexturesSH/Weapon/Hammer/Hammer_arcanum_Diff.dds";
   diffuseMap[1] = "art/TexturesSH/Weapon/Hammer/Hammer_arcanum_Norm.dds";
   diffuseMap[2] = "art/TexturesSH/Weapon/Hammer/Hammer_arcanum_SPEC.dds";   
    
};

//-----------------------------------HammerSmall----------------------------
singleton Material(HammerSmall_steel_Diff_mat)
{
   mapTo = "HammerSmall_steel_Diff";
   diffuseMap[0] = "art/TexturesSH/Weapon/HammerSmall/steel/HammerSmall_steel_Diff.dds";
   diffuseMap[1] = "art/TexturesSH/Weapon/HammerSmall/steel/HammerSmall_steel_Norm.dds";
   diffuseMap[2] = "art/TexturesSH/Weapon/HammerSmall/steel/HammerSmall_steel_SPEC.dds";

};
singleton Material(HammerSmall_steel_add_Diff_mat)
{
   mapTo = "HammerSmall_steel_add_Diff";
   diffuseMap[0] = "art/TexturesSH/Weapon/HammerSmall/steel/HammerSmall_steel_add_Diff.dds";
   diffuseMap[1] = "art/TexturesSH/Weapon/HammerSmall/steel/HammerSmall_steel_add_Norm.dds";
   diffuseMap[2] = "art/TexturesSH/Weapon/HammerSmall/steel/HammerSmall_steel_add_SPEC.dds";

};
singleton Material(HammerSmall_iron_Diff_mat)
{
   mapTo = "HammerSmall_iron_Diff";
   diffuseMap[0] = "art/TexturesSH/Weapon/HammerSmall/iron/HammerSmall_iron_Diff.dds";
   diffuseMap[1] = "art/TexturesSH/Weapon/HammerSmall/iron/HammerSmall_iron_Norm.dds";
   diffuseMap[2] = "art/TexturesSH/Weapon/HammerSmall/iron/HammerSmall_iron_SPEC.dds";

};
singleton Material(HammerSmall_chopper_Diff_mat)
{
   mapTo = "HammerSmall_chopper_Diff";
   diffuseMap[0] = "art/TexturesSH/Weapon/HammerSmall/chopper/HammerSmall_chopper_Diff.dds";
   diffuseMap[1] = "art/TexturesSH/Weapon/HammerSmall/chopper/HammerSmall_chopper_Norm.dds";
   diffuseMap[2] = "art/TexturesSH/Weapon/HammerSmall/chopper/HammerSmall_chopper_SPEC.dds";

};
singleton Material(HammerSmall_chopper_add_Diff_mat)
{
   mapTo = "HammerSmall_chopper_add_Diff";
   diffuseMap[0] = "art/TexturesSH/Weapon/HammerSmall/chopper/HammerSmall_chopper_add_Diff.dds";
   diffuseMap[1] = "art/TexturesSH/Weapon/HammerSmall/chopper/HammerSmall_chopper_add_Norm.dds";
   diffuseMap[2] = "art/TexturesSH/Weapon/HammerSmall/chopper/HammerSmall_chopper_add_SPEC.dds";

};

singleton Material(HammerSmall_arc_add_Diff_mat)
{
   mapTo = "HammerSmall_arc_add_Diff";
   diffuseMap[0] = "art/TexturesSH/Weapon/HammerSmall/arcanum/HammerSmall_arc_add_Diff.dds";
   diffuseMap[1] = "art/TexturesSH/Weapon/HammerSmall/arcanum/HammerSmall_arc_add_Norm.dds";
   diffuseMap[2] = "art/TexturesSH/Weapon/HammerSmall/arcanum/HammerSmall_arc_add_SPEC.dds";

};

singleton Material(HammerSmall_arc_Diff_mat)
{
   mapTo = "HammerSmall_arc_Diff";
   diffuseMap[0] = "art/TexturesSH/Weapon/HammerSmall/arcanum/HammerSmall_arc_Diff.dds";
   diffuseMap[1] = "art/TexturesSH/Weapon/HammerSmall/arcanum/HammerSmall_arc_Norm.dds";
   diffuseMap[2] = "art/TexturesSH/Weapon/HammerSmall/arcanum/HammerSmall_arc_SPEC.dds";

};
singleton Material(HammerSmall_BC_mat)
{
   mapTo = "HammerSmall_BC";
   diffuseMap[0] = "art/TexturesSH/Weapon/HammerSmall/HammerSmall_BC.dds";
   diffuseMap[1] = "art/TexturesSH/Weapon/HammerSmall/HammerSmall_N.dds";
   diffuseMap[2] = "art/TexturesSH/Weapon/HammerSmall/HammerSmall_SPEC.dds";
};
//----------------------------------------Rapira----------------------------

singleton Material(Rapira_BC_mat)
{
   mapTo = "Rapira_BC";
   diffuseMap[0] = "art/TexturesSH/weapon/Rapira/Rapira_BC.dds";
   diffuseMap[1] = "art/TexturesSH/weapon/Rapira/Rapira_N.dds";
   diffuseMap[2] = "art/TexturesSH/weapon/Rapira/Rapira_SPEC.dds";
};
singleton Material(Rapira_chop_Diff_mat)
{
   mapTo = "Rapira_chop_Diff";
   diffuseMap[0] = "art/TexturesSH/Weapon/Rapira/chop/Rapira_chop_Diff.dds";
   diffuseMap[1] = "art/TexturesSH/Weapon/Rapira/chop/Rapira_chop_Norm.dds";
   diffuseMap[2] = "art/TexturesSH/Weapon/Rapira/chop/Rapira_chop_SPEC.dds";
};
singleton Material(Rapira_iron_Diff_mat)
{
   mapTo = "Rapira_iron_Diff";
   diffuseMap[0] = "art/TexturesSH/weapon/Rapira/iron/Rapira_iron_Diff.dds";
   diffuseMap[1] = "art/TexturesSH/weapon/Rapira/iron/Rapira_iron_Norm.dds";
   diffuseMap[2] = "art/TexturesSH/weapon/Rapira/iron/Rapira_iron_SPEC.dds";
};
singleton Material(Rapira_steel_Diff_mat)
{
   mapTo = "Rapira_steel_Diff";
   diffuseMap[0] = "art/TexturesSH/weapon/Rapira/steel/Rapira_steel_Diff.dds";
   diffuseMap[1] = "art/TexturesSH/weapon/Rapira/steel/Rapira_steel_Norm.dds";
   diffuseMap[2] = "art/TexturesSH/weapon/Rapira/steel/Rapira_steel_SPEC.dds";
};
singleton Material(Rapira_tiranidy_Diff_mat)
{
   mapTo = "Rapira_tiranidy_Diff";
   diffuseMap[0] = "art/TexturesSH/weapon/Rapira/tiranidy/Rapira_tiranidy_Diff.dds";
   diffuseMap[1] = "art/TexturesSH/weapon/Rapira/tiranidy/Rapira_tiranidy_Norm.dds";
   diffuseMap[2] = "art/TexturesSH/weapon/Rapira/tiranidy/Rapira_tiranidy_SPEC.dds";
};
//----------------------------------------Saber-----------------------------
singleton Material(Saber_BC_mat)
{
   mapTo = "Saber_BC";
   diffuseMap[0] = "art/TexturesSH/weapon/Saber/Saber_BC.dds";
   diffuseMap[1] = "art/TexturesSH/weapon/Saber/Saber_N.dds";
   diffuseMap[2] = "art/TexturesSH/weapon/Saber/Saber_SPEC.dds";  
};
singleton Material(Saber_steel_Diff_mat)
{
   mapTo = "Saber_steel_Diff";
   diffuseMap[0] = "art/TexturesSH/weapon/Saber/steel/Saber_steel_Diff.dds";
   diffuseMap[1] = "art/TexturesSH/weapon/Saber/steel/Saber_steel_Norm.dds";
   diffuseMap[2] = "art/TexturesSH/weapon/Saber/steel/Saber_steel_SPEC.dds";  
};
singleton Material(Saber_tiranidy_Diff_mat)
{
   mapTo = "Saber_tiranidy_Diff";
   diffuseMap[0] = "art/TexturesSH/weapon/Saber/tiranidy/Saber_tiranidy_Diff.dds";
   diffuseMap[1] = "art/TexturesSH/weapon/Saber/tiranidy/Saber_tiranidy_Norm.dds";
   diffuseMap[2] = "art/TexturesSH/weapon/Saber/tiranidy/Saber_tiranidy_SPEC.dds";  
};
//----------------------------------------SimpleGun-------------------------
singleton Material(SimpleGun_in_BC_mat)
{
   mapTo = "SimpleGun_in_BC";
   diffuseMap[0] = "art/TexturesSH/weapon/SimpleGun/SimpleGun_in_BC.dds";
   diffuseMap[1] = "art/TexturesSH/weapon/SimpleGun/SimpleGun_in_N.dds";
   diffuseMap[2] = "art/TexturesSH/weapon/SimpleGun/SimpleGun_in_SPEC.dds";
};
singleton Material(SimpleGun_ark_add_Diff_mat)
{
   mapTo = "SimpleGun_ark_add_Diff";
   diffuseMap[0] = "art/TexturesSH/weapon/SimpleGun/arcanum/SimpleGun_ark_add_Diff.dds";
   diffuseMap[1] = "art/TexturesSH/weapon/SimpleGun/arcanum/SimpleGun_ark_add_Norm.dds";
   diffuseMap[2] = "art/TexturesSH/weapon/SimpleGun/arcanum/SimpleGun_ark_add_SPEC.dds";
};
singleton Material(SimpleGun_ark_Diff_mat)
{
   mapTo = "SimpleGun_ark_Diff";
   diffuseMap[0] = "art/TexturesSH/weapon/SimpleGun/arcanum/SimpleGun_ark_Diff.dds";
   diffuseMap[1] = "art/TexturesSH/weapon/SimpleGun/arcanum/SimpleGun_ark_Norm.dds";
   diffuseMap[2] = "art/TexturesSH/weapon/SimpleGun/arcanum/SimpleGun_ark_SPEC.dds";
};
singleton Material(SimpleGun_chop_Diff_mat)
{
   mapTo = "SimpleGun_chop_Diff";
   diffuseMap[0] = "art/TexturesSH/weapon/SimpleGun/chopper/SimpleGun_chop_Diff.dds";
   diffuseMap[1] = "art/TexturesSH/weapon/SimpleGun/chopper/SimpleGun_chop_Norm.dds";
   diffuseMap[2] = "art/TexturesSH/weapon/SimpleGun/chopper/SimpleGun_chop_SPEC.dds";
};
singleton Material(SimpleGun_iron_Diff_mat)
{
   mapTo = "SimpleGun_iron_Diff";
   diffuseMap[0] = "art/TexturesSH/weapon/SimpleGun/iron/SimpleGun_iron_Diff.dds";
   diffuseMap[1] = "art/TexturesSH/weapon/SimpleGun/iron/SimpleGun_iron_Norm.dds";
   diffuseMap[2] = "art/TexturesSH/weapon/SimpleGun/iron/SimpleGun_iron_SPEC.dds";
};
singleton Material(SimpleGun_steel_add_Diff_mat)
{
   mapTo = "SimpleGun_steel_add_Diff";
   diffuseMap[0] = "art/TexturesSH/weapon/SimpleGun/steel/SimpleGun_steel_add_Diff.dds";
   diffuseMap[1] = "art/TexturesSH/weapon/SimpleGun/steel/SimpleGun_steel_add_Norm.dds";
   diffuseMap[2] = "art/TexturesSH/weapon/SimpleGun/steel/SimpleGun_steel_add_SPEC.dds";
};
singleton Material(SimpleGun_steel_Diff_mat)
{
   mapTo = "SimpleGun_steel_Diff";
   diffuseMap[0] = "art/TexturesSH/weapon/SimpleGun/steel/SimpleGun_steel_Diff.dds";
   diffuseMap[1] = "art/TexturesSH/weapon/SimpleGun/steel/SimpleGun_steel_Norm.dds";
   diffuseMap[2] = "art/TexturesSH/weapon/SimpleGun/steel/SimpleGun_steel_SPEC.dds";
};
//----------------------------------------SteamStaff------------------------
singleton Material(SteamStaff_BC_mat)
{
   mapTo = "SteamStaff_BC";
   diffuseMap[0] = "art/TexturesSH/weapon/SteamStaff/SteamStaff_BC.dds";
   diffuseMap[1] = "art/TexturesSH/weapon/SteamStaff/SteamStaff_N.dds";
   diffuseMap[2] = "art/TexturesSH/weapon/SteamStaff/SteamStaff_SPEC.dds";
};
singleton Material(SteamStaff_iron_Diff_mat)
{
   mapTo = "SteamStaff_iron_Diff";
   diffuseMap[0] = "art/TexturesSH/weapon/SteamStaff/iron/SteamStaff_iron_Diff.dds";
   diffuseMap[1] = "art/TexturesSH/weapon/SteamStaff/iron/SteamStaff_iron_Norm.dds";
   diffuseMap[2] = "art/TexturesSH/weapon/SteamStaff/iron/SteamStaff_iron_SPEC.dds";
};
singleton Material(SteamStaff_steel_Diff_mat)
{
   mapTo = "SteamStaff_steel_Diff";
   diffuseMap[0] = "art/TexturesSH/weapon/SteamStaff/steel/SteamStaff_steel_Diff.dds";
   diffuseMap[1] = "art/TexturesSH/weapon/SteamStaff/steel/SteamStaff_steel_Norm.dds";
   diffuseMap[2] = "art/TexturesSH/weapon/SteamStaff/steel/SteamStaff_steel_SPEC.dds";
};
singleton Material(SteamStaff_tiranidy_Diff_mat)
{
   mapTo = "SteamStaff_tiranidy_Diff";
   diffuseMap[0] = "art/TexturesSH/weapon/SteamStaff/tiranidy/SteamStaff_tiranidy_Diff.dds";
   diffuseMap[1] = "art/TexturesSH/weapon/SteamStaff/tiranidy/SteamStaff_tiranidy_Norm.dds";
   diffuseMap[2] = "art/TexturesSH/weapon/SteamStaff/tiranidy/SteamStaff_tiranidy_SPEC.dds";
};
//----------------------------------------Tesla-----------------------------
singleton Material(Tesla_arc_Diff_mat)
{
   mapTo = "Tesla_arc_Diff";
   diffuseMap[0] = "art/TexturesSH/weapon/Tesla/arcanum/Tesla_arc_Diff.dds";
   diffuseMap[1] = "art/TexturesSH/weapon/Tesla/arcanum/Tesla_arc_Norm.dds";
   diffuseMap[2] = "art/TexturesSH/weapon/Tesla/arcanum/Tesla_arc_SPEC.dds";
};
singleton Material(Tesla_iron_Diff_mat)
{
   mapTo = "Tesla_iron_Diff";
   diffuseMap[0] = "art/TexturesSH/weapon/Tesla/iron/Tesla_iron_Diff.dds";
   diffuseMap[1] = "art/TexturesSH/weapon/Tesla/iron/Tesla_iron_Norm.dds";
   diffuseMap[2] = "art/TexturesSH/weapon/Tesla/iron/Tesla_iron_SPEC.dds";
};
singleton Material(Tesla_steel_Diff_mat)
{
   mapTo = "Tesla_steel_Diff";
   diffuseMap[0] = "art/TexturesSH/weapon/Tesla/steel/Tesla_steel_Diff.dds";
   diffuseMap[1] = "art/TexturesSH/weapon/Tesla/steel/Tesla_steel_Norm.dds";
   diffuseMap[2] = "art/TexturesSH/weapon/Tesla/steel/Tesla_steel_SPEC.dds";
};
singleton Material(Tesla_BC_mat)
{
   mapTo = "Tesla_BC";
   diffuseMap[0] = "art/TexturesSH/weapon/Tesla/Tesla_BC.dds";
   diffuseMap[1] = "art/TexturesSH/weapon/Tesla/Tesla_N.dds";
   diffuseMap[2] = "art/TexturesSH/weapon/Tesla/Tesla_SPEC.dds";
};
singleton Material(Tesla_M_mat)
{
   mapTo = "Tesla_M";
   diffuseMap[0] = "art/TexturesSH/weapon/TeslaSmall/Lamp.dds";
  translucent = "1"; 
  doubleSided = "1";
    rimIntensity = "1";  
};
singleton Material(FLamp_mat)
{
   mapTo = "FLamp";
      diffuseMap[0] = "art/TexturesSH/weapon/TeslaSmall/Lamp.dds";
    rimIntensity = "1";
   skinned = true;
}; 
//----------------------------------------TeslaSmall--------------------------
singleton Material(TeslaSmall_steel_Diff_mat)
{
   mapTo = "TeslaSmall_steel_Diff";
   diffuseMap[0] = "art/TexturesSH/weapon/TeslaSmall/steel/TeslaSmall_steel_Diff.dds";
   diffuseMap[1] = "art/TexturesSH/weapon/TeslaSmall/steel/TeslaSmall_steel_Norm.dds";
   diffuseMap[2] = "art/TexturesSH/weapon/TeslaSmall/steel/TeslaSmall_steel_SPEC.dds";
   };
singleton Material(TeslaSmall_iron_Diff_mat)
{
   mapTo = "TeslaSmall_iron_Diff";
   diffuseMap[0] = "art/TexturesSH/weapon/TeslaSmall/iron/TeslaSmall_iron_Diff.dds";
   diffuseMap[1] = "art/TexturesSH/weapon/TeslaSmall/iron/TeslaSmall_iron_Norm.dds";
   diffuseMap[2] = "art/TexturesSH/weapon/TeslaSmall/iron/TeslaSmall_iron_SPEC.dds";
   };
singleton Material(TeslaSmall_chopper_Diff_mat)
{
   mapTo = "TeslaSmall_chopper_Diff";
   diffuseMap[0] = "art/TexturesSH/weapon/TeslaSmall/chopper/TeslaSmall_chopper_Diff.dds";
   diffuseMap[1] = "art/TexturesSH/weapon/TeslaSmall/chopper/TeslaSmall_chopper_Norm.dds";
   diffuseMap[2] = "art/TexturesSH/weapon/TeslaSmall/chopper/TeslaSmall_chopper_SPEC.dds";
   };
singleton Material(TeslaSmall_arc_Diff_mat)
{
   mapTo = "TeslaSmall_arc_Diff";
   diffuseMap[0] = "art/TexturesSH/weapon/TeslaSmall/arcanum/TeslaSmall_arc_Diff.dds";
   diffuseMap[1] = "art/TexturesSH/weapon/TeslaSmall/arcanum/TeslaSmall_arc_Norm.dds";
   diffuseMap[2] = "art/TexturesSH/weapon/TeslaSmall/arcanum/TeslaSmall_arc_SPEC.dds";
   };

singleton Material(TeslaSmall_BC_mat)
{
   mapTo = "TeslaSmall_BC";
   diffuseMap[0] = "art/TexturesSH/weapon/TeslaSmall/TeslaSmall_BC.dds";
   diffuseMap[1] = "art/TexturesSH/weapon/TeslaSmall/TeslaSmall_N.dds";
   diffuseMap[2] = "art/TexturesSH/weapon/TeslaSmall/TeslaSmall_SPEC.dds";
   };

singleton Material(Lamp_mat)
{
   mapTo = "Lamp";
   diffuseMap[0] = "art/TexturesSH/weapon/TeslaSmall/Lamp.dds";
   
    translucent = "1"; 
    doubleSided = "1";
    rimIntensity = "1";
};
singleton Material(Lamp_yellow_mat)
{
   mapTo = "Lamp_yellow";
   diffuseMap[0] = "art/TexturesSH/weapon/TeslaSmall/Lamp_yellow.dds";
   
    translucent = "1"; 
    doubleSided = "1";
    rimIntensity = "1";
};
//----------------------------------------Chain_Lightning_Generator--------
singleton Material(Chain_Lightning_Generator_diff_mat)
{
   mapTo = "Chain_Lightning_Generator_diff";
   diffuseMap[0] = "art/TexturesSH/weapon/Chain_Lightning_Generator/Chain_Lightning_Generator_diff.dds";
   diffuseMap[1] = "art/TexturesSH/weapon/Chain_Lightning_Generator/Chain_Lightning_Generator_normal.dds";
   diffuseMap[2] = "art/TexturesSH/weapon/Chain_Lightning_Generator/Chain_Lightning_Generator_Spec.dds";    
};
singleton Material(Chain_Lightning_Generator_ST_diff_mat)
{
   mapTo = "Chain_Lightning_Generator_ST_diff";
   diffuseMap[0] = "art/TexturesSH/weapon/Chain_Lightning_Generator/Chain_Lightning_Generator_ST_diff.dds";
   diffuseMap[1] = "art/TexturesSH/weapon/Chain_Lightning_Generator/Chain_Lightning_Generator_normal.dds";
   diffuseMap[2] = "art/TexturesSH/weapon/Chain_Lightning_Generator/Chain_Lightning_Generator_Spec.dds";    
};
//----------------------------------------blowjob--------
singleton Material(blowjob_copper_diff_mat)
{
   mapTo = "blowjob_copper_diff";
   diffuseMap[0] = "art/TexturesSH/weapon/Blowjob/blowjob_copper_diff.dds";
   diffuseMap[1] = "art/TexturesSH/weapon/Blowjob/blowjob_copper_normal.dds";
   diffuseMap[2] = "art/TexturesSH/weapon/Blowjob/blowjob_copper_Spec.dds";    
};
singleton Material(blowjob_diff_mat)
{
   mapTo = "blowjob_diff";
   diffuseMap[0] = "art/TexturesSH/weapon/Blowjob/blowjob_diff.dds";
   diffuseMap[1] = "art/TexturesSH/weapon/Blowjob/blowjob_normal.dds";
   diffuseMap[2] = "art/TexturesSH/weapon/Blowjob/blowjob_Spec.dds";    
};
//----------------------------------------Grenade--------
singleton Material(grenade_diff_mat)
{
   mapTo = "grenade_diff";
   diffuseMap[0] = "art/TexturesSH/weapon/Grenade/grenade_diff.dds";
   diffuseMap[1] = "art/TexturesSH/weapon/Grenade/grenade_normal.dds";
   diffuseMap[2] = "art/TexturesSH/weapon/Grenade/grenade_Spec.dds";    
};
//----------------------------------------SaberB--------
singleton Material(saber_diff_mat)
{
   mapTo = "saber_diff";
   diffuseMap[0] = "art/TexturesSH/weapon/SaberB/saber_diff.dds";
   diffuseMap[1] = "art/TexturesSH/weapon/SaberB/saber_normal.dds";
   diffuseMap[2] = "art/TexturesSH/weapon/SaberB/saber_Spec.dds";    
};
singleton Material(saber_ST_diff_mat)
{
   mapTo = "saber_ST_diff";
   diffuseMap[0] = "art/TexturesSH/weapon/SaberB/saber_ST_diff.dds";
   diffuseMap[1] = "art/TexturesSH/weapon/SaberB/saber_ST_normal.dds";
   diffuseMap[2] = "art/TexturesSH/weapon/SaberB/saber_ST_Spec.dds";    
};
//----------------------------------------Sword--------
singleton Material(sword_diff_mat)
{
   mapTo = "sword_diff";  
   diffuseMap[0] = "art/TexturesSH/weapon/Sword/sword_diff.dds";
   diffuseMap[1] = "art/TexturesSH/weapon/Sword/sword_normal.dds";
   diffuseMap[2] = "art/TexturesSH/weapon/Sword/sword_Spec.dds";    
};
singleton Material(saber_ST_diff_mat)
{
   mapTo = "saber_ST_diff";  
   diffuseMap[0] = "art/TexturesSH/weapon/Sword/saber_ST_diff.dds";
   diffuseMap[1] = "art/TexturesSH/weapon/Sword/saber_ST_normal.dds";
   diffuseMap[2] = "art/TexturesSH/weapon/Sword/saber_ST_Spec.dds";    
};
singleton Material(sword_IR_diff_mat)
{
   mapTo = "sword_IR_diff";  
   diffuseMap[0] = "art/TexturesSH/weapon/Sword/sword_IR_diff.dds";
   diffuseMap[1] = "art/TexturesSH/weapon/Sword/sword_IR_normal.dds";
   diffuseMap[2] = "art/TexturesSH/weapon/Sword/sword_IR_Spec.dds";    
};
//----------------------------------------TechnoRevolver--------
singleton Material(TechnoRevolver_diff_mat)
{
   mapTo = "TechnoRevolver_diff";
   diffuseMap[0] = "art/TexturesSH/weapon/TechnoRevolver/TechnoRevolver_diff.dds";
   diffuseMap[1] = "art/TexturesSH/weapon/TechnoRevolver/TechnoRevolver_normal.dds";
   diffuseMap[2] = "art/TexturesSH/weapon/TechnoRevolver/TechnoRevolver_Spec.dds";    
};
singleton Material(TechnoRevolver_ST_diff_mat)
{
   mapTo = "TechnoRevolver_ST_diff";
   diffuseMap[0] = "art/TexturesSH/weapon/TechnoRevolver/TechnoRevolver_ST_diff.dds";
   diffuseMap[1] = "art/TexturesSH/weapon/TechnoRevolver/TechnoRevolver_ST_normal.dds";
   diffuseMap[2] = "art/TexturesSH/weapon/TechnoRevolver/TechnoRevolver_ST_Spec.dds";    
};
//----------------------------------------TechnoShotgun--------
singleton Material(TechnoShotgun_diff_mat)
{
   mapTo = "TechnoShotgun_diff";
   diffuseMap[0] = "art/TexturesSH/weapon/TechnoShotgun/TechnoShotgun_diff.dds";
   diffuseMap[1] = "art/TexturesSH/weapon/TechnoShotgun/TechnoShotgun_normal.dds";
   diffuseMap[2] = "art/TexturesSH/weapon/TechnoShotgun/TechnoShotgun_Spec.dds";    
};
singleton Material(TechnoShotgun_ST_diff_mat)
{
   mapTo = "TechnoShotgun_ST_diff";
   diffuseMap[0] = "art/TexturesSH/weapon/TechnoShotgun/TechnoShotgun_ST_diff.dds";
   diffuseMap[1] = "art/TexturesSH/weapon/TechnoShotgun/TechnoShotgun_ST_normal.dds";
   diffuseMap[2] = "art/TexturesSH/weapon/TechnoShotgun/TechnoShotgun_ST_Spec.dds";    
};
//----------------------------------------TehnoMolniemet--------
singleton Material(TehnoMolniemet_diff_mat)
{
   mapTo = "TehnoMolniemet_diff";
   diffuseMap[0] = "art/TexturesSH/weapon/TehnoMolniemet/TehnoMolniemet_diff.dds";
   diffuseMap[1] = "art/TexturesSH/weapon/TehnoMolniemet/TehnoMolniemet_normal.dds";
   diffuseMap[2] = "art/TexturesSH/weapon/TehnoMolniemet/TehnoMolniemet_Spec.dds";    
};
singleton Material(TehnoMolniemet_ST_diff_mat)
{
   mapTo = "TehnoMolniemet_ST_diff";
   diffuseMap[0] = "art/TexturesSH/weapon/TehnoMolniemet/TehnoMolniemet_ST_diff.dds";
   diffuseMap[1] = "art/TexturesSH/weapon/TehnoMolniemet/TehnoMolniemet_ST_normal.dds";
   diffuseMap[2] = "art/TexturesSH/weapon/TehnoMolniemet/TehnoMolniemet_ST_Spec.dds";    
};
//----------------------------------------MiniBow--------------------------
singleton Material(MiniBow_BC_mat)
{
   mapTo = "MiniBow_BC";
   diffuseMap[0] = "art/TexturesSH/weapon/MiniBow/MiniBow_BC.dds";
   diffuseMap[1] = "art/TexturesSH/weapon/MiniBow/MiniBow_N.dds";
   diffuseMap[2] = "art/TexturesSH/weapon/MiniBow/MiniBow_SPEC.dds"; 
};

singleton Material(MiniBow_chop_Diff_mat)
{
   mapTo = "MiniBow_chop_Diff";
   diffuseMap[0] = "art/TexturesSH/weapon/MiniBow/chop/MiniBow_chop_Diff.dds";
   diffuseMap[1] = "art/TexturesSH/weapon/MiniBow/chop/MiniBow_chop_Norm.dds";
   diffuseMap[2] = "art/TexturesSH/weapon/MiniBow/chop/MiniBow_chop_SPEC.dds";
    
};
singleton Material(MiniBow_iron_Diff_mat)
{
   mapTo = "MiniBow_iron_Diff";
   diffuseMap[0] = "art/TexturesSH/weapon/MiniBow/iron/MiniBow_iron_Diff.dds";
   diffuseMap[1] = "art/TexturesSH/weapon/MiniBow/iron/MiniBow_iron_Norm.dds";
   diffuseMap[2] = "art/TexturesSH/weapon/MiniBow/iron/MiniBow_iron_SPEC.dds";
    
};
singleton Material(MiniBow_steel_Diff_mat)
{
   mapTo = "MiniBow_steel_Diff";
   diffuseMap[0] = "art/TexturesSH/weapon/MiniBow/steel/MiniBow_steel_Diff.dds";
   diffuseMap[1] = "art/TexturesSH/weapon/MiniBow/steel/MiniBow_steel_Norm.dds";
   diffuseMap[2] = "art/TexturesSH/weapon/MiniBow/steel/MiniBow_steel_SPEC.dds";
    
};
singleton Material(MiniBow_tiranidy_Diff_mat)
{
   mapTo = "MiniBow_tiranidy_Diff";
   diffuseMap[0] = "art/TexturesSH/weapon/MiniBow/tiranidy/MiniBow_tiranidy_Diff.dds";
   diffuseMap[1] = "art/TexturesSH/weapon/MiniBow/tiranidy/MiniBow_tiranidy_Norm.dds";
   diffuseMap[2] = "art/TexturesSH/weapon/MiniBow/tiranidy/MiniBow_tiranidy_SPEC.dds";
    
};
//----------------------------------------SteamBow--------------------------
singleton Material(SteamBow_Diff_mat)
{
   mapTo = "SteamBow_Diff";
   diffuseMap[0] = "art/TexturesSH/weapon/SteamBow/SteamBow_Diff.dds";
   diffuseMap[1] = "art/TexturesSH/weapon/SteamBow/SteamBow_N.dds";
   diffuseMap[2] = "art/TexturesSH/weapon/SteamBow/SteamBow_Spec.dds";   
};
singleton Material(SteamBow_skinBC_mat)
{
   mapTo = "SteamBow_skinBC";
   diffuseMap[0] = "art/TexturesSH/weapon/SteamBow/SteamBow_BC.dds";
   diffuseMap[1] = "art/TexturesSH/weapon/SteamBow/SteamBow_N.dds";
   diffuseMap[2] = "art/TexturesSH/weapon/SteamBow/SteamBow_M.dds";
    
    skinned = true;
};
singleton Material(SteamBowLamp_mat)
{
   mapTo = "SteamBowLamp";
   diffuseMap[0] = "art/TexturesSH/weapon/SteamBow/SteamBowLamp.dds";
   
    translucent = "1";
};
//--------------------------------------------------------------------------------------------------------------
//----------------------------------------SteamRifl--------------------------
singleton Material(SteamRifle_BC_mat)
{
   mapTo = "SteamRifle_BC";
   diffuseMap[0] = "art/TexturesSH/weapon/Rifle/SteamRifle_BC.dds";
   diffuseMap[1] = "art/TexturesSH/weapon/Rifle/SteamRifle_N.dds";
   diffuseMap[2] = "art/TexturesSH/weapon/Rifle/SteamRifle_SPEC.dds";
};
singleton Material(SteamRifle_arc_Diff_mat)
{
   mapTo = "SteamRifle_arc_Diff";
   diffuseMap[0] = "art/TexturesSH/weapon/Rifle/arcanum/SteamRifle_arc_Diff.dds";
   diffuseMap[1] = "art/TexturesSH/weapon/Rifle/arcanum/SteamRifle_arc_Norm.dds";
   diffuseMap[2] = "art/TexturesSH/weapon/Rifle/arcanum/SteamRifle_arc_SPEC.dds";
};
singleton Material(SteamRifle_iron_Diff_mat)
{
   mapTo = "SteamRifle_iron_Diff";
   diffuseMap[0] = "art/TexturesSH/weapon/Rifle/iron/SteamRifle_iron_Diff.dds";
   diffuseMap[1] = "art/TexturesSH/weapon/Rifle/iron/SteamRifle_iron_Norm.dds";
   diffuseMap[2] = "art/TexturesSH/weapon/Rifle/iron/SteamRifle_iron_SPEC.dds";
  
 
};
singleton Material(SteamRifle_steel_Diff_mat)
{
   mapTo = "SteamRifle_steel_Diff";
   diffuseMap[0] = "art/TexturesSH/weapon/Rifle/steel/SteamRifle_steel_Diff.dds";
   diffuseMap[1] = "art/TexturesSH/weapon/Rifle/steel/SteamRifle_steel_Norm.dds";
   diffuseMap[2] = "art/TexturesSH/weapon/Rifle/steel/SteamRifle_steel_SPEC.dds";
};
//--------------------------------------------------------------------------------------------------------------

//----------------------------------------SteamStick--------------------------
singleton Material(SteamStick_BC_mat)
{
   mapTo = "SteamStick_BC";
   diffuseMap[0] = "art/TexturesSH/weapon/SteamStick/SteamStick_BC.dds";
   diffuseMap[1] = "art/TexturesSH/weapon/SteamStick/SteamStick_N.dds";
   diffuseMap[2] = "art/TexturesSH/weapon/SteamStick/SteamStick_SPEC.dds";
    
};
singleton Material(SteamStick_chop_Diff_mat)
{
   mapTo = "SteamStick_chop_Diff";
   diffuseMap[0] = "art/TexturesSH/weapon/SteamStick/chop/SteamStick_chop_Diff.dds";
   diffuseMap[1] = "art/TexturesSH/weapon/SteamStick/chop/SteamStick_chop_Norm.dds";
   diffuseMap[2] = "art/TexturesSH/weapon/SteamStick/chop/SteamStick_chop_SPEC.dds";    
};
singleton Material(SteamStick_iron_Diff_mat)
{
   mapTo = "SteamStick_iron_Diff";
   diffuseMap[0] = "art/TexturesSH/weapon/SteamStick/iron/SteamStick_iron_Diff.dds";
   diffuseMap[1] = "art/TexturesSH/weapon/SteamStick/iron/SteamStick_iron_Norm.dds";
   diffuseMap[2] = "art/TexturesSH/weapon/SteamStick/iron/SteamStick_iron_SPEC.dds";   
};
singleton Material(SteamStick_steel_Diff_mat)
{
   mapTo = "SteamStick_steel_Diff";
   diffuseMap[0] = "art/TexturesSH/weapon/SteamStick/steel/SteamStick_steel_Diff.dds";
   diffuseMap[1] = "art/TexturesSH/weapon/SteamStick/steel/SteamStick_steel_Norm.dds";
   diffuseMap[2] = "art/TexturesSH/weapon/SteamStick/steel/SteamStick_steel_SPEC.dds";   
};
singleton Material(SteamStick_tiranidy_Diff_mat)
{
   mapTo = "SteamStick_tiranidy_Diff";
   diffuseMap[0] = "art/TexturesSH/weapon/SteamStick/tiranidy/SteamStick_tiranidy_Diff.dds";
   diffuseMap[1] = "art/TexturesSH/weapon/SteamStick/tiranidy/SteamStick_tiranidy_Norm.dds";
   diffuseMap[2] = "art/TexturesSH/weapon/SteamStick/tiranidy/SteamStick_tiranidy_SPEC.dds";   
};
//--------------------------------------------------------------------------------------------------------------
//----------------------------------------Enginer_female--------------------------
singleton Material(Technokrat_Female_Body_Diff_mat)
{
   mapTo = "Technokrat_Female_Body_Diff_diff";
   diffuseMap[0] = "art/TexturesSH/CharacterTextures/Customization/enginer_female/Body/Technokrat_Female_Body_Diff.dds";
   diffuseMap[1] = "art/TexturesSH/CharacterTextures/Customization/enginer_female/Body/Technokrat_Female_Body_Normal.dds";
   diffuseMap[2] = "art/TexturesSH/CharacterTextures/Customization/enginer_female/Body/Technokrat_Female_Body_Spec.dds"; 
   skinned = true;
};
singleton Material(Technokrat_Female_Cloth_Diff_mat)
{
   mapTo = "Technokrat_Female_Cloth_Diff_diff";
   diffuseMap[0] = "art/TexturesSH/CharacterTextures/Customization/enginer_female/Body/Technokrat_Female_Cloth_Diff.dds";
   diffuseMap[1] = "art/TexturesSH/CharacterTextures/Customization/enginer_female/Body/Technokrat_Female_Cloth_Normal.dds";
   diffuseMap[2] = "art/TexturesSH/CharacterTextures/Customization/enginer_female/Body/Technokrat_Female_Cloth_Spec.dds"; 
   skinned = true;
};
singleton Material(Technokrat_Female_Head_Diff_mat)
{
   mapTo = "Technokrat_Female_Head_Diff";
   diffuseMap[0] = "art/TexturesSH/CharacterTextures/Customization/enginer_female/Body/Technokrat_Female_Head_Diff.dds";
   diffuseMap[1] = "art/TexturesSH/CharacterTextures/Customization/enginer_female/Body/Technokrat_Female_Head_Normal.dds";
   diffuseMap[2] = "art/TexturesSH/CharacterTextures/Customization/enginer_female/Body/Technokrat_Female_Head_Spec.dds"; 
   skinned = true;
};
singleton Material(Technokrat_Female_Head_Diff_mat)
{
   mapTo = "Technokrat_Female_Head_Diff";
   diffuseMap[0] = "art/TexturesSH/CharacterTextures/Customization/enginer_female/Body/Technokrat_Female_Eyelashes_Diff.dds";
   skinned = true;
};
//----------------------------------------Enginer--------------------------
//--------------------------Glasses
//------glass-----
singleton Material(Glas_glass_diff_mat)
{
   mapTo = "Glas_glass_diff";
   diffuseMap[0] = "art/TexturesSH/glass_diff.dds";
   diffuseMap[2] = "art/TexturesSH/glass_spec.dds";
   doubleSided = "1";

   translucentBlendOp = "LerpAlpha";
   translucentZWrite = "1";
   alphaTest = "1";
   skinned = true;
};
singleton Material(eyeglasses_AA_diff_mat)
{
   mapTo = "eyeglasses_AA_diff";
   diffuseMap[0] = "art/TexturesSH/CharacterTextures/Customization/enginer/Glasses/eyeglasses_AA_diff.dds";
   diffuseMap[1] = "art/TexturesSH/CharacterTextures/Customization/enginer/Glasses/eyeglasses_AA_normal.dds";
   diffuseMap[2] = "art/TexturesSH/CharacterTextures/Customization/enginer/Glasses/eyeglasses_AA_Spec.dds"; 
   skinned = true;
};
singleton Material(Glasses_A_diff_mat)
{
   mapTo = "Glasses_A_diff";
   diffuseMap[0] = "art/TexturesSH/CharacterTextures/Customization/enginer/Glasses/Glasses_A_diff.dds";
   diffuseMap[1] = "art/TexturesSH/CharacterTextures/Customization/enginer/Glasses/Glasses_A_normal.dds";
   diffuseMap[2] = "art/TexturesSH/CharacterTextures/Customization/enginer/Glasses/Glasses_A_Spec.dds";
   skinned = true;
};
singleton Material(glasses_B_diff_mat)
{
   mapTo = "glasses_B_diff";
   diffuseMap[0] = "art/TexturesSH/CharacterTextures/Customization/enginer/Glasses/glasses_B_diff.dds";
   diffuseMap[1] = "art/TexturesSH/CharacterTextures/Customization/enginer/Glasses/glasses_B_normal.dds";
   diffuseMap[2] = "art/TexturesSH/CharacterTextures/Customization/enginer/Glasses/glasses_B_Spec.dds";
   skinned = true;
};
singleton Material(monocleA_diff_mat)
{
   mapTo = "monocleA_diff";
   diffuseMap[0] = "art/TexturesSH/CharacterTextures/Customization/enginer/Glasses/monocleA_diff.dds";
   diffuseMap[1] = "art/TexturesSH/CharacterTextures/Customization/enginer/Glasses/monocleA_normal.dds";
   diffuseMap[2] = "art/TexturesSH/CharacterTextures/Customization/enginer/Glasses/monocleA_Spec.dds";
   skinned = true;
};
//--------------------------Head Teh
singleton Material(Hair_Base_Color_mat)
{
   mapTo = "Hair_Base_Color";
   diffuseMap[0] = "art/TexturesSH/CharacterTextures/Customization/enginer/Hair/Hair_Base_Color.dds";
   diffuseMap[1] = "art/TexturesSH/CharacterTextures/Customization/enginer/Hair/FlatNormal.dds"; 
   doubleSided = "1"; 
   alphaTest = "1";
   alphaRef = "40";
   skinned = true;
   isHair = true; 
   useCustomColor = true;
};
singleton Material(Hair_Scan_Diff_mat)
{
   mapTo = "Hair_Scan_Diff";
   diffuseMap[0] = "art/TexturesSH/CharacterTextures/Customization/enginer/Hair/Hair_Scan_Diff.dds";
   diffuseMap[1] = "art/TexturesSH/CharacterTextures/Customization/enginer/Hair/Hair_Scan_Normal.dds"; 
   doubleSided = "1"; 
   alphaTest = "1";
   alphaRef = "80";
   skinned = true;
   isHair = true;
   useCustomColor = true;
};
singleton Material(Hair_Pushkin_Diff_mat)
{
   mapTo = "Hair_Pushkin_Diff";
   diffuseMap[0] = "art/TexturesSH/CharacterTextures/Customization/enginer/Hair/Hair_Pushkin_Diff.dds";
   diffuseMap[1] = "art/TexturesSH/CharacterTextures/Customization/enginer/Hair/Hair_Pushkin_Normal.dds"; 
   doubleSided = "1"; 
   alphaTest = "1";
   alphaRef = "80";
   skinned = true;
   isHair = true; 
   useCustomColor = true;
};
//-------new hair
singleton Material(Hairs_t_C_Diff_mat)
{
   mapTo = "Hairs_t_C_Diff";
   diffuseMap[0] = "art/TexturesSH/CharacterTextures/Customization/enginer/Hair/Hairs_t_C_Diff.dds";
   diffuseMap[1] = "art/TexturesSH/CharacterTextures/Customization/enginer/Hair/FlatNormal.dds";
   doubleSided = "1"; 
   alphaTest = "1";
   alphaRef = "80"; 
   translucent = "1";
 skinned = true;
 isHair = true;
 useCustomColor = true;
};

singleton Material(Hair_A_Diff_mat)
{
   mapTo = "Hair_A_Diff";
   diffuseMap[0] = "art/TexturesSH/CharacterTextures/Customization/enginer/Hair/Hair_A_Diff.dds";
   diffuseMap[1] = "art/TexturesSH/CharacterTextures/Customization/enginer/Hair/Hair_A_Normal.dds";
   doubleSided = "1"; 
   alphaTest = "1";
   alphaRef = "80"; 
   translucent = "1";
 skinned = true;
 isHair = true;
 useCustomColor = true;
};

singleton Material(Hairs_t_B_Diff_mat)
{
   mapTo = "Hairs_t_B_Diff";
   diffuseMap[0] = "art/TexturesSH/CharacterTextures/Customization/enginer/Hair/Hairs_t_B_Diff.dds";
   diffuseMap[1] = "art/TexturesSH/CharacterTextures/Customization/enginer/Hair/FlatNormal.dds";
   doubleSided = "1"; 
   alphaTest = "1";
   alphaRef = "30"; 
 skinned = true;
 isHair = true;
 useCustomColor = true;
};
singleton Material(HairAll_mat)
{
   mapTo = "HairAll";
   diffuseMap[0] = "art/TexturesSH/CharacterTextures/Customization/enginer/Hair/HairAll.dds";
   diffuseMap[1] = "art/TexturesSH/CharacterTextures/Customization/enginer/Hair/FlatNormal.dds";
   doubleSided = "1"; 
   alphaTest = "1";
   alphaRef = "30"; 
 skinned = true;
 isHair = true;
 useCustomColor = true;
};
singleton Material(HairFlat_Material__2_color_mat)
{
   mapTo = "HairFlat_Material__2_color";
   diffuseMap[0] = "art/TexturesSH/CharacterTextures/Customization/enginer/Hair/HairFlat_Material__2_color.dds";
   diffuseMap[1] = "art/TexturesSH/CharacterTextures/Customization/enginer/Hair/FlatNormal.dds";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "30"; 
   skinned = true;
   isHair = true;
   useCustomColor = true;
};
singleton Material(HeadNew_texture_diff_mat)
{
   mapTo = "HeadNew_texture_diff";
   diffuseMap[0] = "art/TexturesSH/CharacterTextures/Customization/enginer/Hair/HeadNew_texture_diff.dds";
   diffuseMap[1] = "art/TexturesSH/CharacterTextures/Customization/enginer/Hair/HeadNew_texture_normal.dds"; 
   diffuseMap[2] = "art/TexturesSH/CharacterTextures/Customization/enginer/Hair/HeadNew_texture_Spec.dds"; 
    useCustomColor = true;
   isFace = true;
   mipLODBias = -1.2;
   useAnisotropic[0] = "1";
   skinned = true;

   // Customization
   CustomizationData[0]  = Custom_Male_Head_Tatoo_1;
   CustomizationData[1]  = Custom_Male_Head_Tatoo_2;
   CustomizationData[2]  = Custom_Male_Head_Tatoo_3;
   CustomizationData[3]  = Custom_Male_Head_Tatoo_4;
   CustomizationData[4]  = Custom_Male_Head_Tatoo_5;
   CustomizationData[5]  = Custom_Male_Head_Tatoo_6;
   CustomizationData[6]  = Custom_Male_Head_Tatoo_7;
   CustomizationData[7]  = Custom_Male_Head_Tatoo_8;
   CustomizationData[8]  = Custom_Male_Head_Tatoo_9;
   CustomizationData[9]  = Custom_Male_Head_Tatoo_10;
   CustomizationData[10]  = Custom_Male_Head_Tatoo_11;
   CustomizationData[11]  = Custom_Male_Head_Tatoo_12;
   CustomizationData[12]  = Custom_Male_Head_Tatoo_13;
   CustomizationData[13]  = Custom_Male_Head_Tatoo_14;
   CustomizationData[14]  = Custom_Male_Head_Tatoo_15;
   CustomizationData[15]  = Custom_Male_Head_Tatoo_16;
};
//-------B
singleton Material(MechanistHead2_texture_diff_mat)
{
   mapTo = "MechanistHead2_texture_diff";
   diffuseMap[0] = "art/TexturesSH/CharacterTextures/Customization/enginer/Hair/MechanistHead2_texture_diff.dds";
   diffuseMap[1] = "art/TexturesSH/CharacterTextures/Customization/enginer/Hair/MechanistHead2_texture_normal.dds"; 
   diffuseMap[2] = "art/TexturesSH/CharacterTextures/Customization/enginer/Hair/MechanistHead2_texture_gloss.dds"; 
    useCustomColor = true;
   isFace = true;
   mipLODBias = -1.2;
   useAnisotropic[0] = "1";
   skinned = true;

   // Customization
   CustomizationData[0]  = Custom_Male_Head_Tatoo_1;
   CustomizationData[1]  = Custom_Male_Head_Tatoo_2;
   CustomizationData[2]  = Custom_Male_Head_Tatoo_3;
   CustomizationData[3]  = Custom_Male_Head_Tatoo_4;
   CustomizationData[4]  = Custom_Male_Head_Tatoo_5;
   CustomizationData[5]  = Custom_Male_Head_Tatoo_6;
   CustomizationData[6]  = Custom_Male_Head_Tatoo_7;
   CustomizationData[7]  = Custom_Male_Head_Tatoo_8;
   CustomizationData[8]  = Custom_Male_Head_Tatoo_9;
   CustomizationData[9]  = Custom_Male_Head_Tatoo_10;
   CustomizationData[10]  = Custom_Male_Head_Tatoo_11;
   CustomizationData[11]  = Custom_Male_Head_Tatoo_12;
   CustomizationData[12]  = Custom_Male_Head_Tatoo_13;
   CustomizationData[13]  = Custom_Male_Head_Tatoo_14;
   CustomizationData[14]  = Custom_Male_Head_Tatoo_15;
   CustomizationData[15]  = Custom_Male_Head_Tatoo_16;
};
//-------C
singleton Material(MechanistHead3_texture_diff_mat)
{
   mapTo = "MechanistHead3_texture_diff";
   diffuseMap[0] = "art/TexturesSH/CharacterTextures/Customization/enginer/Hair/MechanistHead3_texture_diff.dds";
   diffuseMap[1] = "art/TexturesSH/CharacterTextures/Customization/enginer/Hair/MechanistHead3_texture_normal.dds"; 
   diffuseMap[2] = "art/TexturesSH/CharacterTextures/Customization/enginer/Hair/MechanistHead3_texture_glos.dds"; 
    useCustomColor = true;
   isFace = true;
   mipLODBias = -1.2;
   useAnisotropic[0] = "1";
   skinned = true;

   // Customization
   CustomizationData[0]  = Custom_Male_Head_Tatoo_1;
   CustomizationData[1]  = Custom_Male_Head_Tatoo_2;
   CustomizationData[2]  = Custom_Male_Head_Tatoo_3;
   CustomizationData[3]  = Custom_Male_Head_Tatoo_4;
   CustomizationData[4]  = Custom_Male_Head_Tatoo_5;
   CustomizationData[5]  = Custom_Male_Head_Tatoo_6;
   CustomizationData[6]  = Custom_Male_Head_Tatoo_7;
   CustomizationData[7]  = Custom_Male_Head_Tatoo_8;
   CustomizationData[8]  = Custom_Male_Head_Tatoo_9;
   CustomizationData[9]  = Custom_Male_Head_Tatoo_10;
   CustomizationData[10]  = Custom_Male_Head_Tatoo_11;
   CustomizationData[11]  = Custom_Male_Head_Tatoo_12;
   CustomizationData[12]  = Custom_Male_Head_Tatoo_13;
   CustomizationData[13]  = Custom_Male_Head_Tatoo_14;
   CustomizationData[14]  = Custom_Male_Head_Tatoo_15;
   CustomizationData[15]  = Custom_Male_Head_Tatoo_16;
};
//-------
//-------TEST
singleton Material(Scan_Head_Diff_mat)
{
   mapTo = "Scan_Head_Diff";
   diffuseMap[0] = "art/TexturesSH/CharacterTextures/Customization/enginer/Scan_Head_Diff.dds";
   diffuseMap[1] = "art/TexturesSH/CharacterTextures/Customization/enginer/Scan_Head_Normal.dds"; 
   diffuseMap[2] = "art/TexturesSH/CharacterTextures/Customization/enginer/Scan_Head_Spec.dds"; 
    useCustomColor = true;
   isFace = true;
   mipLODBias = -1.2;
   useAnisotropic[0] = "1";
   skinned = true;

   // Customization
   CustomizationData[0]  = Custom_Male_Head_Tatoo_1;
   CustomizationData[1]  = Custom_Male_Head_Tatoo_2;
   CustomizationData[2]  = Custom_Male_Head_Tatoo_3;
   CustomizationData[3]  = Custom_Male_Head_Tatoo_4;
   CustomizationData[4]  = Custom_Male_Head_Tatoo_5;
   CustomizationData[5]  = Custom_Male_Head_Tatoo_6;
   CustomizationData[6]  = Custom_Male_Head_Tatoo_7;
   CustomizationData[7]  = Custom_Male_Head_Tatoo_8;
   CustomizationData[8]  = Custom_Male_Head_Tatoo_9;
   CustomizationData[9]  = Custom_Male_Head_Tatoo_10;
   CustomizationData[10]  = Custom_Male_Head_Tatoo_11;
   CustomizationData[11]  = Custom_Male_Head_Tatoo_12;
   CustomizationData[12]  = Custom_Male_Head_Tatoo_13;
   CustomizationData[13]  = Custom_Male_Head_Tatoo_14;
   CustomizationData[14]  = Custom_Male_Head_Tatoo_15;
   CustomizationData[15]  = Custom_Male_Head_Tatoo_16;
};
//-------

//-------TEST
singleton Material(Daz_Test_Head_Diff_AO_mat)
{
   mapTo = "Daz_Test_Head_Diff_AO";
   diffuseMap[0] = "art/TexturesSH/CharacterTextures/Customization/enginer/Daz_Test_Head_Diff_AO.dds";
   diffuseMap[1] = "art/TexturesSH/CharacterTextures/Customization/enginer/Daz_Test_Head_Normal.dds"; 
   diffuseMap[2] = "art/TexturesSH/CharacterTextures/Customization/enginer/Daz_Test_Head_Spec.dds"; 
    useCustomColor = true;
   isFace = true;
   mipLODBias = -1.2;
   useAnisotropic[0] = "1";
   skinned = true;

   // Customization
   CustomizationData[0]  = Custom_Male_Head_Tatoo_1;
   CustomizationData[1]  = Custom_Male_Head_Tatoo_2;
   CustomizationData[2]  = Custom_Male_Head_Tatoo_3;
   CustomizationData[3]  = Custom_Male_Head_Tatoo_4;
   CustomizationData[4]  = Custom_Male_Head_Tatoo_5;
   CustomizationData[5]  = Custom_Male_Head_Tatoo_6;
   CustomizationData[6]  = Custom_Male_Head_Tatoo_7;
   CustomizationData[7]  = Custom_Male_Head_Tatoo_8;
   CustomizationData[8]  = Custom_Male_Head_Tatoo_9;
   CustomizationData[9]  = Custom_Male_Head_Tatoo_10;
   CustomizationData[10]  = Custom_Male_Head_Tatoo_11;
   CustomizationData[11]  = Custom_Male_Head_Tatoo_12;
   CustomizationData[12]  = Custom_Male_Head_Tatoo_13;
   CustomizationData[13]  = Custom_Male_Head_Tatoo_14;
   CustomizationData[14]  = Custom_Male_Head_Tatoo_15;
   CustomizationData[15]  = Custom_Male_Head_Tatoo_16;
};
//-------

//-------D
singleton Material(MechanistHead4_texture_diff_mat)
{
   mapTo = "MechanistHead4_texture_diff";
   diffuseMap[0] = "art/TexturesSH/CharacterTextures/Customization/enginer/Hair/MechanistHead4_texture_diff.dds";
   diffuseMap[1] = "art/TexturesSH/CharacterTextures/Customization/enginer/Hair/MechanistHead4_texture_normal.dds"; 
   diffuseMap[2] = "art/TexturesSH/CharacterTextures/Customization/enginer/Hair/MechanistHead4_texture_gloss.dds"; 
   


   useCustomColor = true;
   isFace = true;
   mipLODBias = -1.2;
   useAnisotropic[0] = "1";
   skinned = true;

   // Customization
   CustomizationData[0]  = Custom_Male_Head_Tatoo_1;
   CustomizationData[1]  = Custom_Male_Head_Tatoo_2;
   CustomizationData[2]  = Custom_Male_Head_Tatoo_3;
   CustomizationData[3]  = Custom_Male_Head_Tatoo_4;
   CustomizationData[4]  = Custom_Male_Head_Tatoo_5;
   CustomizationData[5]  = Custom_Male_Head_Tatoo_6;
   CustomizationData[6]  = Custom_Male_Head_Tatoo_7;
   CustomizationData[7]  = Custom_Male_Head_Tatoo_8;
   CustomizationData[8]  = Custom_Male_Head_Tatoo_9;
   CustomizationData[9]  = Custom_Male_Head_Tatoo_10;
   CustomizationData[10]  = Custom_Male_Head_Tatoo_11;
   CustomizationData[11]  = Custom_Male_Head_Tatoo_12;
   CustomizationData[12]  = Custom_Male_Head_Tatoo_13;
   CustomizationData[13]  = Custom_Male_Head_Tatoo_14;
   CustomizationData[14]  = Custom_Male_Head_Tatoo_15;
   CustomizationData[15]  = Custom_Male_Head_Tatoo_16;
};
//-------
singleton Material(Technokrat_Default_Hands_Diff_mat)
{
   mapTo = "Technokrat_Default_Hands_Diff";
   diffuseMap[0] = "art/TexturesSH/CharacterTextures/Customization/enginer/Body/Technokrat_Default_Hands_Diff.dds";
   diffuseMap[1] = "art/TexturesSH/CharacterTextures/Customization/enginer/Body/Technokrat_Default_Hands_Normal.dds";
   diffuseMap[2] = "art/TexturesSH/CharacterTextures/Customization/enginer/Body/Technokrat_Default_Hands_Spec.dds";
    useCustomColor = true;
   isFace = true;
   mipLODBias = -1.2;
   useAnisotropic[0] = "1";
   skinned = true;

   // Customization
   CustomizationData[0]  = Custom_Male_Head_Tatoo_1;
   CustomizationData[1]  = Custom_Male_Head_Tatoo_2;
   CustomizationData[2]  = Custom_Male_Head_Tatoo_3;
   CustomizationData[3]  = Custom_Male_Head_Tatoo_4;
   CustomizationData[4]  = Custom_Male_Head_Tatoo_5;
   CustomizationData[5]  = Custom_Male_Head_Tatoo_6;
   CustomizationData[6]  = Custom_Male_Head_Tatoo_7;
   CustomizationData[7]  = Custom_Male_Head_Tatoo_8;
   CustomizationData[8]  = Custom_Male_Head_Tatoo_9;
   CustomizationData[9]  = Custom_Male_Head_Tatoo_10;
   CustomizationData[10]  = Custom_Male_Head_Tatoo_11;
   CustomizationData[11]  = Custom_Male_Head_Tatoo_12;
   CustomizationData[12]  = Custom_Male_Head_Tatoo_13;
   CustomizationData[13]  = Custom_Male_Head_Tatoo_14;
   CustomizationData[14]  = Custom_Male_Head_Tatoo_15;
   CustomizationData[15]  = Custom_Male_Head_Tatoo_16;
};
singleton Material(Technokrat_default_Diffuse_mat)
{
   mapTo = "Technokrat_default_Diffuse";
   diffuseMap[0] = "art/TexturesSH/CharacterTextures/Customization/enginer/Technokrat_default_Diffuse.dds";
   diffuseMap[1] = "art/TexturesSH/CharacterTextures/Customization/enginer/Technokrat_default_Normal.dds";
   diffuseMap[2] = "art/TexturesSH/CharacterTextures/Customization/enginer/Technokrat_default_Specular.dds";
    
   skinned = true;
};
singleton Material(Light_Techno_low_BaseColor_mat)
{
   mapTo = "Light_Techno_low_BaseColor";
   diffuseMap[0] = "art/TexturesSH/CharacterTextures/Customization/enginer/Light_Techno_low_BaseColor.dds";
   diffuseMap[1] = "art/TexturesSH/CharacterTextures/Customization/enginer/Light_Techno_low_Normal.dds";
   diffuseMap[2] = "art/TexturesSH/CharacterTextures/Customization/enginer/Light_Techno_low_Spec.dds";
   
   skinned = true;
};
// Тело технократа
singleton Material(Technokrat_Swim_Body_Color_mat)
{
   mapTo = "Technokrat_Swim_Body_Color";
   diffuseMap[0] = "art/TexturesSH/CharacterTextures/Customization/enginer/Technokrat_Swim_Body_Color.dds";
   diffuseMap[1] = "art/TexturesSH/CharacterTextures/Customization/enginer/Technokrat_Swim_Body_Normal.dds";
   diffuseMap[2] = "art/TexturesSH/CharacterTextures/Customization/enginer/Technokrat_Swim_Body_Specular.dds";
   skinned = true;
   useCustomColor = true;
   isBody = true;
   // Customization
   CustomizationData[0]  = Custom_Male_Body_Tatoo_1;
   CustomizationData[1]  = Custom_Male_Body_Tatoo_2;
   CustomizationData[2]  = Custom_Male_Body_Tatoo_3;
   CustomizationData[3]  = Custom_Male_Body_Tatoo_4;
   CustomizationData[4]  = Custom_Male_Body_Tatoo_5;
};
singleton Material(Technokrat_Swim_Cloth_color_mat)
{
   mapTo = "Technokrat_Swim_Cloth_color";
   diffuseMap[0] = "art/TexturesSH/CharacterTextures/Customization/enginer/Technokrat_Swim_Cloth_color.dds";
   diffuseMap[1] = "art/TexturesSH/CharacterTextures/Customization/enginer/Technokrat_Swim_Cloth_Normal.dds";
   skinned = true;
   doubleSided = "1";
};

singleton Material(Technokrat_Mid_Hi_Level_Diff_mat)
{
   mapTo = "Technokrat_Mid_Hi_Level_Diff";
   diffuseMap[0] = "art/TexturesSH/CharacterTextures/Customization/enginer/Technokrat_Mid_Hi_Level_Diff.dds";
   diffuseMap[1] = "art/TexturesSH/CharacterTextures/Customization/enginer/Technokrat_Mid_Hi_Level_Normal.dds";
   diffuseMap[2] = "art/TexturesSH/CharacterTextures/Customization/enginer/Technokrat_Mid_Hi_Level_Spec.dds";
   skinned = true;
};
singleton Material(Technokrat_Parad_Diff_mat)
{
   mapTo = "Technokrat_Parad_Diff";
   diffuseMap[0] = "art/TexturesSH/CharacterTextures/Customization/enginer/Technokrat_Parad_Diff.dds";
   diffuseMap[1] = "art/TexturesSH/CharacterTextures/Customization/enginer/Technokrat_Parad_Normal.dds";
   diffuseMap[2] = "art/TexturesSH/CharacterTextures/Customization/enginer/Technokrat_Parad_Spec.dds";
   skinned = true;
};
singleton Material(Technokrat_Elite_Diff_mat)
{
   mapTo = "Technokrat_Elite_Diff";
   diffuseMap[0] = "art/TexturesSH/CharacterTextures/Customization/enginer/Technokrat_Elite_Diff.dds";
   diffuseMap[1] = "art/TexturesSH/CharacterTextures/Customization/enginer/Technokrat_Elite_Normal.dds";
   diffuseMap[2] = "art/TexturesSH/CharacterTextures/Customization/enginer/Technokrat_Elite_Spec.dds";
   skinned = true;
};

singleton Material(Jet_Techno_Low_BaseColor_mat)
{
   mapTo = "Jet_Techno_Low_BaseColor";
   diffuseMap[0] = "art/TexturesSH/CharacterTextures/Customization/enginer/Jet_Techno_Low_BaseColor.dds";
   diffuseMap[1] = "art/TexturesSH/CharacterTextures/Customization/enginer/Jet_Techno_Low_Normal.dds";
   diffuseMap[2] = "art/TexturesSH/CharacterTextures/Customization/enginer/Jet_Techno_Low_Spec.dds";
   skinned = true;
};

singleton Material(MechanicHead_Diff_mat)
{
   mapTo = "MechanicHead_Diff";
   diffuseMap[0] = "art/TexturesSH/CharacterTextures/Customization/enginer/MechanicHead_Diff.dds";
   diffuseMap[1] = "art/TexturesSH/CharacterTextures/Customization/enginer/MechanicHead_NRM.dds";
   diffuseMap[2] = "art/TexturesSH/CharacterTextures/Customization/enginer/MechanicHead_SPEC.dds";
   materialTag0 = "LiF";
   skinned = true;
   streamable = "0";
   
};

singleton Material(belt_B_Albedo_mat)
{
   mapTo = "belt_B_Albedo";
   diffuseMap[0] = "art/TexturesSH/CharacterTextures/Customization/enginer/belt_B_Albedo.dds";
   diffuseMap[1] = "art/TexturesSH/CharacterTextures/Customization/enginer/belt_B_Normal.dds";
   diffuseMap[2] = "art/TexturesSH/CharacterTextures/Customization/enginer/belt_B_Specular.dds";
   
   skinned = true;
};

singleton Material(shirt_Albedo_mat)
{
   mapTo = "shirt_Albedo";
   diffuseMap[0] = "art/TexturesSH/CharacterTextures/Customization/enginer/shirt_Albedo.dds";
    diffuseMap[1] = "art/TexturesSH/CharacterTextures/Customization/enginer/shirt_Normal.dds";
    diffuseMap[2] = "art/TexturesSH/CharacterTextures/Customization/enginer/shirt_Specular.dds";
   
   skinned = true;
};

singleton Material(pants_Albedo_mat)
{
   mapTo = "pants_Albedo";
   diffuseMap[0] = "art/TexturesSH/CharacterTextures/Customization/enginer/pants_Albedo.dds";
     diffuseMap[1] = "art/TexturesSH/CharacterTextures/Customization/enginer/pants_Normal.dds";
     diffuseMap[2] = "art/TexturesSH/CharacterTextures/Customization/enginer/pants_Specular.dds";
   
   skinned = true;
};

singleton Material(backpack_Albedo_mat)
{
   mapTo = "backpack_Albedo";
   diffuseMap[0] = "art/TexturesSH/CharacterTextures/Customization/enginer/backpack_Albedo.dds";
   diffuseMap[1] = "art/TexturesSH/CharacterTextures/Customization/enginer/backpack_Normal.dds";
   diffuseMap[2] = "art/TexturesSH/CharacterTextures/Customization/enginer/backpack_Specular.dds";
   materialTag0 = "LiF";
   skinned = true;
};

singleton Material(Jetpack_Albedo_mat)
{
   mapTo = "Jetpack_Albedo";
   diffuseMap[0] = "art/TexturesSH/CharacterTextures/Customization/enginer/Jetpack_Albedo.dds";
   diffuseMap[1] = "art/TexturesSH/CharacterTextures/Customization/enginer/Jetpack_Normal.dds";
    diffuseMap[2] = "art/TexturesSH/CharacterTextures/Customization/enginer/Jetpack_Specular.dds";
   skinned = true;
   streamable = "0";
};

singleton Material(belt_A_Albedo_mat)
{
   mapTo = "belt_A_Albedo";
   diffuseMap[0] = "art/TexturesSH/CharacterTextures/Customization/enginer/belt_A_Albedo.dds";
    diffuseMap[1] = "art/TexturesSH/CharacterTextures/Customization/enginer/belt_A_Normal.dds";
    diffuseMap[2] = "art/TexturesSH/CharacterTextures/Customization/enginer/belt_A_Specular.dds";
   materialTag0 = "LiF";
   skinned = true;
   streamable = "0";
};
singleton Material(boot_Albedo_mat)
{
   mapTo = "boot_Albedo";
   diffuseMap[0] = "art/TexturesSH/CharacterTextures/Customization/enginer/boot_Albedo.dds";
     diffuseMap[1] = "art/TexturesSH/CharacterTextures/Customization/enginer/boot_Normal.dds";
     diffuseMap[2] = "art/TexturesSH/CharacterTextures/Customization/enginer/boot_Specular.dds";
   materialTag0 = "LiF";
   skinned = true;
   streamable = "0";
};

singleton Material(manometer_mat)
{
   mapTo = "manometer";
   diffuseMap[0] = "art/TexturesSH/CharacterTextures/Customization/enginer/manometer.dds";
   materialTag0 = "LiF";
   skinned = true;
   streamable = "0";
};

singleton Material(Technokrat_Heavy_Armor_arcanium_Color_main_mat)
{
   mapTo = "Technokrat_Heavy_Armor_arcanium_Color_main";
   diffuseMap[0] = "art/TexturesSH/CharacterTextures/Customization/enginer/Technokrat_Heavy_Armor_arcanium_Color_main.dds";
   diffuseMap[1] = "art/TexturesSH/CharacterTextures/Customization/enginer/Technokrat_Heavy_Armor_arcanium_Normal_Main.dds";
   diffuseMap[2] = "art/TexturesSH/CharacterTextures/Customization/enginer/Technokrat_Heavy_Armor_arcanium_Spec_main.dds";
   skinned = true;
};
singleton Material(Technokrat_Heavy_Armor_arcanium_Color_parts_mat)
{
   mapTo = "Technokrat_Heavy_Armor_arcanium_Color_parts";
   diffuseMap[0] = "art/TexturesSH/CharacterTextures/Customization/enginer/Technokrat_Heavy_Armor_arcanium_Color_parts.dds";
   diffuseMap[1] = "art/TexturesSH/CharacterTextures/Customization/enginer/Technokrat_Heavy_Armor_arcanium_Normal_Parts.dds";
   diffuseMap[2] = "art/TexturesSH/CharacterTextures/Customization/enginer/Technokrat_Heavy_Armor_arcanium_Spec_Parts.dds";
   skinned = true;
};
singleton Material(Technokrat_Heavy_Armor_iron_Color_mat)
{
   mapTo = "Technokrat_Heavy_Armor_iron_Color";
   diffuseMap[0] = "art/TexturesSH/CharacterTextures/Customization/enginer/Technokrat_Heavy_Armor_iron_Color.dds";
   diffuseMap[1] = "art/TexturesSH/CharacterTextures/Customization/enginer/Technokrat_Heavy_Armor_iron_Normal.dds";
   diffuseMap[2] = "art/TexturesSH/CharacterTextures/Customization/enginer/Technokrat_Heavy_Armor_iron_Spec.dds";
   skinned = true;
};
singleton Material(Technokrat_Light_Armor_Low_Body_Diff)
{
   mapTo = "Technokrat_Light_Armor_Low_Body_Diff";
   diffuseMap[0] = "art/TexturesSH/CharacterTextures/Customization/enginer/Technokrat_Light_Armor_Low_Body_Diff.dds";
   diffuseMap[1] = "art/TexturesSH/CharacterTextures/Customization/enginer/Technokrat_Light_Armor_Low_Body_Normal.dds";
   diffuseMap[2] = "art/TexturesSH/CharacterTextures/Customization/enginer/Technokrat_Light_Armor_Low_Body_Spec.dds";
   skinned = true;
};
singleton Material(Technokrat_mid_armor_low_Diff_mat)
{
   mapTo = "Technokrat_mid_armor_low_Diff";
   diffuseMap[0] = "art/TexturesSH/CharacterTextures/Customization/enginer/Technokrat_mid_armor_low_Diff.dds";
   diffuseMap[1] = "art/TexturesSH/CharacterTextures/Customization/enginer/Technokrat_mid_armor_low_Normal.dds";
   diffuseMap[2] = "art/TexturesSH/CharacterTextures/Customization/enginer/Technokrat_mid_armor_low_Spec.dds";
   skinned = true;
};
singleton Material(Technokrat_mid_armor_mid_Diffuse_mat)
{
   mapTo = "Technokrat_mid_armor_mid_Diffuse";
   diffuseMap[0] = "art/TexturesSH/CharacterTextures/Customization/enginer/Technokrat_mid_armor_mid_Diffuse.dds";
   diffuseMap[1] = "art/TexturesSH/CharacterTextures/Customization/enginer/Technokrat_mid_armor_mid_Normal.dds";
   diffuseMap[2] = "art/TexturesSH/CharacterTextures/Customization/enginer/Technokrat_mid_armor_mid_Specular.dds";
   skinned = true;
};
//-----------------------------------------
//--------------------------Enginer_Helmet
singleton Material(Technokrat_light_Helmet_Diffuse_mat)
{
   mapTo = "Technokrat_light_Helmet_Diffuse";
   diffuseMap[0] = "art/TexturesSH/CharacterTextures/Customization/enginer/Helmet/Technokrat_light_Helmet_Diffuse.dds";
   diffuseMap[1] = "art/TexturesSH/CharacterTextures/Customization/enginer/Helmet/Technokrat_light_Helmet_Normal.dds";
  //-- diffuseMap[2] = "art/TexturesSH/CharacterTextures/Customization/enginer/Helmet/Technokrat_light_Helmet_Spec.dds";
   skinned = true;
};

singleton Material(Technokrat_Helmet_Diff_mat)
{
   mapTo = "Technokrat_Helmet_Diff";
   diffuseMap[0] = "art/TexturesSH/CharacterTextures/Customization/enginer/Helmet/Technokrat_Helmet_Diff.dds";
   diffuseMap[1] = "art/TexturesSH/CharacterTextures/Customization/enginer/Helmet/Technokrat_Helmet_Normal.dds";
   diffuseMap[2] = "art/TexturesSH/CharacterTextures/Customization/enginer/Helmet/Technokrat_Helmet_Specular.dds";
   skinned = true;
};

singleton Material(Technokrat_mid_helmet_diff_mat)
{
mapTo = "Technokrat_mid_helmet_diff";
   diffuseMap[0] = "art/TexturesSH/CharacterTextures/Customization/enginer/Helmet/Technokrat_mid_helmet_diff.dds";
   diffuseMap[1] = "art/TexturesSH/CharacterTextures/Customization/enginer/Helmet/Technokrat_mid_helmet_Normal.dds";
   diffuseMap[2] = "art/TexturesSH/CharacterTextures/Customization/enginer/Helmet/Technokrat_mid_helmet_Specular.dds";
   skinned = true;
};
//-----------------------------------------
//--------------------------Enginer_Armor

singleton Material(Technokrat_Light_Armor_low_Diff_mat)
{
   mapTo = "Technokrat_Light_Armor_low_Diff";
   diffuseMap[0] = "art/TexturesSH/CharacterTextures/Customization/enginer/Technokrat_Light_Armor_low_Diff.dds";
   diffuseMap[1] = "art/TexturesSH/CharacterTextures/Customization/enginer/Technokrat_Light_Armor_low_Normal.dds";
   diffuseMap[2] = "art/TexturesSH/CharacterTextures/Customization/enginer/Technokrat_Light_Armor_low_Spec.dds";
   skinned = true;
   streamable = "0";
};
singleton Material(Technokrat_Light_Hi_Diff_mat)
{
   mapTo = "Technokrat_Light_Hi_Diff";
   diffuseMap[0] = "art/TexturesSH/CharacterTextures/Customization/enginer/Technokrat_Light_Hi_Diff.dds";
   diffuseMap[1] = "art/TexturesSH/CharacterTextures/Customization/enginer/Technokrat_Light_Hi_Normal.dds";
   diffuseMap[2] = "art/TexturesSH/CharacterTextures/Customization/enginer/Technokrat_Light_Hi_Spec.dds";
   
   skinned = true;
   streamable = "0";
};


singleton Material(Tcrt_TMArmor__BC_mat)
{
   mapTo = "Tcrt_TMArmor__BC";
   diffuseMap[0] = "art/TexturesSH/CharacterTextures/Customization/enginer/Tcrt_TMArmor__BC.dds";
   diffuseMap[1] = "art/TexturesSH/CharacterTextures/Customization/enginer/Tcrt_TMArmor__N.dds";
   diffuseMap[2] = "art/TexturesSH/CharacterTextures/Customization/enginer/Tcrt_TMArmor__M.dds";
   
   skinned = true;
   streamable = "0";
};

singleton Material(THArmor_Albedo_mat)
{
   mapTo = "THArmor_Albedo";
   diffuseMap[0] = "art/TexturesSH/CharacterTextures/Customization/enginer/THArmor_Albedo.dds";
   diffuseMap[1] = "art/TexturesSH/CharacterTextures/Customization/enginer/THArmor_Normal.dds";
   diffuseMap[2] = "art/TexturesSH/CharacterTextures/Customization/enginer/THArmor_Metallic.dds";
   
fChrome = 1;  envmap = "false";

    skinned = true;
   streamable = "0";
};
singleton Material(THArmor_METALL_mat)
{
   mapTo = "THArmor_METALL";
   diffuseMap[0] = "art/TexturesSH/CharacterTextures/Customization/enginer/THArmor_Albedo.dds";
   diffuseMap[1] = "art/TexturesSH/CharacterTextures/Customization/enginer/THArmor_Normal.dds";
   diffuseMap[2] = "art/TexturesSH/CharacterTextures/Customization/enginer/THArmor_Metallic.dds";
   skinned = true;
   streamable = "0";
};

singleton Material(TMArmor_BC_mat)
{
   mapTo = "TMArmor_BC";
   diffuseMap[0] = "art/TexturesSH/CharacterTextures/Customization/enginer/Body/TMArmor_BC.dds";
   diffuseMap[1] = "art/TexturesSH/CharacterTextures/Customization/enginer/Body/TMArmor_N.dds";
   diffuseMap[2] = "art/TexturesSH/CharacterTextures/Customization/enginer/Body/TMArmor_SPEC.dds";

   skinned = true;
   streamable = "0";
};

//------------------------------------Steamage--------------------------------------
/**/
singleton Material(paromag_boot_Albedo_mat)
{
   mapTo = "paromag_boot_Albedo";
   diffuseMap[0] = "art/TexturesSH/CharacterTextures/Customization/steamage/boot/paromag_boot_Albedo.dds";
   diffuseMap[1] = "art/TexturesSH/CharacterTextures/Customization/steamage/boot/paromag_boot_Normal.dds";
   diffuseMap[2] = "art/TexturesSH/CharacterTextures/Customization/steamage/boot/paromag_boot_SPEC.dds";
    
   materialTag0 = "LiF";
   skinned = true;
   streamable = "0";
};

singleton Material(paromag_shirt_Albedo_mat)
{
   mapTo = "paromag_shirt_Albedo";
   diffuseMap[0] = "art/TexturesSH/CharacterTextures/Customization/steamage/shirt/paromag_shirt_Albedo.dds";
   diffuseMap[1] = "art/TexturesSH/CharacterTextures/Customization/steamage/shirt/paromag_shirt_Normal.dds";
   diffuseMap[2] = "art/TexturesSH/CharacterTextures/Customization/steamage/shirt/paromag_shirt_Specular.dds";
   
   materialTag0 = "LiF";
   skinned = true;
   streamable = "0";
};

singleton Material(paromag_pants_Albedo_mat)
{
   mapTo = "paromag_pants_Albedo";
   diffuseMap[0] = "art/TexturesSH/CharacterTextures/Customization/steamage/pants/paromag_pants_Albedo.dds";
   diffuseMap[1] = "art/TexturesSH/CharacterTextures/Customization/steamage/pants/paromag_pants_Normal.dds";
   diffuseMap[2] = "art/TexturesSH/CharacterTextures/Customization/steamage/pants/paromag_pants_Specular.dds";
   
   materialTag0 = "LiF";
   skinned = true;
  streamable = "0";
};

singleton Material(paromag_backpack_Albedo_mat)
{
   mapTo = "paromag_backpack_Albedo";
   diffuseMap[0] = "art/TexturesSH/CharacterTextures/Customization/steamage/backpack/paromag_backpack_Albedo.dds";
   diffuseMap[1] = "art/TexturesSH/CharacterTextures/Customization/steamage/backpack/paromag_backpack_Normal.dds";
   diffuseMap[2] = "art/TexturesSH/CharacterTextures/Customization/steamage/backpack/paromag_backpack_SPEC.dds";
   
   materialTag0 = "LiF";
   skinned = true;
   streamable = "0";
};

singleton Material(paromag_hand_Albedo_mat)
{
   mapTo = "paromag_hand_Albedo";
   diffuseMap[0] = "art/TexturesSH/CharacterTextures/Customization/steamage/hand/paromag_hand_Albedo.dds";
   diffuseMap[1] = "art/TexturesSH/CharacterTextures/Customization/steamage/hand/paromag_hand_Normal.dds";
   diffuseMap[2] = "art/TexturesSH/CharacterTextures/Customization/steamage/hand/paromag_hand_SPEC.dds";
   
   materialTag0 = "LiF";
   skinned = true;
  streamable = "0";
};

singleton Material(paromag_glove_Albedo_mat)
{
   mapTo = "paromag_glove_Albedo";
   diffuseMap[0] = "art/TexturesSH/CharacterTextures/Customization/steamage/glove/paromag_glove_Albedo.dds";
   diffuseMap[1] = "art/TexturesSH/CharacterTextures/Customization/steamage/glove/paromag_glove_Normal.dds";
   diffuseMap[2] = "art/TexturesSH/CharacterTextures/Customization/steamage/glove/paromag_glove_SPEC.dds";
   
   materialTag0 = "LiF";
  skinned = true;
  streamable = "0";
};

singleton Material(paromag_head_diff_mat)
{
   mapTo = "paromag_head_diff";
   diffuseMap[0] = "art/TexturesSH/CharacterTextures/Customization/steamage/head/paromag_head_diff.dds";
   diffuseMap[1] = "art/TexturesSH/CharacterTextures/Customization/steamage/head/paromag_head_normal.dds";
   diffuseMap[2] = "art/TexturesSH/CharacterTextures/Customization/steamage/head/paromag_head_SPEC.dds"; 
   
    
   materialTag0 = "LiF";
  skinned = true;
   streamable = "0";
};

singleton Material(Jetpack_Mag_Albedo_mat)
{
   mapTo = "Jetpack_Mag_Albedo";
   diffuseMap[0] = "art/TexturesSH/CharacterTextures/Customization/steamage/Jetpack_Mag/Jetpack_Mag_Albedo.dds";
   diffuseMap[1] = "art/TexturesSH/CharacterTextures/Customization/steamage/Jetpack_Mag/Jetpack_Mag_Normal_Inv.dds";
   diffuseMap[2] = "art/TexturesSH/CharacterTextures/Customization/steamage/Jetpack_Mag/Jetpack_Mag_SPEC.dds";
   
   materialTag0 = "LiF";
  skinned = true;
  streamable = "0";
};
//------------------------------------Steamage Armor--------------------------------------
singleton Material(Steamage_charNew_diff_mat)
{
   mapTo = "Steamage_charNew_diff";
   diffuseMap[0] = "art/TexturesSH/CharacterTextures/Customization/steamage/Default/Steamage_charNew_diff.dds";
   diffuseMap[1] = "art/TexturesSH/CharacterTextures/Customization/steamage/Default/Steamage_charNew_normal.dds";
   diffuseMap[2] = "art/TexturesSH/CharacterTextures/Customization/steamage/Default/Steamage_charNew_SPEC.dds";
   
   materialTag0 = "LiF";
   skinned = true;
   streamable = "0";
};

singleton Material(Paromage_Default_Diff_mat)
{
   mapTo = "Paromage_Default_Diff";
   diffuseMap[0] = "art/TexturesSH/CharacterTextures/Customization/steamage/Default/Paromage_Default_Diff.dds";
   diffuseMap[1] = "art/TexturesSH/CharacterTextures/Customization/steamage/Default/Paromage_Default_Normal.dds";
   diffuseMap[2] = "art/TexturesSH/CharacterTextures/Customization/steamage/Default/Paromage_Default_SPEC.dds";
   
   materialTag0 = "LiF";
   skinned = true;
   streamable = "0";
};


singleton Material(Light_Armor_Paromages_low_diff_mat)
{
   mapTo = "Light_Armor_Paromages_low_diff";
   diffuseMap[0] = "art/TexturesSH/CharacterTextures/Customization/steamage/Low_Armor/Light_Armor_Paromages_low_diff.dds";
   diffuseMap[1] = "art/TexturesSH/CharacterTextures/Customization/steamage/Low_Armor/Light_Armor_Paromages_low_Norm.dds";
   diffuseMap[2] = "art/TexturesSH/CharacterTextures/Customization/steamage/Low_Armor/Light_Armor_Paromages_low_SPEC.dds";
   
   materialTag0 = "LiF";
   skinned = true;
   streamable = "0";
};
singleton Material(Light_Armor_Paromages_low_Diff_chains_mat)
{
   mapTo = "Light_Armor_Paromages_low_Diff_chains";
   diffuseMap[0] = "art/TexturesSH/CharacterTextures/Customization/steamage/Low_Armor/Light_Armor_Paromages_low_Diff_chains.dds";
   diffuseMap[1] = "art/TexturesSH/CharacterTextures/Customization/steamage/Low_Armor/Light_Armor_Paromages_low_Norm.dds";
   diffuseMap[2] = "art/TexturesSH/CharacterTextures/Customization/steamage/Low_Armor/Light_Armor_Paromages_low_SPEC.dds";
  
   alphaRef = "30"; 
   doubleSided = "1"; 
   skinned = true;
   streamable = "0";
};
singleton Material(Armor_low_DefaultMaterial_Diff_mat)
{
   mapTo = "Armor_low_DefaultMaterial_Diff";
   diffuseMap[0] = "art/TexturesSH/CharacterTextures/Customization/steamage/Heavy_Armor/Armor_low_DefaultMaterial_Diff.dds";
   diffuseMap[1] = "art/TexturesSH/CharacterTextures/Customization/steamage/Heavy_Armor/Armor_low_DefaultMaterial_Normal.dds";
   diffuseMap[2] = "art/TexturesSH/CharacterTextures/Customization/steamage/Heavy_Armor/Armor_low_DefaultMaterial_SPEC.dds";
   
   materialTag0 = "LiF";
  skinned = true;
  streamable = "0";
};
singleton Material(Prmg_M_BC_mat)
{
   mapTo = "Prmg_M_BC";
   diffuseMap[0] = "art/TexturesSH/CharacterTextures/Customization/steamage/Armor_Med/Prmg_M_BC.dds";
   diffuseMap[1] = "art/TexturesSH/CharacterTextures/Customization/steamage/Armor_Med/Prmg_M_N.dds";
   diffuseMap[2] = "art/TexturesSH/CharacterTextures/Customization/steamage/Armor_Med/Prmg_M_SPEC.dds";
   
   materialTag0 = "LiF";
  skinned = true;
  streamable = "0";
};
singleton Material(Prmg_M_Armour_BC_mat)
{
   mapTo = "Prmg_M_Armour_BC";
   diffuseMap[0] = "art/TexturesSH/CharacterTextures/Customization/steamage/Armour/Prmg_M_Armour_BC.dds";
   diffuseMap[1] = "art/TexturesSH/CharacterTextures/Customization/steamage/Armour/Prmg_M_Armour_N.dds";
   diffuseMap[2] = "art/TexturesSH/CharacterTextures/Customization/steamage/Armour/Prmg_M_Armour_SPEC.dds";
   
   materialTag0 = "LiF";
  skinned = true;
  streamable = "0";
};
/**/
//------------------------------------------------------>>>>>TREES<<<<<<----------------
//--------   skinned = true; - для стволов и убрать с пней 
//----------------------------------------first_tree--------------------------

singleton Material(first_mat)
{
   mapTo = "first";
   diffuseMap[0] = "art/ModelsSH/3D/Environment/Trees/first/textures/first.dds";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "80";
   diffuseMap[1] = "art/ModelsSH/3D/Environment/Trees/first/textures/first_Normal.dds";
   skinned = true;
};
singleton Material(OakBark_Diffuse_mat)
{
   mapTo = "OakBark_Diffuse";
   diffuseMap[0] = "art/ModelsSH/3D/Environment/Trees/first/textures/OakBark_Diffuse.dds";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "80";
   diffuseMap[1] = "art/ModelsSH/3D/Environment/Trees/first/textures/OakBark_Diffuse_NRM.dds";
  skinned = true;
};
singleton Material(OakBark_DiffuseB_mat)
{
   mapTo = "OakBark_DiffuseB";
   diffuseMap[0] = "art/ModelsSH/3D/Environment/Trees/first/textures/OakBark_DiffuseB.dds";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "80";
   diffuseMap[1] = "art/ModelsSH/3D/Environment/Trees/first/textures/OakBark_DiffuseB_NRM.dds";
  skinned = true;
};
//--------
singleton Material(f_first_mat)
{
   mapTo = "f_first";
   diffuseMap[0] = "art/ModelsSH/3D/Environment/Trees/first/textures/first.dds";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "80";
   diffuseMap[1] = "art/ModelsSH/3D/Environment/Trees/first/textures/first_Normal.dds";
};
singleton Material(f_OakBark_Diffuse_mat)
{
   mapTo = "f_OakBark_Diffuse";
   diffuseMap[0] = "art/ModelsSH/3D/Environment/Trees/first/textures/OakBark_Diffuse.dds";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "80";
   diffuseMap[1] = "art/ModelsSH/3D/Environment/Trees/first/textures/OakBark_Diffuse_NRM.dds";
};
//----------------------------------------Rubber_tree--------------------------
singleton Material(rubber_mat)
{
   mapTo = "rubber";
   diffuseMap[0] = "art/ModelsSH/3D/Environment/Trees/rubber/textures/rubber.dds";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "80";
   diffuseMap[1] = "art/ModelsSH/3D/Environment/Trees/rubber/textures/rubber_Normal.dds";
   skinned = true;
};
singleton Material(My_kora_dif_mat)
{
   mapTo = "My_kora_dif";
   diffuseMap[0] = "art/ModelsSH/3D/Environment/Trees/rubber/textures/My_kora_dif.dds";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "80";
   diffuseMap[1] = "art/ModelsSH/3D/Environment/Trees/rubber/textures/AmurCorkBark_Normal.dds";
   skinned = true;
};
singleton Material(My_bad_kora_dif_mat)
{
   mapTo = "My_bad_kora_dif";
   diffuseMap[0] = "art/ModelsSH/3D/Environment/Trees/rubber/textures/My_bad_kora_dif.dds";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "80";
   diffuseMap[1] = "art/ModelsSH/3D/Environment/Trees/rubber/textures/My_bad_kora_dif_NRM.dds";
   skinned = true;
};
//-------
singleton Material(f_rubber_mat)
{
   mapTo = "f_rubber";
   diffuseMap[0] = "art/ModelsSH/3D/Environment/Trees/rubber/textures/rubber.dds";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "80";
   diffuseMap[1] = "art/ModelsSH/3D/Environment/Trees/rubber/textures/rubber_Normal.dds";
};
singleton Material(f_My_kora_dif_mat)
{
   mapTo = "f_My_kora_dif";
   diffuseMap[0] = "art/ModelsSH/3D/Environment/Trees/rubber/textures/My_kora_dif.dds";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "80";
   diffuseMap[1] = "art/ModelsSH/3D/Environment/Trees/rubber/textures/AmurCorkBark_Normal.dds";
};
//----------------------------------------Bush_root--------------------------
singleton Material(Pish_bar_Diffuse_mat)
{
   mapTo = "Pish_bar_Diffuse";
   diffuseMap[0] = "art/ModelsSH/3D/Environment/Trees/bush/textures/Pish_bar_Diffuse.dds";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "80";
   diffuseMap[1] = "art/ModelsSH/3D/Environment/Trees/bush/textures/OakBark01_Normal.dds";
};
//----------------------------------------Pine--------------------------
singleton Material(pine_mat)
{
   mapTo = "pine";
   diffuseMap[0] = "art/ModelsSH/3D/Environment/Trees/pine/textures/pine.dds";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "80";
   diffuseMap[1] = "art/ModelsSH/3D/Environment/Trees/pine/textures/pine_Normal.dds";
   diffuseMap[2] = "art/ModelsSH/3D/Environment/Trees/pine/textures/pine_Specular.dds";
   skinned = true;
};
singleton Material(ScotsPineBark_mat)
{
   mapTo = "ScotsPineBark";
   diffuseMap[0] = "art/ModelsSH/3D/Environment/Trees/pine/textures/ScotsPineBark.dds";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "80";
   diffuseMap[1] = "art/ModelsSH/3D/Environment/Trees/pine/textures/ScotsPineBark_Normal.dds";
   diffuseMap[2] = "art/ModelsSH/3D/Environment/Trees/pine/textures/SpruceBark_Specular.dds";
   skinned = true;
};
//-----
singleton Material(f_pine_mat)
{
   mapTo = "f_pine";
   diffuseMap[0] = "art/ModelsSH/3D/Environment/Trees/pine/textures/pine.dds";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "80";
   diffuseMap[1] = "art/ModelsSH/3D/Environment/Trees/pine/textures/pine_Normal.dds";
   diffuseMap[2] = "art/ModelsSH/3D/Environment/Trees/pine/textures/pine_Specular.dds";
};
singleton Material(f_ScotsPineBark_mat)
{
   mapTo = "f_ScotsPineBark";
   diffuseMap[0] = "art/ModelsSH/3D/Environment/Trees/pine/textures/ScotsPineBark.dds";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "80";
   diffuseMap[1] = "art/ModelsSH/3D/Environment/Trees/pine/textures/ScotsPineBark_Normal.dds";
   diffuseMap[2] = "art/ModelsSH/3D/Environment/Trees/pine/textures/SpruceBark_Specular.dds";
};
//----------------------------------------miracle_tree--------------------------
singleton Material(AlienRing_Bark_mat)
{
   mapTo = "AlienRing_Bark";
   diffuseMap[0] = "art/ModelsSH/3D/Environment/Trees/miracle/textures/AlienRing_Bark.dds";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "80";
   diffuseMap[1] = "art/ModelsSH/3D/Environment/Trees/miracle/textures/AlienRing_Bark_NRM.dds";
  skinned = true;
};
singleton Material(AlienRing_Bark_2_mat)
{
   mapTo = "AlienRing_Bark_2";
   diffuseMap[0] = "art/ModelsSH/3D/Environment/Trees/miracle/textures/AlienRing_Bark_2.dds";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "80";
   diffuseMap[1] = "art/ModelsSH/3D/Environment/Trees/miracle/textures/AlienRing_Bark_NRM.dds";
  skinned = true;
};
singleton Material(AlienRing_Bark_1_5_mat)
{
   mapTo = "AlienRing_Bark_1_5";
   diffuseMap[0] = "art/ModelsSH/3D/Environment/Trees/miracle/textures/AlienRing_Bark_1_5.dds";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "80";
   diffuseMap[1] = "art/ModelsSH/3D/Environment/Trees/miracle/textures/AlienRing_Bark_NRM.dds";
  skinned = true;
};
singleton Material(AlienRingBark_Y_mat)
{
   mapTo = "AlienRingBark_Y";
   diffuseMap[0] = "art/ModelsSH/3D/Environment/Trees/miracle/textures/AlienRing_Bark.dds";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "80";
   diffuseMap[1] = "art/ModelsSH/3D/Environment/Trees/miracle/textures/AlienRing_Bark_NRM.dds";
  skinned = true;
};
singleton Material(miracle_mat)
{
   mapTo = "miracle";
   diffuseMap[0] = "art/ModelsSH/3D/Environment/Trees/miracle/textures/miracle.dds";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "80";
   diffuseMap[1] = "art/ModelsSH/3D/Environment/Trees/miracle/textures/miracle_Normal.dds";
   diffuseMap[2] = "art/ModelsSH/3D/Environment/Trees/miracle/textures/miracle_Specular.dds";
  skinned = true;
};
singleton Material(Tentakli_3_mat)
{
   mapTo = "Tentakli_3";
   diffuseMap[0] = "art/ModelsSH/3D/Environment/Trees/miracle/textures/Tentakli_3.dds";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "80";
   diffuseMap[1] = "art/ModelsSH/3D/Environment/Trees/miracle/textures/AlienRing_Bark_NRM.dds";
  skinned = true;
};
singleton Material(Tentakli_3_1_5_mat)
{
   mapTo = "Tentakli_3_1_5";
   diffuseMap[0] = "art/ModelsSH/3D/Environment/Trees/miracle/textures/Tentakli_3_1_5.dds";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "80";
   diffuseMap[1] = "art/ModelsSH/3D/Environment/Trees/miracle/textures/AlienRing_Bark_NRM.dds";
  skinned = true;
};
singleton Material(Tentakli_3_2_mat)
{
   mapTo = "Tentakli_3_2";
   diffuseMap[0] = "art/ModelsSH/3D/Environment/Trees/miracle/textures/Tentakli_3_2.dds";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "80";
   diffuseMap[1] = "art/ModelsSH/3D/Environment/Trees/miracle/textures/AlienRing_Bark_NRM.dds";
  skinned = true;
};
//---
singleton Material(f_AlienRing_Bark_mat)
{
   mapTo = "f_AlienRing_Bark";
   diffuseMap[0] = "art/ModelsSH/3D/Environment/Trees/miracle/textures/AlienRing_Bark_2.dds";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "80";
   diffuseMap[1] = "art/ModelsSH/3D/Environment/Trees/miracle/textures/AlienRing_Bark_NRM.dds";
};
singleton Material(f_AlienRing_Bark_1_5_mat)
{
   mapTo = "f_AlienRing_Bark_1_5";
   diffuseMap[0] = "art/ModelsSH/3D/Environment/Trees/miracle/textures/AlienRing_Bark_1_5.dds";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "80";
   diffuseMap[1] = "art/ModelsSH/3D/Environment/Trees/miracle/textures/AlienRing_Bark_NRM.dds";
};
singleton Material(f_miracle_mat)
{
   mapTo = "f_miracle";
   diffuseMap[0] = "art/ModelsSH/3D/Environment/Trees/miracle/textures/miracle.dds";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "80";
   diffuseMap[1] = "art/ModelsSH/3D/Environment/Trees/miracle/textures/miracle_Normal.dds";
};

//----------------------------------------walnut--------------------------

singleton Material(walnut_mat)
{
   mapTo = "walnut";
   diffuseMap[0] = "art/ModelsSH/3D/Environment/Trees/walnut_tree/textures/walnut.dds";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "80";
   diffuseMap[1] = "art/ModelsSH/3D/Environment/Trees/walnut_tree/textures/walnut_Normal.dds";
   diffuseMap[2] = "art/ModelsSH/3D/Environment/Trees/walnut_tree/textures/walnut_Specular.dds";
   skinned = true;
};
singleton Material(WalnutBark_Diffuse_mat)
{
   mapTo = "WalnutBark_Diffuse";
   diffuseMap[0] = "art/ModelsSH/3D/Environment/Trees/walnut_tree/textures/WalnutBark_Diffuse.dds";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "80";
   diffuseMap[1] = "art/ModelsSH/3D/Environment/Trees/walnut_tree/textures/WalnutBark_Normal.dds";
   skinned = true;
};
singleton Material(WalnutBark_Old_Diffuse_mat)
{
   mapTo = "WalnutBark_Old_Diffuse";
   diffuseMap[0] = "art/ModelsSH/3D/Environment/Trees/walnut_tree/textures/WalnutBark_Old_Diffuse.dds";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "80";
   diffuseMap[1] = "art/ModelsSH/3D/Environment/Trees/walnut_tree/textures/WalnutBark_Old_Normal.dds";
   skinned = true;
};
//-----
singleton Material(f_walnut_mat)
{
   mapTo = "f_walnut";
   diffuseMap[0] = "art/ModelsSH/3D/Environment/Trees/walnut_tree/textures/walnut.dds";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "80";
   diffuseMap[1] = "art/ModelsSH/3D/Environment/Trees/walnut_tree/textures/walnut_Normal.dds";
   diffuseMap[2] = "art/ModelsSH/3D/Environment/Trees/walnut_tree/textures/walnut_Specular.dds";
};
singleton Material(f_WalnutBark_Diffuse_mat)
{
   mapTo = "f_WalnutBark_Diffuse";
   diffuseMap[0] = "art/ModelsSH/3D/Environment/Trees/walnut_tree/textures/WalnutBark_Diffuse.dds";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "80";
   diffuseMap[1] = "art/ModelsSH/3D/Environment/Trees/walnut_tree/textures/WalnutBark_Normal.dds";
};
//----------------------------------------Shelkolipt--------------------------
singleton Material(shelkolipt_mat)
{
   mapTo = "shelkolipt";
   diffuseMap[0] = "art/ModelsSH/3D/Environment/Trees/shelkolipt/textures/shelkolipt.dds";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "80";
   diffuseMap[1] = "art/ModelsSH/3D/Environment/Trees/shelkolipt/textures/shelkolipt_Normal.dds";
   diffuseMap[2] = "art/ModelsSH/3D/Environment/Trees/shelkolipt/textures/shelkolipt_Specular.dds";
   skinned = true;
};
singleton Material(Kora_PineBark_Diffuse_mat)
{
   mapTo = "Kora_PineBark_Diffuse";
   diffuseMap[0] = "art/ModelsSH/3D/Environment/Trees/shelkolipt/textures/Kora_PineBark_Diffuse.dds";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "80";
   diffuseMap[1] = "art/ModelsSH/3D/Environment/Trees/shelkolipt/textures/Kora_PineBark_Diffuse_NRM.dds";
   skinned = true;
};
//-----
singleton Material(f_shelkolipt_mat)
{
   mapTo = "f_shelkolipt";
   diffuseMap[0] = "art/ModelsSH/3D/Environment/Trees/shelkolipt/textures/shelkolipt.dds";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "80";
   diffuseMap[1] = "art/ModelsSH/3D/Environment/Trees/shelkolipt/textures/shelkolipt_Normal.dds";
   diffuseMap[2] = "art/ModelsSH/3D/Environment/Trees/shelkolipt/textures/shelkolipt_Specular.dds";
};
singleton Material(f_Kora_PineBark_Diffuse_mat)
{
   mapTo = "f_Kora_PineBark_Diffuse";
   diffuseMap[0] = "art/ModelsSH/3D/Environment/Trees/shelkolipt/textures/Kora_PineBark_Diffuse.dds";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "80";
   diffuseMap[1] = "art/ModelsSH/3D/Environment/Trees/shelkolipt/textures/Kora_PineBark_Diffuse_NRM.dds";
};
//----------------------------------------Palm--------------------------
singleton Material(Palm_mat)
{
   mapTo = "Palm";
   diffuseMap[0] = "art/ModelsSH/3D/Environment/Trees/palm/textures/Palm.dds";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "80";
   diffuseMap[1] = "art/ModelsSH/3D/Environment/Trees/palm/textures/Palm_Normal.dds";
   diffuseMap[2] = "art/ModelsSH/3D/Environment/Trees/palm/textures/Palm_Specular.dds";
   skinned = true;
};
singleton Material(WhitePineBark_mat)
{
   mapTo = "WhitePineBark";
   diffuseMap[0] = "art/ModelsSH/3D/Environment/Trees/palm/textures/WhitePineBark.dds";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "80";
   diffuseMap[1] = "art/ModelsSH/3D/Environment/Trees/palm/textures/WhitePineBark_Normal.dds";
   skinned = true;
};
//-----
singleton Material(f_Palm_mat)
{
   mapTo = "f_Palm";
   diffuseMap[0] = "art/ModelsSH/3D/Environment/Trees/palm/textures/Palm.dds";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "80";
   diffuseMap[1] = "art/ModelsSH/3D/Environment/Trees/palm/textures/Palm_Normal.dds";
   diffuseMap[2] = "art/ModelsSH/3D/Environment/Trees/palm/textures/Palm_Specular.dds";
   
};
singleton Material(f_WhitePineBark_mat)
{
   mapTo = "f_WhitePineBark";
   diffuseMap[0] = "art/ModelsSH/3D/Environment/Trees/palm/textures/WhitePineBark.dds";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "80";
   diffuseMap[1] = "art/ModelsSH/3D/Environment/Trees/palm/textures/WhitePineBark_Normal.dds";
};
//----------------------------------------Orange--------------------------
singleton Material(orange_tree_mat)
{
   mapTo = "orange_tree";
   diffuseMap[0] = "art/ModelsSH/3D/Environment/Trees/orange_tree/textures/orange_tree.dds";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "80";
   diffuseMap[1] = "art/ModelsSH/3D/Environment/Trees/orange_tree/textures/orange_tree_Normal.dds";
   diffuseMap[2] = "art/ModelsSH/3D/Environment/Trees/orange_tree/textures/orange_tree_Specular.dds";
   skinned = true;
};
singleton Material(RedMapleBark_mat)
{
   mapTo = "RedMapleBark";
   diffuseMap[0] = "art/ModelsSH/3D/Environment/Trees/orange_tree/textures/RedMapleBark.dds";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "80";
   diffuseMap[1] = "art/ModelsSH/3D/Environment/Trees/orange_tree/textures/RedMapleBark_Normal.dds";
   skinned = true;
};
singleton Material(Bad_kora_dif_mat)
{
   mapTo = "Bad_kora_dif";
   diffuseMap[0] = "art/ModelsSH/3D/Environment/Trees/orange_tree/textures/Bad_kora_dif.dds";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "80";
   diffuseMap[1] = "art/ModelsSH/3D/Environment/Trees/orange_tree/textures/Bad_kora_norm.dds";
   skinned = true;
};
//-----
singleton Material(f_orange_tree_mat)
{
   mapTo = "f_orange_tree";
   diffuseMap[0] = "art/ModelsSH/3D/Environment/Trees/orange_tree/textures/orange_tree.dds";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "80";
   diffuseMap[1] = "art/ModelsSH/3D/Environment/Trees/orange_tree/textures/orange_tree_Normal.dds";
   diffuseMap[2] = "art/ModelsSH/3D/Environment/Trees/orange_tree/textures/orange_tree_Specular.dds";
};
singleton Material(f_RedMapleBark_mat)
{
   mapTo = "f_RedMapleBark";
   diffuseMap[0] = "art/ModelsSH/3D/Environment/Trees/orange_tree/textures/RedMapleBark.dds";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "80";
   diffuseMap[1] = "art/ModelsSH/3D/Environment/Trees/orange_tree/textures/RedMapleBark_Normal.dds";
};
//--------------------TREE_END---
//----------------------------------------metall_trash--------------------------
singleton Material(Metal_trash_1_Diffuse_mat)
{
   mapTo = "Metal_trash_1_Diffuse";
   diffuseMap[0] = "art/TexturesSH/Environment/metall_trash/Metal_trash_1_Diffuse.dds";
   diffuseMap[1] = "art/TexturesSH/Environment/metall_trash/Metal_trash_1_Normal.dds";
   diffuseMap[2] = "art/TexturesSH/Environment/metall_trash/Metal_trash_1_SPEC.dds"; 
};
//----------------------------------------metall_trash--------------------------
singleton Material(All_meat_diff_mat)
{
   mapTo = "All_meat_diff";
   diffuseMap[0] = "art/TexturesSH/Environment/Meat/All_meat_diff.dds";
   diffuseMap[1] = "art/TexturesSH/Environment/Meat/All_meat_norm.dds";
   diffuseMap[2] = "art/TexturesSH/Environment/Meat/All_meat_spec.dds"; 
};
//----------------------------------------grave--------------------------
singleton Material(Grave_Stone_Diffuse_mat)
{
   mapTo = "Grave_Stone_Diffuse";
   diffuseMap[0] = "art/TexturesSH/Environment/Grave/Grave_Stone_Diffuse.dds";
   diffuseMap[1] = "art/TexturesSH/Environment/Grave/Grave_Stone_Normal.dds";
   diffuseMap[2] = "art/TexturesSH/Environment/Grave/Grave_Stone_SPEC.dds"; 
};

//----------------------------------------pipe--------------------------
singleton Material(smoke_pipe_mat)
{
   mapTo = "smoke_pipe";
   diffuseMap[0] = "art/TexturesSH/Environment/industrial_Interier/Barrels_stairs_Dif.dds";
   diffuseMap[1] = "art/TexturesSH/Environment/industrial_Interier/Barrels_stairs_Norm.dds";
   diffuseMap[2] = "art/TexturesSH/Environment/industrial_Interier/Barrels_stairs_SPEC.dds"; 
   skinned = true;
};

//----------------------------------------Lamp--------------------------
singleton Material(Wood_walls_farm_Diff_mat)
{
   mapTo = "Wood_walls_farm_Diff";
   diffuseMap[0] = "art/TexturesSH/Environment/Lamp/Wood_walls_farm_Diff.dds";
   diffuseMap[1] = "art/TexturesSH/Environment/Lamp/Wood_walls_farm_Norm.dds";
   diffuseMap[2] = "art/TexturesSH/Environment/Lamp/Wood_walls_farm_SPEC.dds";
};
//----------------------------------------Log--------------------------
singleton Material(Log_diff_mat)
{
   mapTo = "Log_diff";
   diffuseMap[0] = "art/TexturesSH/Environment/Log/Log_diff.dds";
   diffuseMap[1] = "art/TexturesSH/Environment/Log/Log_norm.dds";
};
//----------------------------------------industrial_Interier--------------------------
singleton Material(Barrels_stairs_Dif_mat)
{
   mapTo = "Barrels_stairs_Dif";
   diffuseMap[0] = "art/TexturesSH/Environment/industrial_Interier/Barrels_stairs_Dif.dds";
   diffuseMap[1] = "art/TexturesSH/Environment/industrial_Interier/Barrels_stairs_Norm.dds";
   diffuseMap[2] = "art/TexturesSH/Environment/industrial_Interier/Barrels_stairs_SPEC.dds"; 
};
singleton Material(lamp_hookah_Dif_mat)
{
   mapTo = "lamp_hookah_Dif";
   diffuseMap[0] = "art/TexturesSH/Environment/industrial_Interier/lamp_hookah_Dif.dds";
   diffuseMap[1] = "art/TexturesSH/Environment/industrial_Interier/lamp_hookah_Norm.dds";
   diffuseMap[2] = "art/TexturesSH/Environment/industrial_Interier/lamp_hookah_SPEC.dds"; 
};
singleton Material(Tools_chest_Dif_mat)
{
   mapTo = "Tools_chest_Dif";
   diffuseMap[0] = "art/TexturesSH/Environment/industrial_Interier/Tools_chest_Dif.dds";
   diffuseMap[1] = "art/TexturesSH/Environment/industrial_Interier/Tools_chest_Norm.dds";
   diffuseMap[2] = "art/TexturesSH/Environment/industrial_Interier/Tools_chest_SPEC.dds"; 
};
singleton Material(Wheelbarrow_coal_Dif_mat)
{
   mapTo = "Wheelbarrow_coal_Dif";
   diffuseMap[0] = "art/TexturesSH/Environment/industrial_Interier/Wheelbarrow_coal_Dif.dds";
   diffuseMap[1] = "art/TexturesSH/Environment/industrial_Interier/Wheelbarrow_coal_Norm.dds";
   diffuseMap[2] = "art/TexturesSH/Environment/industrial_Interier/Wheelbarrow_coal_SPEC.dds"; 
};
singleton Material(POSTERS_mat)
{
   mapTo = "POSTERS";
   diffuseMap[0] = "art/TexturesSH/Environment/industrial_Interier/POSTERS.dds";
   diffuseMap[1] = "art/TexturesSH/Environment/industrial_Interier/POSTERS_Norm.dds"; 
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "30";
};
//----------------------------------------Campfire--------------------------
singleton Material(Campfire_Dif_mat)
{
   mapTo = "Campfire_Dif";
   diffuseMap[0] = "art/TexturesSH/Environment/Campfire/Campfire_Dif.dds";
   diffuseMap[1] = "art/TexturesSH/Environment/Campfire/Campfire_Norm.dds";
};

//----------------------------------------bag--------------------------
singleton Material(Bag_Diffuse_mat)
{
   mapTo = "Bag_Diffuse";
   diffuseMap[0] = "art/TexturesSH/Environment/Bag/Bag_Diffuse.dds";
   diffuseMap[1] = "art/TexturesSH/Environment/Bag/Bag_Normal.dds";
   diffuseMap[2] = "art/TexturesSH/Environment/Bag/Bag_SPEC.dds"; 
};
//------------------------------------------------------>>>>>TOOLS<<<<<<----------------
singleton Material(All_TOOLS_diff_mat)             
{
   mapTo = "All_TOOLS_diff";
   diffuseMap[0] = "art/TexturesSH/Tool/All_TOOLS_diff.dds";
   diffuseMap[1] = "art/TexturesSH/Tool/All_TOOLS_norm.dds";
   diffuseMap[2] = "art/TexturesSH/Tool/All_TOOLS_SPEC.dds";
};
singleton Material(F_All_TOOLS_diff_mat)             
{
   mapTo = "F_All_TOOLS_diff";
   diffuseMap[0] = "art/TexturesSH/Tool/All_TOOLS_diff.dds";
   diffuseMap[1] = "art/TexturesSH/Tool/All_TOOLS_norm.dds";
   diffuseMap[2] = "art/TexturesSH/Tool/All_TOOLS_SPEC.dds";
   skinned = true;
};

singleton Material(Bonfire_grave_stone_color_mat)             
{
   mapTo = "Bonfire_grave_stone_color";
   diffuseMap[0] = "art/TexturesSH/Environment/Bonfire_grave_stone_color.dds";
   diffuseMap[1] = "art/TexturesSH/Environment/Bonfire_grave_stone_nmap.dds";
   diffuseMap[2] = "art/TexturesSH/Environment/Bonfire_grave_stone_SPEC.dds";
};
//----------------------------------------axe--------------------------
singleton Material(Ruch_2_Lo_Default_AlbedoTransparency_mat)              //-----ручка
{
   mapTo = "Ruch_2_Lo_Default_AlbedoTransparency";
   diffuseMap[0] = "art/TexturesSH/Tool/axe/Ruch/Ruch_2_Lo_Default_AlbedoTransparency.dds";
   diffuseMap[1] = "art/TexturesSH/Tool/axe/Ruch/Ruch_2_Lo_Default_Normal.dds";
   diffuseMap[2] = "art/TexturesSH/Tool/axe/Ruch/Ruch_2_Lo_Default_SpecularSmoothness.dds";  
};
singleton Material(Lez_Lo_2_Default_AlbedoTransparency_mat)              //-----сталь
{
   mapTo = "Lez_Lo_2_Default_AlbedoTransparency";
   diffuseMap[0] = "art/TexturesSH/Tool/axe/Lez/Lez_Lo_2_Default_AlbedoTransparency.dds";
   diffuseMap[1] = "art/TexturesSH/Tool/axe/Lez/Lez_Lo_2_Default_Normal.dds";
   diffuseMap[2] = "art/TexturesSH/Tool/axe/Lez/Lez_Lo_2_Default_SpecularSmoothness.dds";  
};
singleton Material(Lez_Lo_AlbedoTransparency_Cop_mat)              //-----медь
{
   mapTo = "Lez_Lo_AlbedoTransparency_Cop";
   diffuseMap[0] = "art/TexturesSH/Tool/axe/CopLez/Lez_Lo_AlbedoTransparency_Cop.dds";
   diffuseMap[1] = "art/TexturesSH/Tool/axe/Lez/Lez_Lo_2_Default_Normal.dds";
   diffuseMap[2] = "art/TexturesSH/Tool/axe/Lez/Lez_Lo_2_Default_SpecularSmoothness.dds"; 
};
singleton Material(Lez_Lo_2_Default_AlbedoTransparency_Rjav_mat)              //-----ржа
{
   mapTo = "Lez_Lo_2_Default_AlbedoTransparency_Rjav";
   diffuseMap[0] = "art/TexturesSH/Tool/axe/Rjav/Lez_Lo_2_Default_AlbedoTransparency_Rjav.dds";
   diffuseMap[1] = "art/TexturesSH/Tool/axe/Lez/Lez_Lo_2_Default_Normal.dds";
   diffuseMap[2] = "art/TexturesSH/Tool/axe/Lez/Lez_Lo_2_Default_SpecularSmoothness.dds"; 
};
//----------------------------------------blowjob--------------------------

singleton Material(dobivalkad_diff_mat)            
{
   mapTo = "dobivalkad_diff";
   diffuseMap[0] = "art/TexturesSH/Tool/blowjob/dobivalkad_diff.dds";
   diffuseMap[1] = "art/TexturesSH/Tool/blowjob/dobivalkad_normal.dds";
   diffuseMap[2] = "art/TexturesSH/Tool/blowjob/dobivalkad_Spec.dds"; 
};
singleton Material(dobivalkad_1lev_texture_diff_mat)            
{
   mapTo = "dobivalkad_1lev_texture_diff";
   diffuseMap[0] = "art/TexturesSH/Tool/blowjob/dobivalkad_1lev_texture_diff.dds";
   diffuseMap[1] = "art/TexturesSH/Tool/blowjob/dobivalkad_1lev_texture_normal.dds";
   diffuseMap[2] = "art/TexturesSH/Tool/blowjob/dobivalkad_1lev_texture_Spec.dds";
};
//----------------------------------------fishingpole--------------------------

singleton Material(Rod_LO_Default_AlbedoTransparency_mat)            
{
   mapTo = "Rod_LO_Default_AlbedoTransparency";
   diffuseMap[0] = "art/TexturesSH/Tool/fishingpole/Rod_LO_Default_AlbedoTransparency.dds";
   diffuseMap[1] = "art/TexturesSH/Tool/fishingpole/Rod_LO_Default_Normal.dds";
   diffuseMap[2] = "art/TexturesSH/Tool/fishingpole/Rod_LO_Default_SpecularSmoothness.dds"; 
};
//----------------------------------------hammer--------------------------
singleton Material(Ham_Lo_Default_AlbedoTransparency_mat)            
{
   mapTo = "Ham_Lo_Default_AlbedoTransparency";
   diffuseMap[0] = "art/TexturesSH/Tool/hammer/Ham_Lo_Default_AlbedoTransparency.dds";
   diffuseMap[1] = "art/TexturesSH/Tool/hammer/Ham_Lo_Default_Normal.dds";
   diffuseMap[2] = "art/TexturesSH/Tool/hammer/Ham_Lo_Default_SpecularSmoothness.dds"; 
};
singleton Material(Ham_Lo_Default_AlbedoTransparency_cop_mat)            
{
   mapTo = "Ham_Lo_Default_AlbedoTransparency_cop";
   diffuseMap[0] = "art/TexturesSH/Tool/hammer/Ham_Lo_Default_AlbedoTransparency_cop.dds";
   diffuseMap[1] = "art/TexturesSH/Tool/hammer/Ham_Lo_Default_Normal.dds";
   diffuseMap[2] = "art/TexturesSH/Tool/hammer/Ham_Lo_Default_SpecularSmoothness.dds";
};
singleton Material(Ham_Lo_Default_AlbedoTransparency_Rjav_mat)            
{
   mapTo = "Ham_Lo_Default_AlbedoTransparency_Rjav";
   diffuseMap[0] = "art/TexturesSH/Tool/hammer/Ham_Lo_Default_AlbedoTransparency_Rjav.dds";
   diffuseMap[1] = "art/TexturesSH/Tool/hammer/Ham_Lo_Default_Normal.dds";
   diffuseMap[2] = "art/TexturesSH/Tool/hammer/Ham_Lo_Default_SpecularSmoothness.dds";
};
//----------------------------------------machete--------------------------
singleton Material(Machete_rough_Lo_Default_AlbedoTransparency_mat)            
{
   mapTo = "Machete_rough_Lo_Default_AlbedoTransparency";
   diffuseMap[0] = "art/TexturesSH/Tool/machete/Machete_rough_Lo_Default_AlbedoTransparency.dds";
   diffuseMap[1] = "art/TexturesSH/Tool/machete/Machete_rough_Lo_Default_Normal.dds";
   diffuseMap[2] = "art/TexturesSH/Tool/machete/Machete_rough_Lo_Default_SpecularSmoothness.dds"; 
};

singleton Material(Machete_rough_Lo_Default_AlbedoTransparency_Rjav_mat)            
{
   mapTo = "Machete_rough_Lo_Default_AlbedoTransparency_Rjav";
   diffuseMap[0] = "art/TexturesSH/Tool/machete/Machete_rough_Lo_Default_AlbedoTransparency_Rjav.dds";
   diffuseMap[1] = "art/TexturesSH/Tool/machete/Pick_Lo_Default_Normal.dds";
   diffuseMap[2] = "art/TexturesSH/Tool/machete/Pick_Lo_Default_SpecularSmoothness.dds";
};
singleton Material(Machete_rough_Lo_Default_AlbedoTransparency_Cop_mat)            
{
   mapTo = "Machete_rough_Lo_Default_AlbedoTransparency_Cop";
   diffuseMap[0] = "art/TexturesSH/Tool/machete/Machete_rough_Lo_Default_AlbedoTransparency_Cop.dds";
   diffuseMap[1] = "art/TexturesSH/Tool/machete/Pick_Lo_Default_Normal.dds";
   diffuseMap[2] = "art/TexturesSH/Tool/machete/Pick_Lo_Default_SpecularSmoothness.dds";
};
//----------------------------------------pickaxe--------------------------
singleton Material(Pick_Lo_Default_AlbedoTransparency_mat)            
{
   mapTo = "Pick_Lo_Default_AlbedoTransparency";
   diffuseMap[0] = "art/TexturesSH/Tool/pickaxe/Pick_Lo_Default_AlbedoTransparency.dds";
   diffuseMap[1] = "art/TexturesSH/Tool/pickaxe/Pick_Lo_Default_Normal.dds";
   diffuseMap[2] = "art/TexturesSH/Tool/pickaxe/Pick_Lo_Default_SpecularSmoothness.dds"; 
};
singleton Material(Pick_Lo_Default_AlbedoTransparency_Cop_mat)            
{
   mapTo = "Pick_Lo_Default_AlbedoTransparency_Cop";
   diffuseMap[0] = "art/TexturesSH/Tool/pickaxe/Pick_Lo_Default_AlbedoTransparency_Cop.dds";
   diffuseMap[1] = "art/TexturesSH/Tool/pickaxe/Pick_Lo_Default_Normal.dds";
   diffuseMap[2] = "art/TexturesSH/Tool/pickaxe/Pick_Lo_Default_SpecularSmoothness.dds"; 
};
singleton Material(Pick_Lo_Default_AlbedoTransparency_Rjav_mat)            
{
   mapTo = "Pick_Lo_Default_AlbedoTransparency_Rjav";
   diffuseMap[0] = "art/TexturesSH/Tool/pickaxe/Pick_Lo_Default_AlbedoTransparency_Rjav.dds";
   diffuseMap[1] = "art/TexturesSH/Tool/pickaxe/Pick_Lo_Default_Normal.dds";
   diffuseMap[2] = "art/TexturesSH/Tool/pickaxe/Pick_Lo_Default_SpecularSmoothness.dds"; 
};
//----------------------------------------rod--------------------------
singleton Material(Rod_Default_mat)            
{
   mapTo = "Rod_Default";
   diffuseMap[0] = "art/TexturesSH/Tool/rod/Rod_Default.dds";
   diffuseMap[1] = "art/TexturesSH/Tool/rod/Rod_Normal.dds";
};
//----------------------------------------saw--------------------------
singleton Material(Saw_lo_Fin_Default_AlbedoTransparency_Rjav_mat)            
{
   mapTo = "Saw_lo_Fin_Default_AlbedoTransparency_Rjav";
   diffuseMap[0] = "art/TexturesSH/Tool/saw/Saw_lo_Fin_Default_AlbedoTransparency_Rjav.dds";
   diffuseMap[1] = "art/TexturesSH/Tool/saw/Saw_lo_Fin_Default_Normal.dds";
   diffuseMap[2] = "art/TexturesSH/Tool/saw/Saw_lo_Fin_Default_SpecularSmoothness.dds";
};
singleton Material(Saw_lo_Fin_Default_AlbedoTransparency_Cop_mat)            
{
   mapTo = "Saw_lo_Fin_Default_AlbedoTransparency_Cop";
   diffuseMap[0] = "art/TexturesSH/Tool/saw/Saw_lo_Fin_Default_AlbedoTransparency_Cop.dds";
   diffuseMap[1] = "art/TexturesSH/Tool/saw/Saw_lo_Fin_Default_Normal.dds";
   diffuseMap[2] = "art/TexturesSH/Tool/saw/Saw_lo_Fin_Default_SpecularSmoothness.dds";
};
singleton Material(Saw_lo_Fin_Default_AlbedoTransparency_mat)            
{
   mapTo = "Saw_lo_Fin_Default_AlbedoTransparency";
   diffuseMap[0] = "art/TexturesSH/Tool/saw/Saw_lo_Fin_Default_AlbedoTransparency.dds";
   diffuseMap[1] = "art/TexturesSH/Tool/saw/Saw_lo_Fin_Default_Normal.dds";
   diffuseMap[2] = "art/TexturesSH/Tool/saw/Saw_lo_Fin_Default_SpecularSmoothness.dds"; 
};
//----------------------------------------shovel--------------------------
singleton Material(Ruchka_lo_Default_AlbedoTransparency_mat)            
{
   mapTo = "Ruchka_lo_Default_AlbedoTransparency";
   diffuseMap[0] = "art/TexturesSH/Tool/shovel/Ruch/Ruchka_lo_Default_AlbedoTransparency.dds";
   diffuseMap[1] = "art/TexturesSH/Tool/shovel/Ruch/Ruchka_lo_Default_Normal.dds";
   diffuseMap[2] = "art/TexturesSH/Tool/shovel/Ruch/Ruchka_lo_Default_SpecularSmoothness.dds"; 
};
singleton Material(Kopalo_lo_Default_AlbedoTransparency_mat)            
{
   mapTo = "Kopalo_lo_Default_AlbedoTransparency";
   diffuseMap[0] = "art/TexturesSH/Tool/shovel/Stal/Kopalo_lo_Default_AlbedoTransparency.dds";
   diffuseMap[1] = "art/TexturesSH/Tool/shovel/Stal/Kopalo_lo_Default_Normal.dds";
   diffuseMap[2] = "art/TexturesSH/Tool/shovel/Stal/Kopalo_lo_Default_SpecularSmoothness.dds";
};
singleton Material(Kopalo_lo_Default_AlbedoTransparencyCop_mat)            
{
   mapTo = "Kopalo_lo_Default_AlbedoTransparencyCop";
   diffuseMap[0] = "art/TexturesSH/Tool/shovel/Cop/Kopalo_lo_Default_AlbedoTransparencyCop.dds";
   diffuseMap[1] = "art/TexturesSH/Tool/shovel/Cop/Kopalo_lo_Default_Normal.dds";
   diffuseMap[2] = "art/TexturesSH/Tool/shovel/Cop/Kopalo_lo_Default_SpecularSmoothness.dds"; 
};
singleton Material(Kopalo_lo_Default_AlbedoTransparency_Rjav_mat)            
{
   mapTo = "Kopalo_lo_Default_AlbedoTransparency_Rjav";
   diffuseMap[0] = "art/TexturesSH/Tool/shovel/Rjav/Kopalo_lo_Default_AlbedoTransparency_Rjav.dds";
   diffuseMap[1] = "art/TexturesSH/Tool/shovel/Cop/Kopalo_lo_Default_Normal.dds";
   diffuseMap[2] = "art/TexturesSH/Tool/shovel/Cop/Kopalo_lo_Default_SpecularSmoothness.dds"; 
};
//----------------------------------------slingshot--------------------------
singleton Material(slingshot_LO_Default_AlbedoTransparency_mat)            
{
   mapTo = "slingshot_LO_Default_AlbedoTransparency";
   diffuseMap[0] = "art/TexturesSH/Tool/slingshot/slingshot_LO_Default_AlbedoTransparency.dds";
   diffuseMap[1] = "art/TexturesSH/Tool/slingshot/slingshot_LO_Default_Normal.dds";
   diffuseMap[2] = "art/TexturesSH/Tool/slingshot/slingshot_LO_Default_SpecularSmoothness.dds"; 
skinned = true;
};
//----------------------------------------Environment---
//------Rock-----
singleton Material(Rock_DetB_mat)
{
   mapTo = "Rock_DetB";
   diffuseMap[0] = "art/Textures/GroundCover/Rock_Det.dds";
   diffuseMap[1] = "art/Textures/GroundCover/Rock_Det_B_norm.dds";
};
singleton Material(Rock_Det_mat)
{
   mapTo = "Rock_Det";
   diffuseMap[0] = "art/Textures/GroundCover/Rock_Det.dds";
   diffuseMap[1] = "art/Textures/GroundCover/Rock_Det_B_norm.dds";
};

singleton Material(SnowDriftA_mat)
{
   mapTo = "SnowDriftA";
   diffuseMap[0] = "art/Textures/GroundCover/Rock_Det.dds";
   diffuseMap[1] = "art/Textures/GroundCover/Rock_Det_B_norm.dds";
};


//------glass-----
singleton Material(glass_diff_mat)
{
   mapTo = "glass_diff";
   diffuseMap[0] = "art/TexturesSH/glass_diff.dds";
   diffuseMap[2] = "art/TexturesSH/glass_spec.dds";
   materialTag0 = "LiF";
   doubleSided = "1";
   translucent = "1";
   translucentBlendOp = "LerpAlpha";
   translucentZWrite = "1";
   alphaTest = "1";
   doNotZWrite = "1";
};

singleton Material(F_glass_diff_mat)
{
   mapTo = "F_glass_diff";
   diffuseMap[0] = "art/TexturesSH/glass_diff.dds";
   diffuseMap[2] = "art/TexturesSH/glass_spec.dds";
   materialTag0 = "LiF";
   doubleSided = "1";
   translucent = "1";
   translucentBlendOp = "LerpAlpha";
   translucentZWrite = "1";
   alphaTest = "1";
   doNotZWrite = "1";
   skinned = true;
};
//Tunnel walls, floor and ceiling-----------------------------------------------------------------------------------------------

// soil
singleton Material(TunnelWallsMaterial)
{
   mapTo = "unmapped_mat";
   diffuseMap[0] = "art/Textures/TunnelTextures/Soil/Soil_wall_diff.dds";
   diffuseMap[1] = "art/Textures/TunnelTextures/Soil/Soil_wall_nm.dds";
   materialTag0 = "tunnel";
   streamable = "0";
};

singleton Material(TunnelFloorMaterial)
{
   mapTo = "unmapped_mat";
   diffuseMap[0] = "art/Textures/TunnelTextures/Soil/Soil_floor_diff.dds";
   diffuseMap[1] = "art/Textures/TunnelTextures/Clay/u_floor_nm.dds";
   materialTag0 = "tunnel";
   streamable = "0";
};

singleton Material(TunnelCeilingMaterial)
{
   mapTo = "unmapped_mat";
   diffuseMap[0] = "art/Textures/TunnelTextures/Soil/Soil_ceiling_diff.dds";
   materialTag0 = "tunnel";
   diffuseMap[1] = "art/Textures/TunnelTextures/Clay/u_ceiling_nm.dds";
   streamable = "0";
};

//SteppeSoil
singleton Material(TunnelWallsSteppeSoilMaterial)
{
   mapTo = "unmapped_mat";
   diffuseMap[0] = "art/Textures/TunnelTextures/Soil/Soil_wall_diff.dds";
   diffuseMap[1] = "art/Textures/TunnelTextures/Soil/Soil_wall_nm.dds";
   materialTag0 = "tunnel";
   diffuseColor[0] = "1 0.835294 0 1";
   streamable = "0";
};

singleton Material(TunnelFloorSteppeSoilMaterial)
{
   mapTo = "unmapped_mat";
   diffuseMap[0] = "art/Textures/TunnelTextures/Soil/Soil_floor_diff.dds";
   diffuseMap[1] = "art/Textures/TunnelTextures/Clay/u_floor_nm.dds";
   materialTag0 = "tunnel";
   diffuseColor[0] = "1 0.835294 0 1";
   streamable = "0";
};

singleton Material(TunnelCeilingSteppeSoilMaterial)
{
   mapTo = "unmapped_mat";
   diffuseMap[0] = "art/Textures/TunnelTextures/Soil/Soil_ceiling_diff.dds";
   materialTag0 = "tunnel";
   diffuseMap[1] = "art/Textures/TunnelTextures/Clay/u_ceiling_nm.dds";
   diffuseColor[0] = "1 0.835294 0 1";
   streamable = "0";
};

//Rock
singleton Material(TunnelWallsRockMaterial)
{
   mapTo = "unmapped_mat";
   diffuseMap[0] = "art/Textures/TunnelTextures/Rock/Rock_wall.dds";
   diffuseMap[1] = "art/Textures/TunnelTextures/Rock/Rock_wall_nm.dds";
   materialTag0 = "tunnel";
 //diffuseMap[2] = "art/Textures/TunnelTextures/Rock/Rock_spec.dds";
   streamable = "0";
};

singleton Material(TunnelFloorRockMaterial)
{
   mapTo = "unmapped_mat";
   diffuseMap[0] = "art/Textures/TunnelTextures/Rock/Rock_floor.dds";
   diffuseMap[1] = "art/Textures/TunnelTextures/Rock/Rock_floor_nm.dds";
   materialTag0 = "tunnel";
   streamable = "0";
};

singleton Material(TunnelCeilingRockMaterial)
{
   mapTo = "unmapped_mat";
   diffuseMap[0] = "art/Textures/TunnelTextures/Rock/Rock_ceiling.dds";
   materialTag0 = "tunnel";
   diffuseMap[1] = "art/Textures/TunnelTextures/Rock/Rock_ceiling_nm.dds";
   streamable = "0";
};

//RockBare
singleton Material(TunnelWallsRockBareMaterial)
{
   mapTo = "unmapped_mat";
   diffuseMap[0] = "art/2D/Terrain/Substances/Rock_Fragments/Rock_Frag_diff.DDS";
   diffuseMap[1] = "art/2D/Terrain/Substances/Rock_Fragments/Rock_Frag_nm.DDS";
   materialTag0 = "tunnel";
   streamable = "0";
};

//Granite
singleton Material(TunnelWallsGraniteMaterial)
{
   mapTo = "unmapped_mat";
   diffuseMap[0] = "art/Textures/TunnelTextures/Granite/Granite_wall.dds";
   diffuseMap[1] = "art/Textures/TunnelTextures/Rock/Rock_wall_nm.dds";
   materialTag0 = "tunnel";
   streamable = "0";
};

singleton Material(TunnelFloorGraniteMaterial)
{
   mapTo = "unmapped_mat";
   diffuseMap[0] = "art/Textures/TunnelTextures/Granite/Granite_floor.dds";
   diffuseMap[1] = "art/Textures/TunnelTextures/Rock/Rock_floor_nm.dds";
   materialTag0 = "tunnel";
   streamable = "0";
};

singleton Material(TunnelCeilingGraniteMaterial)
{
   mapTo = "unmapped_mat";
   diffuseMap[0] = "art/Textures/TunnelTextures/Granite/Granite_ceiling.dds";
   diffuseMap[1] = "art/Textures/TunnelTextures/Rock/Rock_ceiling_nm.dds";
   materialTag0 = "tunnel";
   streamable = "0";
};

//GraniteFrag
singleton Material(TunnelWallsGraniteFragMaterial)
{
   mapTo = "unmapped_mat";
   diffuseMap[0] = "art/2D/Terrain/Substances/Granite_fragments/Granite_Frag_diff.dds";
   diffuseMap[1] = "art/2D/Terrain/Substances/Granite_fragments/Granite_Frag_nm.dds";
   materialTag0 = "tunnel";
   streamable = "0";
};

//Marble
singleton Material(TunnelWallsMarbleMaterial)
{
   mapTo = "unmapped_mat";
   diffuseMap[0] = "art/Textures/TunnelTextures/Marble/Marble_wall.dds";
   diffuseMap[1] = "art/Textures/TunnelTextures/Rock/Rock_wall_nm.dds";
   materialTag0 = "tunnel";
   streamable = "0";
};

singleton Material(TunnelFloorMarbleMaterial)
{
   mapTo = "unmapped_mat";
   diffuseMap[0] = "art/Textures/TunnelTextures/Marble/Marble_floor.dds";
   diffuseMap[1] = "art/Textures/TunnelTextures/Rock/Rock_floor_nm.dds";
   materialTag0 = "tunnel";
   streamable = "0";
};

singleton Material(TunnelCeilingMarbleMaterial)
{
   mapTo = "unmapped_mat";
   diffuseMap[0] = "art/Textures/TunnelTextures/Marble/Marble_ceiling.dds";
   materialTag0 = "tunnel";
   diffuseMap[1] = "art/Textures/TunnelTextures/Rock/Rock_ceiling_nm.dds";
   streamable = "0";
};

//MarbleFrag
singleton Material(TunnelWallsMarbleFragMaterial)
{
   mapTo = "unmapped_mat";
   diffuseMap[0] = "art/2D/Terrain/Substances/Marble_fragments/Marble_frag_diff.dds";
   diffuseMap[1] = "art/2D/Terrain/Substances/Rock_Fragments/Rock_Frag_nm.DDS";
   materialTag0 = "tunnel";
   streamable = "0";
};

//Slate
singleton Material(TunnelWallsSlateMaterial)
{
   mapTo = "unmapped_mat";
   diffuseMap[0] = "art/Textures/TunnelTextures/Slate/Slate_wall.dds";
   diffuseMap[1] = "art/Textures/TunnelTextures/Rock/Rock_wall_nm.dds";
   materialTag0 = "tunnel";
   streamable = "0";
};

singleton Material(TunnelFloorSlateMaterial)
{
   mapTo = "unmapped_mat";
   diffuseMap[0] = "art/Textures/TunnelTextures/Slate/Slate_floor.dds";
   diffuseMap[1] = "art/Textures/TunnelTextures/Rock/Rock_floor_nm.dds";
   materialTag0 = "tunnel";
   streamable = "0";
};

singleton Material(TunnelCeilingSlateMaterial)
{
   mapTo = "unmapped_mat";
   diffuseMap[0] = "art/Textures/TunnelTextures/Slate/Slate_ceiling.dds";
   materialTag0 = "tunnel";
   diffuseMap[1] = "art/Textures/TunnelTextures/Rock/Rock_ceiling_nm.dds";
   streamable = "0";
};

//SlateFrag
singleton Material(TunnelWallsSlateFragMaterial)
{
   mapTo = "unmapped_mat";
   diffuseMap[0] = "art/2D/Terrain/Substances/Slate_fragments/Slate_frag_diff.dds";
   diffuseMap[1] = "art/2D/Terrain/Substances/Rock_Fragments/Rock_Frag_nm.DDS";
   materialTag0 = "tunnel";
   streamable = "0";
};

//GoldOre
singleton Material(TunnelWallsGoldOreMaterial)
{
   mapTo = "unmapped_mat";
   diffuseMap[0] = "art/Textures/TunnelTextures/ORE/Ore_Gold_Vein_Dif.dds";
   diffuseMap[1] = "art/Textures/TunnelTextures/Rock/Rock_wall_nm.dds";
   materialTag0 = "tunnel";
   diffuseMap[2] = "art/Textures/TunnelTextures/ORE/Ore_Vein_Spec_.dds";
   streamable = "0";
};

singleton Material(TunnelFloorGoldOreMaterial)
{
   mapTo = "unmapped_mat";
   diffuseMap[0] = "art/Textures/TunnelTextures/ORE/Ore_Gold_Vein_Floor_Dif.dds";
   diffuseMap[1] = "art/Textures/TunnelTextures/Rock/Rock_floor_nm.dds";
   materialTag0 = "tunnel";
   diffuseMap[2] = "art/Textures/TunnelTextures/ORE/Ore_Vein_Spec_.dds";
   streamable = "0";
};

singleton Material(TunnelCeilingGoldOreMaterial)
{
   mapTo = "unmapped_mat";
   diffuseMap[0] = "art/Textures/TunnelTextures/ORE/Ore_Gold_Vein_Ceiling_Dif.dds";
   materialTag0 = "tunnel";
   diffuseMap[1] = "art/Textures/TunnelTextures/Rock/Rock_ceiling_nm.dds";
   diffuseMap[2] = "art/Textures/TunnelTextures/ORE/Ore_Vein_Spec_.dds";
   streamable = "0";
};

//GoldOreFrag
singleton Material(TunnelWallsGoldOreFragMaterial)
{
   mapTo = "unmapped_mat";
   diffuseMap[0] = "art/2D/Terrain/Substances/Gold_ore/Gold_Ore_diff.dds";
   diffuseMap[1] = "art/2D/Terrain/Substances/Rock_Fragments/Rock_Frag_nm.DDS";
   materialTag0 = "tunnel";
   streamable = "0";
};

//IronOre
singleton Material(TunnelFloorIronOreMaterial)
{
   mapTo = "unmapped_mat";
   diffuseMap[0] = "art/Textures/TunnelTextures/ORE/Ore_Iron_Vein_Floor_Dif.dds";
   diffuseMap[1] = "art/Textures/TunnelTextures/Rock/Rock_floor_nm.dds";
   materialTag0 = "tunnel";
   diffuseMap[2] = "art/Textures/TunnelTextures/ORE/Ore_Vein_Spec_.dds";
   streamable = "0";
};

singleton Material(TunnelCeilingIronOreMaterial)
{
   mapTo = "unmapped_mat";
   diffuseMap[0] = "art/Textures/TunnelTextures/ORE/Ore_Iron_Vein_Ceiling_Dif.dds";
   diffuseMap[1] = "art/Textures/TunnelTextures/Rock/Rock_ceiling_nm.dds";
   materialTag0 = "tunnel";
   diffuseMap[2] = "art/Textures/TunnelTextures/ORE/Ore_Vein_Spec_.dds";
   streamable = "0";
};

singleton Material(TunnelWallsIronOreMaterial)
{
   mapTo = "unmapped_mat";
   diffuseMap[0] = "art/Textures/TunnelTextures/ORE/Ore_Iron_Vein_Dif.dds";
   diffuseMap[1] = "art/Textures/TunnelTextures/Rock/Rock_wall_nm.dds";
   materialTag0 = "tunnel";
   diffuseMap[2] = "art/Textures/TunnelTextures/ORE/Ore_Vein_Spec_.dds";
   streamable = "0";
};

//IronOreFrag
singleton Material(TunnelWallsIronOreFragMaterial)
{
   mapTo = "unmapped_mat";
   diffuseMap[0] = "art/2D/Terrain/Substances/Iron_ore/Iron_Ore_diff.dds";
   materialTag0 = "tunnel";
   diffuseMap[1] = "art/2D/Terrain/Substances/Rock_Fragments/Rock_Frag_nm.DDS";
   streamable = "0";
};

//SilverOre
singleton Material(TunnelFloorSilverOreMaterial)
{
   mapTo = "unmapped_mat";
   diffuseMap[0] = "art/Textures/TunnelTextures/ORE/Ore_Silver_Vein_Floor_Dif.dds";
   diffuseMap[1] = "art/Textures/TunnelTextures/Rock/Rock_floor_nm.dds";
   materialTag0 = "tunnel";
   diffuseMap[2] = "art/Textures/TunnelTextures/ORE/Ore_Vein_Spec_.dds";
   streamable = "0";
};

singleton Material(TunnelCeilingSilverOreMaterial)
{
   mapTo = "unmapped_mat";
   diffuseMap[0] = "art/Textures/TunnelTextures/ORE/Ore_Silver_Vein_Ceiling_Dif.dds";
   diffuseMap[1] = "art/Textures/TunnelTextures/Rock/Rock_ceiling_nm.dds";
   materialTag0 = "tunnel";
   diffuseMap[2] = "art/Textures/TunnelTextures/ORE/Ore_Vein_Spec_.dds";
   streamable = "0";
};

singleton Material(TunnelWallsSilverOreMaterial)
{
   mapTo = "unmapped_mat";
   diffuseMap[0] = "art/Textures/TunnelTextures/ORE/Ore_Silver_Vein_Dif.dds";
   diffuseMap[1] = "art/Textures/TunnelTextures/Rock/Rock_wall_nm.dds";
   materialTag0 = "tunnel";
   diffuseMap[2] = "art/Textures/TunnelTextures/ORE/Ore_Vein_Spec_.dds";
   streamable = "0";
};

//SilverOreFrag
singleton Material(TunnelWallsSilverOreFragMaterial)
{
   mapTo = "unmapped_mat";
   diffuseMap[0] = "art/2D/Terrain/Substances/Silver_ore/Silver_Ore_diff.dds";
   materialTag0 = "tunnel";
   diffuseMap[1] = "art/2D/Terrain/Substances/Silver_ore/Silver_Ore_nm.DDS";
   streamable = "0";
};

//CopperOre
singleton Material(TunnelFloorCopperOreMaterial)
{
   mapTo = "unmapped_mat";
   diffuseMap[0] = "art/Textures/TunnelTextures/ORE/Ore_Copper_Vein_Floor_Dif.dds";
   diffuseMap[1] = "art/Textures/TunnelTextures/Rock/Rock_floor_nm.dds";
   materialTag0 = "tunnel";
   diffuseMap[2] = "art/Textures/TunnelTextures/ORE/Ore_Vein_Spec_.dds";
   streamable = "0";
};

singleton Material(TunnelCeilingCopperOreMaterial)
{
   mapTo = "unmapped_mat";
   diffuseMap[0] = "art/Textures/TunnelTextures/ORE/Ore_Copper_Vein_Ceiling_Dif.dds";
   diffuseMap[1] = "art/Textures/TunnelTextures/Rock/Rock_ceiling_nm.dds";
   materialTag0 = "tunnel";
   diffuseMap[2] = "art/Textures/TunnelTextures/ORE/Ore_Vein_Spec_.dds";
   streamable = "0";
};

singleton Material(TunnelWallsCopperOreMaterial)
{
   mapTo = "unmapped_mat";
   diffuseMap[0] = "art/Textures/TunnelTextures/ORE/Ore_Copper_Vein_Dif.dds";
   diffuseMap[1] = "art/Textures/TunnelTextures/Rock/Rock_wall_nm.dds";
   materialTag0 = "tunnel";
   diffuseMap[2] = "art/Textures/TunnelTextures/ORE/Ore_Vein_Spec_.dds";
   streamable = "0";
};

//CopperOreFrag
singleton Material(TunnelWallsCopperOreFragMaterial)
{
   mapTo = "unmapped_mat";
   diffuseMap[0] = "art/2D/Terrain/Substances/Copper_ore/Copper_Ore_diff.dds";
   materialTag0 = "tunnel";
   diffuseMap[1] = "art/2D/Terrain/Substances/Rock_Fragments/Rock_Frag_nm.DDS";
   streamable = "0";
};

//Sand
singleton Material(TunnelWallsSandMaterial)
{
   mapTo = "unmapped_mat";
   diffuseMap[0] = "art/Textures/TunnelTextures/Sand/Sand_wall.dds";
   diffuseMap[1] = "art/Textures/TunnelTextures/Soil/Soil_wall_nm.dds";
   materialTag0 = "tunnel";
   streamable = "0";
};

//Clay
singleton Material(TunnelWallsClayMaterial)
{
   mapTo = "unmapped_mat";
   diffuseMap[0] = "art/Textures/TunnelTextures/Clay/Clay_wall_diff.dds";
   diffuseMap[1] = "art/Textures/TunnelTextures/Clay/Clay_wall_nm.dds";
   materialTag0 = "tunnel";
   streamable = "0";
};

singleton Material(TunnelFloorClayMaterial)
{
   mapTo = "unmapped_mat";
   diffuseMap[0] = "art/Textures/TunnelTextures/Clay/Clay_floor_diff.dds";
   diffuseMap[1] = "art/Textures/TunnelTextures/Clay/u_floor_nm.dds";
   materialTag0 = "tunnel";
   streamable = "0";
};

singleton Material(TunnelCeilingClayMaterial)
{
   mapTo = "unmapped_mat";
   diffuseMap[0] = "art/Textures/TunnelTextures/Clay/Clay_ceiling_diff.dds";
   materialTag0 = "tunnel";
   diffuseMap[1] = "art/Textures/TunnelTextures/Clay/u_ceiling_nm.dds";
   streamable = "0";
};

//Snow
singleton Material(TunnelWallsSnowMaterial)
{
   mapTo = "unmapped_mat";
   diffuseMap[0] = "art/2D/Terrain/Substances/Snow/Snow_diff.dds";
   diffuseMap[1] = "art/2D/Terrain/Substances/Snow/Snow_nm.dds";
   materialTag0 = "tunnel";
   streamable = "0";
};

//Swamp
singleton Material(TunnelWallsSwampMaterial)
{
   mapTo = "unmapped_mat";
   diffuseMap[0] = "art/Textures/TunnelTextures/Swamp/Swamp_wall_diff.dds";
   diffuseMap[1] = "art/Textures/TunnelTextures/Swamp/Swamp_wall_nm.dds";
   materialTag0 = "tunnel";
   diffuseMap[2] = "art/Textures/TunnelTextures/Swamp/Swamp_wall_spec.dds";
   streamable = "0";
};
//--SKYBOX------------
singleton CubemapData(FairCubemap)
{
   cubeFace[0] = "art/2D/Skybox/FairSky/sky_Fair_Right.dds";
   cubeFace[1] = "art/2D/Skybox/FairSky/sky_Fair_Left.dds";
   cubeFace[2] = "art/2D/Skybox/FairSky/sky_Fair_Back.dds";
   cubeFace[3] = "art/2D/Skybox/FairSky/sky_Fair_Front.dds";
   cubeFace[4] = "art/2D/Skybox/FairSky/sky_Fair_Top.dds";
   cubeFace[5] = "art/2D/Skybox/FairSky/sky_Fair_Bottom.dds";
};

singleton CubemapData(DuskLightCubemap)
{
   cubeFace[0] = "art/2D/Skybox/DuskLight/sky_dusk_Right.dds";
   cubeFace[1] = "art/2D/Skybox/DuskLight/sky_dusk_Left.dds";
   cubeFace[2] = "art/2D/Skybox/DuskLight/sky_dusk_Back.dds";
   cubeFace[3] = "art/2D/Skybox/DuskLight/sky_dusk_Front.dds";
   cubeFace[4] = "art/2D/Skybox/DuskLight/sky_dusk_Top.dds";
   cubeFace[5] = "art/2D/Skybox/DuskLight/sky_dusk_Bottom.dds";
};

singleton CubemapData(DuskLight2Cubemap)
{
   cubeFace[0] = "art/2D/Skybox/DuskLight2/sky_dusk2_Right.dds";
   cubeFace[1] = "art/2D/Skybox/DuskLight2/sky_dusk2_Left.dds";
   cubeFace[2] = "art/2D/Skybox/DuskLight2/sky_dusk2_Back.dds";
   cubeFace[3] = "art/2D/Skybox/DuskLight2/sky_dusk2_Front.dds";
   cubeFace[4] = "art/2D/Skybox/DuskLight2/sky_dusk2_Top.dds";
   cubeFace[5] = "art/2D/Skybox/DuskLight2/sky_dusk2_Bottom.dds";
};

singleton CubemapData(NightCubemap)
{
   cubeFace[0] = "art/2D/Skybox/nightSky/nightSky_1.dds";
   cubeFace[1] = "art/2D/Skybox/nightSky/nightSky_2.dds";
   cubeFace[2] = "art/2D/Skybox/nightSky/nightSky_3.dds";
   cubeFace[3] = "art/2D/Skybox/nightSky/nightSky_4.dds";
   cubeFace[4] = "art/2D/Skybox/nightSky/nightSky_5.dds";
   cubeFace[5] = "art/2D/Skybox/nightSky/nightSky_6.dds";
};

singleton CubemapData(FoggyCubemap)
{
   cubeFace[0] = "art/2D/Skybox/FoggySky/sky_Foggy_Right.dds";
   cubeFace[1] = "art/2D/Skybox/FoggySky/sky_Foggy_Left.dds";
   cubeFace[2] = "art/2D/Skybox/FoggySky/sky_Foggy_Back.dds";
   cubeFace[3] = "art/2D/Skybox/FoggySky/sky_Foggy_Front.dds";
   cubeFace[4] = "art/2D/Skybox/FoggySky/sky_Foggy_Top.dds";
   cubeFace[5] = "art/2D/Skybox/FoggySky/sky_Foggy_Bottom.dds";
};

singleton CubemapData(SnowyCubemap)
{
   cubeFace[0] = "art/2D/Skybox/SnowySky/Sky_Snowy_Right.dds";
   cubeFace[1] = "art/2D/Skybox/SnowySky/Sky_Snowy_Left.dds";
   cubeFace[2] = "art/2D/Skybox/SnowySky/Sky_Snowy_Back.dds";
   cubeFace[3] = "art/2D/Skybox/SnowySky/Sky_Snowy_Front.dds";
   cubeFace[4] = "art/2D/Skybox/SnowySky/Sky_Snowy_Top.dds";
   cubeFace[5] = "art/2D/Skybox/SnowySky/Sky_Snowy_Bottom.dds";
};

singleton CubemapData(CloudyCubemap)
{
   cubeFace[0] = "art/2D/Skybox/CloudySky/sky_Cloudy_Right.dds";
   cubeFace[1] = "art/2D/Skybox/CloudySky/sky_Cloudy_Left.dds";
   cubeFace[2] = "art/2D/Skybox/CloudySky/sky_Cloudy_Back.dds";
   cubeFace[3] = "art/2D/Skybox/CloudySky/sky_Cloudy_Front.dds";
   cubeFace[4] = "art/2D/Skybox/CloudySky/sky_Cloudy_Top.dds";
   cubeFace[5] = "art/2D/Skybox/CloudySky/sky_Cloudy_Bottom.dds";
};

//---------TOMATO---
singleton Material(all_plants_diff_mat)
{
   mapTo = "all_plants_diff";
   diffuseMap[0] = "art/Textures/GroundCover/all_plants_diff.dds";
   diffuseMap[1] = "art/Textures/GroundCover/all_plants_nm.dds";
   doubleSided = "1";
   translucent = "0";
   materialTag0 = "LiF";
   translucentBlendOp = "None";
   alphaTest = "1";
   alphaRef = "30";
   streamable = "0";
   normalsUp = "1";
};

//--------------END TOOLS------------
