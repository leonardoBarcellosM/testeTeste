using TechTalk.SpecFlow;

namespace XUnit_Test.tests.steps
{
    [Binding]
    class ScopeFeatures
    {
        private ClassUtilities util = new ClassUtilities();
   
        [BeforeTestRun]
        public static void BeforeTestRun()
        {

        }

        [BeforeFeature]
        public static void BeforeFeature(FeatureInfo featureInfo)
        {
            ClassDriver.GetInstance().StartDriver();
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
            //Assert.True(ClassInfo.GetInstance().ResultScenario, ClassInfo.GetInstance().LogMessage, null);
        }

        [AfterFeature]
        public static void AfterFeature()
        {
            ClassDriver.GetInstance().QuitDriver();
        }

        [AfterTestRun]
        public static void AfterTestRun()
        {

        }           
    }
}
