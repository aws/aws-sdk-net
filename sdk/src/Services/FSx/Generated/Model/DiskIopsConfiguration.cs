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
 * Do not modify this file. This file is generated from the fsx-2018-03-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.FSx.Model
{
    /// <summary>
    /// The SSD IOPS (input/output operations per second) configuration for an Amazon FSx
    /// for NetApp ONTAP or Amazon FSx for OpenZFS file system. The default is 3 IOPS per
    /// GB of storage capacity, but you can provision additional IOPS per GB of storage. The
    /// configuration consists of the total number of provisioned SSD IOPS and how the amount
    /// was provisioned (by the customer or by the system).
    /// </summary>
    public partial class DiskIopsConfiguration
    {
        private long? _iops;
        private DiskIopsConfigurationMode _mode;

        /// <summary>
        /// Gets and sets the property Iops. 
        /// <para>
        /// The total number of SSD IOPS provisioned for the file system.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1000000)]
        public long Iops
        {
            get { return this._iops.GetValueOrDefault(); }
            set { this._iops = value; }
        }

        // Check to see if Iops property is set
        internal bool IsSetIops()
        {
            return this._iops.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Mode. 
        /// <para>
        /// Specifies whether the number of IOPS for the file system is using the system default
        /// (<code>AUTOMATIC</code>) or was provisioned by the customer (<code>USER_PROVISIONED</code>).
        /// </para>
        /// </summary>
        public DiskIopsConfigurationMode Mode
        {
            get { return this._mode; }
            set { this._mode = value; }
        }

        // Check to see if Mode property is set
        internal bool IsSetMode()
        {
            return this._mode != null;
        }

    }
}