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
 * Do not modify this file. This file is generated from the opensearch-2021-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.OpenSearchService.Model
{
    /// <summary>
    /// Options to configure a custom endpoint for an OpenSearch Service domain.
    /// </summary>
    public partial class DomainEndpointOptions
    {
        private string _customEndpoint;
        private string _customEndpointCertificateArn;
        private bool? _customEndpointEnabled;
        private bool? _enforceHTTPS;
        private TLSSecurityPolicy _tlsSecurityPolicy;

        /// <summary>
        /// Gets and sets the property CustomEndpoint. 
        /// <para>
        /// The fully qualified URL for the custom endpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string CustomEndpoint
        {
            get { return this._customEndpoint; }
            set { this._customEndpoint = value; }
        }

        // Check to see if CustomEndpoint property is set
        internal bool IsSetCustomEndpoint()
        {
            return this._customEndpoint != null;
        }

        /// <summary>
        /// Gets and sets the property CustomEndpointCertificateArn. 
        /// <para>
        /// The ARN for your security certificate, managed in Amazon Web Services Certificate
        /// Manager (ACM).
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string CustomEndpointCertificateArn
        {
            get { return this._customEndpointCertificateArn; }
            set { this._customEndpointCertificateArn = value; }
        }

        // Check to see if CustomEndpointCertificateArn property is set
        internal bool IsSetCustomEndpointCertificateArn()
        {
            return this._customEndpointCertificateArn != null;
        }

        /// <summary>
        /// Gets and sets the property CustomEndpointEnabled. 
        /// <para>
        /// Whether to enable a custom endpoint for the domain.
        /// </para>
        /// </summary>
        public bool CustomEndpointEnabled
        {
            get { return this._customEndpointEnabled.GetValueOrDefault(); }
            set { this._customEndpointEnabled = value; }
        }

        // Check to see if CustomEndpointEnabled property is set
        internal bool IsSetCustomEndpointEnabled()
        {
            return this._customEndpointEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EnforceHTTPS. 
        /// <para>
        /// True to require that all traffic to the domain arrive over HTTPS.
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
        /// Specify the TLS security policy to apply to the HTTPS endpoint of the domain.
        /// </para>
        ///  
        /// <para>
        ///  Can be one of the following values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>Policy-Min-TLS-1-0-2019-07:</b> TLS security policy which supports TLS version
        /// 1.0 and higher.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Policy-Min-TLS-1-2-2019-07:</b> TLS security policy which supports only TLS version
        /// 1.2 
        /// </para>
        ///  </li> </ul>
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