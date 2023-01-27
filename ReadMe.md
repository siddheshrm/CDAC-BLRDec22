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
#### Options:
1. -t ->Flag to tell Docker to allocate the Virtual Terminal within the Container to start UR Program.
2. -i ->Flat to tell the Docker to execute the Application in interactive mode. 

### How real Apps work?
1. Developer builds the code in his environment and get it approved by PR and TR(PRTI)=>Personal Review and Team Inspection.
2. The Developer pushes the code the Code Repository(Git, BitBucket or TFS).
3. Once the Code is pushed, a Continuous Integration Tool(CIT) will come into picture which pulls the code from the Repo, builds in a containized environment or production Environment and on post build, it will push the code the Container like Docker and place it in the Cloud.

    --------------------------------------JENKINS------------------------------------------------
    # Jenkins
    ### What is Continuous Integration?
    An Orchestration of a chain of activities to perform continous integration of various components of the application in an automated fashion that helps in pipelining the application deployment and operational Sequence. It is responsible to keep track on any code push that happens to the repo, there by pulling the Code, building it, testing it(Runs thru all the Unit tests and E2e Tests), documenting and finally deploying the Application on the operational System. <br/>
    One of the popular CI tool is JENKINS. 

    ### How does it work?
    Jenkins is basically a server side Web Application that will run on a web server like Apache Tomcat Server. It can run on multiple platforms like Windows, Mac or Linux. To the use the Jenkins, we need pipelines (Its a series of instructions that Jenkins should do once it sees an change in the Code the Repo) and jenkins will read the pipeline and performs the tasks as defined by the pipeline. The pipeline keeps track of the Repo all the time and will be available 24 hrs within the system. It is a continuous operation that happens like a triggering of actions with steps completing one after the other. Jenkins internally has tools to build, test, monitor, raise reports, update changes and even trigger emails to the stake holders of the Application. 

    ### Install JENKINS
    1. U should install JDK 8.0 or later. Set the Environment Variables like JAVA_HOME, JRE_HOME and Path. 
    2. Download the JENKINS from the Jenkins Site. 
    3. During the installation process, ensure that U set the location of the JRE for Jenkins.
    4. U can set the PORT No for the jenkins, default is 8080, but can be modified and set accordingly.
    5. Complete the Setup and restart the machine-> For the Apache to start.
    6. Open the browser and type localhost:PortNo. 
    7. Jenkins will ask for the preset Admin password which is available at the C:\ProgramData\Jenkins\.jenkins\secrets\initialAdminPassword. U can copy the password and login with it. U can change the password if required. 
    8. After logging in, Jenkins will ask for default plugins that must be installed in UR machine. U can skip this step as the plugins are very much as per UR project requirements. U can install git and others could be optional.
    9. After the installation is done, the browser opens with the dashboard of the Jenkins where Users can add new jobs or tasks for the Jenkins to perform.

    ### Create a new Job in Jenkins.  
    1. Create the Application that U want to make Jenkins build it for you. 
    2. Define some description about the job that U intend Jenkins to do
    3. Select UR location of the Source Code either by Git or Local Repo. 
    4. In the Build Steps, Select the Windows Command and provide the Commands to execute
    ```
    javac ./ExampleFile.java
    java ExampleFile
    ```
    5. Additional Settings like POST BUILD can be set for email notifications and running of test cases. 
    6. U can set to build the Application periodically by setting the HR MM DAYS WEEKS. Refer the Help. 

    ------------------------------Microservices------------------------------------------------------------
# Microservices 
1. They are dividing UR large scale Application into small units which are independent of another. In our current scenarios, we might develop very large and complex projects that take lot of time to build and deploy. The Code building proccess would take more time and the deployment will be difficult. To reduce these complexities, most organizations are moving towards microservices where UR Application is cut into small independently executable services that can be contained inside a container like Docker and publised. This will be very easy to develop as U will be creating smaller modules and services are small but effective. Any issues with one service will not affect the other.
2. Microservices can be created on various technologies like Java, .NET and open source. 
3. We will use Microservices using .NET CORE and Docker to publish. 

## Key Questions?
### What is the software required?
1. Windows 10 or later.
2. Visual Studio 2017 or later that supports Docker tools. 
3. .NET CORE SDK for platform independence. 
4. Docker for Windows. 
5. Docker Tools

### Why should we use microservices instead of a monolithic Approach?
1. Microservices is to develop small services that each service runs in its own process. We develop the Microservices instead of one big monolithic Service for many benifits that include:
2. Microservices are smaller in size. 
3. It is easy to develop, deploy and debug, because a fix only needs to be deployed onto the microservice with a bug instead of across the board. 
4. It can be scaled quickly and can be reused in multiple projects.
5. With the size, U can contain it inside containers like Docker. 
6. Each microservice is independent of each other, if one of the services fail, there is a little risk of the full application shutting down, not a real Show stopper.

### Why should we use .NET CORE?
It's opensource, has a large no of Helpful APIs for developing high performance scalable Apps. With VS, it is faster to develop the APplications and has lot of UI support for dependency injections and cloud based Configurations. 

