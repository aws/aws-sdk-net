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
    /// System-generated provenance for a memory or event: the owning actor and session, and
    /// the creation and last-update timestamps. <c>SearchMemories</c>, <c>SearchEvents</c>,
    /// <c>ListMemories</c>, and <c>GetMemory</c> return the same block.
    /// 
    ///  
    /// <para>
    ///  <c>ListMemories</c> and <c>GetMemory</c> always return <c>createdAt</c> and <c>updatedAt</c>.
    /// The search operations return what is recorded and omit the block when nothing is.
    /// </para>
    ///  
    /// <para>
    /// In a query, the timestamps are <c>system_metadata.created_at</c> and <c>system_metadata.updated_at</c>.
    /// Scope by owner with the top-level parameters (<c>actorId</c> on the search operations,
    /// <c>actorIds</c> on <c>ListMemories</c>) and <c>sessionIds</c> (<c>SearchEvents</c>
    /// and <c>ListMemories</c>). The search operations reject actor and session fields inside
    /// the query or sort.
    /// </para>
    /// </summary>
    public partial class SystemMetadata
    {
        /// <summary>
        /// Gets and sets the property ActorId. 
        /// <para>
        /// The owning actor. Absent when none was recorded.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string ActorId { get; set; }

        /// <summary>
        /// Checks to see if the ActorId property is set.
        /// </summary>
        internal bool IsSetActorId() => this.ActorId != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// When the record was created. Always present on <c>ListMemories</c> and <c>GetMemory</c>.
        /// It can be absent from search results.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property SessionId. 
        /// <para>
        /// The owning session. Absent when none was recorded.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string SessionId { get; set; }

        /// <summary>
        /// Checks to see if the SessionId property is set.
        /// </summary>
        internal bool IsSetSessionId() => this.SessionId != null;

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// When the record was last updated. Equals <c>createdAt</c> for a record that has never
        /// been updated, and always for a <c>SearchEvents</c> result.
        /// </para>
        /// </summary>
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;
    }
}
