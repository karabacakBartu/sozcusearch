Project Overview
---
This project is a web application built using ASP.NET Core Razor Pages. It connects to an Elasticsearch database to display and search articles retrieved from the web. But you need to start "node_crawl_and_save_to_elastic" before this application.

Features
---
Article Display: Lists articles stored in the Elasticsearch index.
Search Functionality: Users can search for articles by title using a search bar.

ASP.NET Core 8: For building the Razor Pages web application.
Elasticsearch: For storing and searching article data.
Elasticsearch.NET & NEST: For interacting with Elasticsearch.


Clone the Repository:

git clone <repository-url>
cd <repository-folder>

Install Dependencies: Open the project in Visual Studio and ensure all NuGet dependencies are restored.

Configure Elasticsearch:

Ensure Elasticsearch is running on http://localhost:9200.
Update the connection settings in ElasticSearchService.cs if needed.
Run the Application:

In Visual Studio, press F5 

Access the Application:

Open a web browser and navigate to:
http://localhost:<port>
(Replace <port> with the port number displayed in the console output.)

Usage
---
Viewing Articles:
The homepage displays a list of articles retrieved from Elasticsearch.

Searching Articles:
Enter a keyword in the search bar to find articles with matching titles.

Known Issues
---
Elasticsearch must be running locally on port 9200. (you need to start "node_crawl_and_save_to_elastic" before this application.)
Ensure that the index (sozcu-news) is populated with valid data before running the application.
