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

namespace Amazon.ARCZonalShift.Model
{
    /// <summary>
    /// Container for the parameters to the ListZonalShifts operation. Lists all active and
    /// completed zonal shifts in Amazon Application Recovery Controller in your Amazon Web
    /// Services account in this Amazon Web Services Region. <c>ListZonalShifts</c> returns
    /// customer-initiated zonal shifts, as well as practice run zonal shifts that ARC started
    /// on your behalf for zonal autoshift. <para> For more information about listing autoshifts,
    /// see <a href="https://docs.aws.amazon.com/arc-zonal-shift/latest/api/API_ListAutoshifts.html">"&gt;ListAutoshifts</a>.
    /// </para>
    /// </summary>
    public partial class ListZonalShiftsRequest : AmazonARCZonalShiftRequest
    {
        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The number of objects that you want to return with this call.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// Specifies that you want to receive the next page of results. Valid only if you received
        /// a <c>nextToken</c> response in the previous request. If you did, it indicates that
        /// more output is available. Set this parameter to the value provided by the previous
        /// call's <c>nextToken</c> response to request the next page of results.
        /// </para>
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property ResourceIdentifier. 
        /// <para>
        /// The identifier for the resource that you want to list zonal shifts for. The identifier
        /// is the Amazon Resource Name (ARN) for the resource.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 8, Max = 1024)]
        public string ResourceIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the ResourceIdentifier property is set.
        /// </summary>
        internal bool IsSetResourceIdentifier() => this.ResourceIdentifier != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// A status for a zonal shift.
        /// </para>
        ///  
        /// <para>
        /// The <c>Status</c> for a zonal shift can have one of the following values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>ACTIVE</b>: The zonal shift has been started and is active.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>EXPIRED</b>: The zonal shift has expired (the expiry time was exceeded).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>CANCELED</b>: The zonal shift was canceled.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ZonalShiftStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
