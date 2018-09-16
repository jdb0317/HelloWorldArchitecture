Solution contains an API and a consumer console application.
When run through Visual Studio, API endpoint can be found at http://localhost:51517/api/HelloWorld/Print
If API url or port should change, the appropriate change must also be reflected within the console's App.Config file.
AppConfig settings:
	WebApiEndpoint - URL Address to API endpoint from which the console application will retrieve data
	OutputDestination - The means through which output will be displayed. Working options include "console" and "file".
	TextFileName - When the OutputDestination is set to "file", this will be path and name of the output file.
	
Note: For development I ran the two projects (HelloWorld.API and ConsoleApp) simultaneously through VS IISExpress. If you prefer a more stable set up, publish the API locally and set up through IIS first. Then run the console.