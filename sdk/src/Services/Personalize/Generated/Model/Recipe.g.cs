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
    /// Provides information about a recipe. Each recipe provides an algorithm that Amazon
    /// Personalize uses in model training when you use the <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_CreateSolution.html">CreateSolution</a>
    /// operation.
    /// </summary>
    public partial class Recipe
    {
        /// <summary>
        /// Gets and sets the property AlgorithmArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the algorithm that Amazon Personalize uses to train
        /// the model.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string AlgorithmArn { get; set; }

        /// <summary>
        /// Checks to see if the AlgorithmArn property is set.
        /// </summary>
        internal bool IsSetAlgorithmArn() => this.AlgorithmArn != null;

        /// <summary>
        /// Gets and sets the property CreationDateTime. 
        /// <para>
        /// The date and time (in Unix format) that the recipe was created.
        /// </para>
        /// </summary>
        public DateTime? CreationDateTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationDateTime property is set.
        /// </summary>
        internal bool IsSetCreationDateTime() => this.CreationDateTime.HasValue;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the recipe.
        /// </para>
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property FeatureTransformationArn. 
        /// <para>
        /// The ARN of the FeatureTransformation object.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string FeatureTransformationArn { get; set; }

        /// <summary>
        /// Checks to see if the FeatureTransformationArn property is set.
        /// </summary>
        internal bool IsSetFeatureTransformationArn() => this.FeatureTransformationArn != null;

        /// <summary>
        /// Gets and sets the property LastUpdatedDateTime. 
        /// <para>
        /// The date and time (in Unix format) that the recipe was last updated.
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedDateTime { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdatedDateTime property is set.
        /// </summary>
        internal bool IsSetLastUpdatedDateTime() => this.LastUpdatedDateTime.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the recipe.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 63)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property RecipeArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the recipe.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string RecipeArn { get; set; }

        /// <summary>
        /// Checks to see if the RecipeArn property is set.
        /// </summary>
        internal bool IsSetRecipeArn() => this.RecipeArn != null;

        /// <summary>
        /// Gets and sets the property RecipeType. 
        /// <para>
        /// One of the following values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// PERSONALIZED_RANKING
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// RELATED_ITEMS
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// USER_PERSONALIZATION
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string RecipeType { get; set; }

        /// <summary>
        /// Checks to see if the RecipeType property is set.
        /// </summary>
        internal bool IsSetRecipeType() => this.RecipeType != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the recipe.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
