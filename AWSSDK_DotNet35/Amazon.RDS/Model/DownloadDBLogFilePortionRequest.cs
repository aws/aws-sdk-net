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
 * Do not modify this file. This file is generated from the rds-2013-09-09.normal.json service model.
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
    /// Container for the parameters to the DownloadDBLogFilePortion operation.
    /// Downloads the last line of the specified log file.
    /// </summary>
    public partial class DownloadDBLogFilePortionRequest : AmazonRDSRequest
    {
        private string _dBInstanceIdentifier;
        private string _logFileName;
        private string _marker;
        private int? _numberOfLines;

        /// <summary>
        /// Gets and sets the property DBInstanceIdentifier. 
        /// <para>
        ///  The customer-assigned name of the DB instance that contains the log files you want
        /// to list. 
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li>Must contain from 1 to 63 alphanumeric characters or hyphens</li> <li>First
        /// character must be a letter</li> <li>Cannot end with a hyphen or contain two consecutive
        /// hyphens</li> </ul>
        /// </summary>
        public string DBInstanceIdentifier
        {
            get { return this._dBInstanceIdentifier; }
            set { this._dBInstanceIdentifier = value; }
        }

        // Check to see if DBInstanceIdentifier property is set
        internal bool IsSetDBInstanceIdentifier()
        {
            return this._dBInstanceIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property LogFileName. 
        /// <para>
        ///  The name of the log file to be downloaded. 
        /// </para>
        /// </summary>
        public string LogFileName
        {
            get { return this._logFileName; }
            set { this._logFileName = value; }
        }

        // Check to see if LogFileName property is set
        internal bool IsSetLogFileName()
        {
            return this._logFileName != null;
        }

        /// <summary>
        /// Gets and sets the property Marker. 
        /// <para>
        ///  The pagination token provided in the previous request. If this parameter is specified
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
        /// Gets and sets the property NumberOfLines. 
        /// <para>
        ///  The number of lines remaining to be downloaded. 
        /// </para>
        /// </summary>
        public int NumberOfLines
        {
            get { return this._numberOfLines.GetValueOrDefault(); }
            set { this._numberOfLines = value; }
        }

        // Check to see if NumberOfLines property is set
        internal bool IsSetNumberOfLines()
        {
            return this._numberOfLines.HasValue; 
        }

    }
}