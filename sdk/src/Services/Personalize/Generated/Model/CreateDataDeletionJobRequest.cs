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
    /// Container for the parameters to the CreateDataDeletionJob operation.
    /// Creates a batch job that deletes all references to specific users from an Amazon Personalize
    /// dataset group in batches. You specify the users to delete in a CSV file of userIds
    /// in an Amazon S3 bucket. After a job completes, Amazon Personalize no longer trains
    /// on the users’ data and no longer considers the users when generating user segments.
    /// For more information about creating a data deletion job, see <a href="https://docs.aws.amazon.com/personalize/latest/dg/delete-records.html">Deleting
    /// users</a>.
    /// 
    ///  <ul> <li> 
    /// <para>
    /// Your input file must be a CSV file with a single USER_ID column that lists the users
    /// IDs. For more information about preparing the CSV file, see <a href="https://docs.aws.amazon.com/personalize/latest/dg/prepare-deletion-input-file.html">Preparing
    /// your data deletion file and uploading it to Amazon S3</a>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// To give Amazon Personalize permission to access your input CSV file of userIds, you
    /// must specify an IAM service role that has permission to read from the data source.
    /// This role needs <c>GetObject</c> and <c>ListBucket</c> permissions for the bucket
    /// and its content. These permissions are the same as importing data. For information
    /// on granting access to your Amazon S3 bucket, see <a href="https://docs.aws.amazon.com/personalize/latest/dg/granting-personalize-s3-access.html">Giving
    /// Amazon Personalize Access to Amazon S3 Resources</a>. 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  After you create a job, it can take up to a day to delete all references to the users
    /// from datasets and models. Until the job completes, Amazon Personalize continues to
    /// use the data when training. And if you use a User Segmentation recipe, the users might
    /// appear in user segments. 
    /// </para>
    ///  
    /// <para>
    ///  <b>Status</b> 
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
    /// <para>
    /// To get the status of the data deletion job, call <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_DescribeDataDeletionJob.html">DescribeDataDeletionJob</a>
    /// API operation and specify the Amazon Resource Name (ARN) of the job. If the status
    /// is FAILED, the response includes a <c>failureReason</c> key, which describes why the
    /// job failed.
    /// </para>
    ///  
    /// <para>
    ///  <b>Related APIs</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_ListDataDeletionJobs.html">ListDataDeletionJobs</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_DescribeDataDeletionJob.html">DescribeDataDeletionJob</a>
    /// 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class CreateDataDeletionJobRequest : AmazonPersonalizeRequest
    {
        private string _datasetGroupArn;
        private DataSource _dataSource;
        private string _jobName;
        private string _roleArn;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Gets and sets the property DatasetGroupArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the dataset group that has the datasets you want
        /// to delete records from.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=256)]
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
        /// <para>
        /// The Amazon S3 bucket that contains the list of userIds of the users to delete.
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
        /// Gets and sets the property JobName. 
        /// <para>
        /// The name for the data deletion job.
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
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM role that has permissions to read from the
        /// Amazon S3 data source.
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
        /// to apply to the data deletion job.
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