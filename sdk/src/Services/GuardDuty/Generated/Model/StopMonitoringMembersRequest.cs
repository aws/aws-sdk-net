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
    /// Container for the parameters to the StopMonitoringMembers operation.
    /// Disables GuardDuty from monitoring findings of the member accounts specified by the
    /// account IDs. After running this command, a master GuardDuty account can run StartMonitoringMembers
    /// to re-enable GuardDuty to monitor these members’ findings.
    /// </summary>
    public partial class StopMonitoringMembersRequest : AmazonGuardDutyRequest
    {
        private List<string> _accountIds = new List<string>();
        private string _detectorId;

        /// <summary>
        /// Gets and sets the property AccountIds. A list of account IDs of the GuardDuty member
        /// accounts whose findings you want the master account to stop monitoring.
        /// </summary>
        public List<string> AccountIds
        {
            get { return this._accountIds; }
            set { this._accountIds = value; }
        }

        // Check to see if AccountIds property is set
        internal bool IsSetAccountIds()
        {
            return this._accountIds != null && this._accountIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property DetectorId. The unique ID of the detector of the GuardDuty
        /// account that you want to stop from monitor members' findings.
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

    }
}