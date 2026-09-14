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

namespace Amazon.AgentRegistryControl.Model
{
    /// <summary>
    /// Container for the parameters to the CreateRegistryRecord operation. Creates a registry
    /// record within a registry. A registry record describes a discoverable resource, such
    /// as an MCP server, an agent, an agent skill, or a custom resource. Creation is asynchronous:
    /// the record is returned with the CREATING status while it is processed.
    /// </summary>
    public partial class CreateRegistryRecordRequest : AmazonAgentRegistryControlRequest
    {
        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// Client token for idempotency
        /// </para>
        /// </summary>
        [AWSProperty(Min = 33, Max = 256)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the registry record
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 4096)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property Descriptors. 
        /// <para>
        /// The typed descriptor content for the registry record
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public Descriptors Descriptors { get; set; }

        /// <summary>
        /// Checks to see if the Descriptors property is set.
        /// </summary>
        internal bool IsSetDescriptors() => this.Descriptors != null;

        /// <summary>
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// The human-readable display name of the registry record
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Checks to see if the DisplayName property is set.
        /// </summary>
        internal bool IsSetDisplayName() => this.DisplayName != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the registry record
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Provenance.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 1)]
        public List<Provenance> Provenance { get; set; } = AWSConfigs.InitializeCollections ? new List<Provenance>() : null;

        /// <summary>
        /// Checks to see if the Provenance property is set.
        /// </summary>
        internal bool IsSetProvenance() => this.Provenance != null && (this.Provenance.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RecordType. 
        /// <para>
        /// The type of the registry record, which determines the descriptor format
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public RecordType RecordType { get; set; }

        /// <summary>
        /// Checks to see if the RecordType property is set.
        /// </summary>
        internal bool IsSetRecordType() => this.RecordType != null;

        /// <summary>
        /// Gets and sets the property RecordVersion. 
        /// <para>
        /// The version of the registry record
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string RecordVersion { get; set; }

        /// <summary>
        /// Checks to see if the RecordVersion property is set.
        /// </summary>
        internal bool IsSetRecordVersion() => this.RecordVersion != null;

        /// <summary>
        /// Gets and sets the property RegistryId. 
        /// <para>
        /// The identifier of the registry in which to create the record (ARN or ID)
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string RegistryId { get; set; }

        /// <summary>
        /// Checks to see if the RegistryId property is set.
        /// </summary>
        internal bool IsSetRegistryId() => this.RegistryId != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Tags to associate with the registry record
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
