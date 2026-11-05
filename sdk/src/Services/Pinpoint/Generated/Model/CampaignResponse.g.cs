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
    /// Provides information about the status, configuration, and other settings for a campaign.
    /// </summary>
    public partial class CampaignResponse
    {
        /// <summary>
        /// Gets and sets the property AdditionalTreatments. 
        /// <para>
        /// An array of responses, one for each treatment that you defined for the campaign, in
        /// addition to the default treatment.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<TreatmentResource> AdditionalTreatments { get; set; } = AWSConfigs.InitializeCollections ? new List<TreatmentResource>() : null;

        /// <summary>
        /// Checks to see if the AdditionalTreatments property is set.
        /// </summary>
        internal bool IsSetAdditionalTreatments() => this.AdditionalTreatments != null && (this.AdditionalTreatments.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ApplicationId. 
        /// <para>
        /// The unique identifier for the application that the campaign applies to.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ApplicationId { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationId property is set.
        /// </summary>
        internal bool IsSetApplicationId() => this.ApplicationId != null;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the campaign.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property CreationDate. 
        /// <para>
        /// The date, in ISO 8601 format, when the campaign was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string CreationDate { get; set; }

        /// <summary>
        /// Checks to see if the CreationDate property is set.
        /// </summary>
        internal bool IsSetCreationDate() => this.CreationDate != null;

        /// <summary>
        /// Gets and sets the property CustomDeliveryConfiguration. 
        /// <para>
        /// The delivery configuration settings for sending the campaign through a custom channel.
        /// </para>
        /// </summary>
        public CustomDeliveryConfiguration CustomDeliveryConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the CustomDeliveryConfiguration property is set.
        /// </summary>
        internal bool IsSetCustomDeliveryConfiguration() => this.CustomDeliveryConfiguration != null;

        /// <summary>
        /// Gets and sets the property DefaultState. 
        /// <para>
        /// The current status of the campaign's default treatment. This value exists only for
        /// campaigns that have more than one treatment.
        /// </para>
        /// </summary>
        public CampaignState DefaultState { get; set; }

        /// <summary>
        /// Checks to see if the DefaultState property is set.
        /// </summary>
        internal bool IsSetDefaultState() => this.DefaultState != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The custom description of the campaign.
        /// </para>
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property HoldoutPercent. 
        /// <para>
        /// The allocated percentage of users (segment members) who shouldn't receive messages
        /// from the campaign.
        /// </para>
        /// </summary>
        public int? HoldoutPercent { get; set; }

        /// <summary>
        /// Checks to see if the HoldoutPercent property is set.
        /// </summary>
        internal bool IsSetHoldoutPercent() => this.HoldoutPercent.HasValue;

        /// <summary>
        /// Gets and sets the property Hook. 
        /// <para>
        /// The settings for the AWS Lambda function to use as a code hook for the campaign. You
        /// can use this hook to customize the segment that's used by the campaign.
        /// </para>
        /// </summary>
        public CampaignHook Hook { get; set; }

        /// <summary>
        /// Checks to see if the Hook property is set.
        /// </summary>
        internal bool IsSetHook() => this.Hook != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The unique identifier for the campaign.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property IsPaused. 
        /// <para>
        /// Specifies whether the campaign is paused. A paused campaign doesn't run unless you
        /// resume it by changing this value to false.
        /// </para>
        /// </summary>
        public bool? IsPaused { get; set; }

        /// <summary>
        /// Checks to see if the IsPaused property is set.
        /// </summary>
        internal bool IsSetIsPaused() => this.IsPaused.HasValue;

        /// <summary>
        /// Gets and sets the property LastModifiedDate. 
        /// <para>
        /// The date, in ISO 8601 format, when the campaign was last modified.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string LastModifiedDate { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedDate property is set.
        /// </summary>
        internal bool IsSetLastModifiedDate() => this.LastModifiedDate != null;

        /// <summary>
        /// Gets and sets the property Limits. 
        /// <para>
        /// The messaging limits for the campaign.
        /// </para>
        /// </summary>
        public CampaignLimits Limits { get; set; }

        /// <summary>
        /// Checks to see if the Limits property is set.
        /// </summary>
        internal bool IsSetLimits() => this.Limits != null;

        /// <summary>
        /// Gets and sets the property MessageConfiguration. 
        /// <para>
        /// The message configuration settings for the campaign.
        /// </para>
        /// </summary>
        public MessageConfiguration MessageConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the MessageConfiguration property is set.
        /// </summary>
        internal bool IsSetMessageConfiguration() => this.MessageConfiguration != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the campaign.
        /// </para>
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Priority. 
        /// <para>
        /// Defines the priority of the campaign, used to decide the order of messages displayed
        /// to user if there are multiple messages scheduled to be displayed at the same moment.
        /// </para>
        /// </summary>
        public int? Priority { get; set; }

        /// <summary>
        /// Checks to see if the Priority property is set.
        /// </summary>
        internal bool IsSetPriority() => this.Priority.HasValue;

        /// <summary>
        /// Gets and sets the property Schedule. 
        /// <para>
        /// The schedule settings for the campaign.
        /// </para>
        /// </summary>
        public Schedule Schedule { get; set; }

        /// <summary>
        /// Checks to see if the Schedule property is set.
        /// </summary>
        internal bool IsSetSchedule() => this.Schedule != null;

        /// <summary>
        /// Gets and sets the property SegmentId. 
        /// <para>
        /// The unique identifier for the segment that's associated with the campaign.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string SegmentId { get; set; }

        /// <summary>
        /// Checks to see if the SegmentId property is set.
        /// </summary>
        internal bool IsSetSegmentId() => this.SegmentId != null;

        /// <summary>
        /// Gets and sets the property SegmentVersion. 
        /// <para>
        /// The version number of the segment that's associated with the campaign.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? SegmentVersion { get; set; }

        /// <summary>
        /// Checks to see if the SegmentVersion property is set.
        /// </summary>
        internal bool IsSetSegmentVersion() => this.SegmentVersion.HasValue;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The current status of the campaign.
        /// </para>
        /// </summary>
        public CampaignState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A string-to-string map of key-value pairs that identifies the tags that are associated
        /// with the campaign. Each tag consists of a required tag key and an associated tag value.
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

        /// <summary>
        /// Gets and sets the property TemplateConfiguration. 
        /// <para>
        /// The message template that’s used for the campaign.
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
        /// The custom description of the default treatment for the campaign.
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
        /// The custom name of the default treatment for the campaign, if the campaign has multiple
        /// treatments. A <i>treatment</i> is a variation of a campaign that's used for A/B testing.
        /// </para>
        /// </summary>
        public string TreatmentName { get; set; }

        /// <summary>
        /// Checks to see if the TreatmentName property is set.
        /// </summary>
        internal bool IsSetTreatmentName() => this.TreatmentName != null;

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// The version number of the campaign.
        /// </para>
        /// </summary>
        public int? Version { get; set; }

        /// <summary>
        /// Checks to see if the Version property is set.
        /// </summary>
        internal bool IsSetVersion() => this.Version.HasValue;
    }
}
