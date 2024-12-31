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
 * Do not modify this file. This file is generated from the dms-2016-01-01.normal.json service model.
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
namespace Amazon.DatabaseMigrationService.Model
{
    /// <summary>
    /// The task assessment report in JSON format.
    /// </summary>
    public partial class ReplicationTaskAssessmentResult
    {
        private string _assessmentResults;
        private string _assessmentResultsFile;
        private string _assessmentStatus;
        private string _replicationTaskArn;
        private string _replicationTaskIdentifier;
        private DateTime? _replicationTaskLastAssessmentDate;
        private string _s3ObjectUrl;

        /// <summary>
        /// Gets and sets the property AssessmentResults. 
        /// <para>
        ///  The task assessment results in JSON format. 
        /// </para>
        ///  
        /// <para>
        /// The response object only contains this field if you provide <a>DescribeReplicationTaskAssessmentResultsMessage$ReplicationTaskArn</a>
        /// in the request.
        /// </para>
        /// </summary>
        public string AssessmentResults
        {
            get { return this._assessmentResults; }
            set { this._assessmentResults = value; }
        }

        // Check to see if AssessmentResults property is set
        internal bool IsSetAssessmentResults()
        {
            return this._assessmentResults != null;
        }

        /// <summary>
        /// Gets and sets the property AssessmentResultsFile. 
        /// <para>
        ///  The file containing the results of the task assessment. 
        /// </para>
        /// </summary>
        public string AssessmentResultsFile
        {
            get { return this._assessmentResultsFile; }
            set { this._assessmentResultsFile = value; }
        }

        // Check to see if AssessmentResultsFile property is set
        internal bool IsSetAssessmentResultsFile()
        {
            return this._assessmentResultsFile != null;
        }

        /// <summary>
        /// Gets and sets the property AssessmentStatus. 
        /// <para>
        ///  The status of the task assessment. 
        /// </para>
        /// </summary>
        public string AssessmentStatus
        {
            get { return this._assessmentStatus; }
            set { this._assessmentStatus = value; }
        }

        // Check to see if AssessmentStatus property is set
        internal bool IsSetAssessmentStatus()
        {
            return this._assessmentStatus != null;
        }

        /// <summary>
        /// Gets and sets the property ReplicationTaskArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the replication task. 
        /// </para>
        /// </summary>
        public string ReplicationTaskArn
        {
            get { return this._replicationTaskArn; }
            set { this._replicationTaskArn = value; }
        }

        // Check to see if ReplicationTaskArn property is set
        internal bool IsSetReplicationTaskArn()
        {
            return this._replicationTaskArn != null;
        }

        /// <summary>
        /// Gets and sets the property ReplicationTaskIdentifier. 
        /// <para>
        ///  The replication task identifier of the task on which the task assessment was run.
        /// 
        /// </para>
        /// </summary>
        public string ReplicationTaskIdentifier
        {
            get { return this._replicationTaskIdentifier; }
            set { this._replicationTaskIdentifier = value; }
        }

        // Check to see if ReplicationTaskIdentifier property is set
        internal bool IsSetReplicationTaskIdentifier()
        {
            return this._replicationTaskIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property ReplicationTaskLastAssessmentDate. 
        /// <para>
        /// The date the task assessment was completed. 
        /// </para>
        /// </summary>
        public DateTime? ReplicationTaskLastAssessmentDate
        {
            get { return this._replicationTaskLastAssessmentDate; }
            set { this._replicationTaskLastAssessmentDate = value; }
        }

        // Check to see if ReplicationTaskLastAssessmentDate property is set
        internal bool IsSetReplicationTaskLastAssessmentDate()
        {
            return this._replicationTaskLastAssessmentDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property S3ObjectUrl. 
        /// <para>
        ///  The URL of the S3 object containing the task assessment results. 
        /// </para>
        ///  
        /// <para>
        /// The response object only contains this field if you provide <a>DescribeReplicationTaskAssessmentResultsMessage$ReplicationTaskArn</a>
        /// in the request.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string S3ObjectUrl
        {
            get { return this._s3ObjectUrl; }
            set { this._s3ObjectUrl = value; }
        }

        // Check to see if S3ObjectUrl property is set
        internal bool IsSetS3ObjectUrl()
        {
            return this._s3ObjectUrl != null;
        }

    }
}