using NUnit.Framework;
using TechTalk.SpecFlow;

namespace Endjin.Lib
{
    [Binding]
    public class AdditionSteps
    {
        private int result;

        [When("I have performed the only addition anyone is likely to want to perform")]
        public void WhenIHavePerformedTheOnlyAdditionAnyoneIsLikelyToWantToPerform()
        {
            this.result = Calculator.Add(40, 2);
        }

        [Then("the answer should be (.*)")]
        public void ThenTheAnswerShouldBe(int answer)
        {
            Assert.AreEqual(answer, this.result);
        }
    }
}
