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
    /// Container for the parameters to the CreateDatasetExportJob operation.
    /// Creates a job that exports data from your dataset to an Amazon S3 bucket. To allow
    /// Amazon Personalize to export the training data, you must specify an service-linked
    /// IAM role that gives Amazon Personalize <c>PutObject</c> permissions for your Amazon
    /// S3 bucket. For information, see <a href="https://docs.aws.amazon.com/personalize/latest/dg/export-data.html">Exporting
    /// a dataset</a> in the Amazon Personalize developer guide. 
    /// 
    ///  
    /// <para>
    ///  <b>Status</b> 
    /// </para>
    ///  
    /// <para>
    /// A dataset export job can be in one of the following states:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// CREATE PENDING &gt; CREATE IN_PROGRESS &gt; ACTIVE -or- CREATE FAILED
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  To get the status of the export job, call <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_DescribeDatasetExportJob.html">DescribeDatasetExportJob</a>,
    /// and specify the Amazon Resource Name (ARN) of the dataset export job. The dataset
    /// export is complete when the status shows as ACTIVE. If the status shows as CREATE
    /// FAILED, the response includes a <c>failureReason</c> key, which describes why the
    /// job failed. 
    /// </para>
    /// </summary>
    public partial class CreateDatasetExportJobRequest : AmazonPersonalizeRequest
    {
        private string _datasetArn;
        private IngestionMode _ingestionMode;
        private string _jobName;
        private DatasetExportJobOutput _jobOutput;
        private string _roleArn;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Gets and sets the property DatasetArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the dataset that contains the data to export.
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
        /// Gets and sets the property IngestionMode. 
        /// <para>
        /// The data to export, based on how you imported the data. You can choose to export only
        /// <c>BULK</c> data that you imported using a dataset import job, only <c>PUT</c> data
        /// that you imported incrementally (using the console, PutEvents, PutUsers and PutItems
        /// operations), or <c>ALL</c> for both types. The default value is <c>PUT</c>. 
        /// </para>
        /// </summary>
        public IngestionMode IngestionMode
        {
            get { return this._ingestionMode; }
            set { this._ingestionMode = value; }
        }

        // Check to see if IngestionMode property is set
        internal bool IsSetIngestionMode()
        {
            return this._ingestionMode != null;
        }

        /// <summary>
        /// Gets and sets the property JobName. 
        /// <para>
        /// The name for the dataset export job.
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
        /// Gets and sets the property JobOutput. 
        /// <para>
        /// The path to the Amazon S3 bucket where the job's output is stored.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DatasetExportJobOutput JobOutput
        {
            get { return this._jobOutput; }
            set { this._jobOutput = value; }
        }

        // Check to see if JobOutput property is set
        internal bool IsSetJobOutput()
        {
            return this._jobOutput != null;
        }

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM service role that has permissions to add
        /// data to your output Amazon S3 bucket.
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
        /// to apply to the dataset export job.
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