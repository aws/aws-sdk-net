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
    /// Container for the parameters to the CreateReplaceRootVolumeTask operation.
    /// Replaces the EBS-backed root volume for a <code>running</code> instance with a new
    /// volume that is restored to the original root volume's launch state, that is restored
    /// to a specific snapshot taken from the original root volume, or that is restored from
    /// an AMI that has the same key characteristics as that of the instance.
    /// 
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/replace-root.html">Replace
    /// a root volume</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
    /// </para>
    /// </summary>
    public partial class CreateReplaceRootVolumeTaskRequest : AmazonEC2Request
    {
        private string _clientToken;
        private bool? _deleteReplacedRootVolume;
        private string _imageId;
        private string _instanceId;
        private string _snapshotId;
        private List<TagSpecification> _tagSpecifications = new List<TagSpecification>();

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// Unique, case-sensitive identifier you provide to ensure the idempotency of the request.
        /// If you do not specify a client token, a randomly generated token is used for the request
        /// to ensure idempotency. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/Run_Instance_Idempotency.html">Ensuring
        /// idempotency</a>.
        /// </para>
        /// </summary>
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property DeleteReplacedRootVolume. 
        /// <para>
        /// Indicates whether to automatically delete the original root volume after the root
        /// volume replacement task completes. To delete the original root volume, specify <code>true</code>.
        /// If you choose to keep the original root volume after the replacement task completes,
        /// you must manually delete it when you no longer need it.
        /// </para>
        /// </summary>
        public bool DeleteReplacedRootVolume
        {
            get { return this._deleteReplacedRootVolume.GetValueOrDefault(); }
            set { this._deleteReplacedRootVolume = value; }
        }

        // Check to see if DeleteReplacedRootVolume property is set
        internal bool IsSetDeleteReplacedRootVolume()
        {
            return this._deleteReplacedRootVolume.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ImageId. 
        /// <para>
        /// The ID of the AMI to use to restore the root volume. The specified AMI must have the
        /// same product code, billing information, architecture type, and virtualization type
        /// as that of the instance.
        /// </para>
        ///  
        /// <para>
        /// If you want to restore the replacement volume from a specific snapshot, or if you
        /// want to restore it to its launch state, omit this parameter.
        /// </para>
        /// </summary>
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

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The ID of the instance for which to replace the root volume.
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
        /// Gets and sets the property SnapshotId. 
        /// <para>
        /// The ID of the snapshot from which to restore the replacement root volume. The specified
        /// snapshot must be a snapshot that you previously created from the original root volume.
        /// </para>
        ///  
        /// <para>
        /// If you want to restore the replacement root volume to the initial launch state, or
        /// if you want to restore the replacement root volume from an AMI, omit this parameter.
        /// </para>
        /// </summary>
        public string SnapshotId
        {
            get { return this._snapshotId; }
            set { this._snapshotId = value; }
        }

        // Check to see if SnapshotId property is set
        internal bool IsSetSnapshotId()
        {
            return this._snapshotId != null;
        }

        /// <summary>
        /// Gets and sets the property TagSpecifications. 
        /// <para>
        /// The tags to apply to the root volume replacement task.
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