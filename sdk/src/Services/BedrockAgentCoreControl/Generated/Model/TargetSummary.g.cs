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
    /// Contains summary information about a gateway target. A target represents an endpoint
    /// that the gateway can connect to.
    /// </summary>
    public partial class TargetSummary
    {
        /// <summary>
        /// Gets and sets the property AuthorizationData.
        /// </summary>
        public AuthorizationData AuthorizationData { get; set; }

        /// <summary>
        /// Checks to see if the AuthorizationData property is set.
        /// </summary>
        internal bool IsSetAuthorizationData() => this.AuthorizationData != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp when the target was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the target.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 200)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property LastSynchronizedAt. 
        /// <para>
        /// The timestamp when the target was last synchronized.
        /// </para>
        /// </summary>
        public DateTime? LastSynchronizedAt { get; set; }

        /// <summary>
        /// Checks to see if the LastSynchronizedAt property is set.
        /// </summary>
        internal bool IsSetLastSynchronizedAt() => this.LastSynchronizedAt.HasValue;

        /// <summary>
        /// Gets and sets the property ListingMode. 
        /// <para>
        /// The listing mode for the target. MCP resources for <c>DEFAULT</c> targets are cached
        /// at the control plane for faster access. MCP resources for <c>DYNAMIC</c> targets are
        /// retrieved dynamically when listing tools.
        /// </para>
        /// </summary>
        public ListingMode ListingMode { get; set; }

        /// <summary>
        /// Checks to see if the ListingMode property is set.
        /// </summary>
        internal bool IsSetListingMode() => this.ListingMode != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the target.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property ResourcePriority. 
        /// <para>
        /// Priority for resolving resource URI conflicts across targets. Lower values take precedence.
        /// Defaults to 1000 when not set.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1000)]
        public int? ResourcePriority { get; set; }

        /// <summary>
        /// Checks to see if the ResourcePriority property is set.
        /// </summary>
        internal bool IsSetResourcePriority() => this.ResourcePriority.HasValue;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the target.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public TargetStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property TargetId. 
        /// <para>
        /// The unique identifier of the target.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string TargetId { get; set; }

        /// <summary>
        /// Checks to see if the TargetId property is set.
        /// </summary>
        internal bool IsSetTargetId() => this.TargetId != null;

        /// <summary>
        /// Gets and sets the property TargetType. 
        /// <para>
        /// The type of the target.
        /// </para>
        /// </summary>
        public TargetType TargetType { get; set; }

        /// <summary>
        /// Checks to see if the TargetType property is set.
        /// </summary>
        internal bool IsSetTargetType() => this.TargetType != null;

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The timestamp when the target was last updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;
    }
}
