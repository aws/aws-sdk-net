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
    /// The trace source a dataset generation was started with.
    /// </summary>
    public partial class TraceGenerationRecord
    {
        /// <summary>
        /// Gets and sets the property GroundTruth. 
        /// <para>
        /// The reference fields the generation copies into the examples. If the request didn't
        /// specify quality filters, the filters the generation applies are returned here.
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
        /// The sensitive data the generation masks in the examples.
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
        /// How many scenarios the generation produces.
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
        /// How the generation chooses sessions. Filters are returned as submitted, with the resolved
        /// maximum turn count. Session and trace IDs are returned as counts. If this is absent,
        /// the request had no selection.
        /// </para>
        /// </summary>
        public GenerationSelectionRecord Selection { get; set; }

        /// <summary>
        /// Checks to see if the Selection property is set.
        /// </summary>
        internal bool IsSetSelection() => this.Selection != null;

        /// <summary>
        /// Gets and sets the property SourceConfig. 
        /// <para>
        /// Where the generation reads sessions from, including the resolved time window.
        /// </para>
        /// </summary>
        public TraceSourceConfig SourceConfig { get; set; }

        /// <summary>
        /// Checks to see if the SourceConfig property is set.
        /// </summary>
        internal bool IsSetSourceConfig() => this.SourceConfig != null;
    }
}
