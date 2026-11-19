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
    /// Describes a placement group.
    /// </summary>
    public partial class PlacementGroup
    {
        /// <summary>
        /// Empty constructor used to set properties independently even when a simple constructor is available
        /// </summary>
        public PlacementGroup() { }

        /// <summary>
        /// Instantiates PlacementGroup with the parameterized properties
        /// </summary>
        /// <param name="groupName">The name of the placement group.</param>
        public PlacementGroup(string groupName)
        {
            this.GroupName = groupName;
        }

        /// <summary>
        /// Gets and sets the property GroupArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the placement group.
        /// </para>
        /// </summary>
        public string GroupArn { get; set; }

        /// <summary>
        /// Checks to see if the GroupArn property is set.
        /// </summary>
        internal bool IsSetGroupArn() => this.GroupArn != null;

        /// <summary>
        /// Gets and sets the property GroupId. 
        /// <para>
        /// The ID of the placement group.
        /// </para>
        /// </summary>
        public string GroupId { get; set; }

        /// <summary>
        /// Checks to see if the GroupId property is set.
        /// </summary>
        internal bool IsSetGroupId() => this.GroupId != null;

        /// <summary>
        /// Gets and sets the property GroupName. 
        /// <para>
        /// The name of the placement group.
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
        /// The service provider that manages the Placement Group.
        /// </para>
        /// </summary>
        public OperatorResponse Operator { get; set; }

        /// <summary>
        /// Checks to see if the Operator property is set.
        /// </summary>
        internal bool IsSetOperator() => this.Operator != null;

        /// <summary>
        /// Gets and sets the property ParentGroupId. 
        /// <para>
        /// The ID of the parent placement group.
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
        /// The number of partitions. Valid only if <b>strategy</b> is set to <c>partition</c>.
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
        /// The spread level for the placement group. <i>Only</i> Outpost placement groups can
        /// be spread across hosts.
        /// </para>
        /// </summary>
        public SpreadLevel SpreadLevel { get; set; }

        /// <summary>
        /// Checks to see if the SpreadLevel property is set.
        /// </summary>
        internal bool IsSetSpreadLevel() => this.SpreadLevel != null;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The state of the placement group.
        /// </para>
        /// </summary>
        public PlacementGroupState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;

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
        /// Gets and sets the property Tags. 
        /// <para>
        /// Any tags applied to the placement group.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
