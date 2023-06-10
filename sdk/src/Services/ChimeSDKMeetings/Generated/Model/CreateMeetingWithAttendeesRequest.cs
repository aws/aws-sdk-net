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
 * Do not modify this file. This file is generated from the chime-sdk-meetings-2021-07-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ChimeSDKMeetings.Model
{
    /// <summary>
    /// Container for the parameters to the CreateMeetingWithAttendees operation.
    /// Creates a new Amazon Chime SDK meeting in the specified media Region, with attendees.
    /// For more information about specifying media Regions, see <a href="https://docs.aws.amazon.com/chime/latest/dg/chime-sdk-meetings-regions.html">Amazon
    /// Chime SDK Media Regions</a> in the <i>Amazon Chime Developer Guide</i>. For more information
    /// about the Amazon Chime SDK, see <a href="https://docs.aws.amazon.com/chime/latest/dg/meetings-sdk.html">Using
    /// the Amazon Chime SDK</a> in the <i>Amazon Chime Developer Guide</i>.
    /// </summary>
    public partial class CreateMeetingWithAttendeesRequest : AmazonChimeSDKMeetingsRequest
    {
        private List<CreateAttendeeRequestItem> _attendees = new List<CreateAttendeeRequestItem>();
        private string _clientRequestToken;
        private string _externalMeetingId;
        private string _mediaRegion;
        private MeetingFeaturesConfiguration _meetingFeatures;
        private string _meetingHostId;
        private NotificationsConfiguration _notificationsConfiguration;
        private string _primaryMeetingId;
        private List<Tag> _tags = new List<Tag>();
        private List<string> _tenantIds = new List<string>();

        /// <summary>
        /// Gets and sets the property Attendees. 
        /// <para>
        /// The attendee information, including attendees' IDs and join tokens.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=20)]
        public List<CreateAttendeeRequestItem> Attendees
        {
            get { return this._attendees; }
            set { this._attendees = value; }
        }

        // Check to see if Attendees property is set
        internal bool IsSetAttendees()
        {
            return this._attendees != null && this._attendees.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ClientRequestToken. 
        /// <para>
        /// The unique identifier for the client request. Use a different token for different
        /// meetings.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=2, Max=64)]
        public string ClientRequestToken
        {
            get { return this._clientRequestToken; }
            set { this._clientRequestToken = value; }
        }

        // Check to see if ClientRequestToken property is set
        internal bool IsSetClientRequestToken()
        {
            return this._clientRequestToken != null;
        }

        /// <summary>
        /// Gets and sets the property ExternalMeetingId. 
        /// <para>
        /// The external meeting ID.
        /// </para>
        ///  
        /// <para>
        /// Pattern: <code>[-_&amp;@+=,(){}\[\]\/«».:|'"#a-zA-Z0-9À-ÿ\s]*</code> 
        /// </para>
        ///  
        /// <para>
        /// Values that begin with <code>aws:</code> are reserved. You can't configure a value
        /// that uses this prefix. Case insensitive.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=2, Max=64)]
        public string ExternalMeetingId
        {
            get { return this._externalMeetingId; }
            set { this._externalMeetingId = value; }
        }

        // Check to see if ExternalMeetingId property is set
        internal bool IsSetExternalMeetingId()
        {
            return this._externalMeetingId != null;
        }

        /// <summary>
        /// Gets and sets the property MediaRegion. 
        /// <para>
        /// The Region in which to create the meeting.
        /// </para>
        ///  
        /// <para>
        ///  Available values: <code>af-south-1</code>, <code>ap-northeast-1</code>, <code>ap-northeast-2</code>,
        /// <code>ap-south-1</code>, <code>ap-southeast-1</code>, <code>ap-southeast-2</code>,
        /// <code>ca-central-1</code>, <code>eu-central-1</code>, <code>eu-north-1</code>, <code>eu-south-1</code>,
        /// <code>eu-west-1</code>, <code>eu-west-2</code>, <code>eu-west-3</code>, <code>sa-east-1</code>,
        /// <code>us-east-1</code>, <code>us-east-2</code>, <code>us-west-1</code>, <code>us-west-2</code>.
        /// 
        /// </para>
        ///  
        /// <para>
        /// Available values in AWS GovCloud (US) Regions: <code>us-gov-east-1</code>, <code>us-gov-west-1</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=2, Max=64)]
        public string MediaRegion
        {
            get { return this._mediaRegion; }
            set { this._mediaRegion = value; }
        }

        // Check to see if MediaRegion property is set
        internal bool IsSetMediaRegion()
        {
            return this._mediaRegion != null;
        }

        /// <summary>
        /// Gets and sets the property MeetingFeatures. 
        /// <para>
        /// Lists the audio and video features enabled for a meeting, such as echo reduction.
        /// </para>
        /// </summary>
        public MeetingFeaturesConfiguration MeetingFeatures
        {
            get { return this._meetingFeatures; }
            set { this._meetingFeatures = value; }
        }

        // Check to see if MeetingFeatures property is set
        internal bool IsSetMeetingFeatures()
        {
            return this._meetingFeatures != null;
        }

        /// <summary>
        /// Gets and sets the property MeetingHostId. 
        /// <para>
        /// Reserved.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=2, Max=64)]
        public string MeetingHostId
        {
            get { return this._meetingHostId; }
            set { this._meetingHostId = value; }
        }

        // Check to see if MeetingHostId property is set
        internal bool IsSetMeetingHostId()
        {
            return this._meetingHostId != null;
        }

        /// <summary>
        /// Gets and sets the property NotificationsConfiguration. 
        /// <para>
        /// The configuration for resource targets to receive notifications when meeting and attendee
        /// events occur.
        /// </para>
        /// </summary>
        public NotificationsConfiguration NotificationsConfiguration
        {
            get { return this._notificationsConfiguration; }
            set { this._notificationsConfiguration = value; }
        }

        // Check to see if NotificationsConfiguration property is set
        internal bool IsSetNotificationsConfiguration()
        {
            return this._notificationsConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property PrimaryMeetingId. 
        /// <para>
        /// When specified, replicates the media from the primary meeting to the new meeting.
        /// </para>
        /// </summary>
        [AWSProperty(Min=2, Max=64)]
        public string PrimaryMeetingId
        {
            get { return this._primaryMeetingId; }
            set { this._primaryMeetingId = value; }
        }

        // Check to see if PrimaryMeetingId property is set
        internal bool IsSetPrimaryMeetingId()
        {
            return this._primaryMeetingId != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags in the request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public List<Tag> Tags
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
        /// Gets and sets the property TenantIds. 
        /// <para>
        /// A consistent and opaque identifier, created and maintained by the builder to represent
        /// a segment of their users.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=5)]
        public List<string> TenantIds
        {
            get { return this._tenantIds; }
            set { this._tenantIds = value; }
        }

        // Check to see if TenantIds property is set
        internal bool IsSetTenantIds()
        {
            return this._tenantIds != null && this._tenantIds.Count > 0; 
        }

    }
}