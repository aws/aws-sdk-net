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
    /// Container for the parameters to the DescribeTapes operation.
    /// Returns a description of virtual tapes that correspond to the specified Amazon Resource
    /// Names (ARNs). If <c>TapeARN</c> is not specified, returns a description of the virtual
    /// tapes associated with the specified gateway. This operation is only supported for
    /// the tape gateway type.
    /// 
    ///  
    /// <para>
    /// The operation supports pagination. By default, the operation returns a maximum of
    /// up to 100 tapes. You can optionally specify the <c>Limit</c> field in the body to
    /// limit the number of tapes in the response. If the number of tapes returned in the
    /// response is truncated, the response includes a <c>Marker</c> field. You can use this
    /// <c>Marker</c> value in your subsequent request to retrieve the next set of tapes.
    /// </para>
    /// </summary>
    public partial class DescribeTapesRequest : AmazonStorageGatewayRequest
    {
        private string _gatewayARN;
        private int? _limit;
        private string _marker;
        private List<string> _tapeARNs = AWSConfigs.InitializeCollections ? new List<string>() : null;

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

        /// <summary>
        /// Gets and sets the property Limit. 
        /// <para>
        /// Specifies that the number of virtual tapes described be limited to the specified number.
        /// </para>
        ///  <note> 
        /// <para>
        /// Amazon Web Services may impose its own limit, if this field is not set.
        /// </para>
        ///  </note>
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
        /// A marker value, obtained in a previous call to <c>DescribeTapes</c>. This marker indicates
        /// which page of results to retrieve.
        /// </para>
        ///  
        /// <para>
        /// If not specified, the first page of results is retrieved.
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

        /// <summary>
        /// Gets and sets the property TapeARNs. 
        /// <para>
        /// Specifies one or more unique Amazon Resource Names (ARNs) that represent the virtual
        /// tapes you want to describe. If this parameter is not specified, Tape gateway returns
        /// a description of all virtual tapes associated with the specified gateway.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> TapeARNs
        {
            get { return this._tapeARNs; }
            set { this._tapeARNs = value; }
        }

        // Check to see if TapeARNs property is set
        internal bool IsSetTapeARNs()
        {
            return this._tapeARNs != null && (this._tapeARNs.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}