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
    /// A single dimension of an LLM-as-a-judge evaluator, defining what the evaluator model
    /// should judge for that dimension and how it should be scored.
    /// </summary>
    public partial class EvaluationDimension
    {
        private string _dimensionInstruction;
        private string _dimensionName;
        private DimensionRatingScale _dimensionRatingScale;

        /// <summary>
        /// Gets and sets the property DimensionInstruction. 
        /// <para>
        ///  The instruction to the evaluator model for this dimension, describing what the model
        /// should judge when scoring the dimension. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=4000)]
        public string DimensionInstruction
        {
            get { return this._dimensionInstruction; }
            set { this._dimensionInstruction = value; }
        }

        // Check to see if DimensionInstruction property is set
        internal bool IsSetDimensionInstruction()
        {
            return this._dimensionInstruction != null;
        }

        /// <summary>
        /// Gets and sets the property DimensionName. 
        /// <para>
        ///  The name of the dimension. This name is unique within the evaluator and identifies
        /// the dimension's results. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DimensionName
        {
            get { return this._dimensionName; }
            set { this._dimensionName = value; }
        }

        // Check to see if DimensionName property is set
        internal bool IsSetDimensionName()
        {
            return this._dimensionName != null;
        }

        /// <summary>
        /// Gets and sets the property DimensionRatingScale. 
        /// <para>
        ///  The rating scale for this dimension, which can be numerical or categorical. A dimension's
        /// rating scale cannot itself be multi-dimensional. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true)]
        public DimensionRatingScale DimensionRatingScale
        {
            get { return this._dimensionRatingScale; }
            set { this._dimensionRatingScale = value; }
        }

        // Check to see if DimensionRatingScale property is set
        internal bool IsSetDimensionRatingScale()
        {
            return this._dimensionRatingScale != null;
        }

    }
}