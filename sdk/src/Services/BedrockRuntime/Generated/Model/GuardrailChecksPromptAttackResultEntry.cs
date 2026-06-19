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
 * Do not modify this file. This file is generated from the bedrock-runtime-2023-09-30.normal.json service model.
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
namespace Amazon.BedrockRuntime.Model
{
    /// <summary>
    /// The evaluation result for a single prompt attack category.
    /// </summary>
    public partial class GuardrailChecksPromptAttackResultEntry
    {
        private GuardrailChecksPromptAttackCategory _category;
        private double? _severityScore;

        /// <summary>
        /// Gets and sets the property Category. 
        /// <para>
        /// The prompt attack category that was evaluated.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public GuardrailChecksPromptAttackCategory Category
        {
            get { return this._category; }
            set { this._category = value; }
        }

        // Check to see if Category property is set
        internal bool IsSetCategory()
        {
            return this._category != null;
        }

        /// <summary>
        /// Gets and sets the property SeverityScore. 
        /// <para>
        /// The severity score for the category, ranging from 0.0 to 1.0. Higher values indicate
        /// greater severity.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=1)]
        public double? SeverityScore
        {
            get { return this._severityScore; }
            set { this._severityScore = value; }
        }

        // Check to see if SeverityScore property is set
        internal bool IsSetSeverityScore()
        {
            return this._severityScore.HasValue; 
        }

    }
}