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
        
        // Code to Get GUID of a Controller
        /*public override void Initialize() {
           string gUIDEXT = Microsoft.Xna.Framework.Input.GamePad.GetGUIDEXT(MInput.GamePads[Input.Gamepad].PlayerIndex);
           Console.WriteLine(gUIDEXT);

        }*/

        //Code who Actually Makes it work
        private string WiiButtons(On.Celeste.Input.orig_GuiInputPrefix orig, Input.PrefixMode mode)
{
            string gUIDEXT = Microsoft.Xna.Framework.Input.GamePad.GetGUIDEXT(MInput.GamePads[Input.Gamepad].PlayerIndex);
            string ret = orig(mode);
            if (gUIDEXT.Equals("7e050603"))
                {
                    return "wii";
                }
            return ret = orig(mode);
}
    }
}
