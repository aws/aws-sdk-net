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
    /// Container for the parameters to the CreateSnapshots operation.
    /// Creates crash-consistent snapshots of multiple EBS volumes and stores the data in
    /// S3. Volumes are chosen by specifying an instance. Any attached volumes will produce
    /// one snapshot each that is crash-consistent across the instance.
    /// 
    ///  
    /// <para>
    /// You can include all of the volumes currently attached to the instance, or you can
    /// exclude the root volume or specific data (non-root) volumes from the multi-volume
    /// snapshot set.
    /// </para>
    ///  
    /// <para>
    /// You can create multi-volume snapshots of instances in a Region and instances on an
    /// Outpost. If you create snapshots from an instance in a Region, the snapshots must
    /// be stored in the same Region as the instance. If you create snapshots from an instance
    /// on an Outpost, the snapshots can be stored on the same Outpost as the instance, or
    /// in the Region for that Outpost.
    /// </para>
    /// </summary>
    public partial class CreateSnapshotsRequest : AmazonEC2Request
    {
        private CopyTagsFromSource _copyTagsFromSource;
        private string _description;
        private InstanceSpecification _instanceSpecification;
        private string _outpostArn;
        private List<TagSpecification> _tagSpecifications = new List<TagSpecification>();

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
        /// Gets and sets the property OutpostArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Outpost on which to create the local snapshots.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// To create snapshots from an instance in a Region, omit this parameter. The snapshots
        /// are created in the same Region as the instance.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To create snapshots from an instance on an Outpost and store the snapshots in the
        /// Region, omit this parameter. The snapshots are created in the Region for the Outpost.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To create snapshots from an instance on an Outpost and store the snapshots on an Outpost,
        /// specify the ARN of the destination Outpost. The snapshots must be created on the same
        /// Outpost as the instance.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/snapshots-outposts.html#create-multivol-snapshot">
        /// Create multi-volume local snapshots from instances on an Outpost</a> in the <i>Amazon
        /// Elastic Compute Cloud User Guide</i>.
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