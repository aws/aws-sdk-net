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

namespace Amazon.DevOpsAgent.Model
{
    /// <summary>
    /// Represents a service association within an AgentSpace, defining how the agent interacts
    /// with external services.
    /// </summary>
    public partial class Association
    {
        /// <summary>
        /// Gets and sets the property AgentSpaceId. 
        /// <para>
        /// The unique identifier of the AgentSpace
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string AgentSpaceId { get; set; }

        /// <summary>
        /// Checks to see if the AgentSpaceId property is set.
        /// </summary>
        internal bool IsSetAgentSpaceId() => this.AgentSpaceId != null;

        /// <summary>
        /// Gets and sets the property AssociationId. 
        /// <para>
        /// The unique identifier of the given association.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string AssociationId { get; set; }

        /// <summary>
        /// Checks to see if the AssociationId property is set.
        /// </summary>
        internal bool IsSetAssociationId() => this.AssociationId != null;

        /// <summary>
        /// Gets and sets the property Capabilities. 
        /// <para>
        /// Enabled capabilities for this association.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, CapabilityConfiguration> Capabilities { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, CapabilityConfiguration>() : null;

        /// <summary>
        /// Checks to see if the Capabilities property is set.
        /// </summary>
        internal bool IsSetCapabilities() => this.Capabilities != null && (this.Capabilities.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Configuration. 
        /// <para>
        /// The configuration that directs how AgentSpace interacts with the given service.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ServiceConfiguration Configuration { get; set; }

        /// <summary>
        /// Checks to see if the Configuration property is set.
        /// </summary>
        internal bool IsSetConfiguration() => this.Configuration != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp when the resource was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property ServiceId. 
        /// <para>
        /// The identifier for associated service
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string ServiceId { get; set; }

        /// <summary>
        /// Checks to see if the ServiceId property is set.
        /// </summary>
        internal bool IsSetServiceId() => this.ServiceId != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Validation status
        /// </para>
        /// </summary>
        public ValidationStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The timestamp when the resource was last updated.
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
