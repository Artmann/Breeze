namespace Breeze;

public class Config
{
    public Dictionary<string, string> aspectRatio = [];
    public Dictionary<string, string> backgroundPosition = [];
    public Dictionary<string, string> backgroundSize = [];
    public Dictionary<string, string> borderRadius = [];
    public Dictionary<string, string> borderWidth = [];
    public Dictionary<string, string> colors = [];
    public Dictionary<string, string> fontSize = [];
    public Dictionary<string, string> fontStyles = [];
    public Dictionary<string, string> margin = [];
    public Dictionary<string, string> maxWidth = [];
    public Dictionary<string, string> opacity = [];
    public Dictionary<string, string> outlineOffset = [];
    public Dictionary<string, string> outlineWidth = [];
    public Dictionary<string, string> padding = [];
    public Dictionary<string, string> size = [];
    public Dictionary<string, string> spacing = [];
    public Dictionary<string, string> width = [];

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
        var colors = new Dictionary<string, string> {
            { "transparent", "transparent" },
            { "black", "#000" },
            { "white", "#fff" },
            { "slate-50", "#f8fafc" },
            { "slate-100", "#f1f5f9" },
            { "slate-200", "#e2e8f0" },
            { "slate-300", "#cbd5e1" },
            { "slate-400", "#94a3b8" },
            { "slate-500", "#64748b" },
            { "slate-600", "#475569" },
            { "slate-700", "#334155" },
            { "slate-800", "#1e293b" },
            { "slate-900", "#0f172a" },
            { "slate-950", "#020617" },
            { "gray-50", "#f9fafb" },
            { "gray-100", "#f3f4f6" },
            { "gray-200", "#e5e7eb" },
            { "gray-300", "#d1d5db" },
            { "gray-400", "#9ca3af" },
            { "gray-500", "#6b7280" },
            { "gray-600", "#4b5563" },
            { "gray-700", "#374151" },
            { "gray-800", "#1f2937" },
            { "gray-900", "#111827" },
            { "gray-950", "#030712" },
            { "zinc-50", "#fafafa" },
            { "zinc-100", "#f4f4f5" },
            { "zinc-200", "#e4e4e7" },
            { "zinc-300", "#d4d4d8" },
            { "zinc-400", "#a1a1aa" },
            { "zinc-500", "#71717a" },
            { "zinc-600", "#52525b" },
            { "zinc-700", "#3f3f46" },
            { "zinc-800", "#27272a" },
            { "zinc-900", "#18181b" },
            { "zinc-950", "#09090b" },
            { "neutral-50", "#fafafa" },
            { "neutral-100", "#f5f5f5" },
            { "neutral-200", "#e5e5e5" },
            { "neutral-300", "#d4d4d4" },
            { "neutral-400", "#a3a3a3" },
            { "neutral-500", "#737373" },
            { "neutral-600", "#525252" },
            { "neutral-700", "#404040" },
            { "neutral-800", "#262626" },
            { "neutral-900", "#171717" },
            { "neutral-950", "#0a0a0a" },
            { "stone-50", "#fafaf9" },
            { "stone-100", "#f5f5f4" },
            { "stone-200", "#e7e5e4" },
            { "stone-300", "#d6d3d1" },
            { "stone-400", "#a8a29e" },
            { "stone-500", "#78716c" },
            { "stone-600", "#57534e" },
            { "stone-700", "#44403c" },
            { "stone-800", "#292524" },
            { "stone-900", "#1c1917" },
            { "stone-950", "#0c0a09" },
            { "red-50", "#fef2f2" },
            { "red-100", "#fee2e2" },
            { "red-200", "#fecaca" },
            { "red-300", "#fca5a5" },
            { "red-400", "#f87171" },
            { "red-500", "#ef4444" },
            { "red-600", "#dc2626" },
            { "red-700", "#b91c1c" },
            { "red-800", "#991b1b" },
            { "red-900", "#7f1d1d" },
            { "red-950", "#450a0a" },
            { "orange-50", "#fff7ed" },
            { "orange-100", "#ffedd5" },
            { "orange-200", "#fed7aa" },
            { "orange-300", "#fdba74" },
            { "orange-400", "#fb923c" },
            { "orange-500", "#f97316" },
            { "orange-600", "#ea580c" },
            { "orange-700", "#c2410c" },
            { "orange-800", "#9a3412" },
            { "orange-900", "#7c2d12" },
            { "orange-950", "#431407" },
            { "amber-50", "#fffbeb" },
            { "amber-100", "#fef3c7" },
            { "amber-200", "#fde68a" },
            { "amber-300", "#fcd34d" },
            { "amber-400", "#fbbf24" },
            { "amber-500", "#f59e0b" },
            { "amber-600", "#d97706" },
            { "amber-700", "#b45309" },
            { "amber-800", "#92400e" },
            { "amber-900", "#78350f" },
            { "amber-950", "#451a03" },
            { "yellow-50", "#fefce8" },
            { "yellow-100", "#fef9c3" },
            { "yellow-200", "#fef08a" },
            { "yellow-300", "#fde047" },
            { "yellow-400", "#facc15" },
            { "yellow-500", "#eab308" },
            { "yellow-600", "#ca8a04" },
            { "yellow-700", "#a16207" },
            { "yellow-800", "#854d0e" },
            { "yellow-900", "#713f12" },
            { "yellow-950", "#422006" },
            { "lime-50", "#f7fee7" },
            { "lime-100", "#ecfccb" },
            { "lime-200", "#d9f99d" },
            { "lime-300", "#bef264" },
            { "lime-400", "#a3e635" },
            { "lime-500", "#84cc16" },
            { "lime-600", "#65a30d" },
            { "lime-700", "#4d7c0f" },
            { "lime-800", "#3f6212" },
            { "lime-900", "#365314" },
            { "lime-950", "#1a2e05" },
            { "green-50", "#f0fdf4" },
            { "green-100", "#dcfce7" },
            { "green-200", "#bbf7d0" },
            { "green-300", "#86efac" },
            { "green-400", "#4ade80" },
            { "green-500", "#22c55e" },
            { "green-600", "#16a34a" },
            { "green-700", "#15803d" },
            { "green-800", "#166534" },
            { "green-900", "#14532d" },
            { "green-950", "#052e16" },
            { "emerald-50", "#ecfdf5" },
            { "emerald-100", "#d1fae5" },
            { "emerald-200", "#a7f3d0" },
            { "emerald-300", "#6ee7b7" },
            { "emerald-400", "#34d399" },
            { "emerald-500", "#10b981" },
            { "emerald-600", "#059669" },
            { "emerald-700", "#047857" },
            { "emerald-800", "#065f46" },
            { "emerald-900", "#064e3b" },
            { "emerald-950", "#022c22" },
            { "teal-50", "#f0fdfa" },
            { "teal-100", "#ccfbf1" },
            { "teal-200", "#99f6e4" },
            { "teal-300", "#5eead4" },
            { "teal-400", "#2dd4bf" },
            { "teal-500", "#14b8a6" },
            { "teal-600", "#0d9488" },
            { "teal-700", "#0f766e" },
            { "teal-800", "#115e59" },
            { "teal-900", "#134e4a" },
            { "teal-950", "#042f2e" },
            { "cyan-50", "#ecfeff" },
            { "cyan-100", "#cffafe" },
            { "cyan-200", "#a5f3fc" },
            { "cyan-300", "#67e8f9" },
            { "cyan-400", "#22d3ee" },
            { "cyan-500", "#06b6d4" },
            { "cyan-600", "#0891b2" },
            { "cyan-700", "#0e7490" },
            { "cyan-800", "#155e75" },
            { "cyan-900", "#164e63" },
            { "cyan-950", "#083344" },
            { "sky-50", "#f0f9ff" },
            { "sky-100", "#e0f2fe" },
            { "sky-200", "#bae6fd" },
            { "sky-300", "#7dd3fc" },
            { "sky-400", "#38bdf8" },
            { "sky-500", "#0ea5e9" },
            { "sky-600", "#0284c7" },
            { "sky-700", "#0369a1" },
            { "sky-800", "#075985" },
            { "sky-900", "#0c4a6e" },
            { "sky-950", "#082f49" },
            { "blue-50", "#eff6ff" },
            { "blue-100", "#dbeafe" },
            { "blue-200", "#bfdbfe" },
            { "blue-300", "#93c5fd" },
            { "blue-400", "#60a5fa" },
            { "blue-500", "#3b82f6" },
            { "blue-600", "#2563eb" },
            { "blue-700", "#1d4ed8" },
            { "blue-800", "#1e40af" },
            { "blue-900", "#1e3a8a" },
            { "blue-950", "#172554" },
            { "indigo-50", "#eef2ff" },
            { "indigo-100", "#e0e7ff" },
            { "indigo-200", "#c7d2fe" },
            { "indigo-300", "#a5b4fc" },
            { "indigo-400", "#818cf8" },
            { "indigo-500", "#6366f1" },
            { "indigo-600", "#4f46e5" },
            { "indigo-700", "#4338ca" },
            { "indigo-800", "#3730a3" },
            { "indigo-900", "#312e81" },
            { "indigo-950", "#1e1b4b" },
            { "violet-50", "#f5f3ff" },
            { "violet-100", "#ede9fe" },
            { "violet-200", "#ddd6fe" },
            { "violet-300", "#c4b5fd" },
            { "violet-400", "#a78bfa" },
            { "violet-500", "#8b5cf6" },
            { "violet-600", "#7c3aed" },
            { "violet-700", "#6d28d9" },
            { "violet-800", "#5b21b6" },
            { "violet-900", "#4c1d95" },
            { "violet-950", "#2e1065" },
            { "purple-50", "#faf5ff" },
            { "purple-100", "#f3e8ff" },
            { "purple-200", "#e9d5ff" },
            { "purple-300", "#d8b4fe" },
            { "purple-400", "#c084fc" },
            { "purple-500", "#a855f7" },
            { "purple-600", "#9333ea" },
            { "purple-700", "#7e22ce" },
            { "purple-800", "#6b21a8" },
            { "purple-900", "#581c87" },
            { "purple-950", "#3b0764" },
            { "fuchsia-50", "#fdf4ff" },
            { "fuchsia-100", "#fae8ff" },
            { "fuchsia-200", "#f5d0fe" },
            { "fuchsia-300", "#f0abfc" },
            { "fuchsia-400", "#e879f9" },
            { "fuchsia-500", "#d946ef" },
            { "fuchsia-600", "#c026d3" },
            { "fuchsia-700", "#a21caf" },
            { "fuchsia-800", "#86198f" },
            { "fuchsia-900", "#701a75" },
            { "fuchsia-950", "#4a044e" },
            { "pink-50", "#fdf2f8" },
            { "pink-100", "#fce7f3" },
            { "pink-200", "#fbcfe8" },
            { "pink-300", "#f9a8d4" },
            { "pink-400", "#f472b6" },
            { "pink-500", "#ec4899" },
            { "pink-600", "#db2777" },
            { "pink-700", "#be185d" },
            { "pink-800", "#9d174d" },
            { "pink-900", "#831843" },
            { "pink-950", "#500724" },
            { "rose-50", "#fff1f2" },
            { "rose-100", "#ffe4e6" },
            { "rose-200", "#fecdd3" },
            { "rose-300", "#fda4af" },
            { "rose-400", "#fb7185" },
            { "rose-500", "#f43f5e" },
            { "rose-600", "#e11d48" },
            { "rose-700", "#be123c" },
            { "rose-800", "#9f1239" },
            { "rose-900", "#881337" },
            { "rose-950", "#4c0519" }
        };

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

        var fontStyles = new Dictionary<string, string>
        {
            { "normal", "normal" },
            { "italic ", "italic" },
            { "bold", "bold" },
            { "bold-italic", "bold-and-italic" }
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

        return new Config
        {
            aspectRatio = aspectRatio,
            backgroundPosition = backgroundPosition,
            backgroundSize = backgroundColor,
            borderRadius = borderRadius,
            borderWidth = borderWidth,
            colors = colors,
            fontSize = fontSize,
            fontStyles = fontStyles,
            margin = margin,
            maxWidth = maxWidth,
            opacity = opacity,
            outlineOffset = outlineOffset,
            outlineWidth = outlineWidth,
            padding = padding,
            size = size,
            spacing = spacing,
            width = width,
        };
    }

}
