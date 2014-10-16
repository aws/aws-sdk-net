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
 * Do not modify this file. This file is generated from the rds-2014-09-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.RDS.Model
{
    /// <summary>
    /// This data type is used as a response element in the following actions: 
    /// 
    ///  <ul> <li><a>AuthorizeDBSecurityGroupIngress</a></li> <li><a>DescribeDBSecurityGroups</a></li>
    /// <li><a>RevokeDBSecurityGroupIngress</a></li> </ul>
    /// </summary>
    public partial class EC2SecurityGroup
    {
        private string _eC2SecurityGroupId;
        private string _eC2SecurityGroupName;
        private string _eC2SecurityGroupOwnerId;
        private string _status;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public EC2SecurityGroup() { }

        /// <summary>
        /// Gets and sets the property EC2SecurityGroupId. 
        /// <para>
        ///  Specifies the id of the EC2 security group. 
        /// </para>
        /// </summary>
        public string EC2SecurityGroupId
        {
            get { return this._eC2SecurityGroupId; }
            set { this._eC2SecurityGroupId = value; }
        }

        // Check to see if EC2SecurityGroupId property is set
        internal bool IsSetEC2SecurityGroupId()
        {
            return this._eC2SecurityGroupId != null;
        }

        /// <summary>
        /// Gets and sets the property EC2SecurityGroupName. 
        /// <para>
        ///  Specifies the name of the EC2 security group. 
        /// </para>
        /// </summary>
        public string EC2SecurityGroupName
        {
            get { return this._eC2SecurityGroupName; }
            set { this._eC2SecurityGroupName = value; }
        }

        // Check to see if EC2SecurityGroupName property is set
        internal bool IsSetEC2SecurityGroupName()
        {
            return this._eC2SecurityGroupName != null;
        }

        /// <summary>
        /// Gets and sets the property EC2SecurityGroupOwnerId. 
        /// <para>
        ///  Specifies the AWS ID of the owner of the EC2 security group specified in the <code>EC2SecurityGroupName</code>
        /// field. 
        /// </para>
        /// </summary>
        public string EC2SecurityGroupOwnerId
        {
            get { return this._eC2SecurityGroupOwnerId; }
            set { this._eC2SecurityGroupOwnerId = value; }
        }

        // Check to see if EC2SecurityGroupOwnerId property is set
        internal bool IsSetEC2SecurityGroupOwnerId()
        {
            return this._eC2SecurityGroupOwnerId != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        ///  Provides the status of the EC2 security group. Status can be "authorizing", "authorized",
        /// "revoking", and "revoked". 
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