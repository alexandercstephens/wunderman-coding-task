Created as a coding task for Wunderman Health. Made with Visual Studio 2019. Authored by Alex Stephens.

---------------

This solution contains two projects, API and WebApplication.

API is an ASP.NET Web API application containing a single endpoint that returns a list of gizmos from sample data.

WebApplication is an ASP.NET MVC application containing a single view displaying the output of the API's endpoint in a table.
The HttpJsonGizmoResource class handles connecting to the endpoint using HttpClient and deserializing the response.

---------------

To run the application, go to the solution properties in Visual Studio and set "Multiple startup projects", setting both API and WebApplication to Start. Then Start the application through VS, which will run both projects on IIS Express.
