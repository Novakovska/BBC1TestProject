
Feature: SubmitAQuestion
	In order to use https://www.bbc.com
	As a user
	I want to share story
	Background: 
	#1 #10 #20 #30
	Given I navigate to the website
	#2 #11 #21 #31
	    And I click on News button
		#3 #12 #22 #32
	    And I click on Coronavirus button
		#4 #13 #23 #33
	    And I click on Your Coronavirus Stories button


@negative
Scenario Outline: Submit A Question Without Checkboxes Admited
	#5
	When I click on How to share with BBC News
	#6
	    And I enter the Story Text "<sometext>"
		#7
	    And I enter the Name "<name>"
		#8
	    And I click the Submit button
		#9
    Then I should stay on the same page with URL "https://www.bbc.com/news/10725415"

		Examples: 
		| sometext    | name      |
		| bla bla bla | Viktoriia |


@negative
Scenario Outline: Submit A Question With Story Field Empty
	#14
	When I click on How to share with BBC News
	    #15
	    And I enter the Name "<name>"
		#16
		And I pick I am over sixteen years old
		#17
	    And I pick I accept the Terms of Service checkbox
		#18
	    And I click the Submit button
		#19
    Then I should stay on the same page with URL "https://www.bbc.com/news/10725415"

		Examples: 
		| name      |
		| Viktoriia |
		| Виктория  |
		| 123#$%    |
		|           |


@negative	 
Scenario Outline: Submit A Question With Name Field Empty
	#24
	When I click on How to share with BBC News
	#25
	    And I enter the Story Text "<sometext>"
	    #26
		And I pick I am over sixteen years old
		#27
	    And I pick I accept the Terms of Service checkbox
		#28
	    And I click the Submit button
		#29
    Then I should stay on the same page with URL "https://www.bbc.com/news/10725415"

		Examples: 
		| sometext         |
		| smth interesting |


@negative
Scenario Outline: Submit A Question With All Fields Empty
	#34
	When I click on How to share with BBC News
	    #35
	    And I click the Submit button
		#36
	Then I should stay on the same page with URL "https://www.bbc.com/news/10725415"
