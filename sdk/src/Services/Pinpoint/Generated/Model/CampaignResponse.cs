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
 * Do not modify this file. This file is generated from the pinpoint-2016-12-01.normal.json service model.
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
namespace Amazon.Pinpoint.Model
{
    /// <summary>
    /// Provides information about the status, configuration, and other settings for a campaign.
    /// </summary>
    public partial class CampaignResponse
    {
        private List<TreatmentResource> _additionalTreatments = AWSConfigs.InitializeCollections ? new List<TreatmentResource>() : null;
        private string _applicationId;
        private string _arn;
        private string _creationDate;
        private CustomDeliveryConfiguration _customDeliveryConfiguration;
        private CampaignState _defaultState;
        private string _description;
        private int? _holdoutPercent;
        private CampaignHook _hook;
        private string _id;
        private bool? _isPaused;
        private string _lastModifiedDate;
        private CampaignLimits _limits;
        private MessageConfiguration _messageConfiguration;
        private string _name;
        private int? _priority;
        private Schedule _schedule;
        private string _segmentId;
        private int? _segmentVersion;
        private CampaignState _state;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private TemplateConfiguration _templateConfiguration;
        private string _treatmentDescription;
        private string _treatmentName;
        private int? _version;

        /// <summary>
        /// Gets and sets the property AdditionalTreatments. 
        /// <para>
        /// An array of responses, one for each treatment that you defined for the campaign, in
        /// addition to the default treatment.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<TreatmentResource> AdditionalTreatments
        {
            get { return this._additionalTreatments; }
            set { this._additionalTreatments = value; }
        }

