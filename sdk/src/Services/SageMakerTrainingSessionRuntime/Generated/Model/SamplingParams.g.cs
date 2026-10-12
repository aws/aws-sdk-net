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

namespace Amazon.SageMakerTrainingSessionRuntime.Model
{
    /// <summary>
    /// The parameters controlling the text generation sampling strategy.
    /// </summary>
    public partial class SamplingParams
    {
        /// <summary>
        /// Gets and sets the property MaxTokens. 
        /// <para>
        /// The maximum number of tokens to generate per sample.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 512, Max = 131072)]
        public int? MaxTokens { get; set; }

        /// <summary>
        /// Checks to see if the MaxTokens property is set.
        /// </summary>
        internal bool IsSetMaxTokens() => this.MaxTokens.HasValue;

        /// <summary>
        /// Gets and sets the property Seed. 
        /// <para>
        /// The random seed for reproducible sampling. When set, the same seed with the same input
        /// produces deterministic outputs.
        /// </para>
        /// </summary>
        public int? Seed { get; set; }

        /// <summary>
        /// Checks to see if the Seed property is set.
        /// </summary>
        internal bool IsSetSeed() => this.Seed.HasValue;

        /// <summary>
        /// Gets and sets the property Stop. 
        /// <para>
        /// The list of stop sequences that terminate generation when encountered in the output.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Stop { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Stop property is set.
        /// </summary>
        internal bool IsSetStop() => this.Stop != null && (this.Stop.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Temperature. 
        /// <para>
        /// The sampling temperature controlling randomness. Higher values produce more diverse
        /// outputs.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2)]
        public double? Temperature { get; set; }

        /// <summary>
        /// Checks to see if the Temperature property is set.
        /// </summary>
        internal bool IsSetTemperature() => this.Temperature.HasValue;

        /// <summary>
        /// Gets and sets the property TopK. 
        /// <para>
        /// The number of highest-probability vocabulary tokens to keep for top-k filtering. Set
        /// to -1 to disable.
        /// </para>
        /// </summary>
        public int? TopK { get; set; }

        /// <summary>
        /// Checks to see if the TopK property is set.
        /// </summary>
        internal bool IsSetTopK() => this.TopK.HasValue;

        /// <summary>
        /// Gets and sets the property TopP. 
        /// <para>
        /// The cumulative probability threshold for nucleus (top-p) sampling. Only tokens with
        /// cumulative probability below this threshold are considered.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1)]
        public double? TopP { get; set; }

        /// <summary>
        /// Checks to see if the TopP property is set.
        /// </summary>
        internal bool IsSetTopP() => this.TopP.HasValue;
    }
}
