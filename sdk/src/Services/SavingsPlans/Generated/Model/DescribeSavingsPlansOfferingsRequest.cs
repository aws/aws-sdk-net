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
 * Do not modify this file. This file is generated from the savingsplans-2019-06-28.normal.json service model.
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
namespace Amazon.SavingsPlans.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeSavingsPlansOfferings operation.
    /// Describes the offerings for the specified Savings Plans.
    /// </summary>
    public partial class DescribeSavingsPlansOfferingsRequest : AmazonSavingsPlansRequest
    {
        private List<string> _currencies = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _descriptions = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<long> _durations = AWSConfigs.InitializeCollections ? new List<long>() : null;
        private List<SavingsPlanOfferingFilterElement> _filters = AWSConfigs.InitializeCollections ? new List<SavingsPlanOfferingFilterElement>() : null;
        private int? _maxResults;
        private string _nextToken;
        private List<string> _offeringIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _operations = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _paymentOptions = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _planTypes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private SavingsPlanProductType _productType;
        private List<string> _serviceCodes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _usageTypes = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property Currencies. 
        /// <para>
        /// The currencies.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Currencies
        {
            get { return this._currencies; }
            set { this._currencies = value; }
        }

        // Check to see if Currencies property is set
        internal bool IsSetCurrencies()
        {
            return this._currencies != null && (this._currencies.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Descriptions. 
        /// <para>
        /// The descriptions.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Descriptions
        {
            get { return this._descriptions; }
            set { this._descriptions = value; }
        }

        // Check to see if Descriptions property is set
        internal bool IsSetDescriptions()
        {
            return this._descriptions != null && (this._descriptions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Durations. 
        /// <para>
        /// The duration, in seconds.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<long> Durations
        {
            get { return this._durations; }
            set { this._durations = value; }
        }

        // Check to see if Durations property is set
        internal bool IsSetDurations()
        {
            return this._durations != null && (this._durations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// The filters.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<SavingsPlanOfferingFilterElement> Filters
        {
            get { return this._filters; }
            set { this._filters = value; }
        }

        // Check to see if Filters property is set
        internal bool IsSetFilters()
        {
            return this._filters != null && (this._filters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return with a single call. To retrieve additional
        /// results, make another call with the returned token value.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1000)]
        public int? MaxResults
        {
            get { return this._maxResults; }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token for the next page of results.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1024)]
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property OfferingIds. 
        /// <para>
        /// The IDs of the offerings.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> OfferingIds
        {
            get { return this._offeringIds; }
            set { this._offeringIds = value; }
        }

        // Check to see if OfferingIds property is set
        internal bool IsSetOfferingIds()
        {
            return this._offeringIds != null && (this._offeringIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Operations. 
        /// <para>
        /// The specific Amazon Web Services operation for the line item in the billing report.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Operations
        {
            get { return this._operations; }
            set { this._operations = value; }
        }

        // Check to see if Operations property is set
        internal bool IsSetOperations()
        {
            return this._operations != null && (this._operations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property PaymentOptions. 
        /// <para>
        /// The payment options.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> PaymentOptions
        {
            get { return this._paymentOptions; }
            set { this._paymentOptions = value; }
        }

        // Check to see if PaymentOptions property is set
        internal bool IsSetPaymentOptions()
        {
            return this._paymentOptions != null && (this._paymentOptions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property PlanTypes. 
        /// <para>
        /// The plan types.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> PlanTypes
        {
            get { return this._planTypes; }
            set { this._planTypes = value; }
        }

        // Check to see if PlanTypes property is set
        internal bool IsSetPlanTypes()
        {
            return this._planTypes != null && (this._planTypes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ProductType. 
        /// <para>
        /// The product type.
        /// </para>
        /// </summary>
        public SavingsPlanProductType ProductType
        {
            get { return this._productType; }
            set { this._productType = value; }
        }

        // Check to see if ProductType property is set
        internal bool IsSetProductType()
        {
            return this._productType != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceCodes. 
        /// <para>
        /// The services.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ServiceCodes
        {
            get { return this._serviceCodes; }
            set { this._serviceCodes = value; }
        }

        // Check to see if ServiceCodes property is set
        internal bool IsSetServiceCodes()
        {
            return this._serviceCodes != null && (this._serviceCodes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property UsageTypes. 
        /// <para>
        /// The usage details of the line item in the billing report.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> UsageTypes
        {
            get { return this._usageTypes; }
            set { this._usageTypes = value; }
        }

        // Check to see if UsageTypes property is set
        internal bool IsSetUsageTypes()
        {
            return this._usageTypes != null && (this._usageTypes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}