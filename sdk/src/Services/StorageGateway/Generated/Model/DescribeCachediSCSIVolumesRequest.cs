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
 * Do not modify this file. This file is generated from the storagegateway-2013-06-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.StorageGateway.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeCachediSCSIVolumes operation.
    /// Returns a description of the gateway volumes specified in the request. This operation
    /// is only supported in the cached volume gateway types.
    /// 
    ///  
    /// <para>
    /// The list of gateway volumes in the request must be from one gateway. In the response,
    /// AWS Storage Gateway returns volume information sorted by volume Amazon Resource Name
    /// (ARN).
    /// </para>
    /// </summary>
    public partial class DescribeCachediSCSIVolumesRequest : AmazonStorageGatewayRequest
    {
        private List<string> _volumeARNs = new List<string>();

        /// <summary>
        /// Gets and sets the property VolumeARNs. 
        /// <para>
        /// An array of strings where each string represents the Amazon Resource Name (ARN) of
        /// a cached volume. All of the specified cached volumes must be from the same gateway.
        /// Use <a>ListVolumes</a> to get volume ARNs for a gateway.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> VolumeARNs
        {
            get { return this._volumeARNs; }
            set { this._volumeARNs = value; }
        }

        // Check to see if VolumeARNs property is set
        internal bool IsSetVolumeARNs()
        {
            return this._volumeARNs != null && this._volumeARNs.Count > 0; 
        }

    }
}