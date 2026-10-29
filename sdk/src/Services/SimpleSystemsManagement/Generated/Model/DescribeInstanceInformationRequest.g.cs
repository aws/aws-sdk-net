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
    /// Container for the parameters to the DescribeInstanceInformation operation. Provides
    /// information about one or more of your managed nodes, including the operating system
    /// platform, SSM Agent version, association status, and IP address. This operation does
    /// not return information for nodes that are either Stopped or Terminated. <para> If
    /// you specify one or more node IDs, the operation returns information for those managed
    /// nodes. If you don't specify node IDs, it returns information for all your managed
    /// nodes. If you specify a node ID that isn't valid or a node that you don't own, you
    /// receive an error. </para> <note> <para> The <c>IamRole</c> field returned for this
    /// API operation is the role assigned to an Amazon EC2 instance configured with a Systems
    /// Manager Quick Setup host management configuration or the role assigned to an on-premises
    /// managed node. </para> </note>
    /// </summary>
    public partial class DescribeInstanceInformationRequest : AmazonSimpleSystemsManagementRequest
    {
        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// One or more filters. Use a filter to return a more specific list of managed nodes.
        /// You can filter based on tags applied to your managed nodes. Tag filters can't be combined
        /// with other filter types. Use this <c>Filters</c> data type instead of <c>InstanceInformationFilterList</c>,
        /// which is deprecated.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0)]
        public List<InstanceInformationStringFilter> Filters { get; set; } = AWSConfigs.InitializeCollections ? new List<InstanceInformationStringFilter>() : null;

        /// <summary>
        /// Checks to see if the Filters property is set.
        /// </summary>
        internal bool IsSetFilters() => this.Filters != null && (this.Filters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property InstanceInformationFilterList. 
        /// <para>
        /// This is a legacy method. We recommend that you don't use this method. Instead, use
        /// the <c>Filters</c> data type. <c>Filters</c> enables you to return node information
        /// by filtering based on tags applied to managed nodes.
        /// </para>
        ///  <note> 
        /// <para>
        /// Attempting to use <c>InstanceInformationFilterList</c> and <c>Filters</c> leads to
        /// an exception error. 
        /// </para>
        ///  </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0)]
        public List<InstanceInformationFilter> InstanceInformationFilterList { get; set; } = AWSConfigs.InitializeCollections ? new List<InstanceInformationFilter>() : null;

        /// <summary>
        /// Checks to see if the InstanceInformationFilterList property is set.
        /// </summary>
        internal bool IsSetInstanceInformationFilterList() => this.InstanceInformationFilterList != null && (this.InstanceInformationFilterList.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of items to return for this call. The call also returns a token
        /// that you can specify in a subsequent call to get the next set of results. The default
        /// value is 10 items. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 5, Max = 50)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token for the next set of items to return. (You received this token from a previous
        /// call.)
        /// </para>
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;
    }
}
