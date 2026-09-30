
function PlayerMaleSMData::loadSequences(%this, %shapeName)
{
   %c = singleton TSShapeConstructor() { shapeName = %shapeName; };
   %c.dumpBegin();
   %c.loadSequences("./block_A.dsq");
   %c.loadSequences("./block_B.dsq");
   %c.loadSequences("./block_B2.dsq");
   %c.loadSequences("./block_C.dsq");
   %c.loadSequences("./block_D.dsq");
   %c.loadSequences("./block_E.dsq");
   %c.loadSequences("./block_F.dsq");
   %c.loadSequences("./block_G.dsq");
   %c.loadSequences("./block_H.dsq");
   %c.loadSequences("./block_I.dsq");
   %c.loadSequences("./block_J.dsq");
   %c.loadSequences("./block_K.dsq");
   %c.dumpEnd();
}

function PlayerMaleTCData::loadSequences(%this, %shapeName)
{
   %c = singleton TSShapeConstructor() { shapeName = %shapeName; };
   %c.dumpBegin();
   %c.loadSequences("./block_A.dsq");
   %c.loadSequences("./block_B.dsq");
   %c.loadSequences("./block_B2.dsq");
   %c.loadSequences("./block_C.dsq");
   %c.loadSequences("./block_D.dsq");
   %c.loadSequences("./block_E.dsq");
   %c.loadSequences("./block_F.dsq");
   %c.loadSequences("./block_G.dsq");
   %c.loadSequences("./block_H.dsq");
   %c.loadSequences("./block_I.dsq");
   %c.loadSequences("./block_J.dsq");
   %c.loadSequences("./block_K.dsq");
   %c.dumpEnd();
}

// SH female (sh_female.dts): same SH animation blocks as the male models.
// Only ONE datablock per shape may load them: PlayerFemaleSMData uses the same
// sh_female.dts, so loading them again would duplicate every sequence and
// overflow PlayerData actions (server page fault at preload).
function PlayerFemaleTCData::loadSequences(%this, %shapeName)
{
   %c = singleton TSShapeConstructor() { shapeName = %shapeName; };
   %c.dumpBegin();
   %c.loadSequences("./block_A.dsq");
   %c.loadSequences("./block_B.dsq");
   %c.loadSequences("./block_B2.dsq");
   %c.loadSequences("./block_C.dsq");
   %c.loadSequences("./block_D.dsq");
   %c.loadSequences("./block_E.dsq");
   %c.loadSequences("./block_F.dsq");
   %c.loadSequences("./block_G.dsq");
   %c.loadSequences("./block_H.dsq");
   %c.loadSequences("./block_I.dsq");
   %c.loadSequences("./block_J.dsq");
   %c.loadSequences("./block_K.dsq");
   %c.dumpEnd();
}
