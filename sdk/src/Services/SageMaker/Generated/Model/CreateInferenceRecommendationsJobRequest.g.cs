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
    /// Container for the parameters to the CreateInferenceRecommendationsJob operation. Starts
    /// a recommendation job. You can create either an instance recommendation or load test
    /// job.
    /// </summary>
    public partial class CreateInferenceRecommendationsJobRequest : AmazonSageMakerRequest
    {
        /// <summary>
        /// Gets and sets the property InputConfig. 
        /// <para>
        /// Provides information about the versioned model package Amazon Resource Name (ARN),
        /// the traffic pattern, and endpoint configurations.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public RecommendationJobInputConfig InputConfig { get; set; }

        /// <summary>
        /// Checks to see if the InputConfig property is set.
        /// </summary>
        internal bool IsSetInputConfig() => this.InputConfig != null;

        /// <summary>
        /// Gets and sets the property JobDescription. 
        /// <para>
        /// Description of the recommendation job.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 128)]
        public string JobDescription { get; set; }

        /// <summary>
        /// Checks to see if the JobDescription property is set.
        /// </summary>
        internal bool IsSetJobDescription() => this.JobDescription != null;

        /// <summary>
        /// Gets and sets the property JobName. 
        /// <para>
        /// A name for the recommendation job. The name must be unique within the Amazon Web Services
        /// Region and within your Amazon Web Services account. The job name is passed down to
        /// the resources created by the recommendation job. The names of resources (such as the
        /// model, endpoint configuration, endpoint, and compilation) that are prefixed with the
        /// job name are truncated at 40 characters.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string JobName { get; set; }

        /// <summary>
        /// Checks to see if the JobName property is set.
        /// </summary>
        internal bool IsSetJobName() => this.JobName != null;

        /// <summary>
        /// Gets and sets the property JobType. 
        /// <para>
        /// Defines the type of recommendation job. Specify <c>Default</c> to initiate an instance
        /// recommendation and <c>Advanced</c> to initiate a load test. If left unspecified, Amazon
        /// SageMaker Inference Recommender will run an instance recommendation (<c>DEFAULT</c>)
        /// job.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public RecommendationJobType JobType { get; set; }

        /// <summary>
        /// Checks to see if the JobType property is set.
        /// </summary>
        internal bool IsSetJobType() => this.JobType != null;

        /// <summary>
        /// Gets and sets the property OutputConfig. 
        /// <para>
        /// Provides information about the output artifacts and the KMS key to use for Amazon
        /// S3 server-side encryption.
        /// </para>
        /// </summary>
        public RecommendationJobOutputConfig OutputConfig { get; set; }

        /// <summary>
        /// Checks to see if the OutputConfig property is set.
        /// </summary>
        internal bool IsSetOutputConfig() => this.OutputConfig != null;

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of an IAM role that enables Amazon SageMaker to perform
        /// tasks on your behalf.
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
        /// A set of conditions for stopping a recommendation job. If any of the conditions are
        /// met, the job is automatically stopped.
        /// </para>
        /// </summary>
        public RecommendationJobStoppingConditions StoppingConditions { get; set; }

        /// <summary>
        /// Checks to see if the StoppingConditions property is set.
        /// </summary>
        internal bool IsSetStoppingConditions() => this.StoppingConditions != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The metadata that you apply to Amazon Web Services resources to help you categorize
        /// and organize them. Each tag consists of a key and a value, both of which you define.
        /// For more information, see <a href="https://docs.aws.amazon.com/general/latest/gr/aws_tagging.html">Tagging
        /// Amazon Web Services Resources</a> in the Amazon Web Services General Reference.
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
