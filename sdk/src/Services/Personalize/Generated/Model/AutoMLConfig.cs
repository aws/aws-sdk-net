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
    /// When the solution performs AutoML (<code>performAutoML</code> is true in <a>CreateSolution</a>),
    /// Amazon Personalize determines which recipe, from the specified list, optimizes the
    /// given metric. Amazon Personalize then uses that recipe for the solution.
    /// </summary>
    public partial class AutoMLConfig
    {
        private string _metricName;
        private List<string> _recipeList = new List<string>();

        /// <summary>
        /// Gets and sets the property MetricName. 
        /// <para>
        /// The metric to optimize.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string MetricName
        {
            get { return this._metricName; }
            set { this._metricName = value; }
        }

        // Check to see if MetricName property is set
        internal bool IsSetMetricName()
        {
            return this._metricName != null;
        }

        /// <summary>
        /// Gets and sets the property RecipeList. 
        /// <para>
        /// The list of candidate recipes.
        /// </para>
        /// </summary>
        [AWSProperty(Max=100)]
        public List<string> RecipeList
        {
            get { return this._recipeList; }
            set { this._recipeList = value; }
        }

        // Check to see if RecipeList property is set
        internal bool IsSetRecipeList()
        {
            return this._recipeList != null && this._recipeList.Count > 0; 
        }

    }
}