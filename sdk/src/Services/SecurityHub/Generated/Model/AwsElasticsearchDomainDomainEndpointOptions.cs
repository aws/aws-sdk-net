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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
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
namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Additional options for the domain endpoint, such as whether to require HTTPS for all
    /// traffic.
    /// </summary>
    public partial class AwsElasticsearchDomainDomainEndpointOptions
    {
        private bool? _enforceHTTPS;
        private string _tlsSecurityPolicy;

        /// <summary>
        /// Gets and sets the property EnforceHTTPS. 
        /// <para>
        /// Whether to require that all traffic to the domain arrive over HTTPS.
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
        /// The TLS security policy to apply to the HTTPS endpoint of the OpenSearch domain.
        /// </para>
        ///  
        /// <para>
        /// Valid values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>Policy-Min-TLS-1-0-2019-07</c>, which supports TLSv1.0 and higher
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Policy-Min-TLS-1-2-2019-07</c>, which only supports TLSv1.2
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string TLSSecurityPolicy
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