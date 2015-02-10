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
    /// Container for the parameters to the DeleteVolume operation.
    /// Deletes the specified Amazon EBS volume. The volume must be in the <code>available</code>
    /// state (not attached to an instance).
    /// 
    ///  <note> 
    /// <para>
    /// The volume may remain in the <code>deleting</code> state for several minutes.
    /// </para>
    ///  </note> 
    /// <para>
    /// For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ebs-deleting-volume.html">Deleting
    /// an Amazon EBS Volume</a> in the <i>Amazon Elastic Compute Cloud User Guide for Linux</i>.
    /// </para>
    /// </summary>
    public partial class DeleteVolumeRequest : AmazonEC2Request
    {
        private string _volumeId;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public DeleteVolumeRequest() { }

        /// <summary>
        /// Instantiates DeleteVolumeRequest with the parameterized properties
        /// </summary>
        /// <param name="volumeId">The ID of the volume.</param>
        public DeleteVolumeRequest(string volumeId)
        {
            _volumeId = volumeId;
        }

        /// <summary>
        /// Gets and sets the property VolumeId. 
        /// <para>
        /// The ID of the volume.
        /// </para>
        /// </summary>
        public string VolumeId
        {
            get { return this._volumeId; }
            set { this._volumeId = value; }
        }

        // Check to see if VolumeId property is set
        internal bool IsSetVolumeId()
        {
            return this._volumeId != null;
        }

    }
}