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
 * Do not modify this file. This file is generated from the honeycode-2020-03-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Honeycode.Model
{
    /// <summary>
    /// This is the response object from the DescribeTableDataImportJob operation.
    /// </summary>
    public partial class DescribeTableDataImportJobResponse : AmazonWebServiceResponse
    {
        private TableDataImportJobMetadata _jobMetadata;
        private TableDataImportJobStatus _jobStatus;
        private string _message;

        /// <summary>
        /// Gets and sets the property JobMetadata. 
        /// <para>
        ///  The metadata about the job that was submitted for import. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public TableDataImportJobMetadata JobMetadata
        {
            get { return this._jobMetadata; }
            set { this._jobMetadata = value; }
        }

        // Check to see if JobMetadata property is set
        internal bool IsSetJobMetadata()
        {
            return this._jobMetadata != null;
        }

        /// <summary>
        /// Gets and sets the property JobStatus. 
        /// <para>
        ///  The current status of the import job. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public TableDataImportJobStatus JobStatus
        {
            get { return this._jobStatus; }
            set { this._jobStatus = value; }
        }

        // Check to see if JobStatus property is set
        internal bool IsSetJobStatus()
        {
            return this._jobStatus != null;
        }

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        ///  A message providing more details about the current status of the import job. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Message
        {
            get { return this._message; }
            set { this._message = value; }
        }

        // Check to see if Message property is set
        internal bool IsSetMessage()
        {
            return this._message != null;
        }

    }
}