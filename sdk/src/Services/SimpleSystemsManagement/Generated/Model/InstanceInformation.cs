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
    /// Describes a filter for a specific list of managed nodes.
    /// </summary>
    public partial class InstanceInformation
    {
        private string _activationId;
        private string _agentVersion;
        private InstanceAggregatedAssociationOverview _associationOverview;
        private string _associationStatus;
        private string _computerName;
        private string _iamRole;
        private string _instanceId;
        private string _ipAddress;
        private bool? _isLatestVersion;
        private DateTime? _lastAssociationExecutionDate;
        private DateTime? _lastPingDateTime;
        private DateTime? _lastSuccessfulAssociationExecutionDate;
        private string _name;
        private PingStatus _pingStatus;
        private string _platformName;
        private PlatformType _platformType;
        private string _platformVersion;
        private DateTime? _registrationDate;
        private ResourceType _resourceType;
        private string _sourceId;
        private SourceType _sourceType;

        /// <summary>
        /// Gets and sets the property ActivationId. 
        /// <para>
        /// The activation ID created by Amazon Web Services Systems Manager when the server or
        /// virtual machine (VM) was registered.
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
        /// The version of SSM Agent running on your Linux managed node. 
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
        /// Gets and sets the property AssociationOverview. 
        /// <para>
        /// Information about the association.
        /// </para>
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
        /// The status of the association.
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
        /// The role assigned to an Amazon EC2 instance configured with a Systems Manager Quick
        /// Setup host management configuration or the role assigned to an on-premises managed
        /// node.
        /// </para>
        ///  
        /// <para>
        ///  This call doesn't return the IAM role for <i>unmanaged</i> Amazon EC2 instances (instances
        /// not configured for Systems Manager). To retrieve the role for an unmanaged instance,
        /// use the Amazon EC2 <c>DescribeInstances</c> operation. For information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_DescribeInstances.html">DescribeInstances</a>
        /// in the <i>Amazon EC2 API Reference</i> or <a href="https://docs.aws.amazon.com/cli/latest/reference/ec2/describe-instances.html">describe-instances</a>
        /// in the <i>Amazon Web Services CLI Command Reference</i>.
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
        /// The managed node ID. 
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
        /// Gets and sets the property IPAddress. 
        /// <para>
        /// The IP address of the managed node.
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
        /// Gets and sets the property IsLatestVersion. 
        /// <para>
        /// Indicates whether the latest version of SSM Agent is running on your Linux managed
        /// node. This field doesn't indicate whether or not the latest version is installed on
        /// Windows managed nodes, because some older versions of Windows Server use the EC2Config
        /// service to process Systems Manager requests.
        /// </para>
        /// </summary>
        public bool? IsLatestVersion
        {
            get { return this._isLatestVersion; }
            set { this._isLatestVersion = value; }
        }

        // Check to see if IsLatestVersion property is set
        internal bool IsSetIsLatestVersion()
        {
            return this._isLatestVersion.HasValue; 
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
        /// The date and time when the agent last pinged the Systems Manager service. 
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
        /// Gets and sets the property Name. 
        /// <para>
        /// The name assigned to an on-premises server, edge device, or virtual machine (VM) when
        /// it is activated as a Systems Manager managed node. The name is specified as the <c>DefaultInstanceName</c>
        /// property using the <a>CreateActivation</a> command. It is applied to the managed node
        /// by specifying the Activation Code and Activation ID when you install SSM Agent on
        /// the node, as explained in <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/hybrid-multicloud-ssm-agent-install-linux.html">How
        /// to install SSM Agent on hybrid Linux nodes</a> and <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/hybrid-multicloud-ssm-agent-install-windows.html">How
        /// to install SSM Agent on hybrid Windows Server nodes</a>. To retrieve the <c>Name</c>
        /// tag of an EC2 instance, use the Amazon EC2 <c>DescribeInstances</c> operation. For
        /// information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_DescribeInstances.html">DescribeInstances</a>
        /// in the <i>Amazon EC2 API Reference</i> or <a href="https://docs.aws.amazon.com/cli/latest/reference/ec2/describe-instances.html">describe-instances</a>
        /// in the <i>Amazon Web Services CLI Command Reference</i>.
        /// </para>
        /// </summary>
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
        /// Connection status of SSM Agent. 
        /// </para>
        ///  <note> 
        /// <para>
        /// The status <c>Inactive</c> has been deprecated and is no longer in use.
        /// </para>
        ///  </note>
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
        /// The operating system platform type.
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
        /// The date the server or VM was registered with Amazon Web Services as a managed node.
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
        /// The type of instance. Instances are either EC2 instances or managed instances. 
        /// </para>
        /// </summary>
        public ResourceType ResourceType
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
        /// The ID of the source resource. For IoT Greengrass devices, <c>SourceId</c> is the
        /// Thing name. 
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
        /// The type of the source resource. For IoT Greengrass devices, <c>SourceType</c> is
        /// <c>AWS::IoT::Thing</c>. 
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