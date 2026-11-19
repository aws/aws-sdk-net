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

namespace Amazon.BedrockAgentCore.Model
{
    /// <summary>
    /// Reference fields to copy from the sessions into the generated examples.
    /// </summary>
    public partial class GroundTruthConfig
    {
        /// <summary>
        /// Gets and sets the property Fields. 
        /// <para>
        /// The reference fields to copy. Values are copied from the session as observed, not
        /// generated.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2)]
        public List<string> Fields { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Fields property is set.
        /// </summary>
        internal bool IsSetFields() => this.Fields != null && (this.Fields.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property QualityFilters. 
        /// <para>
        /// Evaluator conditions that a selected session must also meet to have reference fields
        /// copied. If you don't specify these, the generation uses the evaluator filters from
        /// <c>selection</c>. If the selection names sessions and traces by ID, every selected
        /// session gets reference fields. Specify an empty list to give every selected session
        /// reference fields. You can't specify quality filters with a <c>cloudWatchLogs</c> source.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 10)]
        public List<EvaluatorFilter> QualityFilters { get; set; } = AWSConfigs.InitializeCollections ? new List<EvaluatorFilter>() : null;

        /// <summary>
        /// Checks to see if the QualityFilters property is set.
        /// </summary>
        internal bool IsSetQualityFilters() => this.QualityFilters != null && (this.QualityFilters.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
