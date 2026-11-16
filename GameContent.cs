using System.Net.Mime;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

public static class GameContent
{
    public static Texture2D rectangle_cutout_stage;
    public static Texture2D Papa_Test;

    public static void LoadContent(ContentManager content)
    {
        rectangle_cutout_stage = content.Load<Texture2D>("rectangle_cutout");
        Papa_Test = content.Load<Texture2D>("Papa_Test");

    }
}