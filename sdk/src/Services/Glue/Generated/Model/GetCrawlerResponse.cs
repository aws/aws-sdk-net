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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Glue.Model
{
    /// <summary>
    /// This is the response object from the GetCrawler operation.
    /// </summary>
    public partial class GetCrawlerResponse : AmazonWebServiceResponse
    {
        private Crawler _crawler;

        /// <summary>
        /// Gets and sets the property Crawler. 
        /// <para>
        /// The metadata for the specified crawler.
        /// </para>
        /// </summary>
        public Crawler Crawler
        {
            get { return this._crawler; }
            set { this._crawler = value; }
        }

        // Check to see if Crawler property is set
        internal bool IsSetCrawler()
        {
            return this._crawler != null;
        }

    }
}