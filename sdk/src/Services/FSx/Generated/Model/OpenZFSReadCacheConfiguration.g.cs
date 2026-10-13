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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// The configuration for the optional provisioned SSD read cache on Amazon FSx for OpenZFS
    /// file systems that use the Intelligent-Tiering storage class.
    /// </summary>
    public partial class OpenZFSReadCacheConfiguration
    {
        /// <summary>
        /// Gets and sets the property SizeGiB. 
        /// <para>
        ///  Required if <c>SizingMode</c> is set to <c>USER_PROVISIONED</c>. Specifies the size
        /// of the file system's SSD read cache, in gibibytes (GiB). 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public int? SizeGiB { get; set; }

        /// <summary>
        /// Checks to see if the SizeGiB property is set.
        /// </summary>
        internal bool IsSetSizeGiB() => this.SizeGiB.HasValue;

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
        public OpenZFSReadCacheSizingMode SizingMode { get; set; }

        /// <summary>
        /// Checks to see if the SizingMode property is set.
        /// </summary>
        internal bool IsSetSizingMode() => this.SizingMode != null;
    }
}
