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
 * Do not modify this file. This file is generated from the shield-2016-06-02.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

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
        /// The request syntax listing for this call indicates a <code>number</code> type, but
        /// you can provide the time in any valid <a href="https://docs.aws.amazon.com/cli/latest/userguide/cli-usage-parameters-types.html#parameter-type-timestamp">timestamp
        /// format</a> setting. 
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
        /// The greatest number of objects that you want Shield Advanced to return to the list
        /// request. Shield Advanced might return fewer objects than you indicate in this setting,
        /// even if more objects are available. If there are more objects remaining, Shield Advanced
        /// will always also return a <code>NextToken</code> value in the response.
        /// </para>
        ///  
        /// <para>
        /// The default setting is 20.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=10000)]
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
        /// When you request a list of objects from Shield Advanced, if the response does not
        /// include all of the remaining available objects, Shield Advanced includes a <code>NextToken</code>
        /// value in the response. You can retrieve the next batch of objects by requesting the
        /// list again and providing the token that was returned by the prior call in your request.
        /// 
        /// </para>
        ///  
        /// <para>
        /// You can indicate the maximum number of objects that you want Shield Advanced to return
        /// for a single call with the <code>MaxResults</code> setting. Shield Advanced will not
        /// return more than <code>MaxResults</code> objects, but may return fewer, even if more
        /// objects are still available.
        /// </para>
        ///  
        /// <para>
        /// Whenever more objects remain that Shield Advanced has not yet returned to you, the
        /// response will include a <code>NextToken</code> value.
        /// </para>
        ///  
        /// <para>
        /// On your first call to a list operation, leave this setting empty.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=4096)]
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
        /// The ARNs (Amazon Resource Names) of the resources that were attacked. If you leave
        /// this blank, all applicable resources for this account will be included.
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
        /// The request syntax listing for this call indicates a <code>number</code> type, but
        /// you can provide the time in any valid <a href="https://docs.aws.amazon.com/cli/latest/userguide/cli-usage-parameters-types.html#parameter-type-timestamp">timestamp
        /// format</a> setting. 
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