﻿using System;
using Verse;
using RimWorld;

namespace GeneticRimAddOn
{
    public class CompProperties_GenetrainerUseEffect : CompProperties_UseEffect
    {
       
        public HediffDef hediff;

        public CompProperties_GenetrainerUseEffect()
        {
            this.compClass = typeof(CompGenetrainerUseEffect);
        }

       

    }
}