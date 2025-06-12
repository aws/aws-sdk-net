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
    /// Specify the type of Amazon EC2 instances that the cluster (job flow) runs on.
    /// </summary>
    public partial class JobFlowInstancesDetail
    {
        private string _ec2KeyName;
        private string _ec2SubnetId;
        private string _hadoopVersion;
        private int? _instanceCount;
        private List<InstanceGroupDetail> _instanceGroups = AWSConfigs.InitializeCollections ? new List<InstanceGroupDetail>() : null;
        private bool? _keepJobFlowAliveWhenNoSteps;
        private string _masterInstanceId;
        private string _masterInstanceType;
        private string _masterPublicDnsName;
        private int? _normalizedInstanceHours;
        private PlacementType _placement;
        private string _slaveInstanceType;
        private bool? _terminationProtected;
        private bool? _unhealthyNodeReplacement;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public JobFlowInstancesDetail() { }

        /// <summary>
        /// Instantiates JobFlowInstancesDetail with the parameterized properties
        /// </summary>
        /// <param name="masterInstanceType">The Amazon EC2 master node instance type.</param>
        /// <param name="slaveInstanceType">The Amazon EC2 core and task node instance type.</param>
        /// <param name="instanceCount">The number of Amazon EC2 instances in the cluster. If the value is 1, the same instance serves as both the master and core and task node. If the value is greater than 1, one instance is the master node and all others are core and task nodes.</param>
        public JobFlowInstancesDetail(string masterInstanceType, string slaveInstanceType, int? instanceCount)
        {
            _masterInstanceType = masterInstanceType;
            _slaveInstanceType = slaveInstanceType;
            _instanceCount = instanceCount;
        }

        /// <summary>
        /// Gets and sets the property Ec2KeyName. 
        /// <para>
        /// The name of an Amazon EC2 key pair that can be used to connect to the master node
        /// using SSH.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
        public string Ec2KeyName
        {
            get { return this._ec2KeyName; }
            set { this._ec2KeyName = value; }
        }

        // Check to see if Ec2KeyName property is set
        internal bool IsSetEc2KeyName()
        {
            return this._ec2KeyName != null;
        }

        /// <summary>
        /// Gets and sets the property Ec2SubnetId. 
        /// <para>
        /// For clusters launched within Amazon Virtual Private Cloud, this is the identifier
        /// of the subnet where the cluster was launched.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
        public string Ec2SubnetId
        {
            get { return this._ec2SubnetId; }
            set { this._ec2SubnetId = value; }
        }

        // Check to see if Ec2SubnetId property is set
        internal bool IsSetEc2SubnetId()
        {
            return this._ec2SubnetId != null;
        }

        /// <summary>
        /// Gets and sets the property HadoopVersion. 
        /// <para>
        /// The Hadoop version for the cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
        public string HadoopVersion
        {
            get { return this._hadoopVersion; }
            set { this._hadoopVersion = value; }
        }

        // Check to see if HadoopVersion property is set
        internal bool IsSetHadoopVersion()
        {
            return this._hadoopVersion != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceCount. 
        /// <para>
        /// The number of Amazon EC2 instances in the cluster. If the value is 1, the same instance
        /// serves as both the master and core and task node. If the value is greater than 1,
        /// one instance is the master node and all others are core and task nodes.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? InstanceCount
        {
            get { return this._instanceCount; }
            set { this._instanceCount = value; }
        }

        // Check to see if InstanceCount property is set
        internal bool IsSetInstanceCount()
        {
            return this._instanceCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InstanceGroups. 
        /// <para>
        /// Details about the instance groups in a cluster.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<InstanceGroupDetail> InstanceGroups
        {
            get { return this._instanceGroups; }
            set { this._instanceGroups = value; }
        }

        // Check to see if InstanceGroups property is set
        internal bool IsSetInstanceGroups()
        {
            return this._instanceGroups != null && (this._instanceGroups.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property KeepJobFlowAliveWhenNoSteps. 
        /// <para>
        /// Specifies whether the cluster should remain available after completing all steps.
        /// </para>
        /// </summary>
        public bool? KeepJobFlowAliveWhenNoSteps
        {
            get { return this._keepJobFlowAliveWhenNoSteps; }
            set { this._keepJobFlowAliveWhenNoSteps = value; }
        }

        // Check to see if KeepJobFlowAliveWhenNoSteps property is set
        internal bool IsSetKeepJobFlowAliveWhenNoSteps()
        {
            return this._keepJobFlowAliveWhenNoSteps.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MasterInstanceId. 
        /// <para>
        /// The Amazon EC2 instance identifier of the master node.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=10280)]
        public string MasterInstanceId
        {
            get { return this._masterInstanceId; }
            set { this._masterInstanceId = value; }
        }

        // Check to see if MasterInstanceId property is set
        internal bool IsSetMasterInstanceId()
        {
            return this._masterInstanceId != null;
        }

        /// <summary>
        /// Gets and sets the property MasterInstanceType. 
        /// <para>
        /// The Amazon EC2 master node instance type.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string MasterInstanceType
        {
            get { return this._masterInstanceType; }
            set { this._masterInstanceType = value; }
        }

        // Check to see if MasterInstanceType property is set
        internal bool IsSetMasterInstanceType()
        {
            return this._masterInstanceType != null;
        }

        /// <summary>
        /// Gets and sets the property MasterPublicDnsName. 
        /// <para>
        /// The DNS name of the master node. If the cluster is on a private subnet, this is the
        /// private DNS name. On a public subnet, this is the public DNS name.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=10280)]
        public string MasterPublicDnsName
        {
            get { return this._masterPublicDnsName; }
            set { this._masterPublicDnsName = value; }
        }

        // Check to see if MasterPublicDnsName property is set
        internal bool IsSetMasterPublicDnsName()
        {
            return this._masterPublicDnsName != null;
        }

        /// <summary>
        /// Gets and sets the property NormalizedInstanceHours. 
        /// <para>
        /// An approximation of the cost of the cluster, represented in m1.small/hours. This value
        /// is increased one time for every hour that an m1.small instance runs. Larger instances
        /// are weighted more heavily, so an Amazon EC2 instance that is roughly four times more
        /// expensive would result in the normalized instance hours being increased incrementally
        /// four times. This result is only an approximation and does not reflect the actual billing
        /// rate.
        /// </para>
        /// </summary>
        public int? NormalizedInstanceHours
        {
            get { return this._normalizedInstanceHours; }
            set { this._normalizedInstanceHours = value; }
        }

        // Check to see if NormalizedInstanceHours property is set
        internal bool IsSetNormalizedInstanceHours()
        {
            return this._normalizedInstanceHours.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Placement. 
        /// <para>
        /// The Amazon EC2 Availability Zone for the cluster.
        /// </para>
        /// </summary>
        public PlacementType Placement
        {
            get { return this._placement; }
            set { this._placement = value; }
        }

        // Check to see if Placement property is set
        internal bool IsSetPlacement()
        {
            return this._placement != null;
        }

        /// <summary>
        /// Gets and sets the property SlaveInstanceType. 
        /// <para>
        /// The Amazon EC2 core and task node instance type.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string SlaveInstanceType
        {
            get { return this._slaveInstanceType; }
            set { this._slaveInstanceType = value; }
        }

        // Check to see if SlaveInstanceType property is set
        internal bool IsSetSlaveInstanceType()
        {
            return this._slaveInstanceType != null;
        }

        /// <summary>
        /// Gets and sets the property TerminationProtected. 
        /// <para>
        /// Specifies whether the Amazon EC2 instances in the cluster are protected from termination
        /// by API calls, user intervention, or in the event of a job-flow error.
        /// </para>
        /// </summary>
        public bool? TerminationProtected
        {
            get { return this._terminationProtected; }
            set { this._terminationProtected = value; }
        }

        // Check to see if TerminationProtected property is set
        internal bool IsSetTerminationProtected()
        {
            return this._terminationProtected.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UnhealthyNodeReplacement. 
        /// <para>
        /// Indicates whether Amazon EMR should gracefully replace core nodes that have degraded
        /// within the cluster.
        /// </para>
        /// </summary>
        public bool? UnhealthyNodeReplacement
        {
            get { return this._unhealthyNodeReplacement; }
            set { this._unhealthyNodeReplacement = value; }
        }

        // Check to see if UnhealthyNodeReplacement property is set
        internal bool IsSetUnhealthyNodeReplacement()
        {
            return this._unhealthyNodeReplacement.HasValue; 
        }

    }
}