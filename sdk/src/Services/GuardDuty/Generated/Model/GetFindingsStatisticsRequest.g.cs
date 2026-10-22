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

namespace Amazon.GuardDuty.Model
{
    /// <summary>
    /// Container for the parameters to the GetFindingsStatistics operation. Lists GuardDuty
    /// findings statistics for the specified detector ID. <para> You must provide either
    /// <c>findingStatisticTypes</c> or <c>groupBy</c> parameter, and not both. You can use
    /// the <c>maxResults</c> and <c>orderBy</c> parameters only when using <c>groupBy</c>.
    /// </para> <para> There might be regional differences because some flags might not be
    /// available in all the Regions where GuardDuty is currently supported. For more information,
    /// see <a href="https://docs.aws.amazon.com/guardduty/latest/ug/guardduty_regions.html">Regions
    /// and endpoints</a>. </para>
    /// </summary>
    public partial class GetFindingsStatisticsRequest : AmazonGuardDutyRequest
    {
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
        [AWSProperty(Required = true, Min = 1, Max = 300)]
        public string DetectorId { get; set; }

        /// <summary>
        /// Checks to see if the DetectorId property is set.
        /// </summary>
        internal bool IsSetDetectorId() => this.DetectorId != null;

        /// <summary>
        /// Gets and sets the property FindingCriteria. 
        /// <para>
        /// Represents the criteria that is used for querying findings.
        /// </para>
        /// </summary>
        public FindingCriteria FindingCriteria { get; set; }

        /// <summary>
        /// Checks to see if the FindingCriteria property is set.
        /// </summary>
        internal bool IsSetFindingCriteria() => this.FindingCriteria != null;

        /// <summary>
        /// Gets and sets the property FindingStatisticTypes. 
        /// <para>
        /// The types of finding statistics to retrieve.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [Obsolete("This parameter is deprecated, please use GroupBy instead")]
        [AWSProperty(Min = 0, Max = 10)]
        public List<string> FindingStatisticTypes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the FindingStatisticTypes property is set.
        /// </summary>
        internal bool IsSetFindingStatisticTypes() => this.FindingStatisticTypes != null && (this.FindingStatisticTypes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property GroupBy. 
        /// <para>
        /// Displays the findings statistics grouped by one of the listed valid values.
        /// </para>
        /// </summary>
        public GroupByType GroupBy { get; set; }

        /// <summary>
        /// Checks to see if the GroupBy property is set.
        /// </summary>
        internal bool IsSetGroupBy() => this.GroupBy != null;

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
        [AWSProperty(Min = 1, Max = 100)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

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
        public OrderBy OrderBy { get; set; }

        /// <summary>
        /// Checks to see if the OrderBy property is set.
        /// </summary>
        internal bool IsSetOrderBy() => this.OrderBy != null;
    }
}
