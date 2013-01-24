/*******************************************************************************
 * Copyright 2008-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 * this file except in compliance with the License. A copy of the License is located at
 *
 * http://aws.amazon.com/apache2.0
 *
 * or in the "license" file accompanying this file. This file is distributed on
 * an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express
 * or implied. See the License for the specific language governing permissions and
 * limitations under the License.
 * *****************************************************************************
 *    __  _    _  ___
 *   (  )( \/\/ )/ __)
 *   /__\ \    / \__ \
 *  (_)(_) \/\/  (___/
 *
 *  AWS SDK for .NET
 */

using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Additional launch instance information.
    /// </summary>
    [XmlRootAttribute(IsNullable = false)]
    public class ImportInstanceLaunchSpecificationType
    {    
        private string architectureField;
        private List<string> securityGroupField;
        private List<string> securityGroupIdField;
        private string userDataField;
        private string instanceTypeField;
        private Placement placementField;
        private MonitoringSpecification monitoringField;
        private string subnetIdField;
        private string instanceInitiatedShutdownBehaviorField;
        private string privateIpAddressField;

        /// <summary>
        /// Architecture of the instance.
        /// 
        /// Valid Values: i386 | x86_64
        /// </summary>
        [XmlElementAttribute(ElementName = "Architecture")]
        public string Architecture
        {
            get { return this.architectureField; }
            set { this.architectureField = value; }
        }

        /// <summary>
        /// Sets the architecture of the instance.
        /// </summary>
        /// <param name="architecture">Architecture of the instance.
        /// 
        /// Valid Values: i386 | x86_64</param>
        /// <returns>this instance</returns>
        public ImportInstanceLaunchSpecificationType WithArchitecture(string architecture)
        {
            this.architectureField = architecture;
            return this;
        }

        /// <summary>
        /// Checks if Architecture property is set
        /// </summary>
        /// <returns>true if Architecture property is set</returns>
        public bool IsSetArchitecture()
        {
            return this.architectureField != null;
        }

        /// <summary>
        /// One or more security group names.
        /// </summary>
        [XmlElementAttribute(ElementName = "SecurityGroup")]
        public List<string> SecurityGroup
        {
            get
            {
                if (this.securityGroupField == null)
                {
                    this.securityGroupField = new List<string>();
                }
                return this.securityGroupField;
            }
            set { this.securityGroupField = value; }
        }

        /// <summary>
        /// Sets security group names.
        /// </summary>
        /// <param name="list">One or more security group names.</param>
        /// <returns>this instance</returns>
        public ImportInstanceLaunchSpecificationType WithSecurityGroup(params string[] list)
        {
            foreach (string item in list)
            {
                SecurityGroup.Add(item);
            }
            return this;
        }

        /// <summary>
        /// Checks if SecurityGroup property is set
        /// </summary>
        /// <returns>true if SecurityGroup property is set</returns>
        public bool IsSetSecurityGroup()
        {
            return (SecurityGroup.Count > 0);
        }

        /// <summary>
        /// One or more security group IDs.
        /// </summary>
        [XmlElementAttribute(ElementName = "SecurityGroupId")]
        public List<string> SecurityGroupId
        {
            get
            {
                if (this.securityGroupIdField == null)
                {
                    this.securityGroupIdField = new List<string>();
                }
                return this.securityGroupIdField;
            }
            set { this.securityGroupIdField = value; }
        }

        /// <summary>
        /// Sets the security group IDs.
        /// </summary>
        /// <param name="list">One or more security group IDs.</param>
        /// <returns>this instance</returns>
        public ImportInstanceLaunchSpecificationType WithSecurityGroupId(params string[] list)
        {
            foreach (string item in list)
            {
                SecurityGroupId.Add(item);
            }
            return this;
        }

        /// <summary>
        /// Checks if SecurityGroupId property is set
        /// </summary>
        /// <returns>true if SecurityGroupId property is set</returns>
        public bool IsSetSecurityGroupId()
        {
            return (SecurityGroupId.Count > 0);
        }

        /// <summary>
        /// User data to be made available to the instance.
        /// </summary>
        [XmlElementAttribute(ElementName = "UserData")]
        public string UserData
        {
            get { return this.userDataField; }
            set { this.userDataField = value; }
        }

        /// <summary>
        /// Sets the user data to be made available to the instance.
        /// </summary>
        /// <param name="userData">User data to be made available to the instance.</param>
        /// <returns>this instance</returns>
        public ImportInstanceLaunchSpecificationType WithUserData(string userData)
        {
            this.userDataField = userData;
            return this;
        }

        /// <summary>
        /// Checks if UserData property is set
        /// </summary>
        /// <returns>true if UserData property is set</returns>
        public bool IsSetUserData()
        {
            return this.userDataField != null;
        }

        /// <summary>
        /// The instance type.
        ///
        /// Valid Values:
        /// m1.small | m1.medium | m1.large | m1.xlarge | c1.medium |
        /// c1.xlarge |
        /// m2.2xlarge | m2.4xlarge
        ///
        /// Default: m1.small
        /// </summary>
        [XmlElementAttribute(ElementName = "InstanceType")]
        public string InstanceType
        {
            get { return this.instanceTypeField; }
            set { this.instanceTypeField = value; }
        }

        /// <summary>
        /// Sets the instance type.
        /// </summary>
        /// <param name="instanceType">Specifies the instance type.
        ///
        /// Valid Values:
        /// m1.small | m1.medium | m1.large | m1.xlarge | c1.medium |
        /// c1.xlarge |
        /// m2.2xlarge | m2.4xlarge
        ///
        /// Default: m1.small</param>
        /// <returns>this instance</returns>
        public ImportInstanceLaunchSpecificationType WithInstanceType(string instanceType)
        {
            this.instanceTypeField = instanceType;
            return this;
        }

        /// <summary>
        /// Checks if InstanceType property is set
        /// </summary>
        /// <returns>true if InstanceType property is set</returns>
        public bool IsSetInstanceType()
        {
            return this.instanceTypeField != null;
        }

        /// <summary>
        /// The placement constraints.
        /// </summary>
        [XmlElementAttribute(ElementName = "Placement")]
        public Placement Placement
        {
            get { return this.placementField; }
            set { this.placementField = value; }
        }

        /// <summary>
        /// Sets the placement constraints.
        /// </summary>
        /// <param name="placement">Specifies the placement constraints.</param>
        /// <returns>this instance</returns>
        public ImportInstanceLaunchSpecificationType WithPlacement(Placement placement)
        {
            this.placementField = placement;
            return this;
        }

        /// <summary>
        /// Checks if Placement property is set
        /// </summary>
        /// <returns>true if Placement property is set</returns>
        public bool IsSetPlacement()
        {
            return this.placementField != null;
        }

        /// <summary>
        /// Instance monitoring configuration.
        /// </summary>
        [XmlElementAttribute(ElementName = "Monitoring")]
        public MonitoringSpecification Monitoring
        {
            get { return this.monitoringField; }
            set { this.monitoringField = value; }
        }

        /// <summary>
        /// Sets the instance monitoring configuration.
        /// </summary>
        /// <param name="monitoring">Enables monitoring for the instance.</param>
        /// <returns>this instance</returns>
        public ImportInstanceLaunchSpecificationType WithMonitoring(MonitoringSpecification monitoring)
        {
            this.monitoringField = monitoring;
            return this;
        }

        /// <summary>
        /// Checks if Monitoring property is set
        /// </summary>
        /// <returns>true if Monitoring property is set</returns>
        public bool IsSetMonitoring()
        {
            return this.monitoringField != null;
        }

        /// <summary>
        /// The ID of the subnet you want to launch the instance into.
        /// </summary>
        [XmlElementAttribute(ElementName = "SubnetId")]
        public string SubnetId
        {
            get { return this.subnetIdField; }
            set { this.subnetIdField = value; }
        }

        /// <summary>
        /// Sets the ID of the subnet you want to launch the instance into.
        /// </summary>
        /// <param name="subnetId">If you're using Amazon Virtual Private Cloud, this specifies the ID of the subnet you want to launch the instance into.</param>
        /// <returns>this instance</returns>
        public ImportInstanceLaunchSpecificationType WithSubnetId(string subnetId)
        {
            this.subnetIdField = subnetId;
            return this;
        }

        /// <summary>
        /// Checks if SubnetId property is set
        /// </summary>
        /// <returns>true if SubnetId property is set</returns>
        public bool IsSetSubnetId()
        {
            return this.subnetIdField != null;
        }

        /// <summary>
        /// Whether the instance stops or terminates on instance-initiated shutdown.
        /// 
        /// Valid Values: stop | terminate
        /// </summary>
        [XmlElementAttribute(ElementName = "InstanceInitiatedShutdownBehavior")]
        public string InstanceInitiatedShutdownBehavior
        {
            get { return this.instanceInitiatedShutdownBehaviorField; }
            set { this.instanceInitiatedShutdownBehaviorField = value; }
        }

        /// <summary>
        /// Sets whether the instance stops or terminates on instance-initiated shutdown.
        /// </summary>
        /// <param name="instanceInitiatedShutdownBehavior">Determines whether the instance stops or terminates on instance-initiated shutdown.
        /// 
        /// Valid Values: stop | terminate</param>
        /// <returns>this instance</returns>
        public ImportInstanceLaunchSpecificationType WithInstanceInitiatedShutdownBehavior(string instanceInitiatedShutdownBehavior)
        {
            this.instanceInitiatedShutdownBehaviorField = instanceInitiatedShutdownBehavior;
            return this;
        }

        /// <summary>
        /// Checks if InstanceInitiatedShutdownBehavior property is set
        /// </summary>
        /// <returns>true if InstanceInitiatedShutdownBehavior property is set</returns>
        public bool IsSetInstanceInitiatedShutdownBehavior()
        {
            return this.instanceInitiatedShutdownBehaviorField != null;
        }

        /// <summary>
        /// Private IP address for the instance.
        /// </summary>
        /// <remarks>
        /// If you're using Amazon Virtual Private Cloud, you can optionally
        /// assign the instance a specific available IP address from the subnet
        /// (e.g., 10.0.0.25).
        /// </remarks>
        [XmlElementAttribute(ElementName = "PrivateIpAddress")]
        public string PrivateIpAddress
        {
            get { return this.privateIpAddressField; }
            set { this.privateIpAddressField = value; }
        }

        /// <summary>
        /// Sets the private IP address for the instance.
        /// </summary>
        /// <param name="privateIpAddress">If you're using Amazon Virtual Private Cloud, you can optionally use this parameter to assign the instance a specific available IP address from the subnet (e.g., 10.0.0.25).</param>
        /// <returns>this instance</returns>
        public ImportInstanceLaunchSpecificationType WithPrivateIpAddress(string privateIpAddress)
        {
            this.privateIpAddressField = privateIpAddress;
            return this;
        }

        /// <summary>
        /// Checks if PrivateIpAddress property is set
        /// </summary>
        /// <returns>true if PrivateIpAddress property is set</returns>
        public bool IsSetPrivateIpAddress()
        {
            return this.privateIpAddressField != null;
        }

    }
}
