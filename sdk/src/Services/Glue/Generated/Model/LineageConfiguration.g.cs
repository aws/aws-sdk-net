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

namespace Amazon.Glue.Model
{
    /// <summary>
    /// Specifies data lineage configuration settings for the crawler.
    /// </summary>
    public partial class LineageConfiguration
    {
        /// <summary>
        /// Gets and sets the property CrawlerLineageSettings. 
        /// <para>
        /// Specifies whether data lineage is enabled for the crawler. Valid values are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// ENABLE: enables data lineage for the crawler
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// DISABLE: disables data lineage for the crawler
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public CrawlerLineageSettings CrawlerLineageSettings { get; set; }

        /// <summary>
        /// Checks to see if the CrawlerLineageSettings property is set.
        /// </summary>
        internal bool IsSetCrawlerLineageSettings() => this.CrawlerLineageSettings != null;
    }
}
