using System.Text.RegularExpressions;

namespace PotteryHut.Api.Helpers;

// Skapar en URL-slug från ett namn, tex "Mud Skål" blir "mud-skal"
public static class SlugGenerator
{
    public static string Generate(string text)
    {
        var slug = text.Trim().ToLowerInvariant()
            .Replace("å", "a")
            .Replace("ä", "a")
            .Replace("ö", "o");

        slug = Regex.Replace(slug, "^[^a-z0-9]+", "-");

        return slug.Trim('-');
    }
}
