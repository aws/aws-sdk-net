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
    /// Container for the parameters to the ListLocalDisks operation.
    /// Returns a list of the gateway's local disks. To specify which gateway to describe,
    /// you use the Amazon Resource Name (ARN) of the gateway in the body of the request.
    /// 
    ///  
    /// <para>
    /// The request returns a list of all disks, specifying which are configured as working
    /// storage, cache storage, or stored volume or not configured at all. The response includes
    /// a <c>DiskStatus</c> field. This field can have a value of present (the disk is available
    /// to use), missing (the disk is no longer connected to the gateway), or mismatch (the
    /// disk node is occupied by a disk that has incorrect metadata or the disk content is
    /// corrupted).
    /// </para>
    /// </summary>
    public partial class ListLocalDisksRequest : AmazonStorageGatewayRequest
    {
        private string _gatewayARN;

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