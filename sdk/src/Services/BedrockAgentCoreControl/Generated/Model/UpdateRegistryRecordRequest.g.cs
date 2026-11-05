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
    /// Container for the parameters to the UpdateRegistryRecord operation. Updates an existing
    /// registry record. This operation uses PATCH semantics, so you only need to specify
    /// the fields you want to change. The update is processed asynchronously and returns
    /// HTTP 202 Accepted.
    /// </summary>
    public partial class UpdateRegistryRecordRequest : AmazonBedrockAgentCoreControlRequest
    {
        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The updated description for the registry record. To clear the description, include
        /// the <c>UpdatedDescription</c> wrapper with <c>optionalValue</c> not specified.
        /// </para>
        /// </summary>
        public UpdatedDescription Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property DescriptorType. 
        /// <para>
        /// The updated descriptor type for the registry record. Changing the descriptor type
        /// may require updating the <c>descriptors</c> field to match the new type's schema requirements.
        /// </para>
        /// </summary>
        public DescriptorType DescriptorType { get; set; }

        /// <summary>
        /// Checks to see if the DescriptorType property is set.
        /// </summary>
        internal bool IsSetDescriptorType() => this.DescriptorType != null;

        /// <summary>
        /// Gets and sets the property Descriptors. 
        /// <para>
        /// The updated descriptor-type-specific configuration containing the resource schema
        /// and metadata. Uses PATCH semantics where individual descriptor fields can be updated
        /// independently.
        /// </para>
        /// </summary>
        public UpdatedDescriptors Descriptors { get; set; }

        /// <summary>
        /// Checks to see if the Descriptors property is set.
        /// </summary>
        internal bool IsSetDescriptors() => this.Descriptors != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The updated name for the registry record.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property RecordId. 
        /// <para>
        /// The identifier of the registry record to update. You can specify either the Amazon
        /// Resource Name (ARN) or the ID of the record.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string RecordId { get; set; }

        /// <summary>
        /// Checks to see if the RecordId property is set.
        /// </summary>
        internal bool IsSetRecordId() => this.RecordId != null;

        /// <summary>
        /// Gets and sets the property RecordVersion. 
        /// <para>
        /// The version of the registry record for optimistic locking. If provided, it must match
        /// the current version of the record. The service automatically increments the version
        /// after a successful update.
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
        /// The identifier of the registry containing the record. You can specify either the Amazon
        /// Resource Name (ARN) or the ID of the registry.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string RegistryId { get; set; }

        /// <summary>
        /// Checks to see if the RegistryId property is set.
        /// </summary>
        internal bool IsSetRegistryId() => this.RegistryId != null;

        /// <summary>
        /// Gets and sets the property SynchronizationConfiguration. 
        /// <para>
        /// The updated synchronization configuration for the registry record.
        /// </para>
        /// </summary>
        public UpdatedSynchronizationConfiguration SynchronizationConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the SynchronizationConfiguration property is set.
        /// </summary>
        internal bool IsSetSynchronizationConfiguration() => this.SynchronizationConfiguration != null;

        /// <summary>
        /// Gets and sets the property SynchronizationType. 
        /// <para>
        /// The updated synchronization type for the registry record.
        /// </para>
        /// </summary>
        public UpdatedSynchronizationType SynchronizationType { get; set; }

        /// <summary>
        /// Checks to see if the SynchronizationType property is set.
        /// </summary>
        internal bool IsSetSynchronizationType() => this.SynchronizationType != null;

        /// <summary>
        /// Gets and sets the property TriggerSynchronization. 
        /// <para>
        /// Whether to trigger synchronization using the stored or provided configuration. When
        /// set to <c>true</c>, the service will synchronize the record metadata from the configured
        /// external source.
        /// </para>
        /// </summary>
        public bool? TriggerSynchronization { get; set; }

        /// <summary>
        /// Checks to see if the TriggerSynchronization property is set.
        /// </summary>
        internal bool IsSetTriggerSynchronization() => this.TriggerSynchronization.HasValue;
    }
}
