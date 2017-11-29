/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.GuardDuty.Model
{
    /// <summary>
    /// Container for the parameters to the GetFindingsStatistics operation.
    /// Lists Amazon GuardDuty findings' statistics for the specified detector ID.
    /// </summary>
    public partial class GetFindingsStatisticsRequest : AmazonGuardDutyRequest
    {
        private string _detectorId;
        private FindingCriteria _findingCriteria;
        private List<string> _findingStatisticTypes = new List<string>();

        /// <summary>
        /// Gets and sets the property DetectorId. The ID of the detector that specifies the GuardDuty
        /// service whose findings' statistics you want to retrieve.
        /// </summary>
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
        /// Gets and sets the property FindingCriteria. Represents the criteria used for querying
        /// findings.
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
        /// Gets and sets the property FindingStatisticTypes. Types of finding statistics to retrieve.
        /// </summary>
        public List<string> FindingStatisticTypes
        {
            get { return this._findingStatisticTypes; }
            set { this._findingStatisticTypes = value; }
        }

        // Check to see if FindingStatisticTypes property is set
        internal bool IsSetFindingStatisticTypes()
        {
            return this._findingStatisticTypes != null && this._findingStatisticTypes.Count > 0; 
        }

    }
}