using OrangehmrProject.PageObject;
using System;
using TechTalk.SpecFlow;

namespace OrangehmrProject.StepDefinition
{
    [Binding]
    public class LoginStepsDefinition
    {
        OrangeloginTest orangeloginTest;

        public LoginStepsDefinition()
        {
            orangeloginTest = new OrangeloginTest();
        }

        [Given(@"that the user navigate to ""(.*)""")]
        public void GivenThatTheUserNavigateTo(string url)
        {
            orangeloginTest.Navigateurl(url);
        }
        
        [Given(@"user enter username ""(.*)""")]
        public void GivenUserEnterUsername(string uname)
        {
            orangeloginTest.EnterUsername(uname);
        }
        
        [Given(@"user enter password ""(.*)""")]
        public void GivenUserEnterPassword(string pword)
        {
            orangeloginTest.Enterpass(pword);
        }
        
        [Given(@"user enter an invalid password ""(.*)""")]
        public void GivenUserEnterAnInvalidPassword(string pword)
        {
            orangeloginTest.EnterinvalidPass(pword);
        }
        
        [Given(@"user enter invalid username ""(.*)""")]
        public void GivenUserEnterInvalidUsername(string uname)
        {
            orangeloginTest.EnterInvalidUsername(uname);
            
        }
        
        [Given(@"user enter blank username ""(.*)""")]
        public void GivenUserEnterBlankUsername(string uname)
        {
            orangeloginTest.EnterUsername(uname);
        }
        
        [Given(@"user enter blank password ""(.*)""")]
        public void GivenUserEnterBlankPassword(string pword)
        {
            orangeloginTest.EnterinvalidPass(pword);
        }

        [Then(@"user verify the notification")]
        public void ThenUserVerifyTheNotification()
        {
            orangeloginTest.ViewNotification();
        }


        [When(@"user click the login button")]
        public void WhenUserClickTheLoginButton()
        {
            orangeloginTest.ClickLogin();
        }
        
        [When(@"user press the enter key")]
        public void WhenUserPressTheEnterKey()
        {
            orangeloginTest.PressEnter();
        }
        
        [Then(@"the user will be login")]
        public void ThenTheUserWillBeLogin()
        {
            orangeloginTest.CheckLogin();
        }
        
        [Then(@"the system will show failed login notification")]
        public void ThenTheSystemWillShowFailedLoginNotification()
        {
            orangeloginTest.ViewNotification();
        }
        
        [Then(@"user will be able to login successfully")]
        public void ThenUserWillBeAbleToLoginSuccessfully()
        {
            orangeloginTest.CheckLogin();
        }
    }
}
