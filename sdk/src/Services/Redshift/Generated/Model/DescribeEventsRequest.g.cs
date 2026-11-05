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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570

namespace Amazon.Redshift.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeEvents operation. Returns events related
    /// to clusters, security groups, snapshots, and parameter groups for the past 14 days.
    /// Events specific to a particular cluster, security group, snapshot or parameter group
    /// can be obtained by providing the name as a parameter. By default, the past hour of
    /// events are returned.
    /// </summary>
    public partial class DescribeEventsRequest : AmazonRedshiftRequest
    {
        /// <summary>
        /// Gets and sets the property Duration. 
        /// <para>
        /// The number of minutes prior to the time of the request for which to retrieve events.
        /// For example, if the request is sent at 18:00 and you specify a duration of 60, then
        /// only events which have occurred after 17:00 will be returned.
        /// </para>
        ///  
        /// <para>
        /// Default: <c>60</c> 
        /// </para>
        /// </summary>
        public int? Duration { get; set; }

        /// <summary>
        /// Checks to see if the Duration property is set.
        /// </summary>
        internal bool IsSetDuration() => this.Duration.HasValue;

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The end of the time interval for which to retrieve events, specified in ISO 8601 format.
        /// For more information about ISO 8601, go to the <a href="http://en.wikipedia.org/wiki/ISO_8601">ISO8601
        /// Wikipedia page.</a> 
        /// </para>
        ///  
        /// <para>
        /// Example: <c>2009-07-08T18:00Z</c> 
        /// </para>
        /// </summary>
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// Checks to see if the EndTime property is set.
        /// </summary>
        internal bool IsSetEndTime() => this.EndTime.HasValue;

        /// <summary>
        /// Gets and sets the property Marker. 
        /// <para>
        /// An optional parameter that specifies the starting point to return a set of response
        /// records. When the results of a <a>DescribeEvents</a> request exceed the value specified
        /// in <c>MaxRecords</c>, Amazon Web Services returns a value in the <c>Marker</c> field
        /// of the response. You can retrieve the next set of response records by providing the
        /// returned marker value in the <c>Marker</c> parameter and retrying the request. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public string Marker { get; set; }

        /// <summary>
        /// Checks to see if the Marker property is set.
        /// </summary>
        internal bool IsSetMarker() => this.Marker != null;

        /// <summary>
        /// Gets and sets the property MaxRecords. 
        /// <para>
        /// The maximum number of response records to return in each call. If the number of remaining
        /// response records exceeds the specified <c>MaxRecords</c> value, a value is returned
        /// in a <c>marker</c> field of the response. You can retrieve the next set of records
        /// by retrying the command with the returned marker value. 
        /// </para>
        ///  
        /// <para>
        /// Default: <c>100</c> 
        /// </para>
        ///  
        /// <para>
        /// Constraints: minimum 20, maximum 100.
        /// </para>
        /// </summary>
        public int? MaxRecords { get; set; }

        /// <summary>
        /// Checks to see if the MaxRecords property is set.
        /// </summary>
        internal bool IsSetMaxRecords() => this.MaxRecords.HasValue;

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
        /// Specify a cluster identifier when <i>SourceType</i> is <c>cluster</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Specify a cluster security group name when <i>SourceType</i> is <c>cluster-security-group</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Specify a cluster parameter group name when <i>SourceType</i> is <c>cluster-parameter-group</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Specify a cluster snapshot identifier when <i>SourceType</i> is <c>cluster-snapshot</c>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public string SourceIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the SourceIdentifier property is set.
        /// </summary>
        internal bool IsSetSourceIdentifier() => this.SourceIdentifier != null;

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
        /// Specify <c>cluster</c> when <i>SourceIdentifier</i> is a cluster identifier.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Specify <c>cluster-security-group</c> when <i>SourceIdentifier</i> is a cluster security
        /// group name.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Specify <c>cluster-parameter-group</c> when <i>SourceIdentifier</i> is a cluster parameter
        /// group name.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Specify <c>cluster-snapshot</c> when <i>SourceIdentifier</i> is a cluster snapshot
        /// identifier.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public SourceType SourceType { get; set; }

        /// <summary>
        /// Checks to see if the SourceType property is set.
        /// </summary>
        internal bool IsSetSourceType() => this.SourceType != null;

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The beginning of the time interval to retrieve events for, specified in ISO 8601 format.
        /// For more information about ISO 8601, go to the <a href="http://en.wikipedia.org/wiki/ISO_8601">ISO8601
        /// Wikipedia page.</a> 
        /// </para>
        ///  
        /// <para>
        /// Example: <c>2009-07-08T18:00Z</c> 
        /// </para>
        /// </summary>
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// Checks to see if the StartTime property is set.
        /// </summary>
        internal bool IsSetStartTime() => this.StartTime.HasValue;
    }
}
