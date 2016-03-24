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
    /// Container for the parameters to the AddUploadBuffer operation.
    /// Configures one or more gateway local disks as upload buffer for a specified gateway.
    /// This operation is supported for both the gateway-stored and gateway-cached volume
    /// architectures. 
    /// 
    ///  
    /// <para>
    ///  In the request, you specify the gateway Amazon Resource Name (ARN) to which you want
    /// to add upload buffer, and one or more disk IDs that you want to configure as upload
    /// buffer.
    /// </para>
    /// </summary>
    public partial class AddUploadBufferRequest : AmazonStorageGatewayRequest
    {
        private List<string> _diskIds = new List<string>();
        private string _gatewayARN;

        /// <summary>
        /// Gets and sets the property DiskIds.
        /// </summary>
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