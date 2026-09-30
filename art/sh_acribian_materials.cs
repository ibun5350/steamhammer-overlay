//-----------------------------------------------------------------------------
// Steam Hammer: materials for the Acribian player model (sh_acribian_male.dts).
// Body / head / hair / beard / underwear materials copied verbatim from
// Life is Feudal art/materials.cs (textures in art/Textures/CharacterTextures/
// Customization/male). Female equivalents already exist in art/female_materials.cs.
//-----------------------------------------------------------------------------

singleton Material(Male_Beard_All_v2_DIFFUSE_mat)//Борода 2
{
   // SH: LiF ships no Male_Beard_All_v2 textures - uses the v1 beard textures
   mapTo = "Male_Beard_All_v2_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Beard_All_v1_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Beard_All_v1_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Beard_All_v1_SPECULAR.dds";
   alphaTest = "1";
   doubleSided = "1";
   translucent = "0";
   alphaRef = "35";
   useCustomColor = true;
   isHair = true;
   materialTag0 = "LiF";
   mipLODBias = -1.2;
   useAnisotropic[0] = "1";
   translucentZWrite = "1";
   skinned = true;
};

singleton Material(Male_Beard_All_v4_DIFFUSE_mat2)//Борода 4
{
   mapTo = "Male_Beard_All_v4_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Beard_All_v4_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Beard_All_v4_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Beard_All_v4_SPECULAR.dds";
   alphaTest = "1";
   doubleSided = "1";
   translucent = "0";
   alphaRef = "80";
   useCustomColor = true;
   isHair = true;
   materialTag0 = "LiF";
   mipLODBias = -1.2;
   useAnisotropic[0] = "1";
   translucentZWrite = "1";
   skinned = true;
};

singleton Material(Male_Beard_Eur_v3_DIFFUSE_mat)//Борода евро 3
{
   mapTo = "Male_Beard_Eur_v3_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Beard_Eur_v3_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Beard_Eur_v3_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Beard_Eur_v3_SPECULAR.dds";
   alphaTest = "1";
   translucent = "0";
   doubleSided = "1";
   alphaRef = "35";
   useCustomColor = true;
   isHair = true;
   materialTag0 = "LiF";
   mipLODBias = -1.2;
   useAnisotropic[0] = "1";
   translucentZWrite = "1";
   skinned = true;
};

singleton Material(Male_Beard_Eur_v2_DIFFUSE_mat)
{
   mapTo = "Male_Beard_Eur_v2_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Beard_Eur_v2_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Beard_Eur_v2_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Beard_Eur_v2_SPECULAR.dds";
   alphaTest = "1";
   materialTag0 = "LiF";
   alphaRef = "50";
   doubleSided = "1";
   translucentZWrite = "1";
   translucentBlendOp = "LitAndBlendAlpha";
   mipLODBias = -2;
   useAnisotropic[0] = "1";
   useCustomColor = 1;
   isHair = 1;
   skinned = true;
};

singleton Material(Male_Beard_All_v1_DIFFUSE_mat)
{
   mapTo = "Male_Beard_All_v1_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Beard_All_v1_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Beard_All_v1_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Beard_All_v1_SPECULAR.dds";
   alphaTest = "1";
   translucent = "0";
   alphaRef = "35";
   doubleSided = "1";
   useCustomColor = true;
   isHair = true;
   materialTag0 = "LiF";
   mipLODBias = -1.2;
   useAnisotropic[0] = "1";
   translucentZWrite = "1";
   skinned = true;
};

singleton Material(Male_Beard_All_v3_DIFFUSE_mat)
{
   mapTo = "Male_Beard_All_v3_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Beard_All_v3_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Beard_All_v3_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Beard_All_v3_SPECULAR.dds";
   alphaTest = "1";
   translucent = "0";
   alphaRef = "35";
   doubleSided = "1";
   useCustomColor = true;
   isHair = true;
   materialTag0 = "LiF";
   mipLODBias = -1.2;
   useAnisotropic[0] = "1";
   translucentZWrite = "1";
   skinned = true;
};

