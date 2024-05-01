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
    /// Information about additional options for the domain endpoint.
    /// </summary>
    public partial class AwsOpenSearchServiceDomainDomainEndpointOptionsDetails
    {
        private string _customEndpoint;
        private string _customEndpointCertificateArn;
        private bool? _customEndpointEnabled;
        private bool? _enforceHTTPS;
        private string _tlsSecurityPolicy;

        /// <summary>
        /// Gets and sets the property CustomEndpoint. 
        /// <para>
        /// The fully qualified URL for the custom endpoint.
        /// </para>
        /// </summary>
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
        /// The ARN for the security certificate. The certificate is managed in ACM.
        /// </para>
        /// </summary>
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
        public bool? CustomEndpointEnabled
        {
            get { return this._customEndpointEnabled; }
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