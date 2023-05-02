/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the kendra-2019-02-03.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Kendra.Model
{
    /// <summary>
    /// Provides the configuration information required for Amazon Kendra Web Crawler.
    /// </summary>
    public partial class WebCrawlerConfiguration
    {
        private AuthenticationConfiguration _authenticationConfiguration;
        private int? _crawlDepth;
        private float? _maxContentSizePerPageInMegaBytes;
        private int? _maxLinksPerPage;
        private int? _maxUrlsPerMinuteCrawlRate;
        private ProxyConfiguration _proxyConfiguration;
        private List<string> _urlExclusionPatterns = new List<string>();
        private List<string> _urlInclusionPatterns = new List<string>();
        private Urls _urls;

        /// <summary>
        /// Gets and sets the property AuthenticationConfiguration. 
        /// <para>
        /// Configuration information required to connect to websites using authentication.
        /// </para>
        ///  
        /// <para>
        /// You can connect to websites using basic authentication of user name and password.
        /// You use a secret in <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/intro.html">Secrets
        /// Manager</a> to store your authentication credentials.
        /// </para>
        ///  
        /// <para>
        /// You must provide the website host name and port number. For example, the host name
        /// of https://a.example.com/page1.html is "a.example.com" and the port is 443, the standard
        /// port for HTTPS.
        /// </para>
        /// </summary>
        public AuthenticationConfiguration AuthenticationConfiguration
        {
            get { return this._authenticationConfiguration; }
            set { this._authenticationConfiguration = value; }
        }

        // Check to see if AuthenticationConfiguration property is set
        internal bool IsSetAuthenticationConfiguration()
        {
            return this._authenticationConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property CrawlDepth. 
        /// <para>
        /// Specifies the number of levels in a website that you want to crawl.
        /// </para>
        ///  
        /// <para>
        /// The first level begins from the website seed or starting point URL. For example, if
        /// a website has three levels—index level (the seed in this example), sections level,
        /// and subsections level—and you are only interested in crawling information up to the
        /// sections level (levels 0-1), you can set your depth to 1.
        /// </para>
        ///  
        /// <para>
        /// The default crawl depth is set to 2.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=10)]
        public int CrawlDepth
        {
            get { return this._crawlDepth.GetValueOrDefault(); }
            set { this._crawlDepth = value; }
        }

        // Check to see if CrawlDepth property is set
        internal bool IsSetCrawlDepth()
        {
            return this._crawlDepth.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxContentSizePerPageInMegaBytes. 
        /// <para>
        /// The maximum size (in MB) of a web page or attachment to crawl.
        /// </para>
        ///  
        /// <para>
        /// Files larger than this size (in MB) are skipped/not crawled.
        /// </para>
        ///  
        /// <para>
        /// The default maximum size of a web page or attachment is set to 50 MB.
        /// </para>
        /// </summary>
        [AWSProperty(Max=50)]
        public float MaxContentSizePerPageInMegaBytes
        {
            get { return this._maxContentSizePerPageInMegaBytes.GetValueOrDefault(); }
            set { this._maxContentSizePerPageInMegaBytes = value; }
        }

        // Check to see if MaxContentSizePerPageInMegaBytes property is set
        internal bool IsSetMaxContentSizePerPageInMegaBytes()
        {
            return this._maxContentSizePerPageInMegaBytes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxLinksPerPage. 
        /// <para>
        /// The maximum number of URLs on a web page to include when crawling a website. This
        /// number is per web page.
        /// </para>
        ///  
        /// <para>
        /// As a website’s web pages are crawled, any URLs the web pages link to are also crawled.
        /// URLs on a web page are crawled in order of appearance.
        /// </para>
        ///  
        /// <para>
        /// The default maximum links per page is 100.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
        public int MaxLinksPerPage
        {
            get { return this._maxLinksPerPage.GetValueOrDefault(); }
            set { this._maxLinksPerPage = value; }
        }

        // Check to see if MaxLinksPerPage property is set
        internal bool IsSetMaxLinksPerPage()
        {
            return this._maxLinksPerPage.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxUrlsPerMinuteCrawlRate. 
        /// <para>
        /// The maximum number of URLs crawled per website host per minute.
        /// </para>
        ///  
        /// <para>
        /// A minimum of one URL is required.
        /// </para>
        ///  
        /// <para>
        /// The default maximum number of URLs crawled per website host per minute is 300.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=300)]
        public int MaxUrlsPerMinuteCrawlRate
        {
            get { return this._maxUrlsPerMinuteCrawlRate.GetValueOrDefault(); }
            set { this._maxUrlsPerMinuteCrawlRate = value; }
        }

        // Check to see if MaxUrlsPerMinuteCrawlRate property is set
        internal bool IsSetMaxUrlsPerMinuteCrawlRate()
        {
            return this._maxUrlsPerMinuteCrawlRate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ProxyConfiguration. 
        /// <para>
        /// Configuration information required to connect to your internal websites via a web
        /// proxy.
        /// </para>
        ///  
        /// <para>
        /// You must provide the website host name and port number. For example, the host name
        /// of https://a.example.com/page1.html is "a.example.com" and the port is 443, the standard
        /// port for HTTPS.
        /// </para>
        ///  
        /// <para>
        /// Web proxy credentials are optional and you can use them to connect to a web proxy
        /// server that requires basic authentication. To store web proxy credentials, you use
        /// a secret in <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/intro.html">Secrets
        /// Manager</a>.
        /// </para>
        /// </summary>
        public ProxyConfiguration ProxyConfiguration
        {
            get { return this._proxyConfiguration; }
            set { this._proxyConfiguration = value; }
        }

        // Check to see if ProxyConfiguration property is set
        internal bool IsSetProxyConfiguration()
        {
            return this._proxyConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property UrlExclusionPatterns. 
        /// <para>
        /// A list of regular expression patterns to exclude certain URLs to crawl. URLs that
        /// match the patterns are excluded from the index. URLs that don't match the patterns
        /// are included in the index. If a URL matches both an inclusion and exclusion pattern,
        /// the exclusion pattern takes precedence and the URL file isn't included in the index.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public List<string> UrlExclusionPatterns
        {
            get { return this._urlExclusionPatterns; }
            set { this._urlExclusionPatterns = value; }
        }

        // Check to see if UrlExclusionPatterns property is set
        internal bool IsSetUrlExclusionPatterns()
        {
            return this._urlExclusionPatterns != null && this._urlExclusionPatterns.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property UrlInclusionPatterns. 
        /// <para>
        /// A list of regular expression patterns to include certain URLs to crawl. URLs that
        /// match the patterns are included in the index. URLs that don't match the patterns are
        /// excluded from the index. If a URL matches both an inclusion and exclusion pattern,
        /// the exclusion pattern takes precedence and the URL file isn't included in the index.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public List<string> UrlInclusionPatterns
        {
            get { return this._urlInclusionPatterns; }
            set { this._urlInclusionPatterns = value; }
        }

        // Check to see if UrlInclusionPatterns property is set
        internal bool IsSetUrlInclusionPatterns()
        {
            return this._urlInclusionPatterns != null && this._urlInclusionPatterns.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Urls. 
        /// <para>
        /// Specifies the seed or starting point URLs of the websites or the sitemap URLs of the
        /// websites you want to crawl.
        /// </para>
        ///  
        /// <para>
        /// You can include website subdomains. You can list up to 100 seed URLs and up to three
        /// sitemap URLs.
        /// </para>
        ///  
        /// <para>
        /// You can only crawl websites that use the secure communication protocol, Hypertext
        /// Transfer Protocol Secure (HTTPS). If you receive an error when crawling a website,
        /// it could be that the website is blocked from crawling.
        /// </para>
        ///  
        /// <para>
        ///  <i>When selecting websites to index, you must adhere to the <a href="https://aws.amazon.com/aup/">Amazon
        /// Acceptable Use Policy</a> and all other Amazon terms. Remember that you must only
        /// use Amazon Kendra Web Crawler to index your own web pages, or web pages that you have
        /// authorization to index.</i> 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Urls Urls
        {
            get { return this._urls; }
            set { this._urls = value; }
        }

        // Check to see if Urls property is set
        internal bool IsSetUrls()
        {
            return this._urls != null;
        }

    }
}