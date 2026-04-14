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
    /// This is the response object from the UpdateRegistryRecord operation.
    /// </summary>
    public partial class UpdateRegistryRecordResponse : AmazonWebServiceResponse
    {
        private DateTime? _createdAt;
        private string _description;
        private Descriptors _descriptors;
        private DescriptorType _descriptorType;
        private string _name;
        private string _recordArn;
        private string _recordId;
        private string _recordVersion;
        private string _registryArn;
        private RegistryRecordStatus _status;
        private string _statusReason;
        private SynchronizationConfiguration _synchronizationConfiguration;
        private SynchronizationType _synchronizationType;
        private DateTime? _updatedAt;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp when the registry record was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the updated registry record.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=4096)]
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
        /// Gets and sets the property Descriptors. 
        /// <para>
        /// The descriptor-type-specific configuration of the updated registry record. For details,
        /// see the <c>Descriptors</c> data type.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Descriptors Descriptors
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
        /// The descriptor type of the updated registry record. Possible values are <c>MCP</c>,
        /// <c>A2A</c>, <c>CUSTOM</c>, and <c>AGENT_SKILLS</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// The name of the updated registry record.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
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
        /// Gets and sets the property RecordArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the updated registry record.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string RecordArn
        {
            get { return this._recordArn; }
            set { this._recordArn = value; }
        }

        // Check to see if RecordArn property is set
        internal bool IsSetRecordArn()
        {
            return this._recordArn != null;
        }

        /// <summary>
        /// Gets and sets the property RecordId. 
        /// <para>
        /// The unique identifier of the updated registry record.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=12, Max=12)]
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
        /// The version of the updated registry record.
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
        /// Gets and sets the property RegistryArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the registry that contains the updated record.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string RegistryArn
        {
            get { return this._registryArn; }
            set { this._registryArn = value; }
        }

        // Check to see if RegistryArn property is set
        internal bool IsSetRegistryArn()
        {
            return this._registryArn != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the updated registry record. Possible values include <c>CREATING</c>,
        /// <c>DRAFT</c>, <c>APPROVED</c>, <c>PENDING_APPROVAL</c>, <c>REJECTED</c>, <c>DEPRECATED</c>,
        /// <c>UPDATING</c>, <c>CREATE_FAILED</c>, and <c>UPDATE_FAILED</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RegistryRecordStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property StatusReason. 
        /// <para>
        /// The reason for the current status of the updated registry record.
        /// </para>
        /// </summary>
        public string StatusReason
        {
            get { return this._statusReason; }
            set { this._statusReason = value; }
        }

        // Check to see if StatusReason property is set
        internal bool IsSetStatusReason()
        {
            return this._statusReason != null;
        }

        /// <summary>
        /// Gets and sets the property SynchronizationConfiguration. 
        /// <para>
        /// The synchronization configuration of the updated registry record.
        /// </para>
        /// </summary>
        public SynchronizationConfiguration SynchronizationConfiguration
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
        /// The synchronization type of the updated registry record.
        /// </para>
        /// </summary>
        public SynchronizationType SynchronizationType
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
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The timestamp when the registry record was last updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? UpdatedAt
        {
            get { return this._updatedAt; }
            set { this._updatedAt = value; }
        }

        // Check to see if UpdatedAt property is set
        internal bool IsSetUpdatedAt()
        {
            return this._updatedAt.HasValue; 
        }

    }
}