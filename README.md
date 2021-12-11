DPS926NSA

Assignment 2

dmchan3/056613144


# What is the final app idea and functionality?

The final app idea for Assignment 2 was to create a Restaurant Search App that would be able to look for locations where users can eat based on Province/State, City/Town, and a keyword for the type of food they are looking for (Pasta, Sushi, Barbecue). The application would also allow the user to save entries that were returned by the search query so that they can look at the restaurant details at another time.

# What are the used web services?

The web service that was used for this assignment was Yelp’s API called Fusion v3. It allows developers to send queries to Yelp’s API with different paths available for different search results. For assignment 2, Yelp Fusion’s Business Search (/businesses/search) was used to allow the application to find restaurants by using different keywords in the web service query.

# What is the data that is stored locally in SQLite DB?

In the assignment application, the data that is stored locally in the SQLite DB is the business class details of the restaurant that the user decided they want to save. There were some exceptions to the data that could be saved in the database though related to the Business Class. The variables in particular that could not have their details saved were Categories, Coordinates, Transactions, and Location. The reasoning for this from the research I did is because the SQLite Database is unable to natively save data that are not some kind of primitive type (Integer, String, Char, etc). So I decided to set up the application so that SQLite would ignore these variables and not save those particular variable’s details. If I did want to save these details, I could have tried implementing some sort of function that would loop over these details and attempt to save them as their own entries like numbers or strings. 
Also, a primary key variable was implemented into the Business Class that auto increments whenever a new restaurant entry needed to be saved.
