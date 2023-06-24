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
 * Do not modify this file. This file is generated from the apigateway-2015-07-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.APIGateway.Model
{
    /// <summary>
    /// Represents a unique identifier for a version of a deployed RestApi that is callable
    /// by users.
    /// </summary>
    public partial class UpdateStageResponse : AmazonWebServiceResponse
    {
        private AccessLogSettings _accessLogSettings;
        private bool? _cacheClusterEnabled;
        private CacheClusterSize _cacheClusterSize;
        private CacheClusterStatus _cacheClusterStatus;
        private CanarySettings _canarySettings;
        private string _clientCertificateId;
        private DateTime? _createdDate;
        private string _deploymentId;
        private string _description;
        private string _documentationVersion;
        private DateTime? _lastUpdatedDate;
        private Dictionary<string, MethodSetting> _methodSettings = new Dictionary<string, MethodSetting>();
        private string _stageName;
        private Dictionary<string, string> _tags = new Dictionary<string, string>();
        private bool? _tracingEnabled;
        private Dictionary<string, string> _variables = new Dictionary<string, string>();
        private string _webAclArn;

        /// <summary>
        /// Gets and sets the property AccessLogSettings. 
        /// <para>
        /// Settings for logging access in this stage.
        /// </para>
        /// </summary>
        public AccessLogSettings AccessLogSettings
        {
            get { return this._accessLogSettings; }
            set { this._accessLogSettings = value; }
        }

        // Check to see if AccessLogSettings property is set
        internal bool IsSetAccessLogSettings()
        {
            return this._accessLogSettings != null;
        }

        /// <summary>
        /// Gets and sets the property CacheClusterEnabled. 
        /// <para>
        /// Specifies whether a cache cluster is enabled for the stage.
        /// </para>
        /// </summary>
        public bool CacheClusterEnabled
        {
            get { return this._cacheClusterEnabled.GetValueOrDefault(); }
            set { this._cacheClusterEnabled = value; }
        }

        // Check to see if CacheClusterEnabled property is set
        internal bool IsSetCacheClusterEnabled()
        {
            return this._cacheClusterEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CacheClusterSize. 
        /// <para>
        /// The stage's cache capacity in GB. For more information about choosing a cache size,
        /// see <a href="https://docs.aws.amazon.com/apigateway/latest/developerguide/api-gateway-caching.html">Enabling
        /// API caching to enhance responsiveness</a>.
        /// </para>
        /// </summary>
        public CacheClusterSize CacheClusterSize
        {
            get { return this._cacheClusterSize; }
            set { this._cacheClusterSize = value; }
        }

        // Check to see if CacheClusterSize property is set
        internal bool IsSetCacheClusterSize()
        {
            return this._cacheClusterSize != null;
        }

        /// <summary>
        /// Gets and sets the property CacheClusterStatus. 
        /// <para>
        /// The status of the cache cluster for the stage, if enabled.
        /// </para>
        /// </summary>
        public CacheClusterStatus CacheClusterStatus
        {
            get { return this._cacheClusterStatus; }
            set { this._cacheClusterStatus = value; }
        }

        // Check to see if CacheClusterStatus property is set
        internal bool IsSetCacheClusterStatus()
        {
            return this._cacheClusterStatus != null;
        }

        /// <summary>
        /// Gets and sets the property CanarySettings. 
        /// <para>
        /// Settings for the canary deployment in this stage.
        /// </para>
        /// </summary>
        public CanarySettings CanarySettings
        {
            get { return this._canarySettings; }
            set { this._canarySettings = value; }
        }

        // Check to see if CanarySettings property is set
        internal bool IsSetCanarySettings()
        {
            return this._canarySettings != null;
        }

        /// <summary>
        /// Gets and sets the property ClientCertificateId. 
        /// <para>
        /// The identifier of a client certificate for an API stage.
        /// </para>
        /// </summary>
        public string ClientCertificateId
        {
            get { return this._clientCertificateId; }
            set { this._clientCertificateId = value; }
        }

        // Check to see if ClientCertificateId property is set
        internal bool IsSetClientCertificateId()
        {
            return this._clientCertificateId != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedDate. 
        /// <para>
        /// The timestamp when the stage was created.
        /// </para>
        /// </summary>
        public DateTime CreatedDate
        {
            get { return this._createdDate.GetValueOrDefault(); }
            set { this._createdDate = value; }
        }

        // Check to see if CreatedDate property is set
        internal bool IsSetCreatedDate()
        {
            return this._createdDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DeploymentId. 
        /// <para>
        /// The identifier of the Deployment that the stage points to.
        /// </para>
        /// </summary>
        public string DeploymentId
        {
            get { return this._deploymentId; }
            set { this._deploymentId = value; }
        }

        // Check to see if DeploymentId property is set
        internal bool IsSetDeploymentId()
        {
            return this._deploymentId != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The stage's description.
        /// </para>
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property DocumentationVersion. 
        /// <para>
        /// The version of the associated API documentation.
        /// </para>
        /// </summary>
        public string DocumentationVersion
        {
            get { return this._documentationVersion; }
            set { this._documentationVersion = value; }
        }

        // Check to see if DocumentationVersion property is set
        internal bool IsSetDocumentationVersion()
        {
            return this._documentationVersion != null;
        }

        /// <summary>
        /// Gets and sets the property LastUpdatedDate. 
        /// <para>
        /// The timestamp when the stage last updated.
        /// </para>
        /// </summary>
        public DateTime LastUpdatedDate
        {
            get { return this._lastUpdatedDate.GetValueOrDefault(); }
            set { this._lastUpdatedDate = value; }
        }

        // Check to see if LastUpdatedDate property is set
        internal bool IsSetLastUpdatedDate()
        {
            return this._lastUpdatedDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MethodSettings. 
        /// <para>
        /// A map that defines the method settings for a Stage resource. Keys (designated as <code>/{method_setting_key</code>
        /// below) are method paths defined as <code>{resource_path}/{http_method}</code> for
        /// an individual method override, or <code>/\*/\*</code> for overriding all methods in
        /// the stage. 
        /// </para>
        /// </summary>
        public Dictionary<string, MethodSetting> MethodSettings
        {
            get { return this._methodSettings; }
            set { this._methodSettings = value; }
        }

        // Check to see if MethodSettings property is set
        internal bool IsSetMethodSettings()
        {
            return this._methodSettings != null && this._methodSettings.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property StageName. 
        /// <para>
        /// The name of the stage is the first path segment in the Uniform Resource Identifier
        /// (URI) of a call to API Gateway. Stage names can only contain alphanumeric characters,
        /// hyphens, and underscores. Maximum length is 128 characters.
        /// </para>
        /// </summary>
        public string StageName
        {
            get { return this._stageName; }
            set { this._stageName = value; }
        }

        // Check to see if StageName property is set
        internal bool IsSetStageName()
        {
            return this._stageName != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The collection of tags. Each tag element is associated with a given resource.
        /// </para>
        /// </summary>
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property TracingEnabled. 
        /// <para>
        /// Specifies whether active tracing with X-ray is enabled for the Stage.
        /// </para>
        /// </summary>
        public bool TracingEnabled
        {
            get { return this._tracingEnabled.GetValueOrDefault(); }
            set { this._tracingEnabled = value; }
        }

        // Check to see if TracingEnabled property is set
        internal bool IsSetTracingEnabled()
        {
            return this._tracingEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Variables. 
        /// <para>
        /// A map that defines the stage variables for a Stage resource. Variable names can have
        /// alphanumeric and underscore characters, and the values must match <code>[A-Za-z0-9-._~:/?#&amp;=,]+</code>.
        /// </para>
        /// </summary>
        public Dictionary<string, string> Variables
        {
            get { return this._variables; }
            set { this._variables = value; }
        }

        // Check to see if Variables property is set
        internal bool IsSetVariables()
        {
            return this._variables != null && this._variables.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property WebAclArn. 
        /// <para>
        /// The ARN of the WebAcl associated with the Stage.
        /// </para>
        /// </summary>
        public string WebAclArn
        {
            get { return this._webAclArn; }
            set { this._webAclArn = value; }
        }

        // Check to see if WebAclArn property is set
        internal bool IsSetWebAclArn()
        {
            return this._webAclArn != null;
        }

    }
}