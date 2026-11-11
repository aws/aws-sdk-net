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
    /// Specify the type of Amazon EC2 instances that the cluster (job flow) runs on.
    /// </summary>
    public partial class JobFlowInstancesDetail
    {
        /// <summary>
        /// Empty constructor used to set properties independently even when a simple constructor is available
        /// </summary>
        public JobFlowInstancesDetail() { }

        /// <summary>
        /// Instantiates JobFlowInstancesDetail with the parameterized properties
        /// </summary>
        /// <param name="masterInstanceType">The Amazon EC2 master node instance type.</param>
        /// <param name="slaveInstanceType">The Amazon EC2 core and task node instance type.</param>
        /// <param name="instanceCount">The number of Amazon EC2 instances in the cluster. If the value is 1, the same   instance serves as both the master and core and task node. If the value is greater than 1,   one instance is the master node and all others are core and task nodes.</param>
        public JobFlowInstancesDetail(string masterInstanceType, string slaveInstanceType, int? instanceCount)
        {
            this.MasterInstanceType = masterInstanceType;
            this.SlaveInstanceType = slaveInstanceType;
            this.InstanceCount = instanceCount;
        }

        /// <summary>
        /// Gets and sets the property Ec2KeyName. 
        /// <para>
        /// The name of an Amazon EC2 key pair that can be used to connect to the master node
        /// using SSH.
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
        /// For clusters launched within Amazon Virtual Private Cloud, this is the identifier
        /// of the subnet where the cluster was launched.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string Ec2SubnetId { get; set; }

        /// <summary>
        /// Checks to see if the Ec2SubnetId property is set.
        /// </summary>
        internal bool IsSetEc2SubnetId() => this.Ec2SubnetId != null;

        /// <summary>
        /// Gets and sets the property HadoopVersion. 
        /// <para>
        /// The Hadoop version for the cluster.
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
        /// The number of Amazon EC2 instances in the cluster. If the value is 1, the same instance
        /// serves as both the master and core and task node. If the value is greater than 1,
        /// one instance is the master node and all others are core and task nodes.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? InstanceCount { get; set; }

        /// <summary>
        /// Checks to see if the InstanceCount property is set.
        /// </summary>
        internal bool IsSetInstanceCount() => this.InstanceCount.HasValue;

        /// <summary>
        /// Gets and sets the property InstanceGroups. 
        /// <para>
        /// Details about the instance groups in a cluster.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<InstanceGroupDetail> InstanceGroups { get; set; } = AWSConfigs.InitializeCollections ? new List<InstanceGroupDetail>() : null;

        /// <summary>
        /// Checks to see if the InstanceGroups property is set.
        /// </summary>
        internal bool IsSetInstanceGroups() => this.InstanceGroups != null && (this.InstanceGroups.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property KeepJobFlowAliveWhenNoSteps. 
        /// <para>
        /// Specifies whether the cluster should remain available after completing all steps.
        /// </para>
        /// </summary>
        public bool? KeepJobFlowAliveWhenNoSteps { get; set; }

        /// <summary>
        /// Checks to see if the KeepJobFlowAliveWhenNoSteps property is set.
        /// </summary>
        internal bool IsSetKeepJobFlowAliveWhenNoSteps() => this.KeepJobFlowAliveWhenNoSteps.HasValue;

        /// <summary>
        /// Gets and sets the property MasterInstanceId. 
        /// <para>
        /// The Amazon EC2 instance identifier of the master node.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 10280)]
        public string MasterInstanceId { get; set; }

        /// <summary>
        /// Checks to see if the MasterInstanceId property is set.
        /// </summary>
        internal bool IsSetMasterInstanceId() => this.MasterInstanceId != null;

        /// <summary>
        /// Gets and sets the property MasterInstanceType. 
        /// <para>
        /// The Amazon EC2 master node instance type.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string MasterInstanceType { get; set; }

        /// <summary>
        /// Checks to see if the MasterInstanceType property is set.
        /// </summary>
        internal bool IsSetMasterInstanceType() => this.MasterInstanceType != null;

        /// <summary>
        /// Gets and sets the property MasterPublicDnsName. 
        /// <para>
        /// The DNS name of the master node. If the cluster is on a private subnet, this is the
        /// private DNS name. On a public subnet, this is the public DNS name.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 10280)]
        public string MasterPublicDnsName { get; set; }

        /// <summary>
        /// Checks to see if the MasterPublicDnsName property is set.
        /// </summary>
        internal bool IsSetMasterPublicDnsName() => this.MasterPublicDnsName != null;

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
        public int? NormalizedInstanceHours { get; set; }

        /// <summary>
        /// Checks to see if the NormalizedInstanceHours property is set.
        /// </summary>
        internal bool IsSetNormalizedInstanceHours() => this.NormalizedInstanceHours.HasValue;

        /// <summary>
        /// Gets and sets the property Placement. 
        /// <para>
        /// The Amazon EC2 Availability Zone for the cluster.
        /// </para>
        /// </summary>
        public PlacementType Placement { get; set; }

        /// <summary>
        /// Checks to see if the Placement property is set.
        /// </summary>
        internal bool IsSetPlacement() => this.Placement != null;

        /// <summary>
        /// Gets and sets the property SlaveInstanceType. 
        /// <para>
        /// The Amazon EC2 core and task node instance type.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string SlaveInstanceType { get; set; }

        /// <summary>
        /// Checks to see if the SlaveInstanceType property is set.
        /// </summary>
        internal bool IsSetSlaveInstanceType() => this.SlaveInstanceType != null;

        /// <summary>
        /// Gets and sets the property TerminationProtected. 
        /// <para>
        /// Specifies whether the Amazon EC2 instances in the cluster are protected from termination
        /// by API calls, user intervention, or in the event of a job-flow error.
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
