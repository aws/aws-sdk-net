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
    /// Container for the parameters to the CreateBatchInferenceJob operation.
    /// Generates batch recommendations based on a list of items or users stored in Amazon
    /// S3 and exports the recommendations to an Amazon S3 bucket.
    /// 
    ///  
    /// <para>
    /// To generate batch recommendations, specify the ARN of a solution version and an Amazon
    /// S3 URI for the input and output data. For user personalization, popular items, and
    /// personalized ranking solutions, the batch inference job generates a list of recommended
    /// items for each user ID in the input file. For related items solutions, the job generates
    /// a list of recommended items for each item ID in the input file.
    /// </para>
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/personalize/latest/dg/getting-batch-recommendations.html">Creating
    /// a batch inference job </a>.
    /// </para>
    ///  
    /// <para>
    ///  If you use the Similar-Items recipe, Amazon Personalize can add descriptive themes
    /// to batch recommendations. To generate themes, set the job's mode to <c>THEME_GENERATION</c>
    /// and specify the name of the field that contains item names in the input data.
    /// </para>
    ///  
    /// <para>
    ///  For more information about generating themes, see <a href="https://docs.aws.amazon.com/personalize/latest/dg/themed-batch-recommendations.html">Batch
    /// recommendations with themes from Content Generator </a>. 
    /// </para>
    ///  
    /// <para>
    /// You can't get batch recommendations with the Trending-Now or Next-Best-Action recipes.
    /// </para>
    /// </summary>
    public partial class CreateBatchInferenceJobRequest : AmazonPersonalizeRequest
    {
        private BatchInferenceJobConfig _batchInferenceJobConfig;
        private BatchInferenceJobMode _batchInferenceJobMode;
        private string _filterArn;
        private BatchInferenceJobInput _jobInput;
        private string _jobName;
        private BatchInferenceJobOutput _jobOutput;
        private int? _numResults;
        private string _roleArn;
        private string _solutionVersionArn;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private ThemeGenerationConfig _themeGenerationConfig;

        /// <summary>
        /// Gets and sets the property BatchInferenceJobConfig. 
        /// <para>
        /// The configuration details of a batch inference job.
        /// </para>
        /// </summary>
        public BatchInferenceJobConfig BatchInferenceJobConfig
        {
            get { return this._batchInferenceJobConfig; }
            set { this._batchInferenceJobConfig = value; }
        }

        // Check to see if BatchInferenceJobConfig property is set
        internal bool IsSetBatchInferenceJobConfig()
        {
            return this._batchInferenceJobConfig != null;
        }

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
        public BatchInferenceJobMode BatchInferenceJobMode
        {
            get { return this._batchInferenceJobMode; }
            set { this._batchInferenceJobMode = value; }
        }

        // Check to see if BatchInferenceJobMode property is set
        internal bool IsSetBatchInferenceJobMode()
        {
            return this._batchInferenceJobMode != null;
        }

        /// <summary>
        /// Gets and sets the property FilterArn. 
        /// <para>
        /// The ARN of the filter to apply to the batch inference job. For more information on
        /// using filters, see <a href="https://docs.aws.amazon.com/personalize/latest/dg/filter-batch.html">Filtering
        /// batch recommendations</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string FilterArn
        {
            get { return this._filterArn; }
            set { this._filterArn = value; }
        }

        // Check to see if FilterArn property is set
        internal bool IsSetFilterArn()
        {
            return this._filterArn != null;
        }

        /// <summary>
        /// Gets and sets the property JobInput. 
        /// <para>
        /// The Amazon S3 path that leads to the input file to base your recommendations on. The
        /// input material must be in JSON format.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public BatchInferenceJobInput JobInput
        {
            get { return this._jobInput; }
            set { this._jobInput = value; }
        }

        // Check to see if JobInput property is set
        internal bool IsSetJobInput()
        {
            return this._jobInput != null;
        }

        /// <summary>
        /// Gets and sets the property JobName. 
        /// <para>
        /// The name of the batch inference job to create.
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
        /// The path to the Amazon S3 bucket where the job's output will be stored.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public BatchInferenceJobOutput JobOutput
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
        /// Gets and sets the property NumResults. 
        /// <para>
        /// The number of recommendations to retrieve.
        /// </para>
        /// </summary>
        public int? NumResults
        {
            get { return this._numResults; }
            set { this._numResults = value; }
        }

        // Check to see if NumResults property is set
        internal bool IsSetNumResults()
        {
            return this._numResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The ARN of the Amazon Identity and Access Management role that has permissions to
        /// read and write to your input and output Amazon S3 buckets respectively.
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
        /// Gets and sets the property SolutionVersionArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the solution version that will be used to generate
        /// the batch inference recommendations.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=256)]
        public string SolutionVersionArn
        {
            get { return this._solutionVersionArn; }
            set { this._solutionVersionArn = value; }
        }

        // Check to see if SolutionVersionArn property is set
        internal bool IsSetSolutionVersionArn()
        {
            return this._solutionVersionArn != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of <a href="https://docs.aws.amazon.com/personalize/latest/dg/tagging-resources.html">tags</a>
        /// to apply to the batch inference job.
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

        /// <summary>
        /// Gets and sets the property ThemeGenerationConfig. 
        /// <para>
        /// For theme generation jobs, specify the name of the column in your Items dataset that
        /// contains each item's name.
        /// </para>
        /// </summary>
        public ThemeGenerationConfig ThemeGenerationConfig
        {
            get { return this._themeGenerationConfig; }
            set { this._themeGenerationConfig = value; }
        }

        // Check to see if ThemeGenerationConfig property is set
        internal bool IsSetThemeGenerationConfig()
        {
            return this._themeGenerationConfig != null;
        }

    }
}