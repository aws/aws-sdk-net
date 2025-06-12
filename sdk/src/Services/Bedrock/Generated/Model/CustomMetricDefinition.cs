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
 * Do not modify this file. This file is generated from the bedrock-2023-04-20.normal.json service model.
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
namespace Amazon.Bedrock.Model
{
    /// <summary>
    /// The definition of a custom metric for use in an Amazon Bedrock evaluation job. A custom
    /// metric definition includes a metric name, prompt (instructions) and optionally, a
    /// rating scale. Your prompt must include a task description and input variables. The
    /// required input variables are different for model-as-a-judge and RAG evaluations.
    /// 
    ///  
    /// <para>
    /// For more information about how to define a custom metric in Amazon Bedrock, see <a
    /// href="https://docs.aws.amazon.com/bedrock/latest/userguide/model-evaluation-custom-metrics-prompt-formats.html">Create
    /// a prompt for a custom metrics (LLM-as-a-judge model evaluations)</a> and <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/kb-evaluation-custom-metrics-prompt-formats.html">Create
    /// a prompt for a custom metrics (RAG evaluations)</a>.
    /// </para>
    /// </summary>
    public partial class CustomMetricDefinition
    {
        private string _instructions;
        private string _name;
        private List<RatingScaleItem> _ratingScale = AWSConfigs.InitializeCollections ? new List<RatingScaleItem>() : null;

        /// <summary>
        /// Gets and sets the property Instructions. 
        /// <para>
        /// The prompt for a custom metric that instructs the evaluator model how to rate the
        /// model or RAG source under evaluation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=5000)]
        public string Instructions
        {
            get { return this._instructions; }
            set { this._instructions = value; }
        }

        // Check to see if Instructions property is set
        internal bool IsSetInstructions()
        {
            return this._instructions != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name for a custom metric. Names must be unique in your Amazon Web Services region.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=63)]
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
        /// Gets and sets the property RatingScale. 
        /// <para>
        /// Defines the rating scale to be used for a custom metric. We recommend that you always
        /// define a ratings scale when creating a custom metric. If you don't define a scale,
        /// Amazon Bedrock won't be able to visually display the results of the evaluation in
        /// the console or calculate average values of numerical scores. For more information
        /// on specifying a rating scale, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/model-evaluation-custom-metrics-prompt-formats.html#model-evaluation-custom-metrics-prompt-formats-schema">Specifying
        /// an output schema (rating scale)</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<RatingScaleItem> RatingScale
        {
            get { return this._ratingScale; }
            set { this._ratingScale = value; }
        }

        // Check to see if RatingScale property is set
        internal bool IsSetRatingScale()
        {
            return this._ratingScale != null && (this._ratingScale.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}