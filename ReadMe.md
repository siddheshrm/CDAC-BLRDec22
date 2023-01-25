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
        1. Automation Testing: This is E2E Testing that is done to see the flow of the Application in an executing Environment of the Customer. These tests are triggered using some Testing commands or Continuous Integration Tools(CIT) like JENKINS.  CIT tool does things like building, testing and deploying the Application on the Customer specified Environment. 
        2. App Evaluation : This involves Quality Testing of the Application including Performance, Load-Testing and Analysis of the Complete E2E Environment. They might include other technical aspects like Cluster Management, Resource management.  
        3. Integrations with various servers : Includes the Plumbing work of integrating various Servers like Database, Application, Sharepoint, Cloud servers. All these will interact to UR Application representable as one SINGLE UNIT. 
        4. Final Hand-Shake: The Final Deployement is the phase where a UAT(User Acceptance Tests) process will begin, a UAT Engineer from the Customer's end will test the Application manually to make the App work in the Environment which he/she uses every day. Here the App is tested by the End users of the Application and give the feedback. Once the Application evaluation is complete, the Customer gives the Closure letter which means that Project has been Completed Successfully.
    - QA Teams, Product Owners, Product evaluators, UAT Engineers and Customer Users will be the part of the Operations Teams. 
        
- Challenges in this Setup:
    - Many a time, the Ops Team are not aware of the Technical aspects in the Application like packages, its versions and its venerabilities even though they might be minor ones. 
    - The Integration Config files are very huge in no, especially if U R working on multiple servers, and it might take days to resolve any bugs. 

- The Solution for all the above problems is the Collaborative work of both the Developer team and the Operations Team: Dev + Ops: DevOps. 
- With this, the Ops Team dont have any surprises. Both the teams do a collaborative work on understanding the Application, its execution process, and involve themselves on many developmental and deployemental issues, finally helping each other in understanding both the sides of the Project Execution. 

### Why DevOps?
Earlier, the Dev Team and the Ops Team were working in Complete Isolation. Here Testing and the Deployment activity were something that was done after the Complete Development. With this, it consumed more time than the work done with short builds. Unexpected challenges used to pop up with no clue from the Dev Team, as even the Dev Team were unware of the Environment settings of the Customer side. Many a time, with the manual code deployment, there were tendencies of human errors, sometimes taking days together to resolve it. 
With Devops, Software delivery is automated which will be fast and easy. It increases the Deployment easiness and also reduces the Complexity. It is estimated that with DevOps methodology, the deployment time has been reduced by 20% of the total Application delivery. Most of the procedures are automated with high end tools to do major jobs. These tools like Git(Code Repo), JENKINS(CIT), Kubernetes(Containerization), Docker(VM like Containers) that helps in building the Application with little scope of errors.

### Benifits of DevOps?
1. Productivity: As the Dev Team and the Ops team will work in Collaboration at all levels, any software that is created thru' this cycle of events will be under the supervision of a DevOps Engineer. Building, Testing and Integration wil be the part of this cycle. Any failures that pops up at any level can be identified and make it known to all the stake holders of the Application. So all the members can immediately work on those bugs and resolve it as early as possible. With this, teams are aware of the challenges and they work to ensure that those challenges are met with success. It gives low failure rates compared to any other Deployment methodologies. 
2. Reproducability: As we maintain the versioning of the Applications, any recent build failures can be rolled back for the stable version and can be reproduced without affecting the Environment. 
3. Maintainability: With large no of Tools available for the Devops, and most of these tools are open sourced and free licensed, it is easy to maintain. To store the Code, we can use GIT, to build the Application Cycle we use JENKINS, to handle Issues we use JIRA, to place the Code in the Production like Environment we use Docker and manage multiple Dockers thru a containerization tool like Kubernetes(K8s). To place the Application on an Environment that can be reliable and accessible anywhere in the world we have Cloud Computing Softwares maintained by well trusted Organizations like Google, Microsoft, Amazon and Oracle. 

### What kind of Apps can use DevOps?
1. Large scaled Distributed Computing Apps like E-Comm portals, Apps that work with IoT and Cloud are suited to be developed using DevOps. It can also be used by App Developers who develop Apps using Agile Development methodologies where UR Large App is cut into small but rich in feature tasks and subtasks called as Sprints and builds are expected to be small and frequent. In such cases, the changes are expected to be frequent and Devops tools helps in automating these processes effectively with little human interventions. 

### DevOps Automation Tools:
After the Development is complete, the ops teams need resources or tools to build, test, integrate and deploy the Application. For these things, we dont need the Developer team support. These works can be done by Non-Developer community but with little or fair amount of knowledge on the technology. <br>
Many a time, these tasks are routine in nature and we dont a real time resource to monitor it. We have tools to do the job.
Deployment tools: Jenkins
Logging Tools: Log4J and Splunk
Containers: Dockers
Containerization Tools: Kubernetes
Testing Tools: Selenium and Chai
-------------------------------------Day 2---------------------------------------
# Docker
It is a centralized platform for packaging, deploying and running the Applications. 
The Application that U developed can be placed in a closed Environment with all the required infrastructure to make UR Application called as Containers. The Container can be shared to all the Customers and even placed in Cloud. The Customers will use the Containers as their place of work and start using it. 

### What is Docker?
It is an Open sourced platform to create and deploy UR applications on different platforms without a need to a real time OS where the Host Environment's OS will be taken as its own OS. Dockers use a concept called Containers on the Host OS to run UR Applications. 

### Installing Docker on Windows
1. Install the WSL(Windows SubSystem for Linux) using the wsl --install. U should be running the Cmd as Administrator. 
2. Download the Docker Desktop App from the website https://www.docker.com/products/docker-desktop/
3. Continue with the installation process, accept defaults and restart UR Machine. 
4. Docker immediately starts on bootup and wait for the Application to start. 
5. The purpose of WSL is only for Windows OS. It provides a Linux kernel on Windows which is used by Docker to Run. 

### Download the Mongodb Container into Docker from DockerHub
Create the Volume for storing UR data in MongoDB
```
docker volume create --name= MyContainer
```
1. Run the following Command:
```
docker -run -it --rm --name mongoContainer mongo:latest mongod
```
2. In another terminal U run the following command
```
docker exec -it mongo mongosh
```
### Create Docker Images:
#### Docker Image on a Java Application:
1. Create a new Folder and name it as per your requirement(In our case, its Simple Java App) 
docker build -t java-app
2. Create the required Java files for UR Application. 
3. Create a Dockerfile which is basically a text file with no extensions and the name must be Dockerfile. 
4. Provide all the instructions required for the dependencies for the Container.(File shared)
5. Build the Docker Image using the command:
```
docker build -t java-app . 
``` 
6. U can check the image being loaded into the Docker Desktop before moving to the final step.
7. Run the command to execute the Program from Docker:
```
docker run java-app
```