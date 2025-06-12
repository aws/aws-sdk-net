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
 * Do not modify this file. This file is generated from the apigatewayv2-2018-11-29.normal.json service model.
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
namespace Amazon.ApiGatewayV2.Model
{
    /// <summary>
    /// Container for the parameters to the CreateDomainName operation.
    /// Creates a domain name.
    /// </summary>
    public partial class CreateDomainNameRequest : AmazonApiGatewayV2Request
    {
        private string _domainName;
        private List<DomainNameConfiguration> _domainNameConfigurations = AWSConfigs.InitializeCollections ? new List<DomainNameConfiguration>() : null;
        private MutualTlsAuthenticationInput _mutualTlsAuthentication;
        private RoutingMode _routingMode;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property DomainName. 
        /// <para>
        /// The domain name.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property DomainNameConfigurations. 
        /// <para>
        /// The domain name configurations.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DomainNameConfiguration> DomainNameConfigurations
        {
            get { return this._domainNameConfigurations; }
            set { this._domainNameConfigurations = value; }
        }

        // Check to see if DomainNameConfigurations property is set
        internal bool IsSetDomainNameConfigurations()
        {
            return this._domainNameConfigurations != null && (this._domainNameConfigurations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property MutualTlsAuthentication. 
        /// <para>
        /// The mutual TLS authentication configuration for a custom domain name.
        /// </para>
        /// </summary>
        public MutualTlsAuthenticationInput MutualTlsAuthentication
        {
            get { return this._mutualTlsAuthentication; }
            set { this._mutualTlsAuthentication = value; }
        }

        // Check to see if MutualTlsAuthentication property is set
        internal bool IsSetMutualTlsAuthentication()
        {
            return this._mutualTlsAuthentication != null;
        }

        /// <summary>
        /// Gets and sets the property RoutingMode. 
        /// <para>
        /// The routing mode.
        /// </para>
        /// </summary>
        public RoutingMode RoutingMode
        {
            get { return this._routingMode; }
            set { this._routingMode = value; }
        }

        // Check to see if RoutingMode property is set
        internal bool IsSetRoutingMode()
        {
            return this._routingMode != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The collection of tags associated with a domain name.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}