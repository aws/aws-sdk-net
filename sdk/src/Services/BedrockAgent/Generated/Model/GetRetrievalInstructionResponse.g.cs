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

namespace Amazon.BedrockAgent.Model
{
    /// <summary>
    /// This is the response object from the GetRetrievalInstruction operation.
    /// </summary>
    public partial class GetRetrievalInstructionResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// When the retrieval instruction was created. On a numbered version, when that version
        /// was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property CustomerEncryptionKeyArn. 
        /// <para>
        /// The ARN of the customer managed KMS key protecting this content, when one was supplied
        /// at create.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string CustomerEncryptionKeyArn { get; set; }

        /// <summary>
        /// Checks to see if the CustomerEncryptionKeyArn property is set.
        /// </summary>
        internal bool IsSetCustomerEncryptionKeyArn() => this.CustomerEncryptionKeyArn != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the retrieval instruction. On a numbered version, the description
        /// of that version.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 200)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property Instruction. 
        /// <para>
        /// The reviewed content this instruction serves — what AgenticRetrieveStream resolves
        /// while status is ACTIVE. Absent until the first create review passes. Always present
        /// on a numbered version.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public RetrievalInstructionContent Instruction { get; set; }

        /// <summary>
        /// Checks to see if the Instruction property is set.
        /// </summary>
        internal bool IsSetInstruction() => this.Instruction != null;

        /// <summary>
        /// Gets and sets the property LastTransitionStatus. 
        /// <para>
        /// The outcome or in-progress state of the most recent create or update. CREATING or
        /// UPDATING means the operation is still running. Independent of status. Always has a
        /// value from the create 202 onward. On a numbered version this is always CREATE_SUCCESSFUL:
        /// a version is created once, from reviewed content, and is immutable.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public RetrievalInstructionLastTransitionStatus LastTransitionStatus { get; set; }

        /// <summary>
        /// Checks to see if the LastTransitionStatus property is set.
        /// </summary>
        internal bool IsSetLastTransitionStatus() => this.LastTransitionStatus != null;

        /// <summary>
        /// Gets and sets the property LastTransitionStatusReasons. 
        /// <para>
        /// Why the most recent create or update was rejected. One entry for each rejected field,
        /// or a single entry when the review itself failed. Each entry has a machine-readable
        /// code and a message, and names the field when it applies to one. The service includes
        /// this field only when lastTransitionStatus is CREATE_FAILED or UPDATE_FAILED. Never
        /// present on a numbered version.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<RetrievalInstructionFailureReason> LastTransitionStatusReasons { get; set; } = AWSConfigs.InitializeCollections ? new List<RetrievalInstructionFailureReason>() : null;

        /// <summary>
        /// Checks to see if the LastTransitionStatusReasons property is set.
        /// </summary>
        internal bool IsSetLastTransitionStatusReasons() => this.LastTransitionStatusReasons != null && (this.LastTransitionStatusReasons.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property LatestVersion. 
        /// <para>
        /// The largest version number that currently exists for this retrieval instruction, that
        /// is, the newest version you can retrieve. Present only on a DRAFT read, and only when
        /// at least one version exists. Because version numbers are never reused, deleting versions
        /// can leave gaps: this is the newest existing version, not a count and not the highest
        /// number ever created.
        /// </para>
        /// </summary>
        public string LatestVersion { get; set; }

        /// <summary>
        /// Checks to see if the LatestVersion property is set.
        /// </summary>
        internal bool IsSetLatestVersion() => this.LatestVersion != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the retrieval instruction.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 1, Max = 100)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property RetrievalInstructionArn. 
        /// <para>
        /// The ARN of the retrieval instruction.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string RetrievalInstructionArn { get; set; }

        /// <summary>
        /// Checks to see if the RetrievalInstructionArn property is set.
        /// </summary>
        internal bool IsSetRetrievalInstructionArn() => this.RetrievalInstructionArn != null;

        /// <summary>
        /// Gets and sets the property RetrievalInstructionId. 
        /// <para>
        /// The identifier of the retrieval instruction.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 10, Max = 10)]
        public string RetrievalInstructionId { get; set; }

        /// <summary>
        /// Checks to see if the RetrievalInstructionId property is set.
        /// </summary>
        internal bool IsSetRetrievalInstructionId() => this.RetrievalInstructionId != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Specifies whether you can use the instruction. You can resolve only an ACTIVE instruction
        /// at retrieval time. Monotone: INACTIVE to ACTIVE once, never back. Numbered versions
        /// are always ACTIVE.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public RetrievalInstructionStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// When the retrieval instruction was last updated. Equal to createdAt on a numbered
        /// version, which is immutable.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// The version this response describes: a version number, or DRAFT.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 9)]
        public string Version { get; set; }

        /// <summary>
        /// Checks to see if the Version property is set.
        /// </summary>
        internal bool IsSetVersion() => this.Version != null;
    }
}
