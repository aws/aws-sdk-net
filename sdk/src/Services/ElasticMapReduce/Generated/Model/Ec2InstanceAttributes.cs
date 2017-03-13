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
    /// Provides information about the EC2 instances in a cluster grouped by category. For
    /// example, key name, subnet ID, IAM instance profile, and so on.
    /// </summary>
    public partial class Ec2InstanceAttributes
    {
        private List<string> _additionalMasterSecurityGroups = new List<string>();
        private List<string> _additionalSlaveSecurityGroups = new List<string>();
        private string _ec2AvailabilityZone;
        private string _ec2KeyName;
        private string _ec2SubnetId;
        private string _emrManagedMasterSecurityGroup;
        private string _emrManagedSlaveSecurityGroup;
        private string _iamInstanceProfile;
        private List<string> _requestedEc2AvailabilityZones = new List<string>();
        private List<string> _requestedEc2SubnetIds = new List<string>();
        private string _serviceAccessSecurityGroup;

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
        /// To launch the cluster in Amazon VPC, set this parameter to the identifier of the Amazon
        /// VPC subnet where you want the cluster to launch. If you do not specify this value,
        /// the cluster is launched in the normal AWS cloud, outside of a VPC.
        /// </para>
        ///  
        /// <para>
        /// Amazon VPC currently does not support cluster compute quadruple extra large (cc1.4xlarge)
        /// instances. Thus, you cannot specify the cc1.4xlarge instance type for nodes of a cluster
        /// launched in a VPC.
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
        /// Gets and sets the property IamInstanceProfile. 
        /// <para>
        /// The IAM role that was specified when the cluster was launched. The EC2 instances of
        /// the cluster assume this role.
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
        /// Applies to clusters configured with the The list of availability zones to choose from.
        /// The service will choose the availability zone with the best mix of available capacity
        /// and lowest cost to launch the cluster. If you do not specify this value, the cluster
        /// is launched in any availability zone that the customer account has access to.
        /// </para>
        /// </summary>
        public List<string> RequestedEc2AvailabilityZones
        {
            get { return this._requestedEc2AvailabilityZones; }
            set { this._requestedEc2AvailabilityZones = value; }
        }

        // Check to see if RequestedEc2AvailabilityZones property is set
        internal bool IsSetRequestedEc2AvailabilityZones()
        {
            return this._requestedEc2AvailabilityZones != null && this._requestedEc2AvailabilityZones.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property RequestedEc2SubnetIds. 
        /// <para>
        /// Applies to clusters configured with the instance fleets option. Specifies the unique
        /// identifier of one or more Amazon EC2 subnets in which to launch EC2 cluster instances.
        /// Amazon EMR chooses the EC2 subnet with the best performance and cost characteristics
        /// from among the list of RequestedEc2SubnetIds and launches all cluster instances within
        /// that subnet. If this value is not specified, and the account supports EC2-Classic
        /// networks, the cluster launches instances in the EC2-Classic network and uses Requested
        /// </para>
        /// </summary>
        public List<string> RequestedEc2SubnetIds
        {
            get { return this._requestedEc2SubnetIds; }
            set { this._requestedEc2SubnetIds = value; }
        }

        // Check to see if RequestedEc2SubnetIds property is set
        internal bool IsSetRequestedEc2SubnetIds()
        {
            return this._requestedEc2SubnetIds != null && this._requestedEc2SubnetIds.Count > 0; 
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