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
    /// Container for the parameters to the ListFileShares operation.
    /// Gets a list of the file shares for a specific S3 File Gateway, or the list of file
    /// shares that belong to the calling Amazon Web Services account. This operation is only
    /// supported for S3 File Gateways.
    /// </summary>
    public partial class ListFileSharesRequest : AmazonStorageGatewayRequest
    {
        private string _gatewayARN;
        private int? _limit;
        private string _marker;

        /// <summary>
        /// Gets and sets the property GatewayARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the gateway whose file shares you want to list.
        /// If this field is not present, all file shares under your account are listed.
        /// </para>
        /// </summary>
        [AWSProperty(Min=50, Max=500)]
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

        /// <summary>
        /// Gets and sets the property Limit. 
        /// <para>
        /// The maximum number of file shares to return in the response. The value must be an
        /// integer with a value greater than zero. Optional.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public int? Limit
        {
            get { return this._limit; }
            set { this._limit = value; }
        }

        // Check to see if Limit property is set
        internal bool IsSetLimit()
        {
            return this._limit.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Marker. 
        /// <para>
        /// Opaque pagination token returned from a previous ListFileShares operation. If present,
        /// <c>Marker</c> specifies where to continue the list from after a previous call to ListFileShares.
        /// Optional.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2000)]
        public string Marker
        {
            get { return this._marker; }
            set { this._marker = value; }
        }

        // Check to see if Marker property is set
        internal bool IsSetMarker()
        {
            return this._marker != null;
        }

    }
}