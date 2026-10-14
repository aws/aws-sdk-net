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

namespace Amazon.CostExplorer.Model
{
    /// <summary>
    /// Container for the parameters to the GetReservationPurchaseRecommendation operation.
    /// Gets recommendations for reservation purchases. These recommendations might help you
    /// to reduce your costs. Reservations provide a discounted hourly rate (up to 75%) compared
    /// to On-Demand pricing. <para> Amazon Web Services generates your recommendations by
    /// identifying your On-Demand usage during a specific time period and collecting your
    /// usage into categories that are eligible for a reservation. After Amazon Web Services
    /// has these categories, it simulates every combination of reservations in each category
    /// of usage to identify the best number of each type of Reserved Instance (RI) to purchase
    /// to maximize your estimated savings. </para> <para> For example, Amazon Web Services
    /// automatically aggregates your Amazon EC2 Linux, shared tenancy, and c4 family usage
    /// in the US West (Oregon) Region and recommends that you buy size-flexible regional
    /// reservations to apply to the c4 family usage. Amazon Web Services recommends the smallest
    /// size instance in an instance family. This makes it easier to purchase a size-flexible
    /// Reserved Instance (RI). Amazon Web Services also shows the equal number of normalized
    /// units. This way, you can purchase any instance size that you want. For this example,
    /// your RI recommendation is for <c>c4.large</c> because that is the smallest size instance
    /// in the c4 instance family. </para>
    /// </summary>
    public partial class GetReservationPurchaseRecommendationRequest : AmazonCostExplorerRequest
    {
        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The account ID that's associated with the recommendation. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string AccountId { get; set; }

        /// <summary>
        /// Checks to see if the AccountId property is set.
        /// </summary>
        internal bool IsSetAccountId() => this.AccountId != null;

        /// <summary>
        /// Gets and sets the property AccountScope. 
        /// <para>
        /// The account scope that you want your recommendations for. Amazon Web Services calculates
        /// recommendations including the management account and member accounts if the value
        /// is set to <c>PAYER</c>. If the value is <c>LINKED</c>, recommendations are calculated
        /// for individual member accounts only.
        /// </para>
        /// </summary>
        public AccountScope AccountScope { get; set; }

        /// <summary>
        /// Checks to see if the AccountScope property is set.
        /// </summary>
        internal bool IsSetAccountScope() => this.AccountScope != null;

        /// <summary>
        /// Gets and sets the property Filter.
        /// </summary>
        public Expression Filter { get; set; }

        /// <summary>
        /// Checks to see if the Filter property is set.
        /// </summary>
        internal bool IsSetFilter() => this.Filter != null;

        /// <summary>
        /// Gets and sets the property LookbackPeriodInDays. 
        /// <para>
        /// The number of previous days that you want Amazon Web Services to consider when it
        /// calculates your recommendations.
        /// </para>
        /// </summary>
        public LookbackPeriodInDays LookbackPeriodInDays { get; set; }

        /// <summary>
        /// Checks to see if the LookbackPeriodInDays property is set.
        /// </summary>
        internal bool IsSetLookbackPeriodInDays() => this.LookbackPeriodInDays != null;

        /// <summary>
        /// Gets and sets the property NextPageToken. 
        /// <para>
        /// The pagination token that indicates the next set of results that you want to retrieve.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 8192)]
        public string NextPageToken { get; set; }

        /// <summary>
        /// Checks to see if the NextPageToken property is set.
        /// </summary>
        internal bool IsSetNextPageToken() => this.NextPageToken != null;

        /// <summary>
        /// Gets and sets the property PageSize. 
        /// <para>
        /// The number of recommendations that you want returned in a single response object.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 6000)]
        public int? PageSize { get; set; }

        /// <summary>
        /// Checks to see if the PageSize property is set.
        /// </summary>
        internal bool IsSetPageSize() => this.PageSize.HasValue;

        /// <summary>
        /// Gets and sets the property PaymentOption. 
        /// <para>
        /// The reservation purchase option that you want recommendations for.
        /// </para>
        /// </summary>
        public PaymentOption PaymentOption { get; set; }

        /// <summary>
        /// Checks to see if the PaymentOption property is set.
        /// </summary>
        internal bool IsSetPaymentOption() => this.PaymentOption != null;

        /// <summary>
        /// Gets and sets the property Service. 
        /// <para>
        /// The specific service that you want recommendations for.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 1024)]
        public string Service { get; set; }

        /// <summary>
        /// Checks to see if the Service property is set.
        /// </summary>
        internal bool IsSetService() => this.Service != null;

        /// <summary>
        /// Gets and sets the property ServiceSpecification. 
        /// <para>
        /// The hardware specifications for the service instances that you want recommendations
        /// for, such as standard or convertible Amazon EC2 instances.
        /// </para>
        /// </summary>
        public ServiceSpecification ServiceSpecification { get; set; }

        /// <summary>
        /// Checks to see if the ServiceSpecification property is set.
        /// </summary>
        internal bool IsSetServiceSpecification() => this.ServiceSpecification != null;

        /// <summary>
        /// Gets and sets the property TermInYears. 
        /// <para>
        /// The reservation term that you want recommendations for.
        /// </para>
        /// </summary>
        public TermInYears TermInYears { get; set; }

        /// <summary>
        /// Checks to see if the TermInYears property is set.
        /// </summary>
        internal bool IsSetTermInYears() => this.TermInYears != null;
    }
}
