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
    /// This is the response object from the GetChannel operation.
    /// </summary>
    public partial class GetChannelResponse : AmazonWebServiceResponse
    {
        private string _channelDescription;
        private string _channelId;
        private string _channelName;
        private Dictionary<string, List<string>> _channelRoles = AWSConfigs.InitializeCollections ? new Dictionary<string, List<string>>() : null;
        private ChannelStatus _channelStatus;
        private DateTime? _createDateTime;
        private DateTime? _deleteDateTime;
        private string _spaceId;

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
        /// Gets and sets the property ChannelRoles. 
        /// <para>
        /// The channel roles associated to the users and groups of the channel.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, List<string>> ChannelRoles
        {
            get { return this._channelRoles; }
            set { this._channelRoles = value; }
        }

        // Check to see if ChannelRoles property is set
        internal bool IsSetChannelRoles()
        {
            return this._channelRoles != null && (this._channelRoles.Count > 0 || !AWSConfigs.InitializeCollections); 
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

    }
}