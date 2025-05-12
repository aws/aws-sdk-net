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
    /// Container for the parameters to the ListGateways operation.
    /// Lists gateways owned by an Amazon Web Services account in an Amazon Web Services Region
    /// specified in the request. The returned list is ordered by gateway Amazon Resource
    /// Name (ARN).
    /// 
    ///  
    /// <para>
    /// By default, the operation returns a maximum of 100 gateways. This operation supports
    /// pagination that allows you to optionally reduce the number of gateways returned in
    /// a response.
    /// </para>
    ///  
    /// <para>
    /// If you have more gateways than are returned in a response (that is, the response returns
    /// only a truncated list of your gateways), the response contains a marker that you can
    /// specify in your next request to fetch the next page of gateways.
    /// </para>
    /// </summary>
    public partial class ListGatewaysRequest : AmazonStorageGatewayRequest
    {
        private int? _limit;
        private string _marker;

        /// <summary>
        /// Gets and sets the property Limit. 
        /// <para>
        /// Specifies that the list of gateways returned be limited to the specified number of
        /// items.
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
        /// An opaque string that indicates the position at which to begin the returned list of
        /// gateways.
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