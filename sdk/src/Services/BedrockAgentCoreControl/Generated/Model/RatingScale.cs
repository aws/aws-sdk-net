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
 * Do not modify this file. This file is generated from the bedrock-agentcore-control-2023-06-05.normal.json service model.
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
namespace Amazon.BedrockAgentCoreControl.Model
{
    /// <summary>
    /// The rating scale that defines how evaluators should score agent performance, supporting
    /// both numerical and categorical scales.
    /// </summary>
    public partial class RatingScale
    {
        private List<CategoricalScaleDefinition> _categorical = AWSConfigs.InitializeCollections ? new List<CategoricalScaleDefinition>() : null;
        private List<NumericalScaleDefinition> _numerical = AWSConfigs.InitializeCollections ? new List<NumericalScaleDefinition>() : null;

        /// <summary>
        /// Gets and sets the property Categorical. 
        /// <para>
        ///  The categorical rating scale with named categories and definitions for qualitative
        /// evaluation. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<CategoricalScaleDefinition> Categorical
        {
            get { return this._categorical; }
            set { this._categorical = value; }
        }

        // Check to see if Categorical property is set
        internal bool IsSetCategorical()
        {
            return this._categorical != null && (this._categorical.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Numerical. 
        /// <para>
        ///  The numerical rating scale with defined score values and descriptions for quantitative
        /// evaluation. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<NumericalScaleDefinition> Numerical
        {
            get { return this._numerical; }
            set { this._numerical = value; }
        }

        // Check to see if Numerical property is set
        internal bool IsSetNumerical()
        {
            return this._numerical != null && (this._numerical.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}