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
    /// Specifies the settings for a campaign treatment. A <i>treatment</i> is a variation
    /// of a campaign that's used for A/B testing of a campaign.
    /// </summary>
    public partial class TreatmentResource
    {
        private CustomDeliveryConfiguration _customDeliveryConfiguration;
        private string _id;
        private MessageConfiguration _messageConfiguration;
        private Schedule _schedule;
        private int? _sizePercent;
        private CampaignState _state;
        private TemplateConfiguration _templateConfiguration;
        private string _treatmentDescription;
        private string _treatmentName;

        /// <summary>
        /// Gets and sets the property CustomDeliveryConfiguration. 
        /// <para>
        /// The delivery configuration settings for sending the treatment through a custom channel.
        /// This object is required if the MessageConfiguration object for the treatment specifies
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
        /// Gets and sets the property Id. 
        /// <para>
        /// The unique identifier for the treatment.
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
        /// Gets and sets the property MessageConfiguration. 
        /// <para>
        /// The message configuration settings for the treatment.
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
        /// Gets and sets the property Schedule. 
        /// <para>
        /// The schedule settings for the treatment.
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
        /// Gets and sets the property SizePercent. 
        /// <para>
        /// The allocated percentage of users (segment members) that the treatment is sent to.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? SizePercent
        {
            get { return this._sizePercent; }
            set { this._sizePercent = value; }
        }

        // Check to see if SizePercent property is set
        internal bool IsSetSizePercent()
        {
            return this._sizePercent.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The current status of the treatment.
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
        /// Gets and sets the property TemplateConfiguration. 
        /// <para>
        /// The message template to use for the treatment.
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
        /// The custom description of the treatment.
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
        /// The custom name of the treatment.
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