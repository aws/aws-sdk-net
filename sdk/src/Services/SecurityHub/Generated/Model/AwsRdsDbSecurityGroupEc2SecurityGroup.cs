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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
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
namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// EC2 security group information for an RDS DB security group.
    /// </summary>
    public partial class AwsRdsDbSecurityGroupEc2SecurityGroup
    {
        private string _ec2SecurityGroupId;
        private string _ec2SecurityGroupName;
        private string _ec2SecurityGroupOwnerId;
        private string _status;

        /// <summary>
        /// Gets and sets the property Ec2SecurityGroupId. 
        /// <para>
        /// Specifies the ID for the EC2 security group.
        /// </para>
        /// </summary>
        public string Ec2SecurityGroupId
        {
            get { return this._ec2SecurityGroupId; }
            set { this._ec2SecurityGroupId = value; }
        }

        // Check to see if Ec2SecurityGroupId property is set
        internal bool IsSetEc2SecurityGroupId()
        {
            return this._ec2SecurityGroupId != null;
        }

        /// <summary>
        /// Gets and sets the property Ec2SecurityGroupName. 
        /// <para>
        /// Specifies the name of the EC2 security group.
        /// </para>
        /// </summary>
        public string Ec2SecurityGroupName
        {
            get { return this._ec2SecurityGroupName; }
            set { this._ec2SecurityGroupName = value; }
        }

        // Check to see if Ec2SecurityGroupName property is set
        internal bool IsSetEc2SecurityGroupName()
        {
            return this._ec2SecurityGroupName != null;
        }

        /// <summary>
        /// Gets and sets the property Ec2SecurityGroupOwnerId. 
        /// <para>
        /// Provides the Amazon Web Services ID of the owner of the EC2 security group.
        /// </para>
        /// </summary>
        public string Ec2SecurityGroupOwnerId
        {
            get { return this._ec2SecurityGroupOwnerId; }
            set { this._ec2SecurityGroupOwnerId = value; }
        }

        // Check to see if Ec2SecurityGroupOwnerId property is set
        internal bool IsSetEc2SecurityGroupOwnerId()
        {
            return this._ec2SecurityGroupOwnerId != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Provides the status of the EC2 security group.
        /// </para>
        /// </summary>
        public string Status
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