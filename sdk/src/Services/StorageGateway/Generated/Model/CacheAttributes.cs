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
 * Do not modify this file. This file is generated from the storagegateway-2013-06-30.normal.json service model.
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
namespace Amazon.StorageGateway.Model
{
    /// <summary>
    /// The refresh cache information for the file share or FSx file systems.
    /// </summary>
    public partial class CacheAttributes
    {
        private int? _cacheStaleTimeoutInSeconds;

        /// <summary>
        /// Gets and sets the property CacheStaleTimeoutInSeconds. 
        /// <para>
        /// Refreshes a file share's cache by using Time To Live (TTL). TTL is the length of time
        /// since the last refresh after which access to the directory would cause the file gateway
        /// to first refresh that directory's contents from the Amazon S3 bucket or Amazon FSx
        /// file system. The TTL duration is in seconds.
        /// </para>
        ///  
        /// <para>
        /// Valid Values:0, 300 to 2,592,000 seconds (5 minutes to 30 days)
        /// </para>
        /// </summary>
        public int? CacheStaleTimeoutInSeconds
        {
            get { return this._cacheStaleTimeoutInSeconds; }
            set { this._cacheStaleTimeoutInSeconds = value; }
        }

        // Check to see if CacheStaleTimeoutInSeconds property is set
        internal bool IsSetCacheStaleTimeoutInSeconds()
        {
            return this._cacheStaleTimeoutInSeconds.HasValue; 
        }

    }
}