namespace SunamoWpf.Converters;

public static partial class StringHexColorConverter //: ISimpleConverter<string, Color>
{
    public static string ConvertTo(System.Drawing.Color color)
    {
        return string.Format("#{0:X2}{1:X2}{2:X2}{3:X2}", color.A, color.R, color.G, color.B);
    }

    /// <summary>
    /// Can be entered with or without # - is used TrimStart()
    /// </summary>
    /// <param name = "hex"></param>
    public static System.Drawing.Color? ConvertFrom(string hex)
    {
        //TODO: Write unit test for it - Tato metoda je nějaká divná asi, kdyby nefungovala, použij místo ní třídu BrushConverter a metodu ConvertFrom

        //Color vr = new Color();
        hex = hex.TrimStart('#');
        if (hex.Length == 8)
        {
            return System.Drawing.Color.FromArgb(GetGroup(0, hex), GetGroup(1, hex), GetGroup(2, hex), GetGroup(3, hex));
        }
        else if (hex.Length == 6)
        {
            return System.Drawing.Color.FromArgb(GetGroup(0, hex), GetGroup(1, hex), GetGroup(2, hex));
        }
        // earlier time Color.Black
        return null;
    }

    private static byte GetGroup(int groupIndex, string hex)
    {
        string groupText = "";
        if (groupIndex == 0)
        {
            groupText = hex[0].ToString() + hex[1].ToString();
        }
        else if (groupIndex == 1)
        {
            groupText = hex[2].ToString() + hex[3].ToString();
        }
        else if (groupIndex == 2)
        {
            groupText = hex[4].ToString() + hex[5].ToString();
        }
        else
        {
            groupText = hex[6].ToString() + hex[7].ToString();
        }

        return Convert.ToByte(groupText, 16);
    }
}