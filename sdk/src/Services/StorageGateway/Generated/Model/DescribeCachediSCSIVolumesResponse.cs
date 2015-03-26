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
 * Do not modify this file. This file is generated from the storagegateway-2013-06-30.normal.json service model.
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
    /// A JSON object containing the following fields:
    /// </summary>
    public partial class DescribeCachediSCSIVolumesResponse : AmazonWebServiceResponse
    {
        private List<CachediSCSIVolume> _cachediSCSIVolumes = new List<CachediSCSIVolume>();

        /// <summary>
        /// Gets and sets the property CachediSCSIVolumes. 
        /// <para>
        /// An array of objects where each object contains metadata about one cached volume.
        /// </para>
        /// </summary>
        public List<CachediSCSIVolume> CachediSCSIVolumes
        {
            get { return this._cachediSCSIVolumes; }
            set { this._cachediSCSIVolumes = value; }
        }

        // Check to see if CachediSCSIVolumes property is set
        internal bool IsSetCachediSCSIVolumes()
        {
            return this._cachediSCSIVolumes != null && this._cachediSCSIVolumes.Count > 0; 
        }

    }
}