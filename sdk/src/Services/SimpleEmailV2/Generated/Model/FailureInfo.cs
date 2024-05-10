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
 * Do not modify this file. This file is generated from the sesv2-2019-09-27.normal.json service model.
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
namespace Amazon.SimpleEmailV2.Model
{
    /// <summary>
    /// An object that contains the failure details about a job.
    /// </summary>
    public partial class FailureInfo
    {
        private string _errorMessage;
        private string _failedRecordsS3Url;

        /// <summary>
        /// Gets and sets the property ErrorMessage. 
        /// <para>
        /// A message about why the job failed.
        /// </para>
        /// </summary>
        public string ErrorMessage
        {
            get { return this._errorMessage; }
            set { this._errorMessage = value; }
        }

        // Check to see if ErrorMessage property is set
        internal bool IsSetErrorMessage()
        {
            return this._errorMessage != null;
        }

        /// <summary>
        /// Gets and sets the property FailedRecordsS3Url. 
        /// <para>
        /// An Amazon S3 pre-signed URL that contains all the failed records and related information.
        /// </para>
        /// </summary>
        public string FailedRecordsS3Url
        {
            get { return this._failedRecordsS3Url; }
            set { this._failedRecordsS3Url = value; }
        }

        // Check to see if FailedRecordsS3Url property is set
        internal bool IsSetFailedRecordsS3Url()
        {
            return this._failedRecordsS3Url != null;
        }

    }
}