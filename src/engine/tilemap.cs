namespace Fab5.Engine {

    using Microsoft.Xna.Framework.Graphics;

public class Tile_Map {
    public int[] tiles = new int[256*256];

    public Tile_Map() {
        var lol = new int[] {
            1, 1, 1, 1, 1, 1, 1, 1,
            1, 0, 0, 0, 0, 0, 0, 0,
            1, 0, 0, 0, 0, 0, 0, 0,
            1, 0, 0, 0, 0, 0, 0, 0,
            1, 0, 0, 0, 0, 0, 0, 0,
            1, 0, 0, 0, 0, 0, 0, 0,
            1, 0, 0, 0, 0, 0, 0, 0,
            1, 1, 1, 1, 1, 1, 1, 1
        };

        for (int i = 0; i < 8; i++) {
            for (int j = 0; j < 8; j++) {
                int o1 = i +j*8;
                int o2 = (i+142)+(j+142)*256;

                tiles[o2] = lol[o1];
            }
        }
    }

    public Texture2D tile_tex;
}

}
