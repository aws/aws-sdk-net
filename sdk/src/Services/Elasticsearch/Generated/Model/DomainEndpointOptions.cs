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
 * Do not modify this file. This file is generated from the es-2015-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Elasticsearch.Model
{
    /// <summary>
    /// Options to configure endpoint for the Elasticsearch domain.
    /// </summary>
    public partial class DomainEndpointOptions
    {
        private bool? _enforceHTTPS;
        private TLSSecurityPolicy _tlsSecurityPolicy;

        /// <summary>
        /// Gets and sets the property EnforceHTTPS. 
        /// <para>
        /// Specify if only HTTPS endpoint should be enabled for the Elasticsearch domain.
        /// </para>
        /// </summary>
        public bool EnforceHTTPS
        {
            get { return this._enforceHTTPS.GetValueOrDefault(); }
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
        /// Specify the TLS security policy that needs to be applied to the HTTPS endpoint of
        /// Elasticsearch domain. <br/> It can be one of the following values: <ul> <li><b>Policy-Min-TLS-1-0-2019-07:
        /// </b> TLS security policy which supports TLSv1.0 and higher.</li> <li><b>Policy-Min-TLS-1-2-2019-07:
        /// </b> TLS security policy which supports only TLSv1.2</li> </ul> 
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