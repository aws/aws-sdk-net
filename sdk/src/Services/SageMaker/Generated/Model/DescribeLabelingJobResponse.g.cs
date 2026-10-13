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

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// This is the response object from the DescribeLabelingJob operation.
    /// </summary>
    public partial class DescribeLabelingJobResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The date and time that the labeling job was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property FailureReason. 
        /// <para>
        /// If the job failed, the reason that it failed. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string FailureReason { get; set; }

        /// <summary>
        /// Checks to see if the FailureReason property is set.
        /// </summary>
        internal bool IsSetFailureReason() => this.FailureReason != null;

        /// <summary>
        /// Gets and sets the property HumanTaskConfig. 
        /// <para>
        /// Configuration information required for human workers to complete a labeling task.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public HumanTaskConfig HumanTaskConfig { get; set; }

        /// <summary>
        /// Checks to see if the HumanTaskConfig property is set.
        /// </summary>
        internal bool IsSetHumanTaskConfig() => this.HumanTaskConfig != null;

        /// <summary>
        /// Gets and sets the property InputConfig. 
        /// <para>
        /// Input configuration information for the labeling job, such as the Amazon S3 location
        /// of the data objects and the location of the manifest file that describes the data
        /// objects.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public LabelingJobInputConfig InputConfig { get; set; }

        /// <summary>
        /// Checks to see if the InputConfig property is set.
        /// </summary>
        internal bool IsSetInputConfig() => this.InputConfig != null;

        /// <summary>
        /// Gets and sets the property JobReferenceCode. 
        /// <para>
        /// A unique identifier for work done as part of a labeling job.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1)]
        public string JobReferenceCode { get; set; }

        /// <summary>
        /// Checks to see if the JobReferenceCode property is set.
        /// </summary>
        internal bool IsSetJobReferenceCode() => this.JobReferenceCode != null;

        /// <summary>
        /// Gets and sets the property LabelAttributeName. 
        /// <para>
        /// The attribute used as the label in the output manifest file.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 127)]
        public string LabelAttributeName { get; set; }

        /// <summary>
        /// Checks to see if the LabelAttributeName property is set.
        /// </summary>
        internal bool IsSetLabelAttributeName() => this.LabelAttributeName != null;

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
        [AWSProperty(Min = 0, Max = 1024)]
        public string LabelCategoryConfigS3Uri { get; set; }

        /// <summary>
        /// Checks to see if the LabelCategoryConfigS3Uri property is set.
        /// </summary>
        internal bool IsSetLabelCategoryConfigS3Uri() => this.LabelCategoryConfigS3Uri != null;

        /// <summary>
        /// Gets and sets the property LabelCounters. 
        /// <para>
        /// Provides a breakdown of the number of data objects labeled by humans, the number of
        /// objects labeled by machine, the number of objects than couldn't be labeled, and the
        /// total number of objects labeled. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public LabelCounters LabelCounters { get; set; }

        /// <summary>
        /// Checks to see if the LabelCounters property is set.
        /// </summary>
        internal bool IsSetLabelCounters() => this.LabelCounters != null;

        /// <summary>
        /// Gets and sets the property LabelingJobAlgorithmsConfig. 
        /// <para>
        /// Configuration information for automated data labeling.
        /// </para>
        /// </summary>
        public LabelingJobAlgorithmsConfig LabelingJobAlgorithmsConfig { get; set; }

        /// <summary>
        /// Checks to see if the LabelingJobAlgorithmsConfig property is set.
        /// </summary>
        internal bool IsSetLabelingJobAlgorithmsConfig() => this.LabelingJobAlgorithmsConfig != null;

        /// <summary>
        /// Gets and sets the property LabelingJobArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the labeling job.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 2048)]
        public string LabelingJobArn { get; set; }

        /// <summary>
        /// Checks to see if the LabelingJobArn property is set.
        /// </summary>
        internal bool IsSetLabelingJobArn() => this.LabelingJobArn != null;

        /// <summary>
        /// Gets and sets the property LabelingJobName. 
        /// <para>
        /// The name assigned to the labeling job when it was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 63)]
        public string LabelingJobName { get; set; }

        /// <summary>
        /// Checks to see if the LabelingJobName property is set.
        /// </summary>
        internal bool IsSetLabelingJobName() => this.LabelingJobName != null;

        /// <summary>
        /// Gets and sets the property LabelingJobOutput. 
        /// <para>
        /// The location of the output produced by the labeling job.
        /// </para>
        /// </summary>
        public LabelingJobOutput LabelingJobOutput { get; set; }

        /// <summary>
        /// Checks to see if the LabelingJobOutput property is set.
        /// </summary>
        internal bool IsSetLabelingJobOutput() => this.LabelingJobOutput != null;

        /// <summary>
        /// Gets and sets the property LabelingJobStatus. 
        /// <para>
        /// The processing status of the labeling job. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public LabelingJobStatus LabelingJobStatus { get; set; }

        /// <summary>
        /// Checks to see if the LabelingJobStatus property is set.
        /// </summary>
        internal bool IsSetLabelingJobStatus() => this.LabelingJobStatus != null;

        /// <summary>
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// The date and time that the labeling job was last updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? LastModifiedTime { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedTime property is set.
        /// </summary>
        internal bool IsSetLastModifiedTime() => this.LastModifiedTime.HasValue;

        /// <summary>
        /// Gets and sets the property OutputConfig. 
        /// <para>
        /// The location of the job's output data and the Amazon Web Services Key Management Service
        /// key ID for the key used to encrypt the output data, if any.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public LabelingJobOutputConfig OutputConfig { get; set; }

        /// <summary>
        /// Checks to see if the OutputConfig property is set.
        /// </summary>
        internal bool IsSetOutputConfig() => this.OutputConfig != null;

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) that SageMaker assumes to perform tasks on your behalf
        /// during data labeling.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 2048)]
        public string RoleArn { get; set; }

        /// <summary>
        /// Checks to see if the RoleArn property is set.
        /// </summary>
        internal bool IsSetRoleArn() => this.RoleArn != null;

        /// <summary>
        /// Gets and sets the property StoppingConditions. 
        /// <para>
        /// A set of conditions for stopping a labeling job. If any of the conditions are met,
        /// the job is automatically stopped.
        /// </para>
        /// </summary>
        public LabelingJobStoppingConditions StoppingConditions { get; set; }

        /// <summary>
        /// Checks to see if the StoppingConditions property is set.
        /// </summary>
        internal bool IsSetStoppingConditions() => this.StoppingConditions != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// An array of key-value pairs. You can use tags to categorize your Amazon Web Services
        /// resources in different ways, for example, by purpose, owner, or environment. For more
        /// information, see <a href="https://docs.aws.amazon.com/general/latest/gr/aws_tagging.html">Tagging
        /// Amazon Web Services Resources</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
