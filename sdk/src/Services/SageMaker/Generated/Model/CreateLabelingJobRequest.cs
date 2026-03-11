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
    /// One or more vendors that you select from the Amazon Web Services Marketplace. Vendors
    /// provide expertise in specific areas. 
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
    ///  
    /// <para>
    /// You can use this operation to create a static labeling job or a streaming labeling
    /// job. A static labeling job stops if all data objects in the input manifest file identified
    /// in <c>ManifestS3Uri</c> have been labeled. A streaming labeling job runs perpetually
    /// until it is manually stopped, or remains idle for 10 days. You can send new data objects
    /// to an active (<c>InProgress</c>) streaming labeling job in real time. To learn how
    /// to create a static labeling job, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/sms-create-labeling-job-api.html">Create
    /// a Labeling Job (API) </a> in the Amazon SageMaker Developer Guide. To learn how to
    /// create a streaming labeling job, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/sms-streaming-create-job.html">Create
    /// a Streaming Labeling Job</a>.
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
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

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
        ///  
        /// <para>
        /// You must specify at least one of the following: <c>S3DataSource</c> or <c>SnsDataSource</c>.
        /// 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Use <c>SnsDataSource</c> to specify an SNS input topic for a streaming labeling job.
        /// If you do not specify and SNS input topic ARN, Ground Truth will create a one-time
        /// labeling job that stops after all data objects in the input manifest file have been
        /// labeled.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <c>S3DataSource</c> to specify an input manifest file for both streaming and one-time
        /// labeling jobs. Adding an <c>S3DataSource</c> is optional if you use <c>SnsDataSource</c>
        /// to create a streaming labeling job.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If you use the Amazon Mechanical Turk workforce, your input data should not include
        /// confidential information, personal information or protected health information. Use
        /// <c>ContentClassifiers</c> to specify that your data is free of personally identifiable
        /// information and adult content.
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
        /// The <c>LabelAttributeName</c> must meet the following requirements.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The name can't end with "-metadata". 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you are using one of the <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/sms-task-types.html">built-in
        /// task types</a> or one of the following, the attribute name <i>must</i> end with "-ref".
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Image semantic segmentation (<c>SemanticSegmentation)</c> and adjustment (<c>AdjustmentSemanticSegmentation</c>)
        /// labeling jobs for this task type. One exception is that verification (<c>VerificationSemanticSegmentation</c>)
        /// <i>must not</i> end with -"ref".
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Video frame object detection (<c>VideoObjectDetection</c>), and adjustment and verification
        /// (<c>AdjustmentVideoObjectDetection</c>) labeling jobs for this task type.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Video frame object tracking (<c>VideoObjectTracking</c>), and adjustment and verification
        /// (<c>AdjustmentVideoObjectTracking</c>) labeling jobs for this task type.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// 3D point cloud semantic segmentation (<c>3DPointCloudSemanticSegmentation</c>), and
        /// adjustment and verification (<c>Adjustment3DPointCloudSemanticSegmentation</c>) labeling
        /// jobs for this task type. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// 3D point cloud object tracking (<c>3DPointCloudObjectTracking</c>), and adjustment
        /// and verification (<c>Adjustment3DPointCloudObjectTracking</c>) labeling jobs for this
        /// task type. 
        /// </para>
        ///  </li> </ul> </li> </ul>  <important> 
        /// <para>
        /// If you are creating an adjustment or verification labeling job, you must use a <i>different</i>
        /// <c>LabelAttributeName</c> than the one used in the original labeling job. The original
        /// labeling job is the Ground Truth labeling job that produced the labels that you want
        /// verified or adjusted. To learn more about adjustment and verification labeling jobs,
        /// see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/sms-verification-data.html">Verify
        /// and Adjust Labels</a>.
        /// </para>
        ///  </important>
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
        /// The S3 URI of the file, referred to as a <i>label category configuration file</i>,
        /// that defines the categories used to label the data objects.
        /// </para>
        ///  
        /// <para>
        /// For 3D point cloud and video frame task types, you can add label category attributes
        /// and frame attributes to your label category configuration file. To learn how, see
        /// <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/sms-point-cloud-label-category-config.html">Create
        /// a Labeling Category Configuration File for 3D Point Cloud Labeling Jobs</a>. 
        /// </para>
        ///  
        /// <para>
        /// For named entity recognition jobs, in addition to <c>"labels"</c>, you must provide
        /// worker instructions in the label category configuration file using the <c>"instructions"</c>
        /// parameter: <c>"instructions": {"shortInstruction":"&lt;h1&gt;Add header&lt;/h1&gt;&lt;p&gt;Add
        /// Instructions&lt;/p&gt;", "fullInstruction":"&lt;p&gt;Add additional instructions.&lt;/p&gt;"}</c>.
        /// For details and an example, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/sms-named-entity-recg.html#sms-creating-ner-api">Create
        /// a Named Entity Recognition Labeling Job (API) </a>.
        /// </para>
        ///  
        /// <para>
        /// For all other <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/sms-task-types.html">built-in
        /// task types</a> and <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/sms-custom-templates.html">custom
        /// tasks</a>, your label category configuration file must be a JSON file in the following
        /// format. Identify the labels you want to use by replacing <c>label_1</c>, <c>label_2</c>,<c>...</c>,<c>label_n</c>
        /// with your label categories.
        /// </para>
        ///  
        /// <para>
        ///  <c>{ </c> 
        /// </para>
        ///  
        /// <para>
        ///  <c>"document-version": "2018-11-28",</c> 
        /// </para>
        ///  
        /// <para>
        ///  <c>"labels": [{"label": "label_1"},{"label": "label_2"},...{"label": "label_n"}]</c>
        /// 
        /// </para>
        ///  
        /// <para>
        ///  <c>}</c> 
        /// </para>
        ///  
        /// <para>
        /// Note the following about the label category configuration file:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For image classification and text classification (single and multi-label) you must
        /// specify at least two label categories. For all other task types, the minimum number
        /// of label categories required is one. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Each label category must be unique, you cannot specify duplicate label categories.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you create a 3D point cloud or video frame adjustment or verification labeling
        /// job, you must include <c>auditLabelAttributeName</c> in the label category configuration.
        /// Use this parameter to enter the <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_CreateLabelingJob.html#sagemaker-CreateLabelingJob-request-LabelAttributeName">
        /// <c>LabelAttributeName</c> </a> of the labeling job you want to adjust or verify annotations
        /// of.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
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
        /// jobs. Labeling job names must be unique within an Amazon Web Services account and
        /// region. <c>LabelingJobName</c> is not case sensitive. For example, Example-job and
        /// example-job are considered the same labeling job name by Ground Truth.
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
        /// The location of the output data and the Amazon Web Services Key Management Service
        /// key ID for the key used to encrypt the output data, if any.
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
        /// Cost Allocation Tags</a> in the <i>Amazon Web Services Billing and Cost Management
        /// User Guide</i>.
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