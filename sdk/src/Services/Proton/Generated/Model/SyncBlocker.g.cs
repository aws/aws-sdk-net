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

namespace Amazon.Proton.Model
{
    /// <summary>
    /// Detailed data of the sync blocker.
    /// </summary>
    public partial class SyncBlocker
    {
        /// <summary>
        /// Gets and sets the property Contexts. 
        /// <para>
        /// The contexts for the sync blocker.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<SyncBlockerContext> Contexts { get; set; } = AWSConfigs.InitializeCollections ? new List<SyncBlockerContext>() : null;

        /// <summary>
        /// Checks to see if the Contexts property is set.
        /// </summary>
        internal bool IsSetContexts() => this.Contexts != null && (this.Contexts.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The time when the sync blocker was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property CreatedReason. 
        /// <para>
        /// The reason why the sync blocker was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string CreatedReason { get; set; }

        /// <summary>
        /// Checks to see if the CreatedReason property is set.
        /// </summary>
        internal bool IsSetCreatedReason() => this.CreatedReason != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID of the sync blocker.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property ResolvedAt. 
        /// <para>
        /// The time the sync blocker was resolved.
        /// </para>
        /// </summary>
        public DateTime? ResolvedAt { get; set; }

        /// <summary>
        /// Checks to see if the ResolvedAt property is set.
        /// </summary>
        internal bool IsSetResolvedAt() => this.ResolvedAt.HasValue;

        /// <summary>
        /// Gets and sets the property ResolvedReason. 
        /// <para>
        /// The reason the sync blocker was resolved.
        /// </para>
        /// </summary>
        public string ResolvedReason { get; set; }

        /// <summary>
        /// Checks to see if the ResolvedReason property is set.
        /// </summary>
        internal bool IsSetResolvedReason() => this.ResolvedReason != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the sync blocker.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public BlockerStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of the sync blocker.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public BlockerType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
