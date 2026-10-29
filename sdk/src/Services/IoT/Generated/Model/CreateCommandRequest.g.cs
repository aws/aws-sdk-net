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
    /// Container for the parameters to the CreateCommand operation. Creates a command. A
    /// command contains reusable configurations that can be applied before they are sent
    /// to the devices.
    /// </summary>
    public partial class CreateCommandRequest : AmazonIoTRequest
    {
        /// <summary>
        /// Gets and sets the property CommandId. 
        /// <para>
        /// A unique identifier for the command. We recommend using UUID. Alpha-numeric characters,
        /// hyphens, and underscores are valid for use here.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string CommandId { get; set; }

        /// <summary>
        /// Checks to see if the CommandId property is set.
        /// </summary>
        internal bool IsSetCommandId() => this.CommandId != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A short text decription of the command.
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
        /// The user-friendly name in the console for the command. This name doesn't have to be
        /// unique. You can update the user-friendly name after you define it.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 64)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Checks to see if the DisplayName property is set.
        /// </summary>
        internal bool IsSetDisplayName() => this.DisplayName != null;

        /// <summary>
        /// Gets and sets the property MandatoryParameters. 
        /// <para>
        /// A list of parameters that are used by <c>StartCommandExecution</c> API for execution
        /// payload generation.
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
        /// The namespace of the command. The MQTT reserved topics and validations will be used
        /// for command executions according to the namespace setting.
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
        /// The payload object for the static command.
        /// </para>
        ///  
        /// <para>
        /// You can upload a static payload file from your local storage that contains the instructions
        /// for the device to process. The payload file can use any format. To make sure that
        /// the device correctly interprets the payload, we recommend you to specify the payload
        /// content type.
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
        ///  <note> 
        /// <para>
        /// This parameter is required for dynamic commands where the command execution placeholders
        /// are supplied either from <c>mandatoryParameters</c> or when <c>StartCommandExecution</c>
        /// is invoked.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min = 0, Max = 32768)]
        public string PayloadTemplate { get; set; }

        /// <summary>
        /// Checks to see if the PayloadTemplate property is set.
        /// </summary>
        internal bool IsSetPayloadTemplate() => this.PayloadTemplate != null;

        /// <summary>
        /// Gets and sets the property Preprocessor. 
        /// <para>
        /// Configuration that determines how <c>payloadTemplate</c> is processed to generate
        /// command execution payload.
        /// </para>
        ///  <note> 
        /// <para>
        /// This parameter is required for dynamic commands, along with <c>payloadTemplate</c>,
        /// and <c>mandatoryParameters</c>.
        /// </para>
        ///  </note>
        /// </summary>
        public CommandPreprocessor Preprocessor { get; set; }

        /// <summary>
        /// Checks to see if the Preprocessor property is set.
        /// </summary>
        internal bool IsSetPreprocessor() => this.Preprocessor != null;

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The IAM role that you must provide when using the <c>AWS-IoT-FleetWise</c> namespace.
        /// The role grants IoT Device Management the permission to access IoT FleetWise resources
        /// for generating the payload for the command. This field is not supported when you use
        /// the <c>AWS-IoT</c> namespace.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string RoleArn { get; set; }

        /// <summary>
        /// Checks to see if the RoleArn property is set.
        /// </summary>
        internal bool IsSetRoleArn() => this.RoleArn != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Name-value pairs that are used as metadata to manage a command.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
