namespace FeatureToggleLibrary;

public class InMemoryFeatureToggleService : IFeatureToggleService
{
    private readonly Dictionary<string, bool> _featureToggles;
    public InMemoryFeatureToggleService()
    {
        _featureToggles = new Dictionary<string, bool>();
    }

    public void AddFeature(string featureName, bool isActive)
    {
        if(!_featureToggles.ContainsKey(featureName)) 
            _featureToggles.Add(featureName, isActive);
        else
            _featureToggles[featureName] = isActive;
    }

    public bool IsFeatureEnable(string featureName)
    {
        return _featureToggles.ContainsKey(featureName) && _featureToggles[featureName];
    }

    public Dictionary<string, bool> RetreiveFeature()
        => _featureToggles;
}
