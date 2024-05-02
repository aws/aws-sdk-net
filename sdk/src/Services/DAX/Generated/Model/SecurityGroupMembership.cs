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
 * Do not modify this file. This file is generated from the dax-2017-04-19.normal.json service model.
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
namespace Amazon.DAX.Model
{
    /// <summary>
    /// An individual VPC security group and its status.
    /// </summary>
    public partial class SecurityGroupMembership
    {
        private string _securityGroupIdentifier;
        private string _status;

        /// <summary>
        /// Gets and sets the property SecurityGroupIdentifier. 
        /// <para>
        /// The unique ID for this security group.
        /// </para>
        /// </summary>
        public string SecurityGroupIdentifier
        {
            get { return this._securityGroupIdentifier; }
            set { this._securityGroupIdentifier = value; }
        }

        // Check to see if SecurityGroupIdentifier property is set
        internal bool IsSetSecurityGroupIdentifier()
        {
            return this._securityGroupIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of this security group.
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