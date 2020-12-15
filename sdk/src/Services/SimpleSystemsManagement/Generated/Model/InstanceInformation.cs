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

namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// Describes a filter for a specific list of instances.
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

        /// <summary>
        /// Gets and sets the property ActivationId. 
        /// <para>
        /// The activation ID created by Systems Manager when the server or VM was registered.
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
        /// The version of SSM Agent running on your Linux instance. 
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
        /// The fully qualified host name of the managed instance.
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
        /// The Amazon Identity and Access Management (IAM) role assigned to the on-premises Systems
        /// Manager managed instance. This call does not return the IAM role for EC2 instances.
        /// To retrieve the IAM role for an EC2 instance, use the Amazon EC2 <code>DescribeInstances</code>
        /// action. For information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_DescribeInstances.html">DescribeInstances</a>
        /// in the <i>Amazon EC2 API Reference</i> or <a href="http://docs.aws.amazon.com/cli/latest/reference/ec2/describe-instances.html">describe-instances</a>
        /// in the <i>AWS CLI Command Reference</i>.
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
        /// The instance ID. 
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
        /// The IP address of the managed instance.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=46)]
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
        /// Indicates whether the latest version of SSM Agent is running on your Linux Managed
        /// Instance. This field does not indicate whether or not the latest version is installed
        /// on Windows managed instances, because some older versions of Windows Server use the
        /// EC2Config service to process SSM requests.
        /// </para>
        /// </summary>
        public bool IsLatestVersion
        {
            get { return this._isLatestVersion.GetValueOrDefault(); }
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
        public DateTime LastAssociationExecutionDate
        {
            get { return this._lastAssociationExecutionDate.GetValueOrDefault(); }
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
        public DateTime LastPingDateTime
        {
            get { return this._lastPingDateTime.GetValueOrDefault(); }
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
        public DateTime LastSuccessfulAssociationExecutionDate
        {
            get { return this._lastSuccessfulAssociationExecutionDate.GetValueOrDefault(); }
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
        /// The name assigned to an on-premises server or virtual machine (VM) when it is activated
        /// as a Systems Manager managed instance. The name is specified as the <code>DefaultInstanceName</code>
        /// property using the <a>CreateActivation</a> command. It is applied to the managed instance
        /// by specifying the Activation Code and Activation ID when you install SSM Agent on
        /// the instance, as explained in <a href="http://docs.aws.amazon.com/systems-manager/latest/userguide/sysman-install-managed-linux.html">Install
        /// SSM Agent for a hybrid environment (Linux)</a> and <a href="http://docs.aws.amazon.com/systems-manager/latest/userguide/sysman-install-managed-win.html">Install
        /// SSM Agent for a hybrid environment (Windows)</a>. To retrieve the Name tag of an EC2
        /// instance, use the Amazon EC2 <code>DescribeInstances</code> action. For information,
        /// see <a href="http://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_DescribeInstances.html">DescribeInstances</a>
        /// in the <i>Amazon EC2 API Reference</i> or <a href="http://docs.aws.amazon.com/cli/latest/reference/ec2/describe-instances.html">describe-instances</a>
        /// in the <i>AWS CLI Command Reference</i>.
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
        /// The status <code>Inactive</code> has been deprecated and is no longer in use.
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
        /// The name of the operating system platform running on your instance. 
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
        /// The version of the OS platform running on your instance. 
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
        /// The date the server or VM was registered with AWS as a managed instance.
        /// </para>
        /// </summary>
        public DateTime RegistrationDate
        {
            get { return this._registrationDate.GetValueOrDefault(); }
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

    }
}