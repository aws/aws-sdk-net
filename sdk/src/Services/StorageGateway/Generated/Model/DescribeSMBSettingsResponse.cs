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
    /// This is the response object from the DescribeSMBSettings operation.
    /// </summary>
    public partial class DescribeSMBSettingsResponse : AmazonWebServiceResponse
    {
        private ActiveDirectoryStatus _activeDirectoryStatus;
        private string _domainName;
        private bool? _fileSharesVisible;
        private string _gatewayARN;
        private bool? _smbGuestPasswordSet;
        private SMBSecurityStrategy _smbSecurityStrategy;

        /// <summary>
        /// Gets and sets the property ActiveDirectoryStatus. 
        /// <para>
        /// Indicates the status of a gateway that is a member of the Active Directory domain.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>ACCESS_DENIED</code>: Indicates that the <code>JoinDomain</code> operation
        /// failed due to an authentication error.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>DETACHED</code>: Indicates that gateway is not joined to a domain.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>JOINED</code>: Indicates that the gateway has successfully joined a domain.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>JOINING</code>: Indicates that a <code>JoinDomain</code> operation is in progress.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>NETWORK_ERROR</code>: Indicates that <code>JoinDomain</code> operation failed
        /// due to a network or connectivity error.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>TIMEOUT</code>: Indicates that the <code>JoinDomain</code> operation failed
        /// because the operation didn't complete within the allotted time.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>UNKNOWN_ERROR</code>: Indicates that the <code>JoinDomain</code> operation
        /// failed due to another type of error.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ActiveDirectoryStatus ActiveDirectoryStatus
        {
            get { return this._activeDirectoryStatus; }
            set { this._activeDirectoryStatus = value; }
        }

        // Check to see if ActiveDirectoryStatus property is set
        internal bool IsSetActiveDirectoryStatus()
        {
            return this._activeDirectoryStatus != null;
        }

        /// <summary>
        /// Gets and sets the property DomainName. 
        /// <para>
        /// The name of the domain that the gateway is joined to.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
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
        /// Gets and sets the property FileSharesVisible. 
        /// <para>
        /// The shares on this gateway appear when listing shares.
        /// </para>
        /// </summary>
        public bool FileSharesVisible
        {
            get { return this._fileSharesVisible.GetValueOrDefault(); }
            set { this._fileSharesVisible = value; }
        }

        // Check to see if FileSharesVisible property is set
        internal bool IsSetFileSharesVisible()
        {
            return this._fileSharesVisible.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property GatewayARN.
        /// </summary>
        [AWSProperty(Min=50, Max=500)]
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
        /// This value is <code>true</code> if a password for the guest user <code>smbguest</code>
        /// is set, otherwise <code>false</code>.
        /// </para>
        ///  
        /// <para>
        /// Valid Values: <code>true</code> | <code>false</code> 
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

        /// <summary>
        /// Gets and sets the property SMBSecurityStrategy. 
        /// <para>
        /// The type of security strategy that was specified for file gateway.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>ClientSpecified</code>: If you use this option, requests are established based
        /// on what is negotiated by the client. This option is recommended when you want to maximize
        /// compatibility across different clients in your environment.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>MandatorySigning</code>: If you use this option, file gateway only allows connections
        /// from SMBv2 or SMBv3 clients that have signing enabled. This option works with SMB
        /// clients on Microsoft Windows Vista, Windows Server 2008 or newer.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>MandatoryEncryption</code>: If you use this option, file gateway only allows
        /// connections from SMBv3 clients that have encryption enabled. This option is highly
        /// recommended for environments that handle sensitive data. This option works with SMB
        /// clients on Microsoft Windows 8, Windows Server 2012 or newer.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public SMBSecurityStrategy SMBSecurityStrategy
        {
            get { return this._smbSecurityStrategy; }
            set { this._smbSecurityStrategy = value; }
        }

        // Check to see if SMBSecurityStrategy property is set
        internal bool IsSetSMBSecurityStrategy()
        {
            return this._smbSecurityStrategy != null;
        }

    }
}