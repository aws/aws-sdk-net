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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        /// <summary>
        /// Gets and sets the property CertKey. 
        /// <para>
        /// For SSH access, the public key to use when accessing your instance For OpenSSH clients
        /// (command line SSH), you should save this value to <c>tempkey-cert.pub</c>.
        /// </para>
        /// </summary>
        public string CertKey { get; set; }

        /// <summary>
        /// Checks to see if the CertKey property is set.
        /// </summary>
        internal bool IsSetCertKey() => this.CertKey != null;

        /// <summary>
        /// Gets and sets the property ExpiresAt. 
        /// <para>
        /// For SSH access, the date on which the temporary keys expire.
        /// </para>
        /// </summary>
        public DateTime? ExpiresAt { get; set; }

        /// <summary>
        /// Checks to see if the ExpiresAt property is set.
        /// </summary>
        internal bool IsSetExpiresAt() => this.ExpiresAt.HasValue;

        /// <summary>
        /// Gets and sets the property HostKeys. 
        /// <para>
        /// Describes the public SSH host keys or the RDP certificate.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<HostKeyAttributes> HostKeys { get; set; } = AWSConfigs.InitializeCollections ? new List<HostKeyAttributes>() : null;

        /// <summary>
        /// Checks to see if the HostKeys property is set.
        /// </summary>
        internal bool IsSetHostKeys() => this.HostKeys != null && (this.HostKeys.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property InstanceName. 
        /// <para>
        /// The name of this Amazon Lightsail instance.
        /// </para>
        /// </summary>
        public string InstanceName { get; set; }

        /// <summary>
        /// Checks to see if the InstanceName property is set.
        /// </summary>
        internal bool IsSetInstanceName() => this.InstanceName != null;

        /// <summary>
        /// Gets and sets the property IpAddress. 
        /// <para>
        /// The public IP address of the Amazon Lightsail instance.
        /// </para>
        /// </summary>
        public string IpAddress { get; set; }

        /// <summary>
        /// Checks to see if the IpAddress property is set.
        /// </summary>
        internal bool IsSetIpAddress() => this.IpAddress != null;

        /// <summary>
        /// Gets and sets the property Ipv6Addresses. 
        /// <para>
        /// The IPv6 address of the Amazon Lightsail instance.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Ipv6Addresses { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Ipv6Addresses property is set.
        /// </summary>
        internal bool IsSetIpv6Addresses() => this.Ipv6Addresses != null && (this.Ipv6Addresses.Count > 0 || !AWSConfigs.InitializeCollections);

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
        public string Password { get; set; }

        /// <summary>
        /// Checks to see if the Password property is set.
        /// </summary>
        internal bool IsSetPassword() => this.Password != null;

        /// <summary>
        /// Gets and sets the property PasswordData. 
        /// <para>
        /// For a Windows Server-based instance, an object with the data you can use to retrieve
        /// your password. This is only needed if <c>password</c> is empty and the instance is
        /// not new (and therefore the password is not ready yet). When you create an instance,
        /// it can take up to 15 minutes for the instance to be ready.
        /// </para>
        /// </summary>
        public PasswordData PasswordData { get; set; }

        /// <summary>
        /// Checks to see if the PasswordData property is set.
        /// </summary>
        internal bool IsSetPasswordData() => this.PasswordData != null;

        /// <summary>
        /// Gets and sets the property PrivateKey. 
        /// <para>
        /// For SSH access, the temporary private key. For OpenSSH clients (command line SSH),
        /// you should save this value to <c>tempkey</c>).
        /// </para>
        /// </summary>
        public string PrivateKey { get; set; }

        /// <summary>
        /// Checks to see if the PrivateKey property is set.
        /// </summary>
        internal bool IsSetPrivateKey() => this.PrivateKey != null;

        /// <summary>
        /// Gets and sets the property Protocol. 
        /// <para>
        /// The protocol for these Amazon Lightsail instance access details.
        /// </para>
        /// </summary>
        public InstanceAccessProtocol Protocol { get; set; }

        /// <summary>
        /// Checks to see if the Protocol property is set.
        /// </summary>
        internal bool IsSetProtocol() => this.Protocol != null;

        /// <summary>
        /// Gets and sets the property Username. 
        /// <para>
        /// The user name to use when logging in to the Amazon Lightsail instance.
        /// </para>
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        /// Checks to see if the Username property is set.
        /// </summary>
        internal bool IsSetUsername() => this.Username != null;
    }
}
