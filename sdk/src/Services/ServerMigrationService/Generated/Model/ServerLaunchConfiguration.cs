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
 * Do not modify this file. This file is generated from the sms-2016-10-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ServerMigrationService.Model
{
    /// <summary>
    /// Launch configuration for a server.
    /// </summary>
    public partial class ServerLaunchConfiguration
    {
        private bool? _associatePublicIpAddress;
        private string _ec2KeyName;
        private string _instanceType;
        private string _logicalId;
        private string _securityGroup;
        private Server _server;
        private string _subnet;
        private UserData _userData;
        private string _vpc;

        /// <summary>
        /// Gets and sets the property AssociatePublicIpAddress. 
        /// <para>
        /// If true, a publicly accessible IP address is created when launching the server.
        /// </para>
        /// </summary>
        public bool AssociatePublicIpAddress
        {
            get { return this._associatePublicIpAddress.GetValueOrDefault(); }
            set { this._associatePublicIpAddress = value; }
        }

        // Check to see if AssociatePublicIpAddress property is set
        internal bool IsSetAssociatePublicIpAddress()
        {
            return this._associatePublicIpAddress.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Ec2KeyName. 
        /// <para>
        /// Name of the EC2 SSH Key to be used for connecting to the launched server.
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
        /// Gets and sets the property InstanceType. 
        /// <para>
        /// Instance type to be used for launching the server.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property LogicalId. 
        /// <para>
        /// Logical ID of the server in the Amazon CloudFormation template.
        /// </para>
        /// </summary>
        public string LogicalId
        {
            get { return this._logicalId; }
            set { this._logicalId = value; }
        }

        // Check to see if LogicalId property is set
        internal bool IsSetLogicalId()
        {
            return this._logicalId != null;
        }

        /// <summary>
        /// Gets and sets the property SecurityGroup. 
        /// <para>
        /// Identifier of the security group that applies to the launched server.
        /// </para>
        /// </summary>
        public string SecurityGroup
        {
            get { return this._securityGroup; }
            set { this._securityGroup = value; }
        }

        // Check to see if SecurityGroup property is set
        internal bool IsSetSecurityGroup()
        {
            return this._securityGroup != null;
        }

        /// <summary>
        /// Gets and sets the property Server. 
        /// <para>
        /// Identifier of the server the launch configuration is associated with.
        /// </para>
        /// </summary>
        public Server Server
        {
            get { return this._server; }
            set { this._server = value; }
        }

        // Check to see if Server property is set
        internal bool IsSetServer()
        {
            return this._server != null;
        }

        /// <summary>
        /// Gets and sets the property Subnet. 
        /// <para>
        /// Identifier of the subnet the server should be launched into.
        /// </para>
        /// </summary>
        public string Subnet
        {
            get { return this._subnet; }
            set { this._subnet = value; }
        }

        // Check to see if Subnet property is set
        internal bool IsSetSubnet()
        {
            return this._subnet != null;
        }

        /// <summary>
        /// Gets and sets the property UserData. 
        /// <para>
        /// Location of the user-data script to be executed when launching the server.
        /// </para>
        /// </summary>
        public UserData UserData
        {
            get { return this._userData; }
            set { this._userData = value; }
        }

        // Check to see if UserData property is set
        internal bool IsSetUserData()
        {
            return this._userData != null;
        }

        /// <summary>
        /// Gets and sets the property Vpc. 
        /// <para>
        /// Identifier of the VPC the server should be launched into.
        /// </para>
        /// </summary>
        public string Vpc
        {
            get { return this._vpc; }
            set { this._vpc = value; }
        }

        // Check to see if Vpc property is set
        internal bool IsSetVpc()
        {
            return this._vpc != null;
        }

    }
}