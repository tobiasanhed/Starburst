namespace Fab5.Starburst {

    using Fab5.Engine;
    using Fab5.Engine.Components;
    using Fab5.Engine.Core;
    using Fab5.Engine.Subsystems;

    using Fab5.Starburst.States;

    using Microsoft.Xna.Framework.Graphics;

    // Starburst game implementation.
    public class Starburst : Fab5_Game {
        public const string VERSION = "1.0";

        public Starburst() {
            GraphicsMgr.HardwareModeSwitch = false;
        }
        protected override void init() {
            if (false || GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Height < 800 || GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Width < 1400) {
                GraphicsMgr.PreferredBackBufferWidth = 1280;
                GraphicsMgr.PreferredBackBufferHeight = 720;
            }
            else {
                GraphicsMgr.PreferredBackBufferWidth = 1920;
                GraphicsMgr.PreferredBackBufferHeight = 1080;
            }

            GraphicsMgr.GraphicsProfile = GraphicsProfile.HiDef;
            //GraphicsMgr.PreferMultiSampling = true;
            //GraphicsMgr.GraphicsDevice.RasterizerState = new RasterizerState { MultiSampleAntiAlias = true };

            //Fab5_Game.inst().GraphicsDevice.SamplerStates[0].MipFilter = TextureFilter.Anisotropic;

            //Fab5_Game.inst().GraphicsDevice.SamplerStates[0] = SamplerState.AnisotropicWrap;



            //GraphicsMgr.SynchronizeWithVerticalRetrace = false;
            //IsFixedTimeStep = false;



            GraphicsMgr.ApplyChanges();
            //
            GraphicsMgr.ToggleFullScreen();
            Microsoft.Xna.Framework.Media.MediaPlayer.Volume = 0.7f;

            var form = (System.Windows.Forms.Form)System.Windows.Forms.Control.FromHandle(this.Window.Handle);
            form.Location = new System.Drawing.Point(300, 200);

            enter_state(new Splash_Screen_State());
        }

        protected override void cleanup() {
        }

        protected override void update(float t, float dt) {
        }

        protected override void draw(float t, float dt) {
        }

        static void Main() {
            using (var game = new Starburst()) {
                game.run();
            }
        }
    }

}
