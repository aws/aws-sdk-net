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
 * Do not modify this file. This file is generated from the lightsail-2016-11-28.normal.json service model.
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
namespace Amazon.Lightsail.Model
{
    /// <summary>
    /// Returns information that was submitted during the <c>SetupInstanceHttps</c> request.
    /// Email information is redacted for privacy.
    /// </summary>
    public partial class SetupRequest
    {
        private CertificateProvider _certificateProvider;
        private List<string> _domainNames = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _instanceName;

        /// <summary>
        /// Gets and sets the property CertificateProvider. 
        /// <para>
        /// The Certificate Authority (CA) that issues the SSL/TLS certificate.
        /// </para>
        /// </summary>
        public CertificateProvider CertificateProvider
        {
            get { return this._certificateProvider; }
            set { this._certificateProvider = value; }
        }

        // Check to see if CertificateProvider property is set
        internal bool IsSetCertificateProvider()
        {
            return this._certificateProvider != null;
        }

        /// <summary>
        /// Gets and sets the property DomainNames. 
        /// <para>
        /// The name of the domain and subdomains that the SSL/TLS certificate secures.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<string> DomainNames
        {
            get { return this._domainNames; }
            set { this._domainNames = value; }
        }

        // Check to see if DomainNames property is set
        internal bool IsSetDomainNames()
        {
            return this._domainNames != null && (this._domainNames.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property InstanceName. 
        /// <para>
        /// The name of the Lightsail instance.
        /// </para>
        /// </summary>
        public string InstanceName
        {
            get { return this._instanceName; }
            set { this._instanceName = value; }
        }

        // Check to see if InstanceName property is set
        internal bool IsSetInstanceName()
        {
            return this._instanceName != null;
        }

    }
}