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
 * Do not modify this file. This file is generated from the logs-2014-03-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudWatchLogs.Model
{
    /// <summary>
    /// This is the response object from the GetLogEvents operation.
    /// </summary>
    public partial class GetLogEventsResponse : AmazonWebServiceResponse
    {
        private List<OutputLogEvent> _events = new List<OutputLogEvent>();
        private string _nextBackwardToken;
        private string _nextForwardToken;

        /// <summary>
        /// Gets and sets the property Events. 
        /// <para>
        /// The events.
        /// </para>
        /// </summary>
        public List<OutputLogEvent> Events
        {
            get { return this._events; }
            set { this._events = value; }
        }

        // Check to see if Events property is set
        internal bool IsSetEvents()
        {
            return this._events != null && this._events.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextBackwardToken. 
        /// <para>
        /// The token for the next set of items in the backward direction. The token expires after
        /// 24 hours. This token is not null. If you have reached the end of the stream, it returns
        /// the same token you passed in.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public string NextBackwardToken
        {
            get { return this._nextBackwardToken; }
            set { this._nextBackwardToken = value; }
        }

        // Check to see if NextBackwardToken property is set
        internal bool IsSetNextBackwardToken()
        {
            return this._nextBackwardToken != null;
        }

        /// <summary>
        /// Gets and sets the property NextForwardToken. 
        /// <para>
        /// The token for the next set of items in the forward direction. The token expires after
        /// 24 hours. If you have reached the end of the stream, it returns the same token you
        /// passed in.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public string NextForwardToken
        {
            get { return this._nextForwardToken; }
            set { this._nextForwardToken = value; }
        }

        // Check to see if NextForwardToken property is set
        internal bool IsSetNextForwardToken()
        {
            return this._nextForwardToken != null;
        }

    }
}