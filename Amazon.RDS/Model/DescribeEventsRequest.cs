/*******************************************************************************
 * Copyright 2008-2010 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 * this file except in compliance with the License. A copy of the License is located at
 *
 * http://aws.amazon.com/apache2.0
 *
 * or in the "license" file accompanying this file. This file is distributed on
 * an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express
 * or implied. See the License for the specific language governing permissions and
 * limitations under the License.
 * *****************************************************************************
 *    __  _    _  ___
 *   (  )( \/\/ )/ __)
 *   /__\ \    / \__ \
 *  (_)(_) \/\/  (___/
 *
 *  AWS SDK for .NET
 *  API Version: 2010-01-01
 */

using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

namespace Amazon.RDS.Model
{
    /// <summary>
    /// Returns information about events related to your DB Instances, DB Security Groups, and DB Parameter Groups for up to the
    /// past 14 days. You can get events specific to a particular DB Instance or DB Security Group by providing the name as a
    /// parameter. By default, the past hour of events are returned.
    ///
    /// If neither DBInstanceIdentifier or DBSecurityGroupName are provided, all events are be retrieved for DB Instances and DB Security Groups.
    /// </summary>
    [XmlRootAttribute(Namespace = "http://rds.amazonaws.com/doc/2010-01-01/", IsNullable = false)]
    public class DescribeEventsRequest
    {
        private string sourceIdentifierField;
        private string sourceTypeField;
        private DateTime? startTimeField;
        private DateTime? endTimeField;
        private Decimal? durationField;
        private Decimal? maxRecordsField;
        private string markerField;

        /// <summary>
        /// Gets and sets the SourceIdentifier property.
        /// Identifier of the event source for which events will be returned. If the source identifier is not specified then
        /// all sources are included in the response.
        /// If SourceIdentifier is supplied, SourceType must also be provided.
        /// If the source type is DBInstance, then a DBInstanceIdentifier must be supplied.
        /// If the source type is DBSecurityGroup, a DBSecurityGroupName must be supplied.
        /// If the source type is DBParameterGroup, a DBParameterGroupName must be supplied.
        /// If the source type is DBSnapshot, a DBSnapshotIdentifier must be supplied.
        /// May not end with a hyphen or contain two consecutive hyphens.
        /// </summary>
        [XmlElementAttribute(ElementName = "SourceIdentifier")]
        public string SourceIdentifier
        {
            get { return this.sourceIdentifierField; }
            set { this.sourceIdentifierField = value; }
        }

        /// <summary>
        /// Sets the SourceIdentifier property
        /// </summary>
        /// <param name="sourceIdentifier">Identifier of the event source for which events will be returned. If the source identifier is not specified then
        /// all sources are included in the response.
        /// If SourceIdentifier is supplied, SourceType must also be provided.
        /// If the source type is DBInstance, then a DBInstanceIdentifier must be supplied.
        /// If the source type is DBSecurityGroup, a DBSecurityGroupName must be supplied.
        /// If the source type is DBParameterGroup, a DBParameterGroupName must be supplied.
        /// If the source type is DBSnapshot, a DBSnapshotIdentifier must be supplied.
        /// May not end with a hyphen or contain two consecutive hyphens.</param>
        /// <returns>this instance</returns>
        public DescribeEventsRequest WithSourceIdentifier(string sourceIdentifier)
        {
            this.sourceIdentifierField = sourceIdentifier;
            return this;
        }

        /// <summary>
        /// Checks if SourceIdentifier property is set
        /// </summary>
        /// <returns>true if SourceIdentifier property is set</returns>
        public bool IsSetSourceIdentifier()
        {
            return this.sourceIdentifierField != null;
        }

        /// <summary>
        /// Gets and sets the SourceType property.
        /// Specifies the event source to retrieve events for. If no value is specified, all events are returned.
        /// If SourceIdentifier is supplied, SourceType must also be provided.
        /// If the source type is DBInstance, then a DBInstanceIdentifier must be supplied.
        /// If the source type is DBSecurityGroup, a DBSecurityGroupName must be supplied.
        /// If the source type is DBParameterGroup, a DBParameterGroupName must be supplied.
        /// If the source type is DBSnapshot, a DBSnapshotIdentifier must be supplied.
        /// May not end with a hyphen or contain two consecutive hyphens.
        /// </summary>
        [XmlElementAttribute(ElementName = "SourceType")]
        public string SourceType
        {
            get { return this.sourceTypeField; }
            set { this.sourceTypeField = value; }
        }

        /// <summary>
        /// Sets the SourceType property
        /// </summary>
        /// <param name="sourceType">Specifies the event source to retrieve events for. If no value is specified, all events are returned.
        /// If SourceIdentifier is supplied, SourceType must also be provided.
        /// If the source type is DBInstance, then a DBInstanceIdentifier must be supplied.
        /// If the source type is DBSecurityGroup, a DBSecurityGroupName must be supplied.
        /// If the source type is DBParameterGroup, a DBParameterGroupName must be supplied.
        /// If the source type is DBSnapshot, a DBSnapshotIdentifier must be supplied.
        /// May not end with a hyphen or contain two consecutive hyphens.</param>
        /// <returns>this instance</returns>
        public DescribeEventsRequest WithSourceType(string sourceType)
        {
            this.sourceTypeField = sourceType;
            return this;
        }

        /// <summary>
        /// Checks if SourceType property is set
        /// </summary>
        /// <returns>true if SourceType property is set</returns>
        public bool IsSetSourceType()
        {
            return this.sourceTypeField != null;
        }

