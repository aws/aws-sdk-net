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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.StorageGateway.Model
{
    /// <summary>
    /// A list of Active Directory users and groups that have special permissions for SMB
    /// file shares on the gateway.
    /// </summary>
    public partial class SMBLocalGroups
    {
        private List<string> _gatewayAdmins = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property GatewayAdmins. 
        /// <para>
        /// A list of Active Directory users and groups that have local Gateway Admin permissions.
        /// Acceptable formats include: <c>DOMAIN\User1</c>, <c>user1</c>, <c>DOMAIN\group1</c>,
        /// and <c>group1</c>.
        /// </para>
        ///  
        /// <para>
        /// Gateway Admins can use the Shared Folders Microsoft Management Console snap-in to
        /// force-close files that are open and locked.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._gatewayAdmins != null && (this._gatewayAdmins.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}