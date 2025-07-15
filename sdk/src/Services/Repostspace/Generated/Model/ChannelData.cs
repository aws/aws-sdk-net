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
 * Do not modify this file. This file is generated from the repostspace-2022-05-13.normal.json service model.
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
namespace Amazon.Repostspace.Model
{
    /// <summary>
    /// A structure that contains some information about a channel in a private re:Post.
    /// </summary>
    public partial class ChannelData
    {
        private string _channelDescription;
        private string _channelId;
        private string _channelName;
        private ChannelStatus _channelStatus;
        private DateTime? _createDateTime;
        private DateTime? _deleteDateTime;
        private int? _groupCount;
        private string _spaceId;
        private int? _userCount;

        /// <summary>
        /// Gets and sets the property ChannelDescription. 
        /// <para>
        /// A description for the channel. This is used only to help you identify this channel.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=255)]
        public string ChannelDescription
        {
            get { return this._channelDescription; }
            set { this._channelDescription = value; }
        }

        // Check to see if ChannelDescription property is set
        internal bool IsSetChannelDescription()
        {
            return this._channelDescription != null;
        }

        /// <summary>
        /// Gets and sets the property ChannelId. 
        /// <para>
        /// The unique ID of the private re:Post channel.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=24, Max=24)]
        public string ChannelId
        {
            get { return this._channelId; }
            set { this._channelId = value; }
        }

        // Check to see if ChannelId property is set
        internal bool IsSetChannelId()
        {
            return this._channelId != null;
        }

        /// <summary>
        /// Gets and sets the property ChannelName. 
        /// <para>
        /// The name for the channel. This must be unique per private re:Post.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=64)]
        public string ChannelName
        {
            get { return this._channelName; }
            set { this._channelName = value; }
        }

        // Check to see if ChannelName property is set
        internal bool IsSetChannelName()
        {
            return this._channelName != null;
        }

        /// <summary>
        /// Gets and sets the property ChannelStatus. 
        /// <para>
        /// The status pf the channel.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ChannelStatus ChannelStatus
        {
            get { return this._channelStatus; }
            set { this._channelStatus = value; }
        }

        // Check to see if ChannelStatus property is set
        internal bool IsSetChannelStatus()
        {
            return this._channelStatus != null;
        }

        /// <summary>
        /// Gets and sets the property CreateDateTime. 
        /// <para>
        /// The date when the channel was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? CreateDateTime
        {
            get { return this._createDateTime; }
            set { this._createDateTime = value; }
        }

        // Check to see if CreateDateTime property is set
        internal bool IsSetCreateDateTime()
        {
            return this._createDateTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DeleteDateTime. 
        /// <para>
        /// The date when the channel was deleted.
        /// </para>
        /// </summary>
        public DateTime? DeleteDateTime
        {
            get { return this._deleteDateTime; }
            set { this._deleteDateTime = value; }
        }

        // Check to see if DeleteDateTime property is set
        internal bool IsSetDeleteDateTime()
        {
            return this._deleteDateTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property GroupCount. 
        /// <para>
        /// The number of groups that are part of the channel.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? GroupCount
        {
            get { return this._groupCount; }
            set { this._groupCount = value; }
        }

        // Check to see if GroupCount property is set
        internal bool IsSetGroupCount()
        {
            return this._groupCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SpaceId. 
        /// <para>
        /// The unique ID of the private re:Post.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string SpaceId
        {
            get { return this._spaceId; }
            set { this._spaceId = value; }
        }

        // Check to see if SpaceId property is set
        internal bool IsSetSpaceId()
        {
            return this._spaceId != null;
        }

        /// <summary>
        /// Gets and sets the property UserCount. 
        /// <para>
        /// The number of users that are part of the channel.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? UserCount
        {
            get { return this._userCount; }
            set { this._userCount = value; }
        }

        // Check to see if UserCount property is set
        internal bool IsSetUserCount()
        {
            return this._userCount.HasValue; 
        }

    }
}