        // Check to see if AdditionalTreatments property is set
        internal bool IsSetAdditionalTreatments()
        {
            return this._additionalTreatments != null && (this._additionalTreatments.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ApplicationId. 
        /// <para>
        /// The unique identifier for the application that the campaign applies to.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ApplicationId
        {
            get { return this._applicationId; }
            set { this._applicationId = value; }
        }

        // Check to see if ApplicationId property is set
        internal bool IsSetApplicationId()
        {
            return this._applicationId != null;
        }

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the campaign.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property CreationDate. 
        /// <para>
        /// The date, in ISO 8601 format, when the campaign was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string CreationDate
        {
            get { return this._creationDate; }
            set { this._creationDate = value; }
        }

        // Check to see if CreationDate property is set
        internal bool IsSetCreationDate()
        {
            return this._creationDate != null;
        }

        /// <summary>
        /// Gets and sets the property CustomDeliveryConfiguration. 
        /// <para>
        /// The delivery configuration settings for sending the campaign through a custom channel.
        /// </para>
        /// </summary>
        public CustomDeliveryConfiguration CustomDeliveryConfiguration
        {
            get { return this._customDeliveryConfiguration; }
            set { this._customDeliveryConfiguration = value; }
        }

        // Check to see if CustomDeliveryConfiguration property is set
        internal bool IsSetCustomDeliveryConfiguration()
        {
            return this._customDeliveryConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property DefaultState. 
        /// <para>
        /// The current status of the campaign's default treatment. This value exists only for
        /// campaigns that have more than one treatment.
        /// </para>
        /// </summary>
        public CampaignState DefaultState
        {
            get { return this._defaultState; }
            set { this._defaultState = value; }
        }

        // Check to see if DefaultState property is set
        internal bool IsSetDefaultState()
        {
            return this._defaultState != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The custom description of the campaign.
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
        /// Gets and sets the property HoldoutPercent. 
        /// <para>
        /// The allocated percentage of users (segment members) who shouldn't receive messages
        /// from the campaign.
        /// </para>
        /// </summary>
        public int? HoldoutPercent
        {
            get { return this._holdoutPercent; }
            set { this._holdoutPercent = value; }
        }

        // Check to see if HoldoutPercent property is set
        internal bool IsSetHoldoutPercent()
        {
            return this._holdoutPercent.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Hook. 
        /// <para>
        /// The settings for the AWS Lambda function to use as a code hook for the campaign. You
        /// can use this hook to customize the segment that's used by the campaign.
        /// </para>
        /// </summary>
        public CampaignHook Hook
        {
            get { return this._hook; }
            set { this._hook = value; }
        }

        // Check to see if Hook property is set
        internal bool IsSetHook()
        {
            return this._hook != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The unique identifier for the campaign.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property IsPaused. 
        /// <para>
        /// Specifies whether the campaign is paused. A paused campaign doesn't run unless you
        /// resume it by changing this value to false.
        /// </para>
        /// </summary>
        public bool? IsPaused
        {
            get { return this._isPaused; }
            set { this._isPaused = value; }
        }

        // Check to see if IsPaused property is set
        internal bool IsSetIsPaused()
        {
            return this._isPaused.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastModifiedDate. 
        /// <para>
        /// The date, in ISO 8601 format, when the campaign was last modified.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string LastModifiedDate
        {
            get { return this._lastModifiedDate; }
            set { this._lastModifiedDate = value; }
        }

        // Check to see if LastModifiedDate property is set
        internal bool IsSetLastModifiedDate()
        {
            return this._lastModifiedDate != null;
        }

        /// <summary>
        /// Gets and sets the property Limits. 
        /// <para>
        /// The messaging limits for the campaign.
        /// </para>
        /// </summary>
        public CampaignLimits Limits
        {
            get { return this._limits; }
            set { this._limits = value; }
        }

        // Check to see if Limits property is set
        internal bool IsSetLimits()
        {
            return this._limits != null;
        }

        /// <summary>
        /// Gets and sets the property MessageConfiguration. 
        /// <para>
        /// The message configuration settings for the campaign.
        /// </para>
        /// </summary>
        public MessageConfiguration MessageConfiguration
        {
            get { return this._messageConfiguration; }
            set { this._messageConfiguration = value; }
        }

        // Check to see if MessageConfiguration property is set
        internal bool IsSetMessageConfiguration()
        {
            return this._messageConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the campaign.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property Priority. 
        /// <para>
        /// Defines the priority of the campaign, used to decide the order of messages displayed
        /// to user if there are multiple messages scheduled to be displayed at the same moment.
        /// </para>
        /// </summary>
        public int? Priority
        {
            get { return this._priority; }
            set { this._priority = value; }
        }

        // Check to see if Priority property is set
        internal bool IsSetPriority()
        {
            return this._priority.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Schedule. 
        /// <para>
        /// The schedule settings for the campaign.
        /// </para>
        /// </summary>
        public Schedule Schedule
        {
            get { return this._schedule; }
            set { this._schedule = value; }
        }

        // Check to see if Schedule property is set
        internal bool IsSetSchedule()
        {
            return this._schedule != null;
        }

        /// <summary>
        /// Gets and sets the property SegmentId. 
        /// <para>
        /// The unique identifier for the segment that's associated with the campaign.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string SegmentId
        {
            get { return this._segmentId; }
            set { this._segmentId = value; }
        }

        // Check to see if SegmentId property is set
        internal bool IsSetSegmentId()
        {
            return this._segmentId != null;
        }

        /// <summary>
        /// Gets and sets the property SegmentVersion. 
        /// <para>
        /// The version number of the segment that's associated with the campaign.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? SegmentVersion
        {
            get { return this._segmentVersion; }
            set { this._segmentVersion = value; }
        }

        // Check to see if SegmentVersion property is set
        internal bool IsSetSegmentVersion()
        {
            return this._segmentVersion.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The current status of the campaign.
        /// </para>
        /// </summary>
        public CampaignState State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A string-to-string map of key-value pairs that identifies the tags that are associated
        /// with the campaign. Each tag consists of a required tag key and an associated tag value.
        /// </para>
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

        /// <summary>
        /// Gets and sets the property TemplateConfiguration. 
        /// <para>
        /// The message template that’s used for the campaign.
        /// </para>
        /// </summary>
        public TemplateConfiguration TemplateConfiguration
        {
            get { return this._templateConfiguration; }
            set { this._templateConfiguration = value; }
        }

        // Check to see if TemplateConfiguration property is set
        internal bool IsSetTemplateConfiguration()
        {
            return this._templateConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property TreatmentDescription. 
        /// <para>
        /// The custom description of the default treatment for the campaign.
        /// </para>
        /// </summary>
        public string TreatmentDescription
        {
            get { return this._treatmentDescription; }
            set { this._treatmentDescription = value; }
        }

        // Check to see if TreatmentDescription property is set
        internal bool IsSetTreatmentDescription()
        {
            return this._treatmentDescription != null;
        }

        /// <summary>
        /// Gets and sets the property TreatmentName. 
        /// <para>
        /// The custom name of the default treatment for the campaign, if the campaign has multiple
        /// treatments. A <i>treatment</i> is a variation of a campaign that's used for A/B testing.
        /// </para>
        /// </summary>
        public string TreatmentName
        {
            get { return this._treatmentName; }
            set { this._treatmentName = value; }
        }

        // Check to see if TreatmentName property is set
        internal bool IsSetTreatmentName()
        {
            return this._treatmentName != null;
        }

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// The version number of the campaign.
        /// </para>
        /// </summary>
        public int? Version
        {
            get { return this._version; }
            set { this._version = value; }
        }

        // Check to see if Version property is set
        internal bool IsSetVersion()
        {
            return this._version.HasValue; 
        }

    }
}