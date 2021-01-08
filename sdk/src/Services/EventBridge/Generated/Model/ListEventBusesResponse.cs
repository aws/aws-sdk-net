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
 * Do not modify this file. This file is generated from the eventbridge-2015-10-07.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EventBridge.Model
{
    /// <summary>
    /// This is the response object from the ListEventBuses operation.
    /// </summary>
    public partial class ListEventBusesResponse : AmazonWebServiceResponse
    {
        private List<EventBus> _eventBuses = new List<EventBus>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property EventBuses. 
        /// <para>
        /// This list of event buses.
        /// </para>
        /// </summary>
        public List<EventBus> EventBuses
        {
            get { return this._eventBuses; }
            set { this._eventBuses = value; }
        }

        // Check to see if EventBuses property is set
        internal bool IsSetEventBuses()
        {
            return this._eventBuses != null && this._eventBuses.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A token you can use in a subsequent operation to retrieve the next set of results.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
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

    }
}