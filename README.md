# FeatureToggle

### The **FeatureToggleLibrary** is a flexible and easy-to-use library designed to manage feature toggles in .NET applications. This library enables developers to dynamically enable or disable features without modifying the application code. It's ideal for managing feature rollouts, conducting A/B testing, and controlling feature access based on different conditions.


- isFeatureEnable(string featureName) - Checks whether a specific feature is enabled or not based on its featureName. Returns true if the feature is enabled, otherwise false

- AddFeature(string featureName, bool isActive) - Adds or updates a feature with the given featureName and sets its initial isActive status (true for enabled, false for disabled)

- RetreiveFeature() - Retrieves all features as a dictionary where the key is the feature name and the value is a boolean indicating whether the feature is enabled (true) or disabled (false).

- ScheduleFeatureActivation(string featureName, DateTime activationDate, DateTime? deactivationDate) - Schedules the activation and optional deactivation of a feature. The feature will be enabled starting from activationDate and disabled after deactivationDate if it is provided. This allows you to set time-based feature toggles.

- SetFeatureForUser(string featureName, string userId, bool isActive) - Sets the activation status of a feature for a specific user. This allows you to enable or disable a feature for individual users, providing personalized feature control.

- IsFeatureEnabledForUser(string featureName, string userId) - Checks whether a specific feature is enabled for a given user based on the feature name and user ID. Returns true if the feature is enabled for the user, otherwise false.

- AddFeatureDependency(string featureName, string dependencyFeatureName) - Adds a dependency between two features. The featureName will depend on dependencyFeatureName, meaning featureName can only be enabled if dependencyFeatureName is also enabled. This allows you to manage feature dependencies and ensure proper activation sequences.

- List<string> RetreiveFeatureDependencies(string featureName) - Retrieves all dependencies for a given feature. Returns a list of feature names that the specified featureName depends on. This helps in understanding and managing feature dependencie


## Install the FeatureToggle package

```
dotnet add package FeatureToggle
```


Author - Abdulvosid Foziljonov

How to reach me - abdulvosidfoziljonov55@gmail.com



