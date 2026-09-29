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

namespace Amazon.GlueDataBrew.Model
{
    /// <summary>
    /// Container for the parameters to the ListRecipes operation. Lists all of the DataBrew
    /// recipes that are defined.
    /// </summary>
    public partial class ListRecipesRequest : AmazonGlueDataBrewRequest
    {
        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return in this request. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token returned by a previous call to retrieve the next set of results.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2000)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property RecipeVersion. 
        /// <para>
        /// Return only those recipes with a version identifier of <c>LATEST_WORKING</c> or <c>LATEST_PUBLISHED</c>.
        /// If <c>RecipeVersion</c> is omitted, <c>ListRecipes</c> returns all of the <c>LATEST_PUBLISHED</c>
        /// recipe versions.
        /// </para>
        ///  
        /// <para>
        /// Valid values: <c>LATEST_WORKING</c> | <c>LATEST_PUBLISHED</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 16)]
        public string RecipeVersion { get; set; }

        /// <summary>
        /// Checks to see if the RecipeVersion property is set.
        /// </summary>
        internal bool IsSetRecipeVersion() => this.RecipeVersion != null;
    }
}
