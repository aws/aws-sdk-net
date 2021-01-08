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
 * Do not modify this file. This file is generated from the servicediscovery-2017-03-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ServiceDiscovery.Model
{
    /// <summary>
    /// A complex type that contains information that is specific to the namespace type.
    /// </summary>
    public partial class NamespaceProperties
    {
        private DnsProperties _dnsProperties;
        private HttpProperties _httpProperties;

        /// <summary>
        /// Gets and sets the property DnsProperties. 
        /// <para>
        /// A complex type that contains the ID for the Route 53 hosted zone that AWS Cloud Map
        /// creates when you create a namespace.
        /// </para>
        /// </summary>
        public DnsProperties DnsProperties
        {
            get { return this._dnsProperties; }
            set { this._dnsProperties = value; }
        }

        // Check to see if DnsProperties property is set
        internal bool IsSetDnsProperties()
        {
            return this._dnsProperties != null;
        }

        /// <summary>
        /// Gets and sets the property HttpProperties. 
        /// <para>
        /// A complex type that contains the name of an HTTP namespace.
        /// </para>
        /// </summary>
        public HttpProperties HttpProperties
        {
            get { return this._httpProperties; }
            set { this._httpProperties = value; }
        }

        // Check to see if HttpProperties property is set
        internal bool IsSetHttpProperties()
        {
            return this._httpProperties != null;
        }

    }
}