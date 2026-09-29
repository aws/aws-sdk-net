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
    /// Represents one or more actions to be performed on a DataBrew dataset.
    /// </summary>
    public partial class Recipe
    {
        /// <summary>
        /// Gets and sets the property CreateDate. 
        /// <para>
        /// The date and time that the recipe was created.
        /// </para>
        /// </summary>
        public DateTime? CreateDate { get; set; }

        /// <summary>
        /// Checks to see if the CreateDate property is set.
        /// </summary>
        internal bool IsSetCreateDate() => this.CreateDate.HasValue;

        /// <summary>
        /// Gets and sets the property CreatedBy. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the user who created the recipe.
        /// </para>
        /// </summary>
        public string CreatedBy { get; set; }

        /// <summary>
        /// Checks to see if the CreatedBy property is set.
        /// </summary>
        internal bool IsSetCreatedBy() => this.CreatedBy != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the recipe.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property LastModifiedBy. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the user who last modified the recipe.
        /// </para>
        /// </summary>
        public string LastModifiedBy { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedBy property is set.
        /// </summary>
        internal bool IsSetLastModifiedBy() => this.LastModifiedBy != null;

        /// <summary>
        /// Gets and sets the property LastModifiedDate. 
        /// <para>
        /// The last modification date and time of the recipe.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedDate { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedDate property is set.
        /// </summary>
        internal bool IsSetLastModifiedDate() => this.LastModifiedDate.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The unique name for the recipe.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property ProjectName. 
        /// <para>
        /// The name of the project that the recipe is associated with.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string ProjectName { get; set; }

        /// <summary>
        /// Checks to see if the ProjectName property is set.
        /// </summary>
        internal bool IsSetProjectName() => this.ProjectName != null;

        /// <summary>
        /// Gets and sets the property PublishedBy. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the user who published the recipe.
        /// </para>
        /// </summary>
        public string PublishedBy { get; set; }

        /// <summary>
        /// Checks to see if the PublishedBy property is set.
        /// </summary>
        internal bool IsSetPublishedBy() => this.PublishedBy != null;

        /// <summary>
        /// Gets and sets the property PublishedDate. 
        /// <para>
        /// The date and time when the recipe was published.
        /// </para>
        /// </summary>
        public DateTime? PublishedDate { get; set; }

        /// <summary>
        /// Checks to see if the PublishedDate property is set.
        /// </summary>
        internal bool IsSetPublishedDate() => this.PublishedDate.HasValue;

        /// <summary>
        /// Gets and sets the property RecipeVersion. 
        /// <para>
        /// The identifier for the version for the recipe. Must be one of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Numeric version (<c>X.Y</c>) - <c>X</c> and <c>Y</c> stand for major and minor version
        /// numbers. The maximum length of each is 6 digits, and neither can be negative values.
        /// Both <c>X</c> and <c>Y</c> are required, and "0.0" isn't a valid version.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>LATEST_WORKING</c> - the most recent valid version being developed in a DataBrew
        /// project.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>LATEST_PUBLISHED</c> - the most recent published version.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min = 1, Max = 16)]
        public string RecipeVersion { get; set; }

        /// <summary>
        /// Checks to see if the RecipeVersion property is set.
        /// </summary>
        internal bool IsSetRecipeVersion() => this.RecipeVersion != null;

        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the recipe.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string ResourceArn { get; set; }

        /// <summary>
        /// Checks to see if the ResourceArn property is set.
        /// </summary>
        internal bool IsSetResourceArn() => this.ResourceArn != null;

        /// <summary>
        /// Gets and sets the property Steps. 
        /// <para>
        /// A list of steps that are defined by the recipe.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<RecipeStep> Steps { get; set; } = AWSConfigs.InitializeCollections ? new List<RecipeStep>() : null;

        /// <summary>
        /// Checks to see if the Steps property is set.
        /// </summary>
        internal bool IsSetSteps() => this.Steps != null && (this.Steps.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Metadata tags that have been applied to the recipe.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 200)]
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
