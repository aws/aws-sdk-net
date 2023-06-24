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
    /// Container for the parameters to the CreateDeployment operation.
    /// Creates a Deployment resource, which makes a specified RestApi callable over the internet.
    /// </summary>
    public partial class CreateDeploymentRequest : AmazonAPIGatewayRequest
    {
        private bool? _cacheClusterEnabled;
        private CacheClusterSize _cacheClusterSize;
        private DeploymentCanarySettings _canarySettings;
        private string _description;
        private string _restApiId;
        private string _stageDescription;
        private string _stageName;
        private bool? _tracingEnabled;
        private Dictionary<string, string> _variables = new Dictionary<string, string>();

        /// <summary>
        /// Gets and sets the property CacheClusterEnabled. 
        /// <para>
        /// Enables a cache cluster for the Stage resource specified in the input.
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
        /// Gets and sets the property CanarySettings. 
        /// <para>
        /// The input configuration for the canary deployment when the deployment is a canary
        /// release deployment. 
        /// </para>
        /// </summary>
        public DeploymentCanarySettings CanarySettings
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
        /// Gets and sets the property Description. 
        /// <para>
        /// The description for the Deployment resource to create.
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
        /// Gets and sets the property RestApiId. 
        /// <para>
        /// The string identifier of the associated RestApi.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string RestApiId
        {
            get { return this._restApiId; }
            set { this._restApiId = value; }
        }

        // Check to see if RestApiId property is set
        internal bool IsSetRestApiId()
        {
            return this._restApiId != null;
        }

        /// <summary>
        /// Gets and sets the property StageDescription. 
        /// <para>
        /// The description of the Stage resource for the Deployment resource to create.
        /// </para>
        /// </summary>
        public string StageDescription
        {
            get { return this._stageDescription; }
            set { this._stageDescription = value; }
        }

        // Check to see if StageDescription property is set
        internal bool IsSetStageDescription()
        {
            return this._stageDescription != null;
        }

        /// <summary>
        /// Gets and sets the property StageName. 
        /// <para>
        /// The name of the Stage resource for the Deployment resource to create.
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
        /// A map that defines the stage variables for the Stage resource that is associated with
        /// the new deployment. Variable names can have alphanumeric and underscore characters,
        /// and the values must match <code>[A-Za-z0-9-._~:/?#&amp;=,]+</code>.
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

    }
}