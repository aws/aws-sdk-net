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
 * Do not modify this file. This file is generated from the lambda-web-2025-03-07.normal.json service model.
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
namespace Amazon.LambdaWeb.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateWebFunctionEndpoint operation.
    /// Updates the configuration of a web function endpoint. You can modify the authorization
    /// type, auto-deployment mode, revision weights, scaling, and throttling settings.
    /// </summary>
    public partial class UpdateWebFunctionEndpointRequest : AmazonLambdaWebRequest
    {
        private AuthType _authType;
        private AutoDeploymentMode _autoDeploymentMode;
        private string _description;
        private string _endpointName;
        private string _functionName;
        private List<RevisionWeight> _revisionWeights = AWSConfigs.InitializeCollections ? new List<RevisionWeight>() : null;
        private ScalingConfig _scalingConfig;
        private ThrottleConfig _throttleConfig;

        /// <summary>
        /// Gets and sets the property AuthType. 
        /// <para>
        /// The authorization type for the endpoint.
        /// </para>
        /// </summary>
        public AuthType AuthType
        {
            get { return this._authType; }
            set { this._authType = value; }
        }

        // Check to see if AuthType property is set
        internal bool IsSetAuthType()
        {
            return this._authType != null;
        }

        /// <summary>
        /// Gets and sets the property AutoDeploymentMode. 
        /// <para>
        /// The auto-deployment mode for the endpoint.
        /// </para>
        /// </summary>
        public AutoDeploymentMode AutoDeploymentMode
        {
            get { return this._autoDeploymentMode; }
            set { this._autoDeploymentMode = value; }
        }

        // Check to see if AutoDeploymentMode property is set
        internal bool IsSetAutoDeploymentMode()
        {
            return this._autoDeploymentMode != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the endpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
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
        /// Gets and sets the property EndpointName. 
        /// <para>
        /// The name of the endpoint to update. You can specify the endpoint name or the endpoint
        /// ARN. The length constraint applies only to the full ARN. If you specify only the endpoint
        /// name, it is limited to 64 characters in length.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string EndpointName
        {
            get { return this._endpointName; }
            set { this._endpointName = value; }
        }

        // Check to see if EndpointName property is set
        internal bool IsSetEndpointName()
        {
            return this._endpointName != null;
        }

        /// <summary>
        /// Gets and sets the property FunctionName. 
        /// <para>
        /// The name of the web function. You can specify the function name or the function ARN.
        /// The length constraint applies only to the full ARN. If you specify only the function
        /// name, it is limited to 64 characters in length.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string FunctionName
        {
            get { return this._functionName; }
            set { this._functionName = value; }
        }

        // Check to see if FunctionName property is set
        internal bool IsSetFunctionName()
        {
            return this._functionName != null;
        }

        /// <summary>
        /// Gets and sets the property RevisionWeights. 
        /// <para>
        /// A list of revision weights that determine how traffic is distributed across revisions.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=2)]
        public List<RevisionWeight> RevisionWeights
        {
            get { return this._revisionWeights; }
            set { this._revisionWeights = value; }
        }

        // Check to see if RevisionWeights property is set
        internal bool IsSetRevisionWeights()
        {
            return this._revisionWeights != null && (this._revisionWeights.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ScalingConfig. 
        /// <para>
        /// The scaling configuration for the endpoint. Omit this field to keep the current scaling
        /// configuration. To clear a previously set <c>maxEnvironments</c> value, specify an
        /// empty object.
        /// </para>
        /// </summary>
        public ScalingConfig ScalingConfig
        {
            get { return this._scalingConfig; }
            set { this._scalingConfig = value; }
        }

        // Check to see if ScalingConfig property is set
        internal bool IsSetScalingConfig()
        {
            return this._scalingConfig != null;
        }

        /// <summary>
        /// Gets and sets the property ThrottleConfig. 
        /// <para>
        /// The throttling configuration for the endpoint. Omit this field to keep the current
        /// throttling configuration. To clear a previously set <c>rateLimit</c> value, specify
        /// an empty object.
        /// </para>
        /// </summary>
        public ThrottleConfig ThrottleConfig
        {
            get { return this._throttleConfig; }
            set { this._throttleConfig = value; }
        }

        // Check to see if ThrottleConfig property is set
        internal bool IsSetThrottleConfig()
        {
            return this._throttleConfig != null;
        }

    }
}