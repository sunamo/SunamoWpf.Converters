namespace SunamoWpf.Converters;

/// <summary>
/// Represents the visibility boolean converter type.
/// </summary>
public class VisibilityBooleanConverter
{
    /// <summary>
    /// To bool.
    /// </summary>
    /// <param name="visibility">The visibility.</param>
    /// <returns>The to bool result.</returns>
    public static bool ToBool(Visibility visibility)
    {
        if (visibility == Visibility.Visible)
        {
            return true;
        }
        return false;
    }

    /// <summary>
    /// From bool.
    /// </summary>
    /// <param name="value">The value.</param>
    /// <returns>The from bool result.</returns>
    public static Visibility FromBool(bool value)
    {
        if (value)
        {
            return Visibility.Visible;
        }
        return Visibility.Collapsed;
    }
}