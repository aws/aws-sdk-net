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
 * Do not modify this file. This file is generated from the billing-2023-09-07.normal.json service model.
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
namespace Amazon.Billing.Model
{
    /// <summary>
    /// Container for the parameters to the ListBillingViews operation.
    /// Lists the billing views available for a given time period. 
    /// 
    ///  
    /// <para>
    /// Every Amazon Web Services account has a unique <c>PRIMARY</c> billing view that represents
    /// the billing data available by default. Accounts that use Billing Conductor also have
    /// <c>BILLING_GROUP</c> billing views representing pro forma costs associated with each
    /// created billing group.
    /// </para>
    /// </summary>
    public partial class ListBillingViewsRequest : AmazonBillingRequest
    {
        private ActiveTimeRange _activeTimeRange;
        private List<string> _arns = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _billingViewTypes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private int? _maxResults;
        private string _nextToken;
        private string _ownerAccountId;
        private string _sourceAccountId;

        /// <summary>
        /// Gets and sets the property ActiveTimeRange. 
        /// <para>
        ///  The time range for the billing views listed. <c>PRIMARY</c> billing view is always
        /// listed. <c>BILLING_GROUP</c> billing views are listed for time ranges when the associated
        /// billing group resource in Billing Conductor is active. The time range must be within
        /// one calendar month. 
        /// </para>
        /// </summary>
        public ActiveTimeRange ActiveTimeRange
        {
            get { return this._activeTimeRange; }
            set { this._activeTimeRange = value; }
        }

        // Check to see if ActiveTimeRange property is set
        internal bool IsSetActiveTimeRange()
        {
            return this._activeTimeRange != null;
        }

        /// <summary>
        /// Gets and sets the property Arns. 
        /// <para>
        /// The Amazon Resource Name (ARN) that can be used to uniquely identify the billing view.
        /// 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=10)]
        public List<string> Arns
        {
            get { return this._arns; }
            set { this._arns = value; }
        }

        // Check to see if Arns property is set
        internal bool IsSetArns()
        {
            return this._arns != null && (this._arns.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property BillingViewTypes. 
        /// <para>
        /// The type of billing view.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> BillingViewTypes
        {
            get { return this._billingViewTypes; }
            set { this._billingViewTypes = value; }
        }

        // Check to see if BillingViewTypes property is set
        internal bool IsSetBillingViewTypes()
        {
            return this._billingViewTypes != null && (this._billingViewTypes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of billing views to retrieve. Default is 100. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
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
        /// The pagination token that is used on subsequent calls to list billing views.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2047)]
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
        /// Gets and sets the property OwnerAccountId. 
        /// <para>
        ///  The list of owners of the billing view. 
        /// </para>
        /// </summary>
        public string OwnerAccountId
        {
            get { return this._ownerAccountId; }
            set { this._ownerAccountId = value; }
        }

        // Check to see if OwnerAccountId property is set
        internal bool IsSetOwnerAccountId()
        {
            return this._ownerAccountId != null;
        }

        /// <summary>
        /// Gets and sets the property SourceAccountId. 
        /// <para>
        ///  Filters the results to include only billing views that use the specified account
        /// as a source. 
        /// </para>
        /// </summary>
        public string SourceAccountId
        {
            get { return this._sourceAccountId; }
            set { this._sourceAccountId = value; }
        }

        // Check to see if SourceAccountId property is set
        internal bool IsSetSourceAccountId()
        {
            return this._sourceAccountId != null;
        }

    }
}