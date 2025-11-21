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
    /// This data type is used as a response element to <c>DownloadDBLogFilePortion</c>.
    /// </summary>
    public partial class DownloadDBLogFilePortionResponse : AmazonWebServiceResponse
    {
        private bool? _additionalDataPending;
        private string _logFileData;
        private string _marker;

        /// <summary>
        /// Gets and sets the property AdditionalDataPending. 
        /// <para>
        /// A Boolean value that, if true, indicates there is more data to be downloaded.
        /// </para>
        /// </summary>
        public bool? AdditionalDataPending
        {
            get { return this._additionalDataPending; }
            set { this._additionalDataPending = value; }
        }

        // Check to see if AdditionalDataPending property is set
        internal bool IsSetAdditionalDataPending()
        {
            return this._additionalDataPending.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LogFileData. 
        /// <para>
        /// Entries from the specified log file.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string LogFileData
        {
            get { return this._logFileData; }
            set { this._logFileData = value; }
        }

        // Check to see if LogFileData property is set
        internal bool IsSetLogFileData()
        {
            return this._logFileData != null;
        }

        /// <summary>
        /// Gets and sets the property Marker. 
        /// <para>
        /// A pagination token that can be used in a later <c>DownloadDBLogFilePortion</c> request.
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

    }
}