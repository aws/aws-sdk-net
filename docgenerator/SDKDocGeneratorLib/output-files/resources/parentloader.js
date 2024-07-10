(function () {
    //inFrame = true is the normal state of the documents website. This is where there is the parent
    //frameset containing the TOC frame and the content frame. When inFrame = false the content page
    //has been loaded directly and the parent frameset and navigation TOC are not loaded. In this case
    //the parent frameset and TOC need to be loaded. The content frame pages are the only pages that 
    //run this script.

    var inFrame = false;
    try {
        inFrame = window.self !== window.top;
    }
    catch (e) {
        inFrame = true;
    }

    if (inFrame) {
        //The parent frameset and TOC exists should exist this content page is in a frame. Verify the
        //replaceState method is supported and that we for sure have a parent window.
        if (window.history.replaceState && parent.window) {
            //Replace the parent frame's URL without reloading so it isn't sitting on the static
            //index.html page. This allows users to bookmark the current page and where supported
            //using the current page's title. Do not include any query string in the main page URL
            //if one exists.
            var qsIndex = window.location.href.indexOf('?');
            if (qsIndex != -1) {
                parent.window.history.replaceState(null, jQuery('title').text(), window.location.href.substring(0, qsIndex));
            }
            else {
                parent.window.history.replaceState(null, jQuery('title').text(), window.location.href);
            }                        
        }        
    }
    else {
        //This content page is not in the expected frameset which contains the TOC so  
        //reload the parent frame and cause it to reload this page in the frame. The
        //canonical link element contains the link to reload the entire parent frameset
        //and load this current content page.
        var pageLink = jQuery("link[rel='canonical']").attr('href');
        if (pageLink !== '') {
            //Canonical links look like this: http://docs.aws.amazon.com/sdkfornet/v4/apidocs/index.html?page=PAGE.html&tocid=TOCID
            //Attempt to find where the relative path starts after the hostname.
            var seekFrom = 0;
            var protocolEndIndex = pageLink.indexOf('://');
            if (protocolEndIndex != -1) {
                seekFrom = protocolEndIndex + 3;
            }            

            //Look for the start of the relative path.
            var relPathIndex = pageLink.indexOf('/', seekFrom);
            if (relPathIndex != -1) {            
                //Reload the parent frameset and this content page. Note the address bar URL will
                //look like the canonical link in the address bar. The inFrame part of this script 
                //will run on release to replace the address bar URL with the actual friendly content
                //frame page URL.
                window.location.href = pageLink.substring(relPathIndex);
            }
            //Else do nothing because the link doesn't appear to be in a normal URL format where the 
            //hostname ends with a / starting the relative URL path.
        }
    }    
})();