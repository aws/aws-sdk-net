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
    /// This is the response object from the GetRegistryRecord operation.
    /// </summary>
    public partial class GetRegistryRecordResponse : AmazonWebServiceResponse
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
        /// Gets and sets the property CreatedBy. 
        /// <para>
        /// The ID of the Amazon Web Services account that created the registry record.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 12, Max = 12)]
        public string CreatedBy { get; set; }

        /// <summary>
        /// Checks to see if the CreatedBy property is set.
        /// </summary>
        internal bool IsSetCreatedBy() => this.CreatedBy != null;

        /// <summary>
        /// Gets and sets the property CreatedByAutoDetection. 
        /// <para>
        /// Specifies whether the registry record was created by auto-detection. <c>true</c> indicates
        /// the record was automatically created by the service based on the registry's auto-detection
        /// configuration; <c>false</c> indicates the record was created through a control-plane
        /// API call.
        /// </para>
        /// </summary>
        public bool? CreatedByAutoDetection { get; set; }

        /// <summary>
        /// Checks to see if the CreatedByAutoDetection property is set.
        /// </summary>
        internal bool IsSetCreatedByAutoDetection() => this.CreatedByAutoDetection.HasValue;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the registry record.
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
        /// The typed descriptors that define the content of the registry record.
        /// </para>
        /// </summary>
        public Descriptors Descriptors { get; set; }

        /// <summary>
        /// Checks to see if the Descriptors property is set.
        /// </summary>
        internal bool IsSetDescriptors() => this.Descriptors != null;

        /// <summary>
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// The human-readable display name of the registry record.
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
        /// The name of the registry record. Names are unique within a registry.
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
        /// Gets and sets the property RecordArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the registry record.
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
        /// The unique identifier of the registry record.
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
        /// The type of the registry record, such as MCP, AGENT, SKILL, or CUSTOM.
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
        /// The version identifier of the registry record.
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
        /// The Amazon Resource Name (ARN) of the parent registry that owns the record.
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
        /// The lifecycle status of the registry record.
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
        /// The reason for the current status. Typically populated when the status indicates a
        /// failure state.
        /// </para>
        /// </summary>
        public string StatusReason { get; set; }

        /// <summary>
        /// Checks to see if the StatusReason property is set.
        /// </summary>
        internal bool IsSetStatusReason() => this.StatusReason != null;

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
