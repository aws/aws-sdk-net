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
    /// Container for the parameters to the ResetCache operation.
    /// Resets all cache disks that have encountered a error and makes the disks available
    /// for reconfiguration as cache storage. If your cache disk encounters a error, the gateway
    /// prevents read and write operations on virtual tapes in the gateway. For example, an
    /// error can occur when a disk is corrupted or removed from the gateway. When a cache
    /// is reset, the gateway loses its cache storage. At this point you can reconfigure the
    /// disks as cache disks. This operation is only supported in the cached volume and tape
    /// types.
    /// 
    ///  <important> 
    /// <para>
    /// If the cache disk you are resetting contains data that has not been uploaded to Amazon
    /// S3 yet, that data can be lost. After you reset cache disks, there will be no configured
    /// cache disks left in the gateway, so you must configure at least one new cache disk
    /// for your gateway to function properly.
    /// </para>
    ///  </important>
    /// </summary>
    public partial class ResetCacheRequest : AmazonStorageGatewayRequest
    {
        private string _gatewayARN;

        /// <summary>
        /// Gets and sets the property GatewayARN.
        /// </summary>
        public string GatewayARN
        {
            get { return this._gatewayARN; }
            set { this._gatewayARN = value; }
        }

        // Check to see if GatewayARN property is set
        internal bool IsSetGatewayARN()
        {
            return this._gatewayARN != null;
        }

    }
}