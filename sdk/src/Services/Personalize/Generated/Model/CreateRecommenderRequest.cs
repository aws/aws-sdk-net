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
    /// Container for the parameters to the CreateRecommender operation.
    /// Creates a recommender with the recipe (a Domain dataset group use case) you specify.
    /// You create recommenders for a Domain dataset group and specify the recommender's Amazon
    /// Resource Name (ARN) when you make a <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_RS_GetRecommendations.html">GetRecommendations</a>
    /// request. 
    /// 
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
    /// DELETE PENDING &gt; DELETE IN_PROGRESS
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// To get the recommender status, call <a>DescribeRecommender</a>.
    /// </para>
    ///  <note> 
    /// <para>
    /// Wait until the <code>status</code> of the recommender is <code>ACTIVE</code> before
    /// asking the recommender for recommendations.
    /// </para>
    ///  </note> <p class="title"> <b>Related APIs</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>ListRecommenders</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DescribeRecommender</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>UpdateRecommender</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DeleteRecommender</a> 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class CreateRecommenderRequest : AmazonPersonalizeRequest
    {
        private string _datasetGroupArn;
        private string _name;
        private string _recipeArn;
        private RecommenderConfig _recommenderConfig;

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

    }
}