singleton Material(Male_Beard_Eur_v1_DIFFUSE_mat)
{
   mapTo = "Male_Beard_Eur_v1_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Beard_Eur_v1_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Beard_Eur_v1_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Beard_Eur_v1_SPECULAR.dds";
   alphaTest = "1";
   translucent = "0";
   alphaRef = "35";
   doubleSided = "1";
   useCustomColor = true;
   isHair = true;
   materialTag0 = "LiF";
   mipLODBias = -1.2;
   useAnisotropic[0] = "1";
   translucentZWrite = "1";
   skinned = true;
};

singleton Material(Male_Beard_Eur_v4_DIFFUSE_mat)
{
   mapTo = "Male_Beard_Eur_v4_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Beard_Eur_v4_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Beard_Eur_v4_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Beard_Eur_v4_SPECULAR.dds";
   alphaTest = "1";
   translucent = "0";
   alphaRef = "35";
   doubleSided = "1";
   useCustomColor = true;
   isHair = true;
   materialTag0 = "LiF";
   mipLODBias = -1.2;
   useAnisotropic[0] = "1";
   translucentZWrite = "1";
   skinned = true;
};

singleton Material(Male_Hair_All_v1_DIFFUSE_mat) //мужская прическа 1
{
   mapTo = "Male_Hair_All_v1_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Hair_All_v1_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Hair_All_v1_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Hair_All_v1_SPECULAR.dds";
   alphaTest = "1";
   translucent = "0";
   alphaRef = "35";
   doubleSided = "1";
   useCustomColor = true;
   isHair = true;
   materialTag0 = "LiF";
   mipLODBias = -1.2;
   useAnisotropic[0] = "1";
   skinned = true;
};

singleton Material(Male_Hair_All_v2_DIFFUSE_mat) //мужская прическа 2
{
   mapTo = "Male_Hair_All_v2_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Hair_All_v2_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Hair_All_v2_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Hair_All_v2_SPECULAR.dds";
   alphaTest = "1";
   translucent = "0";
   alphaRef = "35";
   doubleSided = "1";
   useCustomColor = true;
   isHair = true;
   materialTag0 = "LiF";
   mipLODBias = -1.2;
   useAnisotropic[0] = "1";
   skinned = true;
};

singleton Material(Male_Hair_All_v4_DIFFUSE_mat) //мужская прическа 4
{
   mapTo = "Male_Hair_All_v4_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Hair_All_v4_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Hair_All_v4_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Hair_All_v4_SPECULAR.dds";
   alphaTest = "1";
   translucent = "0";
   alphaRef = "35";
   doubleSided = "1";
   useCustomColor = true;
   isHair = true;
   materialTag0 = "LiF";
   mipLODBias = -1.2;
   useAnisotropic[0] = "1";
   skinned = true;
};

singleton Material(Male_Hair_Eur_v1_DIFFUSE_mat) //мужская евро прическа 1
{
   mapTo = "Male_Hair_Eur_v1_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Hair_Eur_v1_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Hair_Eur_v1_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Hair_Eur_v1_SPECULAR.dds";
   alphaTest = "1";
   translucent = "0";
   alphaRef = "35";
   doubleSided = "1";
   useCustomColor = true;
   isHair = true;
   materialTag0 = "LiF";
   mipLODBias = -1.2;
   useAnisotropic[0] = "1";
   skinned = true;
};

singleton Material(Male_Hair_Eur_v2_DIFFUSE_mat)
{
   mapTo = "Male_Hair_Eur_v2_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Hair_Eur_v2_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Hair_Eur_v2_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Hair_Eur_v2_SPECULAR.dds";
   alphaTest = "1";
   materialTag0 = "LiF";
   alphaRef = "50";
   doubleSided = "1";
   translucentZWrite = "1";
   translucentBlendOp = "LitAndBlendAlpha";
   mipLODBias = -2;
   useAnisotropic[0] = "1";
   useCustomColor = 1;
   isHair = 1;
   skinned = true;
};

