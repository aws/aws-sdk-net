/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ElasticMapReduce.Model
{
    /// <summary>
    /// Detailed information about an instance group.
    /// </summary>
    public partial class InstanceGroupDetail
    {
        private string _bidPrice;
        private DateTime? _creationDateTime;
        private DateTime? _endDateTime;
        private string _instanceGroupId;
        private int? _instanceRequestCount;
        private string _instanceRole;
        private int? _instanceRunningCount;
        private string _instanceType;
        private string _lastStateChangeReason;
        private string _market;
        private string _name;
        private DateTime? _readyDateTime;
        private DateTime? _startDateTime;
        private string _state;


        /// <summary>
        /// Gets and sets the property BidPrice. 
        /// <para>
        /// Bid price for EC2 Instances when launching nodes as         Spot Instances, expressed
        /// in USD.
        /// </para>
        /// </summary>
        public string BidPrice
        {
            get { return this._bidPrice; }
            set { this._bidPrice = value; }
        }


        /// <summary>
        /// Sets the BidPrice property
        /// </summary>
        /// <param name="bidPrice">The value to set for the BidPrice property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public InstanceGroupDetail WithBidPrice(string bidPrice)
        {
            this._bidPrice = bidPrice;
            return this;
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
        public DateTime CreationDateTime
        {
            get { return this._creationDateTime.GetValueOrDefault(); }
            set { this._creationDateTime = value; }
        }


        /// <summary>
        /// Sets the CreationDateTime property
        /// </summary>
        /// <param name="creationDateTime">The value to set for the CreationDateTime property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public InstanceGroupDetail WithCreationDateTime(DateTime creationDateTime)
        {
            this._creationDateTime = creationDateTime;
            return this;
        }

        // Check to see if CreationDateTime property is set
        internal bool IsSetCreationDateTime()
        {
            return this._creationDateTime.HasValue; 
        }


        /// <summary>
        /// Gets and sets the property EndDateTime. 
        /// <para>
        /// The date/time the instance group was terminated.
        /// </para>
        /// </summary>
        public DateTime EndDateTime
        {
            get { return this._endDateTime.GetValueOrDefault(); }
            set { this._endDateTime = value; }
        }


        /// <summary>
        /// Sets the EndDateTime property
        /// </summary>
        /// <param name="endDateTime">The value to set for the EndDateTime property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public InstanceGroupDetail WithEndDateTime(DateTime endDateTime)
        {
            this._endDateTime = endDateTime;
            return this;
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
        public string InstanceGroupId
        {
            get { return this._instanceGroupId; }
            set { this._instanceGroupId = value; }
        }


        /// <summary>
        /// Sets the InstanceGroupId property
        /// </summary>
        /// <param name="instanceGroupId">The value to set for the InstanceGroupId property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public InstanceGroupDetail WithInstanceGroupId(string instanceGroupId)
        {
            this._instanceGroupId = instanceGroupId;
            return this;
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
        public int InstanceRequestCount
        {
            get { return this._instanceRequestCount.GetValueOrDefault(); }
            set { this._instanceRequestCount = value; }
        }


        /// <summary>
        /// Sets the InstanceRequestCount property
        /// </summary>
        /// <param name="instanceRequestCount">The value to set for the InstanceRequestCount property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public InstanceGroupDetail WithInstanceRequestCount(int instanceRequestCount)
        {
            this._instanceRequestCount = instanceRequestCount;
            return this;
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
        public string InstanceRole
        {
            get { return this._instanceRole; }
            set { this._instanceRole = value; }
        }


        /// <summary>
        /// Sets the InstanceRole property
        /// </summary>
        /// <param name="instanceRole">The value to set for the InstanceRole property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public InstanceGroupDetail WithInstanceRole(string instanceRole)
        {
            this._instanceRole = instanceRole;
            return this;
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
        public int InstanceRunningCount
        {
            get { return this._instanceRunningCount.GetValueOrDefault(); }
            set { this._instanceRunningCount = value; }
        }


        /// <summary>
        /// Sets the InstanceRunningCount property
        /// </summary>
        /// <param name="instanceRunningCount">The value to set for the InstanceRunningCount property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public InstanceGroupDetail WithInstanceRunningCount(int instanceRunningCount)
        {
            this._instanceRunningCount = instanceRunningCount;
            return this;
        }

        // Check to see if InstanceRunningCount property is set
        internal bool IsSetInstanceRunningCount()
        {
            return this._instanceRunningCount.HasValue; 
        }


        /// <summary>
        /// Gets and sets the property InstanceType. 
        /// <para>
        /// Amazon EC2 Instance type.
        /// </para>
        /// </summary>
        public string InstanceType
        {
            get { return this._instanceType; }
            set { this._instanceType = value; }
        }


        /// <summary>
        /// Sets the InstanceType property
        /// </summary>
        /// <param name="instanceType">The value to set for the InstanceType property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public InstanceGroupDetail WithInstanceType(string instanceType)
        {
            this._instanceType = instanceType;
            return this;
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
        public string LastStateChangeReason
        {
            get { return this._lastStateChangeReason; }
            set { this._lastStateChangeReason = value; }
        }


        /// <summary>
        /// Sets the LastStateChangeReason property
        /// </summary>
        /// <param name="lastStateChangeReason">The value to set for the LastStateChangeReason property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public InstanceGroupDetail WithLastStateChangeReason(string lastStateChangeReason)
        {
            this._lastStateChangeReason = lastStateChangeReason;
            return this;
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
        public string Market
        {
            get { return this._market; }
            set { this._market = value; }
        }


        /// <summary>
        /// Sets the Market property
        /// </summary>
        /// <param name="market">The value to set for the Market property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public InstanceGroupDetail WithMarket(string market)
        {
            this._market = market;
            return this;
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
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }


        /// <summary>
        /// Sets the Name property
        /// </summary>
        /// <param name="name">The value to set for the Name property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public InstanceGroupDetail WithName(string name)
        {
            this._name = name;
            return this;
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
        public DateTime ReadyDateTime
        {
            get { return this._readyDateTime.GetValueOrDefault(); }
            set { this._readyDateTime = value; }
        }


        /// <summary>
        /// Sets the ReadyDateTime property
        /// </summary>
        /// <param name="readyDateTime">The value to set for the ReadyDateTime property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public InstanceGroupDetail WithReadyDateTime(DateTime readyDateTime)
        {
            this._readyDateTime = readyDateTime;
            return this;
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
        public DateTime StartDateTime
        {
            get { return this._startDateTime.GetValueOrDefault(); }
            set { this._startDateTime = value; }
        }


        /// <summary>
        /// Sets the StartDateTime property
        /// </summary>
        /// <param name="startDateTime">The value to set for the StartDateTime property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public InstanceGroupDetail WithStartDateTime(DateTime startDateTime)
        {
            this._startDateTime = startDateTime;
            return this;
        }

        // Check to see if StartDateTime property is set
        internal bool IsSetStartDateTime()
        {
            return this._startDateTime.HasValue; 
        }


        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// State of instance group. The following values are deprecated: STARTING, TERMINATED,
        /// and FAILED.
        /// </para>
        /// </summary>
        public string State
        {
            get { return this._state; }
            set { this._state = value; }
        }


        /// <summary>
        /// Sets the State property
        /// </summary>
        /// <param name="state">The value to set for the State property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public InstanceGroupDetail WithState(string state)
        {
            this._state = state;
            return this;
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

    }
}