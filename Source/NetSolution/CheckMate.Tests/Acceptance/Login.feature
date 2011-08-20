Feature: Login
	In order to access advanced functionality
	As a user
	I want to able to log myself in

Scenario: Login
	Given I am on page UserLogin
		And I have entered florian into the username
		And I have entered 1234 into the password
	When I press the login button
	Then I should be redirected to UserHome
