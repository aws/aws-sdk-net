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
 * Do not modify this file. This file is generated from the memorydb-2021-01-01.normal.json service model.
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
namespace Amazon.MemoryDB.Model
{
    /// <summary>
    /// Represents a single security group and its status.
    /// </summary>
    public partial class SecurityGroupMembership
    {
        private string _securityGroupId;
        private string _status;

        /// <summary>
        /// Gets and sets the property SecurityGroupId. 
        /// <para>
        /// The identifier of the security group.
        /// </para>
        /// </summary>
        public string SecurityGroupId
        {
            get { return this._securityGroupId; }
            set { this._securityGroupId = value; }
        }

        // Check to see if SecurityGroupId property is set
        internal bool IsSetSecurityGroupId()
        {
            return this._securityGroupId != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the security group membership. The status changes whenever a security
        /// group is modified, or when the security groups assigned to a cluster are modified.
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