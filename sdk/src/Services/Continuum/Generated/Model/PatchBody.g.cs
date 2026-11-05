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
    /// Projected content for a PATCH artifact: the remediation patch for one repository,
    /// with the descriptors needed to verify and apply it and the state of its delivery to
    /// the customer's own bucket or repository.
    /// </summary>
    public partial class PatchBody
    {
        /// <summary>
        /// Gets and sets the property Delivery. Delivery of the patch to the customer's bucket
        /// or repository. Absent when the artifact has no delivery destination.
        /// </summary>
        public PatchDelivery Delivery { get; set; }

        /// <summary>
        /// Checks to see if the Delivery property is set.
        /// </summary>
        internal bool IsSetDelivery() => this.Delivery != null;

        /// <summary>
        /// Gets and sets the property Format. The patch's wire format, read from the patch itself,
        /// which determines how to apply it. Absent when the patch starts with neither a git
        /// mailbox header nor a `diff --git` header.
        /// </summary>
        public PatchFormat Format { get; set; }

        /// <summary>
        /// Checks to see if the Format property is set.
        /// </summary>
        internal bool IsSetFormat() => this.Format != null;

        /// <summary>
        /// Gets and sets the property Patch. The patch exactly as stored, unmodified. Control
        /// Plane accepted it only as a text unified diff, so `git apply` applies it.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 5242880)]
        public string Patch { get; set; }

        /// <summary>
        /// Checks to see if the Patch property is set.
        /// </summary>
        internal bool IsSetPatch() => this.Patch != null;

        /// <summary>
        /// Gets and sets the property PatchSha256. SHA-256 of the patch's UTF-8 bytes in lowercase
        /// hex, computed by Control Plane when it stored the patch. Lets a caller confirm the
        /// patch it applies is byte-for-byte the one that was reviewed. Computed over the patch
        /// bytes, so it is verifiable against `patch` without trusting this value.
        /// </summary>
        [AWSProperty(Required = true, Min = 64, Max = 64)]
        public string PatchSha256 { get; set; }

        /// <summary>
        /// Checks to see if the PatchSha256 property is set.
        /// </summary>
        internal bool IsSetPatchSha256() => this.PatchSha256 != null;

        /// <summary>
        /// Gets and sets the property RepositoryName. The repository the patch applies to, as
        /// named in the source snapshot it was generated against.
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string RepositoryName { get; set; }

        /// <summary>
        /// Checks to see if the RepositoryName property is set.
        /// </summary>
        internal bool IsSetRepositoryName() => this.RepositoryName != null;

        /// <summary>
        /// Gets and sets the property SizeBytes. Size of the patch in UTF-8 bytes, the unit the
        /// digest is computed over.
        /// </summary>
        [AWSProperty(Required = true)]
        public long? SizeBytes { get; set; }

        /// <summary>
        /// Checks to see if the SizeBytes property is set.
        /// </summary>
        internal bool IsSetSizeBytes() => this.SizeBytes.HasValue;
    }
}