singleton Material(Male_Hair_Eur_v4_DIFFUSE_mat)
{
   mapTo = "Male_Hair_Eur_v4_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Hair_Eur_v4_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Hair_Eur_v4_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Hair_Eur_v4_SPECULAR.dds";
   alphaTest = "1";
   materialTag0 = "LiF";
   alphaRef = "50";
   doubleSided = "1";
   translucentZWrite = "1";
   translucentBlendOp = "LitAndBlendAlpha";
   mipLODBias = -2;
   useAnisotropic[0] = "1";
   useCustomColor = 1;
   isHair = 1;
   skinned = true;
};

singleton Material(Male_Hair_All_v3_DIFFUSE_mat)
{
   mapTo = "Male_Hair_All_v3_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Hair_All_v3_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Hair_All_v3_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Hair_All_v3_SPECULAR.dds";
   alphaTest = "1";
   translucent = "0";
   alphaRef = "35";
   useCustomColor = true;
   doubleSided = "1";
   isHair = true;
   materialTag0 = "LiF";
   mipLODBias = -1.2;
   useAnisotropic[0] = "1";
   translucentZWrite = "1";
   skinned = true;
};

singleton Material(Male_Hair_Eur_v3_DIFFUSE_mat)
{
   mapTo = "Male_Hair_Eur_v3_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Hair_Eur_v3_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Hair_Eur_v3_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Hair_Eur_v3_SPECULAR.dds";
   alphaTest = "1";
   translucent = "0";
   alphaRef = "35";
   doubleSided = "1";
   useCustomColor = true;
   isHair = true;
   materialTag0 = "LiF";
   mipLODBias = -1.2;
   useAnisotropic[0] = "1";
   translucentZWrite = "1";
   skinned = true;
};

singleton Material(Male_Head_Eur_v1_DIFFUSE_mat)//Муж. европейская голова v1
{
   mapTo = "Male_Head_Eur_v1_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Male_Head_Eur_v1_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Male_Head_Eur_v1_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Male_Head_Eur_v1_SPECULAR.dds";
   useCustomColor = true;
   isFace = true;
   materialTag0 = "LiF";
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
   CustomizationData[7]  = Custom_Male_Head_Paint_v1;
   CustomizationData[8]  = Custom_Male_Head_Paint_v2;
   CustomizationData[9]  = Custom_Male_Head_Scar_v1;
   CustomizationData[10]  = Custom_Male_Head_Scar_v2;
   CustomizationData[11]  = Custom_Male_Head_Scar_v3;
   CustomizationData[12]  = Custom_Male_Head_Scar_v4;
   CustomizationData[13]  = Custom_Male_Head_Scar_v5;
   CustomizationData[14]  = Custom_Male_Head_Dirt_v1;
};

singleton Material(Male_Head_Eur_v2_DIFFUSE_mat)
{
   mapTo = "Male_Head_Eur_v2_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Male_Head_Eur_v2_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Male_Head_Eur_v2_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Male_Head_Eur_v2_SPECULAR.dds";
   useCustomColor = true;
   useAnisotropic[0] = "1";
   isFace = true;
   materialTag0 = "LiF";
   skinned = true;

   // Customization
   CustomizationData[0]  = Custom_Male_Head_Tatoo_1;
   CustomizationData[1]  = Custom_Male_Head_Tatoo_2;
   CustomizationData[2]  = Custom_Male_Head_Tatoo_3;
   CustomizationData[3]  = Custom_Male_Head_Tatoo_4;
   CustomizationData[4]  = Custom_Male_Head_Tatoo_5;
   CustomizationData[5]  = Custom_Male_Head_Tatoo_6;
   CustomizationData[6]  = Custom_Male_Head_Tatoo_7;
   CustomizationData[7]  = Custom_Male_Head_Paint_v1;
   CustomizationData[8]  = Custom_Male_Head_Paint_v2;
   CustomizationData[9]  = Custom_Male_Head_Scar_v1;
   CustomizationData[10]  = Custom_Male_Head_Scar_v2;
   CustomizationData[11]  = Custom_Male_Head_Scar_v3;
   CustomizationData[12]  = Custom_Male_Head_Scar_v4;
   CustomizationData[13]  = Custom_Male_Head_Scar_v5;
   CustomizationData[14]  = Custom_Male_Head_Dirt_v1;
};

