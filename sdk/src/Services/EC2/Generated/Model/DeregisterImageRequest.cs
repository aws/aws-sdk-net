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
    /// Container for the parameters to the DeregisterImage operation.
    /// Deregisters the specified AMI. A deregistered AMI can't be used to launch new instances.
    /// 
    ///  
    /// <para>
    /// If a deregistered EBS-backed AMI matches a Recycle Bin retention rule, it moves to
    /// the Recycle Bin for the specified retention period. It can be restored before its
    /// retention period expires, after which it is permanently deleted. If the deregistered
    /// AMI doesn't match a retention rule, it is permanently deleted immediately. For more
    /// information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/recycle-bin.html">Recover
    /// deleted Amazon EBS snapshots and EBS-backed AMIs with Recycle Bin</a> in the <i>Amazon
    /// EBS User Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// When deregistering an EBS-backed AMI, you can optionally delete its associated snapshots
    /// at the same time. However, if a snapshot is associated with multiple AMIs, it won't
    /// be deleted even if specified for deletion, although the AMI will still be deregistered.
    /// </para>
    ///  
    /// <para>
    /// Deregistering an AMI does not delete the following:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Instances already launched from the AMI. You'll continue to incur usage costs for
    /// the instances until you terminate them.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// For EBS-backed AMIs: Snapshots that are associated with multiple AMIs. You'll continue
    /// to incur snapshot storage costs.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// For instance store-backed AMIs: The files uploaded to Amazon S3 during AMI creation.
    /// You'll continue to incur S3 storage costs.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/deregister-ami.html">Deregister
    /// an Amazon EC2 AMI</a> in the <i>Amazon EC2 User Guide</i>.
    /// </para>
    /// </summary>
    public partial class DeregisterImageRequest : AmazonEC2Request
    {
        private bool? _deleteAssociatedSnapshots;
        private bool? _dryRun;
        private string _imageId;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public DeregisterImageRequest() { }

        /// <summary>
        /// Instantiates DeregisterImageRequest with the parameterized properties
        /// </summary>
        /// <param name="imageId">The ID of the AMI.</param>
        public DeregisterImageRequest(string imageId)
        {
            _imageId = imageId;
        }

        /// <summary>
        /// Gets and sets the property DeleteAssociatedSnapshots. 
        /// <para>
        /// Specifies whether to delete the snapshots associated with the AMI during deregistration.
        /// </para>
        ///  <note> 
        /// <para>
        /// If a snapshot is associated with multiple AMIs, it is not deleted, regardless of this
        /// setting.
        /// </para>
        ///  </note> 
        /// <para>
        /// Default: The snapshots are not deleted.
        /// </para>
        /// </summary>
        public bool? DeleteAssociatedSnapshots
        {
            get { return this._deleteAssociatedSnapshots; }
            set { this._deleteAssociatedSnapshots = value; }
        }

        // Check to see if DeleteAssociatedSnapshots property is set
        internal bool IsSetDeleteAssociatedSnapshots()
        {
            return this._deleteAssociatedSnapshots.HasValue; 
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
        /// Gets and sets the property ImageId. 
        /// <para>
        /// The ID of the AMI.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ImageId
        {
            get { return this._imageId; }
            set { this._imageId = value; }
        }

        // Check to see if ImageId property is set
        internal bool IsSetImageId()
        {
            return this._imageId != null;
        }

    }
}