/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.StorageGateway.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeCachediSCSIVolumes operation.
    /// <para>This operation returns a description of the gateway volumes specified in the request. This operation is supported only for the
    /// gateway-cached volume architecture.</para> <para> The list of gateway volumes in the request must be from one gateway. In the response
    /// Amazon Storage Gateway returns volume information sorted by volume Amazon Resource Name (ARN). </para>
    /// </summary>
    /// <seealso cref="Amazon.StorageGateway.AmazonStorageGateway.DescribeCachediSCSIVolumes"/>
    public class DescribeCachediSCSIVolumesRequest : AmazonWebServiceRequest
    {
        private List<string> volumeARNs = new List<string>();

        /// <summary>
        /// An array of strings, where each string represents the Amazon Resource Name (ARN) of a cached volume. All of the specified cached volumes
        /// must be from the same gateway. Use <a>ListVolumes</a> to get volume ARNs of a gateway.
        ///  
        /// </summary>
        public List<string> VolumeARNs
        {
            get { return this.volumeARNs; }
            set { this.volumeARNs = value; }
        }
        /// <summary>
        /// Adds elements to the VolumeARNs collection
        /// </summary>
        /// <param name="volumeARNs">The values to add to the VolumeARNs collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeCachediSCSIVolumesRequest WithVolumeARNs(params string[] volumeARNs)
        {
            foreach (string element in volumeARNs)
            {
                this.volumeARNs.Add(element);
            }

            return this;
        }
        
        /// <summary>
        /// Adds elements to the VolumeARNs collection
        /// </summary>
        /// <param name="volumeARNs">The values to add to the VolumeARNs collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeCachediSCSIVolumesRequest WithVolumeARNs(IEnumerable<string> volumeARNs)
        {
            foreach (string element in volumeARNs)
            {
                this.volumeARNs.Add(element);
            }

            return this;
        }

        // Check to see if VolumeARNs property is set
        internal bool IsSetVolumeARNs()
        {
            return this.volumeARNs.Count > 0;       
        }
    }
}
    
