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

namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// The <c>EffectivePatch</c> structure defines metadata about a patch along with the
    /// approval state of the patch in a particular patch baseline. The approval state includes
    /// information about whether the patch is currently approved, due to be approved by a
    /// rule, explicitly approved, or explicitly rejected and the date the patch was or will
    /// be approved.
    /// </summary>
    public partial class EffectivePatch
    {
        /// <summary>
        /// Gets and sets the property Patch. 
        /// <para>
        /// Provides metadata for a patch, including information such as the KB ID, severity,
        /// classification and a URL for where more information can be obtained about the patch.
        /// </para>
        /// </summary>
        public Patch Patch { get; set; }

        /// <summary>
        /// Checks to see if the Patch property is set.
        /// </summary>
        internal bool IsSetPatch() => this.Patch != null;

        /// <summary>
        /// Gets and sets the property PatchStatus. 
        /// <para>
        /// The status of the patch in a patch baseline. This includes information about whether
        /// the patch is currently approved, due to be approved by a rule, explicitly approved,
        /// or explicitly rejected and the date the patch was or will be approved.
        /// </para>
        /// </summary>
        public PatchStatus PatchStatus { get; set; }

        /// <summary>
        /// Checks to see if the PatchStatus property is set.
        /// </summary>
        internal bool IsSetPatchStatus() => this.PatchStatus != null;
    }
}
