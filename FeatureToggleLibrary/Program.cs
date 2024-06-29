
using FeatureToggleLibrary;

InMemoryFeatureToggleService service = new InMemoryFeatureToggleService();

Console.Write("Feature ni kiriting: ");
string feature = Console.ReadLine();

switch(feature)
{
    case "NewFeature": if(service.IsFeatureEnable("NewFeature")) Console.WriteLine("You NewFeature"); break;
    case "BetaFeature": if(!service.IsFeatureEnable("BetaFeature")) Console.WriteLine("You BetaFeature"); break;
}

