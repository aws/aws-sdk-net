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
    public partial class CreateLaunchConfigurationRequest : AmazonWebServiceRequest
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
        private bool? associatePublicIpAddress;

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

        // Check to see if LaunchConfigurationName property is set
        internal bool IsSetLaunchConfigurationName()
        {
            return this.launchConfigurationName != null;
        }

        /// <summary>
        /// Unique ID of the <i>Amazon Machine Image</i> (AMI) you want to use to launch your EC2 instances. For information about finding Amazon EC2
        /// AMIs, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/finding-an-ami.html">Finding a Suitable AMI</a> in the <i>Amazon
        /// Elastic Compute Cloud User Guide</i>.
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

        // Check to see if ImageId property is set
        internal bool IsSetImageId()
        {
            return this.imageId != null;
        }

        /// <summary>
        /// The name of the Amazon EC2 key pair. For more information, see <a
        /// href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/generating-a-keypair.html">Getting a Key Pair</a> in the <i>Amazon Elastic Compute
        /// Cloud User Guide</i>.
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

        // Check to see if KeyName property is set
        internal bool IsSetKeyName()
        {
            return this.keyName != null;
        }

        /// <summary>
        /// The security groups with which to associate Amazon EC2 or Amazon VPC instances. If your instances are launched in EC2, you can either
        /// specify Amazon EC2 security group names or the security group IDs. For more information about Amazon EC2 security groups, see <a
        /// href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/index.html?using-network-security.html"> Using Security Groups</a> in the <i>Amazon
        /// Elastic Compute Cloud User Guide</i>. If your instances are launched within VPC, specify Amazon VPC security group IDs. For more information
        /// about Amazon VPC security groups, see <a
        /// href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/index.html?VPC_SecurityGroups.html">Security Groups</a> in the <i>Amazon Virtual
        /// Private Cloud User Guide</i>.
        ///  
        /// </summary>
        public List<string> SecurityGroups
        {
            get { return this.securityGroups; }
            set { this.securityGroups = value; }
        }

        // Check to see if SecurityGroups property is set
        internal bool IsSetSecurityGroups()
        {
            return this.securityGroups.Count > 0;
        }

        /// <summary>
        /// The user data to make available to the launched Amazon EC2 instances. For more information about Amazon EC2 user data, see <a
        /// href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/AESDG-chapter-instancedata.html#instancedata-user-data-retrieval">User Data
        /// Retrieval</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
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

        // Check to see if UserData property is set
        internal bool IsSetUserData()
        {
            return this.userData != null;
        }

        /// <summary>
        /// The instance type of the Amazon EC2 instance. For information about available Amazon EC2 instance types, see <a
        /// href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/instance-types.html#AvailableInstanceTypes"> Available Instance Types</a> in the
        /// <i>Amazon Elastic Cloud Compute User Guide.</i>
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

        // Check to see if RamdiskId property is set
        internal bool IsSetRamdiskId()
        {
            return this.ramdiskId != null;
        }

        /// <summary>
        /// A list of mappings that specify how block devices are exposed to the instance. Each mapping is made up of a <i>VirtualName</i>, a
        /// <i>DeviceName</i>, and an <i>ebs</i> data structure that contains information about the associated Elastic Block Storage volume. For more
        /// information about Amazon EC2 BlockDeviceMappings, go to <a
        /// href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/index.html?block-device-mapping-concepts.html"> Block Device Mapping</a> in the
        /// Amazon EC2 product documentation.
        ///  
        /// </summary>
        public List<BlockDeviceMapping> BlockDeviceMappings
        {
            get { return this.blockDeviceMappings; }
            set { this.blockDeviceMappings = value; }
        }

        // Check to see if BlockDeviceMappings property is set
        internal bool IsSetBlockDeviceMappings()
        {
            return this.blockDeviceMappings.Count > 0;
        }

        /// <summary>
        /// Enables detailed monitoring if it is disabled. Detailed monitoring is enabled by default. When detailed monitoring is enabled, Amazon
        /// Cloudwatch will generate metrics every minute and your account will be charged a fee. When you disable detailed monitoring, by specifying
        /// <c>False</c>, Cloudwatch will generate metrics every 5 minutes. For more information, see <a
        /// href="http://docs.aws.amazon.com/AutoScaling/latest/DeveloperGuide/as-instance-monitoring.html">Monitor Your Auto Scaling Instances</a>. For
        /// information about Amazon CloudWatch, see the <a href="http://docs.aws.amazon.com/AmazonCloudWatch/latest/DeveloperGuide/Welcome.html">Amazon
        /// CloudWatch Developer Guide</a>.
        ///  
        /// </summary>
        public InstanceMonitoring InstanceMonitoring
        {
            get { return this.instanceMonitoring; }
            set { this.instanceMonitoring = value; }
        }

        // Check to see if InstanceMonitoring property is set
        internal bool IsSetInstanceMonitoring()
        {
            return this.instanceMonitoring != null;
        }

        /// <summary>
        /// The maximum hourly price to be paid for any Spot Instance launched to fulfill the request. Spot Instances are launched when the price you
        /// specify exceeds the current Spot market price. For more information on launching Spot Instances, see <a
        /// href="http://docs.aws.amazon.com/AutoScaling/latest/DeveloperGuide/US-SpotInstances.html"> Using Auto Scaling to Launch Spot Instances</a>
        /// in the <i>Auto Scaling Developer Guide</i>.
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

        // Check to see if SpotPrice property is set
        internal bool IsSetSpotPrice()
        {
            return this.spotPrice != null;
        }

        /// <summary>
        /// The name or the Amazon Resource Name (ARN) of the instance profile associated with the IAM role for the instance. Amazon EC2 instances
        /// launched with an IAM role will automatically have AWS security credentials available. You can use IAM roles with Auto Scaling to
        /// automatically enable applications running on your Amazon EC2 instances to securely access other AWS resources. For information on launching
        /// EC2 instances with an IAM role, go to <a href="http://docs.aws.amazon.com/AutoScaling/latest/DeveloperGuide/us-iam-role.html">Launching Auto
        /// Scaling Instances With an IAM Role</a> in the <i>Auto Scaling Developer Guide</i>.
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

        // Check to see if IamInstanceProfile property is set
        internal bool IsSetIamInstanceProfile()
        {
            return this.iamInstanceProfile != null;
        }

        /// <summary>
        /// Whether the instance is optimized for EBS I/O. The optimization provides dedicated throughput to Amazon EBS and an optimized configuration
        /// stack to provide optimal EBS I/O performance. This optimization is not available with all instance types. Additional usage charges apply
        /// when using an EBS Optimized instance. By default the instance is not optimized for EBS I/O. For information about EBS-optimized instances,
        /// go to <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/instance-types.html#EBSOptimized">EBS-Optimized Instances</a> in the
        /// <i>Amazon Elastic Compute Cloud User Guide</i>.
        ///  
        /// </summary>
        public bool EbsOptimized
        {
            get { return this.ebsOptimized ?? default(bool); }
            set { this.ebsOptimized = value; }
        }

        // Check to see if EbsOptimized property is set
        internal bool IsSetEbsOptimized()
        {
            return this.ebsOptimized.HasValue;
        }

        /// <summary>
        /// Used for Auto Scaling groups that launch instances into an Amazon Virtual Private Cloud (Amazon VPC). Specifies whether to assign a public
        /// IP address to each instance launched in a Amazon VPC. <note> If you specify a value for this parameter, be sure to specify at least one VPC
        /// subnet using the <i>VPCZoneIdentifier</i> parameter when you create your Auto Scaling group. </note> Default: If the instance is launched in
        /// default VPC, the default is <c>true</c>. If the instance is launched in a nondefault VPC (EC2-VPC), the default is <c>false</c>. For more
        /// information about the platforms supported by Auto Scaling, see <a
        /// href="http://docs.aws.amazon.com/AutoScaling/latest/DeveloperGuide/US_BasicSetup.html">Basic Auto Scaling Configuration</a>.
        ///  
        /// </summary>
        public bool AssociatePublicIpAddress
        {
            get { return this.associatePublicIpAddress ?? default(bool); }
            set { this.associatePublicIpAddress = value; }
        }

        // Check to see if AssociatePublicIpAddress property is set
        internal bool IsSetAssociatePublicIpAddress()
        {
            return this.associatePublicIpAddress.HasValue;
        }

    }
}
    
