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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        /// <summary>
        /// Gets and sets the property Marker. 
        /// <para>
        /// A pagination token provided by a previous <c>DescribeReservedNodeExchangeStatus</c>
        /// request.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public string Marker { get; set; }

        /// <summary>
        /// Checks to see if the Marker property is set.
        /// </summary>
        internal bool IsSetMarker() => this.Marker != null;

        /// <summary>
        /// Gets and sets the property ReservedNodeExchangeStatusDetails. 
        /// <para>
        /// The details of the reserved-node exchange request, including the status, request time,
        /// source reserved-node identifier, and additional details.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ReservedNodeExchangeStatus> ReservedNodeExchangeStatusDetails { get; set; } = AWSConfigs.InitializeCollections ? new List<ReservedNodeExchangeStatus>() : null;

        /// <summary>
        /// Checks to see if the ReservedNodeExchangeStatusDetails property is set.
        /// </summary>
        internal bool IsSetReservedNodeExchangeStatusDetails() => this.ReservedNodeExchangeStatusDetails != null && (this.ReservedNodeExchangeStatusDetails.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
