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
    /// Container for the parameters to the DescribeTapes operation.
    /// Returns a description of the specified Amazon Resource Name (ARN) of virtual tapes.
    /// If a <code>TapeARN</code> is not specified, returns a description of all virtual tapes
    /// associated with the specified gateway.
    /// </summary>
    public partial class DescribeTapesRequest : AmazonStorageGatewayRequest
    {
        private string _gatewayARN;
        private int? _limit;
        private string _marker;
        private List<string> _tapeARNs = new List<string>();

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

        /// <summary>
        /// Gets and sets the property Limit. 
        /// <para>
        /// Specifies that the number of virtual tapes described be limited to the specified number.
        /// </para>
        ///  <note>Amazon Web Services may impose its own limit, if this field is not set.</note>
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
        /// A marker value, obtained in a previous call to <code>DescribeTapes</code>. This marker
        /// indicates which page of results to retrieve. 
        /// </para>
        ///  
        /// <para>
        /// If not specified, the first page of results is retrieved.
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
        /// <para>
        /// Specifies one or more unique Amazon Resource Names (ARNs) that represent the virtual
        /// tapes you want to describe. If this parameter is not specified, AWS Storage Gateway
        /// returns a description of all virtual tapes associated with the specified gateway.
        /// </para>
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