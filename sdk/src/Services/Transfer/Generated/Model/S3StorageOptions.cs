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
 * Do not modify this file. This file is generated from the transfer-2018-11-05.normal.json service model.
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
namespace Amazon.Transfer.Model
{
    /// <summary>
    /// The Amazon S3 storage options that are configured for your server.
    /// </summary>
    public partial class S3StorageOptions
    {
        private DirectoryListingOptimization _directoryListingOptimization;

        /// <summary>
        /// Gets and sets the property DirectoryListingOptimization. 
        /// <para>
        /// Specifies whether or not performance for your Amazon S3 directories is optimized.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If using the console, this is enabled by default.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If using the API or CLI, this is disabled by default.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// By default, home directory mappings have a <c>TYPE</c> of <c>DIRECTORY</c>. If you
        /// enable this option, you would then need to explicitly set the <c>HomeDirectoryMapEntry</c>
        /// <c>Type</c> to <c>FILE</c> if you want a mapping to have a file target.
        /// </para>
        /// </summary>
        public DirectoryListingOptimization DirectoryListingOptimization
        {
            get { return this._directoryListingOptimization; }
            set { this._directoryListingOptimization = value; }
        }

        // Check to see if DirectoryListingOptimization property is set
        internal bool IsSetDirectoryListingOptimization()
        {
            return this._directoryListingOptimization != null;
        }

    }
}