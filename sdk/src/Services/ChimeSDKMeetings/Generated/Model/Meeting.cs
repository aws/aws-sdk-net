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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.ChimeSDKMeetings.Model
{
    /// <summary>
    /// A meeting created using the Amazon Chime SDK.
    /// </summary>
    public partial class Meeting
    {
        private string _externalMeetingId;
        private MediaPlacement _mediaPlacement;
        private string _mediaRegion;
        private string _meetingArn;
        private MeetingFeaturesConfiguration _meetingFeatures;
        private string _meetingHostId;
        private string _meetingId;
        private string _primaryMeetingId;
        private List<string> _tenantIds = AWSConfigs.InitializeCollections ? new List<string>() : null;

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
        /// Gets and sets the property MediaPlacement. 
        /// <para>
        /// The media placement for the meeting.
        /// </para>
        /// </summary>
        public MediaPlacement MediaPlacement
        {
            get { return this._mediaPlacement; }
            set { this._mediaPlacement = value; }
        }

        // Check to see if MediaPlacement property is set
        internal bool IsSetMediaPlacement()
        {
            return this._mediaPlacement != null;
        }

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
        [AWSProperty(Min=2, Max=64)]
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
        /// Gets and sets the property MeetingArn. 
        /// <para>
        /// The ARN of the meeting.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1011)]
        public string MeetingArn
        {
            get { return this._meetingArn; }
            set { this._meetingArn = value; }
        }

        // Check to see if MeetingArn property is set
        internal bool IsSetMeetingArn()
        {
            return this._meetingArn != null;
        }

        /// <summary>
        /// Gets and sets the property MeetingFeatures. 
        /// <para>
        /// The features available to a meeting, such as echo reduction.
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
        /// Gets and sets the property MeetingId. 
        /// <para>
        /// The Amazon Chime SDK meeting ID.
        /// </para>
        /// </summary>
        public string MeetingId
        {
            get { return this._meetingId; }
            set { this._meetingId = value; }
        }

        // Check to see if MeetingId property is set
        internal bool IsSetMeetingId()
        {
            return this._meetingId != null;
        }

        /// <summary>
        /// Gets and sets the property PrimaryMeetingId. 
        /// <para>
        /// When specified, replicates the media from the primary meeting to this meeting.
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
        /// Gets and sets the property TenantIds. 
        /// <para>
        /// Array of strings.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._tenantIds != null && (this._tenantIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}