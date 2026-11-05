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
    /// This is the response object from the UpdateRegistryRecord operation.
    /// </summary>
    public partial class UpdateRegistryRecordResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp when the registry record was created.
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
        /// The description of the updated registry record.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 4096)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property DescriptorType. 
        /// <para>
        /// The descriptor type of the updated registry record. Possible values are <c>MCP</c>,
        /// <c>A2A</c>, <c>CUSTOM</c>, and <c>AGENT_SKILLS</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DescriptorType DescriptorType { get; set; }

        /// <summary>
        /// Checks to see if the DescriptorType property is set.
        /// </summary>
        internal bool IsSetDescriptorType() => this.DescriptorType != null;

        /// <summary>
        /// Gets and sets the property Descriptors. 
        /// <para>
        /// The descriptor-type-specific configuration of the updated registry record. For details,
        /// see the <c>Descriptors</c> data type.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public Descriptors Descriptors { get; set; }

        /// <summary>
        /// Checks to see if the Descriptors property is set.
        /// </summary>
        internal bool IsSetDescriptors() => this.Descriptors != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the updated registry record.
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
        /// The Amazon Resource Name (ARN) of the updated registry record.
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
        /// The unique identifier of the updated registry record.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 12, Max = 12)]
        public string RecordId { get; set; }

        /// <summary>
        /// Checks to see if the RecordId property is set.
        /// </summary>
        internal bool IsSetRecordId() => this.RecordId != null;

        /// <summary>
        /// Gets and sets the property RecordVersion. 
        /// <para>
        /// The version of the updated registry record.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string RecordVersion { get; set; }

        /// <summary>
        /// Checks to see if the RecordVersion property is set.
        /// </summary>
        internal bool IsSetRecordVersion() => this.RecordVersion != null;

        /// <summary>
        /// Gets and sets the property RegistryArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the registry that contains the updated record.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string RegistryArn { get; set; }

        /// <summary>
        /// Checks to see if the RegistryArn property is set.
        /// </summary>
        internal bool IsSetRegistryArn() => this.RegistryArn != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the updated registry record. Possible values include <c>CREATING</c>,
        /// <c>DRAFT</c>, <c>APPROVED</c>, <c>PENDING_APPROVAL</c>, <c>REJECTED</c>, <c>DEPRECATED</c>,
        /// <c>UPDATING</c>, <c>CREATE_FAILED</c>, and <c>UPDATE_FAILED</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public RegistryRecordStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StatusReason. 
        /// <para>
        /// The reason for the current status of the updated registry record.
        /// </para>
        /// </summary>
        public string StatusReason { get; set; }

        /// <summary>
        /// Checks to see if the StatusReason property is set.
        /// </summary>
        internal bool IsSetStatusReason() => this.StatusReason != null;

        /// <summary>
        /// Gets and sets the property SynchronizationConfiguration. 
        /// <para>
        /// The synchronization configuration of the updated registry record.
        /// </para>
        /// </summary>
        public SynchronizationConfiguration SynchronizationConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the SynchronizationConfiguration property is set.
        /// </summary>
        internal bool IsSetSynchronizationConfiguration() => this.SynchronizationConfiguration != null;

        /// <summary>
        /// Gets and sets the property SynchronizationType. 
        /// <para>
        /// The synchronization type of the updated registry record.
        /// </para>
        /// </summary>
        public SynchronizationType SynchronizationType { get; set; }

        /// <summary>
        /// Checks to see if the SynchronizationType property is set.
        /// </summary>
        internal bool IsSetSynchronizationType() => this.SynchronizationType != null;

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The timestamp when the registry record was last updated.
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
