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
    /// This is the response object from the GetCommand operation.
    /// </summary>
    public partial class GetCommandResponse : AmazonWebServiceResponse
    {
        private string _commandArn;
        private string _commandId;
        private DateTime? _createdAt;
        private bool? _deprecated;
        private string _description;
        private string _displayName;
        private DateTime? _lastUpdatedAt;
        private List<CommandParameter> _mandatoryParameters = AWSConfigs.InitializeCollections ? new List<CommandParameter>() : null;
        private CommandNamespace _awsNamespace;
        private CommandPayload _payload;
        private string _payloadTemplate;
        private bool? _pendingDeletion;
        private CommandPreprocessor _preprocessor;
        private string _roleArn;

        /// <summary>
        /// Gets and sets the property CommandArn. 
        /// <para>
        /// The Amazon Resource Number (ARN) of the command. For example, <c>arn:aws:iot:&lt;region&gt;:&lt;accountid&gt;:command/&lt;commandId&gt;</c>
        /// 
        /// </para>
        /// </summary>
        public string CommandArn
        {
            get { return this._commandArn; }
            set { this._commandArn = value; }
        }

        // Check to see if CommandArn property is set
        internal bool IsSetCommandArn()
        {
            return this._commandArn != null;
        }

        /// <summary>
        /// Gets and sets the property CommandId. 
        /// <para>
        /// The unique identifier of the command.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
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
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp, when the command was created.
        /// </para>
        /// </summary>
        public DateTime CreatedAt
        {
            get { return this._createdAt.GetValueOrDefault(); }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Deprecated. 
        /// <para>
        /// Indicates whether the command has been deprecated.
        /// </para>
        /// </summary>
        public bool Deprecated
        {
            get { return this._deprecated.GetValueOrDefault(); }
            set { this._deprecated = value; }
        }

        // Check to see if Deprecated property is set
        internal bool IsSetDeprecated()
        {
            return this._deprecated.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A short text description of the command.
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
        /// The user-friendly name in the console for the command.
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
        /// Gets and sets the property LastUpdatedAt. 
        /// <para>
        /// The timestamp, when the command was last updated.
        /// </para>
        /// </summary>
        public DateTime LastUpdatedAt
        {
            get { return this._lastUpdatedAt.GetValueOrDefault(); }
            set { this._lastUpdatedAt = value; }
        }

        // Check to see if LastUpdatedAt property is set
        internal bool IsSetLastUpdatedAt()
        {
            return this._lastUpdatedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MandatoryParameters. 
        /// <para>
        /// A list of parameters for the command created.
        /// </para>
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
        /// The namespace of the command.
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
        /// The payload object that you provided for the command.
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
        /// Gets and sets the property PayloadTemplate. 
        /// <para>
        /// The payload template for the dynamic command.
        /// </para>
        /// </summary>
        [AWSProperty(Max=32768)]
        public string PayloadTemplate
        {
            get { return this._payloadTemplate; }
            set { this._payloadTemplate = value; }
        }

        // Check to see if PayloadTemplate property is set
        internal bool IsSetPayloadTemplate()
        {
            return this._payloadTemplate != null;
        }

        /// <summary>
        /// Gets and sets the property PendingDeletion. 
        /// <para>
        /// Indicates whether the command is being deleted.
        /// </para>
        /// </summary>
        public bool PendingDeletion
        {
            get { return this._pendingDeletion.GetValueOrDefault(); }
            set { this._pendingDeletion = value; }
        }

        // Check to see if PendingDeletion property is set
        internal bool IsSetPendingDeletion()
        {
            return this._pendingDeletion.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Preprocessor. 
        /// <para>
        /// Configuration that determines how <c>payloadTemplate</c> is processed to generate
        /// command execution payload.
        /// </para>
        /// </summary>
        public CommandPreprocessor Preprocessor
        {
            get { return this._preprocessor; }
            set { this._preprocessor = value; }
        }

        // Check to see if Preprocessor property is set
        internal bool IsSetPreprocessor()
        {
            return this._preprocessor != null;
        }

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The IAM role that you provided when creating the command with <c>AWS-IoT-FleetWise</c>
        /// as the namespace.
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

    }
}