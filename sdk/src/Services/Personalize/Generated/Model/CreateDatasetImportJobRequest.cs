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
    /// Container for the parameters to the CreateDatasetImportJob operation.
    /// Creates a job that imports training data from your data source (an Amazon S3 bucket)
    /// to an Amazon Personalize dataset. To allow Amazon Personalize to import the training
    /// data, you must specify an IAM service role that has permission to read from the data
    /// source, as Amazon Personalize makes a copy of your data and processes it internally.
    /// For information on granting access to your Amazon S3 bucket, see <a href="https://docs.aws.amazon.com/personalize/latest/dg/granting-personalize-s3-access.html">Giving
    /// Amazon Personalize Access to Amazon S3 Resources</a>. 
    /// 
    ///  
    /// <para>
    /// If you already created a recommender or deployed a custom solution version with a
    /// campaign, how new bulk records influence recommendations depends on the domain use
    /// case or recipe that you use. For more information, see <a href="https://docs.aws.amazon.com/personalize/latest/dg/how-new-data-influences-recommendations.html">How
    /// new data influences real-time recommendations</a>.
    /// </para>
    ///  <important> 
    /// <para>
    /// By default, a dataset import job replaces any existing data in the dataset that you
    /// imported in bulk. To add new records without replacing existing data, specify INCREMENTAL
    /// for the import mode in the CreateDatasetImportJob operation.
    /// </para>
    ///  </important> 
    /// <para>
    ///  <b>Status</b> 
    /// </para>
    ///  
    /// <para>
    /// A dataset import job can be in one of the following states:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// CREATE PENDING &gt; CREATE IN_PROGRESS &gt; ACTIVE -or- CREATE FAILED
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// To get the status of the import job, call <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_DescribeDatasetImportJob.html">DescribeDatasetImportJob</a>,
    /// providing the Amazon Resource Name (ARN) of the dataset import job. The dataset import
    /// is complete when the status shows as ACTIVE. If the status shows as CREATE FAILED,
    /// the response includes a <c>failureReason</c> key, which describes why the job failed.
    /// </para>
    ///  <note> 
    /// <para>
    /// Importing takes time. You must wait until the status shows as ACTIVE before training
    /// a model using the dataset.
    /// </para>
    ///  </note> 
    /// <para>
    ///  <b>Related APIs</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_ListDatasetImportJobs.html">ListDatasetImportJobs</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_DescribeDatasetImportJob.html">DescribeDatasetImportJob</a>
    /// 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class CreateDatasetImportJobRequest : AmazonPersonalizeRequest
    {
        private string _datasetArn;
        private DataSource _dataSource;
        private ImportMode _importMode;
        private string _jobName;
        private bool? _publishAttributionMetricsToS3;
        private string _roleArn;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Gets and sets the property DatasetArn. 
        /// <para>
        /// The ARN of the dataset that receives the imported data.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=256)]
        public string DatasetArn
        {
            get { return this._datasetArn; }
            set { this._datasetArn = value; }
        }

        // Check to see if DatasetArn property is set
        internal bool IsSetDatasetArn()
        {
            return this._datasetArn != null;
        }

        /// <summary>
        /// Gets and sets the property DataSource. 
        /// <para>
        /// The Amazon S3 bucket that contains the training data to import.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property ImportMode. 
        /// <para>
        /// Specify how to add the new records to an existing dataset. The default import mode
        /// is <c>FULL</c>. If you haven't imported bulk records into the dataset previously,
        /// you can only specify <c>FULL</c>.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Specify <c>FULL</c> to overwrite all existing bulk data in your dataset. Data you
        /// imported individually is not replaced.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Specify <c>INCREMENTAL</c> to append the new records to the existing data in your
        /// dataset. Amazon Personalize replaces any record with the same ID with the new one.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ImportMode ImportMode
        {
            get { return this._importMode; }
            set { this._importMode = value; }
        }

        // Check to see if ImportMode property is set
        internal bool IsSetImportMode()
        {
            return this._importMode != null;
        }

        /// <summary>
        /// Gets and sets the property JobName. 
        /// <para>
        /// The name for the dataset import job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=63)]
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
        /// Gets and sets the property PublishAttributionMetricsToS3. 
        /// <para>
        /// If you created a metric attribution, specify whether to publish metrics for this import
        /// job to Amazon S3
        /// </para>
        /// </summary>
        public bool? PublishAttributionMetricsToS3
        {
            get { return this._publishAttributionMetricsToS3; }
            set { this._publishAttributionMetricsToS3 = value; }
        }

        // Check to see if PublishAttributionMetricsToS3 property is set
        internal bool IsSetPublishAttributionMetricsToS3()
        {
            return this._publishAttributionMetricsToS3.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The ARN of the IAM role that has permissions to read from the Amazon S3 data source.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=256)]
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of <a href="https://docs.aws.amazon.com/personalize/latest/dg/tagging-resources.html">tags</a>
        /// to apply to the dataset import job.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=200)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}