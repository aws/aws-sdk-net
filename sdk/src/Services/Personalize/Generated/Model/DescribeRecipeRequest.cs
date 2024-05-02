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
    /// Container for the parameters to the DescribeRecipe operation.
    /// Describes a recipe.
    /// 
    ///  
    /// <para>
    /// A recipe contains three items:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// An algorithm that trains a model.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Hyperparameters that govern the training.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Feature transformation information for modifying the input data before training.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// Amazon Personalize provides a set of predefined recipes. You specify a recipe when
    /// you create a solution with the <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_CreateSolution.html">CreateSolution</a>
    /// API. <c>CreateSolution</c> trains a model by using the algorithm in the specified
    /// recipe and a training dataset. The solution, when deployed as a campaign, can provide
    /// recommendations using the <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_RS_GetRecommendations.html">GetRecommendations</a>
    /// API.
    /// </para>
    /// </summary>
    public partial class DescribeRecipeRequest : AmazonPersonalizeRequest
    {
        private string _recipeArn;

        /// <summary>
        /// Gets and sets the property RecipeArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the recipe to describe.
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

    }
}