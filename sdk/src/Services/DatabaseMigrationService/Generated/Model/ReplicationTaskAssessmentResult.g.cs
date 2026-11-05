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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        public string AssessmentResults { get; set; }

        /// <summary>
        /// Checks to see if the AssessmentResults property is set.
        /// </summary>
        internal bool IsSetAssessmentResults() => this.AssessmentResults != null;

        /// <summary>
        /// Gets and sets the property AssessmentResultsFile. 
        /// <para>
        ///  The file containing the results of the task assessment. 
        /// </para>
        /// </summary>
        public string AssessmentResultsFile { get; set; }

        /// <summary>
        /// Checks to see if the AssessmentResultsFile property is set.
        /// </summary>
        internal bool IsSetAssessmentResultsFile() => this.AssessmentResultsFile != null;

        /// <summary>
        /// Gets and sets the property AssessmentStatus. 
        /// <para>
        ///  The status of the task assessment. 
        /// </para>
        /// </summary>
        public string AssessmentStatus { get; set; }

        /// <summary>
        /// Checks to see if the AssessmentStatus property is set.
        /// </summary>
        internal bool IsSetAssessmentStatus() => this.AssessmentStatus != null;

        /// <summary>
        /// Gets and sets the property ReplicationTaskArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the replication task. 
        /// </para>
        /// </summary>
        public string ReplicationTaskArn { get; set; }

        /// <summary>
        /// Checks to see if the ReplicationTaskArn property is set.
        /// </summary>
        internal bool IsSetReplicationTaskArn() => this.ReplicationTaskArn != null;

        /// <summary>
        /// Gets and sets the property ReplicationTaskIdentifier. 
        /// <para>
        ///  The replication task identifier of the task on which the task assessment was run.
        /// 
        /// </para>
        /// </summary>
        public string ReplicationTaskIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the ReplicationTaskIdentifier property is set.
        /// </summary>
        internal bool IsSetReplicationTaskIdentifier() => this.ReplicationTaskIdentifier != null;

        /// <summary>
        /// Gets and sets the property ReplicationTaskLastAssessmentDate. 
        /// <para>
        /// The date the task assessment was completed. 
        /// </para>
        /// </summary>
        public DateTime? ReplicationTaskLastAssessmentDate { get; set; }

        /// <summary>
        /// Checks to see if the ReplicationTaskLastAssessmentDate property is set.
        /// </summary>
        internal bool IsSetReplicationTaskLastAssessmentDate() => this.ReplicationTaskLastAssessmentDate.HasValue;

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
        [AWSProperty(Sensitive = true)]
        public string S3ObjectUrl { get; set; }

        /// <summary>
        /// Checks to see if the S3ObjectUrl property is set.
        /// </summary>
        internal bool IsSetS3ObjectUrl() => this.S3ObjectUrl != null;
    }
}
