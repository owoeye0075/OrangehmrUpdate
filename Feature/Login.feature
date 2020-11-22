Feature: SpecFlowFeature1
	As a User
	 In order to use Giftrete Website
	 I will need to first register

@Firststage
Scenario: Valid Login 
Given that the user navigate to "https://opensource-demo.orangehrmlive.com"
And user enter username "Admin"
And user enter password "admin123"
When  user click the login button
Then the user will be login


@secondstage
Scenario:  Invalid Password Login Test
Given that the user navigate to "https://opensource-demo.orangehrmlive.com"
And user enter username "Admin"
And user enter an invalid password "admin12345"
When  user click the login button
Then the system will show failed login notification


@thirdstage
Scenario: Invalid username Login test
Given that the user navigate to "https://opensource-demo.orangehrmlive.com"
And user enter invalid username "Admin123"
And user enter password "admin123"
When  user click the login button
Then the system will show failed login notification
	

@fourthstage
Scenario: entering blank username and password
Given that the user navigate to "https://opensource-demo.orangehrmlive.com"
And user enter blank username ""
And user enter blank password ""
When  user click the login button
Then the system will show failed login notification


@fifthstage 
Scenario: Verify notification
Given that the user navigate to "https://opensource-demo.orangehrmlive.com"
And user enter blank username ""
And user enter blank password ""
When  user click the login button
Then user verify the notification


@sixthstage
Scenario: Validate the Enter Key
Given that the user navigate to "https://opensource-demo.orangehrmlive.com"
And user enter username "Admin"
And user enter password "admin123"
When user press the enter key
Then user will be able to login successfully

@seventhstage
Scenario: Enter alphanumeric characted
Given that the user navigate to "https://opensource-demo.orangehrmlive.com"
And user enter username "Admin#123"
And user enter password "admin123#"
When user press the enter key
Then the system will show failed login notification




