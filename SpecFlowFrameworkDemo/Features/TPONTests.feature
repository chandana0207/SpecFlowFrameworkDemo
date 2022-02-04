Feature: Login to TPON application
	

@Smoke
Scenario:  ACreate a New Work Item
	#steps

	Given I'm on the Portfolio Dashboard 
	And I click Quick Links menu and tap on Work Items link
	And I click New button on All Work Items Page
	And I Enter the Name, Programme/Project, Container, stage and Type on the Create Work Item pop-up box
	And I click on Save button
	And I verify the Success Notification

@Sanity
	Scenario: BEdit the Work Item
	#steps
    #Given I'm on the Portfolio Dashboard 
	Given I click Quick Links menu and tap on Work Items link
	And I Click on Name Filter
	And I enter the WIName Text in the filter textbox
	And I click Filter Button
	And I click Editlink icon to open the work item to be edited
	And I select the Status
	And I select the Owner
	And I select the priority
	And I enter the description
	And I select the internal user
	And I enter the approver
	And I select the external user
	And I enter the dates
	And I click the Discussion Tab and enter comment
	And I click Conditions tab and a condition
	And I click Issues tab and create an issue.
	And I select a file to upload
	And I Click Save Button to update the changes made.


	@Regression

	Scenario: CCreate a New Programme
	#steps

	Given  I click Programmes Menu Link
	And I click New button on all programmes page
	And I enter programme name,code,start date, end date,Investor currency and process template in the create programme pop-up
	And I click save button
	Then I verify the success notification


	
	@Regression
	Scenario: DEdit the Key Information Programme
	#steps
	
		Given I'm on the Portfolio Dashboard 
	Given  I click Programmes Menu Link

	And I click filter icon  on Name column and enter the text and click filter button
	And I click edit icon to open the programme
	And I click on Key Information tab
	And I enter value for the Expected Commitment for Investment
	And I enter Expected CoFinancing for Investment
	And I click ProcessTracker tab and create and edit stage
	And I click Risk tab then create a risk and edit risk
	And I click Kanban Tab then click plus icon to cerate a work item 
	And I click Projects Tab then click on New button to create a new project
	And I click Interventions Tab then click on New button to create a new intervention
	And I click cofinancing tab and create a new cofinance
	And I click Programme Upload tab and upload the document
	And I click programme save button


@Regression
	Scenario: ECreate a Partner,Grant,Allocation and Adjustment
	#steps

	
		Given I'm on the Portfolio Dashboard 
	Given I click Partner Menu Link and create a new partner with partner type being Investor
	And I create the grant and approve it
	And I click allocation tab to create a new allocation and I approve it
	And I click on Adjustment tab to create an adjustment and approve it

	
	
