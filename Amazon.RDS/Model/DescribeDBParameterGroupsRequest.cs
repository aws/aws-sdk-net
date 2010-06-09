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
 *  API Version: 2009-10-16
 */

using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

namespace Amazon.RDS.Model
{
    /// <summary>
    /// Returns information about all DB Parameter Groups for an account if no DB Parameter Group name is supplied, or displays
    /// information about a specific named DB Parameter Group. You can call this operation recursively using the Marker parameter.
    /// </summary>
    [XmlRootAttribute(Namespace = "http://rds.amazonaws.com/admin/2009-10-16/", IsNullable = false)]
    public class DescribeDBParameterGroupsRequest
    {
        private string DBParameterGroupNameField;
        private Decimal? maxRecordsField;
        private string markerField;

        /// <summary>
        /// Gets and sets the DBParameterGroupName property.
        /// The name of a specific database parameter group to return details for. Must contain 1 to 255 alphanumeric characters or hyphens.
        /// First character must be a letter. May not end with a hyphen or contain two consecutive hyphens.
        /// </summary>
        [XmlElementAttribute(ElementName = "DBParameterGroupName")]
        public string DBParameterGroupName
        {
            get { return this.DBParameterGroupNameField; }
            set { this.DBParameterGroupNameField = value; }
        }

        /// <summary>
        /// Sets the DBParameterGroupName property
        /// </summary>
        /// <param name="DBParameterGroupName">The name of a specific database parameter group to return details for. Must contain 1 to 255 alphanumeric characters or hyphens.
        /// First character must be a letter. May not end with a hyphen or contain two consecutive hyphens.</param>
        /// <returns>this instance</returns>
        public DescribeDBParameterGroupsRequest WithDBParameterGroupName(string DBParameterGroupName)
        {
            this.DBParameterGroupNameField = DBParameterGroupName;
            return this;
        }

        /// <summary>
        /// Checks if DBParameterGroupName property is set
        /// </summary>
        /// <returns>true if DBParameterGroupName property is set</returns>
        public bool IsSetDBParameterGroupName()
        {
            return this.DBParameterGroupNameField != null;
        }

        /// <summary>
        /// Gets and sets the MaxRecords property.
        /// The maximum number of records to include in the response. If more than the MaxRecords value is available, a marker
        /// is included in the response so that the following results can be retrieved.
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
        /// <param name="maxRecords">The maximum number of records to include in the response. If more than the MaxRecords value is available, a marker
        /// is included in the response so that the following results can be retrieved.</param>
        /// <returns>this instance</returns>
        public DescribeDBParameterGroupsRequest WithMaxRecords(Decimal maxRecords)
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
        /// The marker provided in the previous request. If this parameter is specified, the response includes only records
        /// beyond the marker, up to MaxRecords.
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
        /// <param name="marker">The marker provided in the previous request. If this parameter is specified, the response includes only records
        /// beyond the marker, up to MaxRecords.</param>
        /// <returns>this instance</returns>
        public DescribeDBParameterGroupsRequest WithMarker(string marker)
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
