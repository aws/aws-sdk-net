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
 * Do not modify this file. This file is generated from the s3tables-2018-05-10.normal.json service model.
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
namespace Amazon.S3Tables.Model
{
    /// <summary>
    /// This is the response object from the GetTableRecordExpirationJobStatus operation.
    /// </summary>
    public partial class GetTableRecordExpirationJobStatusResponse : AmazonWebServiceResponse
    {
        private string _failureMessage;
        private DateTime? _lastRunTimestamp;
        private TableRecordExpirationJobMetrics _metrics;
        private TableRecordExpirationJobStatus _status;

        /// <summary>
        /// Gets and sets the property FailureMessage. 
        /// <para>
        /// If the job failed, this field contains an error message describing the failure reason.
        /// </para>
        /// </summary>
        public string FailureMessage
        {
            get { return this._failureMessage; }
            set { this._failureMessage = value; }
        }

        // Check to see if FailureMessage property is set
        internal bool IsSetFailureMessage()
        {
            return this._failureMessage != null;
        }

        /// <summary>
        /// Gets and sets the property LastRunTimestamp. 
        /// <para>
        /// The timestamp when the expiration job was last executed.
        /// </para>
        /// </summary>
        public DateTime? LastRunTimestamp
        {
            get { return this._lastRunTimestamp; }
            set { this._lastRunTimestamp = value; }
        }

        // Check to see if LastRunTimestamp property is set
        internal bool IsSetLastRunTimestamp()
        {
            return this._lastRunTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Metrics. 
        /// <para>
        /// Metrics about the most recent expiration job execution, including the number of records
        /// and files deleted.
        /// </para>
        /// </summary>
        public TableRecordExpirationJobMetrics Metrics
        {
            get { return this._metrics; }
            set { this._metrics = value; }
        }

        // Check to see if Metrics property is set
        internal bool IsSetMetrics()
        {
            return this._metrics != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the most recent expiration job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public TableRecordExpirationJobStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}