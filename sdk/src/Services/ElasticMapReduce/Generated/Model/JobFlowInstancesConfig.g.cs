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

namespace Amazon.ElasticMapReduce.Model
{
    /// <summary>
    /// A description of the Amazon EC2 instance on which the cluster (job flow) runs. A valid
    /// JobFlowInstancesConfig must contain either InstanceGroups or InstanceFleets. They
    /// cannot be used together. You may also have MasterInstanceType, SlaveInstanceType,
    /// and InstanceCount (all three must be present), but we don't recommend this configuration.
    /// </summary>
    public partial class JobFlowInstancesConfig
    {
        /// <summary>
        /// Empty constructor used to set properties independently even when a simple constructor is available
        /// </summary>
        public JobFlowInstancesConfig() { }

        /// <summary>
        /// Gets and sets the property AdditionalMasterSecurityGroups. 
        /// <para>
        /// A list of additional Amazon EC2 security group IDs for the master node.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AdditionalMasterSecurityGroups { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AdditionalMasterSecurityGroups property is set.
        /// </summary>
        internal bool IsSetAdditionalMasterSecurityGroups() => this.AdditionalMasterSecurityGroups != null && (this.AdditionalMasterSecurityGroups.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AdditionalSlaveSecurityGroups. 
        /// <para>
        /// A list of additional Amazon EC2 security group IDs for the core and task nodes.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AdditionalSlaveSecurityGroups { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AdditionalSlaveSecurityGroups property is set.
        /// </summary>
        internal bool IsSetAdditionalSlaveSecurityGroups() => this.AdditionalSlaveSecurityGroups != null && (this.AdditionalSlaveSecurityGroups.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Ec2KeyName. 
        /// <para>
        /// The name of the Amazon EC2 key pair that can be used to connect to the master node
        /// using SSH as the user called "hadoop."
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string Ec2KeyName { get; set; }

        /// <summary>
        /// Checks to see if the Ec2KeyName property is set.
        /// </summary>
        internal bool IsSetEc2KeyName() => this.Ec2KeyName != null;

        /// <summary>
        /// Gets and sets the property Ec2SubnetId. 
        /// <para>
        /// Applies to clusters that use the uniform instance group configuration. To launch the
        /// cluster in Amazon Virtual Private Cloud (Amazon VPC), set this parameter to the identifier
        /// of the Amazon VPC subnet where you want the cluster to launch. If you do not specify
        /// this value and your account supports EC2-Classic, the cluster launches in EC2-Classic.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string Ec2SubnetId { get; set; }

        /// <summary>
        /// Checks to see if the Ec2SubnetId property is set.
        /// </summary>
        internal bool IsSetEc2SubnetId() => this.Ec2SubnetId != null;

        /// <summary>
        /// Gets and sets the property Ec2SubnetIds. 
        /// <para>
        /// Applies to clusters that use the instance fleet configuration. When multiple Amazon
        /// EC2 subnet IDs are specified, Amazon EMR evaluates them and launches instances in
        /// the optimal subnet.
        /// </para>
        ///  <note> 
        /// <para>
        /// The instance fleet configuration is available only in Amazon EMR releases 4.8.0 and
        /// later, excluding 5.0.x versions.
        /// </para>
        ///  </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Ec2SubnetIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Ec2SubnetIds property is set.
        /// </summary>
        internal bool IsSetEc2SubnetIds() => this.Ec2SubnetIds != null && (this.Ec2SubnetIds.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property EmrManagedMasterSecurityGroup. 
        /// <para>
        /// The identifier of the Amazon EC2 security group for the master node. If you specify
        /// <c>EmrManagedMasterSecurityGroup</c>, you must also specify <c>EmrManagedSlaveSecurityGroup</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string EmrManagedMasterSecurityGroup { get; set; }

        /// <summary>
        /// Checks to see if the EmrManagedMasterSecurityGroup property is set.
        /// </summary>
        internal bool IsSetEmrManagedMasterSecurityGroup() => this.EmrManagedMasterSecurityGroup != null;

        /// <summary>
        /// Gets and sets the property EmrManagedSlaveSecurityGroup. 
        /// <para>
        /// The identifier of the Amazon EC2 security group for the core and task nodes. If you
        /// specify <c>EmrManagedSlaveSecurityGroup</c>, you must also specify <c>EmrManagedMasterSecurityGroup</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string EmrManagedSlaveSecurityGroup { get; set; }

        /// <summary>
        /// Checks to see if the EmrManagedSlaveSecurityGroup property is set.
        /// </summary>
        internal bool IsSetEmrManagedSlaveSecurityGroup() => this.EmrManagedSlaveSecurityGroup != null;

        /// <summary>
        /// Gets and sets the property HadoopVersion. 
        /// <para>
        /// Applies only to Amazon EMR release versions earlier than 4.0. The Hadoop version for
        /// the cluster. Valid inputs are "0.18" (no longer maintained), "0.20" (no longer maintained),
        /// "0.20.205" (no longer maintained), "1.0.3", "2.2.0", or "2.4.0". If you do not set
        /// this value, the default of 0.18 is used, unless the <c>AmiVersion</c> parameter is
        /// set in the RunJobFlow call, in which case the default version of Hadoop for that AMI
        /// version is used.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string HadoopVersion { get; set; }

        /// <summary>
        /// Checks to see if the HadoopVersion property is set.
        /// </summary>
        internal bool IsSetHadoopVersion() => this.HadoopVersion != null;

        /// <summary>
        /// Gets and sets the property InstanceCount. 
        /// <para>
        /// The number of Amazon EC2 instances in the cluster.
        /// </para>
        /// </summary>
        public int? InstanceCount { get; set; }

        /// <summary>
        /// Checks to see if the InstanceCount property is set.
        /// </summary>
        internal bool IsSetInstanceCount() => this.InstanceCount.HasValue;

        /// <summary>
        /// Gets and sets the property InstanceFleets. <note> 
        /// <para>
        /// The instance fleet configuration is available only in Amazon EMR releases 4.8.0 and
        /// later, excluding 5.0.x versions.
        /// </para>
        ///  </note> 
        /// <para>
        /// Describes the Amazon EC2 instances and instance configurations for clusters that use
        /// the instance fleet configuration.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<InstanceFleetConfig> InstanceFleets { get; set; } = AWSConfigs.InitializeCollections ? new List<InstanceFleetConfig>() : null;

        /// <summary>
        /// Checks to see if the InstanceFleets property is set.
        /// </summary>
        internal bool IsSetInstanceFleets() => this.InstanceFleets != null && (this.InstanceFleets.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property InstanceGroups. 
        /// <para>
        /// Configuration for the instance groups in a cluster.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<InstanceGroupConfig> InstanceGroups { get; set; } = AWSConfigs.InitializeCollections ? new List<InstanceGroupConfig>() : null;

        /// <summary>
        /// Checks to see if the InstanceGroups property is set.
        /// </summary>
        internal bool IsSetInstanceGroups() => this.InstanceGroups != null && (this.InstanceGroups.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property KeepJobFlowAliveWhenNoSteps. 
        /// <para>
        /// Specifies whether the cluster should remain available after completing all steps.
        /// Defaults to <c>false</c>. For more information about configuring cluster termination,
        /// see <a href="https://docs.aws.amazon.com/emr/latest/ManagementGuide/emr-plan-termination.html">Control
        /// Cluster Termination</a> in the <i>EMR Management Guide</i>.
        /// </para>
        /// </summary>
        public bool? KeepJobFlowAliveWhenNoSteps { get; set; }

        /// <summary>
        /// Checks to see if the KeepJobFlowAliveWhenNoSteps property is set.
        /// </summary>
        internal bool IsSetKeepJobFlowAliveWhenNoSteps() => this.KeepJobFlowAliveWhenNoSteps.HasValue;

        /// <summary>
        /// Gets and sets the property MasterInstanceType. 
        /// <para>
        /// The Amazon EC2 instance type of the master node.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string MasterInstanceType { get; set; }

        /// <summary>
        /// Checks to see if the MasterInstanceType property is set.
        /// </summary>
        internal bool IsSetMasterInstanceType() => this.MasterInstanceType != null;

        /// <summary>
        /// Gets and sets the property Placement. 
        /// <para>
        /// The Availability Zone in which the cluster runs.
        /// </para>
        /// </summary>
        public PlacementType Placement { get; set; }

        /// <summary>
        /// Checks to see if the Placement property is set.
        /// </summary>
        internal bool IsSetPlacement() => this.Placement != null;

        /// <summary>
        /// Gets and sets the property ServiceAccessSecurityGroup. 
        /// <para>
        /// The identifier of the Amazon EC2 security group for the Amazon EMR service to access
        /// clusters in VPC private subnets.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string ServiceAccessSecurityGroup { get; set; }

        /// <summary>
        /// Checks to see if the ServiceAccessSecurityGroup property is set.
        /// </summary>
        internal bool IsSetServiceAccessSecurityGroup() => this.ServiceAccessSecurityGroup != null;

        /// <summary>
        /// Gets and sets the property SlaveInstanceType. 
        /// <para>
        /// The Amazon EC2 instance type of the core and task nodes.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string SlaveInstanceType { get; set; }

        /// <summary>
        /// Checks to see if the SlaveInstanceType property is set.
        /// </summary>
        internal bool IsSetSlaveInstanceType() => this.SlaveInstanceType != null;

        /// <summary>
        /// Gets and sets the property TerminationProtected. 
        /// <para>
        /// Specifies whether to lock the cluster to prevent the Amazon EC2 instances from being
        /// terminated by API call, user intervention, or in the event of a job-flow error.
        /// </para>
        /// </summary>
        public bool? TerminationProtected { get; set; }

        /// <summary>
        /// Checks to see if the TerminationProtected property is set.
        /// </summary>
        internal bool IsSetTerminationProtected() => this.TerminationProtected.HasValue;

        /// <summary>
        /// Gets and sets the property UnhealthyNodeReplacement. 
        /// <para>
        /// Indicates whether Amazon EMR should gracefully replace core nodes that have degraded
        /// within the cluster.
        /// </para>
        /// </summary>
        public bool? UnhealthyNodeReplacement { get; set; }

        /// <summary>
        /// Checks to see if the UnhealthyNodeReplacement property is set.
        /// </summary>
        internal bool IsSetUnhealthyNodeReplacement() => this.UnhealthyNodeReplacement.HasValue;
    }
}
