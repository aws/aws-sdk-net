/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.APIGateway.Model
{
    /// <summary>
    /// Container for the parameters to the CreateStage operation.
    /// Creates a new <a>Stage</a> resource that references a pre-existing <a>Deployment</a>
    /// for the API.
    /// </summary>
    public partial class CreateStageRequest : AmazonAPIGatewayRequest
    {
        private bool? _cacheClusterEnabled;
        private CacheClusterSize _cacheClusterSize;
        private string _deploymentId;
        private string _description;
        private string _restApiId;
        private string _stageName;
        private Dictionary<string, string> _variables = new Dictionary<string, string>();

        /// <summary>
        /// Gets and sets the property CacheClusterEnabled. 
        /// <para>
        /// Whether cache clustering is enabled for the stage.
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
        /// The stage's cache cluster size.
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
        /// Gets and sets the property DeploymentId. 
        /// <para>
        /// The identifier of the <a>Deployment</a> resource for the <a>Stage</a> resource.
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
        /// The description of the <a>Stage</a> resource.
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
        /// The identifier of the <a>RestApi</a> resource for the <a>Stage</a> resource to create.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property StageName. 
        /// <para>
        /// The name for the <a>Stage</a> resource.
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
        /// Gets and sets the property Variables. 
        /// <para>
        /// A map that defines the stage variables for the new <a>Stage</a> resource. Variable
        /// names can have alphanumeric and underscore characters, and the values must match <code>[A-Za-z0-9-._~:/?#&amp;=,]+</code>.
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