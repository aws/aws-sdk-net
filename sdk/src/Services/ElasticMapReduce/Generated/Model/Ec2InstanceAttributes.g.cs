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
    /// Provides information about the Amazon EC2 instances in a cluster grouped by category.
    /// For example, key name, subnet ID, IAM instance profile, and so on.
    /// </summary>
    public partial class Ec2InstanceAttributes
    {
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
        /// Gets and sets the property Ec2AvailabilityZone. 
        /// <para>
        /// The Availability Zone in which the cluster will run. 
        /// </para>
        /// </summary>
        public string Ec2AvailabilityZone { get; set; }

        /// <summary>
        /// Checks to see if the Ec2AvailabilityZone property is set.
        /// </summary>
        internal bool IsSetEc2AvailabilityZone() => this.Ec2AvailabilityZone != null;

        /// <summary>
        /// Gets and sets the property Ec2KeyName. 
        /// <para>
        /// The name of the Amazon EC2 key pair to use when connecting with SSH into the master
        /// node as a user named "hadoop".
        /// </para>
        /// </summary>
        public string Ec2KeyName { get; set; }

        /// <summary>
        /// Checks to see if the Ec2KeyName property is set.
        /// </summary>
        internal bool IsSetEc2KeyName() => this.Ec2KeyName != null;

        /// <summary>
        /// Gets and sets the property Ec2SubnetId. 
        /// <para>
        /// Set this parameter to the identifier of the Amazon VPC subnet where you want the cluster
        /// to launch. If you do not specify this value, and your account supports EC2-Classic,
        /// the cluster launches in EC2-Classic.
        /// </para>
        /// </summary>
        public string Ec2SubnetId { get; set; }

        /// <summary>
        /// Checks to see if the Ec2SubnetId property is set.
        /// </summary>
        internal bool IsSetEc2SubnetId() => this.Ec2SubnetId != null;

        /// <summary>
        /// Gets and sets the property EmrManagedMasterSecurityGroup. 
        /// <para>
        /// The identifier of the Amazon EC2 security group for the master node.
        /// </para>
        /// </summary>
        public string EmrManagedMasterSecurityGroup { get; set; }

        /// <summary>
        /// Checks to see if the EmrManagedMasterSecurityGroup property is set.
        /// </summary>
        internal bool IsSetEmrManagedMasterSecurityGroup() => this.EmrManagedMasterSecurityGroup != null;

        /// <summary>
        /// Gets and sets the property EmrManagedSlaveSecurityGroup. 
        /// <para>
        /// The identifier of the Amazon EC2 security group for the core and task nodes.
        /// </para>
        /// </summary>
        public string EmrManagedSlaveSecurityGroup { get; set; }

        /// <summary>
        /// Checks to see if the EmrManagedSlaveSecurityGroup property is set.
        /// </summary>
        internal bool IsSetEmrManagedSlaveSecurityGroup() => this.EmrManagedSlaveSecurityGroup != null;

        /// <summary>
        /// Gets and sets the property IamInstanceProfile. 
        /// <para>
        /// The IAM role that was specified when the cluster was launched. The Amazon EC2 instances
        /// of the cluster assume this role.
        /// </para>
        /// </summary>
        public string IamInstanceProfile { get; set; }

        /// <summary>
        /// Checks to see if the IamInstanceProfile property is set.
        /// </summary>
        internal bool IsSetIamInstanceProfile() => this.IamInstanceProfile != null;

        /// <summary>
        /// Gets and sets the property RequestedEc2AvailabilityZones. 
        /// <para>
        /// Applies to clusters configured with the instance fleets option. Specifies one or more
        /// Availability Zones in which to launch Amazon EC2 cluster instances when the EC2-Classic
        /// network configuration is supported. Amazon EMR chooses the Availability Zone with
        /// the best fit from among the list of <c>RequestedEc2AvailabilityZones</c>, and then
        /// launches all cluster instances within that Availability Zone. If you do not specify
        /// this value, Amazon EMR chooses the Availability Zone for you. <c>RequestedEc2SubnetIDs</c>
        /// and <c>RequestedEc2AvailabilityZones</c> cannot be specified together.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> RequestedEc2AvailabilityZones { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the RequestedEc2AvailabilityZones property is set.
        /// </summary>
        internal bool IsSetRequestedEc2AvailabilityZones() => this.RequestedEc2AvailabilityZones != null && (this.RequestedEc2AvailabilityZones.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RequestedEc2SubnetIds. 
        /// <para>
        /// Applies to clusters configured with the instance fleets option. Specifies the unique
        /// identifier of one or more Amazon EC2 subnets in which to launch Amazon EC2 cluster
        /// instances. Subnets must exist within the same VPC. Amazon EMR chooses the Amazon EC2
        /// subnet with the best fit from among the list of <c>RequestedEc2SubnetIds</c>, and
        /// then launches all cluster instances within that Subnet. If this value is not specified,
        /// and the account and Region support EC2-Classic networks, the cluster launches instances
        /// in the EC2-Classic network and uses <c>RequestedEc2AvailabilityZones</c> instead of
        /// this setting. If EC2-Classic is not supported, and no Subnet is specified, Amazon
        /// EMR chooses the subnet for you. <c>RequestedEc2SubnetIDs</c> and <c>RequestedEc2AvailabilityZones</c>
        /// cannot be specified together.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> RequestedEc2SubnetIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the RequestedEc2SubnetIds property is set.
        /// </summary>
        internal bool IsSetRequestedEc2SubnetIds() => this.RequestedEc2SubnetIds != null && (this.RequestedEc2SubnetIds.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ServiceAccessSecurityGroup. 
        /// <para>
        /// The identifier of the Amazon EC2 security group for the Amazon EMR service to access
        /// clusters in VPC private subnets.
        /// </para>
        /// </summary>
        public string ServiceAccessSecurityGroup { get; set; }

        /// <summary>
        /// Checks to see if the ServiceAccessSecurityGroup property is set.
        /// </summary>
        internal bool IsSetServiceAccessSecurityGroup() => this.ServiceAccessSecurityGroup != null;
    }
}
