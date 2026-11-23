namespace SunamoWpf.ValueConverters;

/// <summary>
/// Represents the scalar value converter type.
/// </summary>
public class ScalarValueConverter : IValueConverter
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
        var oldValue = double.Parse(value.ToString(), culture);
        if (parameter != null)
        {
            oldValue *= double.Parse(parameter.ToString(), culture);
        }
        return oldValue;
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
        var oldValue = double.Parse(value.ToString(), culture);
        if (parameter != null)
        {
            oldValue /= double.Parse(parameter.ToString(), culture);
        }
        return oldValue;
    }
}