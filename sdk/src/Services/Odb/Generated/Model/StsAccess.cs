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
 * Do not modify this file. This file is generated from the odb-2024-08-20.normal.json service model.
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
namespace Amazon.Odb.Model
{
    /// <summary>
    /// Configuration for Amazon Web Services Security Token Service (STS) access from the
    /// ODB network.
    /// </summary>
    public partial class StsAccess
    {
        private string _domainName;
        private List<string> _ipv4Addresses = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private ManagedResourceStatus _status;
        private string _stsPolicyDocument;

        /// <summary>
        /// Gets and sets the property DomainName. 
        /// <para>
        /// The domain name for STS access configuration.
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
        /// Gets and sets the property Ipv4Addresses. 
        /// <para>
        /// The IPv4 addresses allowed for STS access.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public List<string> Ipv4Addresses
        {
            get { return this._ipv4Addresses; }
            set { this._ipv4Addresses = value; }
        }

        // Check to see if Ipv4Addresses property is set
        internal bool IsSetIpv4Addresses()
        {
            return this._ipv4Addresses != null && (this._ipv4Addresses.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the STS access configuration.
        /// </para>
        /// </summary>
        public ManagedResourceStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property StsPolicyDocument. 
        /// <para>
        /// The STS policy document that defines permissions for token service usage.
        /// </para>
        /// </summary>
        public string StsPolicyDocument
        {
            get { return this._stsPolicyDocument; }
            set { this._stsPolicyDocument = value; }
        }

        // Check to see if StsPolicyDocument property is set
        internal bool IsSetStsPolicyDocument()
        {
            return this._stsPolicyDocument != null;
        }

    }
}