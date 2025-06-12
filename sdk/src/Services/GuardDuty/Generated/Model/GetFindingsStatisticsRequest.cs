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
 * Do not modify this file. This file is generated from the guardduty-2017-11-28.normal.json service model.
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
namespace Amazon.GuardDuty.Model
{
    /// <summary>
    /// Container for the parameters to the GetFindingsStatistics operation.
    /// Lists GuardDuty findings statistics for the specified detector ID.
    /// 
    ///  
    /// <para>
    /// You must provide either <c>findingStatisticTypes</c> or <c>groupBy</c> parameter,
    /// and not both. You can use the <c>maxResults</c> and <c>orderBy</c> parameters only
    /// when using <c>groupBy</c>.
    /// </para>
    ///  
    /// <para>
    /// There might be regional differences because some flags might not be available in all
    /// the Regions where GuardDuty is currently supported. For more information, see <a href="https://docs.aws.amazon.com/guardduty/latest/ug/guardduty_regions.html">Regions
    /// and endpoints</a>.
    /// </para>
    /// </summary>
    public partial class GetFindingsStatisticsRequest : AmazonGuardDutyRequest
    {
        private string _detectorId;
        private FindingCriteria _findingCriteria;
        private List<string> _findingStatisticTypes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private GroupByType _groupBy;
        private int? _maxResults;
        private OrderBy _orderBy;

        /// <summary>
        /// Gets and sets the property DetectorId. 
        /// <para>
        /// The ID of the detector whose findings statistics you want to retrieve.
        /// </para>
        ///  
        /// <para>
        /// To find the <c>detectorId</c> in the current Region, see the Settings page in the
        /// GuardDuty console, or run the <a href="https://docs.aws.amazon.com/guardduty/latest/APIReference/API_ListDetectors.html">ListDetectors</a>
        /// API.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=300)]
        public string DetectorId
        {
            get { return this._detectorId; }
            set { this._detectorId = value; }
        }

        // Check to see if DetectorId property is set
        internal bool IsSetDetectorId()
        {
            return this._detectorId != null;
        }

        /// <summary>
        /// Gets and sets the property FindingCriteria. 
        /// <para>
        /// Represents the criteria that is used for querying findings.
        /// </para>
        /// </summary>
        public FindingCriteria FindingCriteria
        {
            get { return this._findingCriteria; }
            set { this._findingCriteria = value; }
        }

        // Check to see if FindingCriteria property is set
        internal bool IsSetFindingCriteria()
        {
            return this._findingCriteria != null;
        }

        /// <summary>
        /// Gets and sets the property FindingStatisticTypes. 
        /// <para>
        /// The types of finding statistics to retrieve.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [Obsolete("This parameter is deprecated, please use GroupBy instead")]
        [AWSProperty(Min=0, Max=10)]
        public List<string> FindingStatisticTypes
        {
            get { return this._findingStatisticTypes; }
            set { this._findingStatisticTypes = value; }
        }

        // Check to see if FindingStatisticTypes property is set
        internal bool IsSetFindingStatisticTypes()
        {
            return this._findingStatisticTypes != null && (this._findingStatisticTypes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property GroupBy. 
        /// <para>
        /// Displays the findings statistics grouped by one of the listed valid values.
        /// </para>
        /// </summary>
        public GroupByType GroupBy
        {
            get { return this._groupBy; }
            set { this._groupBy = value; }
        }

        // Check to see if GroupBy property is set
        internal bool IsSetGroupBy()
        {
            return this._groupBy != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to be returned in the response. The default value is
        /// 25.
        /// </para>
        ///  
        /// <para>
        /// You can use this parameter only with the <c>groupBy</c> parameter.
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
        /// Gets and sets the property OrderBy. 
        /// <para>
        /// Displays the sorted findings in the requested order. The default value of <c>orderBy</c>
        /// is <c>DESC</c>.
        /// </para>
        ///  
        /// <para>
        /// You can use this parameter only with the <c>groupBy</c> parameter.
        /// </para>
        /// </summary>
        public OrderBy OrderBy
        {
            get { return this._orderBy; }
            set { this._orderBy = value; }
        }

        // Check to see if OrderBy property is set
        internal bool IsSetOrderBy()
        {
            return this._orderBy != null;
        }

    }
}