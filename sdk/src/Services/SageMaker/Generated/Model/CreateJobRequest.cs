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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
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
namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Container for the parameters to the CreateJob operation.
    /// Creates a model customization job in Amazon SageMaker. A job runs a workload based
    /// on the job category and configuration you provide. You specify the job category, a
    /// schema-versioned configuration document, and an IAM role that grants Amazon SageMaker
    /// permission to access resources on your behalf.
    /// 
    ///  
    /// <para>
    /// Use the <c>AgentRFT</c> category to fine-tune a model using multi-turn reinforcement
    /// learning with reward signals. Use the <c>AgentRFTEvaluation</c> category to evaluate
    /// a fine-tuned or base model by running multi-turn rollouts against a held-out prompt
    /// dataset and computing metrics such as pass@k and mean reward.
    /// </para>
    ///  
    /// <para>
    /// Before creating a job, call <c>ListJobSchemaVersions</c> and <c>DescribeJobSchemaVersion</c>
    /// to retrieve the configuration schema for your job category. The <c>JobConfigDocument</c>
    /// must conform to the schema specified by <c>JobConfigSchemaVersion</c>.
    /// </para>
    ///  
    /// <para>
    /// The following operations are related to <c>CreateJob</c>:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <c>DescribeJob</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>ListJobs</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>StopJob</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>DeleteJob</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>ListJobSchemaVersions</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>DescribeJobSchemaVersion</c> 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class CreateJobRequest : AmazonSageMakerRequest
    {
        private JobCategory _jobCategory;
        private string _jobConfigDocument;
        private string _jobConfigSchemaVersion;
        private string _jobName;
        private string _roleArn;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Gets and sets the property JobCategory. 
        /// <para>
        /// The category of the job. The category determines the type of workload that the job
        /// runs.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public JobCategory JobCategory
        {
            get { return this._jobCategory; }
            set { this._jobCategory = value; }
        }

        // Check to see if JobCategory property is set
        internal bool IsSetJobCategory()
        {
            return this._jobCategory != null;
        }

        /// <summary>
        /// Gets and sets the property JobConfigDocument. 
        /// <para>
        /// The JSON configuration document for the job. The document must conform to the schema
        /// specified by <c>JobConfigSchemaVersion</c>. Use <c>DescribeJobSchemaVersion</c> to
        /// retrieve the schema for validation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=262144)]
        public string JobConfigDocument
        {
            get { return this._jobConfigDocument; }
            set { this._jobConfigDocument = value; }
        }

        // Check to see if JobConfigDocument property is set
        internal bool IsSetJobConfigDocument()
        {
            return this._jobConfigDocument != null;
        }

        /// <summary>
        /// Gets and sets the property JobConfigSchemaVersion. 
        /// <para>
        /// The version of the configuration schema to use for the job configuration document.
        /// Use <c>ListJobSchemaVersions</c> to get available schema versions for a job category.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=5, Max=16)]
        public string JobConfigSchemaVersion
        {
            get { return this._jobConfigSchemaVersion; }
            set { this._jobConfigSchemaVersion = value; }
        }

        // Check to see if JobConfigSchemaVersion property is set
        internal bool IsSetJobConfigSchemaVersion()
        {
            return this._jobConfigSchemaVersion != null;
        }

        /// <summary>
        /// Gets and sets the property JobName. 
        /// <para>
        /// The name of the job. The name must be unique within your account and Amazon Web Services
        /// Region.
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
        /// The Amazon Resource Name (ARN) of the IAM role that Amazon SageMaker assumes to perform
        /// the job. The role must have the necessary permissions to access the resources required
        /// by the job configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
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
        /// An array of key-value pairs to apply to the job as tags. For more information, see
        /// <a href="https://docs.aws.amazon.com/general/latest/gr/aws_tagging.html">Tagging Amazon
        /// Web Services Resources</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
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