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

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Container for the parameters to the CreateLabelingJob operation.
    /// Creates a job that uses workers to label the data objects in your input dataset. You
    /// can use the labeled data to train machine learning models.
    /// 
    ///  
    /// <para>
    /// You can select your workforce from one of three providers:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// A private workforce that you create. It can include employees, contractors, and outside
    /// experts. Use a private workforce when want the data to stay within your organization
    /// or when a specific set of skills is required.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// One or more vendors that you select from the AWS Marketplace. Vendors provide expertise
    /// in specific areas. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The Amazon Mechanical Turk workforce. This is the largest workforce, but it should
    /// only be used for public data or data that has been stripped of any personally identifiable
    /// information.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// You can also use <i>automated data labeling</i> to reduce the number of data objects
    /// that need to be labeled by a human. Automated data labeling uses <i>active learning</i>
    /// to determine if a data object can be labeled by machine or if it needs to be sent
    /// to a human worker. For more information, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/sms-automated-labeling.html">Using
    /// Automated Data Labeling</a>.
    /// </para>
    ///  
    /// <para>
    /// The data objects to be labeled are contained in an Amazon S3 bucket. You create a
    /// <i>manifest file</i> that describes the location of each object. For more information,
    /// see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/sms-data.html">Using
    /// Input and Output Data</a>.
    /// </para>
    ///  
    /// <para>
    /// The output can be used as the manifest file for another labeling job or as training
    /// data for your machine learning models.
    /// </para>
    /// </summary>
    public partial class CreateLabelingJobRequest : AmazonSageMakerRequest
    {
        private HumanTaskConfig _humanTaskConfig;
        private LabelingJobInputConfig _inputConfig;
        private string _labelAttributeName;
        private string _labelCategoryConfigS3Uri;
        private LabelingJobAlgorithmsConfig _labelingJobAlgorithmsConfig;
        private string _labelingJobName;
        private LabelingJobOutputConfig _outputConfig;
        private string _roleArn;
        private LabelingJobStoppingConditions _stoppingConditions;
        private List<Tag> _tags = new List<Tag>();

        /// <summary>
        /// Gets and sets the property HumanTaskConfig. 
        /// <para>
        /// Configures the labeling task and how it is presented to workers; including, but not
        /// limited to price, keywords, and batch size (task count).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public HumanTaskConfig HumanTaskConfig
        {
            get { return this._humanTaskConfig; }
            set { this._humanTaskConfig = value; }
        }

        // Check to see if HumanTaskConfig property is set
        internal bool IsSetHumanTaskConfig()
        {
            return this._humanTaskConfig != null;
        }

        /// <summary>
        /// Gets and sets the property InputConfig. 
        /// <para>
        /// Input data for the labeling job, such as the Amazon S3 location of the data objects
        /// and the location of the manifest file that describes the data objects.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public LabelingJobInputConfig InputConfig
        {
            get { return this._inputConfig; }
            set { this._inputConfig = value; }
        }

        // Check to see if InputConfig property is set
        internal bool IsSetInputConfig()
        {
            return this._inputConfig != null;
        }

        /// <summary>
        /// Gets and sets the property LabelAttributeName. 
        /// <para>
        /// The attribute name to use for the label in the output manifest file. This is the key
        /// for the key/value pair formed with the label that a worker assigns to the object.
        /// The name can't end with "-metadata". If you are running a semantic segmentation labeling
        /// job, the attribute name must end with "-ref". If you are running any other kind of
        /// labeling job, the attribute name must not end with "-ref".
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=127)]
        public string LabelAttributeName
        {
            get { return this._labelAttributeName; }
            set { this._labelAttributeName = value; }
        }

        // Check to see if LabelAttributeName property is set
        internal bool IsSetLabelAttributeName()
        {
            return this._labelAttributeName != null;
        }

        /// <summary>
        /// Gets and sets the property LabelCategoryConfigS3Uri. 
        /// <para>
        /// The S3 URI of the file that defines the categories used to label the data objects.
        /// </para>
        ///  
        /// <para>
        /// For 3D point cloud task types, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/sms-point-cloud-label-category-config.html">Create
        /// a Labeling Category Configuration File for 3D Point Cloud Labeling Jobs</a>. 
        /// </para>
        ///  
        /// <para>
        /// For all other <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/sms-task-types.html">built-in
        /// task types</a> and <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/sms-custom-templates.html">custom
        /// tasks</a>, your label category configuration file must be a JSON file in the following
        /// format. Identify the labels you want to use by replacing <code>label_1</code>, <code>label_2</code>,<code>...</code>,<code>label_n</code>
        /// with your label categories.
        /// </para>
        ///  
        /// <para>
        ///  <code>{</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code> "document-version": "2018-11-28"</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code> "labels": [</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code> {</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code> "label": "<i>label_1</i>"</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code> },</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code> {</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code> "label": "<i>label_2</i>"</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code> },</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code> ...</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code> {</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code> "label": "<i>label_n</i>"</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code> }</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code> ]</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code>}</code> 
        /// </para>
        /// </summary>
        [AWSProperty(Max=1024)]
        public string LabelCategoryConfigS3Uri
        {
            get { return this._labelCategoryConfigS3Uri; }
            set { this._labelCategoryConfigS3Uri = value; }
        }

        // Check to see if LabelCategoryConfigS3Uri property is set
        internal bool IsSetLabelCategoryConfigS3Uri()
        {
            return this._labelCategoryConfigS3Uri != null;
        }

        /// <summary>
        /// Gets and sets the property LabelingJobAlgorithmsConfig. 
        /// <para>
        /// Configures the information required to perform automated data labeling.
        /// </para>
        /// </summary>
        public LabelingJobAlgorithmsConfig LabelingJobAlgorithmsConfig
        {
            get { return this._labelingJobAlgorithmsConfig; }
            set { this._labelingJobAlgorithmsConfig = value; }
        }

        // Check to see if LabelingJobAlgorithmsConfig property is set
        internal bool IsSetLabelingJobAlgorithmsConfig()
        {
            return this._labelingJobAlgorithmsConfig != null;
        }

        /// <summary>
        /// Gets and sets the property LabelingJobName. 
        /// <para>
        /// The name of the labeling job. This name is used to identify the job in a list of labeling
        /// jobs.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=63)]
        public string LabelingJobName
        {
            get { return this._labelingJobName; }
            set { this._labelingJobName = value; }
        }

        // Check to see if LabelingJobName property is set
        internal bool IsSetLabelingJobName()
        {
            return this._labelingJobName != null;
        }

        /// <summary>
        /// Gets and sets the property OutputConfig. 
        /// <para>
        /// The location of the output data and the AWS Key Management Service key ID for the
        /// key used to encrypt the output data, if any.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public LabelingJobOutputConfig OutputConfig
        {
            get { return this._outputConfig; }
            set { this._outputConfig = value; }
        }

        // Check to see if OutputConfig property is set
        internal bool IsSetOutputConfig()
        {
            return this._outputConfig != null;
        }

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon Resource Number (ARN) that Amazon SageMaker assumes to perform tasks on
        /// your behalf during data labeling. You must grant this role the necessary permissions
        /// so that Amazon SageMaker can successfully complete data labeling.
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
        /// Gets and sets the property StoppingConditions. 
        /// <para>
        /// A set of conditions for stopping the labeling job. If any of the conditions are met,
        /// the job is automatically stopped. You can use these conditions to control the cost
        /// of data labeling.
        /// </para>
        /// </summary>
        public LabelingJobStoppingConditions StoppingConditions
        {
            get { return this._stoppingConditions; }
            set { this._stoppingConditions = value; }
        }

        // Check to see if StoppingConditions property is set
        internal bool IsSetStoppingConditions()
        {
            return this._stoppingConditions != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// An array of key/value pairs. For more information, see <a href="https://docs.aws.amazon.com/awsaccountbilling/latest/aboutv2/cost-alloc-tags.html#allocation-what">Using
        /// Cost Allocation Tags</a> in the <i>AWS Billing and Cost Management User Guide</i>.
        /// </para>
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
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}