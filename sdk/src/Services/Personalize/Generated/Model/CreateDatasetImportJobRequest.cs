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

namespace Amazon.Personalize.Model
{
    /// <summary>
    /// Container for the parameters to the CreateDatasetImportJob operation.
    /// Creates a job that imports training data from your data source (an Amazon S3 bucket)
    /// to an Amazon Personalize dataset. To allow Amazon Personalize to import the training
    /// data, you must specify an AWS Identity and Access Management (IAM) role that has permission
    /// to read from the data source, as Amazon Personalize makes a copy of your data and
    /// processes it in an internal AWS system.
    /// 
    ///  <important> 
    /// <para>
    /// The dataset import job replaces any existing data in the dataset that you imported
    /// in bulk.
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
    /// To get the status of the import job, call <a>DescribeDatasetImportJob</a>, providing
    /// the Amazon Resource Name (ARN) of the dataset import job. The dataset import is complete
    /// when the status shows as ACTIVE. If the status shows as CREATE FAILED, the response
    /// includes a <code>failureReason</code> key, which describes why the job failed.
    /// </para>
    ///  <note> 
    /// <para>
    /// Importing takes time. You must wait until the status shows as ACTIVE before training
    /// a model using the dataset.
    /// </para>
    ///  </note> <p class="title"> <b>Related APIs</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>ListDatasetImportJobs</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DescribeDatasetImportJob</a> 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class CreateDatasetImportJobRequest : AmazonPersonalizeRequest
    {
        private string _datasetArn;
        private DataSource _dataSource;
        private string _jobName;
        private string _roleArn;

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

    }
}