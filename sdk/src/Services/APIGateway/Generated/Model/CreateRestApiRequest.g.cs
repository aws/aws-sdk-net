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

namespace Amazon.APIGateway.Model
{
    /// <summary>
    /// Container for the parameters to the CreateRestApi operation. Creates a new RestApi
    /// resource.
    /// </summary>
    public partial class CreateRestApiRequest : AmazonAPIGatewayRequest
    {
        /// <summary>
        /// Gets and sets the property ApiKeySource. 
        /// <para>
        /// The source of the API key for metering requests according to a usage plan. Valid values
        /// are: <c>HEADER</c> to read the API key from the <c>X-API-Key</c> header of a request.
        /// <c>AUTHORIZER</c> to read the API key from the <c>UsageIdentifierKey</c> from a custom
        /// authorizer.
        /// </para>
        /// </summary>
        public ApiKeySourceType ApiKeySource { get; set; }

        /// <summary>
        /// Checks to see if the ApiKeySource property is set.
        /// </summary>
        internal bool IsSetApiKeySource() => this.ApiKeySource != null;

        /// <summary>
        /// Gets and sets the property BinaryMediaTypes. 
        /// <para>
        /// The list of binary media types supported by the RestApi. By default, the RestApi supports
        /// only UTF-8-encoded text payloads.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> BinaryMediaTypes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the BinaryMediaTypes property is set.
        /// </summary>
        internal bool IsSetBinaryMediaTypes() => this.BinaryMediaTypes != null && (this.BinaryMediaTypes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property CloneFrom. 
        /// <para>
        /// The ID of the RestApi that you want to clone from.
        /// </para>
        /// </summary>
        public string CloneFrom { get; set; }

        /// <summary>
        /// Checks to see if the CloneFrom property is set.
        /// </summary>
        internal bool IsSetCloneFrom() => this.CloneFrom != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the RestApi.
        /// </para>
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property DisableExecuteApiEndpoint. 
        /// <para>
        /// Specifies whether clients can invoke your API by using the default <c>execute-api</c>
        /// endpoint. By default, clients can invoke your API with the default <c>https://{api_id}.execute-api.{region}.amazonaws.com</c>
        /// endpoint. To require that clients use a custom domain name to invoke your API, disable
        /// the default endpoint
        /// </para>
        /// </summary>
        public bool? DisableExecuteApiEndpoint { get; set; }

        /// <summary>
        /// Checks to see if the DisableExecuteApiEndpoint property is set.
        /// </summary>
        internal bool IsSetDisableExecuteApiEndpoint() => this.DisableExecuteApiEndpoint.HasValue;

        /// <summary>
        /// Gets and sets the property EndpointAccessMode. 
        /// <para>
        ///  The endpoint access mode of the RestApi. Only available for RestApis that use security
        /// policies that start with <c>SecurityPolicy_</c>.
        /// </para>
        /// </summary>
        public EndpointAccessMode EndpointAccessMode { get; set; }

        /// <summary>
        /// Checks to see if the EndpointAccessMode property is set.
        /// </summary>
        internal bool IsSetEndpointAccessMode() => this.EndpointAccessMode != null;

        /// <summary>
        /// Gets and sets the property EndpointConfiguration. 
        /// <para>
        /// The endpoint configuration of this RestApi showing the endpoint types and IP address
        /// types of the API. 
        /// </para>
        /// </summary>
        public EndpointConfiguration EndpointConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the EndpointConfiguration property is set.
        /// </summary>
        internal bool IsSetEndpointConfiguration() => this.EndpointConfiguration != null;

        /// <summary>
        /// Gets and sets the property MinimumCompressionSize. 
        /// <para>
        /// A nullable integer that is used to enable compression (with non-negative between 0
        /// and 10485760 (10M) bytes, inclusive) or disable compression (with a null value) on
        /// an API. When compression is enabled, compression or decompression is not applied on
        /// the payload if the payload size is smaller than this value. Setting it to zero allows
        /// compression for any payload size.
        /// </para>
        /// </summary>
        public int? MinimumCompressionSize { get; set; }

        /// <summary>
        /// Checks to see if the MinimumCompressionSize property is set.
        /// </summary>
        internal bool IsSetMinimumCompressionSize() => this.MinimumCompressionSize.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the RestApi.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Policy. 
        /// <para>
        /// A stringified JSON policy document that applies to this RestApi regardless of the
        /// caller and Method configuration.
        /// </para>
        /// </summary>
        public string Policy { get; set; }

        /// <summary>
        /// Checks to see if the Policy property is set.
        /// </summary>
        internal bool IsSetPolicy() => this.Policy != null;

        /// <summary>
        /// Gets and sets the property SecurityPolicy. 
        /// <para>
        ///  The Transport Layer Security (TLS) version + cipher suite for this RestApi. 
        /// </para>
        /// </summary>
        public SecurityPolicy SecurityPolicy { get; set; }

        /// <summary>
        /// Checks to see if the SecurityPolicy property is set.
        /// </summary>
        internal bool IsSetSecurityPolicy() => this.SecurityPolicy != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The key-value map of strings. The valid character set is [a-zA-Z+-=._:/]. The tag
        /// key can be up to 128 characters and must not start with <c>aws:</c>. The tag value
        /// can be up to 256 characters.
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

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// A version identifier for the API.
        /// </para>
        /// </summary>
        public string Version { get; set; }

        /// <summary>
        /// Checks to see if the Version property is set.
        /// </summary>
        internal bool IsSetVersion() => this.Version != null;
    }
}
