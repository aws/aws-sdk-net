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
    /// Container for the parameters to the DescribeDBLogFiles operation.
    /// Returns a list of DB log files for the DB instance.
    /// 
    ///  
    /// <para>
    /// This command doesn't apply to RDS Custom.
    /// </para>
    /// </summary>
    public partial class DescribeDBLogFilesRequest : AmazonRDSRequest
    {
        private string _dbInstanceIdentifier;
        private long? _fileLastWritten;
        private string _filenameContains;
        private long? _fileSize;
        private List<Filter> _filters = AWSConfigs.InitializeCollections ? new List<Filter>() : null;
        private string _marker;
        private int? _maxRecords;

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
        [AWSProperty(Required=true)]
        public string DBInstanceIdentifier
        {
            get { return this._dbInstanceIdentifier; }
            set { this._dbInstanceIdentifier = value; }
        }

        // Check to see if DBInstanceIdentifier property is set
        internal bool IsSetDBInstanceIdentifier()
        {
            return this._dbInstanceIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property FileLastWritten. 
        /// <para>
        /// Filters the available log files for files written since the specified date, in POSIX
        /// timestamp format with milliseconds.
        /// </para>
        /// </summary>
        public long? FileLastWritten
        {
            get { return this._fileLastWritten; }
            set { this._fileLastWritten = value; }
        }

        // Check to see if FileLastWritten property is set
        internal bool IsSetFileLastWritten()
        {
            return this._fileLastWritten.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FilenameContains. 
        /// <para>
        /// Filters the available log files for log file names that contain the specified string.
        /// </para>
        /// </summary>
        public string FilenameContains
        {
            get { return this._filenameContains; }
            set { this._filenameContains = value; }
        }

        // Check to see if FilenameContains property is set
        internal bool IsSetFilenameContains()
        {
            return this._filenameContains != null;
        }

        /// <summary>
        /// Gets and sets the property FileSize. 
        /// <para>
        /// Filters the available log files for files larger than the specified size.
        /// </para>
        /// </summary>
        public long? FileSize
        {
            get { return this._fileSize; }
            set { this._fileSize = value; }
        }

        // Check to see if FileSize property is set
        internal bool IsSetFileSize()
        {
            return this._fileSize.HasValue; 
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
        /// The pagination token provided in the previous request. If this parameter is specified
        /// the response includes only records beyond the marker, up to MaxRecords.
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
        /// the specified MaxRecords value, a pagination token called a marker is included in
        /// the response so you can retrieve the remaining results.
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

    }
}