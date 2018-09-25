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
 * Do not modify this file. This file is generated from the redshift-2012-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Redshift.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeEvents operation.
    /// Returns events related to clusters, security groups, snapshots, and parameter groups
    /// for the past 14 days. Events specific to a particular cluster, security group, snapshot
    /// or parameter group can be obtained by providing the name as a parameter. By default,
    /// the past hour of events are returned.
    /// </summary>
    public partial class DescribeEventsRequest : AmazonRedshiftRequest
    {
        private int? _duration;
        private DateTime? _endTimeUtc;
        private string _marker;
        private int? _maxRecords;
        private string _sourceIdentifier;
        private SourceType _sourceType;
        private DateTime? _startTimeUtc;

        /// <summary>
        /// Gets and sets the property Duration. 
        /// <para>
        /// The number of minutes prior to the time of the request for which to retrieve events.
        /// For example, if the request is sent at 18:00 and you specify a duration of 60, then
        /// only events which have occurred after 17:00 will be returned.
        /// </para>
        ///  
        /// <para>
        /// Default: <code>60</code> 
        /// </para>
        /// </summary>
        public int Duration
        {
            get { return this._duration.GetValueOrDefault(); }
            set { this._duration = value; }
        }

        // Check to see if Duration property is set
        internal bool IsSetDuration()
        {
            return this._duration.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EndTimeUtc. 
        /// <para>
        /// The end of the time interval for which to retrieve events, specified in ISO 8601 format.
        /// For more information about ISO 8601, go to the <a href="http://en.wikipedia.org/wiki/ISO_8601">ISO8601
        /// Wikipedia page.</a> 
        /// </para>
        ///  
        /// <para>
        /// Example: <code>2009-07-08T18:00Z</code> 
        /// </para>
        /// </summary>
        public DateTime EndTimeUtc
        {
            get { return this._endTimeUtc.GetValueOrDefault(); }
            set { this._endTime = this._endTimeUtc = value; }
        }

        // Check to see if EndTimeUtc property is set
        internal bool IsSetEndTimeUtc()
        {
            return this._endTimeUtc.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Marker. 
        /// <para>
        /// An optional parameter that specifies the starting point to return a set of response
        /// records. When the results of a <a>DescribeEvents</a> request exceed the value specified
        /// in <code>MaxRecords</code>, AWS returns a value in the <code>Marker</code> field of
        /// the response. You can retrieve the next set of response records by providing the returned
        /// marker value in the <code>Marker</code> parameter and retrying the request. 
        /// </para>
        /// </summary>
        public string Marker
        {
            get { return this._marker; }
            set { this._marker = value; }
        }

        // Check to see if Marker property is set
        internal bool IsSetMarker()
        {
            return this._marker != null;
        }

        /// <summary>
        /// Gets and sets the property MaxRecords. 
        /// <para>
        /// The maximum number of response records to return in each call. If the number of remaining
        /// response records exceeds the specified <code>MaxRecords</code> value, a value is returned
        /// in a <code>marker</code> field of the response. You can retrieve the next set of records
        /// by retrying the command with the returned marker value. 
        /// </para>
        ///  
        /// <para>
        /// Default: <code>100</code> 
        /// </para>
        ///  
        /// <para>
        /// Constraints: minimum 20, maximum 100.
        /// </para>
        /// </summary>
        public int MaxRecords
        {
            get { return this._maxRecords.GetValueOrDefault(); }
            set { this._maxRecords = value; }
        }

        // Check to see if MaxRecords property is set
        internal bool IsSetMaxRecords()
        {
            return this._maxRecords.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SourceIdentifier. 
        /// <para>
        /// The identifier of the event source for which events will be returned. If this parameter
        /// is not specified, then all sources are included in the response.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  
        /// <para>
        /// If <i>SourceIdentifier</i> is supplied, <i>SourceType</i> must also be provided.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Specify a cluster identifier when <i>SourceType</i> is <code>cluster</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Specify a cluster security group name when <i>SourceType</i> is <code>cluster-security-group</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Specify a cluster parameter group name when <i>SourceType</i> is <code>cluster-parameter-group</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Specify a cluster snapshot identifier when <i>SourceType</i> is <code>cluster-snapshot</code>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string SourceIdentifier
        {
            get { return this._sourceIdentifier; }
            set { this._sourceIdentifier = value; }
        }

        // Check to see if SourceIdentifier property is set
        internal bool IsSetSourceIdentifier()
        {
            return this._sourceIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property SourceType. 
        /// <para>
        /// The event source to retrieve events for. If no value is specified, all events are
        /// returned.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  
        /// <para>
        /// If <i>SourceType</i> is supplied, <i>SourceIdentifier</i> must also be provided.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Specify <code>cluster</code> when <i>SourceIdentifier</i> is a cluster identifier.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Specify <code>cluster-security-group</code> when <i>SourceIdentifier</i> is a cluster
        /// security group name.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Specify <code>cluster-parameter-group</code> when <i>SourceIdentifier</i> is a cluster
        /// parameter group name.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Specify <code>cluster-snapshot</code> when <i>SourceIdentifier</i> is a cluster snapshot
        /// identifier.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public SourceType SourceType
        {
            get { return this._sourceType; }
            set { this._sourceType = value; }
        }

        // Check to see if SourceType property is set
        internal bool IsSetSourceType()
        {
            return this._sourceType != null;
        }

        /// <summary>
        /// Gets and sets the property StartTimeUtc. 
        /// <para>
        /// The beginning of the time interval to retrieve events for, specified in ISO 8601 format.
        /// For more information about ISO 8601, go to the <a href="http://en.wikipedia.org/wiki/ISO_8601">ISO8601
        /// Wikipedia page.</a> 
        /// </para>
        ///  
        /// <para>
        /// Example: <code>2009-07-08T18:00Z</code> 
        /// </para>
        /// </summary>
        public DateTime StartTimeUtc
        {
            get { return this._startTimeUtc.GetValueOrDefault(); }
            set { this._startTime = this._startTimeUtc = value; }
        }

        // Check to see if StartTimeUtc property is set
        internal bool IsSetStartTimeUtc()
        {
            return this._startTimeUtc.HasValue; 
        }

#region Backwards compatible properties
        private DateTime? _endTime;
        private DateTime? _startTime;

        /// <summary>
        /// Gets and sets the property EndTimeUtc. 
        /// <para>
        /// This property is deprecated. Setting this property results in non-UTC DateTimes not
        /// being marshalled correctly. Use EndTimeUtc instead. Setting either EndTime or EndTimeUtc
        /// results in both EndTime and EndTimeUtc being assigned, the latest assignment to either
        /// one of the two property is reflected in the value of both. EndTime is provided for
        /// backwards compatibility only and assigning a non-Utc DateTime to it results in the
        /// wrong timestamp being passed to the service.
        /// </para>
        ///  
        /// <para>
        /// The end of the time interval for which to retrieve events, specified in ISO 8601 format.
        /// For more information about ISO 8601, go to the <a href="http://en.wikipedia.org/wiki/ISO_8601">ISO8601
        /// Wikipedia page.</a> 
        /// </para>
        ///  
        /// <para>
        /// Example: <code>2009-07-08T18:00Z</code> 
        /// </para>
        /// </summary>
        [Obsolete("Setting this property results in non-UTC DateTimes not being marshalled correctly. " +
            "Use EndTimeUtc instead. Setting either EndTime or EndTimeUtc results in both EndTime and " +
            "EndTimeUtc being assigned, the latest assignment to either one of the two property is " + 
            "reflected in the value of both. EndTime is provided for backwards compatibility only and " +
            "assigning a non-Utc DateTime to it results in the wrong timestamp being passed to the service.", false)]
        public DateTime EndTime
        {
            get { return this._endTime.GetValueOrDefault(); }
            set
            {
                this._endTime = value;
                this._endTimeUtc = new DateTime(value.Ticks, DateTimeKind.Utc);
            }
        }
        /// <summary>
        /// Gets and sets the property StartTimeUtc. 
        /// <para>
        /// This property is deprecated. Setting this property results in non-UTC DateTimes not
        /// being marshalled correctly. Use StartTimeUtc instead. Setting either StartTime or
        /// StartTimeUtc results in both StartTime and StartTimeUtc being assigned, the latest
        /// assignment to either one of the two property is reflected in the value of both. StartTime
        /// is provided for backwards compatibility only and assigning a non-Utc DateTime to it
        /// results in the wrong timestamp being passed to the service.
        /// </para>
        ///  
        /// <para>
        /// The beginning of the time interval to retrieve events for, specified in ISO 8601 format.
        /// For more information about ISO 8601, go to the <a href="http://en.wikipedia.org/wiki/ISO_8601">ISO8601
        /// Wikipedia page.</a> 
        /// </para>
        ///  
        /// <para>
        /// Example: <code>2009-07-08T18:00Z</code> 
        /// </para>
        /// </summary>
        [Obsolete("Setting this property results in non-UTC DateTimes not being marshalled correctly. " +
            "Use StartTimeUtc instead. Setting either StartTime or StartTimeUtc results in both StartTime and " +
            "StartTimeUtc being assigned, the latest assignment to either one of the two property is " + 
            "reflected in the value of both. StartTime is provided for backwards compatibility only and " +
            "assigning a non-Utc DateTime to it results in the wrong timestamp being passed to the service.", false)]
        public DateTime StartTime
        {
            get { return this._startTime.GetValueOrDefault(); }
            set
            {
                this._startTime = value;
                this._startTimeUtc = new DateTime(value.Ticks, DateTimeKind.Utc);
            }
        }
#endregion
    }
}