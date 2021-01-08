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

namespace Amazon.StorageGateway.Model
{
    /// <summary>
    /// Container for the parameters to the AddCache operation.
    /// Configures one or more gateway local disks as cache for a gateway. This operation
    /// is only supported in the cached volume, tape, and file gateway type (see <a href="https://docs.aws.amazon.com/storagegateway/latest/userguide/StorageGatewayConcepts.html">How
    /// AWS Storage Gateway works (architecture)</a>.
    /// 
    ///  
    /// <para>
    /// In the request, you specify the gateway Amazon Resource Name (ARN) to which you want
    /// to add cache, and one or more disk IDs that you want to configure as cache.
    /// </para>
    /// </summary>
    public partial class AddCacheRequest : AmazonStorageGatewayRequest
    {
        private List<string> _diskIds = new List<string>();
        private string _gatewayARN;

        /// <summary>
        /// Gets and sets the property DiskIds. 
        /// <para>
        /// An array of strings that identify disks that are to be configured as working storage.
        /// Each string has a minimum length of 1 and maximum length of 300. You can get the disk
        /// IDs from the <a>ListLocalDisks</a> API.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> DiskIds
        {
            get { return this._diskIds; }
            set { this._diskIds = value; }
        }

        // Check to see if DiskIds property is set
        internal bool IsSetDiskIds()
        {
            return this._diskIds != null && this._diskIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property GatewayARN.
        /// </summary>
        [AWSProperty(Required=true, Min=50, Max=500)]
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