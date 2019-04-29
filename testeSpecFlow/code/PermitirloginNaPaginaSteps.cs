using System;
using TechTalk.SpecFlow;

namespace testeSpecFlow.code
{
    [Binding]
    public class PermitirloginNaPaginaSteps
    {
        [Given(@"Dado que estou na pagina ""(.*)""")]
        public void GivenDadoQueEstouNaPagina(string site)
        {
            
        }
        
        [When(@"Eu informar ""(.*)"" no campo ""(.*)""")]
        public void WhenEuInformarNoCampo(string p0, string p1)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"Eu clicar no botao ""(.*)""")]
        public void WhenEuClicarNoBotao(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"Dever ser apresentado o text ""(.*)"" no campo ""(.*)""")]
        public void ThenDeverSerApresentadoOTextNoCampo(string p0, string p1)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
