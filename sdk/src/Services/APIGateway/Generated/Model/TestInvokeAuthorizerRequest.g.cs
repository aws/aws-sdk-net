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
    /// Container for the parameters to the TestInvokeAuthorizer operation. Simulate the execution
    /// of an Authorizer in your RestApi with headers, parameters, and an incoming request
    /// body.
    /// </summary>
    public partial class TestInvokeAuthorizerRequest : AmazonAPIGatewayRequest
    {
        /// <summary>
        /// Gets and sets the property AdditionalContext. 
        /// <para>
        /// A key-value map of additional context variables.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> AdditionalContext { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the AdditionalContext property is set.
        /// </summary>
        internal bool IsSetAdditionalContext() => this.AdditionalContext != null && (this.AdditionalContext.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AuthorizerId. 
        /// <para>
        /// Specifies a test invoke authorizer request's Authorizer ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string AuthorizerId { get; set; }

        /// <summary>
        /// Checks to see if the AuthorizerId property is set.
        /// </summary>
        internal bool IsSetAuthorizerId() => this.AuthorizerId != null;

        /// <summary>
        /// Gets and sets the property Body. 
        /// <para>
        /// The simulated request body of an incoming invocation request.
        /// </para>
        /// </summary>
        public string Body { get; set; }

        /// <summary>
        /// Checks to see if the Body property is set.
        /// </summary>
        internal bool IsSetBody() => this.Body != null;

        /// <summary>
        /// Gets and sets the property Headers. 
        /// <para>
        /// A key-value map of headers to simulate an incoming invocation request. This is where
        /// the incoming authorization token, or identity source, should be specified.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Headers { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Headers property is set.
        /// </summary>
        internal bool IsSetHeaders() => this.Headers != null && (this.Headers.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property MultiValueHeaders. 
        /// <para>
        /// The headers as a map from string to list of values to simulate an incoming invocation
        /// request. This is where the incoming authorization token, or identity source, may be
        /// specified.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, List<string>> MultiValueHeaders { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, List<string>>() : null;

        /// <summary>
        /// Checks to see if the MultiValueHeaders property is set.
        /// </summary>
        internal bool IsSetMultiValueHeaders() => this.MultiValueHeaders != null && (this.MultiValueHeaders.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property PathWithQueryString. 
        /// <para>
        /// The URI path, including query string, of the simulated invocation request. Use this
        /// to specify path parameters and query string parameters.
        /// </para>
        /// </summary>
        public string PathWithQueryString { get; set; }

        /// <summary>
        /// Checks to see if the PathWithQueryString property is set.
        /// </summary>
        internal bool IsSetPathWithQueryString() => this.PathWithQueryString != null;

        /// <summary>
        /// Gets and sets the property RestApiId. 
        /// <para>
        /// The string identifier of the associated RestApi.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string RestApiId { get; set; }

        /// <summary>
        /// Checks to see if the RestApiId property is set.
        /// </summary>
        internal bool IsSetRestApiId() => this.RestApiId != null;

        /// <summary>
        /// Gets and sets the property StageVariables. 
        /// <para>
        /// A key-value map of stage variables to simulate an invocation on a deployed Stage.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> StageVariables { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the StageVariables property is set.
        /// </summary>
        internal bool IsSetStageVariables() => this.StageVariables != null && (this.StageVariables.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
