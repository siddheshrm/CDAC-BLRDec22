# DevOps Training
### Course Outline:
- DevOps + Docker + Jenkins + K8s

### What is DevOps?
- There are 2 Teams that collaborate in a Project Life Cycle. Developer Team and Operations Team.
- What is the Development Team?
    - Development means the following things:
        1. Requirement Gathering -> The Team acquires all the inputs from the Customer required for the Application Development. 
        2. Design -> Based on the inputs given by the Customer, the team will design a HLDC and LLDC that tells about the App, Technology involved, reasons on the technology, its features, limitations, and if required a POC(Proof of Concept). If required, any additional Show Stoppers will be explained to the Customer and take feedback on the alternate solutions. 
        3. Unit Testing -> Unit tests will be created to provide the test cases for the Behavior of the Application and accordingly the Application will be developed. This is called as BDD(Behavioral Driven Development). Usually this will be a part of the build cycle of the Application. 
        4. Coding -> The Time where the Application creation happens. The teams will split all their tasks into Sprints using Agile Development Methodology and develop the Code accordingly and share the completed code into a Code Repo(Git, BitBucket, TFS) 
        5. Integration Process-> Final Build of the Application with Release mode and the bugs are fixed and all the Configs are set and the required dependencies are placed in the Application. 
        6. Deployment -> The Deployment will be done with the Support of IT Engineers who take care of the Installation, Usage of the Application(Operations) in the Customer's Prospective.
    - Developer teams include Directors, Project Managers, Team Leads and Tech leads, Sr. Software Engineers, Jr. Software Engineers and Testers.
- What are the Operations Team ?
    - The OPs Team will do the following things:
        a. Automation Testing: This is E2E Testing that is done to see the flow of the Application in an executing Environment of the Customer. These tests are triggered using some Testing commands or Continuous Integration Tools(CIT) like JENKINS.  CIT tool does things like building, testing and deploying the Application on the Customer specified Environment. 
        b. App Evaluation : This involves Quality Testing of the Application including Performance, Load-Testing and Analysis of the Complete E2E Environment. They might include other technical aspects like Cluster Management, Resource management.  
        c. Integrations with various servers : Includes the Plumbing work of integrating various Servers like Database, Application, Sharepoint, Cloud servers. All these will interact to UR Application representable as one SINGLE UNIT. 
        d. Final Hand-Shake: The Final Deployement is the phase where a UAT(User Acceptance Tests) process will begin, a UAT Engineer from the Customer's end will test the Application manually to make the App work in the Environment which he/she uses every day. Here the App is tested by the End users of the Application and give the feedback. Once the Application evaluation is complete, the Customer gives the Closure letter which means that Project has been Completed Successfully.
    - QA Teams, Product Owners, Product evaluators, UAT Engineers and Customer Users will be the part of the Operations Teams. 
        

