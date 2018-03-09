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
 * Do not modify this file. This file is generated from the pinpoint-2016-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Pinpoint.Model
{
    /// <summary>
    /// Campaign definition
    /// </summary>
    public partial class CampaignResponse
    {
        private List<TreatmentResource> _additionalTreatments = new List<TreatmentResource>();
        private string _applicationId;
        private string _creationDate;
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
        private Schedule _schedule;
        private string _segmentId;
        private int? _segmentVersion;
        private CampaignState _state;
        private string _treatmentDescription;
        private string _treatmentName;
        private int? _version;

        /// <summary>
        /// Gets and sets the property AdditionalTreatments. Treatments that are defined in addition
        /// to the default treatment.
        /// </summary>
        public List<TreatmentResource> AdditionalTreatments
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
        /// Gets and sets the property ApplicationId. The ID of the application to which the campaign
        /// applies.
        /// </summary>
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
        /// Gets and sets the property CreationDate. The date the campaign was created in ISO
        /// 8601 format.
        /// </summary>
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
        /// Gets and sets the property DefaultState. The status of the campaign's default treatment.
        /// Only present for A/B test campaigns.
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
        /// Gets and sets the property Description. A description of the campaign.
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
        /// Gets and sets the property HoldoutPercent. The allocated percentage of end users who
        /// will not receive messages from this campaign.
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
        /// Gets and sets the property Hook. Campaign hook information.
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
        /// Gets and sets the property Id. The unique campaign ID.
        /// </summary>
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
        /// Gets and sets the property IsPaused. Indicates whether the campaign is paused. A paused
        /// campaign does not send messages unless you resume it by setting IsPaused to false.
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
        /// Gets and sets the property LastModifiedDate. The date the campaign was last updated
        /// in ISO 8601 format.
        /// </summary>
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
        /// Gets and sets the property Limits. The campaign limits settings.
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
        /// Gets and sets the property MessageConfiguration. The message configuration settings.
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
        /// Gets and sets the property Name. The custom name of the campaign.
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
        /// Gets and sets the property Schedule. The campaign schedule.
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
        /// Gets and sets the property SegmentId. The ID of the segment to which the campaign
        /// sends messages.
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
        /// Gets and sets the property SegmentVersion. The version of the segment to which the
        /// campaign sends messages.
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
        /// Gets and sets the property State. The campaign status.An A/B test campaign will have
        /// a status of COMPLETED only when all treatments have a status of COMPLETED.
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
        /// Gets and sets the property TreatmentDescription. A custom description for the treatment.
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
        /// Gets and sets the property TreatmentName. The custom name of a variation of the campaign
        /// used for A/B testing.
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
        /// Gets and sets the property Version. The campaign version number.
        /// </summary>
        public int Version
        {
            get { return this._version.GetValueOrDefault(); }
            set { this._version = value; }
        }

        // Check to see if Version property is set
        internal bool IsSetVersion()
        {
            return this._version.HasValue; 
        }

    }
}