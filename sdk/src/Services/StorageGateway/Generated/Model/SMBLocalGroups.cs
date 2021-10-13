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
 * Do not modify this file. This file is generated from the storagegateway-2013-06-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.StorageGateway.Model
{
    /// <summary>
    /// A list of Active Directory users and groups that have special permissions for SMB
    /// file shares on the gateway.
    /// </summary>
    public partial class SMBLocalGroups
    {
        private List<string> _gatewayAdmins = new List<string>();

        /// <summary>
        /// Gets and sets the property GatewayAdmins. 
        /// <para>
        /// A list of Active Directory users and groups that have local Gateway Admin permissions.
        /// Acceptable formats include: <code>DOMAIN\User1</code>, <code>user1</code>, <code>DOMAIN\group1</code>,
        /// and <code>group1</code>.
        /// </para>
        ///  
        /// <para>
        /// Gateway Admins can use the Shared Folders Microsoft Management Console snap-in to
        /// force-close files that are open and locked.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public List<string> GatewayAdmins
        {
            get { return this._gatewayAdmins; }
            set { this._gatewayAdmins = value; }
        }

        // Check to see if GatewayAdmins property is set
        internal bool IsSetGatewayAdmins()
        {
            return this._gatewayAdmins != null && this._gatewayAdmins.Count > 0; 
        }

    }
}