singleton Material(Male_Head_Eur_v3_DIFFUSE_mat)
{
   mapTo = "Male_Head_Eur_v3_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Male_Head_Eur_v3_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Male_Head_Eur_v3_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Male_Head_Eur_v3_SPECULAR.dds";
   useCustomColor = true;
   isFace = true;
   useAnisotropic[0] = "1";
   materialTag0 = "LiF";
   skinned = true;

   // Customization
   CustomizationData[0]  = Custom_Male_Head_Tatoo_1;
   CustomizationData[1]  = Custom_Male_Head_Tatoo_2;
   CustomizationData[2]  = Custom_Male_Head_Tatoo_3;
   CustomizationData[3]  = Custom_Male_Head_Tatoo_4;
   CustomizationData[4]  = Custom_Male_Head_Tatoo_5;
   CustomizationData[5]  = Custom_Male_Head_Tatoo_6;
   CustomizationData[6]  = Custom_Male_Head_Tatoo_7;
   CustomizationData[7]  = Custom_Male_Head_Paint_v1;
   CustomizationData[8]  = Custom_Male_Head_Paint_v2;
   CustomizationData[9]  = Custom_Male_Head_Scar_v1;
   CustomizationData[10]  = Custom_Male_Head_Scar_v2;
   CustomizationData[11]  = Custom_Male_Head_Scar_v3;
   CustomizationData[12]  = Custom_Male_Head_Scar_v4;
   CustomizationData[13]  = Custom_Male_Head_Scar_v5;
   CustomizationData[14]  = Custom_Male_Head_Dirt_v1;
};

singleton Material(Male_Body_v1_DIFFUSE_mat)//Муж. тело v1
{
   mapTo = "Male_Body_v1_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Male_Body_v1_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Male_Body_v1_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Male_Body_v1_SPECULAR.dds";
   materialTag0 = "LiF";
   doubleSided = "1";
   useCustomColor = true;
   isBody = true;
   useAnisotropic[0] = "1";
   mipLODBias = -1.2;
   useAnisotropic[0] = "1";
   skinned = true;

    // Customization
   customizationData[0]  = Custom_Male_Body_Tatoo_1;
   customizationData[1]  = Custom_Male_Body_Tatoo_2;
   customizationData[2]  = Custom_Male_Body_Tatoo_3;
   customizationData[3]  = Custom_Male_Body_Tatoo_4;
   customizationData[4]  = Custom_Male_Body_Tatoo_5;
   customizationData[5]  = Custom_Male_Body_Tatoo_6;
   customizationData[6]  = Custom_Male_Body_Tatoo_7;
   customizationData[7]  = Custom_Male_Body_Tatoo_8;
   customizationData[8]  = Custom_Male_Body_Paint_v1;
   customizationData[9]  = Custom_Male_Body_Paint_v2;
   customizationData[10]  = Custom_Male_Body_Scar_v1;
   customizationData[11]  = Custom_Male_Body_Scar_v2;
   customizationData[12]  = Custom_Male_Body_Scar_v3;
   customizationData[13]  = Custom_Male_Body_Scar_v4;
   customizationData[14]  = Custom_Male_Body_Scar_v5;
};

singleton Material(Male_Underwear_Eur_DIFFUSE_mat)//Муж. нижнее бельё
{
   mapTo = "Male_Underwear_Eur_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Male_Underwear_Eur_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Male_Underwear_Eur_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Male_Underwear_Eur_SPECULAR.dds";
   normal3DC="1";
   materialTag0 = "LiF";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "150";
   mipLODBias = -1.2;
   useAnisotropic[0] = "1";
   skinned = true;
};

singleton Material(Male_Antiseam_DIFFUSE_mat)//Рубаха
{
   mapTo = "Male_Antiseam_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Male_Antiseam_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Male_Antiseam_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Male_Antiseam_SPECULAR.dds";
   materialTag0 = "LiF";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "100";
   mipLODBias = -1.2;
   useAnisotropic[0] = "1";
   skinned = true;
};
