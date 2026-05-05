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
 * Do not modify this file. This file is generated from the bedrock-agentcore-2024-02-28.normal.json service model.
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
namespace Amazon.BedrockAgentCore.Model
{
    /// <summary>
    /// Statistical metrics for a single evaluator comparing control and treatment variants.
    /// </summary>
    public partial class EvaluatorMetric
    {
        private ControlStats _controlStats;
        private string _evaluatorArn;
        private List<VariantResult> _variantResults = AWSConfigs.InitializeCollections ? new List<VariantResult>() : null;

        /// <summary>
        /// Gets and sets the property ControlStats. 
        /// <para>
        /// The statistics for the control variant.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ControlStats ControlStats
        {
            get { return this._controlStats; }
            set { this._controlStats = value; }
        }

        // Check to see if ControlStats property is set
        internal bool IsSetControlStats()
        {
            return this._controlStats != null;
        }

        /// <summary>
        /// Gets and sets the property EvaluatorArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the evaluator.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string EvaluatorArn
        {
            get { return this._evaluatorArn; }
            set { this._evaluatorArn = value; }
        }

        // Check to see if EvaluatorArn property is set
        internal bool IsSetEvaluatorArn()
        {
            return this._evaluatorArn != null;
        }

        /// <summary>
        /// Gets and sets the property VariantResults. 
        /// <para>
        /// The results for each treatment variant compared against the control.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<VariantResult> VariantResults
        {
            get { return this._variantResults; }
            set { this._variantResults = value; }
        }

        // Check to see if VariantResults property is set
        internal bool IsSetVariantResults()
        {
            return this._variantResults != null && (this._variantResults.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}