/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

namespace Amazon.OpsWorks.Model
{
    /// <summary>
    /// <para>Describes an instance.</para>
    /// </summary>
    public class Instance
    {
        
        private string instanceId;
        private string ec2InstanceId;
        private string hostname;
        private string stackId;
        private List<string> layerIds = new List<string>();
        private List<string> securityGroupIds = new List<string>();
        private string instanceType;
        private string instanceProfileArn;
        private string status;
        private string os;
        private string availabilityZone;
        private string publicDns;
        private string privateDns;
        private string publicIp;
        private string privateIp;
        private string elasticIp;
        private string autoScalingType;
        private string sshKeyName;
        private string sshHostRsaKeyFingerprint;
        private string sshHostDsaKeyFingerprint;
        private string createdAt;
        private string lastServiceErrorId;

        /// <summary>
        /// The instance ID.
        ///  
        /// </summary>
        public string InstanceId
        {
            get { return this.instanceId; }
            set { this.instanceId = value; }
        }

        /// <summary>
        /// Sets the InstanceId property
        /// </summary>
        /// <param name="instanceId">The value to set for the InstanceId property </param>
        /// <returns>this instance</returns>
        public Instance WithInstanceId(string instanceId)
        {
            this.instanceId = instanceId;
            return this;
        }
            

        // Check to see if InstanceId property is set
        internal bool IsSetInstanceId()
        {
            return this.instanceId != null;
        }

        /// <summary>
        /// The ID of the associated Amazon EC2 instance.
        ///  
        /// </summary>
        public string Ec2InstanceId
        {
            get { return this.ec2InstanceId; }
            set { this.ec2InstanceId = value; }
        }

        /// <summary>
        /// Sets the Ec2InstanceId property
        /// </summary>
        /// <param name="ec2InstanceId">The value to set for the Ec2InstanceId property </param>
        /// <returns>this instance</returns>
        public Instance WithEc2InstanceId(string ec2InstanceId)
        {
            this.ec2InstanceId = ec2InstanceId;
            return this;
        }
            

        // Check to see if Ec2InstanceId property is set
        internal bool IsSetEc2InstanceId()
        {
            return this.ec2InstanceId != null;
        }

        /// <summary>
        /// The instance host name.
        ///  
        /// </summary>
        public string Hostname
        {
            get { return this.hostname; }
            set { this.hostname = value; }
        }

        /// <summary>
        /// Sets the Hostname property
        /// </summary>
        /// <param name="hostname">The value to set for the Hostname property </param>
        /// <returns>this instance</returns>
        public Instance WithHostname(string hostname)
        {
            this.hostname = hostname;
            return this;
        }
            

        // Check to see if Hostname property is set
        internal bool IsSetHostname()
        {
            return this.hostname != null;
        }

        /// <summary>
        /// The stack ID.
        ///  
        /// </summary>
        public string StackId
        {
            get { return this.stackId; }
            set { this.stackId = value; }
        }

        /// <summary>
        /// Sets the StackId property
        /// </summary>
        /// <param name="stackId">The value to set for the StackId property </param>
        /// <returns>this instance</returns>
        public Instance WithStackId(string stackId)
        {
            this.stackId = stackId;
            return this;
        }
            

        // Check to see if StackId property is set
        internal bool IsSetStackId()
        {
            return this.stackId != null;
        }

        /// <summary>
        /// An array containing the instance layer IDs.
        ///  
        /// </summary>
        public List<string> LayerIds
        {
            get { return this.layerIds; }
            set { this.layerIds = value; }
        }
        /// <summary>
        /// Adds elements to the LayerIds collection
        /// </summary>
        /// <param name="layerIds">The values to add to the LayerIds collection </param>
        /// <returns>this instance</returns>
        public Instance WithLayerIds(params string[] layerIds)
        {
            foreach (string element in layerIds)
            {
                this.layerIds.Add(element);
            }

            return this;
        }

        /// <summary>
        /// Adds elements to the LayerIds collection
        /// </summary>
        /// <param name="layerIds">The values to add to the LayerIds collection </param>
        /// <returns>this instance</returns>
        public Instance WithLayerIds(IEnumerable<string> layerIds)
        {
            foreach (string element in layerIds)
            {
                this.layerIds.Add(element);
            }

            return this;
        }

        // Check to see if LayerIds property is set
        internal bool IsSetLayerIds()
        {
            return this.layerIds.Count > 0;
        }

