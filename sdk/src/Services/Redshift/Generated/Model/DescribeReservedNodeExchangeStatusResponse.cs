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
 * Do not modify this file. This file is generated from the redshift-2012-12-01.normal.json service model.
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
namespace Amazon.Redshift.Model
{
    /// <summary>
    /// This is the response object from the DescribeReservedNodeExchangeStatus operation.
    /// </summary>
    public partial class DescribeReservedNodeExchangeStatusResponse : AmazonWebServiceResponse
    {
        private string _marker;
        private List<ReservedNodeExchangeStatus> _reservedNodeExchangeStatusDetails = AWSConfigs.InitializeCollections ? new List<ReservedNodeExchangeStatus>() : null;

        /// <summary>
        /// Gets and sets the property Marker. 
        /// <para>
        /// A pagination token provided by a previous <c>DescribeReservedNodeExchangeStatus</c>
        /// request.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2147483647)]
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
        /// Gets and sets the property ReservedNodeExchangeStatusDetails. 
        /// <para>
        /// The details of the reserved-node exchange request, including the status, request time,
        /// source reserved-node identifier, and additional details.
        /// </para>
        /// </summary>
        public List<ReservedNodeExchangeStatus> ReservedNodeExchangeStatusDetails
        {
            get { return this._reservedNodeExchangeStatusDetails; }
            set { this._reservedNodeExchangeStatusDetails = value; }
        }

        // Check to see if ReservedNodeExchangeStatusDetails property is set
        internal bool IsSetReservedNodeExchangeStatusDetails()
        {
            return this._reservedNodeExchangeStatusDetails != null && (this._reservedNodeExchangeStatusDetails.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}