using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;


public class Actor
{
    private Texture2D _actorTexture;
    bool isPlayer;
    private String _type;

    public void Spawn(Texture2D sprite, bool player, String type)
    {
        _actorTexture = sprite;
        isPlayer = player;
        _type = type;
    }

    public void Draw()
    {
        if (_actorTexture == null)
        {
            return;
        }

        int screenW = Globals.GraphicsDevice.Viewport.Width;
        int screenH = Globals.GraphicsDevice.Viewport.Height;
        int spriteW = _actorTexture.Width;
        int spriteH = _actorTexture.Height;

        Globals.SpriteBatch.Draw(_actorTexture, new Vector2((screenW / 2) - (spriteW / 2), (screenH / 2) + (screenH / 3) - spriteH), Color.White);
    }

}