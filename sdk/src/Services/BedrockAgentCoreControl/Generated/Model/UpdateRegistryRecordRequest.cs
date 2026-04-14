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
 * Do not modify this file. This file is generated from the bedrock-agentcore-control-2023-06-05.normal.json service model.
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
    /// Container for the parameters to the UpdateRegistryRecord operation.
    /// Updates an existing registry record. This operation uses PATCH semantics, so you only
    /// need to specify the fields you want to change. The update is processed asynchronously
    /// and returns HTTP 202 Accepted.
    /// </summary>
    public partial class UpdateRegistryRecordRequest : AmazonBedrockAgentCoreControlRequest
    {
        private UpdatedDescription _description;
        private UpdatedDescriptors _descriptors;
        private DescriptorType _descriptorType;
        private string _name;
        private string _recordId;
        private string _recordVersion;
        private string _registryId;
        private UpdatedSynchronizationConfiguration _synchronizationConfiguration;
        private UpdatedSynchronizationType _synchronizationType;
        private bool? _triggerSynchronization;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The updated description for the registry record. To clear the description, include
        /// the <c>UpdatedDescription</c> wrapper with <c>optionalValue</c> not specified.
        /// </para>
        /// </summary>
        public UpdatedDescription Description
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
        /// Gets and sets the property Descriptors. 
        /// <para>
        /// The updated descriptor-type-specific configuration containing the resource schema
        /// and metadata. Uses PATCH semantics where individual descriptor fields can be updated
        /// independently.
        /// </para>
        /// </summary>
        public UpdatedDescriptors Descriptors
        {
            get { return this._descriptors; }
            set { this._descriptors = value; }
        }

        // Check to see if Descriptors property is set
        internal bool IsSetDescriptors()
        {
            return this._descriptors != null;
        }

        /// <summary>
        /// Gets and sets the property DescriptorType. 
        /// <para>
        /// The updated descriptor type for the registry record. Changing the descriptor type
        /// may require updating the <c>descriptors</c> field to match the new type's schema requirements.
        /// </para>
        /// </summary>
        public DescriptorType DescriptorType
        {
            get { return this._descriptorType; }
            set { this._descriptorType = value; }
        }

        // Check to see if DescriptorType property is set
        internal bool IsSetDescriptorType()
        {
            return this._descriptorType != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The updated name for the registry record.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
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
        /// Gets and sets the property RecordId. 
        /// <para>
        /// The identifier of the registry record to update. You can specify either the Amazon
        /// Resource Name (ARN) or the ID of the record.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
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
        /// Gets and sets the property RecordVersion. 
        /// <para>
        /// The version of the registry record for optimistic locking. If provided, it must match
        /// the current version of the record. The service automatically increments the version
        /// after a successful update.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
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
        /// Gets and sets the property RegistryId. 
        /// <para>
        /// The identifier of the registry containing the record. You can specify either the Amazon
        /// Resource Name (ARN) or the ID of the registry.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string RegistryId
        {
            get { return this._registryId; }
            set { this._registryId = value; }
        }

        // Check to see if RegistryId property is set
        internal bool IsSetRegistryId()
        {
            return this._registryId != null;
        }

        /// <summary>
        /// Gets and sets the property SynchronizationConfiguration. 
        /// <para>
        /// The updated synchronization configuration for the registry record.
        /// </para>
        /// </summary>
        public UpdatedSynchronizationConfiguration SynchronizationConfiguration
        {
            get { return this._synchronizationConfiguration; }
            set { this._synchronizationConfiguration = value; }
        }

        // Check to see if SynchronizationConfiguration property is set
        internal bool IsSetSynchronizationConfiguration()
        {
            return this._synchronizationConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property SynchronizationType. 
        /// <para>
        /// The updated synchronization type for the registry record.
        /// </para>
        /// </summary>
        public UpdatedSynchronizationType SynchronizationType
        {
            get { return this._synchronizationType; }
            set { this._synchronizationType = value; }
        }

        // Check to see if SynchronizationType property is set
        internal bool IsSetSynchronizationType()
        {
            return this._synchronizationType != null;
        }

        /// <summary>
        /// Gets and sets the property TriggerSynchronization. 
        /// <para>
        /// Whether to trigger synchronization using the stored or provided configuration. When
        /// set to <c>true</c>, the service will synchronize the record metadata from the configured
        /// external source.
        /// </para>
        /// </summary>
        public bool? TriggerSynchronization
        {
            get { return this._triggerSynchronization; }
            set { this._triggerSynchronization = value; }
        }

        // Check to see if TriggerSynchronization property is set
        internal bool IsSetTriggerSynchronization()
        {
            return this._triggerSynchronization.HasValue; 
        }

    }
}