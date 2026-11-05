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
    /// Specifies the configuration and other settings for a campaign.
    /// </summary>
    public partial class WriteCampaignRequest
    {
        /// <summary>
        /// Gets and sets the property AdditionalTreatments. 
        /// <para>
        /// An array of requests that defines additional treatments for the campaign, in addition
        /// to the default treatment for the campaign.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<WriteTreatmentResource> AdditionalTreatments { get; set; } = AWSConfigs.InitializeCollections ? new List<WriteTreatmentResource>() : null;

        /// <summary>
        /// Checks to see if the AdditionalTreatments property is set.
        /// </summary>
        internal bool IsSetAdditionalTreatments() => this.AdditionalTreatments != null && (this.AdditionalTreatments.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property CustomDeliveryConfiguration. 
        /// <para>
        /// The delivery configuration settings for sending the campaign through a custom channel.
        /// This object is required if the MessageConfiguration object for the campaign specifies
        /// a CustomMessage object.
        /// </para>
        /// </summary>
        public CustomDeliveryConfiguration CustomDeliveryConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the CustomDeliveryConfiguration property is set.
        /// </summary>
        internal bool IsSetCustomDeliveryConfiguration() => this.CustomDeliveryConfiguration != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A custom description of the campaign.
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
        /// The settings for the AWS Lambda function to invoke as a code hook for the campaign.
        /// You can use this hook to customize the segment that's used by the campaign.
        /// </para>
        /// </summary>
        public CampaignHook Hook { get; set; }

        /// <summary>
        /// Checks to see if the Hook property is set.
        /// </summary>
        internal bool IsSetHook() => this.Hook != null;

        /// <summary>
        /// Gets and sets the property IsPaused. 
        /// <para>
        /// Specifies whether to pause the campaign. A paused campaign doesn't run unless you
        /// resume it by changing this value to false.
        /// </para>
        /// </summary>
        public bool? IsPaused { get; set; }

        /// <summary>
        /// Checks to see if the IsPaused property is set.
        /// </summary>
        internal bool IsSetIsPaused() => this.IsPaused.HasValue;

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
        /// A custom name for the campaign.
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
        /// The unique identifier for the segment to associate with the campaign.
        /// </para>
        /// </summary>
        public string SegmentId { get; set; }

        /// <summary>
        /// Checks to see if the SegmentId property is set.
        /// </summary>
        internal bool IsSetSegmentId() => this.SegmentId != null;

        /// <summary>
        /// Gets and sets the property SegmentVersion. 
        /// <para>
        /// The version of the segment to associate with the campaign.
        /// </para>
        /// </summary>
        public int? SegmentVersion { get; set; }

        /// <summary>
        /// Checks to see if the SegmentVersion property is set.
        /// </summary>
        internal bool IsSetSegmentVersion() => this.SegmentVersion.HasValue;

        /// <summary>
        /// Gets and sets the property Tags. <note>
        /// <para>
        /// As of <b>22-05-2023</b> tags has been deprecated for update operations. After this
        /// date any value in tags is not processed and an error code is not returned. To manage
        /// tags we recommend using either <a href="https://docs.aws.amazon.com/pinpoint/latest/apireference/tags-resource-arn.html">Tags</a>
        /// in the <i>API Reference for Amazon Pinpoint</i>, <a href="https://docs.aws.amazon.com/cli/latest/reference/resourcegroupstaggingapi/index.html">resourcegroupstaggingapi</a>
        /// commands in the <i>AWS Command Line Interface Documentation</i> or <a href="https://sdk.amazonaws.com/java/api/latest/software/amazon/awssdk/services/resourcegroupstaggingapi/package-summary.html">resourcegroupstaggingapi</a>
        /// in the <i>AWS SDK</i>.
        /// </para>
        /// </note> 
        /// <para>
        /// (Deprecated) A string-to-string map of key-value pairs that defines the tags to associate
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
        /// The message template to use for the campaign.
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
        /// A custom description of the default treatment for the campaign.
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
        /// A custom name of the default treatment for the campaign, if the campaign has multiple
        /// treatments. A <i>treatment</i> is a variation of a campaign that's used for A/B testing.
        /// </para>
        /// </summary>
        public string TreatmentName { get; set; }

        /// <summary>
        /// Checks to see if the TreatmentName property is set.
        /// </summary>
        internal bool IsSetTreatmentName() => this.TreatmentName != null;
    }
}
