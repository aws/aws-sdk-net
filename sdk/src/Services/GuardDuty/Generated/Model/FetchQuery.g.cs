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
    /// Contains the parameters of a request that GuardDuty made to retrieve data during an
    /// investigation. The members that are set depend on the <c>FetchType</c> of the record.
    /// </summary>
    public partial class FetchQuery
    {
        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The Amazon Web Services account ID that the request was made for.
        /// </para>
        /// </summary>
        public string AccountId { get; set; }

        /// <summary>
        /// Checks to see if the AccountId property is set.
        /// </summary>
        internal bool IsSetAccountId() => this.AccountId != null;

        /// <summary>
        /// Gets and sets the property Criteria. 
        /// <para>
        /// The filter criteria that GuardDuty applied to the request.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 20)]
        public List<FetchCriterion> Criteria { get; set; } = AWSConfigs.InitializeCollections ? new List<FetchCriterion>() : null;

        /// <summary>
        /// Checks to see if the Criteria property is set.
        /// </summary>
        internal bool IsSetCriteria() => this.Criteria != null && (this.Criteria.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property FindingId. 
        /// <para>
        /// The ID of the finding that GuardDuty retrieved.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 300)]
        public string FindingId { get; set; }

        /// <summary>
        /// Checks to see if the FindingId property is set.
        /// </summary>
        internal bool IsSetFindingId() => this.FindingId != null;

        /// <summary>
        /// Gets and sets the property FindingType. 
        /// <para>
        /// The finding type whose documentation GuardDuty retrieved.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string FindingType { get; set; }

        /// <summary>
        /// Checks to see if the FindingType property is set.
        /// </summary>
        internal bool IsSetFindingType() => this.FindingType != null;

        /// <summary>
        /// Gets and sets the property Indicator. 
        /// <para>
        /// The threat indicator that GuardDuty looked up, such as an IP address, a domain, or
        /// a file hash.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 1024)]
        public string Indicator { get; set; }

        /// <summary>
        /// Checks to see if the Indicator property is set.
        /// </summary>
        internal bool IsSetIndicator() => this.Indicator != null;

        /// <summary>
        /// Gets and sets the property IndicatorType. 
        /// <para>
        /// The type of the threat indicator. Possible values are <c>IP</c>, <c>DOMAIN</c>, and
        /// <c>FILE</c>.
        /// </para>
        /// </summary>
        public InvestigationIndicatorType IndicatorType { get; set; }

        /// <summary>
        /// Checks to see if the IndicatorType property is set.
        /// </summary>
        internal bool IsSetIndicatorType() => this.IndicatorType != null;

        /// <summary>
        /// Gets and sets the property RowLimit. 
        /// <para>
        /// The maximum number of rows that GuardDuty requested. Valid values are 1 to 1,000.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1000)]
        public int? RowLimit { get; set; }

        /// <summary>
        /// Checks to see if the RowLimit property is set.
        /// </summary>
        internal bool IsSetRowLimit() => this.RowLimit.HasValue;

        /// <summary>
        /// Gets and sets the property TimeWindow. 
        /// <para>
        /// The time range of the data that GuardDuty requested.
        /// </para>
        /// </summary>
        public FetchTimeWindow TimeWindow { get; set; }

        /// <summary>
        /// Checks to see if the TimeWindow property is set.
        /// </summary>
        internal bool IsSetTimeWindow() => this.TimeWindow != null;
    }
}
