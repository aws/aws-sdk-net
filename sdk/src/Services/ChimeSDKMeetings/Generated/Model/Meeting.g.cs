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
    /// A meeting created using the Amazon Chime SDK.
    /// </summary>
    public partial class Meeting
    {
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
        [AWSProperty(Sensitive = true, Min = 2, Max = 64)]
        public string ExternalMeetingId { get; set; }

        /// <summary>
        /// Checks to see if the ExternalMeetingId property is set.
        /// </summary>
        internal bool IsSetExternalMeetingId() => this.ExternalMeetingId != null;

        /// <summary>
        /// Gets and sets the property MediaPlacement. 
        /// <para>
        /// The media placement for the meeting.
        /// </para>
        /// </summary>
        public MediaPlacement MediaPlacement { get; set; }

        /// <summary>
        /// Checks to see if the MediaPlacement property is set.
        /// </summary>
        internal bool IsSetMediaPlacement() => this.MediaPlacement != null;

        /// <summary>
        /// Gets and sets the property MediaRegion. 
        /// <para>
        /// The Region in which you create the meeting. Available values: <c>af-south-1</c>, <c>ap-northeast-1</c>,
        /// <c>ap-northeast-2</c>, <c>ap-south-1</c>, <c>ap-southeast-1</c>, <c>ap-southeast-2</c>,
        /// <c>ca-central-1</c>, <c>eu-central-1</c>, <c>eu-north-1</c>, <c>eu-south-1</c>, <c>eu-west-1</c>,
        /// <c>eu-west-2</c>, <c>eu-west-3</c>, <c>sa-east-1</c>, <c>us-east-1</c>, <c>us-east-2</c>,
        /// <c>us-west-1</c>, <c>us-west-2</c>.
        /// </para>
        ///  
        /// <para>
        /// Available values in Amazon Web Services GovCloud (US) Regions: <c>us-gov-east-1</c>,
        /// <c>us-gov-west-1</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 2, Max = 64)]
        public string MediaRegion { get; set; }

        /// <summary>
        /// Checks to see if the MediaRegion property is set.
        /// </summary>
        internal bool IsSetMediaRegion() => this.MediaRegion != null;

        /// <summary>
        /// Gets and sets the property MeetingArn. 
        /// <para>
        /// The ARN of the meeting.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1011)]
        public string MeetingArn { get; set; }

        /// <summary>
        /// Checks to see if the MeetingArn property is set.
        /// </summary>
        internal bool IsSetMeetingArn() => this.MeetingArn != null;

        /// <summary>
        /// Gets and sets the property MeetingFeatures. 
        /// <para>
        /// The features available to a meeting, such as echo reduction.
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
        /// Gets and sets the property MeetingId. 
        /// <para>
        /// The Amazon Chime SDK meeting ID.
        /// </para>
        /// </summary>
        public string MeetingId { get; set; }

        /// <summary>
        /// Checks to see if the MeetingId property is set.
        /// </summary>
        internal bool IsSetMeetingId() => this.MeetingId != null;

        /// <summary>
        /// Gets and sets the property PrimaryMeetingId. 
        /// <para>
        /// When specified, replicates the media from the primary meeting to this meeting.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 2, Max = 64)]
        public string PrimaryMeetingId { get; set; }

        /// <summary>
        /// Checks to see if the PrimaryMeetingId property is set.
        /// </summary>
        internal bool IsSetPrimaryMeetingId() => this.PrimaryMeetingId != null;

        /// <summary>
        /// Gets and sets the property TenantIds. 
        /// <para>
        /// Array of strings.
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
