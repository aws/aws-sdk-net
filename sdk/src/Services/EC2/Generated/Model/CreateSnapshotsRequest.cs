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
    /// Container for the parameters to the CreateSnapshots operation.
    /// Creates crash-consistent snapshots of multiple EBS volumes attached to an Amazon EC2
    /// instance. Volumes are chosen by specifying an instance. Each volume attached to the
    /// specified instance will produce one snapshot that is crash-consistent across the instance.
    /// You can include all of the volumes currently attached to the instance, or you can
    /// exclude the root volume or specific data (non-root) volumes from the multi-volume
    /// snapshot set.
    /// 
    ///  
    /// <para>
    /// The location of the source instance determines where you can create the snapshots.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// If the source instance is in a Region, you must create the snapshots in the same Region
    /// as the instance.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If the source instance is in a Local Zone, you can create the snapshots in the same
    /// Local Zone or in its parent Amazon Web Services Region.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If the source instance is on an Outpost, you can create the snapshots on the same
    /// Outpost or in its parent Amazon Web Services Region.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class CreateSnapshotsRequest : AmazonEC2Request
    {
        private CopyTagsFromSource _copyTagsFromSource;
        private string _description;
        private bool? _dryRun;
        private InstanceSpecification _instanceSpecification;
        private SnapshotLocationEnum _location;
        private string _outpostArn;
        private List<TagSpecification> _tagSpecifications = AWSConfigs.InitializeCollections ? new List<TagSpecification>() : null;

        /// <summary>
        /// Gets and sets the property CopyTagsFromSource. 
        /// <para>
        /// Copies the tags from the specified volume to corresponding snapshot.
        /// </para>
        /// </summary>
        public CopyTagsFromSource CopyTagsFromSource
        {
            get { return this._copyTagsFromSource; }
            set { this._copyTagsFromSource = value; }
        }

        // Check to see if CopyTagsFromSource property is set
        internal bool IsSetCopyTagsFromSource()
        {
            return this._copyTagsFromSource != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        ///  A description propagated to every snapshot specified by the instance.
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
        /// Gets and sets the property InstanceSpecification. 
        /// <para>
        /// The instance to specify which volumes should be included in the snapshots.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public InstanceSpecification InstanceSpecification
        {
            get { return this._instanceSpecification; }
            set { this._instanceSpecification = value; }
        }

        // Check to see if InstanceSpecification property is set
        internal bool IsSetInstanceSpecification()
        {
            return this._instanceSpecification != null;
        }

        /// <summary>
        /// Gets and sets the property Location. <note> 
        /// <para>
        /// Only supported for instances in Local Zones. If the source instance is not in a Local
        /// Zone, omit this parameter.
        /// </para>
        ///  </note> <ul> <li> 
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
        /// Default value: <c>regional</c> 
        /// </para>
        /// </summary>
        public SnapshotLocationEnum Location
        {
            get { return this._location; }
            set { this._location = value; }
        }

        // Check to see if Location property is set
        internal bool IsSetLocation()
        {
            return this._location != null;
        }

        /// <summary>
        /// Gets and sets the property OutpostArn. <note> 
        /// <para>
        /// Only supported for instances on Outposts. If the source instance is not on an Outpost,
        /// omit this parameter.
        /// </para>
        ///  </note> <ul> <li> 
        /// <para>
        /// To create the snapshots on the same Outpost as the source instance, specify the ARN
        /// of that Outpost. The snapshots must be created on the same Outpost as the instance.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To create the snapshots in the parent Region of the Outpost, omit this parameter.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/ebs/latest/userguide/snapshots-outposts.html#create-snapshot">
        /// Create local snapshots from volumes on an Outpost</a> in the <i>Amazon EBS User Guide</i>.
        /// </para>
        /// </summary>
        public string OutpostArn
        {
            get { return this._outpostArn; }
            set { this._outpostArn = value; }
        }

        // Check to see if OutpostArn property is set
        internal bool IsSetOutpostArn()
        {
            return this._outpostArn != null;
        }

        /// <summary>
        /// Gets and sets the property TagSpecifications. 
        /// <para>
        /// Tags to apply to every snapshot specified by the instance.
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