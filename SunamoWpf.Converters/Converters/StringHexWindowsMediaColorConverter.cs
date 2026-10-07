namespace SunamoWpf.Converters;

public static class StringHexWindowsMediaColorConverter //: ISimpleConverter<string, Color>
{
    public static string ConvertTo(Color color)
    {
        return SHFormat.Format4("#{0:X2}{1:X2}{2:X2}{3:X2}", color.A, color.R, color.G, color.B);
    }
    public static Color ConvertFrom(string hex)
    {
        Color result = new Color();
        hex = hex.TrimStart('#');
        if (hex.Length == 8)
        {
            result.A = GetGroup(0, hex);
            result.R = GetGroup(1, hex);
            result.G = GetGroup(2, hex);
            result.B = GetGroup(3, hex);
        }
        else if (hex.Length == 6)
        {
            result.A = 255;
            result.R = GetGroup(0, hex);
            result.G = GetGroup(1, hex);
            result.B = GetGroup(2, hex);
        }
        else
        {
            return Colors.Black;
        }
        return result;
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