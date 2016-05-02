namespace Fab5.Starburst.States {

using Fab5.Engine;
using Fab5.Engine.Components;
using Fab5.Engine.Core;
using Fab5.Engine.Subsystems;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

using System;
using System.Threading;

public class Pause_State : Game_State {
    private bool can_unpause = false;

    public override void init() {
        var sprite_batch = new SpriteBatch(Starburst.inst().GraphicsDevice);

        var w = Starburst.inst().GraphicsMgr.PreferredBackBufferWidth;
        var h = Starburst.inst().GraphicsMgr.PreferredBackBufferHeight;

        sprite_batch.Begin(SpriteSortMode.Deferred, BlendState.AlphaBlend);

        GFX_Util.fill_rect(sprite_batch, new Rectangle(0, 0, w, h), Color.Black * 0.5f);

        var text_size = GFX_Util.measure_string("Paused");
        var tx = (w-text_size.X)*0.5f;
        var ty = (h-text_size.Y)*0.5f;

        GFX_Util.draw_def_text(sprite_batch, "Paused", tx, ty);

        sprite_batch.End();
    }

    public override void draw(float t, float dt) {
        if (can_unpause) {
            for (int i = 0; i <= 3; i++) {
                if (GamePad.GetState((PlayerIndex)i).IsConnected && GamePad.GetState((PlayerIndex)i).Buttons.Start == ButtonState.Pressed) {
                    Starburst.inst().leave_state();
                    return;
                }
            }

            if (Keyboard.GetState().IsKeyDown(Keys.P)) {
                Starburst.inst().leave_state();
                return;
            }
        }
        else {
            bool no_buttons_pressed = true;

            for (int i = 0; i <= 3; i++) {
                if (GamePad.GetState((PlayerIndex)i).IsConnected && GamePad.GetState((PlayerIndex)i).Buttons.Start == ButtonState.Pressed) {
                    no_buttons_pressed = false;
                    break;
                }
            }

            if (Keyboard.GetState().IsKeyDown(Keys.P)) {
                no_buttons_pressed = false;
            }

            if (no_buttons_pressed) {
                can_unpause = true;
            }
        }

        Thread.Sleep(10);
    }
}

}