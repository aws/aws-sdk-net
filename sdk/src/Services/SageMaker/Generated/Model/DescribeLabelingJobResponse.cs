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
    /// This is the response object from the DescribeLabelingJob operation.
    /// </summary>
    public partial class DescribeLabelingJobResponse : AmazonWebServiceResponse
    {
        private DateTime? _creationTime;
        private string _failureReason;
        private HumanTaskConfig _humanTaskConfig;
        private LabelingJobInputConfig _inputConfig;
        private string _jobReferenceCode;
        private string _labelAttributeName;
        private string _labelCategoryConfigS3Uri;
        private LabelCounters _labelCounters;
        private LabelingJobAlgorithmsConfig _labelingJobAlgorithmsConfig;
        private string _labelingJobArn;
        private string _labelingJobName;
        private LabelingJobOutput _labelingJobOutput;
        private LabelingJobStatus _labelingJobStatus;
        private DateTime? _lastModifiedTime;
        private LabelingJobOutputConfig _outputConfig;
        private string _roleArn;
        private LabelingJobStoppingConditions _stoppingConditions;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The date and time that the labeling job was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? CreationTime
        {
            get { return this._creationTime; }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FailureReason. 
        /// <para>
        /// If the job failed, the reason that it failed. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string FailureReason
        {
            get { return this._failureReason; }
            set { this._failureReason = value; }
        }

        // Check to see if FailureReason property is set
        internal bool IsSetFailureReason()
        {
            return this._failureReason != null;
        }

        /// <summary>
        /// Gets and sets the property HumanTaskConfig. 
        /// <para>
        /// Configuration information required for human workers to complete a labeling task.
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
        /// Input configuration information for the labeling job, such as the Amazon S3 location
        /// of the data objects and the location of the manifest file that describes the data
        /// objects.
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
        /// Gets and sets the property JobReferenceCode. 
        /// <para>
        /// A unique identifier for work done as part of a labeling job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public string JobReferenceCode
        {
            get { return this._jobReferenceCode; }
            set { this._jobReferenceCode = value; }
        }

        // Check to see if JobReferenceCode property is set
        internal bool IsSetJobReferenceCode()
        {
            return this._jobReferenceCode != null;
        }

        /// <summary>
        /// Gets and sets the property LabelAttributeName. 
        /// <para>
        /// The attribute used as the label in the output manifest file.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=127)]
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
        /// The S3 location of the JSON file that defines the categories used to label data objects.
        /// Please note the following label-category limits:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Semantic segmentation labeling jobs using automated labeling: 20 labels
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Box bounding labeling jobs (all): 10 labels
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The file is a JSON structure in the following format:
        /// </para>
        ///  
        /// <para>
        ///  <c>{</c> 
        /// </para>
        ///  
        /// <para>
        ///  <c> "document-version": "2018-11-28"</c> 
        /// </para>
        ///  
        /// <para>
        ///  <c> "labels": [</c> 
        /// </para>
        ///  
        /// <para>
        ///  <c> {</c> 
        /// </para>
        ///  
        /// <para>
        ///  <c> "label": "<i>label 1</i>"</c> 
        /// </para>
        ///  
        /// <para>
        ///  <c> },</c> 
        /// </para>
        ///  
        /// <para>
        ///  <c> {</c> 
        /// </para>
        ///  
        /// <para>
        ///  <c> "label": "<i>label 2</i>"</c> 
        /// </para>
        ///  
        /// <para>
        ///  <c> },</c> 
        /// </para>
        ///  
        /// <para>
        ///  <c> ...</c> 
        /// </para>
        ///  
        /// <para>
        ///  <c> {</c> 
        /// </para>
        ///  
        /// <para>
        ///  <c> "label": "<i>label n</i>"</c> 
        /// </para>
        ///  
        /// <para>
        ///  <c> }</c> 
        /// </para>
        ///  
        /// <para>
        ///  <c> ]</c> 
        /// </para>
        ///  
        /// <para>
        ///  <c>}</c> 
        /// </para>
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
        /// Gets and sets the property LabelCounters. 
        /// <para>
        /// Provides a breakdown of the number of data objects labeled by humans, the number of
        /// objects labeled by machine, the number of objects than couldn't be labeled, and the
        /// total number of objects labeled. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public LabelCounters LabelCounters
        {
            get { return this._labelCounters; }
            set { this._labelCounters = value; }
        }

        // Check to see if LabelCounters property is set
        internal bool IsSetLabelCounters()
        {
            return this._labelCounters != null;
        }

        /// <summary>
        /// Gets and sets the property LabelingJobAlgorithmsConfig. 
        /// <para>
        /// Configuration information for automated data labeling.
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
        /// Gets and sets the property LabelingJobArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the labeling job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=2048)]
        public string LabelingJobArn
        {
            get { return this._labelingJobArn; }
            set { this._labelingJobArn = value; }
        }

        // Check to see if LabelingJobArn property is set
        internal bool IsSetLabelingJobArn()
        {
            return this._labelingJobArn != null;
        }

        /// <summary>
        /// Gets and sets the property LabelingJobName. 
        /// <para>
        /// The name assigned to the labeling job when it was created.
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
        /// Gets and sets the property LabelingJobOutput. 
        /// <para>
        /// The location of the output produced by the labeling job.
        /// </para>
        /// </summary>
        public LabelingJobOutput LabelingJobOutput
        {
            get { return this._labelingJobOutput; }
            set { this._labelingJobOutput = value; }
        }

        // Check to see if LabelingJobOutput property is set
        internal bool IsSetLabelingJobOutput()
        {
            return this._labelingJobOutput != null;
        }

        /// <summary>
        /// Gets and sets the property LabelingJobStatus. 
        /// <para>
        /// The processing status of the labeling job. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public LabelingJobStatus LabelingJobStatus
        {
            get { return this._labelingJobStatus; }
            set { this._labelingJobStatus = value; }
        }

        // Check to see if LabelingJobStatus property is set
        internal bool IsSetLabelingJobStatus()
        {
            return this._labelingJobStatus != null;
        }

        /// <summary>
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// The date and time that the labeling job was last updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? LastModifiedTime
        {
            get { return this._lastModifiedTime; }
            set { this._lastModifiedTime = value; }
        }

        // Check to see if LastModifiedTime property is set
        internal bool IsSetLastModifiedTime()
        {
            return this._lastModifiedTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OutputConfig. 
        /// <para>
        /// The location of the job's output data and the Amazon Web Services Key Management Service
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
        /// The Amazon Resource Name (ARN) that SageMaker assumes to perform tasks on your behalf
        /// during data labeling.
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
        /// A set of conditions for stopping a labeling job. If any of the conditions are met,
        /// the job is automatically stopped.
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
        /// An array of key-value pairs. You can use tags to categorize your Amazon Web Services
        /// resources in different ways, for example, by purpose, owner, or environment. For more
        /// information, see <a href="https://docs.aws.amazon.com/general/latest/gr/aws_tagging.html">Tagging
        /// Amazon Web Services Resources</a>.
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