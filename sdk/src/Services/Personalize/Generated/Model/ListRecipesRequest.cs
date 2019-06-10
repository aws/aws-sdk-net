/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Personalize.Model
{
    /// <summary>
    /// Container for the parameters to the ListRecipes operation.
    /// Returns a list of available recipes. The response provides the properties for each
    /// recipe, including the recipe's Amazon Resource Name (ARN).
    /// </summary>
    public partial class ListRecipesRequest : AmazonPersonalizeRequest
    {
        private int? _maxResults;
        private string _nextToken;
        private RecipeProvider _recipeProvider;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of recipes to return.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public int MaxResults
        {
            get { return this._maxResults.GetValueOrDefault(); }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A token returned from the previous call to <code>ListRecipes</code> for getting the
        /// next set of recipes (if they exist).
        /// </para>
        /// </summary>
        [AWSProperty(Max=1300)]
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property RecipeProvider. 
        /// <para>
        /// The default is <code>SERVICE</code>.
        /// </para>
        /// </summary>
        public RecipeProvider RecipeProvider
        {
            get { return this._recipeProvider; }
            set { this._recipeProvider = value; }
        }

        // Check to see if RecipeProvider property is set
        internal bool IsSetRecipeProvider()
        {
            return this._recipeProvider != null;
        }

    }
}