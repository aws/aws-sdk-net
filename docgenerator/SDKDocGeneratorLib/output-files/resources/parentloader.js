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
        //reload the parent frame and cause it to reload this page in the frame.
        //Read the tocid from the meta tag and build the frameset URL.
        var tocid = jQuery("meta[name='aws-tocid']").attr('content');
        var pathname = window.location.pathname;
        var itemsIndex = pathname.indexOf('/items/');

        if (tocid && itemsIndex !== -1) {
            //Build the frameset URL from the current path
            var basePath = pathname.substring(0, itemsIndex);
            var filename = pathname.substring(pathname.lastIndexOf('/') + 1);
            //Reload the parent frameset and this content page. The inFrame part of this script
            //will run on reload to replace the address bar URL with the actual friendly content
            //frame page URL.
            window.location.href = basePath + '/index.html?page=' + filename + '&tocid=' + tocid;
        }
    }    
})();