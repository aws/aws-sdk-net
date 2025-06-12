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
    /// Container for the parameters to the CreateRecommender operation.
    /// Creates a recommender with the recipe (a Domain dataset group use case) you specify.
    /// You create recommenders for a Domain dataset group and specify the recommender's Amazon
    /// Resource Name (ARN) when you make a <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_RS_GetRecommendations.html">GetRecommendations</a>
    /// request. 
    /// 
    ///  
    /// <para>
    ///  <b>Minimum recommendation requests per second</b> 
    /// </para>
    ///  <important> 
    /// <para>
    /// A high <c>minRecommendationRequestsPerSecond</c> will increase your bill. We recommend
    /// starting with 1 for <c>minRecommendationRequestsPerSecond</c> (the default). Track
    /// your usage using Amazon CloudWatch metrics, and increase the <c>minRecommendationRequestsPerSecond</c>
    /// as necessary.
    /// </para>
    ///  </important> 
    /// <para>
    /// When you create a recommender, you can configure the recommender's minimum recommendation
    /// requests per second. The minimum recommendation requests per second (<c>minRecommendationRequestsPerSecond</c>)
    /// specifies the baseline recommendation request throughput provisioned by Amazon Personalize.
    /// The default minRecommendationRequestsPerSecond is <c>1</c>. A recommendation request
    /// is a single <c>GetRecommendations</c> operation. Request throughput is measured in
    /// requests per second and Amazon Personalize uses your requests per second to derive
    /// your requests per hour and the price of your recommender usage. 
    /// </para>
    ///  
    /// <para>
    ///  If your requests per second increases beyond <c>minRecommendationRequestsPerSecond</c>,
    /// Amazon Personalize auto-scales the provisioned capacity up and down, but never below
    /// <c>minRecommendationRequestsPerSecond</c>. There's a short time delay while the capacity
    /// is increased that might cause loss of requests.
    /// </para>
    ///  
    /// <para>
    ///  Your bill is the greater of either the minimum requests per hour (based on minRecommendationRequestsPerSecond)
    /// or the actual number of requests. The actual request throughput used is calculated
    /// as the average requests/second within a one-hour window. We recommend starting with
    /// the default <c>minRecommendationRequestsPerSecond</c>, track your usage using Amazon
    /// CloudWatch metrics, and then increase the <c>minRecommendationRequestsPerSecond</c>
    /// as necessary. 
    /// </para>
    ///  
    /// <para>
    ///  <b>Status</b> 
    /// </para>
    ///  
    /// <para>
    /// A recommender can be in one of the following states:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// CREATE PENDING &gt; CREATE IN_PROGRESS &gt; ACTIVE -or- CREATE FAILED
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// STOP PENDING &gt; STOP IN_PROGRESS &gt; INACTIVE &gt; START PENDING &gt; START IN_PROGRESS
    /// &gt; ACTIVE
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// DELETE PENDING &gt; DELETE IN_PROGRESS
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// To get the recommender status, call <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_DescribeRecommender.html">DescribeRecommender</a>.
    /// </para>
    ///  <note> 
    /// <para>
    /// Wait until the <c>status</c> of the recommender is <c>ACTIVE</c> before asking the
    /// recommender for recommendations.
    /// </para>
    ///  </note> 
    /// <para>
    ///  <b>Related APIs</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_ListRecommenders.html">ListRecommenders</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_DescribeRecommender.html">DescribeRecommender</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_UpdateRecommender.html">UpdateRecommender</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_DeleteRecommender.html">DeleteRecommender</a>
    /// 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class CreateRecommenderRequest : AmazonPersonalizeRequest
    {
        private string _datasetGroupArn;
        private string _name;
        private string _recipeArn;
        private RecommenderConfig _recommenderConfig;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Gets and sets the property DatasetGroupArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the destination domain dataset group for the recommender.
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
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the recommender.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=63)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property RecipeArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the recipe that the recommender will use. For a
        /// recommender, a recipe is a Domain dataset group use case. Only Domain dataset group
        /// use cases can be used to create a recommender. For information about use cases see
        /// <a href="https://docs.aws.amazon.com/personalize/latest/dg/domain-use-cases.html">Choosing
        /// recommender use cases</a>. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=256)]
        public string RecipeArn
        {
            get { return this._recipeArn; }
            set { this._recipeArn = value; }
        }

        // Check to see if RecipeArn property is set
        internal bool IsSetRecipeArn()
        {
            return this._recipeArn != null;
        }

        /// <summary>
        /// Gets and sets the property RecommenderConfig. 
        /// <para>
        /// The configuration details of the recommender.
        /// </para>
        /// </summary>
        public RecommenderConfig RecommenderConfig
        {
            get { return this._recommenderConfig; }
            set { this._recommenderConfig = value; }
        }

        // Check to see if RecommenderConfig property is set
        internal bool IsSetRecommenderConfig()
        {
            return this._recommenderConfig != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of <a href="https://docs.aws.amazon.com/personalize/latest/dg/tagging-resources.html">tags</a>
        /// to apply to the recommender.
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