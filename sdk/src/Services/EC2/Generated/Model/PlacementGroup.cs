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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Describes a placement group.
    /// </summary>
    public partial class PlacementGroup
    {
        private string _groupArn;
        private string _groupId;
        private string _groupName;
        private int? _partitionCount;
        private SpreadLevel _spreadLevel;
        private PlacementGroupState _state;
        private PlacementStrategy _strategy;
        private List<Tag> _tags = new List<Tag>();

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public PlacementGroup() { }

        /// <summary>
        /// Instantiates PlacementGroup with the parameterized properties
        /// </summary>
        /// <param name="groupName">The name of the placement group.</param>
        public PlacementGroup(string groupName)
        {
            _groupName = groupName;
        }

        /// <summary>
        /// Gets and sets the property GroupArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the placement group.
        /// </para>
        /// </summary>
        public string GroupArn
        {
            get { return this._groupArn; }
            set { this._groupArn = value; }
        }

        // Check to see if GroupArn property is set
        internal bool IsSetGroupArn()
        {
            return this._groupArn != null;
        }

        /// <summary>
        /// Gets and sets the property GroupId. 
        /// <para>
        /// The ID of the placement group.
        /// </para>
        /// </summary>
        public string GroupId
        {
            get { return this._groupId; }
            set { this._groupId = value; }
        }

        // Check to see if GroupId property is set
        internal bool IsSetGroupId()
        {
            return this._groupId != null;
        }

        /// <summary>
        /// Gets and sets the property GroupName. 
        /// <para>
        /// The name of the placement group.
        /// </para>
        /// </summary>
        public string GroupName
        {
            get { return this._groupName; }
            set { this._groupName = value; }
        }

        // Check to see if GroupName property is set
        internal bool IsSetGroupName()
        {
            return this._groupName != null;
        }

        /// <summary>
        /// Gets and sets the property PartitionCount. 
        /// <para>
        /// The number of partitions. Valid only if <b>strategy</b> is set to <code>partition</code>.
        /// </para>
        /// </summary>
        public int PartitionCount
        {
            get { return this._partitionCount.GetValueOrDefault(); }
            set { this._partitionCount = value; }
        }

        // Check to see if PartitionCount property is set
        internal bool IsSetPartitionCount()
        {
            return this._partitionCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SpreadLevel. 
        /// <para>
        /// The spread level for the placement group. <i>Only</i> Outpost placement groups can
        /// be spread across hosts.
        /// </para>
        /// </summary>
        public SpreadLevel SpreadLevel
        {
            get { return this._spreadLevel; }
            set { this._spreadLevel = value; }
        }

        // Check to see if SpreadLevel property is set
        internal bool IsSetSpreadLevel()
        {
            return this._spreadLevel != null;
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The state of the placement group.
        /// </para>
        /// </summary>
        public PlacementGroupState State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

        /// <summary>
        /// Gets and sets the property Strategy. 
        /// <para>
        /// The placement strategy.
        /// </para>
        /// </summary>
        public PlacementStrategy Strategy
        {
            get { return this._strategy; }
            set { this._strategy = value; }
        }

        // Check to see if Strategy property is set
        internal bool IsSetStrategy()
        {
            return this._strategy != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Any tags applied to the placement group.
        /// </para>
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}