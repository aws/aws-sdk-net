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

namespace Amazon.AppMesh.Model
{
    /// <summary>
    /// An object that represents the DNS service discovery information for your virtual node.
    /// </summary>
    public partial class DnsServiceDiscovery
    {
        /// <summary>
        /// Gets and sets the property Hostname. 
        /// <para>
        /// Specifies the DNS service discovery hostname for the virtual node. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Hostname { get; set; }

        /// <summary>
        /// Checks to see if the Hostname property is set.
        /// </summary>
        internal bool IsSetHostname() => this.Hostname != null;

        /// <summary>
        /// Gets and sets the property IpPreference. 
        /// <para>
        /// The preferred IP version that this virtual node uses. Setting the IP preference on
        /// the virtual node only overrides the IP preference set for the mesh on this specific
        /// node.
        /// </para>
        /// </summary>
        public IpPreference IpPreference { get; set; }

        /// <summary>
        /// Checks to see if the IpPreference property is set.
        /// </summary>
        internal bool IsSetIpPreference() => this.IpPreference != null;

        /// <summary>
        /// Gets and sets the property ResponseType. 
        /// <para>
        /// Specifies the DNS response type for the virtual node.
        /// </para>
        /// </summary>
        public DnsResponseType ResponseType { get; set; }

        /// <summary>
        /// Checks to see if the ResponseType property is set.
        /// </summary>
        internal bool IsSetResponseType() => this.ResponseType != null;
    }
}
