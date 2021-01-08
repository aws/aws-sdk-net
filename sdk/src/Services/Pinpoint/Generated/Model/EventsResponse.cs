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
 * Do not modify this file. This file is generated from the pinpoint-2016-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Pinpoint.Model
{
    /// <summary>
    /// Provides information about endpoints and the events that they're associated with.
    /// </summary>
    public partial class EventsResponse
    {
        private Dictionary<string, ItemResponse> _results = new Dictionary<string, ItemResponse>();

        /// <summary>
        /// Gets and sets the property Results. 
        /// <para>
        /// A map that contains a multipart response for each endpoint. For each item in this
        /// object, the endpoint ID is the key and the item response is the value. If no item
        /// response exists, the value can also be one of the following: 202, the request was
        /// processed successfully; or 400, the payload wasn't valid or required fields were missing.
        /// </para>
        /// </summary>
        public Dictionary<string, ItemResponse> Results
        {
            get { return this._results; }
            set { this._results = value; }
        }

        // Check to see if Results property is set
        internal bool IsSetResults()
        {
            return this._results != null && this._results.Count > 0; 
        }

    }
}