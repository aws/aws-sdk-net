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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.FSx.Model
{
    /// <summary>
    /// The SSD IOPS (input/output operations per second) configuration for an Amazon FSx
    /// for NetApp ONTAP, Amazon FSx for Windows File Server, or FSx for OpenZFS file system.
    /// By default, Amazon FSx automatically provisions 3 IOPS per GB of storage capacity.
    /// You can provision additional IOPS per GB of storage. The configuration consists of
    /// the total number of provisioned SSD IOPS and how it is was provisioned, or the mode
    /// (by the customer or by Amazon FSx).
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
        ///  
        /// <para>
        /// The minimum and maximum values for this property depend on the value of <c>HAPairs</c>
        /// and <c>StorageCapacity</c>. The minimum value is calculated as <c>StorageCapacity</c>
        /// * 3 * <c>HAPairs</c> (3 IOPS per GB of <c>StorageCapacity</c>). The maximum value
        /// is calculated as 200,000 * <c>HAPairs</c>.
        /// </para>
        ///  
        /// <para>
        /// Amazon FSx responds with an HTTP status code 400 (Bad Request) if the value of <c>Iops</c>
        /// is outside of the minimum or maximum values.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2400000)]
        public long? Iops
        {
            get { return this._iops; }
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
        /// Specifies whether the file system is using the <c>AUTOMATIC</c> setting of SSD IOPS
        /// of 3 IOPS per GB of storage capacity, or if it using a <c>USER_PROVISIONED</c> value.
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