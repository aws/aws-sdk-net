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
    /// Lists Amazon GuardDuty findings statistics for the specified detector ID.
    /// 
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

        /// <summary>
        /// Gets and sets the property DetectorId. 
        /// <para>
        /// The ID of the detector that specifies the GuardDuty service whose findings' statistics
        /// you want to retrieve.
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
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=10)]
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

    }
}