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
    /// Provides the configuration information for the seed or starting point URLs to crawl.
    /// 
    ///  
    /// <para>
    ///  <i>When selecting websites to index, you must adhere to the <a href="https://aws.amazon.com/aup/">Amazon
    /// Acceptable Use Policy</a> and all other Amazon terms. Remember that you must only
    /// use Amazon Kendra Web Crawler to index your own web pages, or web pages that you have
    /// authorization to index.</i> 
    /// </para>
    /// </summary>
    public partial class SeedUrlConfiguration
    {
        private List<string> _seedUrls = new List<string>();
        private WebCrawlerMode _webCrawlerMode;

        /// <summary>
        /// Gets and sets the property SeedUrls. 
        /// <para>
        /// The list of seed or starting point URLs of the websites you want to crawl.
        /// </para>
        ///  
        /// <para>
        /// The list can include a maximum of 100 seed URLs.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=100)]
        public List<string> SeedUrls
        {
            get { return this._seedUrls; }
            set { this._seedUrls = value; }
        }

        // Check to see if SeedUrls property is set
        internal bool IsSetSeedUrls()
        {
            return this._seedUrls != null && this._seedUrls.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property WebCrawlerMode. 
        /// <para>
        /// You can choose one of the following modes:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>HOST_ONLY</code> – crawl only the website host names. For example, if the seed
        /// URL is "abc.example.com", then only URLs with host name "abc.example.com" are crawled.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>SUBDOMAINS</code> – crawl the website host names with subdomains. For example,
        /// if the seed URL is "abc.example.com", then "a.abc.example.com" and "b.abc.example.com"
        /// are also crawled.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>EVERYTHING</code> – crawl the website host names with subdomains and other
        /// domains that the web pages link to.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The default mode is set to <code>HOST_ONLY</code>.
        /// </para>
        /// </summary>
        public WebCrawlerMode WebCrawlerMode
        {
            get { return this._webCrawlerMode; }
            set { this._webCrawlerMode = value; }
        }

        // Check to see if WebCrawlerMode property is set
        internal bool IsSetWebCrawlerMode()
        {
            return this._webCrawlerMode != null;
        }

    }
}