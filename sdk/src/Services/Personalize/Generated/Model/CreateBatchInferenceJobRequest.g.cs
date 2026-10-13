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

namespace Amazon.Personalize.Model
{
    /// <summary>
    /// Container for the parameters to the CreateBatchInferenceJob operation. Generates batch
    /// recommendations based on a list of items or users stored in Amazon S3 and exports
    /// the recommendations to an Amazon S3 bucket. <para> To generate batch recommendations,
    /// specify the ARN of a solution version and an Amazon S3 URI for the input and output
    /// data. For user personalization, popular items, and personalized ranking solutions,
    /// the batch inference job generates a list of recommended items for each user ID in
    /// the input file. For related items solutions, the job generates a list of recommended
    /// items for each item ID in the input file. </para> <para> For more information, see
    /// <a href="https://docs.aws.amazon.com/personalize/latest/dg/getting-batch-recommendations.html">Creating
    /// a batch inference job </a>. </para> <para> If you use the Similar-Items recipe, Amazon
    /// Personalize can add descriptive themes to batch recommendations. To generate themes,
    /// set the job's mode to <c>THEME_GENERATION</c> and specify the name of the field that
    /// contains item names in the input data. </para> <para> For more information about generating
    /// themes, see <a href="https://docs.aws.amazon.com/personalize/latest/dg/themed-batch-recommendations.html">Batch
    /// recommendations with themes from Content Generator </a>. </para> <para> You can't
    /// get batch recommendations with the Trending-Now or Next-Best-Action recipes. </para>
    /// </summary>
    public partial class CreateBatchInferenceJobRequest : AmazonPersonalizeRequest
    {
        /// <summary>
        /// Gets and sets the property BatchInferenceJobConfig. 
        /// <para>
        /// The configuration details of a batch inference job.
        /// </para>
        /// </summary>
        public BatchInferenceJobConfig BatchInferenceJobConfig { get; set; }

        /// <summary>
        /// Checks to see if the BatchInferenceJobConfig property is set.
        /// </summary>
        internal bool IsSetBatchInferenceJobConfig() => this.BatchInferenceJobConfig != null;

        /// <summary>
        /// Gets and sets the property BatchInferenceJobMode. 
        /// <para>
        /// The mode of the batch inference job. To generate descriptive themes for groups of
        /// similar items, set the job mode to <c>THEME_GENERATION</c>. If you don't want to generate
        /// themes, use the default <c>BATCH_INFERENCE</c>.
        /// </para>
        ///  
        /// <para>
        ///  When you get batch recommendations with themes, you will incur additional costs.
        /// For more information, see <a href="https://aws.amazon.com/personalize/pricing/">Amazon
        /// Personalize pricing</a>. 
        /// </para>
        /// </summary>
        public BatchInferenceJobMode BatchInferenceJobMode { get; set; }

        /// <summary>
        /// Checks to see if the BatchInferenceJobMode property is set.
        /// </summary>
        internal bool IsSetBatchInferenceJobMode() => this.BatchInferenceJobMode != null;

        /// <summary>
        /// Gets and sets the property FilterArn. 
        /// <para>
        /// The ARN of the filter to apply to the batch inference job. For more information on
        /// using filters, see <a href="https://docs.aws.amazon.com/personalize/latest/dg/filter-batch.html">Filtering
        /// batch recommendations</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string FilterArn { get; set; }

        /// <summary>
        /// Checks to see if the FilterArn property is set.
        /// </summary>
        internal bool IsSetFilterArn() => this.FilterArn != null;

        /// <summary>
        /// Gets and sets the property JobInput. 
        /// <para>
        /// The Amazon S3 path that leads to the input file to base your recommendations on. The
        /// input material must be in JSON format.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public BatchInferenceJobInput JobInput { get; set; }

        /// <summary>
        /// Checks to see if the JobInput property is set.
        /// </summary>
        internal bool IsSetJobInput() => this.JobInput != null;

        /// <summary>
        /// Gets and sets the property JobName. 
        /// <para>
        /// The name of the batch inference job to create.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 63)]
        public string JobName { get; set; }

        /// <summary>
        /// Checks to see if the JobName property is set.
        /// </summary>
        internal bool IsSetJobName() => this.JobName != null;

        /// <summary>
        /// Gets and sets the property JobOutput. 
        /// <para>
        /// The path to the Amazon S3 bucket where the job's output will be stored.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public BatchInferenceJobOutput JobOutput { get; set; }

        /// <summary>
        /// Checks to see if the JobOutput property is set.
        /// </summary>
        internal bool IsSetJobOutput() => this.JobOutput != null;

        /// <summary>
        /// Gets and sets the property NumResults. 
        /// <para>
        /// The number of recommendations to retrieve.
        /// </para>
        /// </summary>
        public int? NumResults { get; set; }

        /// <summary>
        /// Checks to see if the NumResults property is set.
        /// </summary>
        internal bool IsSetNumResults() => this.NumResults.HasValue;

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The ARN of the Amazon Identity and Access Management role that has permissions to
        /// read and write to your input and output Amazon S3 buckets respectively.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 256)]
        public string RoleArn { get; set; }

        /// <summary>
        /// Checks to see if the RoleArn property is set.
        /// </summary>
        internal bool IsSetRoleArn() => this.RoleArn != null;

        /// <summary>
        /// Gets and sets the property SolutionVersionArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the solution version that will be used to generate
        /// the batch inference recommendations.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 256)]
        public string SolutionVersionArn { get; set; }

        /// <summary>
        /// Checks to see if the SolutionVersionArn property is set.
        /// </summary>
        internal bool IsSetSolutionVersionArn() => this.SolutionVersionArn != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of <a href="https://docs.aws.amazon.com/personalize/latest/dg/tagging-resources.html">tags</a>
        /// to apply to the batch inference job.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 200)]
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ThemeGenerationConfig. 
        /// <para>
        /// For theme generation jobs, specify the name of the column in your Items dataset that
        /// contains each item's name.
        /// </para>
        /// </summary>
        public ThemeGenerationConfig ThemeGenerationConfig { get; set; }

        /// <summary>
        /// Checks to see if the ThemeGenerationConfig property is set.
        /// </summary>
        internal bool IsSetThemeGenerationConfig() => this.ThemeGenerationConfig != null;
    }
}
