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
    /// Container for the parameters to the CreateImage operation.
    /// Creates an Amazon EBS-backed AMI from an Amazon EBS-backed instance that is either
    /// running or stopped.
    /// 
    ///  
    /// <para>
    /// If you customized your instance with instance store volumes or Amazon EBS volumes
    /// in addition to the root device volume, the new AMI contains block device mapping information
    /// for those volumes. When you launch an instance from this new AMI, the instance automatically
    /// launches with those additional volumes.
    /// </para>
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/creating-an-ami-ebs.html">Create
    /// an Amazon EBS-backed Linux AMI</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
    /// </para>
    /// </summary>
    public partial class CreateImageRequest : AmazonEC2Request
    {
        private List<BlockDeviceMapping> _blockDeviceMappings = new List<BlockDeviceMapping>();
        private string _description;
        private string _instanceId;
        private string _name;
        private bool? _noReboot;
        private List<TagSpecification> _tagSpecifications = new List<TagSpecification>();

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public CreateImageRequest() { }

        /// <summary>
        /// Instantiates CreateImageRequest with the parameterized properties
        /// </summary>
        /// <param name="instanceId">The ID of the instance.</param>
        /// <param name="name">A name for the new image. Constraints: 3-128 alphanumeric characters, parentheses (()), square brackets ([]), spaces ( ), periods (.), slashes (/), dashes (-), single quotes ('), at-signs (@), or underscores(_)</param>
        public CreateImageRequest(string instanceId, string name)
        {
            _instanceId = instanceId;
            _name = name;
        }

        /// <summary>
        /// Gets and sets the property BlockDeviceMappings. 
        /// <para>
        /// The block device mappings. This parameter cannot be used to modify the encryption
        /// status of existing volumes or snapshots. To create an AMI with encrypted snapshots,
        /// use the <a>CopyImage</a> action.
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
        /// A description for the new image.
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
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The ID of the instance.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string InstanceId
        {
            get { return this._instanceId; }
            set { this._instanceId = value; }
        }

        // Check to see if InstanceId property is set
        internal bool IsSetInstanceId()
        {
            return this._instanceId != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A name for the new image.
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
        /// Gets and sets the property NoReboot. 
        /// <para>
        /// Indicates whether or not the instance should be automatically rebooted before creating
        /// the image. Specify one of the following values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>true</code> - The instance is not rebooted before creating the image. This
        /// creates crash-consistent snapshots that include only the data that has been written
        /// to the volumes at the time the snapshots are created. Buffered data and data in memory
        /// that has not yet been written to the volumes is not included in the snapshots.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>false</code> - The instance is rebooted before creating the image. This ensures
        /// that all buffered data and data in memory is written to the volumes before the snapshots
        /// are created.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Default: <code>false</code> 
        /// </para>
        /// </summary>
        public bool NoReboot
        {
            get { return this._noReboot.GetValueOrDefault(); }
            set { this._noReboot = value; }
        }

        // Check to see if NoReboot property is set
        internal bool IsSetNoReboot()
        {
            return this._noReboot.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TagSpecifications. 
        /// <para>
        /// The tags to apply to the AMI and snapshots on creation. You can tag the AMI, the snapshots,
        /// or both.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// To tag the AMI, the value for <code>ResourceType</code> must be <code>image</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To tag the snapshots that are created of the root volume and of other Amazon EBS volumes
        /// that are attached to the instance, the value for <code>ResourceType</code> must be
        /// <code>snapshot</code>. The same tag is applied to all of the snapshots that are created.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If you specify other values for <code>ResourceType</code>, the request fails.
        /// </para>
        ///  
        /// <para>
        /// To tag an AMI or snapshot after it has been created, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_CreateTags.html">CreateTags</a>.
        /// 
        /// </para>
        /// </summary>
        public List<TagSpecification> TagSpecifications
        {
            get { return this._tagSpecifications; }
            set { this._tagSpecifications = value; }
        }

        // Check to see if TagSpecifications property is set
        internal bool IsSetTagSpecifications()
        {
            return this._tagSpecifications != null && this._tagSpecifications.Count > 0; 
        }

    }
}