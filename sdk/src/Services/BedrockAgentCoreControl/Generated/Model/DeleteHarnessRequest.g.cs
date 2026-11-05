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

namespace Amazon.BedrockAgentCoreControl.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteHarness operation. Operation to delete a
    /// Harness.
    /// </summary>
    public partial class DeleteHarnessRequest : AmazonBedrockAgentCoreControlRequest
    {
        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier to ensure idempotency of the request.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 33, Max = 256)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property DeleteManagedMemory. 
        /// <para>
        /// Whether to delete the managed memory on harness deletion. Default: true. If false,
        /// the memory is disassociated and becomes a regular customer-owned resource.
        /// </para>
        /// </summary>
        public bool? DeleteManagedMemory { get; set; }

        /// <summary>
        /// Checks to see if the DeleteManagedMemory property is set.
        /// </summary>
        internal bool IsSetDeleteManagedMemory() => this.DeleteManagedMemory.HasValue;

        /// <summary>
        /// Gets and sets the property HarnessId. 
        /// <para>
        /// The ID of the harness to delete.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string HarnessId { get; set; }

        /// <summary>
        /// Checks to see if the HarnessId property is set.
        /// </summary>
        internal bool IsSetHarnessId() => this.HarnessId != null;
    }
}
