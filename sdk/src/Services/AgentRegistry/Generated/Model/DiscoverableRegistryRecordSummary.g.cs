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

namespace Amazon.AgentRegistry.Model
{
    /// <summary>
    /// Summary information about a discoverable registry record returned by <c> ListDiscoverableRegistryRecords</c>.
    /// This summary does not include descriptors.
    /// </summary>
    public partial class DiscoverableRegistryRecordSummary
    {
        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        ///  The timestamp when the registry record was created.
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
        ///  A human-readable description of the registry record. Use this field to explain the
        /// record's purpose or content to consumers discovering it in the registry.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 4096)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property DescriptorTypes. 
        /// <para>
        ///  The descriptor types that are present on this registry record. Each value corresponds
        /// to a descriptor entry key on the approved record.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 10)]
        public List<string> DescriptorTypes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the DescriptorTypes property is set.
        /// </summary>
        internal bool IsSetDescriptorTypes() => this.DescriptorTypes != null && (this.DescriptorTypes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property DisplayName. 
        /// <para>
        ///  The human-readable display name of the registry record.
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
        ///  The name of the registry record. Names are unique within a registry.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property RecordArn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) of the registry record.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string RecordArn { get; set; }

        /// <summary>
        /// Checks to see if the RecordArn property is set.
        /// </summary>
        internal bool IsSetRecordArn() => this.RecordArn != null;

        /// <summary>
        /// Gets and sets the property RecordId. 
        /// <para>
        ///  The unique identifier of the registry record.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 12, Max = 12)]
        public string RecordId { get; set; }

        /// <summary>
        /// Checks to see if the RecordId property is set.
        /// </summary>
        internal bool IsSetRecordId() => this.RecordId != null;

        /// <summary>
        /// Gets and sets the property RecordType. 
        /// <para>
        ///  The type of the registry record. <c>MCP</c> is a Model Context Protocol server record,
        /// <c>AGENT</c> is an Agent-to-Agent (A2A) agent card record, <c>SKILL</c> is an agent
        /// skills definition record, and <c>CUSTOM</c> is a record with a custom descriptor.
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
        ///  The version identifier of the registry record.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string RecordVersion { get; set; }

        /// <summary>
        /// Checks to see if the RecordVersion property is set.
        /// </summary>
        internal bool IsSetRecordVersion() => this.RecordVersion != null;

        /// <summary>
        /// Gets and sets the property RegistryArn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) of the parent registry that owns the record.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 46, Max = 2048)]
        public string RegistryArn { get; set; }

        /// <summary>
        /// Checks to see if the RegistryArn property is set.
        /// </summary>
        internal bool IsSetRegistryArn() => this.RegistryArn != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        ///  The lifecycle status of the registry record. A record is <c>DRAFT</c> before it is
        /// submitted, <c>PENDING_APPROVAL</c> while awaiting curator review, and <c>APPROVED</c>
        /// once it is approved and discoverable. <c>REJECTED</c> and <c>DEPRECATED</c> records
        /// are not discoverable. The <c>CREATING</c>, <c>UPDATING</c>, <c>CREATE_FAILED</c>,
        /// and <c>UPDATE_FAILED</c> values reflect the state of an in-progress or failed asynchronous
        /// change.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public RegistryRecordStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        ///  The timestamp when the registry record was last updated.
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
