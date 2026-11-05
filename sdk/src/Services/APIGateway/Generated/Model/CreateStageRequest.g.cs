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
    /// Container for the parameters to the CreateStage operation. Creates a new Stage resource
    /// that references a pre-existing Deployment for the API.
    /// </summary>
    public partial class CreateStageRequest : AmazonAPIGatewayRequest
    {
        /// <summary>
        /// Gets and sets the property CacheClusterEnabled. 
        /// <para>
        /// Whether cache clustering is enabled for the stage.
        /// </para>
        /// </summary>
        public bool? CacheClusterEnabled { get; set; }

        /// <summary>
        /// Checks to see if the CacheClusterEnabled property is set.
        /// </summary>
        internal bool IsSetCacheClusterEnabled() => this.CacheClusterEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property CacheClusterSize. 
        /// <para>
        /// The stage's cache capacity in GB. For more information about choosing a cache size,
        /// see <a href="https://docs.aws.amazon.com/apigateway/latest/developerguide/api-gateway-caching.html">Enabling
        /// API caching to enhance responsiveness</a>.
        /// </para>
        /// </summary>
        public CacheClusterSize CacheClusterSize { get; set; }

        /// <summary>
        /// Checks to see if the CacheClusterSize property is set.
        /// </summary>
        internal bool IsSetCacheClusterSize() => this.CacheClusterSize != null;

        /// <summary>
        /// Gets and sets the property CanarySettings. 
        /// <para>
        /// The canary deployment settings of this stage.
        /// </para>
        /// </summary>
        public CanarySettings CanarySettings { get; set; }

        /// <summary>
        /// Checks to see if the CanarySettings property is set.
        /// </summary>
        internal bool IsSetCanarySettings() => this.CanarySettings != null;

        /// <summary>
        /// Gets and sets the property DeploymentId. 
        /// <para>
        /// The identifier of the Deployment resource for the Stage resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string DeploymentId { get; set; }

        /// <summary>
        /// Checks to see if the DeploymentId property is set.
        /// </summary>
        internal bool IsSetDeploymentId() => this.DeploymentId != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the Stage resource.
        /// </para>
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property DocumentationVersion. 
        /// <para>
        /// The version of the associated API documentation.
        /// </para>
        /// </summary>
        public string DocumentationVersion { get; set; }

        /// <summary>
        /// Checks to see if the DocumentationVersion property is set.
        /// </summary>
        internal bool IsSetDocumentationVersion() => this.DocumentationVersion != null;

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
        /// Gets and sets the property StageName. 
        /// <para>
        /// The name for the Stage resource. Stage names can only contain alphanumeric characters,
        /// hyphens, and underscores. Maximum length is 128 characters.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string StageName { get; set; }

        /// <summary>
        /// Checks to see if the StageName property is set.
        /// </summary>
        internal bool IsSetStageName() => this.StageName != null;

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
        /// Gets and sets the property TracingEnabled. 
        /// <para>
        /// Specifies whether active tracing with X-ray is enabled for the Stage.
        /// </para>
        /// </summary>
        public bool? TracingEnabled { get; set; }

        /// <summary>
        /// Checks to see if the TracingEnabled property is set.
        /// </summary>
        internal bool IsSetTracingEnabled() => this.TracingEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property Variables. 
        /// <para>
        /// A map that defines the stage variables for the new Stage resource. Variable names
        /// can have alphanumeric and underscore characters, and the values must match <c>[A-Za-z0-9-._~:/?#&amp;=,]+</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Variables { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Variables property is set.
        /// </summary>
        internal bool IsSetVariables() => this.Variables != null && (this.Variables.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
