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

namespace Amazon.Personalize.Model
{
    /// <summary>
    /// Describes a job that exports a dataset to an Amazon S3 bucket. For more information,
    /// see <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_CreateDatasetExportJob.html">CreateDatasetExportJob</a>.
    /// 
    ///  
    /// <para>
    /// A dataset export job can be in one of the following states:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// CREATE PENDING > CREATE IN_PROGRESS > ACTIVE -or- CREATE FAILED
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class DatasetExportJob
    {
        /// <summary>
        /// Gets and sets the property CreationDateTime. 
        /// <para>
        /// The creation date and time (in Unix time) of the dataset export job.
        /// </para>
        /// </summary>
        public DateTime? CreationDateTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationDateTime property is set.
        /// </summary>
        internal bool IsSetCreationDateTime() => this.CreationDateTime.HasValue;

        /// <summary>
        /// Gets and sets the property DatasetArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the dataset to export.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string DatasetArn { get; set; }

        /// <summary>
        /// Checks to see if the DatasetArn property is set.
        /// </summary>
        internal bool IsSetDatasetArn() => this.DatasetArn != null;

        /// <summary>
        /// Gets and sets the property DatasetExportJobArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the dataset export job.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string DatasetExportJobArn { get; set; }

        /// <summary>
        /// Checks to see if the DatasetExportJobArn property is set.
        /// </summary>
        internal bool IsSetDatasetExportJobArn() => this.DatasetExportJobArn != null;

        /// <summary>
        /// Gets and sets the property FailureReason. 
        /// <para>
        /// If a dataset export job fails, provides the reason why.
        /// </para>
        /// </summary>
        public string FailureReason { get; set; }

        /// <summary>
        /// Checks to see if the FailureReason property is set.
        /// </summary>
        internal bool IsSetFailureReason() => this.FailureReason != null;

        /// <summary>
        /// Gets and sets the property IngestionMode. 
        /// <para>
        /// The data to export, based on how you imported the data. You can choose to export <c>BULK</c>
        /// data that you imported using a dataset import job, <c>PUT</c> data that you imported
        /// incrementally (using the console, PutEvents, PutUsers and PutItems operations), or
        /// <c>ALL</c> for both types. The default value is <c>PUT</c>. 
        /// </para>
        /// </summary>
        public IngestionMode IngestionMode { get; set; }

        /// <summary>
        /// Checks to see if the IngestionMode property is set.
        /// </summary>
        internal bool IsSetIngestionMode() => this.IngestionMode != null;

        /// <summary>
        /// Gets and sets the property JobName. 
        /// <para>
        /// The name of the export job.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 63)]
        public string JobName { get; set; }

        /// <summary>
        /// Checks to see if the JobName property is set.
        /// </summary>
        internal bool IsSetJobName() => this.JobName != null;

        /// <summary>
        /// Gets and sets the property JobOutput. 
        /// <para>
        /// The path to the Amazon S3 bucket where the job's output is stored. For example:
        /// </para>
        ///  
        /// <para>
        ///  <c>s3://bucket-name/folder-name/</c> 
        /// </para>
        /// </summary>
        public DatasetExportJobOutput JobOutput { get; set; }

        /// <summary>
        /// Checks to see if the JobOutput property is set.
        /// </summary>
        internal bool IsSetJobOutput() => this.JobOutput != null;

        /// <summary>
        /// Gets and sets the property LastUpdatedDateTime. 
        /// <para>
        /// The date and time (in Unix time) the status of the dataset export job was last updated.
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedDateTime { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdatedDateTime property is set.
        /// </summary>
        internal bool IsSetLastUpdatedDateTime() => this.LastUpdatedDateTime.HasValue;

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM service role that has permissions to add
        /// data to your output Amazon S3 bucket.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string RoleArn { get; set; }

        /// <summary>
        /// Checks to see if the RoleArn property is set.
        /// </summary>
        internal bool IsSetRoleArn() => this.RoleArn != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the dataset export job.
        /// </para>
        ///  
        /// <para>
        /// A dataset export job can be in one of the following states:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// CREATE PENDING > CREATE IN_PROGRESS > ACTIVE -or- CREATE FAILED
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
