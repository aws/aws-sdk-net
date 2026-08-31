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
 * Do not modify this file. This file is generated from the agent-registry-control-2025-12-01.normal.json service model.
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
    /// Container for the parameters to the UpdateRegistryRecord operation.
    /// Updates a registry record. The update is asynchronous: the record is returned with
    /// the UPDATING status while it is processed. Fields that use update wrappers follow
    /// PATCH semantics: omit the field to leave it unchanged.
    /// </summary>
    public partial class UpdateRegistryRecordRequest : AmazonAgentRegistryControlRequest
    {
        private UpdatedDescription _description;
        private UpdatedDescriptors _descriptors;
        private UpdatedDisplayName _displayName;
        private string _name;
        private List<Provenance> _provenance = AWSConfigs.InitializeCollections ? new List<Provenance>() : null;
        private string _recordId;
        private RecordType _recordType;
        private string _recordVersion;
        private string _registryId;
        private bool? _triggerSynchronization;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The updated description of the registry record. Omit to leave the description unchanged;
        /// provide an empty wrapper to unset it.
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
        /// The updated typed descriptor content for the registry record. Omit to leave the descriptors
        /// unchanged.
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
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// The updated display name of the registry record. Omit to leave the display name unchanged;
        /// provide an empty wrapper to unset it.
        /// </para>
        /// </summary>
        public UpdatedDisplayName DisplayName
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
        /// The updated name of the registry record. Omit to leave the name unchanged.
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
        /// Gets and sets the property Provenance.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=1)]
        public List<Provenance> Provenance
        {
            get { return this._provenance; }
            set { this._provenance = value; }
        }

        // Check to see if Provenance property is set
        internal bool IsSetProvenance()
        {
            return this._provenance != null && (this._provenance.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RecordId. 
        /// <para>
        /// The identifier of the registry record to update (ARN or ID)
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
        /// Gets and sets the property RecordType. 
        /// <para>
        /// The updated type of the registry record. Omit to leave the record type unchanged.
        /// </para>
        /// </summary>
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
        /// The updated version of the registry record. Omit to leave the version unchanged.
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
        /// The identifier of the registry containing the record (ARN or ID)
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
        /// Gets and sets the property TriggerSynchronization. 
        /// <para>
        /// Whether to trigger synchronization of the record's descriptor content from its source
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