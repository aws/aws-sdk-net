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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IoT.Model
{
    /// <summary>
    /// This is the response object from the ListViolationEvents operation.
    /// </summary>
    public partial class ListViolationEventsResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<ViolationEvent> _violationEvents = new List<ViolationEvent>();

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A token that can be used to retrieve the next set of results, or <code>null</code>
        /// if there are no additional results.
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

        /// <summary>
        /// Gets and sets the property ViolationEvents. 
        /// <para>
        /// The security profile violation alerts issued for this account during the given time
        /// frame, potentially filtered by security profile, behavior violated, or thing (device)
        /// violating.
        /// </para>
        /// </summary>
        public List<ViolationEvent> ViolationEvents
        {
            get { return this._violationEvents; }
            set { this._violationEvents = value; }
        }

        // Check to see if ViolationEvents property is set
        internal bool IsSetViolationEvents()
        {
            return this._violationEvents != null && this._violationEvents.Count > 0; 
        }

    }
}