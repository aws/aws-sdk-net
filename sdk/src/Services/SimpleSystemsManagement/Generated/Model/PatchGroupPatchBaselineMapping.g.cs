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
    /// The mapping between a patch group and the patch baseline the patch group is registered
    /// with.
    /// </summary>
    public partial class PatchGroupPatchBaselineMapping
    {
        /// <summary>
        /// Gets and sets the property BaselineIdentity. 
        /// <para>
        /// The patch baseline the patch group is registered with.
        /// </para>
        /// </summary>
        public PatchBaselineIdentity BaselineIdentity { get; set; }

        /// <summary>
        /// Checks to see if the BaselineIdentity property is set.
        /// </summary>
        internal bool IsSetBaselineIdentity() => this.BaselineIdentity != null;

        /// <summary>
        /// Gets and sets the property PatchGroup. 
        /// <para>
        /// The name of the patch group registered with the patch baseline.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string PatchGroup { get; set; }

        /// <summary>
        /// Checks to see if the PatchGroup property is set.
        /// </summary>
        internal bool IsSetPatchGroup() => this.PatchGroup != null;
    }
}
