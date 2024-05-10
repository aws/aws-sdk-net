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
 * Do not modify this file. This file is generated from the elasticmapreduce-2009-03-31.normal.json service model.
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
namespace Amazon.ElasticMapReduce.Model
{
    /// <summary>
    /// Detailed information about an instance group.
    /// </summary>
    public partial class InstanceGroupDetail
    {
        private string _bidPrice;
        private DateTime? _creationDateTime;
        private string _customAmiId;
        private DateTime? _endDateTime;
        private string _instanceGroupId;
        private int? _instanceRequestCount;
        private InstanceRoleType _instanceRole;
        private int? _instanceRunningCount;
        private string _instanceType;
        private string _lastStateChangeReason;
        private MarketType _market;
        private string _name;
        private DateTime? _readyDateTime;
        private DateTime? _startDateTime;
        private InstanceGroupState _state;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public InstanceGroupDetail() { }

        /// <summary>
        /// Instantiates InstanceGroupDetail with the parameterized properties
        /// </summary>
        /// <param name="instanceRole">Instance group role in the cluster</param>
        /// <param name="instanceType">Amazon EC2 instance type.</param>
        /// <param name="instanceRequestCount">Target number of instances to run in the instance group.</param>
        /// <param name="instanceRunningCount">Actual count of running instances.</param>
        /// <param name="state">State of instance group. The following values are no longer supported: STARTING, TERMINATED, and FAILED.</param>
        /// <param name="creationDateTime">The date/time the instance group was created.</param>
        public InstanceGroupDetail(InstanceRoleType instanceRole, string instanceType, int? instanceRequestCount, int? instanceRunningCount, InstanceGroupState state, DateTime? creationDateTime)
        {
            _instanceRole = instanceRole;
            _instanceType = instanceType;
            _instanceRequestCount = instanceRequestCount;
            _instanceRunningCount = instanceRunningCount;
            _state = state;
            _creationDateTime = creationDateTime;
        }

        /// <summary>
        /// Gets and sets the property BidPrice. 
        /// <para>
        /// If specified, indicates that the instance group uses Spot Instances. This is the maximum
        /// price you are willing to pay for Spot Instances. Specify <c>OnDemandPrice</c> to set
        /// the amount equal to the On-Demand price, or specify an amount in USD.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
        public string BidPrice
        {
            get { return this._bidPrice; }
            set { this._bidPrice = value; }
        }

        // Check to see if BidPrice property is set
        internal bool IsSetBidPrice()
        {
            return this._bidPrice != null;
        }

        /// <summary>
        /// Gets and sets the property CreationDateTime. 
        /// <para>
        /// The date/time the instance group was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? CreationDateTime
        {
            get { return this._creationDateTime; }
            set { this._creationDateTime = value; }
        }

        // Check to see if CreationDateTime property is set
        internal bool IsSetCreationDateTime()
        {
            return this._creationDateTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CustomAmiId. 
        /// <para>
        /// The custom AMI ID to use for the provisioned instance group.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
        public string CustomAmiId
        {
            get { return this._customAmiId; }
            set { this._customAmiId = value; }
        }

        // Check to see if CustomAmiId property is set
        internal bool IsSetCustomAmiId()
        {
            return this._customAmiId != null;
        }

        /// <summary>
        /// Gets and sets the property EndDateTime. 
        /// <para>
        /// The date/time the instance group was terminated.
        /// </para>
        /// </summary>
        public DateTime? EndDateTime
        {
            get { return this._endDateTime; }
            set { this._endDateTime = value; }
        }

        // Check to see if EndDateTime property is set
        internal bool IsSetEndDateTime()
        {
            return this._endDateTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InstanceGroupId. 
        /// <para>
        /// Unique identifier for the instance group.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
        public string InstanceGroupId
        {
            get { return this._instanceGroupId; }
            set { this._instanceGroupId = value; }
        }

        // Check to see if InstanceGroupId property is set
        internal bool IsSetInstanceGroupId()
        {
            return this._instanceGroupId != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceRequestCount. 
        /// <para>
        /// Target number of instances to run in the instance group.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? InstanceRequestCount
        {
            get { return this._instanceRequestCount; }
            set { this._instanceRequestCount = value; }
        }

        // Check to see if InstanceRequestCount property is set
        internal bool IsSetInstanceRequestCount()
        {
            return this._instanceRequestCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InstanceRole. 
        /// <para>
        /// Instance group role in the cluster
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public InstanceRoleType InstanceRole
        {
            get { return this._instanceRole; }
            set { this._instanceRole = value; }
        }

        // Check to see if InstanceRole property is set
        internal bool IsSetInstanceRole()
        {
            return this._instanceRole != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceRunningCount. 
        /// <para>
        /// Actual count of running instances.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? InstanceRunningCount
        {
            get { return this._instanceRunningCount; }
            set { this._instanceRunningCount = value; }
        }

        // Check to see if InstanceRunningCount property is set
        internal bool IsSetInstanceRunningCount()
        {
            return this._instanceRunningCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InstanceType. 
        /// <para>
        /// Amazon EC2 instance type.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string InstanceType
        {
            get { return this._instanceType; }
            set { this._instanceType = value; }
        }

        // Check to see if InstanceType property is set
        internal bool IsSetInstanceType()
        {
            return this._instanceType != null;
        }

        /// <summary>
        /// Gets and sets the property LastStateChangeReason. 
        /// <para>
        /// Details regarding the state of the instance group.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=10280)]
        public string LastStateChangeReason
        {
            get { return this._lastStateChangeReason; }
            set { this._lastStateChangeReason = value; }
        }

        // Check to see if LastStateChangeReason property is set
        internal bool IsSetLastStateChangeReason()
        {
            return this._lastStateChangeReason != null;
        }

        /// <summary>
        /// Gets and sets the property Market. 
        /// <para>
        /// Market type of the Amazon EC2 instances used to create a cluster node.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public MarketType Market
        {
            get { return this._market; }
            set { this._market = value; }
        }

        // Check to see if Market property is set
        internal bool IsSetMarket()
        {
            return this._market != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// Friendly name for the instance group.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property ReadyDateTime. 
        /// <para>
        /// The date/time the instance group was available to the cluster.
        /// </para>
        /// </summary>
        public DateTime? ReadyDateTime
        {
            get { return this._readyDateTime; }
            set { this._readyDateTime = value; }
        }

        // Check to see if ReadyDateTime property is set
        internal bool IsSetReadyDateTime()
        {
            return this._readyDateTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StartDateTime. 
        /// <para>
        /// The date/time the instance group was started.
        /// </para>
        /// </summary>
        public DateTime? StartDateTime
        {
            get { return this._startDateTime; }
            set { this._startDateTime = value; }
        }

        // Check to see if StartDateTime property is set
        internal bool IsSetStartDateTime()
        {
            return this._startDateTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// State of instance group. The following values are no longer supported: STARTING, TERMINATED,
        /// and FAILED.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public InstanceGroupState State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

    }
}