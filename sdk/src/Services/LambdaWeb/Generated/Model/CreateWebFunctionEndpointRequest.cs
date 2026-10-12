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
    /// Container for the parameters to the CreateWebFunctionEndpoint operation.
    /// Creates an endpoint for a web function. An endpoint exposes the web function over
    /// HTTPS and routes traffic to one or more revisions.
    /// 
    ///  
    /// <para>
    /// To use this operation, you must have the <c>CreateWebFunctionEndpoint</c> permission
    /// on the web function, not on the endpoint being created.
    /// </para>
    /// </summary>
    public partial class CreateWebFunctionEndpointRequest : AmazonLambdaWebRequest
    {
        private AuthType _authType;
        private AutoDeploymentMode _autoDeploymentMode;
        private string _description;
        private string _endpointName;
        private EndpointType _endpointType;
        private string _functionName;
        private List<string> _regions = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<RevisionWeight> _revisionWeights = AWSConfigs.InitializeCollections ? new List<RevisionWeight>() : null;
        private ScalingConfig _scalingConfig;
        private ThrottleConfig _throttleConfig;

        /// <summary>
        /// Gets and sets the property AuthType. 
        /// <para>
        /// The authorization type for the endpoint.
        /// </para>
        ///  
        /// <para>
        /// Valid values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ApplicationManaged</c> – Your application handles authorization.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>IamAuth</c> – Lambda uses IAM to authorize requests, which must be signed with
        /// Signature Version 4 (SigV4).
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// The auto-deployment mode for the endpoint. Controls whether the endpoint automatically
        /// serves the newest revision. If you don't specify a value, the default is <c>Disabled</c>,
        /// and this default is returned in the response.
        /// </para>
        ///  
        /// <para>
        /// Valid values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>LatestRevision</c> – The endpoint automatically serves the newest revision.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Disabled</c> – Revision routing stays fixed until you change it.
        /// </para>
        ///  </li> </ul>
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
        /// The name of the endpoint to create. The name can contain letters, numbers, hyphens
        /// (-), and underscores (_), and can't begin or end with a hyphen or an underscore. The
        /// name is limited to 64 characters in length.
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
        /// Gets and sets the property EndpointType. 
        /// <para>
        /// The type of endpoint to create. Determines how traffic is served and routed across
        /// Regions.
        /// </para>
        ///  
        /// <para>
        /// Valid values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>HomeRegion</c> – Serves traffic from the Region where you created the web function.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>MultiRegion</c> – Replicates across the Regions that you choose and routes each
        /// request to the nearest one.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>PerRegion</c> – Creates a separate endpoint in each Region that you choose.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public EndpointType EndpointType
        {
            get { return this._endpointType; }
            set { this._endpointType = value; }
        }

        // Check to see if EndpointType property is set
        internal bool IsSetEndpointType()
        {
            return this._endpointType != null;
        }

        /// <summary>
        /// Gets and sets the property FunctionName. 
        /// <para>
        /// The web function to create the endpoint for.
        /// </para>
        ///  
        /// <para>
        /// You can specify either of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The function name, for example <c>my-function</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The function ARN.
        /// </para>
        ///  </li> </ul> 
        /// <para>
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
        /// Gets and sets the property Regions. 
        /// <para>
        /// The list of Regions for the endpoint. Required when the endpoint type is <c>MultiRegion</c>
        /// or <c>PerRegion</c>: specify at least one Region other than the Region where you create
        /// the endpoint (the home Region). The home Region is added automatically if you don't
        /// include it; specifying only the home Region isn't allowed. When the endpoint type
        /// is <c>HomeRegion</c>, omit this field or specify only the home Region.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public List<string> Regions
        {
            get { return this._regions; }
            set { this._regions = value; }
        }

        // Check to see if Regions property is set
        internal bool IsSetRegions()
        {
            return this._regions != null && (this._regions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RevisionWeights. 
        /// <para>
        /// A list of revision weights that determine how traffic is distributed across revisions.
        /// You can specify up to two revisions for canary or blue-green deployments.
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
        /// The scaling configuration for the endpoint. There is no default value. If you don't
        /// specify a scaling configuration, it is absent from the response.
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
        /// The throttling configuration for the endpoint. There is no default value. If you don't
        /// specify a throttling configuration, it is absent from the response.
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