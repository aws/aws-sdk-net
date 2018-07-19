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

/*
 * Do not modify this file. This file is generated from the elasticmapreduce-2009-03-31.normal.json service model.
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
    /// A description of the Amazon EC2 instance on which the cluster (job flow) runs. A valid
    /// JobFlowInstancesConfig must contain either InstanceGroups or InstanceFleets, which
    /// is the recommended configuration. They cannot be used together. You may also have
    /// MasterInstanceType, SlaveInstanceType, and InstanceCount (all three must be present),
    /// but we don't recommend this configuration.
    /// </summary>
    public partial class JobFlowInstancesConfig
    {
        private List<string> _additionalMasterSecurityGroups = new List<string>();
        private List<string> _additionalSlaveSecurityGroups = new List<string>();
        private string _ec2KeyName;
        private string _ec2SubnetId;
        private List<string> _ec2SubnetIds = new List<string>();
        private string _emrManagedMasterSecurityGroup;
        private string _emrManagedSlaveSecurityGroup;
        private string _hadoopVersion;
        private int? _instanceCount;
        private List<InstanceFleetConfig> _instanceFleets = new List<InstanceFleetConfig>();
        private List<InstanceGroupConfig> _instanceGroups = new List<InstanceGroupConfig>();
        private bool? _keepJobFlowAliveWhenNoSteps;
        private string _masterInstanceType;
        private PlacementType _placement;
        private string _serviceAccessSecurityGroup;
        private string _slaveInstanceType;
        private bool? _terminationProtected;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public JobFlowInstancesConfig() { }

        /// <summary>
        /// Gets and sets the property AdditionalMasterSecurityGroups. 
        /// <para>
        /// A list of additional Amazon EC2 security group IDs for the master node.
        /// </para>
        /// </summary>
        public List<string> AdditionalMasterSecurityGroups
        {
            get { return this._additionalMasterSecurityGroups; }
            set { this._additionalMasterSecurityGroups = value; }
        }

        // Check to see if AdditionalMasterSecurityGroups property is set
        internal bool IsSetAdditionalMasterSecurityGroups()
        {
            return this._additionalMasterSecurityGroups != null && this._additionalMasterSecurityGroups.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property AdditionalSlaveSecurityGroups. 
        /// <para>
        /// A list of additional Amazon EC2 security group IDs for the slave nodes.
        /// </para>
        /// </summary>
        public List<string> AdditionalSlaveSecurityGroups
        {
            get { return this._additionalSlaveSecurityGroups; }
            set { this._additionalSlaveSecurityGroups = value; }
        }

        // Check to see if AdditionalSlaveSecurityGroups property is set
        internal bool IsSetAdditionalSlaveSecurityGroups()
        {
            return this._additionalSlaveSecurityGroups != null && this._additionalSlaveSecurityGroups.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Ec2KeyName. 
        /// <para>
        /// The name of the EC2 key pair that can be used to ssh to the master node as the user
        /// called "hadoop."
        /// </para>
        /// </summary>
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
        /// Applies to clusters that use the uniform instance group configuration. To launch the
        /// cluster in Amazon Virtual Private Cloud (Amazon VPC), set this parameter to the identifier
        /// of the Amazon VPC subnet where you want the cluster to launch. If you do not specify
        /// this value, the cluster launches in the normal Amazon Web Services cloud, outside
        /// of an Amazon VPC, if the account launching the cluster supports EC2 Classic networks
        /// in the region where the cluster launches.
        /// </para>
        ///  
        /// <para>
        /// Amazon VPC currently does not support cluster compute quadruple extra large (cc1.4xlarge)
        /// instances. Thus you cannot specify the cc1.4xlarge instance type for clusters launched
        /// in an Amazon VPC.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property Ec2SubnetIds. 
        /// <para>
        /// Applies to clusters that use the instance fleet configuration. When multiple EC2 subnet
        /// IDs are specified, Amazon EMR evaluates them and launches instances in the optimal
        /// subnet.
        /// </para>
        ///  <note> 
        /// <para>
        /// The instance fleet configuration is available only in Amazon EMR versions 4.8.0 and
        /// later, excluding 5.0.x versions.
        /// </para>
        ///  </note>
        /// </summary>
        public List<string> Ec2SubnetIds
        {
            get { return this._ec2SubnetIds; }
            set { this._ec2SubnetIds = value; }
        }

        // Check to see if Ec2SubnetIds property is set
        internal bool IsSetEc2SubnetIds()
        {
            return this._ec2SubnetIds != null && this._ec2SubnetIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property EmrManagedMasterSecurityGroup. 
        /// <para>
        /// The identifier of the Amazon EC2 security group for the master node.
        /// </para>
        /// </summary>
        public string EmrManagedMasterSecurityGroup
        {
            get { return this._emrManagedMasterSecurityGroup; }
            set { this._emrManagedMasterSecurityGroup = value; }
        }

        // Check to see if EmrManagedMasterSecurityGroup property is set
        internal bool IsSetEmrManagedMasterSecurityGroup()
        {
            return this._emrManagedMasterSecurityGroup != null;
        }

        /// <summary>
        /// Gets and sets the property EmrManagedSlaveSecurityGroup. 
        /// <para>
        /// The identifier of the Amazon EC2 security group for the slave nodes.
        /// </para>
        /// </summary>
        public string EmrManagedSlaveSecurityGroup
        {
            get { return this._emrManagedSlaveSecurityGroup; }
            set { this._emrManagedSlaveSecurityGroup = value; }
        }

        // Check to see if EmrManagedSlaveSecurityGroup property is set
        internal bool IsSetEmrManagedSlaveSecurityGroup()
        {
            return this._emrManagedSlaveSecurityGroup != null;
        }

        /// <summary>
        /// Gets and sets the property HadoopVersion. 
        /// <para>
        /// Applies only to Amazon EMR release versions earlier than 4.0. The Hadoop version for
        /// the cluster. Valid inputs are "0.18" (deprecated), "0.20" (deprecated), "0.20.205"
        /// (deprecated), "1.0.3", "2.2.0", or "2.4.0". If you do not set this value, the default
        /// of 0.18 is used, unless the <code>AmiVersion</code> parameter is set in the RunJobFlow
        /// call, in which case the default version of Hadoop for that AMI version is used.
        /// </para>
        /// </summary>
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
        /// The number of EC2 instances in the cluster.
        /// </para>
        /// </summary>
        public int InstanceCount
        {
            get { return this._instanceCount.GetValueOrDefault(); }
            set { this._instanceCount = value; }
        }

        // Check to see if InstanceCount property is set
        internal bool IsSetInstanceCount()
        {
            return this._instanceCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InstanceFleets. <note> 
        /// <para>
        /// The instance fleet configuration is available only in Amazon EMR versions 4.8.0 and
        /// later, excluding 5.0.x versions.
        /// </para>
        ///  </note> 
        /// <para>
        /// Describes the EC2 instances and instance configurations for clusters that use the
        /// instance fleet configuration.
        /// </para>
        /// </summary>
        public List<InstanceFleetConfig> InstanceFleets
        {
            get { return this._instanceFleets; }
            set { this._instanceFleets = value; }
        }

        // Check to see if InstanceFleets property is set
        internal bool IsSetInstanceFleets()
        {
            return this._instanceFleets != null && this._instanceFleets.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property InstanceGroups. 
        /// <para>
        /// Configuration for the instance groups in a cluster.
        /// </para>
        /// </summary>
        public List<InstanceGroupConfig> InstanceGroups
        {
            get { return this._instanceGroups; }
            set { this._instanceGroups = value; }
        }

        // Check to see if InstanceGroups property is set
        internal bool IsSetInstanceGroups()
        {
            return this._instanceGroups != null && this._instanceGroups.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property KeepJobFlowAliveWhenNoSteps. 
        /// <para>
        /// Specifies whether the cluster should remain available after completing all steps.
        /// </para>
        /// </summary>
        public bool KeepJobFlowAliveWhenNoSteps
        {
            get { return this._keepJobFlowAliveWhenNoSteps.GetValueOrDefault(); }
            set { this._keepJobFlowAliveWhenNoSteps = value; }
        }

        // Check to see if KeepJobFlowAliveWhenNoSteps property is set
        internal bool IsSetKeepJobFlowAliveWhenNoSteps()
        {
            return this._keepJobFlowAliveWhenNoSteps.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MasterInstanceType. 
        /// <para>
        /// The EC2 instance type of the master node.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property Placement. 
        /// <para>
        /// The Availability Zone in which the cluster runs.
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
        /// Gets and sets the property ServiceAccessSecurityGroup. 
        /// <para>
        /// The identifier of the Amazon EC2 security group for the Amazon EMR service to access
        /// clusters in VPC private subnets.
        /// </para>
        /// </summary>
        public string ServiceAccessSecurityGroup
        {
            get { return this._serviceAccessSecurityGroup; }
            set { this._serviceAccessSecurityGroup = value; }
        }

        // Check to see if ServiceAccessSecurityGroup property is set
        internal bool IsSetServiceAccessSecurityGroup()
        {
            return this._serviceAccessSecurityGroup != null;
        }

        /// <summary>
        /// Gets and sets the property SlaveInstanceType. 
        /// <para>
        /// The EC2 instance type of the slave nodes.
        /// </para>
        /// </summary>
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
        /// Specifies whether to lock the cluster to prevent the Amazon EC2 instances from being
        /// terminated by API call, user intervention, or in the event of a job-flow error.
        /// </para>
        /// </summary>
        public bool TerminationProtected
        {
            get { return this._terminationProtected.GetValueOrDefault(); }
            set { this._terminationProtected = value; }
        }

        // Check to see if TerminationProtected property is set
        internal bool IsSetTerminationProtected()
        {
            return this._terminationProtected.HasValue; 
        }

    }
}