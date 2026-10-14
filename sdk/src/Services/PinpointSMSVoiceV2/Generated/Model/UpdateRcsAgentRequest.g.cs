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

namespace Amazon.PinpointSMSVoiceV2.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateRcsAgent operation. Updates the configuration
    /// of an existing RCS agent. You can update the opt-out list, deletion protection, two-way
    /// messaging settings, and self-managed opt-outs configuration.
    /// </summary>
    public partial class UpdateRcsAgentRequest : AmazonPinpointSMSVoiceV2Request
    {
        /// <summary>
        /// Gets and sets the property DeletionProtectionEnabled. 
        /// <para>
        /// By default this is set to false. When set to true the RCS agent can't be deleted.
        /// </para>
        /// </summary>
        public bool? DeletionProtectionEnabled { get; set; }

        /// <summary>
        /// Checks to see if the DeletionProtectionEnabled property is set.
        /// </summary>
        internal bool IsSetDeletionProtectionEnabled() => this.DeletionProtectionEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property OptOutListName. 
        /// <para>
        /// The OptOutList to associate with the RCS agent. Valid values are either OptOutListName
        /// or OptOutListArn.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string OptOutListName { get; set; }

        /// <summary>
        /// Checks to see if the OptOutListName property is set.
        /// </summary>
        internal bool IsSetOptOutListName() => this.OptOutListName != null;

        /// <summary>
        /// Gets and sets the property RcsAgentId. 
        /// <para>
        /// The unique identifier of the RCS agent to update. You can use either the RcsAgentId
        /// or RcsAgentArn.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string RcsAgentId { get; set; }

        /// <summary>
        /// Checks to see if the RcsAgentId property is set.
        /// </summary>
        internal bool IsSetRcsAgentId() => this.RcsAgentId != null;

        /// <summary>
        /// Gets and sets the property SelfManagedOptOutsEnabled. 
        /// <para>
        /// By default this is set to false. When set to true you're responsible for responding
        /// to HELP and STOP requests. You're also responsible for tracking and honoring opt-out
        /// requests.
        /// </para>
        /// </summary>
        public bool? SelfManagedOptOutsEnabled { get; set; }

        /// <summary>
        /// Checks to see if the SelfManagedOptOutsEnabled property is set.
        /// </summary>
        internal bool IsSetSelfManagedOptOutsEnabled() => this.SelfManagedOptOutsEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property TwoWayChannelArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the two way channel.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string TwoWayChannelArn { get; set; }

        /// <summary>
        /// Checks to see if the TwoWayChannelArn property is set.
        /// </summary>
        internal bool IsSetTwoWayChannelArn() => this.TwoWayChannelArn != null;

        /// <summary>
        /// Gets and sets the property TwoWayChannelRole. 
        /// <para>
        /// An optional IAM Role Arn for a service to assume, to be able to post inbound SMS messages.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string TwoWayChannelRole { get; set; }

        /// <summary>
        /// Checks to see if the TwoWayChannelRole property is set.
        /// </summary>
        internal bool IsSetTwoWayChannelRole() => this.TwoWayChannelRole != null;

        /// <summary>
        /// Gets and sets the property TwoWayEnabled. 
        /// <para>
        /// By default this is set to false. When set to true you can receive incoming text messages
        /// from your end recipients.
        /// </para>
        /// </summary>
        public bool? TwoWayEnabled { get; set; }

        /// <summary>
        /// Checks to see if the TwoWayEnabled property is set.
        /// </summary>
        internal bool IsSetTwoWayEnabled() => this.TwoWayEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property TwoWayMediaS3BucketName. 
        /// <para>
        /// The name of the S3 bucket where inbound RCS media files are stored. Two-way messaging
        /// must be enabled on the agent. To remove the media configuration, pass the sentinel
        /// value <c>UNSET_RCS_MEDIA_CONFIGURATION</c> for both this field and TwoWayMediaS3Role.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 3, Max = 63)]
        public string TwoWayMediaS3BucketName { get; set; }

        /// <summary>
        /// Checks to see if the TwoWayMediaS3BucketName property is set.
        /// </summary>
        internal bool IsSetTwoWayMediaS3BucketName() => this.TwoWayMediaS3BucketName != null;

        /// <summary>
        /// Gets and sets the property TwoWayMediaS3KeyPrefix. 
        /// <para>
        /// The key prefix used for inbound RCS media objects in the S3 bucket.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string TwoWayMediaS3KeyPrefix { get; set; }

        /// <summary>
        /// Checks to see if the TwoWayMediaS3KeyPrefix property is set.
        /// </summary>
        internal bool IsSetTwoWayMediaS3KeyPrefix() => this.TwoWayMediaS3KeyPrefix != null;

        /// <summary>
        /// Gets and sets the property TwoWayMediaS3Role. 
        /// <para>
        /// The ARN of the IAM role used to write inbound RCS media files to the S3 bucket. The
        /// role must have <c>s3:PutObject</c> permission on the bucket and a trust policy allowing
        /// <c>sms-voice.amazonaws.com</c> to assume it. To remove the media configuration, pass
        /// the sentinel value <c>UNSET_RCS_MEDIA_CONFIGURATION</c> for both this field and TwoWayMediaS3BucketName.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string TwoWayMediaS3Role { get; set; }

        /// <summary>
        /// Checks to see if the TwoWayMediaS3Role property is set.
        /// </summary>
        internal bool IsSetTwoWayMediaS3Role() => this.TwoWayMediaS3Role != null;

        /// <summary>
        /// Gets and sets the property TwoWayRcsEventsEnabled. 
        /// <para>
        /// The list of RCS event types to enable for two-way messaging. Pass an empty list to
        /// disable all event types. The special value <c>ALL</c> enables all current and future
        /// event types and must be the sole element if used.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public List<string> TwoWayRcsEventsEnabled { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the TwoWayRcsEventsEnabled property is set.
        /// </summary>
        internal bool IsSetTwoWayRcsEventsEnabled() => this.TwoWayRcsEventsEnabled != null && (this.TwoWayRcsEventsEnabled.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
