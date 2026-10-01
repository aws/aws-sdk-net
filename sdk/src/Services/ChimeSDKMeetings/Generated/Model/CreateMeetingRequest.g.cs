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

namespace Amazon.ChimeSDKMeetings.Model
{
    /// <summary>
    /// Container for the parameters to the CreateMeeting operation. Creates a new Amazon
    /// Chime SDK meeting in the specified media Region with no initial attendees. For more
    /// information about specifying media Regions, see <a href="https://docs.aws.amazon.com/chime-sdk/latest/dg/sdk-available-regions">Available
    /// Regions</a> and <a href="https://docs.aws.amazon.com/chime-sdk/latest/dg/chime-sdk-meetings-regions.html">Using
    /// meeting Regions</a>, both in the <i>Amazon Chime SDK Developer Guide</i>. For more
    /// information about the Amazon Chime SDK, see <a href="https://docs.aws.amazon.com/chime-sdk/latest/dg/meetings-sdk.html">Using
    /// the Amazon Chime SDK</a> in the <i>Amazon Chime SDK Developer Guide</i>. <note> <para>
    /// If you use this API in conjuction with the and APIs, and you don't specify the <c>MeetingFeatures.Content.MaxResolution</c>
    /// or <c>MeetingFeatures.Video.MaxResolution</c> parameters, the following defaults are
    /// used: </para> <ul> <li> <para> Content.MaxResolution: FHD </para> </li> <li> <para>
    /// Video.MaxResolution: HD </para> </li> </ul> </note>
    /// </summary>
    public partial class CreateMeetingRequest : AmazonChimeSDKMeetingsRequest
    {
        /// <summary>
        /// Gets and sets the property ClientRequestToken. 
        /// <para>
        /// The unique identifier for the client request. Use a different token for different
        /// meetings.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 2, Max = 64)]
        public string ClientRequestToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientRequestToken property is set.
        /// </summary>
        internal bool IsSetClientRequestToken() => this.ClientRequestToken != null;

        /// <summary>
        /// Gets and sets the property ExternalMeetingId. 
        /// <para>
        /// The external meeting ID.
        /// </para>
        ///  
        /// <para>
        /// Pattern: <c>[-_&amp;@+=,(){}\[\]\/«».:|'"#a-zA-Z0-9À-ÿ\s]*</c> 
        /// </para>
        ///  
        /// <para>
        /// Values that begin with <c>aws:</c> are reserved. You can't configure a value that
        /// uses this prefix. Case insensitive.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 2, Max = 64)]
        public string ExternalMeetingId { get; set; }

        /// <summary>
        /// Checks to see if the ExternalMeetingId property is set.
        /// </summary>
        internal bool IsSetExternalMeetingId() => this.ExternalMeetingId != null;

        /// <summary>
        /// Gets and sets the property MediaPlacementNetworkType. 
        /// <para>
        /// The type of network for the media placement. Either IPv4 only or dual-stack (IPv4
        /// and IPv6).
        /// </para>
        /// </summary>
        public MediaPlacementNetworkType MediaPlacementNetworkType { get; set; }

        /// <summary>
        /// Checks to see if the MediaPlacementNetworkType property is set.
        /// </summary>
        internal bool IsSetMediaPlacementNetworkType() => this.MediaPlacementNetworkType != null;

        /// <summary>
        /// Gets and sets the property MediaRegion. 
        /// <para>
        /// The Region in which to create the meeting.
        /// </para>
        ///  
        /// <para>
        ///  Available values: <c>af-south-1</c>, <c>ap-northeast-1</c>, <c>ap-northeast-2</c>,
        /// <c>ap-south-1</c>, <c>ap-southeast-1</c>, <c>ap-southeast-2</c>, <c>ca-central-1</c>,
        /// <c>eu-central-1</c>, <c>eu-north-1</c>, <c>eu-south-1</c>, <c>eu-west-1</c>, <c>eu-west-2</c>,
        /// <c>eu-west-3</c>, <c>sa-east-1</c>, <c>us-east-1</c>, <c>us-east-2</c>, <c>us-west-1</c>,
        /// <c>us-west-2</c>. 
        /// </para>
        ///  
        /// <para>
        /// Available values in Amazon Web Services GovCloud (US) Regions: <c>us-gov-east-1</c>,
        /// <c>us-gov-west-1</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 2, Max = 64)]
        public string MediaRegion { get; set; }

