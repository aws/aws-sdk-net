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
    /// Provides the configuration information of the URLs to crawl.
    /// 
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
    public partial class Urls
    {
        private SeedUrlConfiguration _seedUrlConfiguration;
        private SiteMapsConfiguration _siteMapsConfiguration;

        /// <summary>
        /// Gets and sets the property SeedUrlConfiguration. 
        /// <para>
        /// Configuration of the seed or starting point URLs of the websites you want to crawl.
        /// </para>
        ///  
        /// <para>
        /// You can choose to crawl only the website host names, or the website host names with
        /// subdomains, or the website host names with subdomains and other domains that the web
        /// pages link to.
        /// </para>
        ///  
        /// <para>
        /// You can list up to 100 seed URLs.
        /// </para>
        /// </summary>
        public SeedUrlConfiguration SeedUrlConfiguration
        {
            get { return this._seedUrlConfiguration; }
            set { this._seedUrlConfiguration = value; }
        }

        // Check to see if SeedUrlConfiguration property is set
        internal bool IsSetSeedUrlConfiguration()
        {
            return this._seedUrlConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property SiteMapsConfiguration. 
        /// <para>
        /// Configuration of the sitemap URLs of the websites you want to crawl.
        /// </para>
        ///  
        /// <para>
        /// Only URLs belonging to the same website host names are crawled. You can list up to
        /// three sitemap URLs.
        /// </para>
        /// </summary>
        public SiteMapsConfiguration SiteMapsConfiguration
        {
            get { return this._siteMapsConfiguration; }
            set { this._siteMapsConfiguration = value; }
        }

        // Check to see if SiteMapsConfiguration property is set
        internal bool IsSetSiteMapsConfiguration()
        {
            return this._siteMapsConfiguration != null;
        }

    }
}