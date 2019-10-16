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
 * Do not modify this file. This file is generated from the qldb-2019-01-02.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.QLDB.Model
{
    /// <summary>
    /// The information about a journal export job, including the ledger name, export ID,
    /// when it was created, current status, and its start and end time export parameters.
    /// </summary>
    public partial class JournalS3ExportDescription
    {
        private DateTime? _exclusiveEndTime;
        private DateTime? _exportCreationTime;
        private string _exportId;
        private DateTime? _inclusiveStartTime;
        private string _ledgerName;
        private string _roleArn;
        private S3ExportConfiguration _s3ExportConfiguration;
        private ExportStatus _status;

        /// <summary>
        /// Gets and sets the property ExclusiveEndTime. 
        /// <para>
        /// The exclusive end date and time for the range of journal contents that are specified
        /// in the original export request.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime ExclusiveEndTime
        {
            get { return this._exclusiveEndTime.GetValueOrDefault(); }
            set { this._exclusiveEndTime = value; }
        }

        // Check to see if ExclusiveEndTime property is set
        internal bool IsSetExclusiveEndTime()
        {
            return this._exclusiveEndTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ExportCreationTime. 
        /// <para>
        /// The date and time, in epoch time format, when the export job was created. (Epoch time
        /// format is the number of seconds elapsed since 12:00:00 AM January 1, 1970 UTC.)
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime ExportCreationTime
        {
            get { return this._exportCreationTime.GetValueOrDefault(); }
            set { this._exportCreationTime = value; }
        }

        // Check to see if ExportCreationTime property is set
        internal bool IsSetExportCreationTime()
        {
            return this._exportCreationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ExportId. 
        /// <para>
        /// The unique ID of the journal export job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=22, Max=22)]
        public string ExportId
        {
            get { return this._exportId; }
            set { this._exportId = value; }
        }

        // Check to see if ExportId property is set
        internal bool IsSetExportId()
        {
            return this._exportId != null;
        }

        /// <summary>
        /// Gets and sets the property InclusiveStartTime. 
        /// <para>
        /// The inclusive start date and time for the range of journal contents that are specified
        /// in the original export request.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime InclusiveStartTime
        {
            get { return this._inclusiveStartTime.GetValueOrDefault(); }
            set { this._inclusiveStartTime = value; }
        }

        // Check to see if InclusiveStartTime property is set
        internal bool IsSetInclusiveStartTime()
        {
            return this._inclusiveStartTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LedgerName. 
        /// <para>
        /// The name of the ledger.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=32)]
        public string LedgerName
        {
            get { return this._ledgerName; }
            set { this._ledgerName = value; }
        }

        // Check to see if LedgerName property is set
        internal bool IsSetLedgerName()
        {
            return this._ledgerName != null;
        }

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM role that grants QLDB permissions for a
        /// journal export job to do the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Write objects into your Amazon Simple Storage Service (Amazon S3) bucket.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// (Optional) Use your customer master key (CMK) in AWS Key Management Service (AWS KMS)
        /// for server-side encryption of your exported data.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=1600)]
        public string RoleArn
        {
            get { return this._roleArn; }
            set { this._roleArn = value; }
        }

        // Check to see if RoleArn property is set
        internal bool IsSetRoleArn()
        {
            return this._roleArn != null;
        }

        /// <summary>
        /// Gets and sets the property S3ExportConfiguration.
        /// </summary>
        [AWSProperty(Required=true)]
        public S3ExportConfiguration S3ExportConfiguration
        {
            get { return this._s3ExportConfiguration; }
            set { this._s3ExportConfiguration = value; }
        }

        // Check to see if S3ExportConfiguration property is set
        internal bool IsSetS3ExportConfiguration()
        {
            return this._s3ExportConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current state of the journal export job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ExportStatus Status
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