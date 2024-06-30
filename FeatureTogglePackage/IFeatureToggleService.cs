namespace FeatureToggleLibrary;

public interface IFeatureToggleService
{
    bool IsFeatureEnable(string featureName);
    void AddFeature(string featureName, bool isActive);
    Dictionary<string, bool> RetreiveFeature();
}
