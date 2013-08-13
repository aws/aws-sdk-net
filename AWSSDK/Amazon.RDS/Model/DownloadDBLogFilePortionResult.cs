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

namespace Amazon.RDS.Model
{
    /// <summary>
    /// <para>This data type is used as a response element to DownloadDBLogFilePortion.</para>
    /// </summary>
    public class DownloadDBLogFilePortionResult
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

        /// <summary>
        /// Sets the LogFileData property
        /// </summary>
        /// <param name="logFileData">The value to set for the LogFileData property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DownloadDBLogFilePortionResult WithLogFileData(string logFileData)
        {
            this.logFileData = logFileData;
            return this;
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

        /// <summary>
        /// Sets the Marker property
        /// </summary>
        /// <param name="marker">The value to set for the Marker property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DownloadDBLogFilePortionResult WithMarker(string marker)
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
        /// Boolean value that if true, indicates there is more data to be downloaded.
        ///  
        /// </summary>
        public bool AdditionalDataPending
        {
            get { return this.additionalDataPending ?? default(bool); }
            set { this.additionalDataPending = value; }
        }

        /// <summary>
        /// Sets the AdditionalDataPending property
        /// </summary>
        /// <param name="additionalDataPending">The value to set for the AdditionalDataPending property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DownloadDBLogFilePortionResult WithAdditionalDataPending(bool additionalDataPending)
        {
            this.additionalDataPending = additionalDataPending;
            return this;
        }
            

        // Check to see if AdditionalDataPending property is set
        internal bool IsSetAdditionalDataPending()
        {
            return this.additionalDataPending.HasValue;
        }
    }
}
