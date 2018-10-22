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
 * Do not modify this file. This file is generated from the shield-2016-06-02.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Shield.Model
{
    /// <summary>
    /// Container for the parameters to the ListAttacks operation.
    /// Returns all ongoing DDoS attacks or all DDoS attacks during a specified time period.
    /// </summary>
    public partial class ListAttacksRequest : AmazonShieldRequest
    {
        private TimeRange _endTime;
        private int? _maxResults;
        private string _nextToken;
        private List<string> _resourceArns = new List<string>();
        private TimeRange _startTime;

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The end of the time period for the attacks. This is a <code>timestamp</code> type.
        /// The sample request above indicates a <code>number</code> type because the default
        /// used by WAF is Unix time in seconds. However any valid <a href="http://docs.aws.amazon.com/cli/latest/userguide/cli-using-param.html#parameter-types">timestamp
        /// format</a> is allowed. 
        /// </para>
        /// </summary>
        public TimeRange EndTime
        {
            get { return this._endTime; }
            set { this._endTime = value; }
        }

        // Check to see if EndTime property is set
        internal bool IsSetEndTime()
        {
            return this._endTime != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of <a>AttackSummary</a> objects to be returned. If this is left
        /// blank, the first 20 results will be returned.
        /// </para>
        ///  
        /// <para>
        /// This is a maximum value; it is possible that AWS WAF will return the results in smaller
        /// batches. That is, the number of <a>AttackSummary</a> objects returned could be less
        /// than <code>MaxResults</code>, even if there are still more <a>AttackSummary</a> objects
        /// yet to return. If there are more <a>AttackSummary</a> objects to return, AWS WAF will
        /// always also return a <code>NextToken</code>.
        /// </para>
        /// </summary>
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
        /// The <code>ListAttacksRequest.NextMarker</code> value from a previous call to <code>ListAttacksRequest</code>.
        /// Pass null if this is the first call.
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
        /// Gets and sets the property ResourceArns. 
        /// <para>
        /// The ARN (Amazon Resource Name) of the resource that was attacked. If this is left
        /// blank, all applicable resources for this account will be included.
        /// </para>
        /// </summary>
        public List<string> ResourceArns
        {
            get { return this._resourceArns; }
            set { this._resourceArns = value; }
        }

        // Check to see if ResourceArns property is set
        internal bool IsSetResourceArns()
        {
            return this._resourceArns != null && this._resourceArns.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The start of the time period for the attacks. This is a <code>timestamp</code> type.
        /// The sample request above indicates a <code>number</code> type because the default
        /// used by WAF is Unix time in seconds. However any valid <a href="http://docs.aws.amazon.com/cli/latest/userguide/cli-using-param.html#parameter-types">timestamp
        /// format</a> is allowed. 
        /// </para>
        /// </summary>
        public TimeRange StartTime
        {
            get { return this._startTime; }
            set { this._startTime = value; }
        }

        // Check to see if StartTime property is set
        internal bool IsSetStartTime()
        {
            return this._startTime != null;
        }

    }
}