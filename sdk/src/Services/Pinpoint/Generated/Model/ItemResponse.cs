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
 * Do not modify this file. This file is generated from the pinpoint-2016-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Pinpoint.Model
{
    /// <summary>
    /// The endpoint and events combined response definition
    /// </summary>
    public partial class ItemResponse
    {
        private EndpointItemResponse _endpointItemResponse;
        private Dictionary<string, EventItemResponse> _eventsItemResponse = new Dictionary<string, EventItemResponse>();

        /// <summary>
        /// Gets and sets the property EndpointItemResponse. Endpoint item response after endpoint
        /// registration
        /// </summary>
        public EndpointItemResponse EndpointItemResponse
        {
            get { return this._endpointItemResponse; }
            set { this._endpointItemResponse = value; }
        }

        // Check to see if EndpointItemResponse property is set
        internal bool IsSetEndpointItemResponse()
        {
            return this._endpointItemResponse != null;
        }

        /// <summary>
        /// Gets and sets the property EventsItemResponse. Events item response is a multipart
        /// response object per event Id, with eventId as the key and EventItemResponse object
        /// as the value
        /// </summary>
        public Dictionary<string, EventItemResponse> EventsItemResponse
        {
            get { return this._eventsItemResponse; }
            set { this._eventsItemResponse = value; }
        }

        // Check to see if EventsItemResponse property is set
        internal bool IsSetEventsItemResponse()
        {
            return this._eventsItemResponse != null && this._eventsItemResponse.Count > 0; 
        }

    }
}