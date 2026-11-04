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

namespace Amazon.RDS.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeDBLogFiles operation. Returns a list of
    /// DB log files for the DB instance. <para> This command doesn't apply to RDS Custom.
    /// </para>
    /// </summary>
    public partial class DescribeDBLogFilesRequest : AmazonRDSRequest
    {
        /// <summary>
        /// Gets and sets the property DBInstanceIdentifier. 
        /// <para>
        /// The customer-assigned name of the DB instance that contains the log files you want
        /// to list.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Must match the identifier of an existing DBInstance.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true)]
        public string DBInstanceIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the DBInstanceIdentifier property is set.
        /// </summary>
        internal bool IsSetDBInstanceIdentifier() => this.DBInstanceIdentifier != null;

        /// <summary>
        /// Gets and sets the property FileLastWritten. 
        /// <para>
        /// Filters the available log files for files written since the specified date, in POSIX
        /// timestamp format with milliseconds.
        /// </para>
        /// </summary>
        public long? FileLastWritten { get; set; }

        /// <summary>
        /// Checks to see if the FileLastWritten property is set.
        /// </summary>
        internal bool IsSetFileLastWritten() => this.FileLastWritten.HasValue;

        /// <summary>
        /// Gets and sets the property FileSize. 
        /// <para>
        /// Filters the available log files for files larger than the specified size.
        /// </para>
        /// </summary>
        public long? FileSize { get; set; }

        /// <summary>
        /// Checks to see if the FileSize property is set.
        /// </summary>
        internal bool IsSetFileSize() => this.FileSize.HasValue;

        /// <summary>
        /// Gets and sets the property FilenameContains. 
        /// <para>
        /// Filters the available log files for log file names that contain the specified string.
        /// </para>
        /// </summary>
        public string FilenameContains { get; set; }

        /// <summary>
        /// Checks to see if the FilenameContains property is set.
        /// </summary>
        internal bool IsSetFilenameContains() => this.FilenameContains != null;

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// This parameter isn't currently supported.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Filter> Filters { get; set; } = AWSConfigs.InitializeCollections ? new List<Filter>() : null;

        /// <summary>
        /// Checks to see if the Filters property is set.
        /// </summary>
        internal bool IsSetFilters() => this.Filters != null && (this.Filters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Marker. 
        /// <para>
        /// The pagination token provided in the previous request. If this parameter is specified
        /// the response includes only records beyond the marker, up to MaxRecords.
        /// </para>
        /// </summary>
        public string Marker { get; set; }

        /// <summary>
        /// Checks to see if the Marker property is set.
        /// </summary>
        internal bool IsSetMarker() => this.Marker != null;

        /// <summary>
        /// Gets and sets the property MaxRecords. 
        /// <para>
        /// The maximum number of records to include in the response. If more records exist than
        /// the specified MaxRecords value, a pagination token called a marker is included in
        /// the response so you can retrieve the remaining results.
        /// </para>
        /// </summary>
        public int? MaxRecords { get; set; }

        /// <summary>
        /// Checks to see if the MaxRecords property is set.
        /// </summary>
        internal bool IsSetMaxRecords() => this.MaxRecords.HasValue;
    }
}
