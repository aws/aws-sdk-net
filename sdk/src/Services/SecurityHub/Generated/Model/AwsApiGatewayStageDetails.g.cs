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

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Provides information about a version 1 Amazon API Gateway stage.
    /// </summary>
    public partial class AwsApiGatewayStageDetails
    {
        /// <summary>
        /// Gets and sets the property AccessLogSettings. 
        /// <para>
        /// Settings for logging access for the stage.
        /// </para>
        /// </summary>
        public AwsApiGatewayAccessLogSettings AccessLogSettings { get; set; }

        /// <summary>
        /// Checks to see if the AccessLogSettings property is set.
        /// </summary>
        internal bool IsSetAccessLogSettings() => this.AccessLogSettings != null;

        /// <summary>
        /// Gets and sets the property CacheClusterEnabled. 
        /// <para>
        /// Indicates whether a cache cluster is enabled for the stage.
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
        /// If a cache cluster is enabled, the size of the cache cluster.
        /// </para>
        /// </summary>
        public string CacheClusterSize { get; set; }

        /// <summary>
        /// Checks to see if the CacheClusterSize property is set.
        /// </summary>
        internal bool IsSetCacheClusterSize() => this.CacheClusterSize != null;

        /// <summary>
        /// Gets and sets the property CacheClusterStatus. 
        /// <para>
        /// If a cache cluster is enabled, the status of the cache cluster.
        /// </para>
        /// </summary>
        public string CacheClusterStatus { get; set; }

        /// <summary>
        /// Checks to see if the CacheClusterStatus property is set.
        /// </summary>
        internal bool IsSetCacheClusterStatus() => this.CacheClusterStatus != null;

        /// <summary>
        /// Gets and sets the property CanarySettings. 
        /// <para>
        /// Information about settings for canary deployment in the stage.
        /// </para>
        /// </summary>
        public AwsApiGatewayCanarySettings CanarySettings { get; set; }

        /// <summary>
        /// Checks to see if the CanarySettings property is set.
        /// </summary>
        internal bool IsSetCanarySettings() => this.CanarySettings != null;

        /// <summary>
        /// Gets and sets the property ClientCertificateId. 
        /// <para>
        /// The identifier of the client certificate for the stage.
        /// </para>
        /// </summary>
        public string ClientCertificateId { get; set; }

        /// <summary>
        /// Checks to see if the ClientCertificateId property is set.
        /// </summary>
        internal bool IsSetClientCertificateId() => this.ClientCertificateId != null;

        /// <summary>
        /// Gets and sets the property CreatedDate. 
        /// <para>
        /// Indicates when the stage was created.
        /// </para>
        ///  
        /// <para>
        /// For more information about the validation and formatting of timestamp fields in Security
        /// Hub CSPM, see <a href="https://docs.aws.amazon.com/securityhub/1.0/APIReference/Welcome.html#timestamps">Timestamps</a>.
        /// </para>
        /// </summary>
        public string CreatedDate { get; set; }

        /// <summary>
        /// Checks to see if the CreatedDate property is set.
        /// </summary>
        internal bool IsSetCreatedDate() => this.CreatedDate != null;

        /// <summary>
        /// Gets and sets the property DeploymentId. 
        /// <para>
        /// The identifier of the deployment that the stage points to.
        /// </para>
        /// </summary>
        public string DeploymentId { get; set; }

        /// <summary>
        /// Checks to see if the DeploymentId property is set.
        /// </summary>
        internal bool IsSetDeploymentId() => this.DeploymentId != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the stage.
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
        /// The version of the API documentation that is associated with the stage.
        /// </para>
        /// </summary>
        public string DocumentationVersion { get; set; }

        /// <summary>
        /// Checks to see if the DocumentationVersion property is set.
        /// </summary>
        internal bool IsSetDocumentationVersion() => this.DocumentationVersion != null;

        /// <summary>
        /// Gets and sets the property LastUpdatedDate. 
        /// <para>
        /// Indicates when the stage was most recently updated.
        /// </para>
        ///  
        /// <para>
        /// For more information about the validation and formatting of timestamp fields in Security
        /// Hub CSPM, see <a href="https://docs.aws.amazon.com/securityhub/1.0/APIReference/Welcome.html#timestamps">Timestamps</a>.
        /// </para>
        /// </summary>
        public string LastUpdatedDate { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdatedDate property is set.
        /// </summary>
        internal bool IsSetLastUpdatedDate() => this.LastUpdatedDate != null;

        /// <summary>
        /// Gets and sets the property MethodSettings. 
        /// <para>
        /// Defines the method settings for the stage.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AwsApiGatewayMethodSettings> MethodSettings { get; set; } = AWSConfigs.InitializeCollections ? new List<AwsApiGatewayMethodSettings>() : null;

        /// <summary>
        /// Checks to see if the MethodSettings property is set.
        /// </summary>
        internal bool IsSetMethodSettings() => this.MethodSettings != null && (this.MethodSettings.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property StageName. 
        /// <para>
        /// The name of the stage.
        /// </para>
        /// </summary>
        public string StageName { get; set; }

        /// <summary>
        /// Checks to see if the StageName property is set.
        /// </summary>
        internal bool IsSetStageName() => this.StageName != null;

        /// <summary>
        /// Gets and sets the property TracingEnabled. 
        /// <para>
        /// Indicates whether active tracing with X-Ray is enabled for the stage.
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
        /// A map that defines the stage variables for the stage.
        /// </para>
        ///  
        /// <para>
        /// Variable names can have alphanumeric and underscore characters.
        /// </para>
        ///  
        /// <para>
        /// Variable values can contain the following characters:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Uppercase and lowercase letters
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Numbers
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Special characters -._~:/?#&amp;=,
        /// </para>
        ///  </li> </ul>
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

        /// <summary>
        /// Gets and sets the property WebAclArn. 
        /// <para>
        /// The ARN of the web ACL associated with the stage.
        /// </para>
        /// </summary>
        public string WebAclArn { get; set; }

        /// <summary>
        /// Checks to see if the WebAclArn property is set.
        /// </summary>
        internal bool IsSetWebAclArn() => this.WebAclArn != null;
    }
}
