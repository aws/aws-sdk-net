/*
 * Copyright 2010-2011 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AutoScaling.Model
{
    /// <summary>
    /// Container for the parameters to the CreateLaunchConfiguration operation.
    /// <para> Creates a new launch configuration. Once created, the new launch configuration is available for immediate use. </para>
    /// <para><b>NOTE:</b> The launch configuration name used must be unique, within the scope of the client's AWS account, and the maximum limit of
    /// launch configurations must not yet have been met, or else the call will fail. </para>
    /// </summary>
    /// <seealso cref="Amazon.AutoScaling.AmazonAutoScaling.CreateLaunchConfiguration"/>
    public class CreateLaunchConfigurationRequest : AmazonWebServiceRequest
    {
        private string launchConfigurationName;
        private string imageId;
        private string keyName;
        private List<string> securityGroups = new List<string>();
        private string userData;
        private string instanceType;
        private string kernelId;
        private string ramdiskId;
        private List<BlockDeviceMapping> blockDeviceMappings = new List<BlockDeviceMapping>();
        private InstanceMonitoring instanceMonitoring;

        /// <summary>
        /// The name of the launch configuration to create.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 255</description>
        ///     </item>
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>[\u0020-\uD7FF\uE000-\uFFFD\uD800\uDC00-\uDBFF\uDFFF\r\n\t]*</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string LaunchConfigurationName
        {
            get { return this.launchConfigurationName; }
            set { this.launchConfigurationName = value; }
        }

        /// <summary>
        /// Sets the LaunchConfigurationName property
        /// </summary>
        /// <param name="launchConfigurationName">The value to set for the LaunchConfigurationName property </param>
        /// <returns>this instance</returns>
        public CreateLaunchConfigurationRequest WithLaunchConfigurationName(string launchConfigurationName)
        {
            this.launchConfigurationName = launchConfigurationName;
            return this;
        }
            

        // Check to see if LaunchConfigurationName property is set
        internal bool IsSetLaunchConfigurationName()
        {
            return this.launchConfigurationName != null;       
        }

        /// <summary>
        /// Unique ID of the <i>Amazon Machine Image</i> (AMI) which was assigned during registration. For more information about Amazon EC2 images,
        /// please see <a href="http://aws.amazon.com/ec2/"> Amazon EC2 product documentation</a>
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 255</description>
        ///     </item>
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>[\u0020-\uD7FF\uE000-\uFFFD\uD800\uDC00-\uDBFF\uDFFF\r\n\t]*</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string ImageId
        {
            get { return this.imageId; }
            set { this.imageId = value; }
        }

        /// <summary>
        /// Sets the ImageId property
        /// </summary>
        /// <param name="imageId">The value to set for the ImageId property </param>
        /// <returns>this instance</returns>
        public CreateLaunchConfigurationRequest WithImageId(string imageId)
        {
            this.imageId = imageId;
            return this;
        }
            

        // Check to see if ImageId property is set
        internal bool IsSetImageId()
        {
            return this.imageId != null;       
        }

        /// <summary>
        /// The name of the EC2 key pair.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 255</description>
        ///     </item>
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>[\u0020-\uD7FF\uE000-\uFFFD\uD800\uDC00-\uDBFF\uDFFF\r\n\t]*</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string KeyName
        {
            get { return this.keyName; }
            set { this.keyName = value; }
        }

        /// <summary>
        /// Sets the KeyName property
        /// </summary>
        /// <param name="keyName">The value to set for the KeyName property </param>
        /// <returns>this instance</returns>
        public CreateLaunchConfigurationRequest WithKeyName(string keyName)
        {
            this.keyName = keyName;
            return this;
        }
            

        // Check to see if KeyName property is set
        internal bool IsSetKeyName()
        {
            return this.keyName != null;       
        }

        /// <summary>
        /// The names of the security groups with which to associate EC2 instances. For more information about Amazon EC2 security groups, go to the <a
        /// href="http://aws.amazon.com/ec2/"> Amazon EC2 product documentation.</a>
        ///  
        /// </summary>
        public List<string> SecurityGroups
        {
            get { return this.securityGroups; }
            set { this.securityGroups = value; }
        }
        /// <summary>
        /// Adds elements to the SecurityGroups collection
        /// </summary>
        /// <param name="securityGroups">The values to add to the SecurityGroups collection </param>
        /// <returns>this instance</returns>
        public CreateLaunchConfigurationRequest WithSecurityGroups(params string[] securityGroups)
        {
            foreach (string element in securityGroups)
            {
                this.securityGroups.Add(element);
            }

            return this;
        }
        
        /// <summary>
        /// Adds elements to the SecurityGroups collection
        /// </summary>
        /// <param name="securityGroups">The values to add to the SecurityGroups collection </param>
        /// <returns>this instance</returns>
        public CreateLaunchConfigurationRequest WithSecurityGroups(IEnumerable<string> securityGroups)
        {
            foreach (string element in securityGroups)
            {
                this.securityGroups.Add(element);
            }

            return this;
        }

        // Check to see if SecurityGroups property is set
        internal bool IsSetSecurityGroups()
        {
            return this.securityGroups.Count > 0;       
        }

        /// <summary>
        /// The user data available to the launched EC2 instances. For more information about Amazon EC2 user data, please see <a
        /// href="http://aws.amazon.com/ec2/"> Amazon EC2 product documentation</a>.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>0 - 21847</description>
        ///     </item>
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>[\u0020-\uD7FF\uE000-\uFFFD\uD800\uDC00-\uDBFF\uDFFF\r\n\t]*</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string UserData
        {
            get { return this.userData; }
            set { this.userData = value; }
        }

        /// <summary>
        /// Sets the UserData property
        /// </summary>
        /// <param name="userData">The value to set for the UserData property </param>
        /// <returns>this instance</returns>
        public CreateLaunchConfigurationRequest WithUserData(string userData)
        {
            this.userData = userData;
            return this;
        }
            

        // Check to see if UserData property is set
        internal bool IsSetUserData()
        {
            return this.userData != null;       
        }

        /// <summary>
        /// The instance type of the EC2 instance. For more information about Amazon EC2 instance types, please see <a
        /// href="http://aws.amazon.com/ec2/"> Amazon EC2 product documentation</a>
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 255</description>
        ///     </item>
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>[\u0020-\uD7FF\uE000-\uFFFD\uD800\uDC00-\uDBFF\uDFFF\r\n\t]*</description>
        ///     </item>
        /// </list>
        /// </para>
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
        public CreateLaunchConfigurationRequest WithInstanceType(string instanceType)
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
        /// The ID of the kernel associated with the EC2 AMI.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 255</description>
        ///     </item>
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>[\u0020-\uD7FF\uE000-\uFFFD\uD800\uDC00-\uDBFF\uDFFF\r\n\t]*</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string KernelId
        {
            get { return this.kernelId; }
            set { this.kernelId = value; }
        }

        /// <summary>
        /// Sets the KernelId property
        /// </summary>
        /// <param name="kernelId">The value to set for the KernelId property </param>
        /// <returns>this instance</returns>
        public CreateLaunchConfigurationRequest WithKernelId(string kernelId)
        {
            this.kernelId = kernelId;
            return this;
        }
            

        // Check to see if KernelId property is set
        internal bool IsSetKernelId()
        {
            return this.kernelId != null;       
        }

        /// <summary>
        /// The ID of the RAM disk associated with the EC2 AMI.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 255</description>
        ///     </item>
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>[\u0020-\uD7FF\uE000-\uFFFD\uD800\uDC00-\uDBFF\uDFFF\r\n\t]*</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string RamdiskId
        {
            get { return this.ramdiskId; }
            set { this.ramdiskId = value; }
        }

        /// <summary>
        /// Sets the RamdiskId property
        /// </summary>
        /// <param name="ramdiskId">The value to set for the RamdiskId property </param>
        /// <returns>this instance</returns>
        public CreateLaunchConfigurationRequest WithRamdiskId(string ramdiskId)
        {
            this.ramdiskId = ramdiskId;
            return this;
        }
            

        // Check to see if RamdiskId property is set
        internal bool IsSetRamdiskId()
        {
            return this.ramdiskId != null;       
        }

        /// <summary>
        /// A list of mappings that specify how block devices are exposed to the instance. Each mapping is made up of a <i>VirtualName</i>, a
        /// <i>DeviceName</i>, and an <i>ebs</i> data structure that contains information about the associated Elastic Block Storage volume. For more
        /// information about Amazon EC2 BlockDeviceMappings, please go to <a
        /// href="http://docs.amazonwebservices.com/AWSEC2/latest/UserGuide/index.html?block-device-mapping-concepts.html"> Block Device Mapping</a> in
        /// the Amazon EC2 product documentation.
        ///  
        /// </summary>
        public List<BlockDeviceMapping> BlockDeviceMappings
        {
            get { return this.blockDeviceMappings; }
            set { this.blockDeviceMappings = value; }
        }
        /// <summary>
        /// Adds elements to the BlockDeviceMappings collection
        /// </summary>
        /// <param name="blockDeviceMappings">The values to add to the BlockDeviceMappings collection </param>
        /// <returns>this instance</returns>
        public CreateLaunchConfigurationRequest WithBlockDeviceMappings(params BlockDeviceMapping[] blockDeviceMappings)
        {
            foreach (BlockDeviceMapping element in blockDeviceMappings)
            {
                this.blockDeviceMappings.Add(element);
            }

            return this;
        }
        
        /// <summary>
        /// Adds elements to the BlockDeviceMappings collection
        /// </summary>
        /// <param name="blockDeviceMappings">The values to add to the BlockDeviceMappings collection </param>
        /// <returns>this instance</returns>
        public CreateLaunchConfigurationRequest WithBlockDeviceMappings(IEnumerable<BlockDeviceMapping> blockDeviceMappings)
        {
            foreach (BlockDeviceMapping element in blockDeviceMappings)
            {
                this.blockDeviceMappings.Add(element);
            }

            return this;
        }

        // Check to see if BlockDeviceMappings property is set
        internal bool IsSetBlockDeviceMappings()
        {
            return this.blockDeviceMappings.Count > 0;       
        }

        /// <summary>
        /// Enables detailed monitoring.
        ///  
        /// </summary>
        public InstanceMonitoring InstanceMonitoring
        {
            get { return this.instanceMonitoring; }
            set { this.instanceMonitoring = value; }
        }

        /// <summary>
        /// Sets the InstanceMonitoring property
        /// </summary>
        /// <param name="instanceMonitoring">The value to set for the InstanceMonitoring property </param>
        /// <returns>this instance</returns>
        public CreateLaunchConfigurationRequest WithInstanceMonitoring(InstanceMonitoring instanceMonitoring)
        {
            this.instanceMonitoring = instanceMonitoring;
            return this;
        }
            

        // Check to see if InstanceMonitoring property is set
        internal bool IsSetInstanceMonitoring()
        {
            return this.instanceMonitoring != null;       
        }
    }
}
    
