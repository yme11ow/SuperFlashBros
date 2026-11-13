using System.Runtime.CompilerServices;
using System.Security.Principal;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using SuperFlashBros;

public class StageManager
{
    private Texture2D _stageTexture;

    public void Init(Texture2D tex)
    {
        _stageTexture = tex;
    }

    public void Draw()
    {
        if (_stageTexture == null) {
            return;
        }

        int screenW = Globals.GraphicsDevice.Viewport.Width;
        int screenH = Globals.GraphicsDevice.Viewport.Height;
        int spriteW = _stageTexture.Width;
        int spriteH = _stageTexture.Height;

        Globals.SpriteBatch.Draw(_stageTexture, new Vector2((screenW / 2) - (spriteW / 2), (screenH / 2) + (screenH / 3) - spriteH), Color.White);
    }
}