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

namespace Amazon.BedrockAgentCoreControl.Model
{
    /// <summary>
    /// Container for the parameters to the CreateGateway operation. Creates a gateway for
    /// Amazon Bedrock Agent. A gateway serves as an integration point between your agent
    /// and external services. <para> If you specify <c>CUSTOM_JWT</c> as the <c>authorizerType</c>,
    /// you must provide an <c>authorizerConfiguration</c>. </para>
    /// </summary>
    public partial class CreateGatewayRequest : AmazonBedrockAgentCoreControlRequest
    {
        /// <summary>
        /// Gets and sets the property AuthorizerConfiguration. 
        /// <para>
        /// The authorizer configuration for the gateway. Required if <c>authorizerType</c> is
        /// <c>CUSTOM_JWT</c>.
        /// </para>
        /// </summary>
        public AuthorizerConfiguration AuthorizerConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the AuthorizerConfiguration property is set.
        /// </summary>
        internal bool IsSetAuthorizerConfiguration() => this.AuthorizerConfiguration != null;

        /// <summary>
        /// Gets and sets the property AuthorizerType. 
        /// <para>
        /// The type of authorizer to use for the gateway.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>CUSTOM_JWT</c> - Authorize with a bearer token.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AWS_IAM</c> - Authorize with your Amazon Web Services IAM credentials.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>NONE</c> - No authorization
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true)]
        public AuthorizerType AuthorizerType { get; set; }

        /// <summary>
        /// Checks to see if the AuthorizerType property is set.
        /// </summary>
        internal bool IsSetAuthorizerType() => this.AuthorizerType != null;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier to ensure that the API request completes no more
        /// than one time. If you don't specify this field, a value is randomly generated for
        /// you. If this token matches a previous request, the service ignores the request, but
        /// doesn't return an error. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/Run_Instance_Idempotency.html">Ensuring
        /// idempotency</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 33, Max = 256)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the gateway.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 200)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property ExceptionLevel. 
        /// <para>
        /// The level of detail in error messages returned when invoking the gateway.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If the value is <c>DEBUG</c>, granular exception messages are returned to help a user
        /// debug the gateway.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the value is omitted, a generic error message is returned to the end user.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ExceptionLevel ExceptionLevel { get; set; }

        /// <summary>
        /// Checks to see if the ExceptionLevel property is set.
        /// </summary>
        internal bool IsSetExceptionLevel() => this.ExceptionLevel != null;

        /// <summary>
        /// Gets and sets the property InterceptorConfigurations. 
        /// <para>
        /// A list of configuration settings for a gateway interceptor. Gateway interceptors allow
        /// custom code to be invoked during gateway invocations.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 2)]
        public List<GatewayInterceptorConfiguration> InterceptorConfigurations { get; set; } = AWSConfigs.InitializeCollections ? new List<GatewayInterceptorConfiguration>() : null;

        /// <summary>
        /// Checks to see if the InterceptorConfigurations property is set.
        /// </summary>
        internal bool IsSetInterceptorConfigurations() => this.InterceptorConfigurations != null && (this.InterceptorConfigurations.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property KmsKeyArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the KMS key used to encrypt data associated with
        /// the gateway.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string KmsKeyArn { get; set; }

        /// <summary>
        /// Checks to see if the KmsKeyArn property is set.
        /// </summary>
        internal bool IsSetKmsKeyArn() => this.KmsKeyArn != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the gateway. The name must be unique within your account.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property PolicyEngineConfiguration. 
        /// <para>
        /// The policy engine configuration for the gateway. A policy engine is a collection of
        /// policies that evaluates and authorizes agent tool calls. When associated with a gateway,
        /// the policy engine intercepts all agent requests and determines whether to allow or
        /// deny each action based on the defined policies.
        /// </para>
        /// </summary>
        public GatewayPolicyEngineConfiguration PolicyEngineConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the PolicyEngineConfiguration property is set.
        /// </summary>
        internal bool IsSetPolicyEngineConfiguration() => this.PolicyEngineConfiguration != null;

        /// <summary>
        /// Gets and sets the property ProtocolConfiguration. 
        /// <para>
        /// The configuration settings for the protocol specified in the <c>protocolType</c> parameter.
        /// </para>
        /// </summary>
        public GatewayProtocolConfiguration ProtocolConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ProtocolConfiguration property is set.
        /// </summary>
        internal bool IsSetProtocolConfiguration() => this.ProtocolConfiguration != null;

        /// <summary>
        /// Gets and sets the property ProtocolType. 
        /// <para>
        /// The protocol type for the gateway.
        /// </para>
        /// </summary>
        public GatewayProtocolType ProtocolType { get; set; }

        /// <summary>
        /// Checks to see if the ProtocolType property is set.
        /// </summary>
        internal bool IsSetProtocolType() => this.ProtocolType != null;

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM role that provides permissions for the gateway
        /// to access Amazon Web Services services.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string RoleArn { get; set; }

        /// <summary>
        /// Checks to see if the RoleArn property is set.
        /// </summary>
        internal bool IsSetRoleArn() => this.RoleArn != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A map of key-value pairs to associate with the gateway as metadata tags.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
