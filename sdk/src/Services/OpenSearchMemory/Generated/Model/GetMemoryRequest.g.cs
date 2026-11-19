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

namespace Amazon.OpenSearchMemory.Model
{
    /// <summary>
    /// Container for the parameters to the GetMemory operation. Gets a memory by ID, as returned
    /// by <c>SearchMemories</c> or <c>ListMemories</c>. A memory that doesn't exist returns
    /// <c>ResourceNotFoundException</c>. Unlike <c>SearchMemories</c>, this operation also
    /// returns memories that consolidation has superseded. <para> A memory past its expiry
    /// (set from the space's <c>memoryExpiryDays</c> when the memory is written) reads as
    /// not found: <c>ResourceNotFoundException</c>, the same answer as for an ID that does
    /// not exist. </para> <para> If the space uses a customer managed AWS KMS key, the call
    /// can also fail because of the key. It fails with <c>AccessDeniedException</c> if you
    /// aren't allowed to use the key, and with <c>ThrottlingException</c> if AWS KMS throttles
    /// the request. It fails with <c>ValidationException</c> if the key is disabled, pending
    /// deletion, or deleted. </para>
    /// </summary>
    public partial class GetMemoryRequest : AmazonOpenSearchMemoryRequest
    {
        /// <summary>
        /// Gets and sets the property ActorId. 
        /// <para>
        /// The ID of the actor the memory must belong to. Omit it to skip this check. If it doesn't
        /// match the stored memory, the call fails with <c>ResourceNotFoundException</c>, as
        /// if the memory did not exist.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string ActorId { get; set; }

        /// <summary>
        /// Checks to see if the ActorId property is set.
        /// </summary>
        internal bool IsSetActorId() => this.ActorId != null;

        /// <summary>
        /// Gets and sets the property MemoryId. 
        /// <para>
        /// The memory's ID, as returned by <c>SearchMemories</c> or <c>ListMemories</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string MemoryId { get; set; }

        /// <summary>
        /// Checks to see if the MemoryId property is set.
        /// </summary>
        internal bool IsSetMemoryId() => this.MemoryId != null;

        /// <summary>
        /// Gets and sets the property SpaceId. 
        /// <para>
        /// The ID of the space that holds the memory.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string SpaceId { get; set; }

        /// <summary>
        /// Checks to see if the SpaceId property is set.
        /// </summary>
        internal bool IsSetSpaceId() => this.SpaceId != null;

        /// <summary>
        /// Gets and sets the property StrategyName. 
        /// <para>
        /// The name of the strategy the memory must belong to. Omit it to skip this check. If
        /// it doesn't match the stored memory, the call fails with <c>ResourceNotFoundException</c>,
        /// as if the memory did not exist.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string StrategyName { get; set; }

        /// <summary>
        /// Checks to see if the StrategyName property is set.
        /// </summary>
        internal bool IsSetStrategyName() => this.StrategyName != null;
    }
}
