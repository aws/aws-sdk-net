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
    /// This is the response object from the UpdateMethod operation.
    /// </summary>
    public partial class UpdateMethodResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property ApiKeyRequired. 
        /// <para>
        /// A boolean flag specifying whether a valid ApiKey is required to invoke this method.
        /// </para>
        /// </summary>
        public bool? ApiKeyRequired { get; set; }

        /// <summary>
        /// Checks to see if the ApiKeyRequired property is set.
        /// </summary>
        internal bool IsSetApiKeyRequired() => this.ApiKeyRequired.HasValue;

        /// <summary>
        /// Gets and sets the property AuthorizationScopes. 
        /// <para>
        /// A list of authorization scopes configured on the method. The scopes are used with
        /// a <c>COGNITO_USER_POOLS</c> authorizer to authorize the method invocation. The authorization
        /// works by matching the method scopes against the scopes parsed from the access token
        /// in the incoming request. The method invocation is authorized if any method scopes
        /// matches a claimed scope in the access token. Otherwise, the invocation is not authorized.
        /// When the method scope is configured, the client must provide an access token instead
        /// of an identity token for authorization purposes.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AuthorizationScopes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AuthorizationScopes property is set.
        /// </summary>
        internal bool IsSetAuthorizationScopes() => this.AuthorizationScopes != null && (this.AuthorizationScopes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AuthorizationType. 
        /// <para>
        /// The method's authorization type. Valid values are <c>NONE</c> for open access, <c>AWS_IAM</c>
        /// for using AWS IAM permissions, <c>CUSTOM</c> for using a custom authorizer, or <c>COGNITO_USER_POOLS</c>
        /// for using a Cognito user pool.
        /// </para>
        /// </summary>
        public string AuthorizationType { get; set; }

        /// <summary>
        /// Checks to see if the AuthorizationType property is set.
        /// </summary>
        internal bool IsSetAuthorizationType() => this.AuthorizationType != null;

        /// <summary>
        /// Gets and sets the property AuthorizerId. 
        /// <para>
        /// The identifier of an Authorizer to use on this method. The <c>authorizationType</c>
        /// must be <c>CUSTOM</c>.
        /// </para>
        /// </summary>
        public string AuthorizerId { get; set; }

        /// <summary>
        /// Checks to see if the AuthorizerId property is set.
        /// </summary>
        internal bool IsSetAuthorizerId() => this.AuthorizerId != null;

        /// <summary>
        /// Gets and sets the property HttpMethod. 
        /// <para>
        /// The method's HTTP verb.
        /// </para>
        /// </summary>
        public string HttpMethod { get; set; }

        /// <summary>
        /// Checks to see if the HttpMethod property is set.
        /// </summary>
        internal bool IsSetHttpMethod() => this.HttpMethod != null;

        /// <summary>
        /// Gets and sets the property MethodIntegration. 
        /// <para>
        /// Gets the method's integration responsible for passing the client-submitted request
        /// to the back end and performing necessary transformations to make the request compliant
        /// with the back end.
        /// </para>
        /// </summary>
        public Integration MethodIntegration { get; set; }

        /// <summary>
        /// Checks to see if the MethodIntegration property is set.
        /// </summary>
        internal bool IsSetMethodIntegration() => this.MethodIntegration != null;

        /// <summary>
        /// Gets and sets the property MethodResponses. 
        /// <para>
        /// Gets a method response associated with a given HTTP status code. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, MethodResponse> MethodResponses { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, MethodResponse>() : null;

        /// <summary>
        /// Checks to see if the MethodResponses property is set.
        /// </summary>
        internal bool IsSetMethodResponses() => this.MethodResponses != null && (this.MethodResponses.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property OperationName. 
        /// <para>
        /// A human-friendly operation identifier for the method. For example, you can assign
        /// the <c>operationName</c> of <c>ListPets</c> for the <c>GET /pets</c> method in the
        /// <c>PetStore</c> example.
        /// </para>
        /// </summary>
        public string OperationName { get; set; }

        /// <summary>
        /// Checks to see if the OperationName property is set.
        /// </summary>
        internal bool IsSetOperationName() => this.OperationName != null;

        /// <summary>
        /// Gets and sets the property RequestModels. 
        /// <para>
        /// A key-value map specifying data schemas, represented by Model resources, (as the mapped
        /// value) of the request payloads of given content types (as the mapping key).
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> RequestModels { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the RequestModels property is set.
        /// </summary>
        internal bool IsSetRequestModels() => this.RequestModels != null && (this.RequestModels.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RequestParameters. 
        /// <para>
        /// A key-value map defining required or optional method request parameters that can be
        /// accepted by API Gateway. A key is a method request parameter name matching the pattern
        /// of <c>method.request.{location}.{name}</c>, where <c>location</c> is <c>querystring</c>,
        /// <c>path</c>, or <c>header</c> and <c>name</c> is a valid and unique parameter name.
        /// The value associated with the key is a Boolean flag indicating whether the parameter
        /// is required (<c>true</c>) or optional (<c>false</c>). The method request parameter
        /// names defined here are available in Integration to be mapped to integration request
        /// parameters or templates.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, bool> RequestParameters { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, bool>() : null;

        /// <summary>
        /// Checks to see if the RequestParameters property is set.
        /// </summary>
        internal bool IsSetRequestParameters() => this.RequestParameters != null && (this.RequestParameters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RequestValidatorId. 
        /// <para>
        /// The identifier of a RequestValidator for request validation.
        /// </para>
        /// </summary>
        public string RequestValidatorId { get; set; }

        /// <summary>
        /// Checks to see if the RequestValidatorId property is set.
        /// </summary>
        internal bool IsSetRequestValidatorId() => this.RequestValidatorId != null;
    }
}
