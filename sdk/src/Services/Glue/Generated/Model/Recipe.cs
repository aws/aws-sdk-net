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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
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
namespace Amazon.Glue.Model
{
    /// <summary>
    /// A Glue Studio node that uses a Glue DataBrew recipe in Glue jobs.
    /// </summary>
    public partial class Recipe
    {
        private List<string> _inputs = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _name;
        private RecipeReference _recipeReference;
        private List<RecipeStep> _recipeSteps = AWSConfigs.InitializeCollections ? new List<RecipeStep>() : null;

        /// <summary>
        /// Gets and sets the property Inputs. 
        /// <para>
        /// The nodes that are inputs to the recipe node, identified by id.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1)]
        public List<string> Inputs
        {
            get { return this._inputs; }
            set { this._inputs = value; }
        }

        // Check to see if Inputs property is set
        internal bool IsSetInputs()
        {
            return this._inputs != null && (this._inputs.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the Glue Studio node.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property RecipeReference. 
        /// <para>
        /// A reference to the DataBrew recipe used by the node.
        /// </para>
        /// </summary>
        public RecipeReference RecipeReference
        {
            get { return this._recipeReference; }
            set { this._recipeReference = value; }
        }

        // Check to see if RecipeReference property is set
        internal bool IsSetRecipeReference()
        {
            return this._recipeReference != null;
        }

        /// <summary>
        /// Gets and sets the property RecipeSteps. 
        /// <para>
        /// Transform steps used in the recipe node.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<RecipeStep> RecipeSteps
        {
            get { return this._recipeSteps; }
            set { this._recipeSteps = value; }
        }

        // Check to see if RecipeSteps property is set
        internal bool IsSetRecipeSteps()
        {
            return this._recipeSteps != null && (this._recipeSteps.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}