
namespace FeatureToggleLibrary;

public class InMemoryFeatureToggleService : IFeatureToggleService
{
    private readonly Dictionary<string, bool> _featureToggles;
    public InMemoryFeatureToggleService()
    {
        _featureToggles = new Dictionary<string, bool>
        {
            {"NewFeature", true },
            {"BetaFeature", false }
        };
    }
    public bool IsFeatureEnable(string featureName)
    {
        return _featureToggles.ContainsKey(featureName) && _featureToggles[featureName];
    }
}
