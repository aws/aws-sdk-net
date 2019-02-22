/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Glue.Model
{
    /// <summary>
    /// This is the response object from the BatchGetCrawlers operation.
    /// </summary>
    public partial class BatchGetCrawlersResponse : AmazonWebServiceResponse
    {
        private List<Crawler> _crawlers = new List<Crawler>();
        private List<string> _crawlersNotFound = new List<string>();

        /// <summary>
        /// Gets and sets the property Crawlers. 
        /// <para>
        /// A list of crawler definitions.
        /// </para>
        /// </summary>
        public List<Crawler> Crawlers
        {
            get { return this._crawlers; }
            set { this._crawlers = value; }
        }

        // Check to see if Crawlers property is set
        internal bool IsSetCrawlers()
        {
            return this._crawlers != null && this._crawlers.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property CrawlersNotFound. 
        /// <para>
        /// A list of crawlers not found.
        /// </para>
        /// </summary>
        public List<string> CrawlersNotFound
        {
            get { return this._crawlersNotFound; }
            set { this._crawlersNotFound = value; }
        }

        // Check to see if CrawlersNotFound property is set
        internal bool IsSetCrawlersNotFound()
        {
            return this._crawlersNotFound != null && this._crawlersNotFound.Count > 0; 
        }

    }
}