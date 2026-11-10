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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the CreatePlacementGroup operation. Creates a placement
    /// group in which to launch instances. The strategy of the placement group determines
    /// how the instances are organized within the group. <para> A <c>cluster</c> placement
    /// group is a logical grouping of instances within a single Availability Zone that benefit
    /// from low network latency, high network throughput. A <c>spread</c> placement group
    /// places instances on distinct hardware. A <c>partition</c> placement group places groups
    /// of instances in different partitions, where instances in one partition do not share
    /// the same hardware with instances in another partition. A <c>precision-time</c> placement
    /// group places instances on supported hardware with direct access to high-precision
    /// time sources in Amazon Web Services infrastructure. </para> <para> For more information,
    /// see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/placement-groups.html">Placement
    /// groups</a> in the <i>Amazon EC2 User Guide</i>. </para>
    /// </summary>
    public partial class CreatePlacementGroupRequest : AmazonEC2Request
    {
        /// <summary>
        /// Empty constructor used to set properties independently even when a simple constructor is available
        /// </summary>
        public CreatePlacementGroupRequest() { }

        /// <summary>
        /// Instantiates CreatePlacementGroupRequest with the parameterized properties
        /// </summary>
        /// <param name="groupName">A name for the placement group. Must be unique within the scope of your account for   the Region.   Constraints: Up to 255 ASCII characters</param>
        /// <param name="strategy">The placement strategy.</param>
        public CreatePlacementGroupRequest(string groupName, PlacementStrategy strategy)
        {
            this.GroupName = groupName;
            this.Strategy = strategy;
        }

        /// <summary>
        /// Gets and sets the property DryRun. 
        /// <para>
        /// Checks whether you have the required permissions for the operation, without actually
        /// making the request, and provides an error response. If you have the required permissions,
        /// the error response is <c>DryRunOperation</c>. Otherwise, it is <c>UnauthorizedOperation</c>.
        /// </para>
        /// </summary>
        public bool? DryRun { get; set; }

        /// <summary>
        /// Checks to see if the DryRun property is set.
        /// </summary>
        internal bool IsSetDryRun() => this.DryRun.HasValue;

        /// <summary>
        /// Gets and sets the property GroupName. 
        /// <para>
        /// A name for the placement group. Must be unique within the scope of your account for
        /// the Region.
        /// </para>
        ///  
        /// <para>
        /// Constraints: Up to 255 ASCII characters
        /// </para>
        /// </summary>
        public string GroupName { get; set; }

        /// <summary>
        /// Checks to see if the GroupName property is set.
        /// </summary>
        internal bool IsSetGroupName() => this.GroupName != null;

        /// <summary>
        /// Gets and sets the property LinkedGroupId. 
        /// <para>
        /// Reserved for future use.
        /// </para>
        /// </summary>
        public string LinkedGroupId { get; set; }

        /// <summary>
        /// Checks to see if the LinkedGroupId property is set.
        /// </summary>
        internal bool IsSetLinkedGroupId() => this.LinkedGroupId != null;

        /// <summary>
        /// Gets and sets the property Operator. 
        /// <para>
        /// Reserved for internal use.
        /// </para>
        /// </summary>
        public OperatorRequest Operator { get; set; }

        /// <summary>
        /// Checks to see if the Operator property is set.
        /// </summary>
        internal bool IsSetOperator() => this.Operator != null;

        /// <summary>
        /// Gets and sets the property ParentGroupId. 
        /// <para>
        /// The ID of a parent placement group. Valid only when <b>Strategy</b> is set to <c>cluster</c>.
        /// </para>
        /// </summary>
        public string ParentGroupId { get; set; }

        /// <summary>
        /// Checks to see if the ParentGroupId property is set.
        /// </summary>
        internal bool IsSetParentGroupId() => this.ParentGroupId != null;

        /// <summary>
        /// Gets and sets the property PartitionCount. 
        /// <para>
        /// The number of partitions. Valid only when <b>Strategy</b> is set to <c>partition</c>.
        /// </para>
        /// </summary>
        public int? PartitionCount { get; set; }

        /// <summary>
        /// Checks to see if the PartitionCount property is set.
        /// </summary>
        internal bool IsSetPartitionCount() => this.PartitionCount.HasValue;

        /// <summary>
        /// Gets and sets the property SpreadLevel. 
        /// <para>
        /// Determines how placement groups spread instances. 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Host – You can use <c>host</c> only with Outpost placement groups.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Rack – No usage restrictions.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public SpreadLevel SpreadLevel { get; set; }

        /// <summary>
        /// Checks to see if the SpreadLevel property is set.
        /// </summary>
        internal bool IsSetSpreadLevel() => this.SpreadLevel != null;

        /// <summary>
        /// Gets and sets the property Strategy. 
        /// <para>
        /// The placement strategy.
        /// </para>
        /// </summary>
        public PlacementStrategy Strategy { get; set; }

        /// <summary>
        /// Checks to see if the Strategy property is set.
        /// </summary>
        internal bool IsSetStrategy() => this.Strategy != null;

        /// <summary>
        /// Gets and sets the property TagSpecifications. 
        /// <para>
        /// The tags to apply to the new placement group.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<TagSpecification> TagSpecifications { get; set; } = AWSConfigs.InitializeCollections ? new List<TagSpecification>() : null;

        /// <summary>
        /// Checks to see if the TagSpecifications property is set.
        /// </summary>
        internal bool IsSetTagSpecifications() => this.TagSpecifications != null && (this.TagSpecifications.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
