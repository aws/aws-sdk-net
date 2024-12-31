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
    /// Details about a specific managed node.
    /// </summary>
    public partial class InstanceInfo
    {
        private string _agentType;
        private string _agentVersion;
        private string _computerName;
        private string _instanceStatus;
        private string _ipAddress;
        private ManagedStatus _managedStatus;
        private string _platformName;
        private PlatformType _platformType;
        private string _platformVersion;
        private ResourceType _resourceType;

        /// <summary>
        /// Gets and sets the property AgentType. 
        /// <para>
        /// The type of agent installed on the node.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string AgentType
        {
            get { return this._agentType; }
            set { this._agentType = value; }
        }

        // Check to see if AgentType property is set
        internal bool IsSetAgentType()
        {
            return this._agentType != null;
        }

        /// <summary>
        /// Gets and sets the property AgentVersion. 
        /// <para>
        /// The version number of the agent installed on the node.
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
        /// Gets and sets the property InstanceStatus. 
        /// <para>
        /// The current status of the managed node.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string InstanceStatus
        {
            get { return this._instanceStatus; }
            set { this._instanceStatus = value; }
        }

        // Check to see if InstanceStatus property is set
        internal bool IsSetInstanceStatus()
        {
            return this._instanceStatus != null;
        }

        /// <summary>
        /// Gets and sets the property IpAddress. 
        /// <para>
        /// The IP address of the managed node.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=46)]
        public string IpAddress
        {
            get { return this._ipAddress; }
            set { this._ipAddress = value; }
        }

        // Check to see if IpAddress property is set
        internal bool IsSetIpAddress()
        {
            return this._ipAddress != null;
        }

        /// <summary>
        /// Gets and sets the property ManagedStatus. 
        /// <para>
        /// Indicates whether the node is managed by Systems Manager.
        /// </para>
        /// </summary>
        public ManagedStatus ManagedStatus
        {
            get { return this._managedStatus; }
            set { this._managedStatus = value; }
        }

        // Check to see if ManagedStatus property is set
        internal bool IsSetManagedStatus()
        {
            return this._managedStatus != null;
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
        /// The operating system platform type of the managed node.
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
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// The type of instance, either an EC2 instance or another supported machine type in
        /// a hybrid fleet.
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