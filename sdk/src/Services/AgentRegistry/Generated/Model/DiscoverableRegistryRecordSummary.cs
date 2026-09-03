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
 * Do not modify this file. This file is generated from the agent-registry-2025-12-01.normal.json service model.
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
        private DateTime? _createdAt;
        private string _description;
        private List<string> _descriptorTypes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _displayName;
        private string _name;
        private string _recordArn;
        private string _recordId;
        private RecordType _recordType;
        private string _recordVersion;
        private string _registryArn;
        private RegistryRecordStatus _status;
        private DateTime? _updatedAt;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        ///  The timestamp when the registry record was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        ///  A human-readable description of the registry record. Use this field to explain the
        /// record's purpose or content to consumers discovering it in the registry.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=4096)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property DescriptorTypes. 
        /// <para>
        ///  The descriptor types that are present on this registry record. Each value corresponds
        /// to a descriptor entry key on the approved record.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=10)]
        public List<string> DescriptorTypes
        {
            get { return this._descriptorTypes; }
            set { this._descriptorTypes = value; }
        }

        // Check to see if DescriptorTypes property is set
        internal bool IsSetDescriptorTypes()
        {
            return this._descriptorTypes != null && (this._descriptorTypes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property DisplayName. 
        /// <para>
        ///  The human-readable display name of the registry record.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string DisplayName
        {
            get { return this._displayName; }
            set { this._displayName = value; }
        }

        // Check to see if DisplayName property is set
        internal bool IsSetDisplayName()
        {
            return this._displayName != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        ///  The name of the registry record. Names are unique within a registry.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property RecordArn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) of the registry record.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string RecordArn
        {
            get { return this._recordArn; }
            set { this._recordArn = value; }
        }

        // Check to see if RecordArn property is set
        internal bool IsSetRecordArn()
        {
            return this._recordArn != null;
        }

        /// <summary>
        /// Gets and sets the property RecordId. 
        /// <para>
        ///  The unique identifier of the registry record.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=12, Max=12)]
        public string RecordId
        {
            get { return this._recordId; }
            set { this._recordId = value; }
        }

        // Check to see if RecordId property is set
        internal bool IsSetRecordId()
        {
            return this._recordId != null;
        }

        /// <summary>
        /// Gets and sets the property RecordType. 
        /// <para>
        ///  The type of the registry record. <c>MCP</c> is a Model Context Protocol server record,
        /// <c>AGENT</c> is an Agent-to-Agent (A2A) agent card record, <c>SKILL</c> is an agent
        /// skills definition record, and <c>CUSTOM</c> is a record with a custom descriptor.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RecordType RecordType
        {
            get { return this._recordType; }
            set { this._recordType = value; }
        }

        // Check to see if RecordType property is set
        internal bool IsSetRecordType()
        {
            return this._recordType != null;
        }

        /// <summary>
        /// Gets and sets the property RecordVersion. 
        /// <para>
        ///  The version identifier of the registry record.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string RecordVersion
        {
            get { return this._recordVersion; }
            set { this._recordVersion = value; }
        }

        // Check to see if RecordVersion property is set
        internal bool IsSetRecordVersion()
        {
            return this._recordVersion != null;
        }

        /// <summary>
        /// Gets and sets the property RegistryArn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) of the parent registry that owns the record.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=46, Max=2048)]
        public string RegistryArn
        {
            get { return this._registryArn; }
            set { this._registryArn = value; }
        }

        // Check to see if RegistryArn property is set
        internal bool IsSetRegistryArn()
        {
            return this._registryArn != null;
        }

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
        [AWSProperty(Required=true)]
        public RegistryRecordStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        ///  The timestamp when the registry record was last updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? UpdatedAt
        {
            get { return this._updatedAt; }
            set { this._updatedAt = value; }
        }

        // Check to see if UpdatedAt property is set
        internal bool IsSetUpdatedAt()
        {
            return this._updatedAt.HasValue; 
        }

    }
}