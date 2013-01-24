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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AutoScaling.Model
{
    /// <summary>
    /// Container for the parameters to the CreateLaunchConfiguration operation.
    /// <para> Creates a new launch configuration. The launch configuration name must be unique within the scope of the client's AWS account. The
    /// maximum limit of launch configurations, which by default is 100, must not yet have been met; otherwise, the call will fail. When created,
    /// the new launch configuration is available for immediate use. </para> <para>You can create a launch configuration with Amazon EC2 security
    /// groups or with Amazon VPC security groups. However, you can't use Amazon EC2 security groups together with Amazon VPC security groups, or
    /// vice versa.</para> <para><b>NOTE:</b> At this time, Auto Scaling launch configurations don't support compressed (e.g. zipped) user data
    /// files. </para>
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
        private string spotPrice;
        private string iamInstanceProfile;
        private bool? ebsOptimized;

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
        /// please see <a href="http://aws.amazon.com/ec2/"> Amazon EC2 product documentation</a>.
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
        /// The name of the Amazon EC2 key pair.
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
        /// The names of the security groups with which to associate Amazon EC2 or Amazon VPC instances. Specify Amazon EC2 security groups using
        /// security group names, such as <c>websrv</c>. Specify Amazon VPC security groups using security group IDs, such as <c>sg-12345678</c>. For
        /// more information about Amazon EC2 security groups, go to <a
        /// href="http://docs.amazonwebservices.com/AWSEC2/latest/UserGuide/index.html?using-network-security.html"> Using Security Groups</a> in the
        /// Amazon EC2 product documentation. For more information about Amazon VPC security groups, go to <a
        /// href="http://docs.amazonwebservices.com/AmazonVPC/latest/UserGuide/index.html?VPC_SecurityGroups.html"> Security Groups</a> in the Amazon
        /// VPC product documentation.
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
        /// The user data available to the launched Amazon EC2 instances. For more information about Amazon EC2 user data, please see <a
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
        /// The instance type of the Amazon EC2 instance. For more information about Amazon EC2 instance types, please see <a
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
        /// The ID of the kernel associated with the Amazon EC2 AMI.
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
        /// The ID of the RAM disk associated with the Amazon EC2 AMI.
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
        /// information about Amazon EC2 BlockDeviceMappings, go to <a
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
        /// Enables detailed monitoring, which is enabled by default. When detailed monitoring is enabled, CloudWatch will generate metrics every minute
        /// and your account will be charged a fee. When you disable detailed monitoring, by specifying <c>False</c>, Cloudwatch will generate metrics
        /// every 5 minutes. For information about monitoring, see the <a href="http://aws.amazon.com/cloudwatch/">Amazon CloudWatch</a> product page.
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

        /// <summary>
        /// The maximum hourly price to be paid for any Spot Instance launched to fulfill the request. Spot Instances are launched when the price you
        /// specify exceeds the current Spot market price. For more information on launching Spot Instances, go to <a
        /// href="http://docs.amazonwebservices.com/AutoScaling/latest/DeveloperGuide/US-SpotInstances.html"> Using Auto Scaling to Launch Spot
        /// Instances</a> in the <i>Auto Scaling Developer Guide</i>.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 255</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string SpotPrice
        {
            get { return this.spotPrice; }
            set { this.spotPrice = value; }
        }

        /// <summary>
        /// Sets the SpotPrice property
        /// </summary>
        /// <param name="spotPrice">The value to set for the SpotPrice property </param>
        /// <returns>this instance</returns>
        public CreateLaunchConfigurationRequest WithSpotPrice(string spotPrice)
        {
            this.spotPrice = spotPrice;
            return this;
        }
            

        // Check to see if SpotPrice property is set
        internal bool IsSetSpotPrice()
        {
            return this.spotPrice != null;       
        }

        /// <summary>
        /// The name or the Amazon Resource Name (ARN) of the instance profile associated with the IAM role for the instance. For information on
        /// launching EC2 instances with an IAM role, go to <a
        /// href="http://docs.amazonwebservices.com/AutoScaling/latest/DeveloperGuide/us-iam-role.html">Launching Auto Scaling Instances With an IAM
        /// Role</a> in the <i>Auto Scaling Developer Guide</i>.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 1600</description>
        ///     </item>
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>[\u0020-\uD7FF\uE000-\uFFFD\uD800\uDC00-\uDBFF\uDFFF\r\n\t]*</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string IamInstanceProfile
        {
            get { return this.iamInstanceProfile; }
            set { this.iamInstanceProfile = value; }
        }

        /// <summary>
        /// Sets the IamInstanceProfile property
        /// </summary>
        /// <param name="iamInstanceProfile">The value to set for the IamInstanceProfile property </param>
        /// <returns>this instance</returns>
        public CreateLaunchConfigurationRequest WithIamInstanceProfile(string iamInstanceProfile)
        {
            this.iamInstanceProfile = iamInstanceProfile;
            return this;
        }
            

        // Check to see if IamInstanceProfile property is set
        internal bool IsSetIamInstanceProfile()
        {
            return this.iamInstanceProfile != null;       
        }

        /// <summary>
        /// Whether the instance is optimized for EBS I/O. This optimization provides dedicated throughput to Amazon EBS and an optimized configuration
        /// stack to provide optimal EBS I/O performance. This optimization is not available with all instance types. Additional usage charges apply
        /// when using an EBS Optimized instance. For information about EBS-Optimized instances, go to <a
        /// href="http://docs.amazonwebservices.com/AWSEC2/latest/UserGuide/instance-types.html#EBSOptimized">EBS-Optimized Instances</a> in the
        /// <i>Amazon Elastic Compute Cloud User Guide</i>.
        ///  
        /// </summary>
        public bool EbsOptimized
        {
            get { return this.ebsOptimized ?? default(bool); }
            set { this.ebsOptimized = value; }
        }

        /// <summary>
        /// Sets the EbsOptimized property
        /// </summary>
        /// <param name="ebsOptimized">The value to set for the EbsOptimized property </param>
        /// <returns>this instance</returns>
        public CreateLaunchConfigurationRequest WithEbsOptimized(bool ebsOptimized)
        {
            this.ebsOptimized = ebsOptimized;
            return this;
        }
            

        // Check to see if EbsOptimized property is set
        internal bool IsSetEbsOptimized()
        {
            return this.ebsOptimized.HasValue;       
        }
    }
}
    
