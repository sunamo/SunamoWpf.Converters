namespace SunamoWpf.ValueConverters;

/// <summary>
/// Represents the corner radius value converter type.
/// </summary>
public class CornerRadiusValueConverter : IValueConverter
{
    /// <summary>
    /// Convert.
    /// </summary>
    /// <param name="value">The value.</param>
    /// <param name="targetType">The target type.</param>
    /// <param name="parameter">The parameter.</param>
    /// <param name="culture">The culture.</param>
    /// <returns>The convert result.</returns>
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        var radius = double.Parse(value.ToString(), culture);
        if (parameter != null)
        {
            radius *= double.Parse(parameter.ToString(), culture);
        }
        return new CornerRadius(radius);
    }

    /// <summary>
    /// Convert back.
    /// </summary>
    /// <param name="value">The value.</param>
    /// <param name="targetType">The target type.</param>
    /// <param name="parameter">The parameter.</param>
    /// <param name="culture">The culture.</param>
    /// <returns>The convert back result.</returns>
    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        return false;
    }
}