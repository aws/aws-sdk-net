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
    /// Container for the parameters to the CreateBulkImportJob operation. Defines a job to
    /// ingest data to IoT SiteWise from Amazon S3. For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/CreateBulkImportJob.html">Create
    /// a bulk import job (CLI)</a> in the <i>Amazon Simple Storage Service User Guide</i>.
    /// <important> <para> Before you create a bulk import job that ingests data into time
    /// series outside of a workspace, you must enable IoT SiteWise warm tier or IoT SiteWise
    /// cold tier. For more information about how to configure storage settings, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/APIReference/API_PutStorageConfiguration.html">PutStorageConfiguration</a>.
    /// This requirement doesn't apply to bulk import jobs that ingest data into a session
    /// dataset in a workspace (jobs that specify a <c>workspaceName</c> and <c>datasetId</c>).
    /// Those jobs don't use IoT SiteWise warm or cold tier storage. </para> <para> Bulk import
    /// is designed to store historical data to IoT SiteWise. </para> <ul> <li> <para> Newly
    /// ingested data in the hot tier triggers notifications and computations. </para> </li>
    /// <li> <para> After data moves from the hot tier to the warm or cold tier based on retention
    /// settings, it does not trigger computations or notifications. </para> </li> <li> <para>
    /// Data older than 7 days does not trigger computations or notifications. </para> </li>
    /// </ul> </important>
    /// </summary>
    public partial class CreateBulkImportJobRequest : AmazonIoTSiteWiseRequest
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
        /// The ID of the session dataset to ingest data into. Specify this field, together with
        /// <c>workspaceName</c>, to ingest data into a session dataset in a workspace.
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
        /// Gets and sets the property WorkspaceName. 
        /// <para>
        /// The name of the workspace that contains the session dataset. Specify this field together
        /// with <c>datasetId</c>.
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
