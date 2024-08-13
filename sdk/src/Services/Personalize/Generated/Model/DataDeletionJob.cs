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
 * Do not modify this file. This file is generated from the personalize-2018-05-22.normal.json service model.
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
namespace Amazon.Personalize.Model
{
    /// <summary>
    /// Describes a job that deletes all references to specific users from an Amazon Personalize
    /// dataset group in batches. For information about creating a data deletion job, see
    /// <a href="https://docs.aws.amazon.com/personalize/latest/dg/delete-records.html">Deleting
    /// users</a>.
    /// </summary>
    public partial class DataDeletionJob
    {
        private DateTime? _creationDateTime;
        private string _dataDeletionJobArn;
        private string _datasetGroupArn;
        private DataSource _dataSource;
        private string _failureReason;
        private string _jobName;
        private DateTime? _lastUpdatedDateTime;
        private int? _numDeleted;
        private string _roleArn;
        private string _status;

        /// <summary>
        /// Gets and sets the property CreationDateTime. 
        /// <para>
        /// The creation date and time (in Unix time) of the data deletion job.
        /// </para>
        /// </summary>
        public DateTime? CreationDateTime
        {
            get { return this._creationDateTime; }
            set { this._creationDateTime = value; }
        }

        // Check to see if CreationDateTime property is set
        internal bool IsSetCreationDateTime()
        {
            return this._creationDateTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DataDeletionJobArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the data deletion job.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string DataDeletionJobArn
        {
            get { return this._dataDeletionJobArn; }
            set { this._dataDeletionJobArn = value; }
        }

        // Check to see if DataDeletionJobArn property is set
        internal bool IsSetDataDeletionJobArn()
        {
            return this._dataDeletionJobArn != null;
        }

        /// <summary>
        /// Gets and sets the property DatasetGroupArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the dataset group the job deletes records from.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string DatasetGroupArn
        {
            get { return this._datasetGroupArn; }
            set { this._datasetGroupArn = value; }
        }

        // Check to see if DatasetGroupArn property is set
        internal bool IsSetDatasetGroupArn()
        {
            return this._datasetGroupArn != null;
        }

        /// <summary>
        /// Gets and sets the property DataSource.
        /// </summary>
        public DataSource DataSource
        {
            get { return this._dataSource; }
            set { this._dataSource = value; }
        }

        // Check to see if DataSource property is set
        internal bool IsSetDataSource()
        {
            return this._dataSource != null;
        }

        /// <summary>
        /// Gets and sets the property FailureReason. 
        /// <para>
        /// If a data deletion job fails, provides the reason why.
        /// </para>
        /// </summary>
        public string FailureReason
        {
            get { return this._failureReason; }
            set { this._failureReason = value; }
        }

        // Check to see if FailureReason property is set
        internal bool IsSetFailureReason()
        {
            return this._failureReason != null;
        }

        /// <summary>
        /// Gets and sets the property JobName. 
        /// <para>
        /// The name of the data deletion job.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=63)]
        public string JobName
        {
            get { return this._jobName; }
            set { this._jobName = value; }
        }

        // Check to see if JobName property is set
        internal bool IsSetJobName()
        {
            return this._jobName != null;
        }

        /// <summary>
        /// Gets and sets the property LastUpdatedDateTime. 
        /// <para>
        /// The date and time (in Unix time) the data deletion job was last updated.
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedDateTime
        {
            get { return this._lastUpdatedDateTime; }
            set { this._lastUpdatedDateTime = value; }
        }

        // Check to see if LastUpdatedDateTime property is set
        internal bool IsSetLastUpdatedDateTime()
        {
            return this._lastUpdatedDateTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NumDeleted. 
        /// <para>
        /// The number of records deleted by a COMPLETED job.
        /// </para>
        /// </summary>
        public int? NumDeleted
        {
            get { return this._numDeleted; }
            set { this._numDeleted = value; }
        }

        // Check to see if NumDeleted property is set
        internal bool IsSetNumDeleted()
        {
            return this._numDeleted.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM role that has permissions to read from the
        /// Amazon S3 data source.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
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
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the data deletion job.
        /// </para>
        ///  
        /// <para>
        /// A data deletion job can have one of the following statuses:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// PENDING &gt; IN_PROGRESS &gt; COMPLETED -or- FAILED
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Max=256)]
        public string Status
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