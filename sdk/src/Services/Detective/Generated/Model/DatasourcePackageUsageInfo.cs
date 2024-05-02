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
 * Do not modify this file. This file is generated from the detective-2018-10-26.normal.json service model.
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
namespace Amazon.Detective.Model
{
    /// <summary>
    /// Information on the usage of a data source package in the behavior graph.
    /// </summary>
    public partial class DatasourcePackageUsageInfo
    {
        private long? _volumeUsageInBytes;
        private DateTime? _volumeUsageUpdateTime;

        /// <summary>
        /// Gets and sets the property VolumeUsageInBytes. 
        /// <para>
        /// Total volume of data in bytes per day ingested for a given data source package.
        /// </para>
        /// </summary>
        public long? VolumeUsageInBytes
        {
            get { return this._volumeUsageInBytes; }
            set { this._volumeUsageInBytes = value; }
        }

        // Check to see if VolumeUsageInBytes property is set
        internal bool IsSetVolumeUsageInBytes()
        {
            return this._volumeUsageInBytes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property VolumeUsageUpdateTime. 
        /// <para>
        /// The data and time when the member account data volume was last updated. The value
        /// is an ISO8601 formatted string. For example, <c>2021-08-18T16:35:56.284Z</c>.
        /// </para>
        /// </summary>
        public DateTime? VolumeUsageUpdateTime
        {
            get { return this._volumeUsageUpdateTime; }
            set { this._volumeUsageUpdateTime = value; }
        }

        // Check to see if VolumeUsageUpdateTime property is set
        internal bool IsSetVolumeUsageUpdateTime()
        {
            return this._volumeUsageUpdateTime.HasValue; 
        }

    }
}