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
    /// Projected content for a REMEDIATION_PROPOSAL artifact: the patch the remediation agent
    /// produced, with the descriptors needed to apply and verify it.
    /// </summary>
    public partial class RemediationProposalBody
    {
        /// <summary>
        /// Gets and sets the property Filename. Filename the producer suggests for the patch,
        /// when it named one.
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string Filename { get; set; }

        /// <summary>
        /// Checks to see if the Filename property is set.
        /// </summary>
        internal bool IsSetFilename() => this.Filename != null;

        /// <summary>
        /// Gets and sets the property Format. The patch's wire format, which determines how to
        /// apply it. Absent when the producer recorded a format with no mapping yet.
        /// </summary>
        public PatchFormat Format { get; set; }

        /// <summary>
        /// Checks to see if the Format property is set.
        /// </summary>
        internal bool IsSetFormat() => this.Format != null;

        /// <summary>
        /// Gets and sets the property Patch. The patch exactly as the remediation agent produced
        /// it, unmodified.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 5242880)]
        public string Patch { get; set; }

        /// <summary>
        /// Checks to see if the Patch property is set.
        /// </summary>
        internal bool IsSetPatch() => this.Patch != null;

        /// <summary>
        /// Gets and sets the property PatchSha256. SHA-256 of the patch bytes in lowercase hex,
        /// as recorded by the producer. Lets a caller confirm the patch it applies is byte-for-byte
        /// the one that was reviewed. Computed over the patch bytes, so it is verifiable against
        /// `patch` without trusting this value.
        /// </summary>
        [AWSProperty(Min = 64, Max = 64)]
        public string PatchSha256 { get; set; }

        /// <summary>
        /// Checks to see if the PatchSha256 property is set.
        /// </summary>
        internal bool IsSetPatchSha256() => this.PatchSha256 != null;
    }
}
