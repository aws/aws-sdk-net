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

namespace Amazon.ApiGatewayV2.Model
{
    /// <summary>
    /// This is the response object from the CreateStage operation.
    /// </summary>
    public partial class CreateStageResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property AccessLogSettings. 
        /// <para>
        /// Settings for logging access in this stage.
        /// </para>
        /// </summary>
        public AccessLogSettings AccessLogSettings { get; set; }

        /// <summary>
        /// Checks to see if the AccessLogSettings property is set.
        /// </summary>
        internal bool IsSetAccessLogSettings() => this.AccessLogSettings != null;

        /// <summary>
        /// Gets and sets the property ApiGatewayManaged. 
        /// <para>
        /// Specifies whether a stage is managed by API Gateway. If you created an API using quick
        /// create, the $default stage is managed by API Gateway. You can't modify the $default
        /// stage.
        /// </para>
        /// </summary>
        public bool? ApiGatewayManaged { get; set; }

        /// <summary>
        /// Checks to see if the ApiGatewayManaged property is set.
        /// </summary>
        internal bool IsSetApiGatewayManaged() => this.ApiGatewayManaged.HasValue;

        /// <summary>
        /// Gets and sets the property AutoDeploy. 
        /// <para>
        /// Specifies whether updates to an API automatically trigger a new deployment. The default
        /// value is false.
        /// </para>
        /// </summary>
        public bool? AutoDeploy { get; set; }

        /// <summary>
        /// Checks to see if the AutoDeploy property is set.
        /// </summary>
        internal bool IsSetAutoDeploy() => this.AutoDeploy.HasValue;

        /// <summary>
        /// Gets and sets the property ClientCertificateId. 
        /// <para>
        /// The identifier of a client certificate for a Stage. Supported only for WebSocket APIs.
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
        /// The timestamp when the stage was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedDate { get; set; }

        /// <summary>
        /// Checks to see if the CreatedDate property is set.
        /// </summary>
        internal bool IsSetCreatedDate() => this.CreatedDate.HasValue;

        /// <summary>
        /// Gets and sets the property DefaultRouteSettings. 
        /// <para>
        /// Default route settings for the stage.
        /// </para>
        /// </summary>
        public RouteSettings DefaultRouteSettings { get; set; }

        /// <summary>
        /// Checks to see if the DefaultRouteSettings property is set.
        /// </summary>
        internal bool IsSetDefaultRouteSettings() => this.DefaultRouteSettings != null;

        /// <summary>
        /// Gets and sets the property DeploymentId. 
        /// <para>
        /// The identifier of the Deployment that the Stage is associated with. Can't be updated
        /// if autoDeploy is enabled.
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
        /// The description of the stage.
        /// </para>
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property LastDeploymentStatusMessage. 
        /// <para>
        /// Describes the status of the last deployment of a stage. Supported only for stages
        /// with autoDeploy enabled.
        /// </para>
        /// </summary>
        public string LastDeploymentStatusMessage { get; set; }

        /// <summary>
        /// Checks to see if the LastDeploymentStatusMessage property is set.
        /// </summary>
        internal bool IsSetLastDeploymentStatusMessage() => this.LastDeploymentStatusMessage != null;

        /// <summary>
        /// Gets and sets the property LastUpdatedDate. 
        /// <para>
        /// The timestamp when the stage was last updated.
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedDate { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdatedDate property is set.
        /// </summary>
        internal bool IsSetLastUpdatedDate() => this.LastUpdatedDate.HasValue;

        /// <summary>
        /// Gets and sets the property RouteSettings. 
        /// <para>
        /// Route settings for the stage, by routeKey.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, RouteSettings> RouteSettings { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, RouteSettings>() : null;

        /// <summary>
        /// Checks to see if the RouteSettings property is set.
        /// </summary>
        internal bool IsSetRouteSettings() => this.RouteSettings != null && (this.RouteSettings.Count > 0 || !AWSConfigs.InitializeCollections);

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
        /// Gets and sets the property StageVariables. 
        /// <para>
        /// A map that defines the stage variables for a stage resource. Variable names can have
        /// alphanumeric and underscore characters, and the values must match [A-Za-z0-9-._~:/?#&amp;=,]+.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> StageVariables { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the StageVariables property is set.
        /// </summary>
        internal bool IsSetStageVariables() => this.StageVariables != null && (this.StageVariables.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The collection of tags. Each tag element is associated with a given resource.
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
    }
}
