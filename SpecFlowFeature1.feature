Feature: Ability to make general enquiry
	In order to	create an enquiry
	As a vistor
	I want to be able to contact Planit

@mytag
Scenario: Sending online messagentn
	Given I can access the Planit homepage
	And I can select the "Contact Us" button
	And I can entered Jeff in firstname 
	And I can enter Gorg in lastname
	When I submit my enquiry
	Then I should see an error message to fill in job title

Scenario Outline: Sending online messagentn - V2

	Given I can access the Planit homepage
	And I can select the "Contact Us" button
	And I can entered <firstname> in firstname 
	And I can enter <lastname> in lastname
	When I submit my enquiry
	Then I should see an error message to fill in job title


Examples:
   |firstname | lastname|
   | test1    | test2   |
   | test3    | test4   |