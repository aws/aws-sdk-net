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
    /// Settings for generating examples from your agent's traces.
    /// </summary>
    public partial class TraceGenerationSource
    {
        /// <summary>
        /// Gets and sets the property GroundTruth. 
        /// <para>
        /// Reference fields to copy from the sessions into the examples. If you don't specify
        /// this, the examples have no reference fields.
        /// </para>
        /// </summary>
        public GroundTruthConfig GroundTruth { get; set; }

        /// <summary>
        /// Checks to see if the GroundTruth property is set.
        /// </summary>
        internal bool IsSetGroundTruth() => this.GroundTruth != null;

        /// <summary>
        /// Gets and sets the property RedactionConfiguration. 
        /// <para>
        /// Sensitive data to mask in the examples. If you don't specify this, nothing is redacted.
        /// </para>
        /// </summary>
        public RedactionConfiguration RedactionConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the RedactionConfiguration property is set.
        /// </summary>
        internal bool IsSetRedactionConfiguration() => this.RedactionConfiguration != null;

        /// <summary>
        /// Gets and sets the property Sampling. 
        /// <para>
        /// How many scenarios to generate from the selected sessions.
        /// </para>
        /// </summary>
        public GenerationSamplingConfig Sampling { get; set; }

        /// <summary>
        /// Checks to see if the Sampling property is set.
        /// </summary>
        internal bool IsSetSampling() => this.Sampling != null;

        /// <summary>
        /// Gets and sets the property Selection. 
        /// <para>
        /// How to choose sessions from the source. If you don't specify a selection, the generation
        /// uses every session in the source and time window that has at most 100 turns.
        /// </para>
        /// </summary>
        public GenerationSelection Selection { get; set; }

        /// <summary>
        /// Checks to see if the Selection property is set.
        /// </summary>
        internal bool IsSetSelection() => this.Selection != null;

        /// <summary>
        /// Gets and sets the property SourceConfig. 
        /// <para>
        /// Where to read the sessions from.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public TraceSourceConfig SourceConfig { get; set; }

        /// <summary>
        /// Checks to see if the SourceConfig property is set.
        /// </summary>
        internal bool IsSetSourceConfig() => this.SourceConfig != null;
    }
}
