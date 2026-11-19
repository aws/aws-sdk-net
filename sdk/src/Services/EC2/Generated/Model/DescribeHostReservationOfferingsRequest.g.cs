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
    /// Container for the parameters to the DescribeHostReservationOfferings operation. Describes
    /// the Dedicated Host reservations that are available to purchase. <para> The results
    /// describe all of the Dedicated Host reservation offerings, including offerings that
    /// might not match the instance family and Region of your Dedicated Hosts. When purchasing
    /// an offering, ensure that the instance family and Region of the offering matches that
    /// of the Dedicated Hosts with which it is to be associated. For more information about
    /// supported instance types, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/dedicated-hosts-overview.html">Dedicated
    /// Hosts</a> in the <i>Amazon EC2 User Guide</i>. </para>
    /// </summary>
    public partial class DescribeHostReservationOfferingsRequest : AmazonEC2Request
    {
        /// <summary>
        /// Gets and sets the property Filter. 
        /// <para>
        /// The filters.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>instance-family</c> - The instance family of the offering (for example, <c>m4</c>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>payment-option</c> - The payment option (<c>NoUpfront</c> | <c>PartialUpfront</c>
        /// | <c>AllUpfront</c>).
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Filter> Filter { get; set; } = AWSConfigs.InitializeCollections ? new List<Filter>() : null;

        /// <summary>
        /// Checks to see if the Filter property is set.
        /// </summary>
        internal bool IsSetFilter() => this.Filter != null && (this.Filter.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property MaxDuration. 
        /// <para>
        /// This is the maximum duration of the reservation to purchase, specified in seconds.
        /// Reservations are available in one-year and three-year terms. The number of seconds
        /// specified must be the number of seconds in a year (365x24x60x60) times one of the
        /// supported durations (1 or 3). For example, specify 94608000 for three years.
        /// </para>
        /// </summary>
        public int? MaxDuration { get; set; }

        /// <summary>
        /// Checks to see if the MaxDuration property is set.
        /// </summary>
        internal bool IsSetMaxDuration() => this.MaxDuration.HasValue;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return for the request in a single page. The remaining
        /// results can be seen by sending another request with the returned <c>nextToken</c>
        /// value. This value can be between 5 and 500. If <c>maxResults</c> is given a larger
        /// value than 500, you receive an error.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 5, Max = 500)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property MinDuration. 
        /// <para>
        /// This is the minimum duration of the reservation you'd like to purchase, specified
        /// in seconds. Reservations are available in one-year and three-year terms. The number
        /// of seconds specified must be the number of seconds in a year (365x24x60x60) times
        /// one of the supported durations (1 or 3). For example, specify 31536000 for one year.
        /// </para>
        /// </summary>
        public int? MinDuration { get; set; }

        /// <summary>
        /// Checks to see if the MinDuration property is set.
        /// </summary>
        internal bool IsSetMinDuration() => this.MinDuration.HasValue;

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
        /// Gets and sets the property OfferingId. 
        /// <para>
        /// The ID of the reservation offering.
        /// </para>
        /// </summary>
        public string OfferingId { get; set; }

        /// <summary>
        /// Checks to see if the OfferingId property is set.
        /// </summary>
        internal bool IsSetOfferingId() => this.OfferingId != null;
    }
}
