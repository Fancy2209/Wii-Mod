using System;
using Microsoft.Xna.Framework; 

namespace Celeste.Mod.WiiButtonPrompts {
    public class WiiButtonPromptsModule : EverestModule {
        
        public static WiiButtonPromptsModule Instance;

        public WiiButtonPromptsModule() {
            Instance = this;
            
        }

        public override void Load() {
            //On.Celeste.Input.GuiInputPrefix += WiiButtons;
            string guid = GamePad.GetGUIDEXT(index);        
            Console.WriteLine(guid);
        }
        public override void Unload() {
            //On.Celeste.Input.GuiInputPrefix -=  WiiButtons;
        }

        //private string WiiButtons(On.Celeste.Input.orig_GuiInputPrefix orig, Input.PrefixMode mode);
          
    }
}
