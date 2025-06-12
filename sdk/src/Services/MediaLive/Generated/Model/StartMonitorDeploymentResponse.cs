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
 * Do not modify this file. This file is generated from the medialive-2017-10-14.normal.json service model.
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
    /// Placeholder documentation for StartMonitorDeploymentResponse
    /// </summary>
    public partial class StartMonitorDeploymentResponse : AmazonWebServiceResponse
    {
        private string _arn;
        private List<string> _cloudWatchAlarmTemplateGroupIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private DateTime? _createdAt;
        private string _description;
        private string _discoveryEntryPointArn;
        private string _errorMessage;
        private List<string> _eventBridgeRuleTemplateGroupIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private Dictionary<string, MediaResource> _failedMediaResourceMap = AWSConfigs.InitializeCollections ? new Dictionary<string, MediaResource>() : null;
        private string _id;
        private DateTime? _lastDiscoveredAt;
        private SuccessfulMonitorDeployment _lastSuccessfulMonitorDeployment;
        private Dictionary<string, MediaResource> _mediaResourceMap = AWSConfigs.InitializeCollections ? new Dictionary<string, MediaResource>() : null;
        private DateTime? _modifiedAt;
        private bool? _monitorChangesPendingDeployment;
        private MonitorDeployment _monitorDeployment;
        private string _name;
        private SignalMapStatus _status;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property Arn. A signal map's ARN (Amazon Resource Name)
        /// </summary>
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property CloudWatchAlarmTemplateGroupIds.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> CloudWatchAlarmTemplateGroupIds
        {
            get { return this._cloudWatchAlarmTemplateGroupIds; }
            set { this._cloudWatchAlarmTemplateGroupIds = value; }
        }

        // Check to see if CloudWatchAlarmTemplateGroupIds property is set
        internal bool IsSetCloudWatchAlarmTemplateGroupIds()
        {
            return this._cloudWatchAlarmTemplateGroupIds != null && (this._cloudWatchAlarmTemplateGroupIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property CreatedAt.
        /// </summary>
        public DateTime? CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. A resource's optional description.
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
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
        /// Gets and sets the property DiscoveryEntryPointArn. A top-level supported AWS resource
        /// ARN to discovery a signal map from.
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string DiscoveryEntryPointArn
        {
            get { return this._discoveryEntryPointArn; }
            set { this._discoveryEntryPointArn = value; }
        }

        // Check to see if DiscoveryEntryPointArn property is set
        internal bool IsSetDiscoveryEntryPointArn()
        {
            return this._discoveryEntryPointArn != null;
        }

        /// <summary>
        /// Gets and sets the property ErrorMessage. Error message associated with a failed creation
        /// or failed update attempt of a signal map.
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string ErrorMessage
        {
            get { return this._errorMessage; }
            set { this._errorMessage = value; }
        }

        // Check to see if ErrorMessage property is set
        internal bool IsSetErrorMessage()
        {
            return this._errorMessage != null;
        }

        /// <summary>
        /// Gets and sets the property EventBridgeRuleTemplateGroupIds.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> EventBridgeRuleTemplateGroupIds
        {
            get { return this._eventBridgeRuleTemplateGroupIds; }
            set { this._eventBridgeRuleTemplateGroupIds = value; }
        }

        // Check to see if EventBridgeRuleTemplateGroupIds property is set
        internal bool IsSetEventBridgeRuleTemplateGroupIds()
        {
            return this._eventBridgeRuleTemplateGroupIds != null && (this._eventBridgeRuleTemplateGroupIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property FailedMediaResourceMap.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, MediaResource> FailedMediaResourceMap
        {
            get { return this._failedMediaResourceMap; }
            set { this._failedMediaResourceMap = value; }
        }

        // Check to see if FailedMediaResourceMap property is set
        internal bool IsSetFailedMediaResourceMap()
        {
            return this._failedMediaResourceMap != null && (this._failedMediaResourceMap.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Id. A signal map's id.
        /// </summary>
        [AWSProperty(Min=7, Max=11)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property LastDiscoveredAt.
        /// </summary>
        public DateTime? LastDiscoveredAt
        {
            get { return this._lastDiscoveredAt; }
            set { this._lastDiscoveredAt = value; }
        }

        // Check to see if LastDiscoveredAt property is set
        internal bool IsSetLastDiscoveredAt()
        {
            return this._lastDiscoveredAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastSuccessfulMonitorDeployment.
        /// </summary>
        public SuccessfulMonitorDeployment LastSuccessfulMonitorDeployment
        {
            get { return this._lastSuccessfulMonitorDeployment; }
            set { this._lastSuccessfulMonitorDeployment = value; }
        }

        // Check to see if LastSuccessfulMonitorDeployment property is set
        internal bool IsSetLastSuccessfulMonitorDeployment()
        {
            return this._lastSuccessfulMonitorDeployment != null;
        }

        /// <summary>
        /// Gets and sets the property MediaResourceMap.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, MediaResource> MediaResourceMap
        {
            get { return this._mediaResourceMap; }
            set { this._mediaResourceMap = value; }
        }

        // Check to see if MediaResourceMap property is set
        internal bool IsSetMediaResourceMap()
        {
            return this._mediaResourceMap != null && (this._mediaResourceMap.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ModifiedAt.
        /// </summary>
        public DateTime? ModifiedAt
        {
            get { return this._modifiedAt; }
            set { this._modifiedAt = value; }
        }

        // Check to see if ModifiedAt property is set
        internal bool IsSetModifiedAt()
        {
            return this._modifiedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MonitorChangesPendingDeployment. If true, there are pending
        /// monitor changes for this signal map that can be deployed.
        /// </summary>
        public bool? MonitorChangesPendingDeployment
        {
            get { return this._monitorChangesPendingDeployment; }
            set { this._monitorChangesPendingDeployment = value; }
        }

        // Check to see if MonitorChangesPendingDeployment property is set
        internal bool IsSetMonitorChangesPendingDeployment()
        {
            return this._monitorChangesPendingDeployment.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MonitorDeployment.
        /// </summary>
        public MonitorDeployment MonitorDeployment
        {
            get { return this._monitorDeployment; }
            set { this._monitorDeployment = value; }
        }

        // Check to see if MonitorDeployment property is set
        internal bool IsSetMonitorDeployment()
        {
            return this._monitorDeployment != null;
        }

        /// <summary>
        /// Gets and sets the property Name. A resource's name. Names must be unique within the
        /// scope of a resource type in a specific region.
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Status.
        /// </summary>
        public SignalMapStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property Tags.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}