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
    /// Returns information about the DB Snapshots for this account. If you pass in a DBInstanceIdentifier, it returns information
    /// only about DB Snapshots taken for that DB Instance. If you pass in a DBSnapshotIdentifier,it will return information only
    /// about the specified snapshot. If you omit both DBInstanceIdentifier and DBSnapshotIdentifier, it returns all snapshot
    /// information for all database instances, up to the maximum number of records specified. Passing both DBInstanceIdentifier
    /// and DBSnapshotIdentifier results in an error.
    /// </summary>
    [XmlRootAttribute(Namespace = "http://rds.amazonaws.com/doc/2010-01-01/", IsNullable = false)]
    public class DescribeDBSnapshotsRequest
    {
        private string DBInstanceIdentifierField;
        private string DBSnapshotIdentifierField;
        private Decimal? maxRecordsField;
        private string markerField;

        /// <summary>
        /// Gets and sets the DBInstanceIdentifier property.
        /// DB Instance identifier. This is the unique key that identifies a DB Instance. This parameter isn't case sensitive.
        /// Must contain from 1 to 63 alphanumeric characters or hyphens.
        /// First character must be a letter.
        /// Cannot end with a hyphen or contain two consecutive hyphens.
        /// </summary>
        [XmlElementAttribute(ElementName = "DBInstanceIdentifier")]
        public string DBInstanceIdentifier
        {
            get { return this.DBInstanceIdentifierField; }
            set { this.DBInstanceIdentifierField = value; }
        }

        /// <summary>
        /// Sets the DBInstanceIdentifier property
        /// </summary>
        /// <param name="DBInstanceIdentifier">DB Instance identifier. This is the unique key that identifies a DB Instance. This parameter isn't case sensitive.
        /// Must contain from 1 to 63 alphanumeric characters or hyphens.
        /// First character must be a letter.
        /// Cannot end with a hyphen or contain two consecutive hyphens.</param>
        /// <returns>this instance</returns>
        public DescribeDBSnapshotsRequest WithDBInstanceIdentifier(string DBInstanceIdentifier)
        {
            this.DBInstanceIdentifierField = DBInstanceIdentifier;
            return this;
        }

        /// <summary>
        /// Checks if DBInstanceIdentifier property is set
        /// </summary>
        /// <returns>true if DBInstanceIdentifier property is set</returns>
        public bool IsSetDBInstanceIdentifier()
        {
            return this.DBInstanceIdentifierField != null;
        }

        /// <summary>
        /// Gets and sets the DBSnapshotIdentifier property.
        /// The unique identifier for the Amazon RDS DB snapshot. Stored as a lower-case string.
        /// Must contain 1 to 255 alphanumeric characters or hyphens.
        /// First character must be a letter.
        /// May not end with a hyphen or contain two consecutive hyphens.
        /// </summary>
        [XmlElementAttribute(ElementName = "DBSnapshotIdentifier")]
        public string DBSnapshotIdentifier
        {
            get { return this.DBSnapshotIdentifierField; }
            set { this.DBSnapshotIdentifierField = value; }
        }

        /// <summary>
        /// Sets the DBSnapshotIdentifier property
        /// </summary>
        /// <param name="DBSnapshotIdentifier">The unique identifier for the Amazon RDS DB snapshot. Stored as a lower-case string.
        /// Must contain 1 to 255 alphanumeric characters or hyphens.
        /// First character must be a letter.
        /// May not end with a hyphen or contain two consecutive hyphens.</param>
        /// <returns>this instance</returns>
        public DescribeDBSnapshotsRequest WithDBSnapshotIdentifier(string DBSnapshotIdentifier)
        {
            this.DBSnapshotIdentifierField = DBSnapshotIdentifier;
            return this;
        }

        /// <summary>
        /// Checks if DBSnapshotIdentifier property is set
        /// </summary>
        /// <returns>true if DBSnapshotIdentifier property is set</returns>
        public bool IsSetDBSnapshotIdentifier()
        {
            return this.DBSnapshotIdentifierField != null;
        }

        /// <summary>
        /// Gets and sets the MaxRecords property.
        /// The maximum number of records to include in the response. If more than the MaxRecords value is available, a marker is included in the
        /// response so that the following results can be retrieved. Default: 100. Constraints: Minimum 20, maximum 100
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
        /// <param name="maxRecords">The maximum number of records to include in the response. If more than the MaxRecords value is available, a marker is included in the
        /// response so that the following results can be retrieved. Default: 100. Constraints: Minimum 20, maximum 100</param>
        /// <returns>this instance</returns>
        public DescribeDBSnapshotsRequest WithMaxRecords(Decimal maxRecords)
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
        /// The marker provided in the previous request. If this parameter is specified, the response includes only records beyond the marker, up to MaxRecords.
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
        /// <param name="marker">The marker provided in the previous request. If this parameter is specified, the response includes only records beyond the marker, up to MaxRecords.</param>
        /// <returns>this instance</returns>
        public DescribeDBSnapshotsRequest WithMarker(string marker)
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
