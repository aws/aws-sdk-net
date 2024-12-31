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
 * Do not modify this file. This file is generated from the ssm-2014-11-06.normal.json service model.
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
namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// An object containing various properties of a managed node.
    /// </summary>
    public partial class InstanceProperty
    {
        private string _activationId;
        private string _agentVersion;
        private string _architecture;
        private InstanceAggregatedAssociationOverview _associationOverview;
        private string _associationStatus;
        private string _computerName;
        private string _iamRole;
        private string _instanceId;
        private string _instanceRole;
        private string _instanceState;
        private string _instanceType;
        private string _ipAddress;
        private string _keyName;
        private DateTime? _lastAssociationExecutionDate;
        private DateTime? _lastPingDateTime;
        private DateTime? _lastSuccessfulAssociationExecutionDate;
        private DateTime? _launchTime;
        private string _name;
        private PingStatus _pingStatus;
        private string _platformName;
        private PlatformType _platformType;
        private string _platformVersion;
        private DateTime? _registrationDate;
        private string _resourceType;
        private string _sourceId;
        private SourceType _sourceType;

        /// <summary>
        /// Gets and sets the property ActivationId. 
        /// <para>
        /// The activation ID created by Systems Manager when the server or virtual machine (VM)
        /// was registered
        /// </para>
        /// </summary>
        public string ActivationId
        {
            get { return this._activationId; }
            set { this._activationId = value; }
        }

        // Check to see if ActivationId property is set
        internal bool IsSetActivationId()
        {
            return this._activationId != null;
        }

        /// <summary>
        /// Gets and sets the property AgentVersion. 
        /// <para>
        /// The version of SSM Agent running on your managed node.
        /// </para>
        /// </summary>
        public string AgentVersion
        {
            get { return this._agentVersion; }
            set { this._agentVersion = value; }
        }

        // Check to see if AgentVersion property is set
        internal bool IsSetAgentVersion()
        {
            return this._agentVersion != null;
        }

        /// <summary>
        /// Gets and sets the property Architecture. 
        /// <para>
        /// The CPU architecture of the node. For example, <c>x86_64</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Max=120)]
        public string Architecture
        {
            get { return this._architecture; }
            set { this._architecture = value; }
        }

        // Check to see if Architecture property is set
        internal bool IsSetArchitecture()
        {
            return this._architecture != null;
        }

        /// <summary>
        /// Gets and sets the property AssociationOverview.
        /// </summary>
        public InstanceAggregatedAssociationOverview AssociationOverview
        {
            get { return this._associationOverview; }
            set { this._associationOverview = value; }
        }

        // Check to see if AssociationOverview property is set
        internal bool IsSetAssociationOverview()
        {
            return this._associationOverview != null;
        }

        /// <summary>
        /// Gets and sets the property AssociationStatus. 
        /// <para>
        /// The status of the State Manager association applied to the managed node.
        /// </para>
        /// </summary>
        public string AssociationStatus
        {
            get { return this._associationStatus; }
            set { this._associationStatus = value; }
        }

        // Check to see if AssociationStatus property is set
        internal bool IsSetAssociationStatus()
        {
            return this._associationStatus != null;
        }

        /// <summary>
        /// Gets and sets the property ComputerName. 
        /// <para>
        /// The fully qualified host name of the managed node.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string ComputerName
        {
            get { return this._computerName; }
            set { this._computerName = value; }
        }

        // Check to see if ComputerName property is set
        internal bool IsSetComputerName()
        {
            return this._computerName != null;
        }

        /// <summary>
        /// Gets and sets the property IamRole. 
        /// <para>
        /// The IAM role used in the hybrid activation to register the node with Systems Manager.
        /// </para>
        /// </summary>
        [AWSProperty(Max=64)]
        public string IamRole
        {
            get { return this._iamRole; }
            set { this._iamRole = value; }
        }

        // Check to see if IamRole property is set
        internal bool IsSetIamRole()
        {
            return this._iamRole != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The ID of the managed node.
        /// </para>
        /// </summary>
        public string InstanceId
        {
            get { return this._instanceId; }
            set { this._instanceId = value; }
        }

        // Check to see if InstanceId property is set
        internal bool IsSetInstanceId()
        {
            return this._instanceId != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceRole. 
        /// <para>
        /// The instance profile attached to the node. If an instance profile isn't attached to
        /// the node, this value is blank.
        /// </para>
        /// </summary>
        [AWSProperty(Max=120)]
        public string InstanceRole
        {
            get { return this._instanceRole; }
            set { this._instanceRole = value; }
        }

        // Check to see if InstanceRole property is set
        internal bool IsSetInstanceRole()
        {
            return this._instanceRole != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceState. 
        /// <para>
        /// The current state of the node.
        /// </para>
        /// </summary>
        [AWSProperty(Max=120)]
        public string InstanceState
        {
            get { return this._instanceState; }
            set { this._instanceState = value; }
        }

        // Check to see if InstanceState property is set
        internal bool IsSetInstanceState()
        {
            return this._instanceState != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceType. 
        /// <para>
        /// The instance type of the managed node. For example, t3.large.
        /// </para>
        /// </summary>
        [AWSProperty(Max=120)]
        public string InstanceType
        {
            get { return this._instanceType; }
            set { this._instanceType = value; }
        }

        // Check to see if InstanceType property is set
        internal bool IsSetInstanceType()
        {
            return this._instanceType != null;
        }

        /// <summary>
        /// Gets and sets the property IPAddress. 
        /// <para>
        /// The public IPv4 address assigned to the node. If a public IPv4 address isn't assigned
        /// to the node, this value is blank.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=46)]
        public string IPAddress
        {
            get { return this._ipAddress; }
            set { this._ipAddress = value; }
        }

        // Check to see if IPAddress property is set
        internal bool IsSetIPAddress()
        {
            return this._ipAddress != null;
        }

        /// <summary>
        /// Gets and sets the property KeyName. 
        /// <para>
        /// The name of the key pair associated with the node. If a key pair isnt't associated
        /// with the node, this value is blank.
        /// </para>
        /// </summary>
        [AWSProperty(Max=255)]
        public string KeyName
        {
            get { return this._keyName; }
            set { this._keyName = value; }
        }

        // Check to see if KeyName property is set
        internal bool IsSetKeyName()
        {
            return this._keyName != null;
        }

        /// <summary>
        /// Gets and sets the property LastAssociationExecutionDate. 
        /// <para>
        /// The date the association was last run.
        /// </para>
        /// </summary>
        public DateTime? LastAssociationExecutionDate
        {
            get { return this._lastAssociationExecutionDate; }
            set { this._lastAssociationExecutionDate = value; }
        }

        // Check to see if LastAssociationExecutionDate property is set
        internal bool IsSetLastAssociationExecutionDate()
        {
            return this._lastAssociationExecutionDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastPingDateTime. 
        /// <para>
        /// The date and time when the SSM Agent last pinged the Systems Manager service.
        /// </para>
        /// </summary>
        public DateTime? LastPingDateTime
        {
            get { return this._lastPingDateTime; }
            set { this._lastPingDateTime = value; }
        }

        // Check to see if LastPingDateTime property is set
        internal bool IsSetLastPingDateTime()
        {
            return this._lastPingDateTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastSuccessfulAssociationExecutionDate. 
        /// <para>
        /// The last date the association was successfully run.
        /// </para>
        /// </summary>
        public DateTime? LastSuccessfulAssociationExecutionDate
        {
            get { return this._lastSuccessfulAssociationExecutionDate; }
            set { this._lastSuccessfulAssociationExecutionDate = value; }
        }

        // Check to see if LastSuccessfulAssociationExecutionDate property is set
        internal bool IsSetLastSuccessfulAssociationExecutionDate()
        {
            return this._lastSuccessfulAssociationExecutionDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LaunchTime. 
        /// <para>
        /// The timestamp for when the node was launched.
        /// </para>
        /// </summary>
        public DateTime? LaunchTime
        {
            get { return this._launchTime; }
            set { this._launchTime = value; }
        }

        // Check to see if LaunchTime property is set
        internal bool IsSetLaunchTime()
        {
            return this._launchTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The value of the EC2 <c>Name</c> tag associated with the node. If a <c>Name</c> tag
        /// hasn't been applied to the node, this value is blank.
        /// </para>
        /// </summary>
        [AWSProperty(Max=255)]
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
        /// Gets and sets the property PingStatus. 
        /// <para>
        /// Connection status of the SSM Agent on the managed node.
        /// </para>
        /// </summary>
        public PingStatus PingStatus
        {
            get { return this._pingStatus; }
            set { this._pingStatus = value; }
        }

        // Check to see if PingStatus property is set
        internal bool IsSetPingStatus()
        {
            return this._pingStatus != null;
        }

        /// <summary>
        /// Gets and sets the property PlatformName. 
        /// <para>
        /// The name of the operating system platform running on your managed node.
        /// </para>
        /// </summary>
        [AWSProperty(Max=120)]
        public string PlatformName
        {
            get { return this._platformName; }
            set { this._platformName = value; }
        }

        // Check to see if PlatformName property is set
        internal bool IsSetPlatformName()
        {
            return this._platformName != null;
        }

        /// <summary>
        /// Gets and sets the property PlatformType. 
        /// <para>
        /// The operating system platform type of the managed node. For example, Windows Server
        /// or Amazon Linux 2.
        /// </para>
        /// </summary>
        public PlatformType PlatformType
        {
            get { return this._platformType; }
            set { this._platformType = value; }
        }

        // Check to see if PlatformType property is set
        internal bool IsSetPlatformType()
        {
            return this._platformType != null;
        }

        /// <summary>
        /// Gets and sets the property PlatformVersion. 
        /// <para>
        /// The version of the OS platform running on your managed node.
        /// </para>
        /// </summary>
        [AWSProperty(Max=120)]
        public string PlatformVersion
        {
            get { return this._platformVersion; }
            set { this._platformVersion = value; }
        }

        // Check to see if PlatformVersion property is set
        internal bool IsSetPlatformVersion()
        {
            return this._platformVersion != null;
        }

        /// <summary>
        /// Gets and sets the property RegistrationDate. 
        /// <para>
        /// The date the node was registered with Systems Manager.
        /// </para>
        /// </summary>
        public DateTime? RegistrationDate
        {
            get { return this._registrationDate; }
            set { this._registrationDate = value; }
        }

        // Check to see if RegistrationDate property is set
        internal bool IsSetRegistrationDate()
        {
            return this._registrationDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// The type of managed node.
        /// </para>
        /// </summary>
        public string ResourceType
        {
            get { return this._resourceType; }
            set { this._resourceType = value; }
        }

        // Check to see if ResourceType property is set
        internal bool IsSetResourceType()
        {
            return this._resourceType != null;
        }

        /// <summary>
        /// Gets and sets the property SourceId. 
        /// <para>
        /// The ID of the source resource.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=128)]
        public string SourceId
        {
            get { return this._sourceId; }
            set { this._sourceId = value; }
        }

        // Check to see if SourceId property is set
        internal bool IsSetSourceId()
        {
            return this._sourceId != null;
        }

        /// <summary>
        /// Gets and sets the property SourceType. 
        /// <para>
        /// The type of the source resource.
        /// </para>
        /// </summary>
        public SourceType SourceType
        {
            get { return this._sourceType; }
            set { this._sourceType = value; }
        }

        // Check to see if SourceType property is set
        internal bool IsSetSourceType()
        {
            return this._sourceType != null;
        }

    }
}