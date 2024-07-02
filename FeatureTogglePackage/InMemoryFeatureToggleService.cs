
namespace FeatureToggleLibrary;

public class InMemoryFeatureToggleService : IFeatureToggleService
{
    private readonly Dictionary<string, bool> _featureToggles;
    private readonly Dictionary<string, Tuple<DateTime, DateTime?>> _featureSchudeles;
    private readonly Dictionary<string, Dictionary<string, bool>> _userFeatures;
    private readonly Dictionary<string, List<string>> _featureDependencies;
    public InMemoryFeatureToggleService()
    {
        _featureToggles = new Dictionary<string, bool>();
        _featureSchudeles = new Dictionary<string, Tuple<DateTime, DateTime?>>();
        _userFeatures = new Dictionary<string, Dictionary<string, bool>>();
        _featureDependencies = new Dictionary<string, List<string>>();
    }

    public void AddFeature(string featureName, bool isActive)
    {
        if(!_featureToggles.ContainsKey(featureName)) 
            _featureToggles.Add(featureName, isActive);
        else
            _featureToggles[featureName] = isActive;
    }

    public void AddFeatureDependency(string featureName, string dependencyFeatureName)
    {
        if (!_featureDependencies.ContainsKey(featureName))
            _featureDependencies[featureName] = new List<string>();

        _featureDependencies[featureName].Add(dependencyFeatureName);
    }

    public bool IsFeatureEnable(string featureName)
    {
        if(_featureSchudeles.ContainsKey(featureName))
        {
            var schedule = _featureSchudeles[featureName];
            if (DateTime.Now < schedule.Item1 || (schedule.Item2.HasValue && DateTime.Now > schedule.Item2.Value))
                return false;
        }

        if(_featureToggles.ContainsKey(featureName) && _featureToggles[featureName])
        {
            foreach (var dependency in _featureDependencies[featureName])
                if (!IsFeatureEnable(dependency))
                    return false;
        }

        return true;
    }

    public bool IsFeatureEnabledForUser(string featureName, string userId)
    {
        if (_userFeatures.ContainsKey(userId) && _userFeatures[userId].ContainsKey(featureName))
            return _userFeatures[userId][featureName];

        return IsFeatureEnable(featureName);
    }

    public Dictionary<string, bool> RetreiveFeature()
        => _featureToggles;

    public List<string> RetreiveFeatureDependencies(string featureName)
    {
        if(_featureDependencies.ContainsKey(featureName))
            return new List<string>(_featureDependencies[featureName]);

        return new List<string>();
    }

    public void ScheduleFeatureActivation(string featureName, DateTime activationDate, DateTime? deactivationDate)
    {
        _featureSchudeles[featureName] = new Tuple<DateTime, DateTime?>(activationDate, deactivationDate);
    }

    public void SetFeatureForUser(string featureName, string userId, bool isActive)
    {
        if (!_userFeatures.ContainsKey(featureName))
            _userFeatures[userId] = new Dictionary<string, bool>();

        _userFeatures[userId][featureName] = isActive;
    }
}
