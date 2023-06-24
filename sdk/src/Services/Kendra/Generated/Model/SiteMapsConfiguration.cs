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
    /// Provides the configuration information for the sitemap URLs to crawl.
    /// 
    ///  
    /// <para>
    ///  <i>When selecting websites to index, you must adhere to the <a href="https://aws.amazon.com/aup/">Amazon
    /// Acceptable Use Policy</a> and all other Amazon terms. Remember that you must only
    /// use Amazon Kendra Web Crawler to index your own web pages, or web pages that you have
    /// authorization to index.</i> 
    /// </para>
    /// </summary>
    public partial class SiteMapsConfiguration
    {
        private List<string> _siteMaps = new List<string>();

        /// <summary>
        /// Gets and sets the property SiteMaps. 
        /// <para>
        /// The list of sitemap URLs of the websites you want to crawl.
        /// </para>
        ///  
        /// <para>
        /// The list can include a maximum of three sitemap URLs.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=3)]
        public List<string> SiteMaps
        {
            get { return this._siteMaps; }
            set { this._siteMaps = value; }
        }

        // Check to see if SiteMaps property is set
        internal bool IsSetSiteMaps()
        {
            return this._siteMaps != null && this._siteMaps.Count > 0; 
        }

    }
}