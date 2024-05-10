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
 * Do not modify this file. This file is generated from the chime-2018-05-01.normal.json service model.
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
namespace Amazon.Chime.Model
{
    /// <summary>
    /// Container for the parameters to the CreateMeeting operation.
    /// Creates a new Amazon Chime SDK meeting in the specified media Region with no initial
    /// attendees. For more information about specifying media Regions, see <a href="https://docs.aws.amazon.com/chime-sdk/latest/dg/chime-sdk-meetings-regions.html">Amazon
    /// Chime SDK Media Regions</a> in the <i>Amazon Chime SDK Developer Guide</i> . For more
    /// information about the Amazon Chime SDK, see <a href="https://docs.aws.amazon.com/chime-sdk/latest/dg/meetings-sdk.html">Using
    /// the Amazon Chime SDK</a> in the <i>Amazon Chime SDK Developer Guide</i>.
    /// 
    ///  <important> 
    /// <para>
    ///  <b>This API is is no longer supported and will not be updated.</b> We recommend using
    /// the latest version, <a href="https://docs.aws.amazon.com/chime-sdk/latest/APIReference/API_meeting-chime_CreateMeeting.html">CreateMeeting</a>,
    /// in the Amazon Chime SDK.
    /// </para>
    ///  
    /// <para>
    /// Using the latest version requires migrating to a dedicated namespace. For more information,
    /// refer to <a href="https://docs.aws.amazon.com/chime-sdk/latest/dg/migrate-from-chm-namespace.html">Migrating
    /// from the Amazon Chime namespace</a> in the <i>Amazon Chime SDK Developer Guide</i>.
    /// </para>
    ///  </important>
    /// </summary>
    public partial class CreateMeetingRequest : AmazonChimeRequest
    {
        private string _clientRequestToken;
        private string _externalMeetingId;
        private string _mediaRegion;
        private string _meetingHostId;
        private MeetingNotificationConfiguration _notificationsConfiguration;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

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
        /// </summary>
        [AWSProperty(Sensitive=true, Min=2, Max=64)]
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
        ///  The Region in which to create the meeting. Default: <c>us-east-1</c>. 
        /// </para>
        ///  
        /// <para>
        ///  Available values: <c>af-south-1</c> , <c>ap-northeast-1</c> , <c>ap-northeast-2</c>
        /// , <c>ap-south-1</c> , <c>ap-southeast-1</c> , <c>ap-southeast-2</c> , <c>ca-central-1</c>
        /// , <c>eu-central-1</c> , <c>eu-north-1</c> , <c>eu-south-1</c> , <c>eu-west-1</c> ,
        /// <c>eu-west-2</c> , <c>eu-west-3</c> , <c>sa-east-1</c> , <c>us-east-1</c> , <c>us-east-2</c>
        /// , <c>us-west-1</c> , <c>us-west-2</c> . 
        /// </para>
        /// </summary>
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
        public MeetingNotificationConfiguration NotificationsConfiguration
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tag key-value pairs.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}