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
    /// Container for the parameters to the DescribeSavingsPlans operation.
    /// Describes the specified Savings Plans.
    /// </summary>
    public partial class DescribeSavingsPlansRequest : AmazonSavingsPlansRequest
    {
        private List<SavingsPlanFilter> _filters = AWSConfigs.InitializeCollections ? new List<SavingsPlanFilter>() : null;
        private int? _maxResults;
        private string _nextToken;
        private List<string> _savingsPlanArns = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _savingsPlanIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _states = AWSConfigs.InitializeCollections ? new List<string>() : null;

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
        public List<SavingsPlanFilter> Filters
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
        [AWSProperty(Min=1, Max=1000)]
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
        /// Gets and sets the property SavingsPlanArns. 
        /// <para>
        /// The Amazon Resource Names (ARN) of the Savings Plans.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=100)]
        public List<string> SavingsPlanArns
        {
            get { return this._savingsPlanArns; }
            set { this._savingsPlanArns = value; }
        }

        // Check to see if SavingsPlanArns property is set
        internal bool IsSetSavingsPlanArns()
        {
            return this._savingsPlanArns != null && (this._savingsPlanArns.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SavingsPlanIds. 
        /// <para>
        /// The IDs of the Savings Plans.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SavingsPlanIds
        {
            get { return this._savingsPlanIds; }
            set { this._savingsPlanIds = value; }
        }

        // Check to see if SavingsPlanIds property is set
        internal bool IsSetSavingsPlanIds()
        {
            return this._savingsPlanIds != null && (this._savingsPlanIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property States. 
        /// <para>
        /// The current states of the Savings Plans.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> States
        {
            get { return this._states; }
            set { this._states = value; }
        }

        // Check to see if States property is set
        internal bool IsSetStates()
        {
            return this._states != null && (this._states.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}