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

namespace Amazon.Pinpoint.Model
{
    /// <summary>
    /// Specifies the configuration and other settings for a campaign.
    /// </summary>
    public partial class WriteCampaignRequest
    {
        private List<WriteTreatmentResource> _additionalTreatments = new List<WriteTreatmentResource>();
        private CustomDeliveryConfiguration _customDeliveryConfiguration;
        private string _description;
        private int? _holdoutPercent;
        private CampaignHook _hook;
        private bool? _isPaused;
        private CampaignLimits _limits;
        private MessageConfiguration _messageConfiguration;
        private string _name;
        private Schedule _schedule;
        private string _segmentId;
        private int? _segmentVersion;
        private Dictionary<string, string> _tags = new Dictionary<string, string>();
        private TemplateConfiguration _templateConfiguration;
        private string _treatmentDescription;
        private string _treatmentName;

        /// <summary>
        /// Gets and sets the property AdditionalTreatments. 
        /// <para>
        /// An array of requests that defines additional treatments for the campaign, in addition
        /// to the default treatment for the campaign.
        /// </para>
        /// </summary>
        public List<WriteTreatmentResource> AdditionalTreatments
        {
            get { return this._additionalTreatments; }
            set { this._additionalTreatments = value; }
        }

        // Check to see if AdditionalTreatments property is set
        internal bool IsSetAdditionalTreatments()
        {
            return this._additionalTreatments != null && this._additionalTreatments.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property CustomDeliveryConfiguration. 
        /// <para>
        /// The delivery configuration settings for sending the campaign through a custom channel.
        /// This object is required if the MessageConfiguration object for the campaign specifies
        /// a CustomMessage object.
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
        /// Gets and sets the property Description. 
        /// <para>
        /// A custom description of the campaign.
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
        public int HoldoutPercent
        {
            get { return this._holdoutPercent.GetValueOrDefault(); }
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
        /// The settings for the AWS Lambda function to invoke as a code hook for the campaign.
        /// You can use this hook to customize the segment that's used by the campaign.
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
        /// Gets and sets the property IsPaused. 
        /// <para>
        /// Specifies whether to pause the campaign. A paused campaign doesn't run unless you
        /// resume it by changing this value to false.
        /// </para>
        /// </summary>
        public bool IsPaused
        {
            get { return this._isPaused.GetValueOrDefault(); }
            set { this._isPaused = value; }
        }

        // Check to see if IsPaused property is set
        internal bool IsSetIsPaused()
        {
            return this._isPaused.HasValue; 
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
        /// A custom name for the campaign.
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
        /// The unique identifier for the segment to associate with the campaign.
        /// </para>
        /// </summary>
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
        /// The version of the segment to associate with the campaign.
        /// </para>
        /// </summary>
        public int SegmentVersion
        {
            get { return this._segmentVersion.GetValueOrDefault(); }
            set { this._segmentVersion = value; }
        }

        // Check to see if SegmentVersion property is set
        internal bool IsSetSegmentVersion()
        {
            return this._segmentVersion.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A string-to-string map of key-value pairs that defines the tags to associate with
        /// the campaign. Each tag consists of a required tag key and an associated tag value.
        /// </para>
        /// </summary>
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property TemplateConfiguration. 
        /// <para>
        /// The message template to use for the campaign.
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
        /// A custom description of the default treatment for the campaign.
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
        /// A custom name of the default treatment for the campaign, if the campaign has multiple
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

    }
}