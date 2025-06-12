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
    /// Container for the parameters to the DescribeSavingsPlansOfferingRates operation.
    /// Describes the offering rates for the specified Savings Plans.
    /// </summary>
    public partial class DescribeSavingsPlansOfferingRatesRequest : AmazonSavingsPlansRequest
    {
        private List<SavingsPlanOfferingRateFilterElement> _filters = AWSConfigs.InitializeCollections ? new List<SavingsPlanOfferingRateFilterElement>() : null;
        private int? _maxResults;
        private string _nextToken;
        private List<string> _operations = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _products = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _savingsPlanOfferingIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _savingsPlanPaymentOptions = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _savingsPlanTypes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _serviceCodes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _usageTypes = AWSConfigs.InitializeCollections ? new List<string>() : null;

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
        public List<SavingsPlanOfferingRateFilterElement> Filters
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
        /// Gets and sets the property Products. 
        /// <para>
        /// The Amazon Web Services products.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Products
        {
            get { return this._products; }
            set { this._products = value; }
        }

        // Check to see if Products property is set
        internal bool IsSetProducts()
        {
            return this._products != null && (this._products.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SavingsPlanOfferingIds. 
        /// <para>
        /// The IDs of the offerings.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SavingsPlanOfferingIds
        {
            get { return this._savingsPlanOfferingIds; }
            set { this._savingsPlanOfferingIds = value; }
        }

        // Check to see if SavingsPlanOfferingIds property is set
        internal bool IsSetSavingsPlanOfferingIds()
        {
            return this._savingsPlanOfferingIds != null && (this._savingsPlanOfferingIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SavingsPlanPaymentOptions. 
        /// <para>
        /// The payment options.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SavingsPlanPaymentOptions
        {
            get { return this._savingsPlanPaymentOptions; }
            set { this._savingsPlanPaymentOptions = value; }
        }

        // Check to see if SavingsPlanPaymentOptions property is set
        internal bool IsSetSavingsPlanPaymentOptions()
        {
            return this._savingsPlanPaymentOptions != null && (this._savingsPlanPaymentOptions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SavingsPlanTypes. 
        /// <para>
        /// The plan types.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SavingsPlanTypes
        {
            get { return this._savingsPlanTypes; }
            set { this._savingsPlanTypes = value; }
        }

        // Check to see if SavingsPlanTypes property is set
        internal bool IsSetSavingsPlanTypes()
        {
            return this._savingsPlanTypes != null && (this._savingsPlanTypes.Count > 0 || !AWSConfigs.InitializeCollections); 
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