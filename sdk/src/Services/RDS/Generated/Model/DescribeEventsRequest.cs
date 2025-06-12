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
 * Do not modify this file. This file is generated from the rds-2014-10-31.normal.json service model.
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
namespace Amazon.RDS.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeEvents operation.
    /// Returns events related to DB instances, DB clusters, DB parameter groups, DB security
    /// groups, DB snapshots, DB cluster snapshots, and RDS Proxies for the past 14 days.
    /// Events specific to a particular DB instance, DB cluster, DB parameter group, DB security
    /// group, DB snapshot, DB cluster snapshot group, or RDS Proxy can be obtained by providing
    /// the name as a parameter.
    /// 
    ///  
    /// <para>
    /// For more information on working with events, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/working-with-events.html">Monitoring
    /// Amazon RDS events</a> in the <i>Amazon RDS User Guide</i> and <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/working-with-events.html">Monitoring
    /// Amazon Aurora events</a> in the <i>Amazon Aurora User Guide</i>.
    /// </para>
    ///  <note> 
    /// <para>
    /// By default, RDS returns events that were generated in the past hour.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class DescribeEventsRequest : AmazonRDSRequest
    {
        private int? _duration;
        private DateTime? _endTime;
        private List<string> _eventCategories = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<Filter> _filters = AWSConfigs.InitializeCollections ? new List<Filter>() : null;
        private string _marker;
        private int? _maxRecords;
        private string _sourceIdentifier;
        private SourceType _sourceType;
        private DateTime? _startTime;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public DescribeEventsRequest() { }

        /// <summary>
        /// Gets and sets the property Duration. 
        /// <para>
        /// The number of minutes to retrieve events for.
        /// </para>
        ///  
        /// <para>
        /// Default: 60
        /// </para>
        /// </summary>
        public int? Duration
        {
            get { return this._duration; }
            set { this._duration = value; }
        }

        // Check to see if Duration property is set
        internal bool IsSetDuration()
        {
            return this._duration.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The end of the time interval for which to retrieve events, specified in ISO 8601 format.
        /// For more information about ISO 8601, go to the <a href="http://en.wikipedia.org/wiki/ISO_8601">ISO8601
        /// Wikipedia page.</a> 
        /// </para>
        ///  
        /// <para>
        /// Example: 2009-07-08T18:00Z
        /// </para>
        /// </summary>
        public DateTime? EndTime
        {
            get { return this._endTime; }
            set { this._endTime = value; }
        }

        // Check to see if EndTime property is set
        internal bool IsSetEndTime()
        {
            return this._endTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EventCategories. 
        /// <para>
        /// A list of event categories that trigger notifications for a event notification subscription.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> EventCategories
        {
            get { return this._eventCategories; }
            set { this._eventCategories = value; }
        }

        // Check to see if EventCategories property is set
        internal bool IsSetEventCategories()
        {
            return this._eventCategories != null && (this._eventCategories.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// This parameter isn't currently supported.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Filter> Filters
        {
            get { return this._filters; }
            set { this._filters = value; }
        }

        // Check to see if Filters property is set
        internal bool IsSetFilters()
        {
            return this._filters != null && (this._filters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Marker. 
        /// <para>
        /// An optional pagination token provided by a previous DescribeEvents request. If this
        /// parameter is specified, the response includes only records beyond the marker, up to
        /// the value specified by <c>MaxRecords</c>.
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
        /// The maximum number of records to include in the response. If more records exist than
        /// the specified <c>MaxRecords</c> value, a pagination token called a marker is included
        /// in the response so that you can retrieve the remaining results.
        /// </para>
        ///  
        /// <para>
        /// Default: 100
        /// </para>
        ///  
        /// <para>
        /// Constraints: Minimum 20, maximum 100.
        /// </para>
        /// </summary>
        public int? MaxRecords
        {
            get { return this._maxRecords; }
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
        /// The identifier of the event source for which events are returned. If not specified,
        /// then all sources are included in the response.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If <c>SourceIdentifier</c> is supplied, <c>SourceType</c> must also be provided.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the source type is a DB instance, a <c>DBInstanceIdentifier</c> value must be supplied.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the source type is a DB cluster, a <c>DBClusterIdentifier</c> value must be supplied.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the source type is a DB parameter group, a <c>DBParameterGroupName</c> value must
        /// be supplied.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the source type is a DB security group, a <c>DBSecurityGroupName</c> value must
        /// be supplied.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the source type is a DB snapshot, a <c>DBSnapshotIdentifier</c> value must be supplied.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the source type is a DB cluster snapshot, a <c>DBClusterSnapshotIdentifier</c>
        /// value must be supplied.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the source type is an RDS Proxy, a <c>DBProxyName</c> value must be supplied.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Can't end with a hyphen or contain two consecutive hyphens.
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
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The beginning of the time interval to retrieve events for, specified in ISO 8601 format.
        /// For more information about ISO 8601, go to the <a href="http://en.wikipedia.org/wiki/ISO_8601">ISO8601
        /// Wikipedia page.</a> 
        /// </para>
        ///  
        /// <para>
        /// Example: 2009-07-08T18:00Z
        /// </para>
        /// </summary>
        public DateTime? StartTime
        {
            get { return this._startTime; }
            set { this._startTime = value; }
        }

        // Check to see if StartTime property is set
        internal bool IsSetStartTime()
        {
            return this._startTime.HasValue; 
        }

    }
}