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
 * Do not modify this file. This file is generated from the chime-sdk-messaging-2021-05-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ChimeSDKMessaging.Model
{
    /// <summary>
    /// Container for the parameters to the ListChannelMessages operation.
    /// List all the messages in a channel. Returns a paginated list of <code>ChannelMessages</code>.
    /// By default, sorted by creation timestamp in descending order.
    /// 
    ///  <note> 
    /// <para>
    /// Redacted messages appear in the results as empty, since they are only redacted, not
    /// deleted. Deleted messages do not appear in the results. This action always returns
    /// the latest version of an edited message.
    /// </para>
    ///  
    /// <para>
    /// Also, the <code>x-amz-chime-bearer</code> request header is mandatory. Use the ARN
    /// of the <code>AppInstanceUser</code> or <code>AppInstanceBot</code> that makes the
    /// API call as the value in the header.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class ListChannelMessagesRequest : AmazonChimeSDKMessagingRequest
    {
        private string _channelArn;
        private string _chimeBearer;
        private int? _maxResults;
        private string _nextToken;
        private DateTime? _notAfter;
        private DateTime? _notBefore;
        private SortOrder _sortOrder;
        private string _subChannelId;

        /// <summary>
        /// Gets and sets the property ChannelArn. 
        /// <para>
        /// The ARN of the channel.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=5, Max=1600)]
        public string ChannelArn
        {
            get { return this._channelArn; }
            set { this._channelArn = value; }
        }

        // Check to see if ChannelArn property is set
        internal bool IsSetChannelArn()
        {
            return this._channelArn != null;
        }

        /// <summary>
        /// Gets and sets the property ChimeBearer. 
        /// <para>
        /// The ARN of the <code>AppInstanceUser</code> or <code>AppInstanceBot</code> that makes
        /// the API call.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=5, Max=1600)]
        public string ChimeBearer
        {
            get { return this._chimeBearer; }
            set { this._chimeBearer = value; }
        }

        // Check to see if ChimeBearer property is set
        internal bool IsSetChimeBearer()
        {
            return this._chimeBearer != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of messages that you want returned.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public int MaxResults
        {
            get { return this._maxResults.GetValueOrDefault(); }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token passed by previous API calls until all requested messages are returned.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=2048)]
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property NotAfter. 
        /// <para>
        /// The final or ending time stamp for your requested messages.
        /// </para>
        /// </summary>
        public DateTime NotAfter
        {
            get { return this._notAfter.GetValueOrDefault(); }
            set { this._notAfter = value; }
        }

        // Check to see if NotAfter property is set
        internal bool IsSetNotAfter()
        {
            return this._notAfter.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NotBefore. 
        /// <para>
        /// The initial or starting time stamp for your requested messages.
        /// </para>
        /// </summary>
        public DateTime NotBefore
        {
            get { return this._notBefore.GetValueOrDefault(); }
            set { this._notBefore = value; }
        }

        // Check to see if NotBefore property is set
        internal bool IsSetNotBefore()
        {
            return this._notBefore.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SortOrder. 
        /// <para>
        /// The order in which you want messages sorted. Default is Descending, based on time
        /// created.
        /// </para>
        /// </summary>
        public SortOrder SortOrder
        {
            get { return this._sortOrder; }
            set { this._sortOrder = value; }
        }

        // Check to see if SortOrder property is set
        internal bool IsSetSortOrder()
        {
            return this._sortOrder != null;
        }

        /// <summary>
        /// Gets and sets the property SubChannelId. 
        /// <para>
        /// The ID of the SubChannel in the request.
        /// </para>
        ///  <note> 
        /// <para>
        /// Only required when listing the messages in a SubChannel that the user belongs to.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string SubChannelId
        {
            get { return this._subChannelId; }
            set { this._subChannelId = value; }
        }

        // Check to see if SubChannelId property is set
        internal bool IsSetSubChannelId()
        {
            return this._subChannelId != null;
        }

    }
}