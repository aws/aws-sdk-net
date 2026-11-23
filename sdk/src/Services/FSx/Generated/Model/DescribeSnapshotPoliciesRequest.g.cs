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

namespace Amazon.FSx.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeSnapshotPolicies operation. Returns the
    /// description of specific Amazon FSx for NetApp ONTAP snapshot policies, if a <c>SnapshotPolicyIds</c>
    /// value is provided. Otherwise, this operation returns all snapshot policies owned by
    /// your Amazon Web Services account in the Amazon Web Services Region of the endpoint
    /// that you're calling. <para> When retrieving all snapshot policies, you can optionally
    /// specify the <c>MaxResults</c> parameter to limit the number of snapshot policies in
    /// a response. If more snapshot policies remain, Amazon FSx returns a <c>NextToken</c>
    /// value in the response. In this case, send a later request with the <c>NextToken</c>
    /// request parameter set to the value of <c>NextToken</c> from the last response. </para>
    /// </summary>
    public partial class DescribeSnapshotPoliciesRequest : AmazonFSxRequest
    {
        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// The filters structure. The supported names are <c>file-system-id</c> or <c>storage-virtual-machine-id</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 1)]
        public List<SnapshotPolicyFilter> Filters { get; set; } = AWSConfigs.InitializeCollections ? new List<SnapshotPolicyFilter>() : null;

        /// <summary>
        /// Checks to see if the Filters property is set.
        /// </summary>
        internal bool IsSetFilters() => this.Filters != null && (this.Filters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property MaxResults.
        /// </summary>
        [AWSProperty(Min = 1, Max = 2147483647)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken.
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property SnapshotPolicyIds. 
        /// <para>
        /// The IDs of the snapshot policies that you want to retrieve. If you also specify <c>Filters</c>,
        /// only snapshot policies that match both the IDs and the filters are returned. If any
        /// IDs aren't found, or if a filter excludes any of them, a <c>SnapshotPolicyNotFound</c>
        /// error occurs.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public List<string> SnapshotPolicyIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the SnapshotPolicyIds property is set.
        /// </summary>
        internal bool IsSetSnapshotPolicyIds() => this.SnapshotPolicyIds != null && (this.SnapshotPolicyIds.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
