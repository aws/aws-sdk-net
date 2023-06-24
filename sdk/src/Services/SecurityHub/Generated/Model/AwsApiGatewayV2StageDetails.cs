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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Contains information about a version 2 stage for Amazon API Gateway.
    /// </summary>
    public partial class AwsApiGatewayV2StageDetails
    {
        private AwsApiGatewayAccessLogSettings _accessLogSettings;
        private bool? _apiGatewayManaged;
        private bool? _autoDeploy;
        private string _clientCertificateId;
        private string _createdDate;
        private AwsApiGatewayV2RouteSettings _defaultRouteSettings;
        private string _deploymentId;
        private string _description;
        private string _lastDeploymentStatusMessage;
        private string _lastUpdatedDate;
        private AwsApiGatewayV2RouteSettings _routeSettings;
        private string _stageName;
        private Dictionary<string, string> _stageVariables = new Dictionary<string, string>();

        /// <summary>
        /// Gets and sets the property AccessLogSettings. 
        /// <para>
        /// Information about settings for logging access for the stage.
        /// </para>
        /// </summary>
        public AwsApiGatewayAccessLogSettings AccessLogSettings
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
        /// Gets and sets the property ApiGatewayManaged. 
        /// <para>
        /// Indicates whether the stage is managed by API Gateway.
        /// </para>
        /// </summary>
        public bool ApiGatewayManaged
        {
            get { return this._apiGatewayManaged.GetValueOrDefault(); }
            set { this._apiGatewayManaged = value; }
        }

        // Check to see if ApiGatewayManaged property is set
        internal bool IsSetApiGatewayManaged()
        {
            return this._apiGatewayManaged.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AutoDeploy. 
        /// <para>
        /// Indicates whether updates to an API automatically trigger a new deployment.
        /// </para>
        /// </summary>
        public bool AutoDeploy
        {
            get { return this._autoDeploy.GetValueOrDefault(); }
            set { this._autoDeploy = value; }
        }

        // Check to see if AutoDeploy property is set
        internal bool IsSetAutoDeploy()
        {
            return this._autoDeploy.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ClientCertificateId. 
        /// <para>
        /// The identifier of a client certificate for a stage. Supported only for WebSocket API
        /// calls.
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
        /// Indicates when the stage was created.
        /// </para>
        ///  
        /// <para>
        /// Uses the <code>date-time</code> format specified in <a href="https://tools.ietf.org/html/rfc3339#section-5.6">RFC
        /// 3339 section 5.6, Internet Date/Time Format</a>. The value cannot contain spaces,
        /// and date and time should be separated by <code>T</code>. For example, <code>2020-03-22T13:22:13.933Z</code>.
        /// </para>
        /// </summary>
        public string CreatedDate
        {
            get { return this._createdDate; }
            set { this._createdDate = value; }
        }

        // Check to see if CreatedDate property is set
        internal bool IsSetCreatedDate()
        {
            return this._createdDate != null;
        }

        /// <summary>
        /// Gets and sets the property DefaultRouteSettings. 
        /// <para>
        /// Default route settings for the stage.
        /// </para>
        /// </summary>
        public AwsApiGatewayV2RouteSettings DefaultRouteSettings
        {
            get { return this._defaultRouteSettings; }
            set { this._defaultRouteSettings = value; }
        }

        // Check to see if DefaultRouteSettings property is set
        internal bool IsSetDefaultRouteSettings()
        {
            return this._defaultRouteSettings != null;
        }

        /// <summary>
        /// Gets and sets the property DeploymentId. 
        /// <para>
        /// The identifier of the deployment that the stage is associated with. 
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
        /// The description of the stage.
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
        /// Gets and sets the property LastDeploymentStatusMessage. 
        /// <para>
        /// The status of the last deployment of a stage. Supported only if the stage has automatic
        /// deployment enabled.
        /// </para>
        /// </summary>
        public string LastDeploymentStatusMessage
        {
            get { return this._lastDeploymentStatusMessage; }
            set { this._lastDeploymentStatusMessage = value; }
        }

        // Check to see if LastDeploymentStatusMessage property is set
        internal bool IsSetLastDeploymentStatusMessage()
        {
            return this._lastDeploymentStatusMessage != null;
        }

        /// <summary>
        /// Gets and sets the property LastUpdatedDate. 
        /// <para>
        /// Indicates when the stage was most recently updated.
        /// </para>
        ///  
        /// <para>
        /// Uses the <code>date-time</code> format specified in <a href="https://tools.ietf.org/html/rfc3339#section-5.6">RFC
        /// 3339 section 5.6, Internet Date/Time Format</a>. The value cannot contain spaces,
        /// and date and time should be separated by <code>T</code>. For example, <code>2020-03-22T13:22:13.933Z</code>.
        /// </para>
        /// </summary>
        public string LastUpdatedDate
        {
            get { return this._lastUpdatedDate; }
            set { this._lastUpdatedDate = value; }
        }

        // Check to see if LastUpdatedDate property is set
        internal bool IsSetLastUpdatedDate()
        {
            return this._lastUpdatedDate != null;
        }

        /// <summary>
        /// Gets and sets the property RouteSettings. 
        /// <para>
        /// The route settings for the stage.
        /// </para>
        /// </summary>
        public AwsApiGatewayV2RouteSettings RouteSettings
        {
            get { return this._routeSettings; }
            set { this._routeSettings = value; }
        }

        // Check to see if RouteSettings property is set
        internal bool IsSetRouteSettings()
        {
            return this._routeSettings != null;
        }

        /// <summary>
        /// Gets and sets the property StageName. 
        /// <para>
        /// The name of the stage.
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
        /// Gets and sets the property StageVariables. 
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
        /// </summary>
        public Dictionary<string, string> StageVariables
        {
            get { return this._stageVariables; }
            set { this._stageVariables = value; }
        }

        // Check to see if StageVariables property is set
        internal bool IsSetStageVariables()
        {
            return this._stageVariables != null && this._stageVariables.Count > 0; 
        }

    }
}