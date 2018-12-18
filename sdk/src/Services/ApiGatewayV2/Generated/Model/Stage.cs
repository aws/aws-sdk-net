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
 * Do not modify this file. This file is generated from the apigatewayv2-2018-11-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ApiGatewayV2.Model
{
    /// <summary>
    /// Represents an API stage.
    /// </summary>
    public partial class Stage
    {
        private AccessLogSettings _accessLogSettings;
        private string _clientCertificateId;
        private DateTime? _createdDate;
        private RouteSettings _defaultRouteSettings;
        private string _deploymentId;
        private string _description;
        private DateTime? _lastUpdatedDate;
        private Dictionary<string, RouteSettings> _routeSettings = new Dictionary<string, RouteSettings>();
        private string _stageName;
        private Dictionary<string, string> _stageVariables = new Dictionary<string, string>();

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
        /// Gets and sets the property ClientCertificateId. 
        /// <para>
        /// The identifier of a client certificate for a Stage.
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
        /// Gets and sets the property DefaultRouteSettings. 
        /// <para>
        /// Default route settings for the stage.
        /// </para>
        /// </summary>
        public RouteSettings DefaultRouteSettings
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
        /// The identifier of the Deployment that the Stage is associated with.
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
        /// Gets and sets the property LastUpdatedDate. 
        /// <para>
        /// The timestamp when the stage was last updated.
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
        /// Gets and sets the property RouteSettings. 
        /// <para>
        /// Route settings for the stage.
        /// </para>
        /// </summary>
        public Dictionary<string, RouteSettings> RouteSettings
        {
            get { return this._routeSettings; }
            set { this._routeSettings = value; }
        }

        // Check to see if RouteSettings property is set
        internal bool IsSetRouteSettings()
        {
            return this._routeSettings != null && this._routeSettings.Count > 0; 
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
        /// A map that defines the stage variables for a stage resource. Variable names can have
        /// alphanumeric and underscore characters, and the values must match [A-Za-z0-9-._~:/?#&=,]+.
        /// </para>
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