### Why should we use Docker?
Dockers help in containerization of UR Apps into a precreated environment which is easy to create, deploy and run the Applications using Containerization apps. 
They are light weight and takes less time to start compared to traditional servers. 
They are low cost and increases the performance with proper resource management. 
Unlike VMs, there is no need to preallocate any RAMs for UR Containers.

### How to build a Microservice?
1. Visual Studio 2017 or later IDE should be selected. Create a Project of the type ASP.NET CORE WEB API Project. 
2. Create the Data classes required for the Application. 
3. Create the Controllers required for the Application.
4. Right click on the Project to create the Docker File by the VS IDE. 
5. Build and Execute the Application. 
6. Test the App on Postman by giving the required Port no. 
7. For Interacting with SQL server, U might create the SQL server instance inside another Docker container and compose the Orchestration feature. Refer the Documents in the internet. 
----------------------------------------Intro to K8s---------------------------------------------------
# Kubernetes
It is a container management system developed by CNCF(Cloud Native Computimg Foundation) that is developed by Google Platform. It's main purpose is helping in the managing the Containerized Applications on various platforms like Cloud, Local and Virtual Environments. It is said to be one of the most flexible Containerization tool that is created to deploy Complex applications running on Clusters of 100s of individual Servers. This is purely a Cloud based Environment. It Comes with Automated Deployment, Scalling of Apps to multiple users, and operating the Applications across multiple Clusters. It is created for Container specific Infrastructure.  

### Scenario:
1. U create UR App code in the form of a Microservice that has to be built and placed in a Docker Container. U take the support of the CI Tool like Jenkins that builds UR Application and places the App Service in a Docker Container with all the software and the hardware infra requried for the service to expose.
2. In a real time scenario, there canbe 100s of such services each contained inside individual Containers. Each service works independently and each service has its own container.
3. K8s will tbe the container management tool that will have a database of containers maintained in Cloud based Environment. It ensures safety and reliability with content available all the time. It uses a concept called primary and secondary clusters that will be available even during emergencies. If the Primary Cluster fails for some unknown reason, the secondary cluster will immediately take over to provide the services all the time. 

### How K8s Work?
- It is a linux based Kernel that share lots of resources required to manage UR Complex Applications. It is primarily used for Distributed Computing Applications where it will abstract(hide) the underlying hardware servers and offers std and consistant UI for UR Application management. This UI will be used by the DevOps engineer. It will contain a DASHBOARD of servers and containers that one can monitor it from one common place. Its tools helps the DevOps Engineer to manage the resources like removing unnessasary hardware for one Cluster and allocating it to another Application that might need the most and likewise for all the other infra. 

### Features: 
1. Automatic scheduling of App processes. 
2. Integrate with other CI tools for Continuous Development, Integration and Deployment. 
3. Automatic Rollouts and Rollbacks.
4. System will be loosely coupled where every Unit works independently and one component's failure will not affect the other. 
5. Application centric Management thru nice Dashboards that will help the Engineer monitor it nicely. 
6. High Density of Resource Utilization.
7. Environment Consistency: UR App will run on all Conditions. If there are any failures in any of the servers, the Environment should provide a backup server to run the show without stopping it. 

- With all the above features, the Customer will never feel the burden of application slowdown or failures on the infra point of view. 

### Architecture of K8s
Basically K8s follows cluster architecture. It maintains a server of servers scaled across the world to manage UR Applications. Any Container that U place inside the K8s server will have primary and secondary servers. If the Primary server is down, the secondary server will provide the backup.  If UR Application running on the Primary server crashes, then the secondary serer will load the Application once again to make the services available to the Customer. 

### Key Terms:
- POD: It is the smallest Unit of a K8s Application. It can be a single App that is running in one or more groups of containers. Each POD Contains one or more containers that can be one Application. 
- NODE: Node is a single Host that has multiple PODs in it. It runs on a single Physical VM. We also call these Nodes as Minions. Clients will consume the services from the PODS available thru NODES.
- SERVER: The Server in K8s Terminlogoy is a location collection of PODS that work together for a certain functionality of UR Application. Server provides the services thru SUBSCRIPTIONS made by the User.
- CLUSTER:  is a group of Applications hosted inside one or more servers which we call it as CLUSTER. Cluster is basically a collection of servers that help in managing and sharing the infrastructure among UR Application services: RAM, CPU, DISK and devices into one BIG USABLE POOL.
- MASTER: Collection of Components that make the Control panel of the K8s. The Master will be like Admin to the System. It will be maintained by K8s Admin who work on these clusters and make decisions like Scheduling, Responding to the notifications posted by the servers and manage the servers of the Clusters. 
- NAMESPACE: Is a logical Environment that will be used to divide the Clusters on a logical grouping. 

### Components of the Master Node: 
1. Master is the actual server of the K8s. It internally has multiple processes that are required to run and manage the Clusters. 
2. API-SERVER is one such process which provides the services externally to the End Applications. It is considered as GATEWAY to the Clusters. App Developers interact with the API server to get the required services that will be consumed by their Applications. 
3. CONTROLLER MANAGER overviews on what is happening in the Clusters and ensure all the maintainence work is done thru this Controller. 
4. SCHEDULER: Internal abstraction on scheduling the jobs within the K8s server. It is maintained by one more process called ETCD. ETCD is a distributed reliable Key-value stores for data of a distributed System. 
