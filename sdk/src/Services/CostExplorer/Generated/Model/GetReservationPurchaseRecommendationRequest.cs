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
 * Do not modify this file. This file is generated from the ce-2017-10-25.normal.json service model.
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
    /// to On-Demand pricing.
    /// 
    ///  
    /// <para>
    /// Amazon Web Services generates your recommendations by identifying your On-Demand usage
    /// during a specific time period and collecting your usage into categories that are eligible
    /// for a reservation. After Amazon Web Services has these categories, it simulates every
    /// combination of reservations in each category of usage to identify the best number
    /// of each type of Reserved Instance (RI) to purchase to maximize your estimated savings.
    /// 
    /// </para>
    ///  
    /// <para>
    /// For example, Amazon Web Services automatically aggregates your Amazon EC2 Linux, shared
    /// tenancy, and c4 family usage in the US West (Oregon) Region and recommends that you
    /// buy size-flexible regional reservations to apply to the c4 family usage. Amazon Web
    /// Services recommends the smallest size instance in an instance family. This makes it
    /// easier to purchase a size-flexible Reserved Instance (RI). Amazon Web Services also
    /// shows the equal number of normalized units. This way, you can purchase any instance
    /// size that you want. For this example, your RI recommendation is for <c>c4.large</c>
    /// because that is the smallest size instance in the c4 instance family.
    /// </para>
    /// </summary>
    public partial class GetReservationPurchaseRecommendationRequest : AmazonCostExplorerRequest
    {
        private string _accountId;
        private AccountScope _accountScope;
        private Expression _filter;
        private LookbackPeriodInDays _lookbackPeriodInDays;
        private string _nextPageToken;
        private int? _pageSize;
        private PaymentOption _paymentOption;
        private string _service;
        private ServiceSpecification _serviceSpecification;
        private TermInYears _termInYears;

        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The account ID that's associated with the recommendation. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string AccountId
        {
            get { return this._accountId; }
            set { this._accountId = value; }
        }

        // Check to see if AccountId property is set
        internal bool IsSetAccountId()
        {
            return this._accountId != null;
        }

        /// <summary>
        /// Gets and sets the property AccountScope. 
        /// <para>
        /// The account scope that you want your recommendations for. Amazon Web Services calculates
        /// recommendations including the management account and member accounts if the value
        /// is set to <c>PAYER</c>. If the value is <c>LINKED</c>, recommendations are calculated
        /// for individual member accounts only.
        /// </para>
        /// </summary>
        public AccountScope AccountScope
        {
            get { return this._accountScope; }
            set { this._accountScope = value; }
        }

        // Check to see if AccountScope property is set
        internal bool IsSetAccountScope()
        {
            return this._accountScope != null;
        }

        /// <summary>
        /// Gets and sets the property Filter.
        /// </summary>
        public Expression Filter
        {
            get { return this._filter; }
            set { this._filter = value; }
        }

        // Check to see if Filter property is set
        internal bool IsSetFilter()
        {
            return this._filter != null;
        }

        /// <summary>
        /// Gets and sets the property LookbackPeriodInDays. 
        /// <para>
        /// The number of previous days that you want Amazon Web Services to consider when it
        /// calculates your recommendations.
        /// </para>
        /// </summary>
        public LookbackPeriodInDays LookbackPeriodInDays
        {
            get { return this._lookbackPeriodInDays; }
            set { this._lookbackPeriodInDays = value; }
        }

        // Check to see if LookbackPeriodInDays property is set
        internal bool IsSetLookbackPeriodInDays()
        {
            return this._lookbackPeriodInDays != null;
        }

        /// <summary>
        /// Gets and sets the property NextPageToken. 
        /// <para>
        /// The pagination token that indicates the next set of results that you want to retrieve.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=8192)]
        public string NextPageToken
        {
            get { return this._nextPageToken; }
            set { this._nextPageToken = value; }
        }

        // Check to see if NextPageToken property is set
        internal bool IsSetNextPageToken()
        {
            return this._nextPageToken != null;
        }

        /// <summary>
        /// Gets and sets the property PageSize. 
        /// <para>
        /// The number of recommendations that you want returned in a single response object.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int? PageSize
        {
            get { return this._pageSize; }
            set { this._pageSize = value; }
        }

        // Check to see if PageSize property is set
        internal bool IsSetPageSize()
        {
            return this._pageSize.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PaymentOption. 
        /// <para>
        /// The reservation purchase option that you want recommendations for.
        /// </para>
        /// </summary>
        public PaymentOption PaymentOption
        {
            get { return this._paymentOption; }
            set { this._paymentOption = value; }
        }

        // Check to see if PaymentOption property is set
        internal bool IsSetPaymentOption()
        {
            return this._paymentOption != null;
        }

        /// <summary>
        /// Gets and sets the property Service. 
        /// <para>
        /// The specific service that you want recommendations for.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=1024)]
        public string Service
        {
            get { return this._service; }
            set { this._service = value; }
        }

        // Check to see if Service property is set
        internal bool IsSetService()
        {
            return this._service != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceSpecification. 
        /// <para>
        /// The hardware specifications for the service instances that you want recommendations
        /// for, such as standard or convertible Amazon EC2 instances.
        /// </para>
        /// </summary>
        public ServiceSpecification ServiceSpecification
        {
            get { return this._serviceSpecification; }
            set { this._serviceSpecification = value; }
        }

        // Check to see if ServiceSpecification property is set
        internal bool IsSetServiceSpecification()
        {
            return this._serviceSpecification != null;
        }

        /// <summary>
        /// Gets and sets the property TermInYears. 
        /// <para>
        /// The reservation term that you want recommendations for.
        /// </para>
        /// </summary>
        public TermInYears TermInYears
        {
            get { return this._termInYears; }
            set { this._termInYears = value; }
        }

        // Check to see if TermInYears property is set
        internal bool IsSetTermInYears()
        {
            return this._termInYears != null;
        }

    }
}