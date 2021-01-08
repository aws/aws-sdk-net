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
    /// Contains information about the reason that the finding was generated.
    /// </summary>
    public partial class Evidence
    {
        private List<ThreatIntelligenceDetail> _threatIntelligenceDetails = new List<ThreatIntelligenceDetail>();

        /// <summary>
        /// Gets and sets the property ThreatIntelligenceDetails. 
        /// <para>
        /// A list of threat intelligence details related to the evidence.
        /// </para>
        /// </summary>
        public List<ThreatIntelligenceDetail> ThreatIntelligenceDetails
        {
            get { return this._threatIntelligenceDetails; }
            set { this._threatIntelligenceDetails = value; }
        }

        // Check to see if ThreatIntelligenceDetails property is set
        internal bool IsSetThreatIntelligenceDetails()
        {
            return this._threatIntelligenceDetails != null && this._threatIntelligenceDetails.Count > 0; 
        }

    }
}