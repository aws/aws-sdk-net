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
    /// The projected body of an artifact. The active member is selected by the artifact's
    /// artifactType, and for a type that carries more than one payload kind by the stored
    /// content's own discriminator; `raw` carries content for types with no defined shape
    /// yet and for content that did not match its shape.
    /// </summary>
    public partial class IssueArtifactBody
    {
        /// <summary>
        /// Gets and sets the property Patch. Projected PATCH content: the remediation patch for
        /// one repository, with the descriptors needed to verify and apply it and the state of
        /// its delivery to the customer's own bucket or repository. Every PATCH projects here.
        /// The descriptors come from members Control Plane computes or owns when it stores the
        /// patch, not from producer metadata, so this member is the whole PATCH contract and
        /// `metadata` is omitted for it.
        /// </summary>
        public PatchBody Patch { get; set; }

        /// <summary>
        /// Checks to see if the Patch property is set.
        /// </summary>
        internal bool IsSetPatch() => this.Patch != null;

        /// <summary>
        /// Gets and sets the property PrevalidationSignals. Projected EVIDENCE content whose
        /// stored envelope declares `artifact_kind: prevalidation_signals` — the severity signals
        /// prioritization uses. One artifactType can select different members here: EVIDENCE
        /// also carries the prioritization markdown narrative, which is not JSON and so returns
        /// through `raw`. The member is therefore chosen by artifactType AND, for a type that
        /// carries more than one payload kind, the content's own discriminator.
        /// </summary>
        public PrevalidationSignalsBody PrevalidationSignals { get; set; }

        /// <summary>
        /// Checks to see if the PrevalidationSignals property is set.
        /// </summary>
        internal bool IsSetPrevalidationSignals() => this.PrevalidationSignals != null;

        /// <summary>
        /// Gets and sets the property Raw. The producer's content verbatim, for an artifactType
        /// with no defined shape or content that failed to parse against its shape.
        /// </summary>
        [AWSProperty(Min = 1, Max = 5242880)]
        public string Raw { get; set; }

        /// <summary>
        /// Checks to see if the Raw property is set.
        /// </summary>
        internal bool IsSetRaw() => this.Raw != null;

        /// <summary>
        /// Gets and sets the property RemediationProposal. Projected REMEDIATION_PROPOSAL content:
        /// a patch the remediation agent produced, with the descriptors needed to apply and verify
        /// it. REMEDIATION_PROPOSAL content that does not match this shape is returned through
        /// `raw`.
        /// </summary>
        public RemediationProposalBody RemediationProposal { get; set; }

        /// <summary>
        /// Checks to see if the RemediationProposal property is set.
        /// </summary>
        internal bool IsSetRemediationProposal() => this.RemediationProposal != null;

        /// <summary>
        /// Gets and sets the property ValidationEvidence. Projected VALIDATION_EVIDENCE content.
        /// </summary>
        public ValidationEvidenceBody ValidationEvidence { get; set; }

        /// <summary>
        /// Checks to see if the ValidationEvidence property is set.
        /// </summary>
        internal bool IsSetValidationEvidence() => this.ValidationEvidence != null;
    }
}
