/*
 * Copyright 2010 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.RDS.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeEvents operation.
    /// <para> This API returns events related to DB Instances, DB Security
    /// Groups, DB Snapshots and DB Parameter Groups for the past 14 das.
    /// Events specific to a particular DB Instance, database security group,
    /// database snapshot or database parameter group can be obtained by
    /// providing the name as a parameter. By default, the past hour of events
    /// are returned. </para>
    /// </summary>
    /// <seealso cref="Amazon.RDS.AmazonRDS.DescribeEvents"/>
    public class DescribeEventsRequest : AmazonWebServiceRequest
    {
        private string sourceIdentifier;
        private string sourceType;
        private DateTime? startTime;
        private DateTime? endTime;
        private int? duration;
        private int? maxRecords;
        private string marker;

        /// <summary>
        /// The identifier of the event source for which events will be returned.
        /// If not specified, then all sources are included in the response.
        ///  
        /// </summary>
        public string SourceIdentifier
        {
            get { return this.sourceIdentifier; }
            set { this.sourceIdentifier = value; }
        }

        /// <summary>
        /// Sets the SourceIdentifier property
        /// </summary>
        /// <param name="sourceIdentifier">The value to set for the SourceIdentifier property </param>
        /// <returns>this instance</returns>
        public DescribeEventsRequest WithSourceIdentifier(string sourceIdentifier)
        {
            this.sourceIdentifier = sourceIdentifier;
            return this;
        }
            
        // Check to see if SourceIdentifier property is set
        internal bool IsSetSourceIdentifier()
        {
            return this.sourceIdentifier != null;       
        }

        /// <summary>
        /// The event source to retrieve events for. If no value is specified, all
        /// events are returned.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>db-instance, db-parameter-group, db-security-group, db-snapshot</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string SourceType
        {
            get { return this.sourceType; }
            set { this.sourceType = value; }
        }

        /// <summary>
        /// Sets the SourceType property
        /// </summary>
        /// <param name="sourceType">The value to set for the SourceType property </param>
        /// <returns>this instance</returns>
        public DescribeEventsRequest WithSourceType(string sourceType)
        {
            this.sourceType = sourceType;
            return this;
        }
            
        // Check to see if SourceType property is set
        internal bool IsSetSourceType()
        {
            return this.sourceType != null;         
        }

        /// <summary>
        /// The beginning of the time interval to retrieve events for, specified
        /// in ISO 8601 format.
        ///  
        /// </summary>
        public DateTime StartTime
        {
            get { return this.startTime ?? default(DateTime); }
            set { this.startTime = value; }
        }

        /// <summary>
        /// Sets the StartTime property
        /// </summary>
        /// <param name="startTime">The value to set for the StartTime property </param>
        /// <returns>this instance</returns>
        public DescribeEventsRequest WithStartTime(DateTime startTime)
        {
            this.startTime = startTime;
            return this;
        }
            
        // Check to see if StartTime property is set
        internal bool IsSetStartTime()
        {
            return this.startTime.HasValue;         
        }

        /// <summary>
        /// The end of the time interval for which to retrieve events, specified
        /// in ISO 8601 format.
        ///  
        /// </summary>
        public DateTime EndTime
        {
            get { return this.endTime ?? default(DateTime); }
            set { this.endTime = value; }
        }

        /// <summary>
        /// Sets the EndTime property
        /// </summary>
        /// <param name="endTime">The value to set for the EndTime property </param>
        /// <returns>this instance</returns>
        public DescribeEventsRequest WithEndTime(DateTime endTime)
        {
            this.endTime = endTime;
            return this;
        }
            
        // Check to see if EndTime property is set
        internal bool IsSetEndTime()
        {
            return this.endTime.HasValue;       
        }

        /// <summary>
        /// The number of minutes to retrieve events for.
        ///  
        /// </summary>
        public int Duration
        {
            get { return this.duration ?? default(int); }
            set { this.duration = value; }
        }

        /// <summary>
        /// Sets the Duration property
        /// </summary>
        /// <param name="duration">The value to set for the Duration property </param>
        /// <returns>this instance</returns>
        public DescribeEventsRequest WithDuration(int duration)
        {
            this.duration = duration;
            return this;
        }
            
        // Check to see if Duration property is set
        internal bool IsSetDuration()
        {
            return this.duration.HasValue;      
        }

        /// <summary>
        /// The maximum number of records to include in the response. If more
        /// records exist than the specified <i>MaxRecords</i> value, a marker is
        /// included in the response so that the remaining results may be
        /// retrieved.
        ///  
        /// </summary>
        public int MaxRecords
        {
            get { return this.maxRecords ?? default(int); }
            set { this.maxRecords = value; }
        }

        /// <summary>
        /// Sets the MaxRecords property
        /// </summary>
        /// <param name="maxRecords">The value to set for the MaxRecords property </param>
        /// <returns>this instance</returns>
        public DescribeEventsRequest WithMaxRecords(int maxRecords)
        {
            this.maxRecords = maxRecords;
            return this;
        }
            
        // Check to see if MaxRecords property is set
        internal bool IsSetMaxRecords()
        {
            return this.maxRecords.HasValue;        
        }

        /// <summary>
        /// An optional marker provided in the previous DescribeDBInstances
        /// request. If this parameter is specified, the response includes only
        /// records beyond the marker, up to the value specified by
        /// <i>MaxRecords</i>.
        ///  
        /// </summary>
        public string Marker
        {
            get { return this.marker; }
            set { this.marker = value; }
        }

        /// <summary>
        /// Sets the Marker property
        /// </summary>
        /// <param name="marker">The value to set for the Marker property </param>
        /// <returns>this instance</returns>
        public DescribeEventsRequest WithMarker(string marker)
        {
            this.marker = marker;
            return this;
        }
            
        // Check to see if Marker property is set
        internal bool IsSetMarker()
        {
            return this.marker != null;         
        }
    }
}
    
