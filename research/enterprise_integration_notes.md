# Research on Enterprise Integration

Explore current thinking (blogs, online articles, videos etc) about EnterpriseIntegration. 
By Enterprise Integration I mean distributed scalable applications with data storage that 
rely on diLerent ‘services’ or modules talking to each other. 
This means monolithic applications as well as microservices.

1. Definition of Enterprise Integration

What is Enterprise Integration, and why is it important in modern systems?
The role of Enterprise Integration in connecting services, data stores, and applications.


2. Types of Enterprise Integration Patterns

- Focus on patterns such as:
- Pipes and Filters
- Message Bus
- Publish-Subscribe
- Service-Oriented Architecture (SOA)
- Microservices


3. Current Trends and Technologies

Look for blogs, articles, and videos discussing recent developments in Enterprise Integration.
Explore the move from monolithic to microservices architecture.
Explore integration technologies like Apache Camel, Spring Integration, or RabbitMQ.

-----------------------------------------------------------------------------------------------------------------------------------------------------------

## I) Integration Patterns in Software Development

Link: [Integration Patterns in Software Development](https://www.architectureandgovernance.com/applications-technology/integration-patterns-in-software-development/)
Link: [Enterprise Integration: What It Is and Why It’s Important](https://www.ibm.com/think/topics/enterprise-integration/)
Link: [SAP - iPaaS ](https://www.sap.com/products/technology-platform/integration-suite.html)
Link: [Enterprise Application Integration wiki](https://en.wikipedia.org/wiki/Enterprise_application_integration)
Link: [Modern Examples for Enterprise Integration Patterns](https://www.enterpriseintegrationpatterns.com/)
Link: [System Integration vs Software Development](https://budibase.com/blog/app-building/system-integration-vs-software-development/)
Link: [Enterprise Architecture vs. Solution Architecture: A Simple Comparison Guide](https://www.ardoq.com/blog/enterprise-architecture-vs-solution-architecture)
Link: [Microservice Architecture pattern ](https://microservices.io/patterns/microservices.html)



### Application Integration - Description 
Enterprise integration is the process of connecting multiple applications and systems to enable seamless communication and data sharing. 
Big applications has to handle complex tasks, as such they will need to interact with other application and systems to achieve this.  
Integration allows systems to work together to meet functional requirements (e.g., completing transactions) and non-functional requirements (e.g., performance, scalability).
##### - Functional integration: How systems communicate to fulfill business processes (e.g., order fulfillment).
##### - Non-functional integration: Ensuring performance, reliability, and security in integrated systems.

#### Example of application integration
When a user buys a pair of sunglasses on Amazon app, it must fulfill the order and bill the user when the sunglasses are delivered. 
In this case, the ordering system is integrated with the billing system and passes transactional data from the ordering system to the 
billing system, and confirmation from billing back to the ordering system. 


#### Integration patterns
In technical terms, by integration, we mean passing data back and forth, so they meet users’ functional requirements along with meeting
system’s non-functional requirements as well. But how data is passed back and forth matters and depends on what the specific use case is.
Integration patterns define methods for linking various applications. The three primary patterns are:
1. Data-Centric Integration
2. Event-Driven Integration
3. Application-Centric Integration

These patterns help solve challenges like data consistency, real-time responsiveness, and modular system design.


## 1. Data-Centric Integration
- Focus on SST(single source of truth): 
The primary goal is to have a centralized and authoritative data repository, ensuring that all 
applications within the organization access consistent and accurate information.

#### Common patterns associated with data-centric integration:
- ETL (Extract, Transform, Load): 
  - Description: Moves, and validates, data from diverse sources into a central repository, often a data warehouse or data lake.
  - Use Case: Useful for data consolidation, cleansing, and transformation before loading it into a target system.
  - Example: Data access from a data warehouse to data science team for analytics purposes
  - We learned about this during sem. 4 of DAT in business intelligence course. This is common technique for
handling data before storing it in datawarehouse. Common and sometimes intensive preprocessing of data can be done away from the target system. 

- File Transfer:
  - Description: Securely transfers large datasets between systems, often in batch mode.
  - Use Case: Efficient for moving bulk data between applications and systems.
  - Example: An enterprise sending employee information to a payroll processing company.

- Shared Database:
  - Description: Consolidates data into a single database accessible to multiple applications.
  - Use Case: Suitable for scenarios where multiple applications need to interact with and share a common set of data.
  - Example: Operational data store where customer transactions are processed and stored.
	
- Data Replication:
  - Description: Maintains synchronized copies of data across multiple systems.
  - Use Case: Enables real-time or near-real-time access to data across distributed environments.
  - Example: Caching data for read-only purposes to provide status to the end use.
	
- Aggregation: 
  - Description: Gathers data from multiple sources for reporting and analytics.
  - Use Case: Useful for creating consolidated views of data for reporting and analysis purposes.
  - Example: Data lake, data warehouse.

	

#### Benefits:

- Consistency: Ensures that all applications are using consistent and up-to-date data.
- Efficiency: Reduces redundancy and enhances efficiency by avoiding duplicate data storage.
- Accuracy: Facilitates accurate reporting and analytics by providing a reliable data foundation.
 
#### Key Considerations:

1. Data Quality and Consistency: Ensuring data quality and consistency is crucial to maintain the integrity of the single source of truth.
2. Security and Compliance: Implementing security measures to protect data during transfer and ensuring compliance with regulations.
3. Scalability: Designing integration solutions that can scale to handle growing volumes of data and evolving business requirements.
4. Monitoring and Management: Establishing monitoring mechanisms to track data movement, detect issues, and ensure timely resolution.
5. Metadata Management: Managing metadata is essential for understanding the structure, origin, and lineage of the integrated data.


## 2. Event-Driven Integration
Definition: Event-driven integration enables systems to respond to real-time events without direct coupling between components.

#### Key Integration Techniques:
- Message-Driven Communication: Systems exchange messages through message brokers, supporting real-time updates and notifications.
  - Example: Real-time updates on order status from an e-commerce system.
- Event-Driven Communication: Events are broadcasted, and systems independently react to them.
  - Example: An IoT thermostat sending temperature data to its server for analysis.


#### Key Considerations:
- Scalability: Event-driven systems handle large numbers of asynchronous events.
- Error Handling: Systems must manage failures and retries.

## 3. Application-Centric Integration
Definition: This approach emphasizes modular design and reusability by using well-defined interfaces like APIs.

#### Key Integration Techniques:
- Facade: Simplifies complex systems by offering a unified API.
  - Example: A user interface for an e-commerce platform that hides the complexity of multiple backend services.
- Adapter: Translates data between systems with incompatible formats.
  - Example: Integrating a modern payment gateway with an older e-commerce system.
- Content-Based Routing: Dynamically routes messages based on their content.
  - Example: An email system routing messages based on keywords.


#### Key Considerations:
- API Design: Ensure consistency and simplicity in API development.
- Modularity: Break down applications into smaller, reusable services.


## Conclusion
Enterprise integration patterns offer multiple ways to connect systems, each with unique benefits depending on the use case.

- Data-Centric patterns suit scenarios where consistent, reliable data is needed.
- Event-Driven patterns are ideal for real-time responsiveness and scalability.
- Application-Centric patterns focus on modularity, enabling scalable and maintainable system design.

By understanding and applying these patterns, organizations can build efficient, scalable, and maintainable systems to meet both current and future needs.


## What is Enterprise Integration ? 
A big organization may have many different Departments, IT systems, Applications, Databases etc. Using different integration approaches and models,
enterprise services and assets can be leveraged in order to integrate with one another. This enables easy integration, unification and standartization of business capabilities
accros different enterprise services, assets etc. 


Enterprise integration is the use of multiple integration approaches:
- api management 
- application integration 
- messaging 

Enables big organizations to do:
- Sharing critical information
- Simplifying IT processes
- Maximizing opportunities

1. API's

2. Application Intregration

3. Messaging 

4. Events

5. Data:
Real-world operational data, enables continuous improvement (CI) of enterprise architecture.
Data is also used to assess the criticality and usage of integrations and determine their target state. 
When analyzed, data reveals recommended target integration patterns (e.g., service-oriented architecture 
(SOA), event-driven, message-driven, etc.), consolidation possibilities and other inputs that help define 
the target integration state.



Patterns for implementing EAI
- Mediation (intra-communication)
- Federation (inter-communication)


Access patterns:
EAI supports both asynchronous (fire and forget) and synchronous access patterns, the former being typical in the mediation case and the latter in the federation case.

Lifetime patterns
- An integration operation could be short-lived (e.g., keeping data in sync across two applications could be completed within a second) 
- or long-lived (e.g., one of the steps could involve the EAI system interacting with a human work flow application for approval of a loan that takes hours or days to complete)


Topologies
There are two major topologies: 
- hub-and-spoke
- bus. 

Each has its own advantages and disadvantages. In the hub-and-spoke model, the EAI system is at the center (the hub), and interacts with the applications via the spokes.
In the bus model, the EAI system is the bus (or is implemented as a resident module in an already existing message bus or message-oriented middleware).[citation needed]
Most large enterprises use zoned networks to create a layered defense against network oriented threats. For example, an enterprise typically has a credit card processing 
(PCI-compliant) zone, a non-PCI zone, a data zone, a DMZ zone to proxy external user access, and an IWZ zone to proxy internal user access. 
Applications need to integrate across multiple zones. The Hub and spoke model would work better in this case


Technologies
- Bus/hub
- Application connectivity
- Data format and transformation
- Integration modules
- Support for transactions



### Enterprise Architecture vs. Solution Architecture
Enterprise Architecture (EA): overall structure, expert in wide array of frameworks, manage solution.

Solutioan Architecture (SA): specific integration task, expert in specific integration task, work with and communicate knowledge and data to enterprise architect

### Balance between software development and System integration.
Seamless integration is, in most cases, prob not achievable. Thus a little software development might be a requirement in order to intregrate. 
Lets say we wanted to utilize customer data from a CRM system such as salesforce for your online store. In order to make use of the data and in compliance with best practices,
the data needs processing. To achieve system integration between the CMR system and the online store, some software development is also neccesary.








- Publish-Subscribe Channel
- Dead Letter Channel
- Return Address
- Message Expiration
- Content-based Router
- Scatter-Gather
- Message Filter
- Aggregator
- Process Manager
- Content Enricher
- Transactional Client
- Event-driven Consumer
- Competing Consumers
- Channel Purger





### integration platform-as-a-service (iPaaS)
example of this is SAP integration suite






terms
- integration framework
- iPaaS
- middleware framework
- system of systems
- Data integration: Ensures that information in multiple systems is kept consistent. This is also known as enterprise information integration (EII).
- EAI
- low-code development tools

































## Application Integration (Software Intregration) 

 Though every enterprise application serves a unique purpose within a business’s tech stack, each app also generates its own data. 
 And many enterprise workflows rely on real-time data flow between apps and systems communicating with each other on the network. 
 Without app integration, IT teams would have to allot staff for time-consuming manual data entry to integrate data from different software and data sources. 
 This would eliminate the possibility of real-time data transmission and data sharing.


 ### Application integration technologies
There are several technologies businesses can use (alone and in combination) to build and automate integration workflows. These technologies include:

- Application programming interfaces (APIs)
An API is a set of rules or protocols that lets software applications communicate with each other to share data, features and functions. 
APIs simplify and accelerate software development by enabling developers to integrate data, services and capabilities from other applications, instead of developing them from scratch.


- Middleware
 Middleware is software that enables communication and connectivity between applications or components in a distributed network, essentially 
creating "software glue" that binds different systems together. Using a range of intelligent features (message brokers, enterprise service buses (ESBs) 
and web app servers, for instance), middleware streamlines app development by facilitating communication between platforms that weren’t designed to organically connect.


- Webhooks
Unlike API-led integration, which relies on code-based data requests, webhook integrations are HTTP callbacks that rely on events for application integration and data transmission.
An “event” is any foundational data structure that records occurrences in the system or environment. When a system event occurs, a webhook will automatically 
trigger data exchange between network devices. Webhooks facilitate automated, event-driven integration workflows that can transmit data in real time (or near-real time).



### Application integration models
Application integration relies on a network of interconnected processes and 
data exchanges that enable integration tools to orchestrate various functions
across an infrastructure and improve operational efficiency. However, there are 
several ways businesses can approach the integration process, including:

- Point-to-point integration
Point-to-point system integration involves creating direct connections between individual software 
systems or applications, after which each system communicates directly with another using custom integration logic.
It’s the most straightforward integration strategy and the direct connections make implementing integrations a 
relatively cheap and simple process. However, the larger the network of apps and processes, the more point-to-point 
integrations teams will have to configure and maintain. This limitation makes point-to-point strategies best suited 
for small-scale integration projects.

- Enterprise application integration (EAI)
In an EAI (also called a “hub-and-spoke” integration), a central hub acts as an intermediary for all communications 
between systems. Each system connects to the hub, which handles message routing to the appropriate spokes, eliminating 
the need for direct connections.
Hub-and-spoke integrations provide a single point of monitoring and control along with message orchestration capabilities, 
so IT teams can more easily add and remove systems without disrupting existing integrations.
However, the hub also represents a single point of failure—if the hub crashes or experiences availability issues, the 
entire integrated system might suffer. Furthermore, as businesses scale operations and the hub grows to accommodate more systems (spokes), EAIs can become prohibitively costly and complicated to maintain.

- Enterprise service bus (ESB)
An ESB is a middleware solution that provides a highly flexible integration platform. It uses a bus-like architectural 
framework wherein a centralized software component performs integrations between applications. ESBs receive messages at 
one API endpoint, use business logic to find the addresses of the destination endpoints and then send the message to the destination.
ESB solutions can support a variety of communication protocols and data formats, enabling for more diverse integrations. 
ESB also enables IT teams to reuse integration components across different projects, which can minimize software development time.
And since ESB integrations are loosely coupled, they can be easier than some other solutions to update and maintain.
However, with the rise of cloud-native ecosystems, ESB tools are becoming obsolete as integration tools.

- Message-oriented middleware (MOM)
Message-oriented middleware facilitates asynchronous communication between systems using message queues. 
It decouples the sending and receiving processes, so that disparate systems can communicate without being directly connected.
When an application sends a message, MOM adds the message to a queue, where it remains until the app server is ready to retrieve it.
Neither application is directly dependent on the other for communication.
MOM integrations can improve system scalability, reliability and resilience by enabling network processes to run independently. 
Despite their benefits, MOM integrations require vigilant real-time monitoring to ensure that message queues and brokers continue to run optimally.

- Microservices integration
Microservices architectures break down applications into small, independent services that communicate over a network. 
Each service is designed to perform a specific function and can be developed, deployed and scaled independently.
A microservices layer can leverage the benefits of existing systems (ESBs and point-to-point integrations, for instance) 
to manage app data integration. Microservices don’t use intermediary nodes to route data; instead, they rely on protocols such as 
WebSocket and HTTP for direct app connection and service addresses for API integration.
Though microservices integrations require robust monitoring practices (which can be costly), they enable enterprises to customize 
integrations and build more resilient IT environments.

- Integration platform as a service (iPaaS)
iPaaS is a suite of self-service, cloud-based tools that helps enterprises build and deploy integration flows, which can connect 
applications with public and private cloud data and connect the cloud with on-premises data centers.
iPaaS platforms use pre-built connectors and templates to orchestrate data exchange and integration. This helps ensure secure, 
end-to-end data delivery to consuming applications, or to data warehouses and lakes for later analysis. If, for instance, 
an integration depends on APIs, the iPaaS will manage the API calls, handle authentication and make sure data is exchanged securely.
iPaaS deployment can require a lot of time and forethought, especially in sprawling enterprise-level environments. 
However, iPaaS solutions provide a single platform for all an enterprise’s data exchange and integration needs.




_______________________________________________________


## Microservices 

shared database can lead to deadlock. The database can get stuck, while trying to service requests.
one request might lock tables in the SHARED database, which will 
result in deadlock if another micro service is making requests
involving those tables.

distributed transactions

ACID principle

2-phase commit pattern

Saga pattern: need to rollback actions made to databases in prevoius phases of 
the event. Must make rollback functions = more overhead(more cost).

API composition:

seperating database into read and write. 

CQRS command query responsability segregation 

event sourcing management system



## Monolithic applications: 
These are traditional, tightly coupled systems where the user interface, logic, and data storage are bundled into a single application. 
All components talk to a centralized database.
## Microservices: 
A microservices architecture breaks the system down into smaller, loosely coupled, and independent services. 
Each service has its own data storage, and services communicate over APIs or messaging systems.

Communication between Services
To ensure that different services or modules can work together, EI provides various methods for communication:

- APIs (Application Programming Interfaces): Services can expose APIs for others to interact with them.
- Messaging Systems: Asynchronous communication via message brokers (e.g., RabbitMQ, Kafka) can decouple services, improving fault tolerance and scalability.
- Service Buses: These are centralized communication mechanisms that route messages between services.


