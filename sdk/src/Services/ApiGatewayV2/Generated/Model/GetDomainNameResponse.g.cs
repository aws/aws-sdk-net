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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// This is the response object from the GetDomainName operation.
    /// </summary>
    public partial class GetDomainNameResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property ApiMappingSelectionExpression. 
        /// <para>
        /// The API mapping selection expression.
        /// </para>
        /// </summary>
        public string ApiMappingSelectionExpression { get; set; }

        /// <summary>
        /// Checks to see if the ApiMappingSelectionExpression property is set.
        /// </summary>
        internal bool IsSetApiMappingSelectionExpression() => this.ApiMappingSelectionExpression != null;

        /// <summary>
        /// Gets and sets the property DomainName. 
        /// <para>
        /// The name of the DomainName resource.
        /// </para>
        /// </summary>
        public string DomainName { get; set; }

        /// <summary>
        /// Checks to see if the DomainName property is set.
        /// </summary>
        internal bool IsSetDomainName() => this.DomainName != null;

        /// <summary>
        /// Gets and sets the property DomainNameArn. 
        /// <para>
        /// The ARN of the DomainName resource.
        /// </para>
        /// </summary>
        public string DomainNameArn { get; set; }

        /// <summary>
        /// Checks to see if the DomainNameArn property is set.
        /// </summary>
        internal bool IsSetDomainNameArn() => this.DomainNameArn != null;

        /// <summary>
        /// Gets and sets the property DomainNameConfigurations. 
        /// <para>
        /// The domain name configurations.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DomainNameConfiguration> DomainNameConfigurations { get; set; } = AWSConfigs.InitializeCollections ? new List<DomainNameConfiguration>() : null;

        /// <summary>
        /// Checks to see if the DomainNameConfigurations property is set.
        /// </summary>
        internal bool IsSetDomainNameConfigurations() => this.DomainNameConfigurations != null && (this.DomainNameConfigurations.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property MutualTlsAuthentication. 
        /// <para>
        /// The mutual TLS authentication configuration for a custom domain name.
        /// </para>
        /// </summary>
        public MutualTlsAuthentication MutualTlsAuthentication { get; set; }

        /// <summary>
        /// Checks to see if the MutualTlsAuthentication property is set.
        /// </summary>
        internal bool IsSetMutualTlsAuthentication() => this.MutualTlsAuthentication != null;

        /// <summary>
        /// Gets and sets the property RoutingMode. 
        /// <para>
        /// The routing mode.
        /// </para>
        /// </summary>
        public RoutingMode RoutingMode { get; set; }

        /// <summary>
        /// Checks to see if the RoutingMode property is set.
        /// </summary>
        internal bool IsSetRoutingMode() => this.RoutingMode != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The collection of tags associated with a domain name.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
