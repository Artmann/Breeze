namespace Breeze;

public class Config {
  public Dictionary<string, string> spacing = [];
  public Dictionary<string, string> width = [];

  public Config Merge(Config other) {
    return new Config {
      spacing = MergeDictionaries(this.spacing, other.spacing),
      width = MergeDictionaries(this.width, other.width),
    };
  }

  private static Dictionary<T, K> MergeDictionaries<T, K>(Dictionary<T, K> a, Dictionary<T, K> b) where T : notnull {
    var newDictionary = new Dictionary<T, K>();

    foreach (var key in a.Keys) {
      newDictionary[key] = a[key];
    }

    foreach (var key in b.Keys) {
      newDictionary[key] = b[key];
    }

    return newDictionary;
  }

  public static Config Default() {
    return new Config {
      spacing = new Dictionary<string, string> {
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
      },
      width = new Dictionary<string, string> {
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
      }
    };
  }

}
