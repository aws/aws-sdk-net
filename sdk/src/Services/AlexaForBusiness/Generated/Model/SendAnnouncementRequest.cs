/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the alexaforbusiness-2017-11-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AlexaForBusiness.Model
{
    /// <summary>
    /// Container for the parameters to the SendAnnouncement operation.
    /// Triggers an asynchronous flow to send text, SSML, or audio announcements to rooms
    /// that are identified by a search or filter.
    /// </summary>
    public partial class SendAnnouncementRequest : AmazonAlexaForBusinessRequest
    {
        private string _clientRequestToken;
        private Content _content;
        private List<Filter> _roomFilters = new List<Filter>();
        private int? _timeToLiveInSeconds;

        /// <summary>
        /// Gets and sets the property ClientRequestToken. 
        /// <para>
        /// The unique, user-specified identifier for the request that ensures idempotency.
        /// </para>
        /// </summary>
        [AWSProperty(Min=10, Max=150)]
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
        /// Gets and sets the property Content. 
        /// <para>
        /// The announcement content. This can contain only one of the three possible announcement
        /// types (text, SSML or audio).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Content Content
        {
            get { return this._content; }
            set { this._content = value; }
        }

        // Check to see if Content property is set
        internal bool IsSetContent()
        {
            return this._content != null;
        }

        /// <summary>
        /// Gets and sets the property RoomFilters. 
        /// <para>
        /// The filters to use to send an announcement to a specified list of rooms. The supported
        /// filter keys are RoomName, ProfileName, RoomArn, and ProfileArn. To send to all rooms,
        /// specify an empty RoomFilters list.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=25)]
        public List<Filter> RoomFilters
        {
            get { return this._roomFilters; }
            set { this._roomFilters = value; }
        }

        // Check to see if RoomFilters property is set
        internal bool IsSetRoomFilters()
        {
            return this._roomFilters != null && this._roomFilters.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property TimeToLiveInSeconds. 
        /// <para>
        /// The time to live for an announcement. Default is 300. If delivery doesn't occur within
        /// this time, the announcement is not delivered.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=3600)]
        public int TimeToLiveInSeconds
        {
            get { return this._timeToLiveInSeconds.GetValueOrDefault(); }
            set { this._timeToLiveInSeconds = value; }
        }

        // Check to see if TimeToLiveInSeconds property is set
        internal bool IsSetTimeToLiveInSeconds()
        {
            return this._timeToLiveInSeconds.HasValue; 
        }

    }
}