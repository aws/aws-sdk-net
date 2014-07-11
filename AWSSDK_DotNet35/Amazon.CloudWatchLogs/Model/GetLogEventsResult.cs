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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudWatchLogs.Model
{
    /// <summary>
    /// 
    /// </summary>
    public partial class GetLogEventsResult : AmazonWebServiceResponse
    {
        private List<OutputLogEvent> _events = new List<OutputLogEvent>();
        private string _nextBackwardToken;
        private string _nextForwardToken;


        /// <summary>
        /// Gets and sets the property Events.
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
        /// </summary>
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
        /// </summary>
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