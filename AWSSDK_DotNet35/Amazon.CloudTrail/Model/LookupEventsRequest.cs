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
    /// Container for the parameters to the LookupEvents operation.
    /// Looks up API activity events captured by CloudTrail that create, update, or delete
    /// resources in your account. Events for a region can be looked up for the times in which
    /// you had CloudTrail turned on in that region during the last seven days. Lookup supports
    /// five different attributes: time range (defined by a start time and end time), user
    /// name, event name, resource type, and resource name. All attributes are optional. The
    /// maximum number of attributes that can be specified in any one lookup request are time
    /// range and one other attribute. The default number of results returned is 10, with
    /// a maximum of 50 possible. The response includes a token that you can use to get the
    /// next page of results. The rate of lookup requests is limited to one per second per
    /// account.
    /// 
    ///  <important>Events that occurred during the selected time range will not be available
    /// for lookup if CloudTrail logging was not enabled when the events occurred.</important>
    /// </summary>
    public partial class LookupEventsRequest : AmazonCloudTrailRequest
    {
        private DateTime? _endTime;
        private List<LookupAttribute> _lookupAttributes = new List<LookupAttribute>();
        private int? _maxResults;
        private string _nextToken;
        private DateTime? _startTime;

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// Specifies that only events that occur before or at the specified time are returned.
        /// If the specified end time is before the specified start time, an error is returned.
        /// </para>
        /// </summary>
        public DateTime EndTime
        {
            get { return this._endTime.GetValueOrDefault(); }
            set { this._endTime = value; }
        }

        // Check to see if EndTime property is set
        internal bool IsSetEndTime()
        {
            return this._endTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LookupAttributes. 
        /// <para>
        /// Contains a list of lookup attributes. Currently the list can contain only one item.
        /// </para>
        /// </summary>
        public List<LookupAttribute> LookupAttributes
        {
            get { return this._lookupAttributes; }
            set { this._lookupAttributes = value; }
        }

        // Check to see if LookupAttributes property is set
        internal bool IsSetLookupAttributes()
        {
            return this._lookupAttributes != null && this._lookupAttributes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The number of events to return. Possible values are 1 through 50. The default is 10.
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
        /// The token to use to get the next page of results after a previous API call. This token
        /// must be passed in with the same parameters that were specified in the the original
        /// call. For example, if the original call specified an AttributeKey of 'Username' with
        /// a value of 'root', the call with NextToken should include those same parameters.
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
        /// Gets and sets the property StartTime. 
        /// <para>
        /// Specifies that only events that occur after or at the specified time are returned.
        /// If the specified start time is after the specified end time, an error is returned.
        /// </para>
        /// </summary>
        public DateTime StartTime
        {
            get { return this._startTime.GetValueOrDefault(); }
            set { this._startTime = value; }
        }

        // Check to see if StartTime property is set
        internal bool IsSetStartTime()
        {
            return this._startTime.HasValue; 
        }

    }
}