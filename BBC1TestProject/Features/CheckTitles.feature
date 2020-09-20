Feature: CheckTitles
	In order to bla bla bla
	As a BBC news manager
	I want to check titles of aticles at BBC
	Background: 
	#1 #3 #6
	Given I navigate to the website
	


@mytag
Scenario Outline: Check The Title Of The Headline Article
	#2
    When I click on News button
	Then the title of the headline article is "<headlineText>"
	Examples: 
	| headlineText                                      |
	| UK sets £10,000 fines for self-isolation breaches |

	@mytag
Scenario Outline: Check Secondary Article Titles
	#4
	When I click on News button
	#5
	Then Then Secondary article titles are: "<titles>"
	Examples: 
	| titles                                             |
	| Trump says Supreme Court nominee will be a woman   |
	| Judge blocks US attempts to ban China's WeChat     |
	| Flypast marks Battle of Britain 80th anniversary   |
	| Sarcophagi buried for 2,500 years exhumed in Egypt |
	| Runner gives up medal to rival who went wrong way  |


	@mytag
Scenario Outline: Check The Name Of The First Article On SRP
	#7
	When I click on News button
	#8
	And I enter Category link of the headline article in Search field
	#9
	Then the title of the first article is "<headlineText>"
	Examples: 
	| headlineText                |
	| Weather forecast for the UK |