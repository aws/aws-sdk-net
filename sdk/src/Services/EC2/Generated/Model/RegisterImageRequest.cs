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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the RegisterImage operation.
    /// Registers an AMI. When you're creating an AMI, this is the final step you must complete
    /// before you can launch an instance from the AMI. For more information about creating
    /// AMIs, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/creating-an-ami.html">Creating
    /// your own AMIs</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
    /// 
    ///  <note> 
    /// <para>
    /// For Amazon EBS-backed instances, <a>CreateImage</a> creates and registers the AMI
    /// in a single request, so you don't have to register the AMI yourself.
    /// </para>
    ///  </note> 
    /// <para>
    /// You can also use <code>RegisterImage</code> to create an Amazon EBS-backed Linux AMI
    /// from a snapshot of a root device volume. You specify the snapshot using the block
    /// device mapping. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/instance-launch-snapshot.html">Launching
    /// a Linux instance from a backup</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// If any snapshots have AWS Marketplace product codes, they are copied to the new AMI.
    /// </para>
    ///  
    /// <para>
    /// Windows and some Linux distributions, such as Red Hat Enterprise Linux (RHEL) and
    /// SUSE Linux Enterprise Server (SLES), use the EC2 billing product code associated with
    /// an AMI to verify the subscription status for package updates. To create a new AMI
    /// for operating systems that require a billing product code, instead of registering
    /// the AMI, do the following to preserve the billing product code association:
    /// </para>
    ///  <ol> <li> 
    /// <para>
    /// Launch an instance from an existing AMI with that billing product code.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Customize the instance.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Create an AMI from the instance using <a>CreateImage</a>.
    /// </para>
    ///  </li> </ol> 
    /// <para>
    /// If you purchase a Reserved Instance to apply to an On-Demand Instance that was launched
    /// from an AMI with a billing product code, make sure that the Reserved Instance has
    /// the matching billing product code. If you purchase a Reserved Instance without the
    /// matching billing product code, the Reserved Instance will not be applied to the On-Demand
    /// Instance. For information about how to obtain the platform details and billing information
    /// of an AMI, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ami-billing-info.html">Obtaining
    /// billing information</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// If needed, you can deregister an AMI at any time. Any modifications you make to an
    /// AMI backed by an instance store volume invalidates its registration. If you make changes
    /// to an image, deregister the previous image and register the new image.
    /// </para>
    /// </summary>
    public partial class RegisterImageRequest : AmazonEC2Request
    {
        private ArchitectureValues _architecture;
        private List<string> _billingProducts = new List<string>();
        private List<BlockDeviceMapping> _blockDeviceMappings = new List<BlockDeviceMapping>();
        private string _description;
        private bool? _enaSupport;
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
        /// <param name="imageLocation">The full path to your AMI manifest in Amazon S3 storage. The specified bucket must have the <code>aws-exec-read</code> canned access control list (ACL) to ensure that it can be accessed by Amazon EC2. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/acl-overview.html#canned-acl">Canned ACLs</a> in the <i>Amazon S3 Service Developer Guide</i>.</param>
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
        /// Gets and sets the property BillingProducts. 
        /// <para>
        /// The billing product codes. Your account must be authorized to specify billing product
        /// codes. Otherwise, you can use the AWS Marketplace to bill for the use of an AMI.
        /// </para>
        /// </summary>
        public List<string> BillingProducts
        {
            get { return this._billingProducts; }
            set { this._billingProducts = value; }
        }

        // Check to see if BillingProducts property is set
        internal bool IsSetBillingProducts()
        {
            return this._billingProducts != null && this._billingProducts.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property BlockDeviceMappings. 
        /// <para>
        /// The block device mapping entries.
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
        /// Gets and sets the property EnaSupport. 
        /// <para>
        /// Set to <code>true</code> to enable enhanced networking with ENA for the AMI and any
        /// instances that you launch from the AMI.
        /// </para>
        ///  
        /// <para>
        /// This option is supported only for HVM AMIs. Specifying this option with a PV AMI can
        /// make instances launched from the AMI unreachable.
        /// </para>
        /// </summary>
        public bool EnaSupport
        {
            get { return this._enaSupport.GetValueOrDefault(); }
            set { this._enaSupport = value; }
        }

        // Check to see if EnaSupport property is set
        internal bool IsSetEnaSupport()
        {
            return this._enaSupport.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ImageLocation. 
        /// <para>
        /// The full path to your AMI manifest in Amazon S3 storage. The specified bucket must
        /// have the <code>aws-exec-read</code> canned access control list (ACL) to ensure that
        /// it can be accessed by Amazon EC2. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/acl-overview.html#canned-acl">Canned
        /// ACLs</a> in the <i>Amazon S3 Service Developer Guide</i>.
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
        [AWSProperty(Required=true)]
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
        /// The device name of the root device volume (for example, <code>/dev/sda1</code>).
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
        /// Set to <code>simple</code> to enable enhanced networking with the Intel 82599 Virtual
        /// Function interface for the AMI and any instances that you launch from the AMI.
        /// </para>
        ///  
        /// <para>
        /// There is no way to disable <code>sriovNetSupport</code> at this time.
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
        /// The type of virtualization (<code>hvm</code> | <code>paravirtual</code>).
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