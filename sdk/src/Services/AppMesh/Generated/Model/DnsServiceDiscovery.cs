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
 * Do not modify this file. This file is generated from the appmesh-2019-01-25.normal.json service model.
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
namespace Amazon.AppMesh.Model
{
    /// <summary>
    /// An object that represents the DNS service discovery information for your virtual node.
    /// </summary>
    public partial class DnsServiceDiscovery
    {
        private string _hostname;
        private IpPreference _ipPreference;
        private DnsResponseType _responseType;

        /// <summary>
        /// Gets and sets the property Hostname. 
        /// <para>
        /// Specifies the DNS service discovery hostname for the virtual node. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Hostname
        {
            get { return this._hostname; }
            set { this._hostname = value; }
        }

        // Check to see if Hostname property is set
        internal bool IsSetHostname()
        {
            return this._hostname != null;
        }

        /// <summary>
        /// Gets and sets the property IpPreference. 
        /// <para>
        /// The preferred IP version that this virtual node uses. Setting the IP preference on
        /// the virtual node only overrides the IP preference set for the mesh on this specific
        /// node.
        /// </para>
        /// </summary>
        public IpPreference IpPreference
        {
            get { return this._ipPreference; }
            set { this._ipPreference = value; }
        }

        // Check to see if IpPreference property is set
        internal bool IsSetIpPreference()
        {
            return this._ipPreference != null;
        }

        /// <summary>
        /// Gets and sets the property ResponseType. 
        /// <para>
        /// Specifies the DNS response type for the virtual node.
        /// </para>
        /// </summary>
        public DnsResponseType ResponseType
        {
            get { return this._responseType; }
            set { this._responseType = value; }
        }

        // Check to see if ResponseType property is set
        internal bool IsSetResponseType()
        {
            return this._responseType != null;
        }

    }
}