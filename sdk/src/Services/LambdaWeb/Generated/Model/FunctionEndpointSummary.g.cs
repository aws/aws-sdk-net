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

namespace Amazon.LambdaWeb.Model
{
    /// <summary>
    /// A summary of a web function endpoint.
    /// </summary>
    public partial class FunctionEndpointSummary
    {
        /// <summary>
        /// Gets and sets the property AuthType. 
        /// <para>
        /// The authorization type for the endpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public AuthType AuthType { get; set; }

        /// <summary>
        /// Checks to see if the AuthType property is set.
        /// </summary>
        internal bool IsSetAuthType() => this.AuthType != null;

        /// <summary>
        /// Gets and sets the property AutoDeploymentMode. 
        /// <para>
        /// The auto-deployment mode for the endpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public AutoDeploymentMode AutoDeploymentMode { get; set; }

        /// <summary>
        /// Checks to see if the AutoDeploymentMode property is set.
        /// </summary>
        internal bool IsSetAutoDeploymentMode() => this.AutoDeploymentMode != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The date and time the endpoint was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the endpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property DomainName. 
        /// <para>
        /// The domain name of the endpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 4, Max = 256)]
        public string DomainName { get; set; }

        /// <summary>
        /// Checks to see if the DomainName property is set.
        /// </summary>
        internal bool IsSetDomainName() => this.DomainName != null;

        /// <summary>
        /// Gets and sets the property EndpointArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the endpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string EndpointArn { get; set; }

        /// <summary>
        /// Checks to see if the EndpointArn property is set.
        /// </summary>
        internal bool IsSetEndpointArn() => this.EndpointArn != null;

        /// <summary>
        /// Gets and sets the property EndpointName. 
        /// <para>
        /// The name of the endpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string EndpointName { get; set; }

        /// <summary>
        /// Checks to see if the EndpointName property is set.
        /// </summary>
        internal bool IsSetEndpointName() => this.EndpointName != null;

        /// <summary>
        /// Gets and sets the property EndpointType. 
        /// <para>
        /// The type of the endpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public EndpointType EndpointType { get; set; }

        /// <summary>
        /// Checks to see if the EndpointType property is set.
        /// </summary>
        internal bool IsSetEndpointType() => this.EndpointType != null;

        /// <summary>
        /// Gets and sets the property Regions. 
        /// <para>
        /// The list of Regions for the endpoint.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public List<string> Regions { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Regions property is set.
        /// </summary>
        internal bool IsSetRegions() => this.Regions != null && (this.Regions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RevisionWeights. 
        /// <para>
        /// The revision weights for the endpoint.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2)]
        public List<RevisionWeight> RevisionWeights { get; set; } = AWSConfigs.InitializeCollections ? new List<RevisionWeight>() : null;

        /// <summary>
        /// Checks to see if the RevisionWeights property is set.
        /// </summary>
        internal bool IsSetRevisionWeights() => this.RevisionWeights != null && (this.RevisionWeights.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ScalingConfig. 
        /// <para>
        /// The scaling configuration for the endpoint. This field is absent if the endpoint has
        /// no scaling configuration.
        /// </para>
        /// </summary>
        public ScalingConfig ScalingConfig { get; set; }

        /// <summary>
        /// Checks to see if the ScalingConfig property is set.
        /// </summary>
        internal bool IsSetScalingConfig() => this.ScalingConfig != null;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The current state of the endpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public EndpointState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;

        /// <summary>
        /// Gets and sets the property StateReason. 
        /// <para>
        /// The reason for the current state of the endpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string StateReason { get; set; }

        /// <summary>
        /// Checks to see if the StateReason property is set.
        /// </summary>
        internal bool IsSetStateReason() => this.StateReason != null;

        /// <summary>
        /// Gets and sets the property ThrottleConfig. 
        /// <para>
        /// The throttling configuration for the endpoint. This field is absent if the endpoint
        /// has no throttling configuration.
        /// </para>
        /// </summary>
        public ThrottleConfig ThrottleConfig { get; set; }

        /// <summary>
        /// Checks to see if the ThrottleConfig property is set.
        /// </summary>
        internal bool IsSetThrottleConfig() => this.ThrottleConfig != null;

        /// <summary>
        /// Gets and sets the property UpdateStatus. 
        /// <para>
        /// The status of the most recent update to the endpoint.
        /// </para>
        /// </summary>
        public EndpointUpdateStatus UpdateStatus { get; set; }

        /// <summary>
        /// Checks to see if the UpdateStatus property is set.
        /// </summary>
        internal bool IsSetUpdateStatus() => this.UpdateStatus != null;

        /// <summary>
        /// Gets and sets the property UpdateStatusReason. 
        /// <para>
        /// The reason for the current update status of the endpoint.
        /// </para>
        /// </summary>
        public string UpdateStatusReason { get; set; }

        /// <summary>
        /// Checks to see if the UpdateStatusReason property is set.
        /// </summary>
        internal bool IsSetUpdateStatusReason() => this.UpdateStatusReason != null;

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The date and time the endpoint was last updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;
    }
}
