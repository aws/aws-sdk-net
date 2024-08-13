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
 * Do not modify this file. This file is generated from the migrationhubstrategy-2020-02-19.normal.json service model.
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
namespace Amazon.MigrationHubStrategyRecommendations.Model
{
    /// <summary>
    /// This is the response object from the GetImportFileTask operation.
    /// </summary>
    public partial class GetImportFileTaskResponse : AmazonWebServiceResponse
    {
        private DateTime? _completionTime;
        private string _id;
        private string _importName;
        private string _inputs3Bucket;
        private string _inputs3Key;
        private int? _numberOfRecordsFailed;
        private int? _numberOfRecordsSuccess;
        private DateTime? _startTime;
        private ImportFileTaskStatus _status;
        private string _statusReportS3Bucket;
        private string _statusReportS3Key;

        /// <summary>
        /// Gets and sets the property CompletionTime. 
        /// <para>
        ///  The time that the import task completed. 
        /// </para>
        /// </summary>
        public DateTime? CompletionTime
        {
            get { return this._completionTime; }
            set { this._completionTime = value; }
        }

        // Check to see if CompletionTime property is set
        internal bool IsSetCompletionTime()
        {
            return this._completionTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        ///  The import file task <c>id</c> returned in the response of <a>StartImportFileTask</a>.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property ImportName. 
        /// <para>
        ///  The name of the import task given in <a>StartImportFileTask</a>. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string ImportName
        {
            get { return this._importName; }
            set { this._importName = value; }
        }

        // Check to see if ImportName property is set
        internal bool IsSetImportName()
        {
            return this._importName != null;
        }

        /// <summary>
        /// Gets and sets the property InputS3Bucket. 
        /// <para>
        ///  The S3 bucket where import file is located. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=63)]
        public string InputS3Bucket
        {
            get { return this._inputs3Bucket; }
            set { this._inputs3Bucket = value; }
        }

        // Check to see if InputS3Bucket property is set
        internal bool IsSetInputS3Bucket()
        {
            return this._inputs3Bucket != null;
        }

        /// <summary>
        /// Gets and sets the property InputS3Key. 
        /// <para>
        ///  The Amazon S3 key name of the import file. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string InputS3Key
        {
            get { return this._inputs3Key; }
            set { this._inputs3Key = value; }
        }

        // Check to see if InputS3Key property is set
        internal bool IsSetInputS3Key()
        {
            return this._inputs3Key != null;
        }

        /// <summary>
        /// Gets and sets the property NumberOfRecordsFailed. 
        /// <para>
        ///  The number of records that failed to be imported. 
        /// </para>
        /// </summary>
        public int? NumberOfRecordsFailed
        {
            get { return this._numberOfRecordsFailed; }
            set { this._numberOfRecordsFailed = value; }
        }

        // Check to see if NumberOfRecordsFailed property is set
        internal bool IsSetNumberOfRecordsFailed()
        {
            return this._numberOfRecordsFailed.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NumberOfRecordsSuccess. 
        /// <para>
        ///  The number of records successfully imported. 
        /// </para>
        /// </summary>
        public int? NumberOfRecordsSuccess
        {
            get { return this._numberOfRecordsSuccess; }
            set { this._numberOfRecordsSuccess = value; }
        }

        // Check to see if NumberOfRecordsSuccess property is set
        internal bool IsSetNumberOfRecordsSuccess()
        {
            return this._numberOfRecordsSuccess.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        ///  Start time of the import task. 
        /// </para>
        /// </summary>
        public DateTime? StartTime
        {
            get { return this._startTime; }
            set { this._startTime = value; }
        }

        // Check to see if StartTime property is set
        internal bool IsSetStartTime()
        {
            return this._startTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        ///  Status of import file task. 
        /// </para>
        /// </summary>
        public ImportFileTaskStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property StatusReportS3Bucket. 
        /// <para>
        ///  The S3 bucket name for status report of import task. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=63)]
        public string StatusReportS3Bucket
        {
            get { return this._statusReportS3Bucket; }
            set { this._statusReportS3Bucket = value; }
        }

        // Check to see if StatusReportS3Bucket property is set
        internal bool IsSetStatusReportS3Bucket()
        {
            return this._statusReportS3Bucket != null;
        }

        /// <summary>
        /// Gets and sets the property StatusReportS3Key. 
        /// <para>
        ///  The Amazon S3 key name for status report of import task. The report contains details
        /// about whether each record imported successfully or why it did not.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string StatusReportS3Key
        {
            get { return this._statusReportS3Key; }
            set { this._statusReportS3Key = value; }
        }

        // Check to see if StatusReportS3Key property is set
        internal bool IsSetStatusReportS3Key()
        {
            return this._statusReportS3Key != null;
        }

    }
}