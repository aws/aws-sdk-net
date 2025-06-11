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
    /// Container for the parameters to the DownloadDBLogFilePortion operation.
    /// Downloads all or a portion of the specified log file, up to 1 MB in size.
    /// 
    ///  
    /// <para>
    /// This command doesn't apply to RDS Custom.
    /// </para>
    ///  <note> 
    /// <para>
    /// This operation uses resources on database instances. Because of this, we recommend
    /// publishing database logs to CloudWatch and then using the GetLogEvents operation.
    /// For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_GetLogEvents.html">GetLogEvents</a>
    /// in the <i>Amazon CloudWatch Logs API Reference</i>.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class DownloadDBLogFilePortionRequest : AmazonRDSRequest
    {
        private string _dbInstanceIdentifier;
        private string _logFileName;
        private string _marker;
        private int? _numberOfLines;

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
        /// Gets and sets the property LogFileName. 
        /// <para>
        /// The name of the log file to be downloaded.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// The pagination token provided in the previous request or "0". If the Marker parameter
        /// is specified the response includes only records beyond the marker until the end of
        /// the file or up to NumberOfLines.
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
        /// The number of lines to download. If the number of lines specified results in a file
        /// over 1 MB in size, the file is truncated at 1 MB in size.
        /// </para>
        ///  
        /// <para>
        /// If the NumberOfLines parameter is specified, then the block of lines returned can
        /// be from the beginning or the end of the log file, depending on the value of the Marker
        /// parameter.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If neither Marker or NumberOfLines are specified, the entire log file is returned
        /// up to a maximum of 10000 lines, starting with the most recent log entries first.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If NumberOfLines is specified and Marker isn't specified, then the most recent lines
        /// from the end of the log file are returned.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If Marker is specified as "0", then the specified number of lines from the beginning
        /// of the log file are returned.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You can download the log file in blocks of lines by specifying the size of the block
        /// using the NumberOfLines parameter, and by specifying a value of "0" for the Marker
        /// parameter in your first request. Include the Marker value returned in the response
        /// as the Marker value for the next request, continuing until the AdditionalDataPending
        /// response element returns false.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public int? NumberOfLines
        {
            get { return this._numberOfLines; }
            set { this._numberOfLines = value; }
        }

        // Check to see if NumberOfLines property is set
        internal bool IsSetNumberOfLines()
        {
            return this._numberOfLines.HasValue; 
        }

    }
}