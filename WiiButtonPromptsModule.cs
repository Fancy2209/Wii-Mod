using System;
using Celeste;
using Microsoft.Xna.Framework;
using Monocle;

namespace Celeste.Mod.WiiButtonPrompts {
    public class WiiButtonPromptsModule : EverestModule {
        
        public static WiiButtonPromptsModule Instance;
        

        public WiiButtonPromptsModule() {   
            Instance = this;
            
        }
        public override void Load() {
            On.Celeste.Input.GuiInputPrefix += WiiButtons;
            
        }
        public override void Unload() {
            On.Celeste.Input.GuiInputPrefix -=  WiiButtons;
        }
        
        public override void Initialize() {
           string gUIDEXT = Microsoft.Xna.Framework.Input.GamePad.GetGUIDEXT(MInput.GamePads[Input.Gamepad].PlayerIndex);
           Console.WriteLine(gUIDEXT);

        }

        private string WiiButtons(On.Celeste.Input.orig_GuiInputPrefix orig, Input.PrefixMode mode);
            if (gUIDEXT.Equals("7e050603"))
                {
                    return "wii";
                }
                On.Celeste.Input.orig_GuiInputPrefix orig, On.Celeste.Input.PrefixMode mode; 
    }
}