        /// <summary>
        /// An array containing the instance security group IDs.
        ///  
        /// </summary>
        public List<string> SecurityGroupIds
        {
            get { return this.securityGroupIds; }
            set { this.securityGroupIds = value; }
        }
        /// <summary>
        /// Adds elements to the SecurityGroupIds collection
        /// </summary>
        /// <param name="securityGroupIds">The values to add to the SecurityGroupIds collection </param>
        /// <returns>this instance</returns>
        public Instance WithSecurityGroupIds(params string[] securityGroupIds)
        {
            foreach (string element in securityGroupIds)
            {
                this.securityGroupIds.Add(element);
            }

            return this;
        }

        /// <summary>
        /// Adds elements to the SecurityGroupIds collection
        /// </summary>
        /// <param name="securityGroupIds">The values to add to the SecurityGroupIds collection </param>
        /// <returns>this instance</returns>
        public Instance WithSecurityGroupIds(IEnumerable<string> securityGroupIds)
        {
            foreach (string element in securityGroupIds)
            {
                this.securityGroupIds.Add(element);
            }

            return this;
        }

        // Check to see if SecurityGroupIds property is set
        internal bool IsSetSecurityGroupIds()
        {
            return this.securityGroupIds.Count > 0;
        }

        /// <summary>
        /// The instance type, which can be one of the following: <ul> <li>m1.small</li> <li>m1.medium</li> <li>m1.large</li> <li>m1.xlarge</li>
        /// <li>c1.medium</li> <li>c1.xlarge</li> <li>m2.xlarge</li> <li>m2.2xlarge</li> <li>m2.4xlarge</li> </ul>
        ///  
        /// </summary>
        public string InstanceType
        {
            get { return this.instanceType; }
            set { this.instanceType = value; }
        }

        /// <summary>
        /// Sets the InstanceType property
        /// </summary>
        /// <param name="instanceType">The value to set for the InstanceType property </param>
        /// <returns>this instance</returns>
        public Instance WithInstanceType(string instanceType)
        {
            this.instanceType = instanceType;
            return this;
        }
            

        // Check to see if InstanceType property is set
        internal bool IsSetInstanceType()
        {
            return this.instanceType != null;
        }

        /// <summary>
        /// The ARN of the instance's IAM profile. For more information about IAM ARNs, see <a
        /// href="http://docs.aws.amazon.com/IAM/latest/UserGuide/Using_Identifiers.html">Using Identifiers</a>.
        ///  
        /// </summary>
        public string InstanceProfileArn
        {
            get { return this.instanceProfileArn; }
            set { this.instanceProfileArn = value; }
        }

        /// <summary>
        /// Sets the InstanceProfileArn property
        /// </summary>
        /// <param name="instanceProfileArn">The value to set for the InstanceProfileArn property </param>
        /// <returns>this instance</returns>
        public Instance WithInstanceProfileArn(string instanceProfileArn)
        {
            this.instanceProfileArn = instanceProfileArn;
            return this;
        }
            

        // Check to see if InstanceProfileArn property is set
        internal bool IsSetInstanceProfileArn()
        {
            return this.instanceProfileArn != null;
        }

        /// <summary>
        /// The instance status: <ul> <li>requested</li> <li>booting</li> <li>running_setup</li> <li>online</li> <li>setup_failed</li>
        /// <li>start_failed</li> <li>terminating</li> <li>terminated</li> <li>stopped</li> <li>connection_lost</li> </ul>
        ///  
        /// </summary>
        public string Status
        {
            get { return this.status; }
            set { this.status = value; }
        }

        /// <summary>
        /// Sets the Status property
        /// </summary>
        /// <param name="status">The value to set for the Status property </param>
        /// <returns>this instance</returns>
        public Instance WithStatus(string status)
        {
            this.status = status;
            return this;
        }
            

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this.status != null;
        }

        /// <summary>
        /// The instance operating system.
        ///  
        /// </summary>
        public string Os
        {
            get { return this.os; }
            set { this.os = value; }
        }

        /// <summary>
        /// Sets the Os property
        /// </summary>
        /// <param name="os">The value to set for the Os property </param>
        /// <returns>this instance</returns>
        public Instance WithOs(string os)
        {
            this.os = os;
            return this;
        }
            

        // Check to see if Os property is set
        internal bool IsSetOs()
        {
            return this.os != null;
        }

        /// <summary>
        /// The instance Availability Zone. For more information, see <a href="http://docs.aws.amazon.com/general/latest/gr/rande.html">Regions and
        /// Endpoints</a>.
        ///  
        /// </summary>
        public string AvailabilityZone
        {
            get { return this.availabilityZone; }
            set { this.availabilityZone = value; }
        }

