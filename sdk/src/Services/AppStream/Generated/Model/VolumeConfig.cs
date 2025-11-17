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
 * Do not modify this file. This file is generated from the appstream-2016-12-01.normal.json service model.
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
namespace Amazon.AppStream.Model
{
    /// <summary>
    /// Configuration for the root volume of fleet instances and image builders. This allows
    /// you to customize the storage capacity beyond the default 200 GB.
    /// </summary>
    public partial class VolumeConfig
    {
        private int? _volumeSizeInGb;

        /// <summary>
        /// Gets and sets the property VolumeSizeInGb. 
        /// <para>
        /// The size of the root volume in GB. Valid range is 200-500 GB. The default is 200 GB,
        /// which is included in the hourly instance rate. Additional storage beyond 200 GB incurs
        /// extra charges and applies to instances regardless of their running state.
        /// </para>
        /// </summary>
        public int VolumeSizeInGb
        {
            get { return this._volumeSizeInGb.GetValueOrDefault(); }
            set { this._volumeSizeInGb = value; }
        }

        // Check to see if VolumeSizeInGb property is set
        internal bool IsSetVolumeSizeInGb()
        {
            return this._volumeSizeInGb.HasValue; 
        }

    }
}