        /// <summary>
        /// Gets and sets the StartTime property.
        /// The beginning of the time interval to retrieve events for, specified in ISO 8601 format. For more information about ISO 8601, go to the ISO8601
        /// Wikipedia page. Example: 2009-07-08T18:00Z.
        /// </summary>
        [XmlElementAttribute(ElementName = "StartTime")]
        public DateTime StartTime
        {
            get { return this.startTimeField.GetValueOrDefault(); }
            set
            {
                this.startTimeField = DateTime.ParseExact(
                    value.ToString(),
                    Amazon.Util.AWSSDKUtils.ISO8601DateFormat,
                    System.Globalization.CultureInfo.InvariantCulture);
            }
        }

        /// <summary>
        /// Sets the StartTime property
        /// </summary>
        /// <param name="startTime">The beginning of the time interval to retrieve events for, specified in ISO 8601 format. For more information about ISO 8601, go to the ISO8601
        /// Wikipedia page. Example: 2009-07-08T18:00Z.</param>
        /// <returns>this instance</returns>
        public DescribeEventsRequest WithStartTime(DateTime startTime)
        {
            this.startTimeField = startTime;
            return this;
        }

        /// <summary>
        /// Checks if StartTime property is set
        /// </summary>
        /// <returns>true if StartTime property is set</returns>
        public bool IsSetStartTime()
        {
            return this.startTimeField.HasValue;
        }

        /// <summary>
        /// Gets and sets the EndTime property.
        /// The end of the time interval for which to retrieve events, specified in ISO 8601 format. For more information about ISO 8601, go to the ISO8601 Wikipedia page.
        /// Example: 2009-07-08T18:30Z.
        /// </summary>
        [XmlElementAttribute(ElementName = "EndTime")]
        public DateTime EndTime
        {
            get { return this.endTimeField.GetValueOrDefault(); }
            set
            {
                this.endTimeField = DateTime.ParseExact(
                    value.ToString(),
                    Amazon.Util.AWSSDKUtils.ISO8601DateFormat,
                    System.Globalization.CultureInfo.InvariantCulture);
            }
        }

        /// <summary>
        /// Sets the EndTime property
        /// </summary>
        /// <param name="endTime">The end of the time interval for which to retrieve events, specified in ISO 8601 format. For more information about ISO 8601, go to the ISO8601 Wikipedia page.
        /// Example: 2009-07-08T18:30Z.</param>
        /// <returns>this instance</returns>
        public DescribeEventsRequest WithEndTime(DateTime endTime)
        {
            this.endTimeField = endTime;
            return this;
        }

        /// <summary>
        /// Checks if EndTime property is set
        /// </summary>
        /// <returns>true if EndTime property is set</returns>
        public bool IsSetEndTime()
        {
            return this.endTimeField.HasValue;
        }

        /// <summary>
        /// Gets and sets the Duration property.
        /// The number of minutes to retrieve events for. Default: 60.
        /// </summary>
        [XmlElementAttribute(ElementName = "Duration")]
        public Decimal Duration
        {
            get { return this.durationField.GetValueOrDefault(); }
            set { this.durationField = value; }
        }

        /// <summary>
        /// Sets the Duration property
        /// </summary>
        /// <param name="duration">The number of minutes to retrieve events for. Default: 60.</param>
        /// <returns>this instance</returns>
        public DescribeEventsRequest WithDuration(Decimal duration)
        {
            this.durationField = duration;
            return this;
        }

        /// <summary>
        /// Checks if Duration property is set
        /// </summary>
        /// <returns>true if Duration property is set</returns>
        public bool IsSetDuration()
        {
            return this.durationField.HasValue;
        }

        /// <summary>
        /// Gets and sets the MaxRecords property.
        /// The maximum number of records to include in the response. If more than the MaxRecords value is available, a
        /// marker is included in the response so that the following results can be retrieved.
        /// Default: 100. Constraints: Minimum 20, maximum 100
        /// </summary>
        [XmlElementAttribute(ElementName = "MaxRecords")]
        public Decimal MaxRecords
        {
            get { return this.maxRecordsField.GetValueOrDefault(); }
            set { this.maxRecordsField = value; }
        }

        /// <summary>
        /// Sets the MaxRecords property
        /// </summary>
        /// <param name="maxRecords">The maximum number of records to include in the response. If more than the MaxRecords value is available, a
        /// marker is included in the response so that the following results can be retrieved.
        /// Default: 100. Constraints: Minimum 20, maximum 100</param>
        /// <returns>this instance</returns>
        public DescribeEventsRequest WithMaxRecords(Decimal maxRecords)
        {
            this.maxRecordsField = maxRecords;
            return this;
        }

        /// <summary>
        /// Checks if MaxRecords property is set
        /// </summary>
        /// <returns>true if MaxRecords property is set</returns>
        public bool IsSetMaxRecords()
        {
            return this.maxRecordsField.HasValue;
        }

        /// <summary>
        /// Gets and sets the Marker property.
        /// The marker provided in the previous request. If this parameter is specified, the response includes only records beyond
        /// the marker, up to MaxRecords.
        /// </summary>
        [XmlElementAttribute(ElementName = "Marker")]
        public string Marker
        {
            get { return this.markerField; }
            set { this.markerField = value; }
        }

        /// <summary>
        /// Sets the Marker property
        /// </summary>
        /// <param name="marker">The marker provided in the previous request. If this parameter is specified, the response includes only records beyond
        /// the marker, up to MaxRecords.</param>
        /// <returns>this instance</returns>
        public DescribeEventsRequest WithMarker(string marker)
        {
            this.markerField = marker;
            return this;
        }

        /// <summary>
        /// Checks if Marker property is set
        /// </summary>
        /// <returns>true if Marker property is set</returns>
        public bool IsSetMarker()
        {
            return this.markerField != null;
        }

    }
}
