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
    /// The evaluation configuration for an A/B test, specifying which online evaluation configurations
    /// to use for measuring variant performance.
    /// </summary>
    public partial class ABTestEvaluationConfig
    {
        /// <summary>
        /// Gets and sets the property OnlineEvaluationConfigArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of a single online evaluation configuration to use
        /// for both variants.
        /// </para>
        /// </summary>
        public string OnlineEvaluationConfigArn { get; set; }

        /// <summary>
        /// Checks to see if the OnlineEvaluationConfigArn property is set.
        /// </summary>
        internal bool IsSetOnlineEvaluationConfigArn() => this.OnlineEvaluationConfigArn != null;

        /// <summary>
        /// Gets and sets the property PerVariantOnlineEvaluationConfig. 
        /// <para>
        /// Per-variant online evaluation configurations, allowing different evaluation settings
        /// for each variant.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 2, Max = 2)]
        public List<PerVariantOnlineEvaluationConfig> PerVariantOnlineEvaluationConfig { get; set; } = AWSConfigs.InitializeCollections ? new List<PerVariantOnlineEvaluationConfig>() : null;

        /// <summary>
        /// Checks to see if the PerVariantOnlineEvaluationConfig property is set.
        /// </summary>
        internal bool IsSetPerVariantOnlineEvaluationConfig() => this.PerVariantOnlineEvaluationConfig != null && (this.PerVariantOnlineEvaluationConfig.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
