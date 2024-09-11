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








## I) Integration Patterns in Software Development

Link: [Integration Patterns in Software Development](https://www.architectureandgovernance.com/applications-technology/integration-patterns-in-software-development/)

### Application Integration - Description 
Big applications has to handle complex tasks, as such they will need to interact with other application and systems to achieve this.  

#### Example 
When a user buys a pair of sunglasses on Amazon app, it must fulfill the order and bill the user when the sunglasses are delivered. 
In this case, the ordering system is integrated with the billing system and passes transactional data from the ordering system to the 
billing system, and confirmation from billing back to the ordering system. 


#### Integration patterns
In technical terms, by integration, we mean passing data back and forth, so they meet users’ functional requirements along with meeting
system’s non-functional requirements as well. But how data is passed back and forth matters and depends on what the specific use case is.
three common tyes (i.e. patterns) of integration:  
- data-centric
- event-driven 
- application-centric and their pros and cons.  Each one of these patterns can be used in a variety of use cases.


#### 1. Data-Centric Integration
- Focus on SST(single source of truth): 
The primary goal is to have a centralized and authoritative data repository, ensuring that all 
applications within the organization access consistent and accurate information.

##### Common patterns associated with data-centric integration:
- ETL
  - Description: Moves, and validates, data from diverse sources into a central repository, often a data warehouse or data lake.
  - Use Case: Useful for data consolidation, cleansing, and transformation before loading it into a target system.
  - Example: Data access from a data warehouse to data science team for analytics purposes
	
- File Transfer
  - Description: Securely transfers large datasets between systems, often in batch mode.
  - Use Case: Efficient for moving bulk data between applications and systems.
  - Example: An enterprise sending employee information to a payroll processing company.

- Shared Database
  - Description: Consolidates data into a single database accessible to multiple applications.
  - Use Case: Suitable for scenarios where multiple applications need to interact with and share a common set of data.
  - Example: Operational data store where customer transactions are processed and stored.
	
- Data Replication
  - Description: Maintains synchronized copies of data across multiple systems.
  - Use Case: Enables real-time or near-real-time access to data across distributed environments.
  - Example: Caching data for read-only purposes to provide status to the end use.
	
- Aggregation 
  - Description: Gathers data from multiple sources for reporting and analytics.
  - Use Case: Useful for creating consolidated views of data for reporting and analysis purposes.
  - Example: Data lake, data warehouse.
 
