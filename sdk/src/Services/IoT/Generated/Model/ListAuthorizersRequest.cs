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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IoT.Model
{
    /// <summary>
    /// Container for the parameters to the ListAuthorizers operation.
    /// Lists the authorizers registered in your account.
    /// </summary>
    public partial class ListAuthorizersRequest : AmazonIoTRequest
    {
        private bool? _ascendingOrder;
        private string _marker;
        private int? _pageSize;
        private AuthorizerStatus _status;

        /// <summary>
        /// Gets and sets the property AscendingOrder. 
        /// <para>
        /// Return the list of authorizers in ascending alphabetical order.
        /// </para>
        /// </summary>
        public bool AscendingOrder
        {
            get { return this._ascendingOrder.GetValueOrDefault(); }
            set { this._ascendingOrder = value; }
        }

        // Check to see if AscendingOrder property is set
        internal bool IsSetAscendingOrder()
        {
            return this._ascendingOrder.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Marker. 
        /// <para>
        /// A marker used to get the next set of results.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1024)]
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

        /// <summary>
        /// Gets and sets the property PageSize. 
        /// <para>
        /// The maximum number of results to return at one time.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=250)]
        public int PageSize
        {
            get { return this._pageSize.GetValueOrDefault(); }
            set { this._pageSize = value; }
        }

        // Check to see if PageSize property is set
        internal bool IsSetPageSize()
        {
            return this._pageSize.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the list authorizers request.
        /// </para>
        /// </summary>
        public AuthorizerStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}