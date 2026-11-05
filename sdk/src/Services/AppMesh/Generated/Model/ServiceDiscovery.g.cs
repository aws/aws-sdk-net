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
    /// An object that represents the service discovery information for a virtual node.
    /// </summary>
    public partial class ServiceDiscovery
    {
        /// <summary>
        /// Gets and sets the property AwsCloudMap. 
        /// <para>
        /// Specifies any Cloud Map information for the virtual node.
        /// </para>
        /// </summary>
        public AwsCloudMapServiceDiscovery AwsCloudMap { get; set; }

        /// <summary>
        /// Checks to see if the AwsCloudMap property is set.
        /// </summary>
        internal bool IsSetAwsCloudMap() => this.AwsCloudMap != null;

        /// <summary>
        /// Gets and sets the property Dns. 
        /// <para>
        /// Specifies the DNS information for the virtual node.
        /// </para>
        /// </summary>
        public DnsServiceDiscovery Dns { get; set; }

        /// <summary>
        /// Checks to see if the Dns property is set.
        /// </summary>
        internal bool IsSetDns() => this.Dns != null;
    }
}
