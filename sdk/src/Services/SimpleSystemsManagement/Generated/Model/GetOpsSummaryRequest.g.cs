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

namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// Container for the parameters to the GetOpsSummary operation. View a summary of operations
    /// metadata (OpsData) based on specified filters and aggregators. OpsData can include
    /// information about Amazon Web Services Systems Manager OpsCenter operational workitems
    /// (OpsItems) as well as information about any Amazon Web Services resource or service
    /// configured to report OpsData to Amazon Web Services Systems Manager Explorer.
    /// </summary>
    public partial class GetOpsSummaryRequest : AmazonSimpleSystemsManagementRequest
    {
        /// <summary>
        /// Gets and sets the property Aggregators. 
        /// <para>
        /// Optional aggregators that return counts of OpsData based on one or more expressions.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 12)]
        public List<OpsAggregator> Aggregators { get; set; } = AWSConfigs.InitializeCollections ? new List<OpsAggregator>() : null;

        /// <summary>
        /// Checks to see if the Aggregators property is set.
        /// </summary>
        internal bool IsSetAggregators() => this.Aggregators != null && (this.Aggregators.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// Optional filters used to scope down the returned OpsData. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 5)]
        public List<OpsFilter> Filters { get; set; } = AWSConfigs.InitializeCollections ? new List<OpsFilter>() : null;

        /// <summary>
        /// Checks to see if the Filters property is set.
        /// </summary>
        internal bool IsSetFilters() => this.Filters != null && (this.Filters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of items to return for this call. The call also returns a token
        /// that you can specify in a subsequent call to get the next set of results.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A token to start the list. Use this token to get the next set of results. 
        /// </para>
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property ResultAttributes. 
        /// <para>
        /// The OpsData data type to return.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1)]
        public List<OpsResultAttribute> ResultAttributes { get; set; } = AWSConfigs.InitializeCollections ? new List<OpsResultAttribute>() : null;

        /// <summary>
        /// Checks to see if the ResultAttributes property is set.
        /// </summary>
        internal bool IsSetResultAttributes() => this.ResultAttributes != null && (this.ResultAttributes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SyncName. 
        /// <para>
        /// Specify the name of a resource data sync to get.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string SyncName { get; set; }

        /// <summary>
        /// Checks to see if the SyncName property is set.
        /// </summary>
        internal bool IsSetSyncName() => this.SyncName != null;
    }
}
