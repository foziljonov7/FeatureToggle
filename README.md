# FeatureToggle

### The **FeatureToggleLibrary** is a flexible and easy-to-use library designed to manage feature toggles in .NET applications. This library enables developers to dynamically enable or disable features without modifying the application code. It's ideal for managing feature rollouts, conducting A/B testing, and controlling feature access based on different conditions.


- isFeatureEnable(string featureName) - Checks whether a specific feature is enabled or not based on its featureName. Returns true if the feature is enabled, otherwise false

- AddFeature(string featureName, bool isActive) - Adds or updates a feature with the given featureName and sets its initial isActive status (true for enabled, false for disabled)

- RetreiveFeature() - Retrieves all features as a dictionary where the key is the feature name and the value is a boolean indicating whether the feature is enabled (true) or disabled (false).


## Install the FeatureToggle package

```
dotnet add package FeatureToggle
```


Author - Abdulvosid Foziljonov

How to reach me - @abdulvosidfoziljonov55@gmail.com



