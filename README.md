# C# WCF CORS endpoint (with JSON support)

This is the final code from my blog post [WCF CORS (plus JSON & REST) - Complete Example](http://www.productiverage.com/wcf-cors-plus-json-rest-complete-example)

To try it out, build the solution and then start the project "CORSExample" - this will start a WCF that listens on port 51192. You should be able to hit it in a browser by going to -

    http://localhost:50995/Service1.svc/GetData/123
    
That request will return the following JSON (though the "ReceivedAt" value will be different):

    {"ReceivedAt":"\/Date(1485862041862+0000)\/","Value":"You entered: 123"}
    
To confirm that the CORS headers are working, you need to try to make this request from a browser. To do so, right-click on the "Example.html" file in the "HtmlExample" project and click "View in Browser". This will attempt to make the same request and, if successful, will display the following text in the browser:

> Received response from http://localhost:51192/Service1.svc/GetData/123: "You entered: 123"
    
If it fails then there should be an error in the console.

To complete the proof that the CORS headers are working, remove the following line from the CORSExample project's web.config -

    <crossOriginResourceSharingBehavior />

Refreshing Example.html will now display:

> Request to http://localhost:51192/Service1.svc/GetData/123 failed: "error"
    
In the browser console, an error like this will be displayed (this text is was taken from Chrome, it may vary slightly from browser to browser) -

> XMLHttpRequest cannot load http://localhost:51192/Service1.svc/GetData/123. No 'Access-Control-Allow-Origin' header is present on the requested resource. Origin 'null' is therefore not allowed access.