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
    /// The configuration for the optional provisioned SSD read cache on Amazon FSx for Lustre
    /// file systems that use the Intelligent-Tiering storage class.
    /// </summary>
    public partial class LustreReadCacheConfiguration
    {
        private int? _sizeGiB;
        private LustreReadCacheSizingMode _sizingMode;

        /// <summary>
        /// Gets and sets the property SizeGiB. 
        /// <para>
        ///  Required if <c>SizingMode</c> is set to <c>USER_PROVISIONED</c>. Specifies the size
        /// of the file system's SSD read cache, in gibibytes (GiB). 
        /// </para>
        ///  
        /// <para>
        /// The SSD read cache size is distributed across provisioned file servers in your file
        /// system. Intelligent-Tiering file systems support a minimum of 32 GiB and maximum of
        /// 131072 GiB for SSD read cache size for every 4,000 MB/s of throughput capacity provisioned.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2147483647)]
        public int? SizeGiB
        {
            get { return this._sizeGiB; }
            set { this._sizeGiB = value; }
        }

        // Check to see if SizeGiB property is set
        internal bool IsSetSizeGiB()
        {
            return this._sizeGiB.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SizingMode. 
        /// <para>
        ///  Specifies how the provisioned SSD read cache is sized, as follows: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Set to <c>NO_CACHE</c> if you do not want to use an SSD read cache with your Intelligent-Tiering
        /// file system.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Set to <c>USER_PROVISIONED</c> to specify the exact size of your SSD read cache.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Set to <c>PROPORTIONAL_TO_THROUGHPUT_CAPACITY</c> to have your SSD read cache automatically
        /// sized based on your throughput capacity.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public LustreReadCacheSizingMode SizingMode
        {
            get { return this._sizingMode; }
            set { this._sizingMode = value; }
        }

        // Check to see if SizingMode property is set
        internal bool IsSetSizingMode()
        {
            return this._sizingMode != null;
        }

    }
}