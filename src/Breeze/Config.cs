namespace Breeze;

public class Config
{
    public Dictionary<string, string> aspectRatio = [];
    public Dictionary<string, string> backgroundPosition = [];
    public Dictionary<string, string> backgroundSize = [];
    public Dictionary<string, string> blur = [];
    public Dictionary<string, string> borderRadius = [];
    public Dictionary<string, string> borderWidth = [];
    public Dictionary<string, string> brightness = [];
    public Dictionary<string, string> fontSize = [];
    public Dictionary<string, string> fontWeight = [];
    public Dictionary<string, string> lineHeight = [];
    public Dictionary<string, string> margin = [];
    public Dictionary<string, string> maxWidth = [];
    public Dictionary<string, string> opacity = [];
    public Dictionary<string, string> order = [];
    public Dictionary<string, string> outlineOffset = [];
    public Dictionary<string, string> outlineWidth = [];
    public Dictionary<string, string> padding = [];
    public Dictionary<string, string> size = [];
    public Dictionary<string, string> spacing = [];
    public Dictionary<string, string> width = [];
    public Dictionary<string, string> zIndex = [];

    public Config Merge(Config other)
    {
        return new Config
        {
            spacing = MergeDictionaries(spacing, other.spacing),
            width = MergeDictionaries(width, other.width),
        };
    }

    private static Dictionary<T, K> MergeDictionaries<T, K>(Dictionary<T, K> a, Dictionary<T, K> b) where T : notnull
    {
        var newDictionary = new Dictionary<T, K>();

        foreach (var key in a.Keys)
        {
            newDictionary[key] = a[key];
        }

        foreach (var key in b.Keys)
        {
            newDictionary[key] = b[key];
        }

        return newDictionary;
    }

