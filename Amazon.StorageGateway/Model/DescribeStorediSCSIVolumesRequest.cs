/*
 * Copyright 2010-2012 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// Container for the parameters to the DescribeStorediSCSIVolumes operation.
    /// <para>This operation returns description of the gateway volumes specified in the request. The list of gateway volumes in the request must be
    /// from one gateway. In the response Amazon Storage Gateway returns volume information sorted by volume ARNs.</para>
    /// </summary>
    /// <seealso cref="Amazon.StorageGateway.AmazonStorageGateway.DescribeStorediSCSIVolumes"/>
    public class DescribeStorediSCSIVolumesRequest : AmazonWebServiceRequest
    {
        private List<string> volumeARNs = new List<string>();

        /// <summary>
        /// An array of strings where each string represents the Amazon Resource Name (ARN) of a stored volume. All of the specified stored volumes must
        /// from the same gateway. Use <a>ListVolumes</a> to get volume ARNs for a gateway.
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
        public DescribeStorediSCSIVolumesRequest WithVolumeARNs(params string[] volumeARNs)
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
        public DescribeStorediSCSIVolumesRequest WithVolumeARNs(IEnumerable<string> volumeARNs)
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
    
