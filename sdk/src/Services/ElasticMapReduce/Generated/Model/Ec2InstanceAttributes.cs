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
    /// Provides information about the Amazon EC2 instances in a cluster grouped by category.
    /// For example, key name, subnet ID, IAM instance profile, and so on.
    /// </summary>
    public partial class Ec2InstanceAttributes
    {
        private List<string> _additionalMasterSecurityGroups = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _additionalSlaveSecurityGroups = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _ec2AvailabilityZone;
        private string _ec2KeyName;
        private string _ec2SubnetId;
        private string _emrManagedMasterSecurityGroup;
        private string _emrManagedSlaveSecurityGroup;
        private string _iamInstanceProfile;
        private List<string> _requestedEc2AvailabilityZones = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _requestedEc2SubnetIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _serviceAccessSecurityGroup;

        /// <summary>
        /// Gets and sets the property AdditionalMasterSecurityGroups. 
        /// <para>
        /// A list of additional Amazon EC2 security group IDs for the master node.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AdditionalMasterSecurityGroups
        {
            get { return this._additionalMasterSecurityGroups; }
            set { this._additionalMasterSecurityGroups = value; }
        }

        // Check to see if AdditionalMasterSecurityGroups property is set
        internal bool IsSetAdditionalMasterSecurityGroups()
        {
            return this._additionalMasterSecurityGroups != null && (this._additionalMasterSecurityGroups.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property AdditionalSlaveSecurityGroups. 
        /// <para>
        /// A list of additional Amazon EC2 security group IDs for the core and task nodes.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AdditionalSlaveSecurityGroups
        {
            get { return this._additionalSlaveSecurityGroups; }
            set { this._additionalSlaveSecurityGroups = value; }
        }

        // Check to see if AdditionalSlaveSecurityGroups property is set
        internal bool IsSetAdditionalSlaveSecurityGroups()
        {
            return this._additionalSlaveSecurityGroups != null && (this._additionalSlaveSecurityGroups.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Ec2AvailabilityZone. 
        /// <para>
        /// The Availability Zone in which the cluster will run. 
        /// </para>
        /// </summary>
        public string Ec2AvailabilityZone
        {
            get { return this._ec2AvailabilityZone; }
            set { this._ec2AvailabilityZone = value; }
        }

        // Check to see if Ec2AvailabilityZone property is set
        internal bool IsSetEc2AvailabilityZone()
        {
            return this._ec2AvailabilityZone != null;
        }

        /// <summary>
        /// Gets and sets the property Ec2KeyName. 
        /// <para>
        /// The name of the Amazon EC2 key pair to use when connecting with SSH into the master
        /// node as a user named "hadoop".
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
        /// Set this parameter to the identifier of the Amazon VPC subnet where you want the cluster
        /// to launch. If you do not specify this value, and your account supports EC2-Classic,
        /// the cluster launches in EC2-Classic.
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
        /// The identifier of the Amazon EC2 security group for the core and task nodes.
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
        /// Gets and sets the property IamInstanceProfile. 
        /// <para>
        /// The IAM role that was specified when the cluster was launched. The Amazon EC2 instances
        /// of the cluster assume this role.
        /// </para>
        /// </summary>
        public string IamInstanceProfile
        {
            get { return this._iamInstanceProfile; }
            set { this._iamInstanceProfile = value; }
        }

        // Check to see if IamInstanceProfile property is set
        internal bool IsSetIamInstanceProfile()
        {
            return this._iamInstanceProfile != null;
        }

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
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> RequestedEc2AvailabilityZones
        {
            get { return this._requestedEc2AvailabilityZones; }
            set { this._requestedEc2AvailabilityZones = value; }
        }

        // Check to see if RequestedEc2AvailabilityZones property is set
        internal bool IsSetRequestedEc2AvailabilityZones()
        {
            return this._requestedEc2AvailabilityZones != null && (this._requestedEc2AvailabilityZones.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

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
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> RequestedEc2SubnetIds
        {
            get { return this._requestedEc2SubnetIds; }
            set { this._requestedEc2SubnetIds = value; }
        }

        // Check to see if RequestedEc2SubnetIds property is set
        internal bool IsSetRequestedEc2SubnetIds()
        {
            return this._requestedEc2SubnetIds != null && (this._requestedEc2SubnetIds.Count > 0 || !AWSConfigs.InitializeCollections); 
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

    }
}