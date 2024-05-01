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
 * Do not modify this file. This file is generated from the cloudsearch-2013-01-01.normal.json service model.
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
namespace Amazon.CloudSearch.Model
{
    /// <summary>
    /// The domain's endpoint options.
    /// </summary>
    public partial class DomainEndpointOptions
    {
        private bool? _enforceHTTPS;
        private TLSSecurityPolicy _tlsSecurityPolicy;

        /// <summary>
        /// Gets and sets the property EnforceHTTPS. 
        /// <para>
        /// Whether the domain is HTTPS only enabled.
        /// </para>
        /// </summary>
        public bool? EnforceHTTPS
        {
            get { return this._enforceHTTPS; }
            set { this._enforceHTTPS = value; }
        }

        // Check to see if EnforceHTTPS property is set
        internal bool IsSetEnforceHTTPS()
        {
            return this._enforceHTTPS.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TLSSecurityPolicy. 
        /// <para>
        /// The minimum required TLS version
        /// </para>
        /// </summary>
        public TLSSecurityPolicy TLSSecurityPolicy
        {
            get { return this._tlsSecurityPolicy; }
            set { this._tlsSecurityPolicy = value; }
        }

        // Check to see if TLSSecurityPolicy property is set
        internal bool IsSetTLSSecurityPolicy()
        {
            return this._tlsSecurityPolicy != null;
        }

    }
}