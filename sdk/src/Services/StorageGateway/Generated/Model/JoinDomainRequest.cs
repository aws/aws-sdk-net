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
    /// Container for the parameters to the JoinDomain operation.
    /// Adds a file gateway to an Active Directory domain. This operation is only supported
    /// for file gateways that support the SMB file protocol.
    /// </summary>
    public partial class JoinDomainRequest : AmazonStorageGatewayRequest
    {
        private List<string> _domainControllers = new List<string>();
        private string _domainName;
        private string _gatewayARN;
        private string _organizationalUnit;
        private string _password;
        private int? _timeoutInSeconds;
        private string _userName;

        /// <summary>
        /// Gets and sets the property DomainControllers. 
        /// <para>
        /// List of IPv4 addresses, NetBIOS names, or host names of your domain server. If you
        /// need to specify the port number include it after the colon (“:”). For example, <code>mydc.mydomain.com:389</code>.
        /// </para>
        /// </summary>
        public List<string> DomainControllers
        {
            get { return this._domainControllers; }
            set { this._domainControllers = value; }
        }

        // Check to see if DomainControllers property is set
        internal bool IsSetDomainControllers()
        {
            return this._domainControllers != null && this._domainControllers.Count > 0; 
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
        /// The Amazon Resource Name (ARN) of the gateway. Use the <code>ListGateways</code> operation
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
        /// Specifies the time in seconds, in which the <code>JoinDomain</code> operation must
        /// complete. The default is 20 seconds.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=3600)]
        public int TimeoutInSeconds
        {
            get { return this._timeoutInSeconds.GetValueOrDefault(); }
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