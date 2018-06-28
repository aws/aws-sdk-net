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
 * Do not modify this file. This file is generated from the storagegateway-2013-06-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.StorageGateway.Model
{
    /// <summary>
    /// This is the response object from the DescribeSMBSettings operation.
    /// </summary>
    public partial class DescribeSMBSettingsResponse : AmazonWebServiceResponse
    {
        private string _domainName;
        private string _gatewayARN;
        private bool? _smbGuestPasswordSet;

        /// <summary>
        /// Gets and sets the property DomainName. 
        /// <para>
        /// The name of the domain that the gateway is joined to.
        /// </para>
        /// </summary>
        public string DomainName
        {
            get { return this._domainName; }
            set { this._domainName = value; }
        }

        // Check to see if DomainName property is set
        internal bool IsSetDomainName()
        {
            return this._domainName != null;
        }

        /// <summary>
        /// Gets and sets the property GatewayARN.
        /// </summary>
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
        /// Gets and sets the property SMBGuestPasswordSet. 
        /// <para>
        /// This value is true if a password for the guest user “smbguest” is set, and otherwise
        /// false.
        /// </para>
        /// </summary>
        public bool SMBGuestPasswordSet
        {
            get { return this._smbGuestPasswordSet.GetValueOrDefault(); }
            set { this._smbGuestPasswordSet = value; }
        }

        // Check to see if SMBGuestPasswordSet property is set
        internal bool IsSetSMBGuestPasswordSet()
        {
            return this._smbGuestPasswordSet.HasValue; 
        }

    }
}