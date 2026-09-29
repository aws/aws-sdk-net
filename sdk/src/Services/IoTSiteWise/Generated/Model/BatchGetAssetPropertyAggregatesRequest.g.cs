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

namespace Amazon.IoTSiteWise.Model
{
    /// <summary>
    /// Container for the parameters to the BatchGetAssetPropertyAggregates operation. Gets
    /// aggregated values (for example, average, minimum, and maximum) for one or more asset
    /// properties. For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/query-industrial-data.html#aggregates">Querying
    /// aggregates</a> in the <i>IoT SiteWise User Guide</i>.
    /// </summary>
    public partial class BatchGetAssetPropertyAggregatesRequest : AmazonIoTSiteWiseRequest
    {
        /// <summary>
        /// Gets and sets the property Entries. 
        /// <para>
        /// The list of asset property aggregate entries for the batch get request. You can specify
        /// up to 16 entries per request.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<BatchGetAssetPropertyAggregatesEntry> Entries { get; set; } = AWSConfigs.InitializeCollections ? new List<BatchGetAssetPropertyAggregatesEntry>() : null;

        /// <summary>
        /// Checks to see if the Entries property is set.
        /// </summary>
        internal bool IsSetEntries() => this.Entries != null && (this.Entries.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return for each paginated request. A result set is
        /// returned in the two cases, whichever occurs first.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The size of the result set is equal to 1 MB.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The number of data points in the result set is equal to the value of <c>maxResults</c>.
        /// The maximum value of <c>maxResults</c> is 4000.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min = 1)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token to be used for the next set of paginated results.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 4096)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;
    }
}
