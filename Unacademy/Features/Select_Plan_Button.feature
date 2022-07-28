Feature: Select_Plan_Button

A short summary of the feature

@tag1
#Scenario : Verify Select PLUS Plan button functionality
#	Given Chrome is launched and Unacademy application is launched
#	When User clicks on Get subscription button
#	And User clicks on Select PLUS button
#	Then It shows price of PLUS plan with duration in other page

#Scenario: Verify Select LITE Plan button functionality
#	Given Chrome is launched and Unacademy application is launched
#	When User clicks on Get subscription button
#	And User clicks on Select LITE button
#	Then It shows price of LITE plan with duration in other page
#
#Scenario: Verify Select ICONIC button functionality
#	Given Chrome is launched and Unacademy application is launched
#	When User clicks on Get subscription button
#	And User clicks on Select ICONIC button
#	Then It shows price of ICONIC plan with duration in other page

Scenario Outline: Verify Subscription Plan button functionality
	Given Chrome is launched and Unacademy application is launched
	When User clicks on Select '<option>' button
	Then It shows price of '<option>' plan with duration in other page

	Examples: 
	| option |
	| PLUS   |
	| ICONIC |
	| LITE   |

