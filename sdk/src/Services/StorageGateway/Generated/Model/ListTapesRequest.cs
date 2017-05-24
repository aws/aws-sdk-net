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
    /// Container for the parameters to the ListTapes operation.
    /// Lists virtual tapes in your virtual tape library (VTL) and your virtual tape shelf
    /// (VTS). You specify the tapes to list by specifying one or more tape Amazon Resource
    /// Names (ARNs). If you don't specify a tape ARN, the operation lists all virtual tapes
    /// in both your VTL and VTS.
    /// 
    ///  
    /// <para>
    /// This operation supports pagination. By default, the operation returns a maximum of
    /// up to 100 tapes. You can optionally specify the <code>Limit</code> parameter in the
    /// body to limit the number of tapes in the response. If the number of tapes returned
    /// in the response is truncated, the response includes a <code>Marker</code> element
    /// that you can use in your subsequent request to retrieve the next set of tapes. This
    /// operation is only supported in the tape gateway architecture.
    /// </para>
    /// </summary>
    public partial class ListTapesRequest : AmazonStorageGatewayRequest
    {
        private int? _limit;
        private string _marker;
        private List<string> _tapeARNs = new List<string>();

        /// <summary>
        /// Gets and sets the property Limit. 
        /// <para>
        /// An optional number limit for the tapes in the list returned by this call.
        /// </para>
        /// </summary>
        public int Limit
        {
            get { return this._limit.GetValueOrDefault(); }
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
        /// A string that indicates the position at which to begin the returned list of tapes.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property TapeARNs.
        /// </summary>
        public List<string> TapeARNs
        {
            get { return this._tapeARNs; }
            set { this._tapeARNs = value; }
        }

        // Check to see if TapeARNs property is set
        internal bool IsSetTapeARNs()
        {
            return this._tapeARNs != null && this._tapeARNs.Count > 0; 
        }

    }
}