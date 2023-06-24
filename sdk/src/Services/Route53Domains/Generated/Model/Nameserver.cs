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
 * Do not modify this file. This file is generated from the route53domains-2014-05-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Route53Domains.Model
{
    /// <summary>
    /// Name server includes the following elements.
    /// </summary>
    public partial class Nameserver
    {
        private List<string> _glueIps = new List<string>();
        private string _name;

        /// <summary>
        /// Gets and sets the property GlueIps. 
        /// <para>
        /// Glue IP address of a name server entry. Glue IP addresses are required only when the
        /// name of the name server is a subdomain of the domain. For example, if your domain
        /// is example.com and the name server for the domain is ns.example.com, you need to specify
        /// the IP address for ns.example.com.
        /// </para>
        ///  
        /// <para>
        /// Constraints: The list can contain only one IPv4 and one IPv6 address.
        /// </para>
        /// </summary>
        public List<string> GlueIps
        {
            get { return this._glueIps; }
            set { this._glueIps = value; }
        }

        // Check to see if GlueIps property is set
        internal bool IsSetGlueIps()
        {
            return this._glueIps != null && this._glueIps.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The fully qualified host name of the name server.
        /// </para>
        ///  
        /// <para>
        /// Constraint: Maximum 255 characters
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=255)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

    }
}