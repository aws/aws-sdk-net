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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the RegisterImage operation.
    /// <para>Registers an AMI. When you're creating an AMI, this is the final step you must complete before you can launch an instance from the
    /// AMI. For more information about creating AMIs, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/creating-an-ami.html"
    /// >Creating Your Own AMIs</a> in the <i>Amazon Elastic Compute Cloud User Guide</i> .</para> <para><b>NOTE:</b> For Amazon EBS-backed
    /// instances, CreateImage creates and registers the AMI in a single request, so you don't have to register the AMI yourself. </para> <para>You
    /// can also use <c>RegisterImage</c> to create an Amazon EBS-backed AMI from a snapshot of a root device volume. For more information, see <a
    /// href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/Using_LaunchingInstanceFromSnapshot.html" >Launching an Instance from a
    /// Snapshot</a> in the <i>Amazon Elastic Compute Cloud User Guide</i> .</para> <para>If needed, you can deregister an AMI at any time. Any
    /// modifications you make to an AMI backed by an instance store volume invalidates its registration. If you make changes to an image,
    /// deregister the previous image and register the new image.</para> <para><b>NOTE:</b> You can't register an image where a secondary (non-root)
    /// snapshot has AWS Marketplace product codes. </para>
    /// </summary>
    public partial class RegisterImageRequest : AmazonEC2Request
    {
        private string imageLocation;
        private string name;
        private string description;
        private ArchitectureValues architecture;
        private string kernelId;
        private string ramdiskId;
        private string rootDeviceName;
        private List<BlockDeviceMapping> blockDeviceMappings = new List<BlockDeviceMapping>();
        private string virtualizationType;
        private string sriovNetSupport;


        /// <summary>
        /// The full path to your AMI manifest in Amazon S3 storage.
        ///  
        /// </summary>
        public string ImageLocation
        {
            get { return this.imageLocation; }
            set { this.imageLocation = value; }
        }

        // Check to see if ImageLocation property is set
        internal bool IsSetImageLocation()
        {
            return this.imageLocation != null;
        }

        /// <summary>
        /// A name for your AMI. Constraints: 3-128 alphanumeric characters, parenthesis (()), commas (,), slashes (/), dashes (-), or underscores (_)
        ///  
        /// </summary>
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this.name != null;
        }

        /// <summary>
        /// A description for your AMI.
        ///  
        /// </summary>
        public string Description
        {
            get { return this.description; }
            set { this.description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this.description != null;
        }

        /// <summary>
        /// The architecture of the AMI. Default: For Amazon EBS-backed AMIs, <c>i386</c>. For instance store-backed AMIs, the architecture specified in
        /// the manifest file.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>i386, x86_64</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public ArchitectureValues Architecture
        {
            get { return this.architecture; }
            set { this.architecture = value; }
        }

        // Check to see if Architecture property is set
        internal bool IsSetArchitecture()
        {
            return this.architecture != null;
        }

        /// <summary>
        /// The ID of the kernel.
        ///  
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
        /// The ID of the RAM disk.
        ///  
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
        /// The name of the root device (for example, <c>/dev/sda1</c>, or <c>xvda</c>).
        ///  
        /// </summary>
        public string RootDeviceName
        {
            get { return this.rootDeviceName; }
            set { this.rootDeviceName = value; }
        }

        // Check to see if RootDeviceName property is set
        internal bool IsSetRootDeviceName()
        {
            return this.rootDeviceName != null;
        }

        /// <summary>
        /// One or more block device mapping entries.
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
        /// The type of virtualization. Default: <c>paravirtual</c>
        ///  
        /// </summary>
        public string VirtualizationType
        {
            get { return this.virtualizationType; }
            set { this.virtualizationType = value; }
        }

        // Check to see if VirtualizationType property is set
        internal bool IsSetVirtualizationType()
        {
            return this.virtualizationType != null;
        }

        /// <summary>
        /// Set to <c>simple</c> to enable enhanced networking for the AMI and any instances that you launch from the AMI.
        ///  
        /// </summary>
        public string SriovNetSupport
        {
            get { return this.sriovNetSupport; }
            set { this.sriovNetSupport = value; }
        }

        // Check to see if SriovNetSupport property is set
        internal bool IsSetSriovNetSupport()
        {
            return this.sriovNetSupport != null;
        }

    }
}
    
