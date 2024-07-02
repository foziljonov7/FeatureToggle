namespace FeatureToggleLibrary;

public interface IFeatureToggleService
{
    bool IsFeatureEnable(string featureName);
    void AddFeature(string featureName, bool isActive);
    Dictionary<string, bool> RetreiveFeature();
    void ScheduleFeatureActivation(string featureName, DateTime activationDate, DateTime? deactivationDate);
    void SetFeatureForUser(string featureName, string userId, bool isActive);
    bool IsFeatureEnabledForUser(string featureName, string userId);
    void AddFeatureDependency(string featureName, string dependencyFeatureName);
    List<string> RetreiveFeatureDependencies(string featureName);
}
