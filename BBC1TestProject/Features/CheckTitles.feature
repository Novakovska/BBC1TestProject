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
	| headlineText                                    |
	| US Supreme Court Judge Ruth Bader Ginsburg dies |

	@mytag
Scenario Outline: Check Secondary Article Titles
	#4
	When I click on News button
	#5
	Then Then Secondary article titles are: "<titles>"
	Examples: 
	| titles                                         |
	| Obituary: A feminist heroine and cultural icon |
	| 'Ginsburg was an amazing woman' - Trump        |
	| Remembering the trailblazer for women’s rights |
	| Meet the judges on the top US court            |
	| How has Trump's Supreme Court changed America? |
	


	@mytag
Scenario Outline: Check The Name Of The First Article On SRP
	#7
	When I click on News button
	#8
	And I enter Category link of the headline article in Search field
	#9
	Then the title of the first article is "<headlineText>"
	Examples: 
	| headlineText                               |
	| Tudur's TV Flashback: Series 1: Technology |
	