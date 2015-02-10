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

/*
 * Do not modify this file. This file is generated from the ec2-2014-10-01.normal.json service model.
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
    /// Registers an AMI. When you're creating an AMI, this is the final step you must complete
    /// before you can launch an instance from the AMI. For more information about creating
    /// AMIs, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/creating-an-ami.html">Creating
    /// Your Own AMIs</a> in the <i>Amazon Elastic Compute Cloud User Guide for Linux</i>.
    /// 
    ///  <note>
    /// <para>
    /// For Amazon EBS-backed instances, <a>CreateImage</a> creates and registers the AMI
    /// in a single request, so you don't have to register the AMI yourself.
    /// </para>
    /// </note> 
    /// <para>
    /// You can also use <code>RegisterImage</code> to create an Amazon EBS-backed AMI from
    /// a snapshot of a root device volume. For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/Using_LaunchingInstanceFromSnapshot.html">Launching
    /// an Instance from a Snapshot</a> in the <i>Amazon Elastic Compute Cloud User Guide
    /// for Linux</i>.
    /// </para>
    ///  
    /// <para>
    /// If needed, you can deregister an AMI at any time. Any modifications you make to an
    /// AMI backed by an instance store volume invalidates its registration. If you make changes
    /// to an image, deregister the previous image and register the new image.
    /// </para>
    ///  <note>
    /// <para>
    /// You can't register an image where a secondary (non-root) snapshot has AWS Marketplace
    /// product codes.
    /// </para>
    /// </note>
    /// </summary>
    public partial class RegisterImageRequest : AmazonEC2Request
    {
        private ArchitectureValues _architecture;
        private List<BlockDeviceMapping> _blockDeviceMappings = new List<BlockDeviceMapping>();
        private string _description;
        private string _imageLocation;
        private string _kernelId;
        private string _name;
        private string _ramdiskId;
        private string _rootDeviceName;
        private string _sriovNetSupport;
        private string _virtualizationType;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public RegisterImageRequest() { }

        /// <summary>
        /// Instantiates RegisterImageRequest with the parameterized properties
        /// </summary>
        /// <param name="imageLocation">The full path to your AMI manifest in Amazon S3 storage.</param>
        public RegisterImageRequest(string imageLocation)
        {
            _imageLocation = imageLocation;
        }

        /// <summary>
        /// Gets and sets the property Architecture. 
        /// <para>
        /// The architecture of the AMI.
        /// </para>
        ///  
        /// <para>
        /// Default: For Amazon EBS-backed AMIs, <code>i386</code>. For instance store-backed
        /// AMIs, the architecture specified in the manifest file.
        /// </para>
        /// </summary>
        public ArchitectureValues Architecture
        {
            get { return this._architecture; }
            set { this._architecture = value; }
        }

        // Check to see if Architecture property is set
        internal bool IsSetArchitecture()
        {
            return this._architecture != null;
        }

        /// <summary>
        /// Gets and sets the property BlockDeviceMappings. 
        /// <para>
        /// One or more block device mapping entries.
        /// </para>
        /// </summary>
        public List<BlockDeviceMapping> BlockDeviceMappings
        {
            get { return this._blockDeviceMappings; }
            set { this._blockDeviceMappings = value; }
        }

        // Check to see if BlockDeviceMappings property is set
        internal bool IsSetBlockDeviceMappings()
        {
            return this._blockDeviceMappings != null && this._blockDeviceMappings.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description for your AMI.
        /// </para>
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property ImageLocation. 
        /// <para>
        /// The full path to your AMI manifest in Amazon S3 storage.
        /// </para>
        /// </summary>
        public string ImageLocation
        {
            get { return this._imageLocation; }
            set { this._imageLocation = value; }
        }

        // Check to see if ImageLocation property is set
        internal bool IsSetImageLocation()
        {
            return this._imageLocation != null;
        }

        /// <summary>
        /// Gets and sets the property KernelId. 
        /// <para>
        /// The ID of the kernel.
        /// </para>
        /// </summary>
        public string KernelId
        {
            get { return this._kernelId; }
            set { this._kernelId = value; }
        }

        // Check to see if KernelId property is set
        internal bool IsSetKernelId()
        {
            return this._kernelId != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A name for your AMI.
        /// </para>
        ///  
        /// <para>
        /// Constraints: 3-128 alphanumeric characters, parentheses (()), square brackets ([]),
        /// spaces ( ), periods (.), slashes (/), dashes (-), single quotes ('), at-signs (@),
        /// or underscores(_)
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
        /// Gets and sets the property RamdiskId. 
        /// <para>
        /// The ID of the RAM disk.
        /// </para>
        /// </summary>
        public string RamdiskId
        {
            get { return this._ramdiskId; }
            set { this._ramdiskId = value; }
        }

        // Check to see if RamdiskId property is set
        internal bool IsSetRamdiskId()
        {
            return this._ramdiskId != null;
        }

        /// <summary>
        /// Gets and sets the property RootDeviceName. 
        /// <para>
        /// The name of the root device (for example, <code>/dev/sda1</code>, or <code>xvda</code>).
        /// </para>
        /// </summary>
        public string RootDeviceName
        {
            get { return this._rootDeviceName; }
            set { this._rootDeviceName = value; }
        }

        // Check to see if RootDeviceName property is set
        internal bool IsSetRootDeviceName()
        {
            return this._rootDeviceName != null;
        }

        /// <summary>
        /// Gets and sets the property SriovNetSupport. 
        /// <para>
        /// Set to <code>simple</code> to enable enhanced networking for the AMI and any instances
        /// that you launch from the AMI.
        /// </para>
        ///  
        /// <para>
        /// There is no way to disable enhanced networking at this time.
        /// </para>
        ///  
        /// <para>
        /// This option is supported only for HVM AMIs. Specifying this option with a PV AMI can
        /// make instances launched from the AMI unreachable.
        /// </para>
        /// </summary>
        public string SriovNetSupport
        {
            get { return this._sriovNetSupport; }
            set { this._sriovNetSupport = value; }
        }

        // Check to see if SriovNetSupport property is set
        internal bool IsSetSriovNetSupport()
        {
            return this._sriovNetSupport != null;
        }

        /// <summary>
        /// Gets and sets the property VirtualizationType. 
        /// <para>
        /// The type of virtualization.
        /// </para>
        ///  
        /// <para>
        /// Default: <code>paravirtual</code>
        /// </para>
        /// </summary>
        public string VirtualizationType
        {
            get { return this._virtualizationType; }
            set { this._virtualizationType = value; }
        }

        // Check to see if VirtualizationType property is set
        internal bool IsSetVirtualizationType()
        {
            return this._virtualizationType != null;
        }

    }
}