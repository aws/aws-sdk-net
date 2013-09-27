/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

namespace Amazon.ElasticMapReduce.Model
{
    /// <summary>
    /// <para>Detailed information about an instance group. </para>
    /// </summary>
    public class InstanceGroupDetail
    {
        
        private string instanceGroupId;
        private string name;
        private string market;
        private string instanceRole;
        private string bidPrice;
        private string instanceType;
        private int? instanceRequestCount;
        private int? instanceRunningCount;
        private string state;
        private string lastStateChangeReason;
        private DateTime? creationDateTime;
        private DateTime? startDateTime;
        private DateTime? readyDateTime;
        private DateTime? endDateTime;

        /// <summary>
        /// Unique identifier for the instance group.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>0 - 256</description>
        ///     </item>
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>[\u0020-\uD7FF\uE000-\uFFFD\uD800\uDC00-\uDBFF\uDFFF\r\n\t]*</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string InstanceGroupId
        {
            get { return this.instanceGroupId; }
            set { this.instanceGroupId = value; }
        }

        /// <summary>
        /// Sets the InstanceGroupId property
        /// </summary>
        /// <param name="instanceGroupId">The value to set for the InstanceGroupId property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public InstanceGroupDetail WithInstanceGroupId(string instanceGroupId)
        {
            this.instanceGroupId = instanceGroupId;
            return this;
        }
            

        // Check to see if InstanceGroupId property is set
        internal bool IsSetInstanceGroupId()
        {
            return this.instanceGroupId != null;
        }

        /// <summary>
        /// Friendly name for the instance group.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>0 - 256</description>
        ///     </item>
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>[\u0020-\uD7FF\uE000-\uFFFD\uD800\uDC00-\uDBFF\uDFFF\r\n\t]*</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        /// <summary>
        /// Sets the Name property
        /// </summary>
        /// <param name="name">The value to set for the Name property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public InstanceGroupDetail WithName(string name)
        {
            this.name = name;
            return this;
        }
            

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this.name != null;
        }

        /// <summary>
        /// Market type of the Amazon EC2 instances used to create a cluster node.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>ON_DEMAND, SPOT</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string Market
        {
            get { return this.market; }
            set { this.market = value; }
        }

        /// <summary>
        /// Sets the Market property
        /// </summary>
        /// <param name="market">The value to set for the Market property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public InstanceGroupDetail WithMarket(string market)
        {
            this.market = market;
            return this;
        }
            

        // Check to see if Market property is set
        internal bool IsSetMarket()
        {
            return this.market != null;
        }

        /// <summary>
        /// Instance group role in the cluster
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>MASTER, CORE, TASK</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string InstanceRole
        {
            get { return this.instanceRole; }
            set { this.instanceRole = value; }
        }

        /// <summary>
        /// Sets the InstanceRole property
        /// </summary>
        /// <param name="instanceRole">The value to set for the InstanceRole property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public InstanceGroupDetail WithInstanceRole(string instanceRole)
        {
            this.instanceRole = instanceRole;
            return this;
        }
            

        // Check to see if InstanceRole property is set
        internal bool IsSetInstanceRole()
        {
            return this.instanceRole != null;
        }

        /// <summary>
        /// Bid price for EC2 Instances when launching nodes as Spot Instances, expressed in USD.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>0 - 256</description>
        ///     </item>
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>[\u0020-\uD7FF\uE000-\uFFFD\uD800\uDC00-\uDBFF\uDFFF\r\n\t]*</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string BidPrice
        {
            get { return this.bidPrice; }
            set { this.bidPrice = value; }
        }

        /// <summary>
        /// Sets the BidPrice property
        /// </summary>
        /// <param name="bidPrice">The value to set for the BidPrice property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public InstanceGroupDetail WithBidPrice(string bidPrice)
        {
            this.bidPrice = bidPrice;
            return this;
        }
            

        // Check to see if BidPrice property is set
        internal bool IsSetBidPrice()
        {
            return this.bidPrice != null;
        }

        /// <summary>
        /// Amazon EC2 Instance type.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 256</description>
        ///     </item>
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>[\u0020-\uD7FF\uE000-\uFFFD\uD800\uDC00-\uDBFF\uDFFF\r\n\t]*</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string InstanceType
        {
            get { return this.instanceType; }
            set { this.instanceType = value; }
        }

        /// <summary>
        /// Sets the InstanceType property
        /// </summary>
        /// <param name="instanceType">The value to set for the InstanceType property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public InstanceGroupDetail WithInstanceType(string instanceType)
        {
            this.instanceType = instanceType;
            return this;
        }
            

        // Check to see if InstanceType property is set
        internal bool IsSetInstanceType()
        {
            return this.instanceType != null;
        }

        /// <summary>
        /// Target number of instances to run in the instance group.
        ///  
        /// </summary>
        public int InstanceRequestCount
        {
            get { return this.instanceRequestCount ?? default(int); }
            set { this.instanceRequestCount = value; }
        }

        /// <summary>
        /// Sets the InstanceRequestCount property
        /// </summary>
        /// <param name="instanceRequestCount">The value to set for the InstanceRequestCount property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public InstanceGroupDetail WithInstanceRequestCount(int instanceRequestCount)
        {
            this.instanceRequestCount = instanceRequestCount;
            return this;
        }
            

