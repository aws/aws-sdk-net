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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
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
    /// Container for the parameters to the CreateCommand operation.
    /// Creates a command. A command contains reusable configurations that can be applied
    /// before they are sent to the devices.
    /// </summary>
    public partial class CreateCommandRequest : AmazonIoTRequest
    {
        private string _commandId;
        private string _description;
        private string _displayName;
        private List<CommandParameter> _mandatoryParameters = AWSConfigs.InitializeCollections ? new List<CommandParameter>() : null;
        private CommandNamespace _awsNamespace;
        private CommandPayload _payload;
        private string _roleArn;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Gets and sets the property CommandId. 
        /// <para>
        /// A unique identifier for the command. We recommend using UUID. Alpha-numeric characters,
        /// hyphens, and underscores are valid for use here.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string CommandId
        {
            get { return this._commandId; }
            set { this._commandId = value; }
        }

        // Check to see if CommandId property is set
        internal bool IsSetCommandId()
        {
            return this._commandId != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A short text decription of the command.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2028)]
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
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// The user-friendly name in the console for the command. This name doesn't have to be
        /// unique. You can update the user-friendly name after you define it.
        /// </para>
        /// </summary>
        [AWSProperty(Max=64)]
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
        /// Gets and sets the property MandatoryParameters. 
        /// <para>
        /// A list of parameters that are required by the <c>StartCommandExecution</c> API. These
        /// parameters need to be specified only when using the <c>AWS-IoT-FleetWise</c> namespace.
        /// You can either specify them here or when running the command using the <c>StartCommandExecution</c>
        /// API.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1)]
        public List<CommandParameter> MandatoryParameters
        {
            get { return this._mandatoryParameters; }
            set { this._mandatoryParameters = value; }
        }

        // Check to see if MandatoryParameters property is set
        internal bool IsSetMandatoryParameters()
        {
            return this._mandatoryParameters != null && (this._mandatoryParameters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Namespace. 
        /// <para>
        /// The namespace of the command. The MQTT reserved topics and validations will be used
        /// for command executions according to the namespace setting.
        /// </para>
        /// </summary>
        public CommandNamespace Namespace
        {
            get { return this._awsNamespace; }
            set { this._awsNamespace = value; }
        }

        // Check to see if Namespace property is set
        internal bool IsSetNamespace()
        {
            return this._awsNamespace != null;
        }

        /// <summary>
        /// Gets and sets the property Payload. 
        /// <para>
        /// The payload object for the command. You must specify this information when using the
        /// <c>AWS-IoT</c> namespace.
        /// </para>
        ///  
        /// <para>
        /// You can upload a static payload file from your local storage that contains the instructions
        /// for the device to process. The payload file can use any format. To make sure that
        /// the device correctly interprets the payload, we recommend you to specify the payload
        /// content type.
        /// </para>
        /// </summary>
        public CommandPayload Payload
        {
            get { return this._payload; }
            set { this._payload = value; }
        }

        // Check to see if Payload property is set
        internal bool IsSetPayload()
        {
            return this._payload != null;
        }

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The IAM role that you must provide when using the <c>AWS-IoT-FleetWise</c> namespace.
        /// The role grants IoT Device Management the permission to access IoT FleetWise resources
        /// for generating the payload for the command. This field is not required when you use
        /// the <c>AWS-IoT</c> namespace.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string RoleArn
        {
            get { return this._roleArn; }
            set { this._roleArn = value; }
        }

        // Check to see if RoleArn property is set
        internal bool IsSetRoleArn()
        {
            return this._roleArn != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Name-value pairs that are used as metadata to manage a command.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}