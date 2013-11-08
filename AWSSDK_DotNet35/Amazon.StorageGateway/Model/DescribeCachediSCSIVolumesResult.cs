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

namespace Amazon.StorageGateway.Model
{
    /// <summary>
    /// <para>A JSON object containing the following fields:</para>
    /// </summary>
    public partial class DescribeCachediSCSIVolumesResult : AmazonWebServiceResponse
    {
        
        private List<CachediSCSIVolume> cachediSCSIVolumes = new List<CachediSCSIVolume>();


        /// <summary>
        /// An array of objects where each object contains metadata about one cached volume.
        ///  
        /// </summary>
        public List<CachediSCSIVolume> CachediSCSIVolumes
        {
            get { return this.cachediSCSIVolumes; }
            set { this.cachediSCSIVolumes = value; }
        }

        // Check to see if CachediSCSIVolumes property is set
        internal bool IsSetCachediSCSIVolumes()
        {
            return this.cachediSCSIVolumes.Count > 0;
        }
    }
}
