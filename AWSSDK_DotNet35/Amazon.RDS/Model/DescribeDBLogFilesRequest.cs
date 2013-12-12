/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// Container for the parameters to the DescribeDBLogFiles operation.
    /// <para> Returns a list of DB log files for the DB instance. </para>
    /// </summary>
    public partial class DescribeDBLogFilesRequest : AmazonRDSRequest
    {
        private string dBInstanceIdentifier;
        private string filenameContains;
        private long? fileLastWritten;
        private long? fileSize;
        private int? maxRecords;
        private string marker;


        /// <summary>
        /// The customer-assigned name of the DB instance that contains the log files you want to list. Constraints: <ul> <li>Must contain from 1 to 63
        /// alphanumeric characters or hyphens</li> <li>First character must be a letter</li> <li>Cannot end with a hyphen or contain two consecutive
        /// hyphens</li> </ul>
        ///  
        /// </summary>
        public string DBInstanceIdentifier
        {
            get { return this.dBInstanceIdentifier; }
            set { this.dBInstanceIdentifier = value; }
        }

        // Check to see if DBInstanceIdentifier property is set
        internal bool IsSetDBInstanceIdentifier()
        {
            return this.dBInstanceIdentifier != null;
        }

        /// <summary>
        /// Filters the available log files for log file names that contain the specified string.
        ///  
        /// </summary>
        public string FilenameContains
        {
            get { return this.filenameContains; }
            set { this.filenameContains = value; }
        }

        // Check to see if FilenameContains property is set
        internal bool IsSetFilenameContains()
        {
            return this.filenameContains != null;
        }

        /// <summary>
        /// Filters the available log files for files written since the specified date, in POSIX timestamp format.
        ///  
        /// </summary>
        public long FileLastWritten
        {
            get { return this.fileLastWritten ?? default(long); }
            set { this.fileLastWritten = value; }
        }

        // Check to see if FileLastWritten property is set
        internal bool IsSetFileLastWritten()
        {
            return this.fileLastWritten.HasValue;
        }

        /// <summary>
        /// Filters the available log files for files larger than the specified size.
        ///  
        /// </summary>
        public long FileSize
        {
            get { return this.fileSize ?? default(long); }
            set { this.fileSize = value; }
        }

        // Check to see if FileSize property is set
        internal bool IsSetFileSize()
        {
            return this.fileSize.HasValue;
        }

        /// <summary>
        /// The maximum number of records to include in the response. If more records exist than the specified MaxRecords value, a pagination token
        /// called a marker is included in the response so that the remaining results can be retrieved.
        ///  
        /// </summary>
        public int MaxRecords
        {
            get { return this.maxRecords ?? default(int); }
            set { this.maxRecords = value; }
        }

        // Check to see if MaxRecords property is set
        internal bool IsSetMaxRecords()
        {
            return this.maxRecords.HasValue;
        }

        /// <summary>
        /// The pagination token provided in the previous request. If this parameter is specified the response includes only records beyond the marker,
        /// up to MaxRecords.
        ///  
        /// </summary>
        public string Marker
        {
            get { return this.marker; }
            set { this.marker = value; }
        }

        // Check to see if Marker property is set
        internal bool IsSetMarker()
        {
            return this.marker != null;
        }

    }
}
    
