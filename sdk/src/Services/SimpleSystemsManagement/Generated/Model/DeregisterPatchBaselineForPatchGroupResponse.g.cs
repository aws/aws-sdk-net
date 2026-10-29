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
    /// This is the response object from the DeregisterPatchBaselineForPatchGroup operation.
    /// </summary>
    public partial class DeregisterPatchBaselineForPatchGroupResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property BaselineId. 
        /// <para>
        /// The ID of the patch baseline the patch group was deregistered from.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 128)]
        public string BaselineId { get; set; }

        /// <summary>
        /// Checks to see if the BaselineId property is set.
        /// </summary>
        internal bool IsSetBaselineId() => this.BaselineId != null;

        /// <summary>
        /// Gets and sets the property PatchGroup. 
        /// <para>
        /// The name of the patch group deregistered from the patch baseline.
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
