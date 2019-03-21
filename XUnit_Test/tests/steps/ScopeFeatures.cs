using TechTalk.SpecFlow;

namespace Automacao_xUnit.tests.steps
{
    [Binding]
    class ScopeFeatures
    {
       
        [BeforeTestRun]
        public static void BeforeTestRun()
        {

        }

        [BeforeFeature]
        public static void BeforeFeature(FeatureInfo featureInfo)
        {
            
        }

        [BeforeScenario]
        public static void BeforeScenario(FeatureInfo featureInfo)
        {
       
        }

        [BeforeStep]
        public static void BeforeStep()
        {

        }

        [AfterStep]
        public static void AfterStep()
        {
            
        }

        [AfterScenario]
        public static void AfterScenario()
        {

        }

        [AfterFeature]
        public static void AfterFeature()
        {
            
        }

        [AfterTestRun]
        public static void AfterTestRun()
        {
            
        }           
    }
}
