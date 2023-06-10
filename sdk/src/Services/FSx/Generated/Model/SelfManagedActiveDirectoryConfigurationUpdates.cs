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
 * Do not modify this file. This file is generated from the fsx-2018-03-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.FSx.Model
{
    /// <summary>
    /// The configuration that Amazon FSx uses to join the Windows File Server instance to
    /// a self-managed Microsoft Active Directory (AD) directory.
    /// </summary>
    public partial class SelfManagedActiveDirectoryConfigurationUpdates
    {
        private List<string> _dnsIps = new List<string>();
        private string _password;
        private string _userName;

        /// <summary>
        /// Gets and sets the property DnsIps. 
        /// <para>
        /// A list of up to three IP addresses of DNS servers or domain controllers in the self-managed
        /// AD directory.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=3)]
        public List<string> DnsIps
        {
            get { return this._dnsIps; }
            set { this._dnsIps = value; }
        }

        // Check to see if DnsIps property is set
        internal bool IsSetDnsIps()
        {
            return this._dnsIps != null && this._dnsIps.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Password. 
        /// <para>
        /// The password for the service account on your self-managed AD domain that Amazon FSx
        /// will use to join to your AD domain.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=256)]
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
        /// Gets and sets the property UserName. 
        /// <para>
        /// The user name for the service account on your self-managed AD domain that Amazon FSx
        /// will use to join to your AD domain. This account must have the permission to join
        /// computers to the domain in the organizational unit provided in <code>OrganizationalUnitDistinguishedName</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
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