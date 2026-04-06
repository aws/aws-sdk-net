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
 * Do not modify this file. This file is generated from the sustainability-2018-05-10.normal.json service model.
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
namespace Amazon.Sustainability.Model
{
    /// <summary>
    /// Container for the parameters to the GetEstimatedCarbonEmissions operation.
    /// Returns estimated carbon emission values based on customer grouping and filtering
    /// parameters. We recommend using pagination to ensure that the operation returns quickly
    /// and successfully.
    /// </summary>
    public partial class GetEstimatedCarbonEmissionsRequest : AmazonSustainabilityRequest
    {
        private List<string> _emissionsTypes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private FilterExpression _filterBy;
        private TimeGranularity _granularity;
        private GranularityConfiguration _granularityConfiguration;
        private List<string> _groupBy = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private int? _maxResults;
        private string _nextToken;
        private TimePeriod _timePeriod;

        /// <summary>
        /// Gets and sets the property EmissionsTypes. 
        /// <para>
        /// The emission types to include in the results. If absent, returns <c>TOTAL_LBM_CARBON_EMISSIONS</c>
        /// and <c>TOTAL_MBM_CARBON_EMISSIONS</c> emissions types. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> EmissionsTypes
        {
            get { return this._emissionsTypes; }
            set { this._emissionsTypes = value; }
        }

        // Check to see if EmissionsTypes property is set
        internal bool IsSetEmissionsTypes()
        {
            return this._emissionsTypes != null && (this._emissionsTypes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property FilterBy. 
        /// <para>
        /// The criteria for filtering estimated carbon emissions.
        /// </para>
        /// </summary>
        public FilterExpression FilterBy
        {
            get { return this._filterBy; }
            set { this._filterBy = value; }
        }

        // Check to see if FilterBy property is set
        internal bool IsSetFilterBy()
        {
            return this._filterBy != null;
        }

        /// <summary>
        /// Gets and sets the property Granularity. 
        /// <para>
        /// The time granularity for the results. If absent, uses <c>MONTHLY</c> time granularity.
        /// </para>
        /// </summary>
        public TimeGranularity Granularity
        {
            get { return this._granularity; }
            set { this._granularity = value; }
        }

        // Check to see if Granularity property is set
        internal bool IsSetGranularity()
        {
            return this._granularity != null;
        }

        /// <summary>
        /// Gets and sets the property GranularityConfiguration. 
        /// <para>
        /// Configuration for fiscal year calculations when using <c>YEARLY_FISCAL</c> or <c>QUARTERLY_FISCAL</c>
        /// granularity. 
        /// </para>
        /// </summary>
        public GranularityConfiguration GranularityConfiguration
        {
            get { return this._granularityConfiguration; }
            set { this._granularityConfiguration = value; }
        }

        // Check to see if GranularityConfiguration property is set
        internal bool IsSetGranularityConfiguration()
        {
            return this._granularityConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property GroupBy. 
        /// <para>
        /// The dimensions available for grouping estimated carbon emissions.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> GroupBy
        {
            get { return this._groupBy; }
            set { this._groupBy = value; }
        }

        // Check to see if GroupBy property is set
        internal bool IsSetGroupBy()
        {
            return this._groupBy != null && (this._groupBy.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return in a single call. Default is 40.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=5000)]
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
        /// The pagination token specifying which page of results to return in the response. If
        /// no token is provided, the default page is the first page. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2000)]
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
        /// Gets and sets the property TimePeriod. 
        /// <para>
        /// The date range for fetching estimated carbon emissions.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public TimePeriod TimePeriod
        {
            get { return this._timePeriod; }
            set { this._timePeriod = value; }
        }

        // Check to see if TimePeriod property is set
        internal bool IsSetTimePeriod()
        {
            return this._timePeriod != null;
        }

    }
}