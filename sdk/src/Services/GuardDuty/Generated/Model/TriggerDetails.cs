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
    /// Represents the reason the scan was triggered.
    /// </summary>
    public partial class TriggerDetails
    {
        private string _description;
        private string _guardDutyFindingId;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the scan trigger.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=200)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property GuardDutyFindingId. 
        /// <para>
        /// The ID of the GuardDuty finding that triggered the malware scan.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=200)]
        public string GuardDutyFindingId
        {
            get { return this._guardDutyFindingId; }
            set { this._guardDutyFindingId = value; }
        }

        // Check to see if GuardDutyFindingId property is set
        internal bool IsSetGuardDutyFindingId()
        {
            return this._guardDutyFindingId != null;
        }

    }
}