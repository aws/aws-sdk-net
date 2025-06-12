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
 * Do not modify this file. This file is generated from the lightsail-2016-11-28.normal.json service model.
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
namespace Amazon.Lightsail.Model
{
    /// <summary>
    /// The parameters for gaining temporary access to one of your Amazon Lightsail instances.
    /// </summary>
    public partial class InstanceAccessDetails
    {
        private string _certKey;
        private DateTime? _expiresAt;
        private List<HostKeyAttributes> _hostKeys = AWSConfigs.InitializeCollections ? new List<HostKeyAttributes>() : null;
        private string _instanceName;
        private string _ipAddress;
        private List<string> _ipv6Addresses = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _password;
        private PasswordData _passwordData;
        private string _privateKey;
        private InstanceAccessProtocol _protocol;
        private string _username;

        /// <summary>
        /// Gets and sets the property CertKey. 
        /// <para>
        /// For SSH access, the public key to use when accessing your instance For OpenSSH clients
        /// (command line SSH), you should save this value to <c>tempkey-cert.pub</c>.
        /// </para>
        /// </summary>
        public string CertKey
        {
            get { return this._certKey; }
            set { this._certKey = value; }
        }

        // Check to see if CertKey property is set
        internal bool IsSetCertKey()
        {
            return this._certKey != null;
        }

        /// <summary>
        /// Gets and sets the property ExpiresAt. 
        /// <para>
        /// For SSH access, the date on which the temporary keys expire.
        /// </para>
        /// </summary>
        public DateTime? ExpiresAt
        {
            get { return this._expiresAt; }
            set { this._expiresAt = value; }
        }

        // Check to see if ExpiresAt property is set
        internal bool IsSetExpiresAt()
        {
            return this._expiresAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property HostKeys. 
        /// <para>
        /// Describes the public SSH host keys or the RDP certificate.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<HostKeyAttributes> HostKeys
        {
            get { return this._hostKeys; }
            set { this._hostKeys = value; }
        }

        // Check to see if HostKeys property is set
        internal bool IsSetHostKeys()
        {
            return this._hostKeys != null && (this._hostKeys.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property InstanceName. 
        /// <para>
        /// The name of this Amazon Lightsail instance.
        /// </para>
        /// </summary>
        public string InstanceName
        {
            get { return this._instanceName; }
            set { this._instanceName = value; }
        }

        // Check to see if InstanceName property is set
        internal bool IsSetInstanceName()
        {
            return this._instanceName != null;
        }

        /// <summary>
        /// Gets and sets the property IpAddress. 
        /// <para>
        /// The public IP address of the Amazon Lightsail instance.
        /// </para>
        /// </summary>
        public string IpAddress
        {
            get { return this._ipAddress; }
            set { this._ipAddress = value; }
        }

        // Check to see if IpAddress property is set
        internal bool IsSetIpAddress()
        {
            return this._ipAddress != null;
        }

        /// <summary>
        /// Gets and sets the property Ipv6Addresses. 
        /// <para>
        /// The IPv6 address of the Amazon Lightsail instance.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Ipv6Addresses
        {
            get { return this._ipv6Addresses; }
            set { this._ipv6Addresses = value; }
        }

        // Check to see if Ipv6Addresses property is set
        internal bool IsSetIpv6Addresses()
        {
            return this._ipv6Addresses != null && (this._ipv6Addresses.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Password. 
        /// <para>
        /// For RDP access, the password for your Amazon Lightsail instance. Password will be
        /// an empty string if the password for your new instance is not ready yet. When you create
        /// an instance, it can take up to 15 minutes for the instance to be ready.
        /// </para>
        ///  <note> 
        /// <para>
        /// If you create an instance using any key pair other than the default (<c>LightsailDefaultKeyPair</c>),
        /// <c>password</c> will always be an empty string.
        /// </para>
        ///  
        /// <para>
        /// If you change the Administrator password on the instance, Lightsail will continue
        /// to return the original password value. When accessing the instance using RDP, you
        /// need to manually enter the Administrator password after changing it from the default.
        /// </para>
        ///  </note>
        /// </summary>
        public string Password
        {
            get { return this._password; }
            set { this._password = value; }
        }

        // Check to see if Password property is set
        internal bool IsSetPassword()
        {
            return this._password != null;
        }

        /// <summary>
        /// Gets and sets the property PasswordData. 
        /// <para>
        /// For a Windows Server-based instance, an object with the data you can use to retrieve
        /// your password. This is only needed if <c>password</c> is empty and the instance is
        /// not new (and therefore the password is not ready yet). When you create an instance,
        /// it can take up to 15 minutes for the instance to be ready.
        /// </para>
        /// </summary>
        public PasswordData PasswordData
        {
            get { return this._passwordData; }
            set { this._passwordData = value; }
        }

        // Check to see if PasswordData property is set
        internal bool IsSetPasswordData()
        {
            return this._passwordData != null;
        }

        /// <summary>
        /// Gets and sets the property PrivateKey. 
        /// <para>
        /// For SSH access, the temporary private key. For OpenSSH clients (command line SSH),
        /// you should save this value to <c>tempkey</c>).
        /// </para>
        /// </summary>
        public string PrivateKey
        {
            get { return this._privateKey; }
            set { this._privateKey = value; }
        }

        // Check to see if PrivateKey property is set
        internal bool IsSetPrivateKey()
        {
            return this._privateKey != null;
        }

        /// <summary>
        /// Gets and sets the property Protocol. 
        /// <para>
        /// The protocol for these Amazon Lightsail instance access details.
        /// </para>
        /// </summary>
        public InstanceAccessProtocol Protocol
        {
            get { return this._protocol; }
            set { this._protocol = value; }
        }

        // Check to see if Protocol property is set
        internal bool IsSetProtocol()
        {
            return this._protocol != null;
        }

        /// <summary>
        /// Gets and sets the property Username. 
        /// <para>
        /// The user name to use when logging in to the Amazon Lightsail instance.
        /// </para>
        /// </summary>
        public string Username
        {
            get { return this._username; }
            set { this._username = value; }
        }

        // Check to see if Username property is set
        internal bool IsSetUsername()
        {
            return this._username != null;
        }

    }
}