        /// <summary>
        /// Sets the AvailabilityZone property
        /// </summary>
        /// <param name="availabilityZone">The value to set for the AvailabilityZone property </param>
        /// <returns>this instance</returns>
        public Instance WithAvailabilityZone(string availabilityZone)
        {
            this.availabilityZone = availabilityZone;
            return this;
        }
            

        // Check to see if AvailabilityZone property is set
        internal bool IsSetAvailabilityZone()
        {
            return this.availabilityZone != null;
        }

        /// <summary>
        /// The instance public DNS name.
        ///  
        /// </summary>
        public string PublicDns
        {
            get { return this.publicDns; }
            set { this.publicDns = value; }
        }

        /// <summary>
        /// Sets the PublicDns property
        /// </summary>
        /// <param name="publicDns">The value to set for the PublicDns property </param>
        /// <returns>this instance</returns>
        public Instance WithPublicDns(string publicDns)
        {
            this.publicDns = publicDns;
            return this;
        }
            

        // Check to see if PublicDns property is set
        internal bool IsSetPublicDns()
        {
            return this.publicDns != null;
        }

        /// <summary>
        /// The instance private DNS name.
        ///  
        /// </summary>
        public string PrivateDns
        {
            get { return this.privateDns; }
            set { this.privateDns = value; }
        }

        /// <summary>
        /// Sets the PrivateDns property
        /// </summary>
        /// <param name="privateDns">The value to set for the PrivateDns property </param>
        /// <returns>this instance</returns>
        public Instance WithPrivateDns(string privateDns)
        {
            this.privateDns = privateDns;
            return this;
        }
            

        // Check to see if PrivateDns property is set
        internal bool IsSetPrivateDns()
        {
            return this.privateDns != null;
        }

        /// <summary>
        /// The instance public IP address.
        ///  
        /// </summary>
        public string PublicIp
        {
            get { return this.publicIp; }
            set { this.publicIp = value; }
        }

        /// <summary>
        /// Sets the PublicIp property
        /// </summary>
        /// <param name="publicIp">The value to set for the PublicIp property </param>
        /// <returns>this instance</returns>
        public Instance WithPublicIp(string publicIp)
        {
            this.publicIp = publicIp;
            return this;
        }
            

        // Check to see if PublicIp property is set
        internal bool IsSetPublicIp()
        {
            return this.publicIp != null;
        }

        /// <summary>
        /// The instance private IP address.
        ///  
        /// </summary>
        public string PrivateIp
        {
            get { return this.privateIp; }
            set { this.privateIp = value; }
        }

        /// <summary>
        /// Sets the PrivateIp property
        /// </summary>
        /// <param name="privateIp">The value to set for the PrivateIp property </param>
        /// <returns>this instance</returns>
        public Instance WithPrivateIp(string privateIp)
        {
            this.privateIp = privateIp;
            return this;
        }
            

        // Check to see if PrivateIp property is set
        internal bool IsSetPrivateIp()
        {
            return this.privateIp != null;
        }

        /// <summary>
        /// The instance <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/elastic-ip-addresses-eip.html"></a>Elastic IP address.
        ///  
        /// </summary>
        public string ElasticIp
        {
            get { return this.elasticIp; }
            set { this.elasticIp = value; }
        }

        /// <summary>
        /// Sets the ElasticIp property
        /// </summary>
        /// <param name="elasticIp">The value to set for the ElasticIp property </param>
        /// <returns>this instance</returns>
        public Instance WithElasticIp(string elasticIp)
        {
            this.elasticIp = elasticIp;
            return this;
        }
            

        // Check to see if ElasticIp property is set
        internal bool IsSetElasticIp()
        {
            return this.elasticIp != null;
        }

        /// <summary>
        /// The instance's auto scaling type, which has three possible values: <ul> <li><b>AlwaysRunning</b>: A 24x7 instance, which is not affected by
        /// auto scaling.</li> <li><b>TimeBasedAutoScaling</b>: A time-based auto scaling instance, which is started and stopped based on a specified
        /// schedule.</li> <li><b>LoadBasedAutoScaling</b>: A load-based auto scaling instance, which is started and stopped based on load metrics.</li>
        /// </ul>
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>AlwaysRunning, TimeBasedAutoScaling, LoadBasedAutoScaling</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string AutoScalingType
        {
            get { return this.autoScalingType; }
            set { this.autoScalingType = value; }
        }

