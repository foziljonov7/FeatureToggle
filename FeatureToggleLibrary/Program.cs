using FeatureToggleLibrary;

IFeatureToggleService featureToggleService = new InMemoryFeatureToggleService();

string feature = "ProVersion";

//Add a feature
featureToggleService.AddFeature("ProVersion", true);
featureToggleService.AddFeature("BetaVersion", false);

//Check the feature
if (featureToggleService.IsFeatureEnable(feature))
    ProVersionMethod();
else if (featureToggleService.IsFeatureEnable(feature))
    BetaVersionMethod();
else
    Console.WriteLine("Feature not available");

//Write the Pro version logic
void ProVersionMethod()
    => Console.WriteLine("Executing ProVersion feature method...");

//Write the Beta version logic
void BetaVersionMethod()
    => Console.WriteLine("Executing BetaVersion feature method...");








