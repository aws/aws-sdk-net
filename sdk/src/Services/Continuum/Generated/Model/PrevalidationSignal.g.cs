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

namespace Amazon.Continuum.Model
{
    /// <summary>
    /// One producer's conclusion about one subject on one scoring dimension.
    /// </summary>
    public partial class PrevalidationSignal
    {
        /// <summary>
        /// Gets and sets the property Computed. The deterministic values the producer computed
        /// from its assessment.
        /// </summary>
        public SignalComputation Computed { get; set; }

        /// <summary>
        /// Checks to see if the Computed property is set.
        /// </summary>
        internal bool IsSetComputed() => this.Computed != null;

        /// <summary>
        /// Gets and sets the property Conclusion. The producer's conclusion.
        /// </summary>
        [AWSProperty(Min = 1, Max = 8192)]
        public string Conclusion { get; set; }

        /// <summary>
        /// Checks to see if the Conclusion property is set.
        /// </summary>
        internal bool IsSetConclusion() => this.Conclusion != null;

        /// <summary>
        /// Gets and sets the property Confidence. The producer's confidence in this conclusion,
        /// on its native 0-1 scale. Absent when the stored value falls outside 0-1.
        /// </summary>
        public double? Confidence { get; set; }

        /// <summary>
        /// Checks to see if the Confidence property is set.
        /// </summary>
        internal bool IsSetConfidence() => this.Confidence.HasValue;

        /// <summary>
        /// Gets and sets the property ConfidenceReasoning. Why the producer is or is not sure,
        /// kept structured rather than prose.
        /// </summary>
        public SignalConfidenceReasoning ConfidenceReasoning { get; set; }

        /// <summary>
        /// Checks to see if the ConfidenceReasoning property is set.
        /// </summary>
        internal bool IsSetConfidenceReasoning() => this.ConfidenceReasoning != null;

        /// <summary>
        /// Gets and sets the property Dimension. The axis this signal speaks to. Absent when
        /// the producer reported a dimension with no mapping yet.
        /// </summary>
        public SignalDimension Dimension { get; set; }

        /// <summary>
        /// Checks to see if the Dimension property is set.
        /// </summary>
        internal bool IsSetDimension() => this.Dimension != null;

        /// <summary>
        /// Gets and sets the property Exploitability. What validation established about exploitability,
        /// on an exploitability signal. This summarizes the verdict the signal was derived from;
        /// the proof itself is the VALIDATION_EVIDENCE artifact it cites.
        /// </summary>
        public SignalExploitability Exploitability { get; set; }

        /// <summary>
        /// Checks to see if the Exploitability property is set.
        /// </summary>
        internal bool IsSetExploitability() => this.Exploitability != null;

        /// <summary>
        /// Gets and sets the property ImpactDimensions. The three impact dimensions an impact
        /// signal assessed, each with the basis the producer had for it. These are what the computed
        /// impact band is derived from.
        /// </summary>
        public SignalImpactDimensions ImpactDimensions { get; set; }

        /// <summary>
        /// Checks to see if the ImpactDimensions property is set.
        /// </summary>
        internal bool IsSetImpactDimensions() => this.ImpactDimensions != null;

        /// <summary>
        /// Gets and sets the property Preconditions. The four exploit preconditions a likelihood
        /// signal assessed, each with the basis the producer had for it.
        /// </summary>
        public SignalPreconditions Preconditions { get; set; }

        /// <summary>
        /// Checks to see if the Preconditions property is set.
        /// </summary>
        internal bool IsSetPreconditions() => this.Preconditions != null;

        /// <summary>
        /// Gets and sets the property ProducerId. Stable name of the producer that emitted this
        /// signal.
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string ProducerId { get; set; }

        /// <summary>
        /// Checks to see if the ProducerId property is set.
        /// </summary>
        internal bool IsSetProducerId() => this.ProducerId != null;

        /// <summary>
        /// Gets and sets the property ProducerVersion. Version of that producer.
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string ProducerVersion { get; set; }

        /// <summary>
        /// Checks to see if the ProducerVersion property is set.
        /// </summary>
        internal bool IsSetProducerVersion() => this.ProducerVersion != null;

        /// <summary>
        /// Gets and sets the property SignalStrength. The signal's own rating. This is an input
        /// to scoring and is NOT the finding's severity.
        /// </summary>
        public SignalStrength SignalStrength { get; set; }

        /// <summary>
        /// Checks to see if the SignalStrength property is set.
        /// </summary>
        internal bool IsSetSignalStrength() => this.SignalStrength != null;

        /// <summary>
        /// Gets and sets the property SubjectRef. What this signal is about, such as a finding
        /// or issue reference.
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string SubjectRef { get; set; }

        /// <summary>
        /// Checks to see if the SubjectRef property is set.
        /// </summary>
        internal bool IsSetSubjectRef() => this.SubjectRef != null;
    }
}
