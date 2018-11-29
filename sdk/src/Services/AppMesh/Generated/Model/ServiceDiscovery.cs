/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the appmesh-2018-10-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AppMesh.Model
{
    /// <summary>
    /// An object representing the service discovery information for a virtual node.
    /// </summary>
    public partial class ServiceDiscovery
    {
        private DnsServiceDiscovery _dns;

        /// <summary>
        /// Gets and sets the property Dns. 
        /// <para>
        /// Specifies the DNS service name for the virtual node.
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