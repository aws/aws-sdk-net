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
    /// Container for the parameters to the DownloadDBLogFilePortion operation.
    /// <para> Downloads the last line of the specified log file. </para>
    /// </summary>
    /// <seealso cref="Amazon.RDS.AmazonRDS.DownloadDBLogFilePortion"/>
    public class DownloadDBLogFilePortionRequest : AmazonWebServiceRequest
    {
        private string dBInstanceIdentifier;
        private string logFileName;
        private string marker;
        private int? numberOfLines;

        /// <summary>
        /// The customer-assigned name of the DB Instance that contains the log files you want to list. Constraints: <ul> <li>Must contain from 1 to 63
        /// alphanumeric characters or hyphens</li> <li>First character must be a letter</li> <li>Cannot end with a hyphen or contain two consecutive
        /// hyphens</li> </ul>
        ///  
        /// </summary>
        public string DBInstanceIdentifier
        {
            get { return this.dBInstanceIdentifier; }
            set { this.dBInstanceIdentifier = value; }
        }

        /// <summary>
        /// Sets the DBInstanceIdentifier property
        /// </summary>
        /// <param name="dBInstanceIdentifier">The value to set for the DBInstanceIdentifier property </param>
        /// <returns>this instance</returns>
        public DownloadDBLogFilePortionRequest WithDBInstanceIdentifier(string dBInstanceIdentifier)
        {
            this.dBInstanceIdentifier = dBInstanceIdentifier;
            return this;
        }
            

        // Check to see if DBInstanceIdentifier property is set
        internal bool IsSetDBInstanceIdentifier()
        {
            return this.dBInstanceIdentifier != null;
        }

        /// <summary>
        /// The name of the log file to be downloaded.
        ///  
        /// </summary>
        public string LogFileName
        {
            get { return this.logFileName; }
            set { this.logFileName = value; }
        }

        /// <summary>
        /// Sets the LogFileName property
        /// </summary>
        /// <param name="logFileName">The value to set for the LogFileName property </param>
        /// <returns>this instance</returns>
        public DownloadDBLogFilePortionRequest WithLogFileName(string logFileName)
        {
            this.logFileName = logFileName;
            return this;
        }
            

        // Check to see if LogFileName property is set
        internal bool IsSetLogFileName()
        {
            return this.logFileName != null;
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

        /// <summary>
        /// Sets the Marker property
        /// </summary>
        /// <param name="marker">The value to set for the Marker property </param>
        /// <returns>this instance</returns>
        public DownloadDBLogFilePortionRequest WithMarker(string marker)
        {
            this.marker = marker;
            return this;
        }
            

        // Check to see if Marker property is set
        internal bool IsSetMarker()
        {
            return this.marker != null;
        }

        /// <summary>
        /// The number of lines remaining to be downloaded.
        ///  
        /// </summary>
        public int NumberOfLines
        {
            get { return this.numberOfLines ?? default(int); }
            set { this.numberOfLines = value; }
        }

        /// <summary>
        /// Sets the NumberOfLines property
        /// </summary>
        /// <param name="numberOfLines">The value to set for the NumberOfLines property </param>
        /// <returns>this instance</returns>
        public DownloadDBLogFilePortionRequest WithNumberOfLines(int numberOfLines)
        {
            this.numberOfLines = numberOfLines;
            return this;
        }
            

        // Check to see if NumberOfLines property is set
        internal bool IsSetNumberOfLines()
        {
            return this.numberOfLines.HasValue;
        }
    }
}
    
