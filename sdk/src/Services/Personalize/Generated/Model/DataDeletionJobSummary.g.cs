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
    /// Provides a summary of the properties of a data deletion job. For a complete listing,
    /// call the <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_DescribeDataDeletionJob.html">DescribeDataDeletionJob</a>
    /// API operation.
    /// </summary>
    public partial class DataDeletionJobSummary
    {
        /// <summary>
        /// Gets and sets the property CreationDateTime. 
        /// <para>
        /// The creation date and time (in Unix time) of the data deletion job.
        /// </para>
        /// </summary>
        public DateTime? CreationDateTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationDateTime property is set.
        /// </summary>
        internal bool IsSetCreationDateTime() => this.CreationDateTime.HasValue;

        /// <summary>
        /// Gets and sets the property DataDeletionJobArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the data deletion job.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string DataDeletionJobArn { get; set; }

        /// <summary>
        /// Checks to see if the DataDeletionJobArn property is set.
        /// </summary>
        internal bool IsSetDataDeletionJobArn() => this.DataDeletionJobArn != null;

        /// <summary>
        /// Gets and sets the property DatasetGroupArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the dataset group the job deleted records from.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string DatasetGroupArn { get; set; }

        /// <summary>
        /// Checks to see if the DatasetGroupArn property is set.
        /// </summary>
        internal bool IsSetDatasetGroupArn() => this.DatasetGroupArn != null;

        /// <summary>
        /// Gets and sets the property FailureReason. 
        /// <para>
        /// If a data deletion job fails, provides the reason why.
        /// </para>
        /// </summary>
        public string FailureReason { get; set; }

        /// <summary>
        /// Checks to see if the FailureReason property is set.
        /// </summary>
        internal bool IsSetFailureReason() => this.FailureReason != null;

        /// <summary>
        /// Gets and sets the property JobName. 
        /// <para>
        /// The name of the data deletion job.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 63)]
        public string JobName { get; set; }

        /// <summary>
        /// Checks to see if the JobName property is set.
        /// </summary>
        internal bool IsSetJobName() => this.JobName != null;

        /// <summary>
        /// Gets and sets the property LastUpdatedDateTime. 
        /// <para>
        /// The date and time (in Unix time) the data deletion job was last updated.
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedDateTime { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdatedDateTime property is set.
        /// </summary>
        internal bool IsSetLastUpdatedDateTime() => this.LastUpdatedDateTime.HasValue;

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
        /// PENDING > IN_PROGRESS > COMPLETED -or- FAILED
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
