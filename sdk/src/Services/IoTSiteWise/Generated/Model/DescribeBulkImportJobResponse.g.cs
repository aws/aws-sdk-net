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

namespace Amazon.IoTSiteWise.Model
{
    /// <summary>
    /// This is the response object from the DescribeBulkImportJob operation.
    /// </summary>
    public partial class DescribeBulkImportJobResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property AdaptiveIngestion. 
        /// <para>
        /// If set to true, ingest new data into IoT SiteWise storage. Measurements with notifications,
        /// metrics and transforms are computed. If set to false, historical data is ingested
        /// into IoT SiteWise as is.
        /// </para>
        /// </summary>
        public bool? AdaptiveIngestion { get; set; }

        /// <summary>
        /// Checks to see if the AdaptiveIngestion property is set.
        /// </summary>
        internal bool IsSetAdaptiveIngestion() => this.AdaptiveIngestion.HasValue;

        /// <summary>
        /// Gets and sets the property DatasetId. 
        /// <para>
        /// The ID of the dataset.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 36, Max = 36)]
        public string DatasetId { get; set; }

        /// <summary>
        /// Checks to see if the DatasetId property is set.
        /// </summary>
        internal bool IsSetDatasetId() => this.DatasetId != null;

        /// <summary>
        /// Gets and sets the property DeleteFilesAfterImport. 
        /// <para>
        /// If set to true, your data files is deleted from S3, after ingestion into IoT SiteWise
        /// storage.
        /// </para>
        /// </summary>
        public bool? DeleteFilesAfterImport { get; set; }

        /// <summary>
        /// Checks to see if the DeleteFilesAfterImport property is set.
        /// </summary>
        internal bool IsSetDeleteFilesAfterImport() => this.DeleteFilesAfterImport.HasValue;

        /// <summary>
        /// Gets and sets the property ErrorReportLocation. 
        /// <para>
        /// The Amazon S3 destination where errors associated with the job creation request are
        /// saved.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ErrorReportLocation ErrorReportLocation { get; set; }

        /// <summary>
        /// Checks to see if the ErrorReportLocation property is set.
        /// </summary>
        internal bool IsSetErrorReportLocation() => this.ErrorReportLocation != null;

        /// <summary>
        /// Gets and sets the property Files. 
        /// <para>
        /// The files in the specified Amazon S3 bucket that contain your data. You can specify
        /// up to 100 files for each bulk import job. Each file supports the following size limits:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Parquet files – Up to 256 MiB.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Other file formats – Up to 5 GiB.
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<File> Files { get; set; } = AWSConfigs.InitializeCollections ? new List<File>() : null;

        /// <summary>
        /// Checks to see if the Files property is set.
        /// </summary>
        internal bool IsSetFiles() => this.Files != null && (this.Files.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property JobConfiguration. 
        /// <para>
        /// Contains the configuration information of a job, such as the file format used to save
        /// data in Amazon S3.
        /// </para>
        /// </summary>
        public JobConfiguration JobConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the JobConfiguration property is set.
        /// </summary>
        internal bool IsSetJobConfiguration() => this.JobConfiguration != null;

        /// <summary>
        /// Gets and sets the property JobCreationDate. 
        /// <para>
        /// The date the job was created, in Unix epoch TIME.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? JobCreationDate { get; set; }

        /// <summary>
        /// Checks to see if the JobCreationDate property is set.
        /// </summary>
        internal bool IsSetJobCreationDate() => this.JobCreationDate.HasValue;

        /// <summary>
        /// Gets and sets the property JobId. 
        /// <para>
        /// The ID of the job.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 36, Max = 36)]
        public string JobId { get; set; }

        /// <summary>
        /// Checks to see if the JobId property is set.
        /// </summary>
        internal bool IsSetJobId() => this.JobId != null;

        /// <summary>
        /// Gets and sets the property JobLastUpdateDate. 
        /// <para>
        /// The date the job was last updated, in Unix epoch time.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? JobLastUpdateDate { get; set; }

        /// <summary>
        /// Checks to see if the JobLastUpdateDate property is set.
        /// </summary>
        internal bool IsSetJobLastUpdateDate() => this.JobLastUpdateDate.HasValue;

        /// <summary>
        /// Gets and sets the property JobName. 
        /// <para>
        /// The unique name that helps identify the job request.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string JobName { get; set; }

        /// <summary>
        /// Checks to see if the JobName property is set.
        /// </summary>
        internal bool IsSetJobName() => this.JobName != null;

        /// <summary>
        /// Gets and sets the property JobRoleArn. 
        /// <para>
        /// The <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">ARN</a>
        /// of the IAM role that allows IoT SiteWise to read Amazon S3 data.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1600)]
        public string JobRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the JobRoleArn property is set.
        /// </summary>
        internal bool IsSetJobRoleArn() => this.JobRoleArn != null;

        /// <summary>
        /// Gets and sets the property JobStatus. 
        /// <para>
        /// The status of the bulk import job can be one of following values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>PENDING</c> – IoT SiteWise is waiting for the current bulk import job to finish.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CANCELLED</c> – The bulk import job has been canceled.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>RUNNING</c> – IoT SiteWise is processing your request to import your data from
        /// Amazon S3.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>COMPLETED</c> – IoT SiteWise successfully completed your request to import data
        /// from Amazon S3.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FAILED</c> – IoT SiteWise couldn't process your request to import data from Amazon
        /// S3. You can use logs saved in the specified error report location in Amazon S3 to
        /// troubleshoot issues.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>COMPLETED_WITH_FAILURES</c> – IoT SiteWise completed your request to import data
        /// from Amazon S3 with errors. You can use logs saved in the specified error report location
        /// in Amazon S3 to troubleshoot issues.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true)]
        public JobStatus JobStatus { get; set; }

        /// <summary>
        /// Checks to see if the JobStatus property is set.
        /// </summary>
        internal bool IsSetJobStatus() => this.JobStatus != null;

        /// <summary>
        /// Gets and sets the property WorkspaceName. 
        /// <para>
        /// The name of the workspace.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string WorkspaceName { get; set; }

        /// <summary>
        /// Checks to see if the WorkspaceName property is set.
        /// </summary>
        internal bool IsSetWorkspaceName() => this.WorkspaceName != null;
    }
}
