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
    /// Container for the parameters to the ListRecipes operation.
    /// Returns a list of available recipes. The response provides the properties for each
    /// recipe, including the recipe's Amazon Resource Name (ARN).
    /// </summary>
    public partial class ListRecipesRequest : AmazonPersonalizeRequest
    {
        private Domain _domain;
        private int? _maxResults;
        private string _nextToken;
        private RecipeProvider _recipeProvider;

        /// <summary>
        /// Gets and sets the property Domain. 
        /// <para>
        ///  Filters returned recipes by domain for a Domain dataset group. Only recipes (Domain
        /// dataset group use cases) for this domain are included in the response. If you don't
        /// specify a domain, all recipes are returned. 
        /// </para>
        /// </summary>
        public Domain Domain
        {
            get { return this._domain; }
            set { this._domain = value; }
        }

        // Check to see if Domain property is set
        internal bool IsSetDomain()
        {
            return this._domain != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of recipes to return.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public int? MaxResults
        {
            get { return this._maxResults; }
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
        /// A token returned from the previous call to <c>ListRecipes</c> for getting the next
        /// set of recipes (if they exist).
        /// </para>
        /// </summary>
        [AWSProperty(Max=1500)]
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
        /// The default is <c>SERVICE</c>.
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