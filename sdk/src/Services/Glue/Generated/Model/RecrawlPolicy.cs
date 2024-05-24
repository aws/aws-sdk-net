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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.Glue.Model
{
    /// <summary>
    /// When crawling an Amazon S3 data source after the first crawl is complete, specifies
    /// whether to crawl the entire dataset again or to crawl only folders that were added
    /// since the last crawler run. For more information, see <a href="https://docs.aws.amazon.com/glue/latest/dg/incremental-crawls.html">Incremental
    /// Crawls in Glue</a> in the developer guide.
    /// </summary>
    public partial class RecrawlPolicy
    {
        private RecrawlBehavior _recrawlBehavior;

        /// <summary>
        /// Gets and sets the property RecrawlBehavior. 
        /// <para>
        /// Specifies whether to crawl the entire dataset again or to crawl only folders that
        /// were added since the last crawler run.
        /// </para>
        ///  
        /// <para>
        /// A value of <c>CRAWL_EVERYTHING</c> specifies crawling the entire dataset again.
        /// </para>
        ///  
        /// <para>
        /// A value of <c>CRAWL_NEW_FOLDERS_ONLY</c> specifies crawling only folders that were
        /// added since the last crawler run.
        /// </para>
        ///  
        /// <para>
        /// A value of <c>CRAWL_EVENT_MODE</c> specifies crawling only the changes identified
        /// by Amazon S3 events.
        /// </para>
        /// </summary>
        public RecrawlBehavior RecrawlBehavior
        {
            get { return this._recrawlBehavior; }
            set { this._recrawlBehavior = value; }
        }

        // Check to see if RecrawlBehavior property is set
        internal bool IsSetRecrawlBehavior()
        {
            return this._recrawlBehavior != null;
        }

    }
}