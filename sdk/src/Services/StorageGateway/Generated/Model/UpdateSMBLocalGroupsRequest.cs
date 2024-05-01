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
    /// Container for the parameters to the UpdateSMBLocalGroups operation.
    /// Updates the list of Active Directory users and groups that have special permissions
    /// for SMB file shares on the gateway.
    /// </summary>
    public partial class UpdateSMBLocalGroupsRequest : AmazonStorageGatewayRequest
    {
        private string _gatewayARN;
        private SMBLocalGroups _smbLocalGroups;

        /// <summary>
        /// Gets and sets the property GatewayARN.
        /// </summary>
        [AWSProperty(Required=true, Min=50, Max=500)]
        public string GatewayARN
        {
            get { return this._gatewayARN; }
            set { this._gatewayARN = value; }
        }

        // Check to see if GatewayARN property is set
        internal bool IsSetGatewayARN()
        {
            return this._gatewayARN != null;
        }

        /// <summary>
        /// Gets and sets the property SMBLocalGroups. 
        /// <para>
        /// A list of Active Directory users and groups that you want to grant special permissions
        /// for SMB file shares on the gateway.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public SMBLocalGroups SMBLocalGroups
        {
            get { return this._smbLocalGroups; }
            set { this._smbLocalGroups = value; }
        }

        // Check to see if SMBLocalGroups property is set
        internal bool IsSetSMBLocalGroups()
        {
            return this._smbLocalGroups != null;
        }

    }
}