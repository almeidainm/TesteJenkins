using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;


namespace TesteGoogleJenkins
{
    [Binding]
    public class AcessandoGoogle
    {
        IWebDriver driver_ = new ChromeDriver("C:\\ChromeDriver\\");

        [Given(@"que eu acesse o Google")]
        public void DadoQueEuAcesseOGoogle()
        {   
            //System.Threading.Thread.Sleep(5000);
            driver_.Navigate().GoToUrl("https://www.google.com.br");
        }
        
        [Given(@"digite ""(.*)"" na busca")]
        public void DadoDigiteNaBusca(string p0)
        {
            driver_.FindElement(By.XPath("//input[@title='Pesquisar']")).Click();
            driver_.FindElement(By.XPath("salota")).SendKeys("Inmetrics");
        }
        
        [When(@"clico no botão buscar")]
        public void QuandoClicoNoBotaoBuscar()
        {
            driver_.FindElement(By.XPath("//input[@title='Pesquisar']")).SendKeys(Keys.Enter);  
        }
        
        [Then(@"verifico se o site da inmetrics voltou na busca")]
        public void EntaoVerificoSeOSiteDaInmetricsVoltouNaBusca()
        {
            string valoratual = driver_.FindElement(By.XPath("//h3[contains(text(),'Inmetrics: Home')]")).Text;
            valoratual.Contains("Inmetrics: Home");
            driver_.FindElement(By.XPath("//h3[contains(text(),'Inmetrics: Home')]")).Click();
        }
    }
}
