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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570

namespace Amazon.BedrockAgent.Model
{
    /// <summary>
    /// The rate limits for the URLs that you want to crawl. You should be authorized to crawl
    /// the URLs.
    /// </summary>
    public partial class WebCrawlerLimits
    {
        /// <summary>
        /// Gets and sets the property MaxPages. 
        /// <para>
        ///  The max number of web pages crawled from your source URLs, up to 25,000 pages. If
        /// the web pages exceed this limit, the data source sync will fail and no web pages will
        /// be ingested. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public int? MaxPages { get; set; }

        /// <summary>
        /// Checks to see if the MaxPages property is set.
        /// </summary>
        internal bool IsSetMaxPages() => this.MaxPages.HasValue;

        /// <summary>
        /// Gets and sets the property RateLimit. 
        /// <para>
        /// The max rate at which pages are crawled, up to 300 per minute per host.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 300)]
        public int? RateLimit { get; set; }

        /// <summary>
        /// Checks to see if the RateLimit property is set.
        /// </summary>
        internal bool IsSetRateLimit() => this.RateLimit.HasValue;
    }
}
