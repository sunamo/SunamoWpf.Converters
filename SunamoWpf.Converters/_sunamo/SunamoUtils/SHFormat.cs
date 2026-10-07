#define ASYNC
namespace SunamoWpf.Converters._sunamo;

internal class SHFormat
{
    public static string Format4(string format, params Object[] args)
    {
        return string.Format(format, args);
    }
}
