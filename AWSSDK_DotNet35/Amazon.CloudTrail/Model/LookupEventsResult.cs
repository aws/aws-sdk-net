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
 * Do not modify this file. This file is generated from the cloudtrail-2013-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudTrail.Model
{
    /// <summary>
    /// Contains a response to a LookupEvents action.
    /// </summary>
    public partial class LookupEventsResult : AmazonWebServiceResponse
    {
        private List<Event> _events = new List<Event>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property Events. 
        /// <para>
        /// A list of events returned based on the lookup attributes specified and the CloudTrail
        /// event. The events list is sorted by time. The most recent event is listed first.
        /// </para>
        /// </summary>
        public List<Event> Events
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
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token to use to get the next page of results after a previous API call. If the
        /// token does not appear, there are no more results to return. The token must be passed
        /// in with the same parameters as the previous call. For example, if the original call
        /// specified an AttributeKey of 'Username' with a value of 'root', the call with NextToken
        /// should include those same parameters.
        /// </para>
        /// </summary>
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