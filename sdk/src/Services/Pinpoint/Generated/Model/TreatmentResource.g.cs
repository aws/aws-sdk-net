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

namespace Amazon.Pinpoint.Model
{
    /// <summary>
    /// Specifies the settings for a campaign treatment. A <i>treatment</i> is a variation
    /// of a campaign that's used for A/B testing of a campaign.
    /// </summary>
    public partial class TreatmentResource
    {
        /// <summary>
        /// Gets and sets the property CustomDeliveryConfiguration. 
        /// <para>
        /// The delivery configuration settings for sending the treatment through a custom channel.
        /// This object is required if the MessageConfiguration object for the treatment specifies
        /// a CustomMessage object.
        /// </para>
        /// </summary>
        public CustomDeliveryConfiguration CustomDeliveryConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the CustomDeliveryConfiguration property is set.
        /// </summary>
        internal bool IsSetCustomDeliveryConfiguration() => this.CustomDeliveryConfiguration != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The unique identifier for the treatment.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property MessageConfiguration. 
        /// <para>
        /// The message configuration settings for the treatment.
        /// </para>
        /// </summary>
        public MessageConfiguration MessageConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the MessageConfiguration property is set.
        /// </summary>
        internal bool IsSetMessageConfiguration() => this.MessageConfiguration != null;

        /// <summary>
        /// Gets and sets the property Schedule. 
        /// <para>
        /// The schedule settings for the treatment.
        /// </para>
        /// </summary>
        public Schedule Schedule { get; set; }

        /// <summary>
        /// Checks to see if the Schedule property is set.
        /// </summary>
        internal bool IsSetSchedule() => this.Schedule != null;

        /// <summary>
        /// Gets and sets the property SizePercent. 
        /// <para>
        /// The allocated percentage of users (segment members) that the treatment is sent to.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? SizePercent { get; set; }

        /// <summary>
        /// Checks to see if the SizePercent property is set.
        /// </summary>
        internal bool IsSetSizePercent() => this.SizePercent.HasValue;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The current status of the treatment.
        /// </para>
        /// </summary>
        public CampaignState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;

        /// <summary>
        /// Gets and sets the property TemplateConfiguration. 
        /// <para>
        /// The message template to use for the treatment.
        /// </para>
        /// </summary>
        public TemplateConfiguration TemplateConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the TemplateConfiguration property is set.
        /// </summary>
        internal bool IsSetTemplateConfiguration() => this.TemplateConfiguration != null;

        /// <summary>
        /// Gets and sets the property TreatmentDescription. 
        /// <para>
        /// The custom description of the treatment.
        /// </para>
        /// </summary>
        public string TreatmentDescription { get; set; }

        /// <summary>
        /// Checks to see if the TreatmentDescription property is set.
        /// </summary>
        internal bool IsSetTreatmentDescription() => this.TreatmentDescription != null;

        /// <summary>
        /// Gets and sets the property TreatmentName. 
        /// <para>
        /// The custom name of the treatment.
        /// </para>
        /// </summary>
        public string TreatmentName { get; set; }

        /// <summary>
        /// Checks to see if the TreatmentName property is set.
        /// </summary>
        internal bool IsSetTreatmentName() => this.TreatmentName != null;
    }
}
