# VirginMediaApp

# I have implemented the project in n-tier architecture along with SOLID Principles and Repository Design Pattern

# -- Repository Layer --
# All data access operations are performed in this layer.
# In real-time, all the DB transactions using Code First Entity Framework Core are here
# Base Repository: A generic class that provides CRUD operations based on the entity model passed to it. 
# It handles all transactions using the entity model (DB model) and maps the data to the domain model upon transaction completion.
# All CRUD methods with filters will be implemented in real senario. 
# All the transactions are done with Entity model which is the DB model and after transaction completion data is mapped to Domain model. 
# No Entity Model will be pass through the Repository Layer 


# -- Service Layer --
# Here mostly business logic, validation, conversion and other transactions are handled and have direct access to repository methods 

# There are two end points Web and Web Api 
# The Web Api can be consumed by any client application and implemented as per the requirements 

# The Web Application is display the view as an web application 

## Todo:
# I need to implement JWT token authentication for Web Api's
# I would have wrote some unit testing, atleast happy path for the repository and service methods 
