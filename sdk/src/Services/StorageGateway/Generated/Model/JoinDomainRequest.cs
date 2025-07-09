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
    /// Container for the parameters to the JoinDomain operation.
    /// Adds a file gateway to an Active Directory domain. This operation is only supported
    /// for file gateways that support the SMB file protocol.
    /// 
    ///  <note> 
    /// <para>
    /// Joining a domain creates an Active Directory computer account in the default organizational
    /// unit, using the gateway's <b>Gateway ID</b> as the account name (for example, SGW-1234ADE).
    /// If your Active Directory environment requires that you pre-stage accounts to facilitate
    /// the join domain process, you will need to create this account ahead of time.
    /// </para>
    ///  
    /// <para>
    /// To create the gateway's computer account in an organizational unit other than the
    /// default, you must specify the organizational unit when joining the domain.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class JoinDomainRequest : AmazonStorageGatewayRequest
    {
        private List<string> _domainControllers = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _domainName;
        private string _gatewayARN;
        private string _organizationalUnit;
        private string _password;
        private int? _timeoutInSeconds;
        private string _userName;

        /// <summary>
        /// Gets and sets the property DomainControllers. 
        /// <para>
        /// List of IP addresses, NetBIOS names, or host names of your domain server. If you need
        /// to specify the port number include it after the colon (“:”). For example, <c>mydc.mydomain.com:389</c>.
        /// </para>
        ///  <note> 
        /// <para>
        /// S3 File Gateway supports IPv6 addresses in addition to IPv4 and other existing formats.
        /// </para>
        ///  
        /// <para>
        /// FSx File Gateway does not support IPv6.
        /// </para>
        ///  </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> DomainControllers
        {
            get { return this._domainControllers; }
            set { this._domainControllers = value; }
        }

        // Check to see if DomainControllers property is set
        internal bool IsSetDomainControllers()
        {
            return this._domainControllers != null && (this._domainControllers.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property DomainName. 
        /// <para>
        /// The name of the domain that you want the gateway to join.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1024)]
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
        /// <para>
        /// The Amazon Resource Name (ARN) of the gateway. Use the <c>ListGateways</c> operation
        /// to return a list of gateways for your account and Amazon Web Services Region.
        /// </para>
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
        /// Gets and sets the property OrganizationalUnit. 
        /// <para>
        /// The organizational unit (OU) is a container in an Active Directory that can hold users,
        /// groups, computers, and other OUs and this parameter specifies the OU that the gateway
        /// will join within the AD domain.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string OrganizationalUnit
        {
            get { return this._organizationalUnit; }
            set { this._organizationalUnit = value; }
        }

        // Check to see if OrganizationalUnit property is set
        internal bool IsSetOrganizationalUnit()
        {
            return this._organizationalUnit != null;
        }

        /// <summary>
        /// Gets and sets the property Password. 
        /// <para>
        /// Sets the password of the user who has permission to add the gateway to the Active
        /// Directory domain.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=1024)]
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
        /// Gets and sets the property TimeoutInSeconds. 
        /// <para>
        /// Specifies the time in seconds, in which the <c>JoinDomain</c> operation must complete.
        /// The default is 20 seconds.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=3600)]
        public int? TimeoutInSeconds
        {
            get { return this._timeoutInSeconds; }
            set { this._timeoutInSeconds = value; }
        }

        // Check to see if TimeoutInSeconds property is set
        internal bool IsSetTimeoutInSeconds()
        {
            return this._timeoutInSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UserName. 
        /// <para>
        /// Sets the user name of user who has permission to add the gateway to the Active Directory
        /// domain. The domain user account should be enabled to join computers to the domain.
        /// For example, you can use the domain administrator account or an account with delegated
        /// permissions to join computers to the domain.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1024)]
        public string UserName
        {
            get { return this._userName; }
            set { this._userName = value; }
        }

        // Check to see if UserName property is set
        internal bool IsSetUserName()
        {
            return this._userName != null;
        }

    }
}