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

namespace Amazon.IoT.Model
{
    /// <summary>
    /// This is the response object from the GetCommand operation.
    /// </summary>
    public partial class GetCommandResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property CommandArn. 
        /// <para>
        /// The Amazon Resource Number (ARN) of the command. For example, <c>arn:aws:iot:&lt;region&gt;:&lt;accountid&gt;:command/&lt;commandId&gt;</c>
        /// 
        /// </para>
        /// </summary>
        public string CommandArn { get; set; }

        /// <summary>
        /// Checks to see if the CommandArn property is set.
        /// </summary>
        internal bool IsSetCommandArn() => this.CommandArn != null;

        /// <summary>
        /// Gets and sets the property CommandId. 
        /// <para>
        /// The unique identifier of the command.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string CommandId { get; set; }

        /// <summary>
        /// Checks to see if the CommandId property is set.
        /// </summary>
        internal bool IsSetCommandId() => this.CommandId != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp, when the command was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Deprecated. 
        /// <para>
        /// Indicates whether the command has been deprecated.
        /// </para>
        /// </summary>
        public bool? Deprecated { get; set; }

        /// <summary>
        /// Checks to see if the Deprecated property is set.
        /// </summary>
        internal bool IsSetDeprecated() => this.Deprecated.HasValue;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A short text description of the command.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2028)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// The user-friendly name in the console for the command.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 64)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Checks to see if the DisplayName property is set.
        /// </summary>
        internal bool IsSetDisplayName() => this.DisplayName != null;

        /// <summary>
        /// Gets and sets the property LastUpdatedAt. 
        /// <para>
        /// The timestamp, when the command was last updated.
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdatedAt property is set.
        /// </summary>
        internal bool IsSetLastUpdatedAt() => this.LastUpdatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property MandatoryParameters. 
        /// <para>
        /// A list of parameters for the command created.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1)]
        public List<CommandParameter> MandatoryParameters { get; set; } = AWSConfigs.InitializeCollections ? new List<CommandParameter>() : null;

        /// <summary>
        /// Checks to see if the MandatoryParameters property is set.
        /// </summary>
        internal bool IsSetMandatoryParameters() => this.MandatoryParameters != null && (this.MandatoryParameters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Namespace. 
        /// <para>
        /// The namespace of the command.
        /// </para>
        /// </summary>
        public CommandNamespace Namespace { get; set; }

        /// <summary>
        /// Checks to see if the Namespace property is set.
        /// </summary>
        internal bool IsSetNamespace() => this.Namespace != null;

        /// <summary>
        /// Gets and sets the property Payload. 
        /// <para>
        /// The payload object that you provided for the command.
        /// </para>
        /// </summary>
        public CommandPayload Payload { get; set; }

        /// <summary>
        /// Checks to see if the Payload property is set.
        /// </summary>
        internal bool IsSetPayload() => this.Payload != null;

        /// <summary>
        /// Gets and sets the property PayloadTemplate. 
        /// <para>
        /// The payload template for the dynamic command.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 32768)]
        public string PayloadTemplate { get; set; }

        /// <summary>
        /// Checks to see if the PayloadTemplate property is set.
        /// </summary>
        internal bool IsSetPayloadTemplate() => this.PayloadTemplate != null;

        /// <summary>
        /// Gets and sets the property PendingDeletion. 
        /// <para>
        /// Indicates whether the command is being deleted.
        /// </para>
        /// </summary>
        public bool? PendingDeletion { get; set; }

        /// <summary>
        /// Checks to see if the PendingDeletion property is set.
        /// </summary>
        internal bool IsSetPendingDeletion() => this.PendingDeletion.HasValue;

        /// <summary>
        /// Gets and sets the property Preprocessor. 
        /// <para>
        /// Configuration that determines how <c>payloadTemplate</c> is processed to generate
        /// command execution payload.
        /// </para>
        /// </summary>
        public CommandPreprocessor Preprocessor { get; set; }

        /// <summary>
        /// Checks to see if the Preprocessor property is set.
        /// </summary>
        internal bool IsSetPreprocessor() => this.Preprocessor != null;

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The IAM role that you provided when creating the command with <c>AWS-IoT-FleetWise</c>
        /// as the namespace.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string RoleArn { get; set; }

        /// <summary>
        /// Checks to see if the RoleArn property is set.
        /// </summary>
        internal bool IsSetRoleArn() => this.RoleArn != null;
    }
}
