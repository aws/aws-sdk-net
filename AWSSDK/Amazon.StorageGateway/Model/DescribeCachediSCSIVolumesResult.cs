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

namespace Amazon.StorageGateway.Model
{
    /// <summary>
    /// <para>A JSON object containing the following fields:</para>
    /// <ul>
    /// <li> DescribeCachediSCSIVolumesOutput$CachediSCSIVolumes </li>
    /// 
    /// </ul>
    /// </summary>
    public class DescribeCachediSCSIVolumesResult  
    {
        
        private List<CachediSCSIVolume> cachediSCSIVolumes = new List<CachediSCSIVolume>();

        /// <summary>
        /// An array of <a>CachediSCSIVolume</a> objects where each object contains metadata about one cached volume.
        ///  
        /// </summary>
        public List<CachediSCSIVolume> CachediSCSIVolumes
        {
            get { return this.cachediSCSIVolumes; }
            set { this.cachediSCSIVolumes = value; }
        }
        /// <summary>
        /// Adds elements to the CachediSCSIVolumes collection
        /// </summary>
        /// <param name="cachediSCSIVolumes">The values to add to the CachediSCSIVolumes collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeCachediSCSIVolumesResult WithCachediSCSIVolumes(params CachediSCSIVolume[] cachediSCSIVolumes)
        {
            foreach (CachediSCSIVolume element in cachediSCSIVolumes)
            {
                this.cachediSCSIVolumes.Add(element);
            }

            return this;
        }
        
        /// <summary>
        /// Adds elements to the CachediSCSIVolumes collection
        /// </summary>
        /// <param name="cachediSCSIVolumes">The values to add to the CachediSCSIVolumes collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeCachediSCSIVolumesResult WithCachediSCSIVolumes(IEnumerable<CachediSCSIVolume> cachediSCSIVolumes)
        {
            foreach (CachediSCSIVolume element in cachediSCSIVolumes)
            {
                this.cachediSCSIVolumes.Add(element);
            }

            return this;
        }

        // Check to see if CachediSCSIVolumes property is set
        internal bool IsSetCachediSCSIVolumes()
        {
            return this.cachediSCSIVolumes.Count > 0;       
        }
    }
}
