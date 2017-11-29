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
    /// Container for the parameters to the GetThreatIntelSet operation.
    /// Retrieves the ThreatIntelSet that is specified by the ThreatIntelSet ID.
    /// </summary>
    public partial class GetThreatIntelSetRequest : AmazonGuardDutyRequest
    {
        private string _detectorId;
        private string _threatIntelSetId;

        /// <summary>
        /// Gets and sets the property DetectorId. The detectorID that specifies the GuardDuty
        /// service whose ThreatIntelSet you want to describe.
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
        /// Gets and sets the property ThreatIntelSetId. The unique ID that specifies the ThreatIntelSet
        /// that you want to describe.
        /// </summary>
        public string ThreatIntelSetId
        {
            get { return this._threatIntelSetId; }
            set { this._threatIntelSetId = value; }
        }

        // Check to see if ThreatIntelSetId property is set
        internal bool IsSetThreatIntelSetId()
        {
            return this._threatIntelSetId != null;
        }

    }
}