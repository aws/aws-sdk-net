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

namespace Amazon.MediaLive.Model
{
    /// <summary>
    /// This is the response object from the StartMonitorDeployment operation.
    /// </summary>
    public partial class StartMonitorDeploymentResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property Arn. A signal map's ARN (Amazon Resource Name)
        /// </summary>
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property CloudWatchAlarmTemplateGroupIds.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> CloudWatchAlarmTemplateGroupIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the CloudWatchAlarmTemplateGroupIds property is set.
        /// </summary>
        internal bool IsSetCloudWatchAlarmTemplateGroupIds() => this.CloudWatchAlarmTemplateGroupIds != null && (this.CloudWatchAlarmTemplateGroupIds.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property CreatedAt.
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Description. A resource's optional description.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property DiscoveryEntryPointArn. A top-level supported AWS resource
        /// ARN to discovery a signal map from.
        /// </summary>
        public string DiscoveryEntryPointArn { get; set; }

        /// <summary>
        /// Checks to see if the DiscoveryEntryPointArn property is set.
        /// </summary>
        internal bool IsSetDiscoveryEntryPointArn() => this.DiscoveryEntryPointArn != null;

        /// <summary>
        /// Gets and sets the property ErrorMessage. Error message associated with a failed creation
        /// or failed update attempt of a signal map.
        /// </summary>
        public string ErrorMessage { get; set; }

        /// <summary>
        /// Checks to see if the ErrorMessage property is set.
        /// </summary>
        internal bool IsSetErrorMessage() => this.ErrorMessage != null;

        /// <summary>
        /// Gets and sets the property EventBridgeRuleTemplateGroupIds.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> EventBridgeRuleTemplateGroupIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the EventBridgeRuleTemplateGroupIds property is set.
        /// </summary>
        internal bool IsSetEventBridgeRuleTemplateGroupIds() => this.EventBridgeRuleTemplateGroupIds != null && (this.EventBridgeRuleTemplateGroupIds.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property FailedMediaResourceMap.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, MediaResource> FailedMediaResourceMap { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, MediaResource>() : null;

        /// <summary>
        /// Checks to see if the FailedMediaResourceMap property is set.
        /// </summary>
        internal bool IsSetFailedMediaResourceMap() => this.FailedMediaResourceMap != null && (this.FailedMediaResourceMap.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Id. A signal map's id.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property LastDiscoveredAt.
        /// </summary>
        public DateTime? LastDiscoveredAt { get; set; }

        /// <summary>
        /// Checks to see if the LastDiscoveredAt property is set.
        /// </summary>
        internal bool IsSetLastDiscoveredAt() => this.LastDiscoveredAt.HasValue;

        /// <summary>
        /// Gets and sets the property LastSuccessfulMonitorDeployment.
        /// </summary>
        public SuccessfulMonitorDeployment LastSuccessfulMonitorDeployment { get; set; }

        /// <summary>
        /// Checks to see if the LastSuccessfulMonitorDeployment property is set.
        /// </summary>
        internal bool IsSetLastSuccessfulMonitorDeployment() => this.LastSuccessfulMonitorDeployment != null;

        /// <summary>
        /// Gets and sets the property MediaResourceMap.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, MediaResource> MediaResourceMap { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, MediaResource>() : null;

        /// <summary>
        /// Checks to see if the MediaResourceMap property is set.
        /// </summary>
        internal bool IsSetMediaResourceMap() => this.MediaResourceMap != null && (this.MediaResourceMap.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ModifiedAt.
        /// </summary>
        public DateTime? ModifiedAt { get; set; }

        /// <summary>
        /// Checks to see if the ModifiedAt property is set.
        /// </summary>
        internal bool IsSetModifiedAt() => this.ModifiedAt.HasValue;

        /// <summary>
        /// Gets and sets the property MonitorChangesPendingDeployment. If true, there are pending
        /// monitor changes for this signal map that can be deployed.
        /// </summary>
        public bool? MonitorChangesPendingDeployment { get; set; }

        /// <summary>
        /// Checks to see if the MonitorChangesPendingDeployment property is set.
        /// </summary>
        internal bool IsSetMonitorChangesPendingDeployment() => this.MonitorChangesPendingDeployment.HasValue;

        /// <summary>
        /// Gets and sets the property MonitorDeployment.
        /// </summary>
        public MonitorDeployment MonitorDeployment { get; set; }

        /// <summary>
        /// Checks to see if the MonitorDeployment property is set.
        /// </summary>
        internal bool IsSetMonitorDeployment() => this.MonitorDeployment != null;

        /// <summary>
        /// Gets and sets the property Name. A resource's name. Names must be unique within the
        /// scope of a resource type in a specific region.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Status.
        /// </summary>
        public SignalMapStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property Tags.
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
