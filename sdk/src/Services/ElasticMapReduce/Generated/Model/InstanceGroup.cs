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
    /// This entity represents an instance group, which is a group of instances that have
    /// common purpose. For example, CORE instance group is used for HDFS.
    /// </summary>
    public partial class InstanceGroup
    {
        private AutoScalingPolicyDescription _autoScalingPolicy;
        private string _bidPrice;
        private List<Configuration> _configurations = AWSConfigs.InitializeCollections ? new List<Configuration>() : null;
        private long? _configurationsVersion;
        private string _customAmiId;
        private List<EbsBlockDevice> _ebsBlockDevices = AWSConfigs.InitializeCollections ? new List<EbsBlockDevice>() : null;
        private bool? _ebsOptimized;
        private string _id;
        private InstanceGroupType _instanceGroupType;
        private string _instanceType;
        private List<Configuration> _lastSuccessfullyAppliedConfigurations = AWSConfigs.InitializeCollections ? new List<Configuration>() : null;
        private long? _lastSuccessfullyAppliedConfigurationsVersion;
        private MarketType _market;
        private string _name;
        private int? _requestedInstanceCount;
        private int? _runningInstanceCount;
        private ShrinkPolicy _shrinkPolicy;
        private InstanceGroupStatus _status;

        /// <summary>
        /// Gets and sets the property AutoScalingPolicy. 
        /// <para>
        /// An automatic scaling policy for a core instance group or task instance group in an
        /// Amazon EMR cluster. The automatic scaling policy defines how an instance group dynamically
        /// adds and terminates Amazon EC2 instances in response to the value of a CloudWatch
        /// metric. See PutAutoScalingPolicy.
        /// </para>
        /// </summary>
        public AutoScalingPolicyDescription AutoScalingPolicy
        {
            get { return this._autoScalingPolicy; }
            set { this._autoScalingPolicy = value; }
        }

        // Check to see if AutoScalingPolicy property is set
        internal bool IsSetAutoScalingPolicy()
        {
            return this._autoScalingPolicy != null;
        }

        /// <summary>
        /// Gets and sets the property BidPrice. 
        /// <para>
        /// If specified, indicates that the instance group uses Spot Instances. This is the maximum
        /// price you are willing to pay for Spot Instances. Specify <c>OnDemandPrice</c> to set
        /// the amount equal to the On-Demand price, or specify an amount in USD.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property Configurations. <note> 
        /// <para>
        /// Amazon EMR releases 4.x or later.
        /// </para>
        ///  </note> 
        /// <para>
        /// The list of configurations supplied for an Amazon EMR cluster instance group. You
        /// can specify a separate configuration for each instance group (master, core, and task).
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Configuration> Configurations
        {
            get { return this._configurations; }
            set { this._configurations = value; }
        }

        // Check to see if Configurations property is set
        internal bool IsSetConfigurations()
        {
            return this._configurations != null && (this._configurations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ConfigurationsVersion. 
        /// <para>
        /// The version number of the requested configuration specification for this instance
        /// group.
        /// </para>
        /// </summary>
        public long? ConfigurationsVersion
        {
            get { return this._configurationsVersion; }
            set { this._configurationsVersion = value; }
        }

        // Check to see if ConfigurationsVersion property is set
        internal bool IsSetConfigurationsVersion()
        {
            return this._configurationsVersion.HasValue; 
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
        /// Gets and sets the property EbsBlockDevices. 
        /// <para>
        /// The EBS block devices that are mapped to this instance group.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<EbsBlockDevice> EbsBlockDevices
        {
            get { return this._ebsBlockDevices; }
            set { this._ebsBlockDevices = value; }
        }

        // Check to see if EbsBlockDevices property is set
        internal bool IsSetEbsBlockDevices()
        {
            return this._ebsBlockDevices != null && (this._ebsBlockDevices.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property EbsOptimized. 
        /// <para>
        /// If the instance group is EBS-optimized. An Amazon EBS-optimized instance uses an optimized
        /// configuration stack and provides additional, dedicated capacity for Amazon EBS I/O.
        /// </para>
        /// </summary>
        public bool? EbsOptimized
        {
            get { return this._ebsOptimized; }
            set { this._ebsOptimized = value; }
        }

        // Check to see if EbsOptimized property is set
        internal bool IsSetEbsOptimized()
        {
            return this._ebsOptimized.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The identifier of the instance group.
        /// </para>
        /// </summary>
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceGroupType. 
        /// <para>
        /// The type of the instance group. Valid values are MASTER, CORE or TASK.
        /// </para>
        /// </summary>
        public InstanceGroupType InstanceGroupType
        {
            get { return this._instanceGroupType; }
            set { this._instanceGroupType = value; }
        }

        // Check to see if InstanceGroupType property is set
        internal bool IsSetInstanceGroupType()
        {
            return this._instanceGroupType != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceType. 
        /// <para>
        /// The Amazon EC2 instance type for all instances in the instance group.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
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
        /// Gets and sets the property LastSuccessfullyAppliedConfigurations. 
        /// <para>
        /// A list of configurations that were successfully applied for an instance group last
        /// time.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Configuration> LastSuccessfullyAppliedConfigurations
        {
            get { return this._lastSuccessfullyAppliedConfigurations; }
            set { this._lastSuccessfullyAppliedConfigurations = value; }
        }

        // Check to see if LastSuccessfullyAppliedConfigurations property is set
        internal bool IsSetLastSuccessfullyAppliedConfigurations()
        {
            return this._lastSuccessfullyAppliedConfigurations != null && (this._lastSuccessfullyAppliedConfigurations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property LastSuccessfullyAppliedConfigurationsVersion. 
        /// <para>
        /// The version number of a configuration specification that was successfully applied
        /// for an instance group last time. 
        /// </para>
        /// </summary>
        public long? LastSuccessfullyAppliedConfigurationsVersion
        {
            get { return this._lastSuccessfullyAppliedConfigurationsVersion; }
            set { this._lastSuccessfullyAppliedConfigurationsVersion = value; }
        }

        // Check to see if LastSuccessfullyAppliedConfigurationsVersion property is set
        internal bool IsSetLastSuccessfullyAppliedConfigurationsVersion()
        {
            return this._lastSuccessfullyAppliedConfigurationsVersion.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Market. 
        /// <para>
        /// The marketplace to provision instances for this group. Valid values are ON_DEMAND
        /// or SPOT.
        /// </para>
        /// </summary>
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
        /// The name of the instance group.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property RequestedInstanceCount. 
        /// <para>
        /// The target number of instances for the instance group.
        /// </para>
        /// </summary>
        public int? RequestedInstanceCount
        {
            get { return this._requestedInstanceCount; }
            set { this._requestedInstanceCount = value; }
        }

        // Check to see if RequestedInstanceCount property is set
        internal bool IsSetRequestedInstanceCount()
        {
            return this._requestedInstanceCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RunningInstanceCount. 
        /// <para>
        /// The number of instances currently running in this instance group.
        /// </para>
        /// </summary>
        public int? RunningInstanceCount
        {
            get { return this._runningInstanceCount; }
            set { this._runningInstanceCount = value; }
        }

        // Check to see if RunningInstanceCount property is set
        internal bool IsSetRunningInstanceCount()
        {
            return this._runningInstanceCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ShrinkPolicy. 
        /// <para>
        /// Policy for customizing shrink operations.
        /// </para>
        /// </summary>
        public ShrinkPolicy ShrinkPolicy
        {
            get { return this._shrinkPolicy; }
            set { this._shrinkPolicy = value; }
        }

        // Check to see if ShrinkPolicy property is set
        internal bool IsSetShrinkPolicy()
        {
            return this._shrinkPolicy != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the instance group.
        /// </para>
        /// </summary>
        public InstanceGroupStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}