        // Check to see if InstanceRequestCount property is set
        internal bool IsSetInstanceRequestCount()
        {
            return this.instanceRequestCount.HasValue;
        }

        /// <summary>
        /// Actual count of running instances.
        ///  
        /// </summary>
        public int InstanceRunningCount
        {
            get { return this.instanceRunningCount ?? default(int); }
            set { this.instanceRunningCount = value; }
        }

        /// <summary>
        /// Sets the InstanceRunningCount property
        /// </summary>
        /// <param name="instanceRunningCount">The value to set for the InstanceRunningCount property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public InstanceGroupDetail WithInstanceRunningCount(int instanceRunningCount)
        {
            this.instanceRunningCount = instanceRunningCount;
            return this;
        }
            

        // Check to see if InstanceRunningCount property is set
        internal bool IsSetInstanceRunningCount()
        {
            return this.instanceRunningCount.HasValue;
        }

        /// <summary>
        /// State of instance group. The following values are deprecated: STARTING, TERMINATED, and FAILED.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>PROVISIONING, STARTING, BOOTSTRAPPING, RUNNING, RESIZING, ARRESTED, SHUTTING_DOWN, TERMINATED, FAILED, ENDED</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string State
        {
            get { return this.state; }
            set { this.state = value; }
        }

        /// <summary>
        /// Sets the State property
        /// </summary>
        /// <param name="state">The value to set for the State property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public InstanceGroupDetail WithState(string state)
        {
            this.state = state;
            return this;
        }
            

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this.state != null;
        }

        /// <summary>
        /// Details regarding the state of the instance group.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>0 - 10280</description>
        ///     </item>
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>[\u0020-\uD7FF\uE000-\uFFFD\uD800\uDC00-\uDBFF\uDFFF\r\n\t]*</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string LastStateChangeReason
        {
            get { return this.lastStateChangeReason; }
            set { this.lastStateChangeReason = value; }
        }

        /// <summary>
        /// Sets the LastStateChangeReason property
        /// </summary>
        /// <param name="lastStateChangeReason">The value to set for the LastStateChangeReason property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public InstanceGroupDetail WithLastStateChangeReason(string lastStateChangeReason)
        {
            this.lastStateChangeReason = lastStateChangeReason;
            return this;
        }
            

        // Check to see if LastStateChangeReason property is set
        internal bool IsSetLastStateChangeReason()
        {
            return this.lastStateChangeReason != null;
        }

        /// <summary>
        /// The date/time the instance group was created.
        ///  
        /// </summary>
        public DateTime CreationDateTime
        {
            get { return this.creationDateTime ?? default(DateTime); }
            set { this.creationDateTime = value; }
        }

        /// <summary>
        /// Sets the CreationDateTime property
        /// </summary>
        /// <param name="creationDateTime">The value to set for the CreationDateTime property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public InstanceGroupDetail WithCreationDateTime(DateTime creationDateTime)
        {
            this.creationDateTime = creationDateTime;
            return this;
        }
            

        // Check to see if CreationDateTime property is set
        internal bool IsSetCreationDateTime()
        {
            return this.creationDateTime.HasValue;
        }

        /// <summary>
        /// The date/time the instance group was started.
        ///  
        /// </summary>
        public DateTime StartDateTime
        {
            get { return this.startDateTime ?? default(DateTime); }
            set { this.startDateTime = value; }
        }

        /// <summary>
        /// Sets the StartDateTime property
        /// </summary>
        /// <param name="startDateTime">The value to set for the StartDateTime property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public InstanceGroupDetail WithStartDateTime(DateTime startDateTime)
        {
            this.startDateTime = startDateTime;
            return this;
        }
            

        // Check to see if StartDateTime property is set
        internal bool IsSetStartDateTime()
        {
            return this.startDateTime.HasValue;
        }

        /// <summary>
        /// The date/time the instance group was available to the cluster.
        ///  
        /// </summary>
        public DateTime ReadyDateTime
        {
            get { return this.readyDateTime ?? default(DateTime); }
            set { this.readyDateTime = value; }
        }

        /// <summary>
        /// Sets the ReadyDateTime property
        /// </summary>
        /// <param name="readyDateTime">The value to set for the ReadyDateTime property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public InstanceGroupDetail WithReadyDateTime(DateTime readyDateTime)
        {
            this.readyDateTime = readyDateTime;
            return this;
        }
            

        // Check to see if ReadyDateTime property is set
        internal bool IsSetReadyDateTime()
        {
            return this.readyDateTime.HasValue;
        }

        /// <summary>
        /// The date/time the instance group was terminated.
        ///  
        /// </summary>
        public DateTime EndDateTime
        {
            get { return this.endDateTime ?? default(DateTime); }
            set { this.endDateTime = value; }
        }

        /// <summary>
        /// Sets the EndDateTime property
        /// </summary>
        /// <param name="endDateTime">The value to set for the EndDateTime property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public InstanceGroupDetail WithEndDateTime(DateTime endDateTime)
        {
            this.endDateTime = endDateTime;
            return this;
        }
            

        // Check to see if EndDateTime property is set
        internal bool IsSetEndDateTime()
        {
            return this.endDateTime.HasValue;
        }
    }
}