    public static Config Default()
    {
        var spacing = new Dictionary<string, string> {
        { "px", "1px" },
        { "0", "0px" },
        { "0.5", "2px" },
        { "1", "4px" },
        { "1.5", "6px" },
        { "2", "8px" },
        { "2.5", "10px" },
        { "3", "12px" },
        { "3.5", "14px" },
        { "4", "16px" },
        { "5", "20px" },
        { "6", "24px" },
        { "7", "28px" },
        { "8", "32px" },
        { "9", "36px" },
        { "10", "40px" },
        { "11", "44px" },
        { "12", "48px" },
        { "14", "56px" },
        { "16", "64px" },
        { "20", "80px" },
        { "24", "96px" },
        { "28", "112px" },
        { "32", "128px" },
        { "36", "144px" },
        { "40", "160px" },
        { "44", "176px" },
        { "48", "192px" },
        { "52", "208px" },
        { "56", "224px" },
        { "60", "240px" },
        { "64", "256px" },
        { "72", "288px" },
        { "80", "320px" },
        { "96", "384px" }
      };

        var aspectRatio = new Dictionary<string, string>
        {
            { "auto", "auto" },
            { "square", "1 / 1" },
            { "video", "16 / 9" }
        };

        var backgroundPosition = new Dictionary<string, string>
        {
            { "bottom", "bottom" },
            { "center", "center" },
            { "left", "left" },
            { "left-bottom", "left bottom" },
            { "left-top", "left top" },
            { "right", "right" },
            { "right-bottom", "right bottom" },
            { "right-top", "right top" },
            { "top", "top" }
        };

        var backgroundColor = new Dictionary<string, string>
        {
            { "auto", "auto" },
            { "cover", "cover" },
            { "contain", "contain" }
        };

        var blur = new Dictionary<string, string>
        {
            { "0", "0" },
            { "none", "" },
            { "sm", "4px" },
            { "DEFAULT", "8px" },
            { "md", "12px" },
            { "lg", "16px" },
            { "xl", "24px" },
            { "2xl", "40px" },
            { "3xl", "64px" }
        };

        var borderRadius = new Dictionary<string, string>
        {
            { "none", "0px" },
            { "sm", "2px" },
            { "DEFAULT", "4px" },
            { "md", "6px" },
            { "lg", "8px" },
            { "xl", "12px" },
            { "2xl", "16px" },
            { "3xl", "24px" },
            { "full", "9999px" }
        };

        var borderWidth = new Dictionary<string, string>
        {
            { "DEFAULT", "1px" },
            { "0", "0px" },
            { "2", "2px" },
            { "4", "4px" },
            { "8", "8px" }
        };

        var brightness = new Dictionary<string, string>
        {
            { "0", "0" },
            { "50", ".5" },
            { "75", ".75" },
            { "90", ".9" },
            { "95", ".95" },
            { "100", "1" },
            { "105", "1.05" },
            { "110", "1.1" },
            { "125", "1.25" },
            { "150", "1.5" },
            { "200", "2" }
        };

        var fontSize = new Dictionary<string, string>
        {
            { "xs", "12px" },     // 0.75rem
            { "sm", "14px" },     // 0.875rem
            { "base", "16px" },   // 1rem
            { "lg", "18px" },     // 1.125rem
            { "xl", "20px" },     // 1.25rem
            { "2xl", "24px" },    // 1.5rem
            { "3xl", "30px" },    // 1.875rem
            { "4xl", "36px" },    // 2.25rem
            { "5xl", "48px" },    // 3rem
            { "6xl", "60px" },    // 3.75rem
            { "7xl", "72px" },    // 4.5rem
            { "8xl", "96px" },    // 6rem
            { "9xl", "128px" }    // 8rem
        };

        var fontWeight = new Dictionary<string, string>
        {
            { "thin", "100" },
            { "extralight", "200" },
            { "light", "300" },
            { "normal", "400" },
            { "medium", "500" },
            { "semibold", "600" },
            { "bold", "700" },
            { "extrabold", "800" },
            { "black", "900" }
        };

        var lineHeight = new Dictionary<string, string>
        {
            { "none", "1" },
            { "tight", "1.25" },
            { "snug", "1.375" },
            { "normal", "1.5" },
            { "relaxed", "1.625" },
            { "loose", "2" },
            { "3", "12px" },      // 0.75rem
            { "4", "16px" },      // 1rem
            { "5", "20px" },      // 1.25rem
            { "6", "24px" },      // 1.5rem
            { "7", "28px" },      // 1.75rem
            { "8", "32px" },      // 2rem
            { "9", "36px" },      // 2.25rem
            { "10", "40px" }      // 2.5rem
        };

        var margin = MergeDictionaries(spacing, new Dictionary<string, string> {
            { "auto", "auto" }
        });

        var maxWidth = new Dictionary<string, string>
        {
            { "none", "none" },
            { "xs", "320px" },    // 20rem
            { "sm", "384px" },    // 24rem
            { "md", "448px" },    // 28rem
            { "lg", "512px" },    // 32rem
            { "xl", "576px" },    // 36rem
            { "2xl", "672px" },   // 42rem
            { "3xl", "768px" },   // 48rem
            { "4xl", "896px" },   // 56rem
            { "5xl", "1024px" },  // 64rem
            { "6xl", "1152px" },  // 72rem
            { "7xl", "1280px" },  // 80rem
            { "full", "100%" },
            { "min", "min-content" },
            { "max", "max-content" },
            { "fit", "fit-content" },
            { "prose", "65ch" }
        };

        var opacity = new Dictionary<string, string>
        {
            { "0", "0" },
            { "5", "0.05" },
            { "10", "0.1" },
            { "15", "0.15" },
            { "20", "0.2" },
            { "25", "0.25" },
            { "30", "0.3" },
            { "35", "0.35" },
            { "40", "0.4" },
            { "45", "0.45" },
            { "50", "0.5" },
            { "55", "0.55" },
            { "60", "0.6" },
            { "65", "0.65" },
            { "70", "0.7" },
            { "75", "0.75" },
            { "80", "0.8" },
            { "85", "0.85" },
            { "90", "0.9" },
            { "95", "0.95" },
            { "100", "1" }
        };

        var order = new Dictionary<string, string>
        {
            { "first", "-9999" },
            { "last", "9999" },
            { "none", "0" },
            { "1", "1" },
            { "2", "2" },
            { "3", "3" },
            { "4", "4" },
            { "5", "5" },
            { "6", "6" },
            { "7", "7" },
            { "8", "8" },
            { "9", "9" },
            { "10", "10" },
            { "11", "11" },
            { "12", "12" }
        };

        var outlineOffset = new Dictionary<string, string>
        {
            { "0", "0px" },
            { "1", "1px" },
            { "2", "2px" },
            { "4", "4px" },
            { "8", "8px" }
        };

        var outlineWidth = new Dictionary<string, string>
        {
            { "0", "0px" },
            { "1", "1px" },
            { "2", "2px" },
            { "4", "4px" },
            { "8", "8px" }
        };

        var padding = MergeDictionaries(spacing, new Dictionary<string, string> {
            { "px", "1px" }
        });

        var size = MergeDictionaries(spacing, new Dictionary<string, string>
        {
            { "1/2", "50%" },
            { "1/3", "33.333333%" },
            { "2/3", "66.666667%" },
            { "1/4", "25%" },
            { "2/4", "50%" },
            { "3/4", "75%" },
            { "1/5", "20%" },
            { "2/5", "40%" },
            { "3/5", "60%" },
            { "4/5", "80%" },
            { "1/6", "16.666667%" },
            { "2/6", "33.333333%" },
            { "3/6", "50%" },
            { "4/6", "66.666667%" },
            { "5/6", "83.333333%" },
            { "1/12", "8.333333%" },
            { "2/12", "16.666667%" },
            { "3/12", "25%" },
            { "4/12", "33.333333%" },
            { "5/12", "41.666667%" },
            { "6/12", "50%" },
            { "7/12", "58.333333%" },
            { "8/12", "66.666667%" },
            { "9/12", "75%" },
            { "10/12", "83.333333%" },
            { "11/12", "91.666667%" },
            { "full", "100%" },
            { "min", "min-content" },
            { "max", "max-content" },
            { "fit", "fit-content" }
        });

        var width = MergeDictionaries(spacing, new Dictionary<string, string> {
        { "auto", "auto" },
        { "1/2", "50%" },
        { "1/3", "33.333333%" },
        { "2/3", "66.666667%" },
        { "1/4", "25%" },
        { "2/4", "50%" },
        { "3/4", "75%" },
        { "1/5", "20%" },
        { "2/5", "40%" },
        { "3/5", "60%" },
        { "4/5", "80%" },
        { "1/6", "16.666667%" },
        { "2/6", "33.333333%" },
        { "3/6", "50%" },
        { "4/6", "66.666667%" },
        { "5/6", "83.333333%" },
        { "1/12", "8.333333%" },
        { "2/12", "16.666667%" },
        { "3/12", "25%" },
        { "4/12", "33.333333%" },
        { "5/12", "41.666667%" },
        { "6/12", "50%" },
        { "7/12", "58.333333%" },
        { "8/12", "66.666667%" },
        { "9/12", "75%" },
        { "10/12", "83.333333%" },
        { "11/12", "91.666667%" },
        { "full", "100%" },
      });

        var zIndex = new Dictionary<string, string>
        {
            { "auto", "auto" },
            { "0", "0" },
            { "10", "10" },
            { "20", "20" },
            { "30", "30" },
            { "40", "40" },
            { "50", "50" }
        };

        return new Config
        {
            aspectRatio = aspectRatio,
            backgroundPosition = backgroundPosition,
            backgroundSize = backgroundColor,
            blur = blur,
            borderRadius = borderRadius,
            borderWidth = borderWidth,
            brightness = brightness,
            fontSize = fontSize,
            fontWeight = fontWeight,
            lineHeight = lineHeight,
            margin = margin,
            maxWidth = maxWidth,
            opacity = opacity,
            order = order,
            outlineOffset = outlineOffset,
            outlineWidth = outlineWidth,
            padding = padding,
            size = size,
            spacing = spacing,
            width = width,
            zIndex = zIndex,
        };
    }

}
