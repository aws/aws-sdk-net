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
    /// This is the response object from the CreateGateway operation.
    /// </summary>
    public partial class CreateGatewayResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property AuthorizerConfiguration. 
        /// <para>
        /// The authorizer configuration for the created gateway.
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
        /// The type of authorizer used by the gateway.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public AuthorizerType AuthorizerType { get; set; }

        /// <summary>
        /// Checks to see if the AuthorizerType property is set.
        /// </summary>
        internal bool IsSetAuthorizerType() => this.AuthorizerType != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp when the gateway was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property CustomTransformConfiguration. 
        /// <para>
        /// The custom transformation configuration for the gateway. This configuration defines
        /// how the gateway transforms requests and responses.
        /// </para>
        /// </summary>
        public CustomTransformConfiguration CustomTransformConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the CustomTransformConfiguration property is set.
        /// </summary>
        internal bool IsSetCustomTransformConfiguration() => this.CustomTransformConfiguration != null;

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
        /// Gets and sets the property GatewayArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the created gateway.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string GatewayArn { get; set; }

        /// <summary>
        /// Checks to see if the GatewayArn property is set.
        /// </summary>
        internal bool IsSetGatewayArn() => this.GatewayArn != null;

        /// <summary>
        /// Gets and sets the property GatewayId. 
        /// <para>
        /// The unique identifier of the created gateway.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string GatewayId { get; set; }

        /// <summary>
        /// Checks to see if the GatewayId property is set.
        /// </summary>
        internal bool IsSetGatewayId() => this.GatewayId != null;

        /// <summary>
        /// Gets and sets the property GatewayUrl. 
        /// <para>
        /// The URL endpoint for the created gateway.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string GatewayUrl { get; set; }

        /// <summary>
        /// Checks to see if the GatewayUrl property is set.
        /// </summary>
        internal bool IsSetGatewayUrl() => this.GatewayUrl != null;

        /// <summary>
        /// Gets and sets the property InterceptorConfigurations. 
        /// <para>
        /// The list of interceptor configurations for the created gateway.
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
        /// The name of the gateway.
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
        /// The policy engine configuration for the created gateway.
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
        /// The configuration settings for the protocol used by the gateway.
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
        /// The protocol type of the gateway.
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
        /// The Amazon Resource Name (ARN) of the IAM role associated with the gateway.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string RoleArn { get; set; }

        /// <summary>
        /// Checks to see if the RoleArn property is set.
        /// </summary>
        internal bool IsSetRoleArn() => this.RoleArn != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the gateway.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public GatewayStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StatusReasons. 
        /// <para>
        /// The reasons for the current status of the gateway.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 100)]
        public List<string> StatusReasons { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the StatusReasons property is set.
        /// </summary>
        internal bool IsSetStatusReasons() => this.StatusReasons != null && (this.StatusReasons.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The timestamp when the gateway was last updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property WafConfiguration. 
        /// <para>
        /// The Amazon Web Services WAF configuration for the gateway.
        /// </para>
        /// </summary>
        public WafConfiguration WafConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the WafConfiguration property is set.
        /// </summary>
        internal bool IsSetWafConfiguration() => this.WafConfiguration != null;

        /// <summary>
        /// Gets and sets the property WebAclArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Amazon Web Services WAF web ACL associated with
        /// the gateway.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string WebAclArn { get; set; }

        /// <summary>
        /// Checks to see if the WebAclArn property is set.
        /// </summary>
        internal bool IsSetWebAclArn() => this.WebAclArn != null;

        /// <summary>
        /// Gets and sets the property WorkloadIdentityDetails. 
        /// <para>
        /// The workload identity details for the created gateway.
        /// </para>
        /// </summary>
        public WorkloadIdentityDetails WorkloadIdentityDetails { get; set; }

        /// <summary>
        /// Checks to see if the WorkloadIdentityDetails property is set.
        /// </summary>
        internal bool IsSetWorkloadIdentityDetails() => this.WorkloadIdentityDetails != null;
    }
}
