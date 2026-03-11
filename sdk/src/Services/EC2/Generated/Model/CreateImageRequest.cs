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

#pragma warning disable CS0612,CS0618,CS1570
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
    /// The location of the source instance determines where you can create the snapshots
    /// of the AMI:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// If the source instance is in a Region, you must create the snapshots in the same Region
    /// as the instance.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If the source instance is in a Local Zone, you can create the snapshots in the same
    /// Local Zone or in its parent Region.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/creating-an-ami-ebs.html">Create
    /// an Amazon EBS-backed AMI</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
    /// </para>
    /// </summary>
    public partial class CreateImageRequest : AmazonEC2Request
    {
        private List<BlockDeviceMapping> _blockDeviceMappings = AWSConfigs.InitializeCollections ? new List<BlockDeviceMapping>() : null;
        private string _description;
        private bool? _dryRun;
        private string _instanceId;
        private string _name;
        private bool? _noReboot;
        private SnapshotLocationEnum _snapshotLocation;
        private List<TagSpecification> _tagSpecifications = AWSConfigs.InitializeCollections ? new List<TagSpecification>() : null;

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
        /// The block device mappings.
        /// </para>
        ///  
        /// <para>
        /// When using the CreateImage action:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You can't change the volume size using the VolumeSize parameter. If you want a different
        /// volume size, you must first change the volume size of the source instance.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You can't modify the encryption status of existing volumes or snapshots. To create
        /// an AMI with volumes or snapshots that have a different encryption status (for example,
        /// where the source volume and snapshots are unencrypted, and you want to create an AMI
        /// with encrypted volumes or snapshots), copy the image instead.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The only option that can be changed for existing mappings or snapshots is <c>DeleteOnTermination</c>.
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<BlockDeviceMapping> BlockDeviceMappings
        {
            get { return this._blockDeviceMappings; }
            set { this._blockDeviceMappings = value; }
        }

        // Check to see if BlockDeviceMappings property is set
        internal bool IsSetBlockDeviceMappings()
        {
            return this._blockDeviceMappings != null && (this._blockDeviceMappings.Count > 0 || !AWSConfigs.InitializeCollections); 
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
        /// Gets and sets the property DryRun. 
        /// <para>
        /// Checks whether you have the required permissions for the action, without actually
        /// making the request, and provides an error response. If you have the required permissions,
        /// the error response is <c>DryRunOperation</c>. Otherwise, it is <c>UnauthorizedOperation</c>.
        /// </para>
        /// </summary>
        public bool? DryRun
        {
            get { return this._dryRun; }
            set { this._dryRun = value; }
        }

        // Check to see if DryRun property is set
        internal bool IsSetDryRun()
        {
            return this._dryRun.HasValue; 
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
        ///  <c>true</c> - The instance is not rebooted before creating the image. This creates
        /// crash-consistent snapshots that include only the data that has been written to the
        /// volumes at the time the snapshots are created. Buffered data and data in memory that
        /// has not yet been written to the volumes is not included in the snapshots.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>false</c> - The instance is rebooted before creating the image. This ensures that
        /// all buffered data and data in memory is written to the volumes before the snapshots
        /// are created.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Default: <c>false</c> 
        /// </para>
        /// </summary>
        public bool? NoReboot
        {
            get { return this._noReboot; }
            set { this._noReboot = value; }
        }

        // Check to see if NoReboot property is set
        internal bool IsSetNoReboot()
        {
            return this._noReboot.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SnapshotLocation. <note> 
        /// <para>
        /// Only supported for instances in Local Zones. If the source instance is not in a Local
        /// Zone, omit this parameter.
        /// </para>
        ///  </note> 
        /// <para>
        /// The Amazon S3 location where the snapshots will be stored.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// To create local snapshots in the same Local Zone as the source instance, specify <c>local</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To create regional snapshots in the parent Region of the Local Zone, specify <c>regional</c>
        /// or omit this parameter.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Default: <c>regional</c> 
        /// </para>
        /// </summary>
        public SnapshotLocationEnum SnapshotLocation
        {
            get { return this._snapshotLocation; }
            set { this._snapshotLocation = value; }
        }

        // Check to see if SnapshotLocation property is set
        internal bool IsSetSnapshotLocation()
        {
            return this._snapshotLocation != null;
        }

        /// <summary>
        /// Gets and sets the property TagSpecifications. 
        /// <para>
        /// The tags to apply to the AMI and snapshots on creation. You can tag the AMI, the snapshots,
        /// or both.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// To tag the AMI, the value for <c>ResourceType</c> must be <c>image</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To tag the snapshots that are created of the root volume and of other Amazon EBS volumes
        /// that are attached to the instance, the value for <c>ResourceType</c> must be <c>snapshot</c>.
        /// The same tag is applied to all of the snapshots that are created.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If you specify other values for <c>ResourceType</c>, the request fails.
        /// </para>
        ///  
        /// <para>
        /// To tag an AMI or snapshot after it has been created, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_CreateTags.html">CreateTags</a>.
        /// 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<TagSpecification> TagSpecifications
        {
            get { return this._tagSpecifications; }
            set { this._tagSpecifications = value; }
        }

        // Check to see if TagSpecifications property is set
        internal bool IsSetTagSpecifications()
        {
            return this._tagSpecifications != null && (this._tagSpecifications.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}