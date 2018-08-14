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
 * Do not modify this file. This file is generated from the es-2015-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Elasticsearch.Model
{
    /// <summary>
    /// History of the last 10 Upgrades and Upgrade Eligibility Checks.
    /// </summary>
    public partial class UpgradeHistory
    {
        private DateTime? _startTimestamp;
        private List<UpgradeStepItem> _stepsList = new List<UpgradeStepItem>();
        private string _upgradeName;
        private UpgradeStatus _upgradeStatus;

        /// <summary>
        /// Gets and sets the property StartTimestamp. 
        /// <para>
        /// UTC Timestamp at which the Upgrade API call was made in "yyyy-MM-ddTHH:mm:ssZ" format.
        /// </para>
        /// </summary>
        public DateTime StartTimestamp
        {
            get { return this._startTimestamp.GetValueOrDefault(); }
            set { this._startTimestamp = value; }
        }

        // Check to see if StartTimestamp property is set
        internal bool IsSetStartTimestamp()
        {
            return this._startTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StepsList. 
        /// <para>
        ///  A list of <code> <a>UpgradeStepItem</a> </code> s representing information about
        /// each step performed as pard of a specific Upgrade or Upgrade Eligibility Check. 
        /// </para>
        /// </summary>
        public List<UpgradeStepItem> StepsList
        {
            get { return this._stepsList; }
            set { this._stepsList = value; }
        }

        // Check to see if StepsList property is set
        internal bool IsSetStepsList()
        {
            return this._stepsList != null && this._stepsList.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property UpgradeName. 
        /// <para>
        /// A string that describes the update briefly
        /// </para>
        /// </summary>
        public string UpgradeName
        {
            get { return this._upgradeName; }
            set { this._upgradeName = value; }
        }

        // Check to see if UpgradeName property is set
        internal bool IsSetUpgradeName()
        {
            return this._upgradeName != null;
        }

        /// <summary>
        /// Gets and sets the property UpgradeStatus. 
        /// <para>
        ///  The overall status of the update. The status can take one of the following values:
        /// <ul> <li>In Progress</li> <li>Succeeded</li> <li>Succeeded with Issues</li> <li>Failed</li>
        /// </ul> 
        /// </para>
        /// </summary>
        public UpgradeStatus UpgradeStatus
        {
            get { return this._upgradeStatus; }
            set { this._upgradeStatus = value; }
        }

        // Check to see if UpgradeStatus property is set
        internal bool IsSetUpgradeStatus()
        {
            return this._upgradeStatus != null;
        }

    }
}