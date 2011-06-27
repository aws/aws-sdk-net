/*******************************************************************************
 * Copyright 2008-2011 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 *  API Version: 2011-05-15
 */

using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

namespace Amazon.EC2.Model
{
    ///<summary>
    ///Specifies additional launch instance information.
    ///</summary>
    [XmlRootAttribute(Namespace = "http://ec2.amazonaws.com/doc/2011-05-15/", IsNullable = false)]
    public class ImportInstanceLaunchSpecificationType
    {    
        private string architectureField;
        private List<string> securityGroupField;
        private string userDataField;
        private string instanceTypeField;
        private Placement placementField;
        private MonitoringSpecification monitoringField;
        private string subnetIdField;
        private string instanceInitiatedShutdownBehaviorField;
        private string privateIpAddressField;

        /// <summary>
        /// Gets and sets the Architecture property.
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
        /// Sets the Architecture property
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
        /// Gets and sets the SecurityGroup property.
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
        /// Sets the SecurityGroup property
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
        /// Gets and sets the UserData property.
        /// User data to be made available to the instance.
        /// </summary>
        [XmlElementAttribute(ElementName = "UserData")]
        public string UserData
        {
            get { return this.userDataField; }
            set { this.userDataField = value; }
        }

        /// <summary>
        /// Sets the UserData property
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
        /// Gets and sets the InstanceType property.
        /// Specifies the instance type.
        ///
        /// Valid Values:
        /// m1.small | m1.large | m1.xlarge | c1.medium |
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
        /// Sets the InstanceType property
        /// </summary>
        /// <param name="instanceType">Specifies the instance type.
        ///
        /// Valid Values:
        /// m1.small | m1.large | m1.xlarge | c1.medium |
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
        /// Gets and sets the Placement property.
        /// Specifies the placement constraints.
        /// </summary>
        [XmlElementAttribute(ElementName = "Placement")]
        public Placement Placement
        {
            get { return this.placementField; }
            set { this.placementField = value; }
        }

        /// <summary>
        /// Sets the Placement property
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
        /// Gets and sets the Monitoring property.
        /// Enables monitoring for the instance.
        /// </summary>
        [XmlElementAttribute(ElementName = "Monitoring")]
        public MonitoringSpecification Monitoring
        {
            get { return this.monitoringField; }
            set { this.monitoringField = value; }
        }

        /// <summary>
        /// Sets the Monitoring property
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
        /// Gets and sets the SubnetId property.
        /// If you're using Amazon Virtual Private Cloud, this specifies the ID of the subnet you want to launch the instance into.
        /// </summary>
        [XmlElementAttribute(ElementName = "SubnetId")]
        public string SubnetId
        {
            get { return this.subnetIdField; }
            set { this.subnetIdField = value; }
        }

        /// <summary>
        /// Sets the SubnetId property
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
        /// Gets and sets the InstanceInitiatedShutdownBehavior property.
        /// Determines whether the instance stops or terminates on instance-initiated shutdown.
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
        /// Sets the InstanceInitiatedShutdownBehavior property
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
        /// Gets and sets the PrivateIpAddress property.
        /// If you're using Amazon Virtual Private Cloud, you can optionally use this parameter to assign the instance a specific available IP address from the subnet (e.g., 10.0.0.25).
        /// </summary>
        [XmlElementAttribute(ElementName = "PrivateIpAddress")]
        public string PrivateIpAddress
        {
            get { return this.privateIpAddressField; }
            set { this.privateIpAddressField = value; }
        }

        /// <summary>
        /// Sets the PrivateIpAddress property
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
