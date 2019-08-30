﻿using Vintagestory.API.Common;

namespace TheNeolithicMod
{
    class CraftingProp
    {
        public JsonItemStack input { get; set; }
        public JsonItemStack[] output { get; set; }
        public EnumTool? tool { get; set; } = EnumTool.Axe;
        public string craftSound { get; set; }
        public int craftTime { get; set; } = 500;
    }

    class DryingProp
    {
        public JsonItemStack Input { get; set; }
        public JsonItemStack[] Output { get; set; }
        public int? DryingTime { get; set; } = 12;
        public bool RequiresDaylight { get; set; } = true;
        public JsonItemStack TextureSource { get; set; }
    }
}