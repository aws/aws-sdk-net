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
    /// An object that represents the service discovery information for a virtual node.
    /// </summary>
    public partial class ServiceDiscovery
    {
        private AwsCloudMapServiceDiscovery _awsCloudMap;
        private DnsServiceDiscovery _dns;

        /// <summary>
        /// Gets and sets the property AwsCloudMap. 
        /// <para>
        /// Specifies any Cloud Map information for the virtual node.
        /// </para>
        /// </summary>
        public AwsCloudMapServiceDiscovery AwsCloudMap
        {
            get { return this._awsCloudMap; }
            set { this._awsCloudMap = value; }
        }

        // Check to see if AwsCloudMap property is set
        internal bool IsSetAwsCloudMap()
        {
            return this._awsCloudMap != null;
        }

        /// <summary>
        /// Gets and sets the property Dns. 
        /// <para>
        /// Specifies the DNS information for the virtual node.
        /// </para>
        /// </summary>
        public DnsServiceDiscovery Dns
        {
            get { return this._dns; }
            set { this._dns = value; }
        }

        // Check to see if Dns property is set
        internal bool IsSetDns()
        {
            return this._dns != null;
        }

    }
}