        /// <summary>
        /// Checks to see if the MediaRegion property is set.
        /// </summary>
        internal bool IsSetMediaRegion() => this.MediaRegion != null;

        /// <summary>
        /// Gets and sets the property MeetingFeatures. 
        /// <para>
        /// Lists the audio and video features enabled for a meeting, such as echo reduction.
        /// </para>
        /// </summary>
        public MeetingFeaturesConfiguration MeetingFeatures { get; set; }

        /// <summary>
        /// Checks to see if the MeetingFeatures property is set.
        /// </summary>
        internal bool IsSetMeetingFeatures() => this.MeetingFeatures != null;

        /// <summary>
        /// Gets and sets the property MeetingHostId. 
        /// <para>
        /// Reserved.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 2, Max = 64)]
        public string MeetingHostId { get; set; }

        /// <summary>
        /// Checks to see if the MeetingHostId property is set.
        /// </summary>
        internal bool IsSetMeetingHostId() => this.MeetingHostId != null;

        /// <summary>
        /// Gets and sets the property NotificationsConfiguration. 
        /// <para>
        /// The configuration for resource targets to receive notifications when meeting and attendee
        /// events occur.
        /// </para>
        /// </summary>
        public NotificationsConfiguration NotificationsConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the NotificationsConfiguration property is set.
        /// </summary>
        internal bool IsSetNotificationsConfiguration() => this.NotificationsConfiguration != null;

        /// <summary>
        /// Gets and sets the property PrimaryMeetingId. 
        /// <para>
        /// When specified, replicates the media from the primary meeting to the new meeting.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 2, Max = 64)]
        public string PrimaryMeetingId { get; set; }

        /// <summary>
        /// Checks to see if the PrimaryMeetingId property is set.
        /// </summary>
        internal bool IsSetPrimaryMeetingId() => this.PrimaryMeetingId != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Applies one or more tags to an Amazon Chime SDK meeting. Note the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Not all resources have tags. For a list of services with resources that support tagging
        /// using this operation, see <a href="https://docs.aws.amazon.com/resourcegroupstagging/latest/APIReference/supported-services.html">Services
        /// that support the Resource Groups Tagging API</a>. If the resource doesn't yet support
        /// this operation, the resource's service might support tagging using its own API operations.
        /// For more information, refer to the documentation for that service.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Each resource can have up to 50 tags. For other limits, see <a href="https://docs.aws.amazon.com/general/latest/gr/aws_tagging.html#tag-conventions">Tag
        /// Naming and Usage Conventions</a> in the <i>AWS General Reference</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You can only tag resources that are located in the specified Amazon Web Services Region
        /// for the Amazon Web Services account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To add tags to a resource, you need the necessary permissions for the service that
        /// the resource belongs to as well as permissions for adding tags. For more information,
        /// see the documentation for each service.
        /// </para>
        ///  </li> </ul> <important> 
        /// <para>
        /// Do not store personally identifiable information (PII) or other confidential or sensitive
        /// information in tags. We use tags to provide you with billing and administration services.
        /// Tags are not intended to be used for private or sensitive data.
        /// </para>
        ///  </important> 
        /// <para>
        ///  <b>Minimum permissions</b> 
        /// </para>
        ///  
        /// <para>
        /// In addition to the <c>tag:TagResources</c> permission required by this operation,
        /// you must also have the tagging permission defined by the service that created the
        /// resource. For example, to tag a <c>ChimeSDKMeetings</c> instance using the <c>TagResources</c>
        /// operation, you must have both of the following permissions:
        /// </para>
        ///  
        /// <para>
        ///  <c>tag:TagResources</c> 
        /// </para>
        ///  
        /// <para>
        ///  <c>ChimeSDKMeetings:CreateTags</c> 
        /// </para>
        ///  <note> 
        /// <para>
        /// Some services might have specific requirements for tagging some resources. For example,
        /// to tag an Amazon S3 bucket, you must also have the <c>s3:GetBucketTagging</c> permission.
        /// If the expected minimum permissions don't work, check the documentation for that service's
        /// tagging APIs for more information.
        /// </para>
        ///  </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TenantIds. 
        /// <para>
        /// A consistent and opaque identifier, created and maintained by the builder to represent
        /// a segment of their users.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 5)]
        public List<string> TenantIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the TenantIds property is set.
        /// </summary>
        internal bool IsSetTenantIds() => this.TenantIds != null && (this.TenantIds.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