        /// <summary>
        /// Sets the AutoScalingType property
        /// </summary>
        /// <param name="autoScalingType">The value to set for the AutoScalingType property </param>
        /// <returns>this instance</returns>
        public Instance WithAutoScalingType(string autoScalingType)
        {
            this.autoScalingType = autoScalingType;
            return this;
        }
            

        // Check to see if AutoScalingType property is set
        internal bool IsSetAutoScalingType()
        {
            return this.autoScalingType != null;
        }

        /// <summary>
        /// The instance SSH key name.
        ///  
        /// </summary>
        public string SshKeyName
        {
            get { return this.sshKeyName; }
            set { this.sshKeyName = value; }
        }

        /// <summary>
        /// Sets the SshKeyName property
        /// </summary>
        /// <param name="sshKeyName">The value to set for the SshKeyName property </param>
        /// <returns>this instance</returns>
        public Instance WithSshKeyName(string sshKeyName)
        {
            this.sshKeyName = sshKeyName;
            return this;
        }
            

        // Check to see if SshKeyName property is set
        internal bool IsSetSshKeyName()
        {
            return this.sshKeyName != null;
        }

        /// <summary>
        /// The SSH key's RSA fingerprint.
        ///  
        /// </summary>
        public string SshHostRsaKeyFingerprint
        {
            get { return this.sshHostRsaKeyFingerprint; }
            set { this.sshHostRsaKeyFingerprint = value; }
        }

        /// <summary>
        /// Sets the SshHostRsaKeyFingerprint property
        /// </summary>
        /// <param name="sshHostRsaKeyFingerprint">The value to set for the SshHostRsaKeyFingerprint property </param>
        /// <returns>this instance</returns>
        public Instance WithSshHostRsaKeyFingerprint(string sshHostRsaKeyFingerprint)
        {
            this.sshHostRsaKeyFingerprint = sshHostRsaKeyFingerprint;
            return this;
        }
            

        // Check to see if SshHostRsaKeyFingerprint property is set
        internal bool IsSetSshHostRsaKeyFingerprint()
        {
            return this.sshHostRsaKeyFingerprint != null;
        }

        /// <summary>
        /// The SSH key's DSA fingerprint.
        ///  
        /// </summary>
        public string SshHostDsaKeyFingerprint
        {
            get { return this.sshHostDsaKeyFingerprint; }
            set { this.sshHostDsaKeyFingerprint = value; }
        }

        /// <summary>
        /// Sets the SshHostDsaKeyFingerprint property
        /// </summary>
        /// <param name="sshHostDsaKeyFingerprint">The value to set for the SshHostDsaKeyFingerprint property </param>
        /// <returns>this instance</returns>
        public Instance WithSshHostDsaKeyFingerprint(string sshHostDsaKeyFingerprint)
        {
            this.sshHostDsaKeyFingerprint = sshHostDsaKeyFingerprint;
            return this;
        }
            

        // Check to see if SshHostDsaKeyFingerprint property is set
        internal bool IsSetSshHostDsaKeyFingerprint()
        {
            return this.sshHostDsaKeyFingerprint != null;
        }

        /// <summary>
        /// The time that the instance was created.
        ///  
        /// </summary>
        public string CreatedAt
        {
            get { return this.createdAt; }
            set { this.createdAt = value; }
        }

        /// <summary>
        /// Sets the CreatedAt property
        /// </summary>
        /// <param name="createdAt">The value to set for the CreatedAt property </param>
        /// <returns>this instance</returns>
        public Instance WithCreatedAt(string createdAt)
        {
            this.createdAt = createdAt;
            return this;
        }
            

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this.createdAt != null;
        }

        /// <summary>
        /// The ID of the last service error. Call <a>DescribeServiceErrors</a> for details.
        ///  
        /// </summary>
        public string LastServiceErrorId
        {
            get { return this.lastServiceErrorId; }
            set { this.lastServiceErrorId = value; }
        }

        /// <summary>
        /// Sets the LastServiceErrorId property
        /// </summary>
        /// <param name="lastServiceErrorId">The value to set for the LastServiceErrorId property </param>
        /// <returns>this instance</returns>
        public Instance WithLastServiceErrorId(string lastServiceErrorId)
        {
            this.lastServiceErrorId = lastServiceErrorId;
            return this;
        }
            

        // Check to see if LastServiceErrorId property is set
        internal bool IsSetLastServiceErrorId()
        {
            return this.lastServiceErrorId != null;
        }
    }
}
