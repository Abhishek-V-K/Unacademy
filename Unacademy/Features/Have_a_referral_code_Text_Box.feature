Feature: Have_a_referral_code_Text_Box

A short summary of the feature

@tag1
Scenario: Verifying Have a referral code Text Box functionality
	When User clicks on Select PLUS button
    When User clicks on Accept cookies button
	When User clicks on Have a referral code Text Box and enters Valid referral code and click on apply
	Then It shows message you got off.

Scenario: Verifying Have a referral code Text Box functionality negative testing
    When User clicks on Select PLUS button
    When User clicks on Accept cookies button
	When User clicks on Have a referral code Text Box and enters Invalid referral code and click on apply
	Then It shows message you got off.

Scenario: Verifying View all plans button functionality
    When User clicks on Select PLUS button
    When User clicks on Accept cookies button
	When User clicks on View all plans 
	Then It shows all plans 

