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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IoT.Model
{
    /// <summary>
    /// This is the response object from the DescribeDomainConfiguration operation.
    /// </summary>
    public partial class DescribeDomainConfigurationResponse : AmazonWebServiceResponse
    {
        private AuthorizerConfig _authorizerConfig;
        private string _domainConfigurationArn;
        private string _domainConfigurationName;
        private DomainConfigurationStatus _domainConfigurationStatus;
        private string _domainName;
        private DomainType _domainType;
        private DateTime? _lastStatusChangeDate;
        private List<ServerCertificateSummary> _serverCertificates = new List<ServerCertificateSummary>();
        private ServiceType _serviceType;
        private TlsConfig _tlsConfig;

        /// <summary>
        /// Gets and sets the property AuthorizerConfig. 
        /// <para>
        /// An object that specifies the authorization service for a domain.
        /// </para>
        /// </summary>
        public AuthorizerConfig AuthorizerConfig
        {
            get { return this._authorizerConfig; }
            set { this._authorizerConfig = value; }
        }

        // Check to see if AuthorizerConfig property is set
        internal bool IsSetAuthorizerConfig()
        {
            return this._authorizerConfig != null;
        }

        /// <summary>
        /// Gets and sets the property DomainConfigurationArn. 
        /// <para>
        /// The ARN of the domain configuration.
        /// </para>
        /// </summary>
        public string DomainConfigurationArn
        {
            get { return this._domainConfigurationArn; }
            set { this._domainConfigurationArn = value; }
        }

        // Check to see if DomainConfigurationArn property is set
        internal bool IsSetDomainConfigurationArn()
        {
            return this._domainConfigurationArn != null;
        }

        /// <summary>
        /// Gets and sets the property DomainConfigurationName. 
        /// <para>
        /// The name of the domain configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string DomainConfigurationName
        {
            get { return this._domainConfigurationName; }
            set { this._domainConfigurationName = value; }
        }

        // Check to see if DomainConfigurationName property is set
        internal bool IsSetDomainConfigurationName()
        {
            return this._domainConfigurationName != null;
        }

        /// <summary>
        /// Gets and sets the property DomainConfigurationStatus. 
        /// <para>
        /// A Boolean value that specifies the current state of the domain configuration.
        /// </para>
        /// </summary>
        public DomainConfigurationStatus DomainConfigurationStatus
        {
            get { return this._domainConfigurationStatus; }
            set { this._domainConfigurationStatus = value; }
        }

        // Check to see if DomainConfigurationStatus property is set
        internal bool IsSetDomainConfigurationStatus()
        {
            return this._domainConfigurationStatus != null;
        }

        /// <summary>
        /// Gets and sets the property DomainName. 
        /// <para>
        /// The name of the domain.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=253)]
        public string DomainName
        {
            get { return this._domainName; }
            set { this._domainName = value; }
        }

        // Check to see if DomainName property is set
        internal bool IsSetDomainName()
        {
            return this._domainName != null;
        }

        /// <summary>
        /// Gets and sets the property DomainType. 
        /// <para>
        /// The type of the domain.
        /// </para>
        /// </summary>
        public DomainType DomainType
        {
            get { return this._domainType; }
            set { this._domainType = value; }
        }

        // Check to see if DomainType property is set
        internal bool IsSetDomainType()
        {
            return this._domainType != null;
        }

        /// <summary>
        /// Gets and sets the property LastStatusChangeDate. 
        /// <para>
        /// The date and time the domain configuration's status was last changed.
        /// </para>
        /// </summary>
        public DateTime LastStatusChangeDate
        {
            get { return this._lastStatusChangeDate.GetValueOrDefault(); }
            set { this._lastStatusChangeDate = value; }
        }

        // Check to see if LastStatusChangeDate property is set
        internal bool IsSetLastStatusChangeDate()
        {
            return this._lastStatusChangeDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ServerCertificates. 
        /// <para>
        /// A list containing summary information about the server certificate included in the
        /// domain configuration.
        /// </para>
        /// </summary>
        public List<ServerCertificateSummary> ServerCertificates
        {
            get { return this._serverCertificates; }
            set { this._serverCertificates = value; }
        }

        // Check to see if ServerCertificates property is set
        internal bool IsSetServerCertificates()
        {
            return this._serverCertificates != null && this._serverCertificates.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ServiceType. 
        /// <para>
        /// The type of service delivered by the endpoint.
        /// </para>
        /// </summary>
        public ServiceType ServiceType
        {
            get { return this._serviceType; }
            set { this._serviceType = value; }
        }

        // Check to see if ServiceType property is set
        internal bool IsSetServiceType()
        {
            return this._serviceType != null;
        }

        /// <summary>
        /// Gets and sets the property TlsConfig. 
        /// <para>
        /// An object that specifies the TLS configuration for a domain.
        /// </para>
        /// </summary>
        public TlsConfig TlsConfig
        {
            get { return this._tlsConfig; }
            set { this._tlsConfig = value; }
        }

        // Check to see if TlsConfig property is set
        internal bool IsSetTlsConfig()
        {
            return this._tlsConfig != null;
        }

    }
}