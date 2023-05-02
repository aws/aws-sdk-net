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

namespace Amazon.GuardDuty.Model
{
    /// <summary>
    /// Container for the parameters to the GetCoverageStatistics operation.
    /// Retrieves aggregated statistics for your account. If you are a GuardDuty administrator,
    /// you can retrieve the statistics for all the resources associated with the active member
    /// accounts in your organization who have enabled EKS Runtime Monitoring and have the
    /// GuardDuty agent running on their EKS nodes.
    /// </summary>
    public partial class GetCoverageStatisticsRequest : AmazonGuardDutyRequest
    {
        private string _detectorId;
        private CoverageFilterCriteria _filterCriteria;
        private List<string> _statisticsType = new List<string>();

        /// <summary>
        /// Gets and sets the property DetectorId. 
        /// <para>
        /// The unique ID of the GuardDuty detector associated to the coverage statistics.
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
        /// Gets and sets the property FilterCriteria. 
        /// <para>
        /// Represents the criteria used to filter the coverage statistics
        /// </para>
        /// </summary>
        public CoverageFilterCriteria FilterCriteria
        {
            get { return this._filterCriteria; }
            set { this._filterCriteria = value; }
        }

        // Check to see if FilterCriteria property is set
        internal bool IsSetFilterCriteria()
        {
            return this._filterCriteria != null;
        }

        /// <summary>
        /// Gets and sets the property StatisticsType. 
        /// <para>
        /// Represents the statistics type used to aggregate the coverage details.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> StatisticsType
        {
            get { return this._statisticsType; }
            set { this._statisticsType = value; }
        }

        // Check to see if StatisticsType property is set
        internal bool IsSetStatisticsType()
        {
            return this._statisticsType != null && this._statisticsType.Count > 0; 
        }

    }
}