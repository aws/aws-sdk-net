/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// The <code>LaunchConfiguration</code> data type.
    /// </summary>
    public partial class LaunchConfiguration
    {
        private bool? _associatePublicIpAddress;
        private List<BlockDeviceMapping> _blockDeviceMappings = new List<BlockDeviceMapping>();
        private DateTime? _createdTime;
        private bool? _ebsOptimized;
        private string _iamInstanceProfile;
        private string _imageId;
        private InstanceMonitoring _instanceMonitoring;
        private string _instanceType;
        private string _kernelId;
        private string _keyName;
        private string _launchConfigurationARN;
        private string _launchConfigurationName;
        private string _placementTenancy;
        private string _ramdiskId;
        private List<string> _securityGroups = new List<string>();
        private string _spotPrice;
        private string _userData;


        /// <summary>
        /// Gets and sets the property AssociatePublicIpAddress. 
        /// <para>
        /// Specifies whether the instance is associated with a public IP address (<code>true</code>)
        /// or not (<code>false</code>).
        /// </para>
        /// </summary>
        public bool AssociatePublicIpAddress
        {
            get { return this._associatePublicIpAddress.GetValueOrDefault(); }
            set { this._associatePublicIpAddress = value; }
        }


        /// <summary>
        /// Sets the AssociatePublicIpAddress property
        /// </summary>
        /// <param name="associatePublicIpAddress">The value to set for the AssociatePublicIpAddress property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public LaunchConfiguration WithAssociatePublicIpAddress(bool associatePublicIpAddress)
        {
            this._associatePublicIpAddress = associatePublicIpAddress;
            return this;
        }

        // Check to see if AssociatePublicIpAddress property is set
        internal bool IsSetAssociatePublicIpAddress()
        {
            return this._associatePublicIpAddress.HasValue; 
        }


        /// <summary>
        /// Gets and sets the property BlockDeviceMappings. 
        /// <para>
        ///         Specifies how block devices are exposed to the instance.        Each mapping
        /// is made up of a <i>virtualName</i> and a <i>deviceName</i>.        
        /// </para>
        /// </summary>
        public List<BlockDeviceMapping> BlockDeviceMappings
        {
            get { return this._blockDeviceMappings; }
            set { this._blockDeviceMappings = value; }
        }

        /// <summary>
        /// Sets the BlockDeviceMappings property
        /// </summary>
        /// <param name="blockDeviceMappings">The values to add to the BlockDeviceMappings collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public LaunchConfiguration WithBlockDeviceMappings(params BlockDeviceMapping[] blockDeviceMappings)
        {
            foreach (var element in blockDeviceMappings)
            {
                this._blockDeviceMappings.Add(element);
            }
            return this;
        }

        /// <summary>
        /// Sets the BlockDeviceMappings property
        /// </summary>
        /// <param name="blockDeviceMappings">The values to add to the BlockDeviceMappings collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public LaunchConfiguration WithBlockDeviceMappings(IEnumerable<BlockDeviceMapping> blockDeviceMappings)
        {
            foreach (var element in blockDeviceMappings)
            {
                this._blockDeviceMappings.Add(element);
            }
            return this;
        }
        // Check to see if BlockDeviceMappings property is set
        internal bool IsSetBlockDeviceMappings()
        {
            return this._blockDeviceMappings != null && this._blockDeviceMappings.Count > 0; 
        }


        /// <summary>
        /// Gets and sets the property CreatedTime. 
        /// <para>
        ///         Provides the creation date and time for this launch configuration.       
        /// 
        /// </para>
        /// </summary>
        public DateTime CreatedTime
        {
            get { return this._createdTime.GetValueOrDefault(); }
            set { this._createdTime = value; }
        }


        /// <summary>
        /// Sets the CreatedTime property
        /// </summary>
        /// <param name="createdTime">The value to set for the CreatedTime property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public LaunchConfiguration WithCreatedTime(DateTime createdTime)
        {
            this._createdTime = createdTime;
            return this;
        }

        // Check to see if CreatedTime property is set
        internal bool IsSetCreatedTime()
        {
            return this._createdTime.HasValue; 
        }


        /// <summary>
        /// Gets and sets the property EbsOptimized. 
        /// <para>
        /// Specifies whether the instance is optimized for EBS I/O (<i>true</i>) or not (<i>false</i>).
        /// </para>
        /// </summary>
        public bool EbsOptimized
        {
            get { return this._ebsOptimized.GetValueOrDefault(); }
            set { this._ebsOptimized = value; }
        }


        /// <summary>
        /// Sets the EbsOptimized property
        /// </summary>
        /// <param name="ebsOptimized">The value to set for the EbsOptimized property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public LaunchConfiguration WithEbsOptimized(bool ebsOptimized)
        {
            this._ebsOptimized = ebsOptimized;
            return this;
        }

        // Check to see if EbsOptimized property is set
        internal bool IsSetEbsOptimized()
        {
            return this._ebsOptimized.HasValue; 
        }


        /// <summary>
        /// Gets and sets the property IamInstanceProfile. 
        /// <para>
        /// Provides the name or the Amazon Resource Name (ARN) of the             instance profile
        /// associated with the IAM role for the instance.             The instance profile contains
        /// the IAM role.        
        /// </para>
        /// </summary>
        public string IamInstanceProfile
        {
            get { return this._iamInstanceProfile; }
            set { this._iamInstanceProfile = value; }
        }


        /// <summary>
        /// Sets the IamInstanceProfile property
        /// </summary>
        /// <param name="iamInstanceProfile">The value to set for the IamInstanceProfile property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public LaunchConfiguration WithIamInstanceProfile(string iamInstanceProfile)
        {
            this._iamInstanceProfile = iamInstanceProfile;
            return this;
        }

        // Check to see if IamInstanceProfile property is set
        internal bool IsSetIamInstanceProfile()
        {
            return this._iamInstanceProfile != null;
        }


        /// <summary>
        /// Gets and sets the property ImageId. 
        /// <para>
        ///         Provides the unique ID of the <i>Amazon Machine Image</i> (AMI)        that
        /// was assigned during registration.        
        /// </para>
        /// </summary>
        public string ImageId
        {
            get { return this._imageId; }
            set { this._imageId = value; }
        }


        /// <summary>
        /// Sets the ImageId property
        /// </summary>
        /// <param name="imageId">The value to set for the ImageId property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public LaunchConfiguration WithImageId(string imageId)
        {
            this._imageId = imageId;
            return this;
        }

        // Check to see if ImageId property is set
        internal bool IsSetImageId()
        {
            return this._imageId != null;
        }


        /// <summary>
        /// Gets and sets the property InstanceMonitoring. 
        /// <para>
        ///         Controls whether instances in this group are launched with        detailed
        /// monitoring or not.                    
        /// </para>
        /// </summary>
        public InstanceMonitoring InstanceMonitoring
        {
            get { return this._instanceMonitoring; }
            set { this._instanceMonitoring = value; }
        }


        /// <summary>
        /// Sets the InstanceMonitoring property
        /// </summary>
        /// <param name="instanceMonitoring">The value to set for the InstanceMonitoring property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public LaunchConfiguration WithInstanceMonitoring(InstanceMonitoring instanceMonitoring)
        {
            this._instanceMonitoring = instanceMonitoring;
            return this;
        }

        // Check to see if InstanceMonitoring property is set
        internal bool IsSetInstanceMonitoring()
        {
            return this._instanceMonitoring != null;
        }


        /// <summary>
        /// Gets and sets the property InstanceType. 
        /// <para>
        ///         Specifies the instance type of the Amazon EC2 instance.        
        /// </para>
        /// </summary>
        public string InstanceType
        {
            get { return this._instanceType; }
            set { this._instanceType = value; }
        }


        /// <summary>
        /// Sets the InstanceType property
        /// </summary>
        /// <param name="instanceType">The value to set for the InstanceType property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public LaunchConfiguration WithInstanceType(string instanceType)
        {
            this._instanceType = instanceType;
            return this;
        }

        // Check to see if InstanceType property is set
        internal bool IsSetInstanceType()
        {
            return this._instanceType != null;
        }


        /// <summary>
        /// Gets and sets the property KernelId. 
        /// <para>
        ///         Provides the ID of the kernel associated with the Amazon EC2 AMI.        
        /// </para>
        /// </summary>
        public string KernelId
        {
            get { return this._kernelId; }
            set { this._kernelId = value; }
        }


        /// <summary>
        /// Sets the KernelId property
        /// </summary>
        /// <param name="kernelId">The value to set for the KernelId property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public LaunchConfiguration WithKernelId(string kernelId)
        {
            this._kernelId = kernelId;
            return this;
        }

        // Check to see if KernelId property is set
        internal bool IsSetKernelId()
        {
            return this._kernelId != null;
        }


        /// <summary>
        /// Gets and sets the property KeyName. 
        /// <para>
        ///         Provides the name of the Amazon EC2 key pair.        
        /// </para>
        /// </summary>
        public string KeyName
        {
            get { return this._keyName; }
            set { this._keyName = value; }
        }


        /// <summary>
        /// Sets the KeyName property
        /// </summary>
        /// <param name="keyName">The value to set for the KeyName property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public LaunchConfiguration WithKeyName(string keyName)
        {
            this._keyName = keyName;
            return this;
        }

        // Check to see if KeyName property is set
        internal bool IsSetKeyName()
        {
            return this._keyName != null;
        }


        /// <summary>
        /// Gets and sets the property LaunchConfigurationARN. 
        /// <para>
        ///             The launch configuration's Amazon Resource Name (ARN).        
        /// </para>
        /// </summary>
        public string LaunchConfigurationARN
        {
            get { return this._launchConfigurationARN; }
            set { this._launchConfigurationARN = value; }
        }


        /// <summary>
        /// Sets the LaunchConfigurationARN property
        /// </summary>
        /// <param name="launchConfigurationARN">The value to set for the LaunchConfigurationARN property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public LaunchConfiguration WithLaunchConfigurationARN(string launchConfigurationARN)
        {
            this._launchConfigurationARN = launchConfigurationARN;
            return this;
        }

        // Check to see if LaunchConfigurationARN property is set
        internal bool IsSetLaunchConfigurationARN()
        {
            return this._launchConfigurationARN != null;
        }


        /// <summary>
        /// Gets and sets the property LaunchConfigurationName. 
        /// <para>
        ///         Specifies the name of the launch configuration.        
        /// </para>
        /// </summary>
        public string LaunchConfigurationName
        {
            get { return this._launchConfigurationName; }
            set { this._launchConfigurationName = value; }
        }


        /// <summary>
        /// Sets the LaunchConfigurationName property
        /// </summary>
        /// <param name="launchConfigurationName">The value to set for the LaunchConfigurationName property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public LaunchConfiguration WithLaunchConfigurationName(string launchConfigurationName)
        {
            this._launchConfigurationName = launchConfigurationName;
            return this;
        }

        // Check to see if LaunchConfigurationName property is set
        internal bool IsSetLaunchConfigurationName()
        {
            return this._launchConfigurationName != null;
        }


        /// <summary>
        /// Gets and sets the property PlacementTenancy. 
        /// <para>
        /// Specifies the tenancy of the instance. It can be either <code>default</code> or <code>dedicated</code>.
        ///             An instance with <code>dedicated</code> tenancy runs in an isolated, single-tenant
        /// hardware and it can only be launched in a VPC.
        /// </para>
        /// </summary>
        public string PlacementTenancy
        {
            get { return this._placementTenancy; }
            set { this._placementTenancy = value; }
        }


        /// <summary>
        /// Sets the PlacementTenancy property
        /// </summary>
        /// <param name="placementTenancy">The value to set for the PlacementTenancy property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public LaunchConfiguration WithPlacementTenancy(string placementTenancy)
        {
            this._placementTenancy = placementTenancy;
            return this;
        }

        // Check to see if PlacementTenancy property is set
        internal bool IsSetPlacementTenancy()
        {
            return this._placementTenancy != null;
        }


        /// <summary>
        /// Gets and sets the property RamdiskId. 
        /// <para>
        ///         Provides ID of the RAM disk associated with the Amazon EC2 AMI.        
        /// </para>
        /// </summary>
        public string RamdiskId
        {
            get { return this._ramdiskId; }
            set { this._ramdiskId = value; }
        }


        /// <summary>
        /// Sets the RamdiskId property
        /// </summary>
        /// <param name="ramdiskId">The value to set for the RamdiskId property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public LaunchConfiguration WithRamdiskId(string ramdiskId)
        {
            this._ramdiskId = ramdiskId;
            return this;
        }

        // Check to see if RamdiskId property is set
        internal bool IsSetRamdiskId()
        {
            return this._ramdiskId != null;
        }


        /// <summary>
        /// Gets and sets the property SecurityGroups. 
        /// <para>
        ///         A description of the security        groups to associate with the Amazon EC2
        /// instances.        
        /// </para>
        /// </summary>
        public List<string> SecurityGroups
        {
            get { return this._securityGroups; }
            set { this._securityGroups = value; }
        }

        /// <summary>
        /// Sets the SecurityGroups property
        /// </summary>
        /// <param name="securityGroups">The values to add to the SecurityGroups collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public LaunchConfiguration WithSecurityGroups(params string[] securityGroups)
        {
            foreach (var element in securityGroups)
            {
                this._securityGroups.Add(element);
            }
            return this;
        }

        /// <summary>
        /// Sets the SecurityGroups property
        /// </summary>
        /// <param name="securityGroups">The values to add to the SecurityGroups collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public LaunchConfiguration WithSecurityGroups(IEnumerable<string> securityGroups)
        {
            foreach (var element in securityGroups)
            {
                this._securityGroups.Add(element);
            }
            return this;
        }
        // Check to see if SecurityGroups property is set
        internal bool IsSetSecurityGroups()
        {
            return this._securityGroups != null && this._securityGroups.Count > 0; 
        }


        /// <summary>
        /// Gets and sets the property SpotPrice. 
        /// <para>
        /// Specifies the price to bid when launching Spot Instances.
        /// </para>
        /// </summary>
        public string SpotPrice
        {
            get { return this._spotPrice; }
            set { this._spotPrice = value; }
        }


        /// <summary>
        /// Sets the SpotPrice property
        /// </summary>
        /// <param name="spotPrice">The value to set for the SpotPrice property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public LaunchConfiguration WithSpotPrice(string spotPrice)
        {
            this._spotPrice = spotPrice;
            return this;
        }

        // Check to see if SpotPrice property is set
        internal bool IsSetSpotPrice()
        {
            return this._spotPrice != null;
        }


        /// <summary>
        /// Gets and sets the property UserData. 
        /// <para>
        ///         The user data available to the launched Amazon EC2 instances.        
        /// </para>
        /// </summary>
        public string UserData
        {
            get { return this._userData; }
            set { this._userData = value; }
        }


        /// <summary>
        /// Sets the UserData property
        /// </summary>
        /// <param name="userData">The value to set for the UserData property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public LaunchConfiguration WithUserData(string userData)
        {
            this._userData = userData;
            return this;
        }

        // Check to see if UserData property is set
        internal bool IsSetUserData()
        {
            return this._userData != null;
        }

    }
}