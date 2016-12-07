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
 * Do not modify this file. This file is generated from the opsworkscm-2016-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.OpsWorksCM.Model
{
    /// <summary>
    /// This is the response object from the DescribeEvents operation.
    /// </summary>
    public partial class DescribeEventsResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<ServerEvent> _serverEvents = new List<ServerEvent>();

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// NextToken is a string that is returned in some command responses. It indicates that
        /// not all entries have been returned, and that you must run at least one more request
        /// to get remaining items. To get remaining results, call <code>DescribeEvents</code>
        /// again, and assign the token from the previous results as the value of the <code>nextToken</code>
        /// parameter. If there are no more results, the response object's <code>nextToken</code>
        /// parameter value is <code>null</code>. Setting a <code>nextToken</code> value that
        /// was not returned in your previous results causes an <code>InvalidNextTokenException</code>
        /// to occur. 
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
        /// Gets and sets the property ServerEvents. 
        /// <para>
        /// Contains the response to a <code>DescribeEvents</code> request. 
        /// </para>
        /// </summary>
        public List<ServerEvent> ServerEvents
        {
            get { return this._serverEvents; }
            set { this._serverEvents = value; }
        }

        // Check to see if ServerEvents property is set
        internal bool IsSetServerEvents()
        {
            return this._serverEvents != null && this._serverEvents.Count > 0; 
        }

    }
}