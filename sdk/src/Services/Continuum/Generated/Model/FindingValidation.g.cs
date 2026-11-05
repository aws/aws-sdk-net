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
    /// A validator's assessment of a finding. Present only when validation actually ran --
    /// absent for finding types that are ingested untested, rather than reporting a verdict
    /// Continuum did not reach.
    /// </summary>
    public partial class FindingValidation
    {
        /// <summary>
        /// Gets and sets the property BlockingReason. Why the validator reached that verdict.
        /// </summary>
        public FindingBlockingReason BlockingReason { get; set; }

        /// <summary>
        /// Checks to see if the BlockingReason property is set.
        /// </summary>
        internal bool IsSetBlockingReason() => this.BlockingReason != null;

        /// <summary>
        /// Gets and sets the property Confidence. The validator's confidence, from 0.0 to 1.0
        /// inclusive. Advisory: it does not drive Continuum's own routing decisions. The range
        /// is enforced server-side, not by a @range trait -- the smithy-rs server SDK does not
        /// support range constraints on double shapes (smithy-rs#2007).
        /// </summary>
        public double? Confidence { get; set; }

        /// <summary>
        /// Checks to see if the Confidence property is set.
        /// </summary>
        internal bool IsSetConfidence() => this.Confidence.HasValue;

        /// <summary>
        /// Gets and sets the property Evidence. Code citations supporting the verdict.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 64)]
        public List<FindingEvidence> Evidence { get; set; } = AWSConfigs.InitializeCollections ? new List<FindingEvidence>() : null;

        /// <summary>
        /// Checks to see if the Evidence property is set.
        /// </summary>
        internal bool IsSetEvidence() => this.Evidence != null && (this.Evidence.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property MitigatingControls. Controls the validator found that reduce
        /// exploitability.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public List<string> MitigatingControls { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the MitigatingControls property is set.
        /// </summary>
        internal bool IsSetMitigatingControls() => this.MitigatingControls != null && (this.MitigatingControls.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Preconditions. Conditions exploitation depends on, which
        /// bound the severity.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public List<string> Preconditions { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Preconditions property is set.
        /// </summary>
        internal bool IsSetPreconditions() => this.Preconditions != null && (this.Preconditions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Rationale. The validator's reasoning.
        /// </summary>
        [AWSProperty(Min = 1, Max = 65536)]
        public string Rationale { get; set; }

        /// <summary>
        /// Checks to see if the Rationale property is set.
        /// </summary>
        internal bool IsSetRationale() => this.Rationale != null;

        /// <summary>
        /// Gets and sets the property SeverityAdjustment. The validator's severity conclusion.
        /// </summary>
        public FindingSeverityAdjustment SeverityAdjustment { get; set; }

        /// <summary>
        /// Checks to see if the SeverityAdjustment property is set.
        /// </summary>
        internal bool IsSetSeverityAdjustment() => this.SeverityAdjustment != null;

        /// <summary>
        /// Gets and sets the property Verdict. The validator's conclusion.
        /// </summary>
        [AWSProperty(Required = true)]
        public FindingVerdict Verdict { get; set; }

        /// <summary>
        /// Checks to see if the Verdict property is set.
        /// </summary>
        internal bool IsSetVerdict() => this.Verdict != null;
    }
}
