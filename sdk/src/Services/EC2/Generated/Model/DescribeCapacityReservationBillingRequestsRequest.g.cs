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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeCapacityReservationBillingRequests operation.
    /// Describes a request to assign the billing of the unused capacity of a Capacity Reservation.
    /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/transfer-billing.html">
    /// Billing assignment for shared Amazon EC2 Capacity Reservations</a>.
    /// </summary>
    public partial class DescribeCapacityReservationBillingRequestsRequest : AmazonEC2Request
    {
        /// <summary>
        /// Gets and sets the property CapacityReservationIds. 
        /// <para>
        /// The ID of the Capacity Reservation.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> CapacityReservationIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the CapacityReservationIds property is set.
        /// </summary>
        internal bool IsSetCapacityReservationIds() => this.CapacityReservationIds != null && (this.CapacityReservationIds.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property DryRun. 
        /// <para>
        /// Checks whether you have the required permissions for the action, without actually
        /// making the request, and provides an error response. If you have the required permissions,
        /// the error response is <c>DryRunOperation</c>. Otherwise, it is <c>UnauthorizedOperation</c>.
        /// </para>
        /// </summary>
        public bool? DryRun { get; set; }

        /// <summary>
        /// Checks to see if the DryRun property is set.
        /// </summary>
        internal bool IsSetDryRun() => this.DryRun.HasValue;

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// One or more filters.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>status</c> - The state of the request (<c>pending</c> | <c>accepted</c> | <c>rejected</c>
        /// | <c>cancelled</c> | <c>revoked</c> | <c>expired</c>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>requested-by</c> - The account ID of the Capacity Reservation owner that initiated
        /// the request. Not supported if you specify <c>requested-by</c> for <b>Role</b>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>unused-reservation-billing-owner</c> - The ID of the consumer account to which
        /// the request was sent. Not supported if you specify <c>unused-reservation-billing-owner</c>
        /// for <b>Role</b>.
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Filter> Filters { get; set; } = AWSConfigs.InitializeCollections ? new List<Filter>() : null;

        /// <summary>
        /// Checks to see if the Filters property is set.
        /// </summary>
        internal bool IsSetFilters() => this.Filters != null && (this.Filters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of items to return for this request. To get the next page of items,
        /// make another request with the token returned in the output. For more information,
        /// see <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/Query-Requests.html#api-pagination">Pagination</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1000)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token to use to retrieve the next page of results.
        /// </para>
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property Role. 
        /// <para>
        /// Specify one of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>odcr-owner</c> - If you are the Capacity Reservation owner, specify this value
        /// to view requests that you have initiated. Not supported with the <c>requested-by</c>
        /// filter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>unused-reservation-billing-owner</c> - If you are the consumer account, specify
        /// this value to view requests that have been sent to you. Not supported with the <c>unused-reservation-billing-owner</c>
        /// filter.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true)]
        public CallerRole Role { get; set; }

        /// <summary>
        /// Checks to see if the Role property is set.
        /// </summary>
        internal bool IsSetRole() => this.Role != null;
    }
}
