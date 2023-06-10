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
 * Do not modify this file. This file is generated from the ssm-contacts-2021-05-03.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SSMContacts.Model
{
    /// <summary>
    /// Container for the parameters to the ListPreviewRotationShifts operation.
    /// Returns a list of shifts based on rotation configuration parameters.
    /// 
    ///  <note> 
    /// <para>
    /// The Incident Manager primarily uses this operation to populate the <b>Preview</b>
    /// calendar. It is not typically run by end users.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class ListPreviewRotationShiftsRequest : AmazonSSMContactsRequest
    {
        private DateTime? _endTime;
        private int? _maxResults;
        private List<string> _members = new List<string>();
        private string _nextToken;
        private List<PreviewOverride> _overrides = new List<PreviewOverride>();
        private RecurrenceSettings _recurrence;
        private DateTime? _rotationStartTime;
        private DateTime? _startTime;
        private string _timeZoneId;

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The date and time a rotation shift would end.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of items to return for this call. The call also returns a token
        /// that can be specified in a subsequent call to get the next set of results.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
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
        /// Gets and sets the property Members. 
        /// <para>
        /// The contacts that would be assigned to a rotation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=30)]
        public List<string> Members
        {
            get { return this._members; }
            set { this._members = value; }
        }

        // Check to see if Members property is set
        internal bool IsSetMembers()
        {
            return this._members != null && this._members.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A token to start the list. This token is used to get the next set of results.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2048)]
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
        /// Gets and sets the property Overrides. 
        /// <para>
        /// Information about changes that would be made in a rotation override.
        /// </para>
        /// </summary>
        public List<PreviewOverride> Overrides
        {
            get { return this._overrides; }
            set { this._overrides = value; }
        }

        // Check to see if Overrides property is set
        internal bool IsSetOverrides()
        {
            return this._overrides != null && this._overrides.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Recurrence. 
        /// <para>
        /// Information about how long a rotation would last before restarting at the beginning
        /// of the shift order.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RecurrenceSettings Recurrence
        {
            get { return this._recurrence; }
            set { this._recurrence = value; }
        }

        // Check to see if Recurrence property is set
        internal bool IsSetRecurrence()
        {
            return this._recurrence != null;
        }

        /// <summary>
        /// Gets and sets the property RotationStartTime. 
        /// <para>
        /// The date and time a rotation would begin. The first shift is calculated from this
        /// date and time.
        /// </para>
        /// </summary>
        public DateTime RotationStartTime
        {
            get { return this._rotationStartTime.GetValueOrDefault(); }
            set { this._rotationStartTime = value; }
        }

        // Check to see if RotationStartTime property is set
        internal bool IsSetRotationStartTime()
        {
            return this._rotationStartTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// Used to filter the range of calculated shifts before sending the response back to
        /// the user. 
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

        /// <summary>
        /// Gets and sets the property TimeZoneId. 
        /// <para>
        /// The time zone the rotation’s activity would be based on, in Internet Assigned Numbers
        /// Authority (IANA) format. For example: "America/Los_Angeles", "UTC", or "Asia/Seoul".
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string TimeZoneId
        {
            get { return this._timeZoneId; }
            set { this._timeZoneId = value; }
        }

        // Check to see if TimeZoneId property is set
        internal bool IsSetTimeZoneId()
        {
            return this._timeZoneId != null;
        }

    }
}