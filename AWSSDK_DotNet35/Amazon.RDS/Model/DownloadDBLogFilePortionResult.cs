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

namespace Amazon.RDS.Model
{
    /// <summary>
    /// <para>This data type is used as a response element to DownloadDBLogFilePortion.</para>
    /// </summary>
    public partial class DownloadDBLogFilePortionResult : AmazonWebServiceResponse
    {
        
        private string logFileData;
        private string marker;
        private bool? additionalDataPending;


        /// <summary>
        /// Entries from the specified log file.
        ///  
        /// </summary>
        public string LogFileData
        {
            get { return this.logFileData; }
            set { this.logFileData = value; }
        }

        // Check to see if LogFileData property is set
        internal bool IsSetLogFileData()
        {
            return this.logFileData != null;
        }

        /// <summary>
        /// An optional pagination token provided by a previous DownloadDBLogFilePortion request.
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

        /// <summary>
        /// Boolean value that if true, indicates there is more data to be downloaded.
        ///  
        /// </summary>
        public bool AdditionalDataPending
        {
            get { return this.additionalDataPending ?? default(bool); }
            set { this.additionalDataPending = value; }
        }

        // Check to see if AdditionalDataPending property is set
        internal bool IsSetAdditionalDataPending()
        {
            return this.additionalDataPending.HasValue;
        }
    }
}
