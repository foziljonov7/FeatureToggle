namespace FeatureToggleLibrary;

public interface IFeatureToggleService
{
    bool IsFeatureEnable(string featureName);
}
