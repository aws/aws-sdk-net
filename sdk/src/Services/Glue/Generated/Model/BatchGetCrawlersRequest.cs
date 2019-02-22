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
    /// Container for the parameters to the BatchGetCrawlers operation.
    /// Returns a list of resource metadata for a given list of crawler names. After calling
    /// the <code>ListCrawlers</code> operation, you can call this operation to access the
    /// data to which you have been granted permissions to based on tags.
    /// </summary>
    public partial class BatchGetCrawlersRequest : AmazonGlueRequest
    {
        private List<string> _crawlerNames = new List<string>();

        /// <summary>
        /// Gets and sets the property CrawlerNames. 
        /// <para>
        /// A list of crawler names, which may be the names returned from the <code>ListCrawlers</code>
        /// operation.
        /// </para>
        /// </summary>
        public List<string> CrawlerNames
        {
            get { return this._crawlerNames; }
            set { this._crawlerNames = value; }
        }

        // Check to see if CrawlerNames property is set
        internal bool IsSetCrawlerNames()
        {
            return this._crawlerNames != null && this._crawlerNames.Count > 0; 
        }

    }
}