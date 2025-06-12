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
 * Do not modify this file. This file is generated from the opensearch-2021-01-01.normal.json service model.
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
namespace Amazon.OpenSearchService.Model
{
    /// <summary>
    /// History of the last 10 upgrades and upgrade eligibility checks for an Amazon OpenSearch
    /// Service domain.
    /// </summary>
    public partial class UpgradeHistory
    {
        private DateTime? _startTimestamp;
        private List<UpgradeStepItem> _stepsList = AWSConfigs.InitializeCollections ? new List<UpgradeStepItem>() : null;
        private string _upgradeName;
        private UpgradeStatus _upgradeStatus;

        /// <summary>
        /// Gets and sets the property StartTimestamp. 
        /// <para>
        /// UTC timestamp at which the upgrade API call was made, in the format <c>yyyy-MM-ddTHH:mm:ssZ</c>.
        /// </para>
        /// </summary>
        public DateTime? StartTimestamp
        {
            get { return this._startTimestamp; }
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
        /// A list of each step performed as part of a specific upgrade or upgrade eligibility
        /// check.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<UpgradeStepItem> StepsList
        {
            get { return this._stepsList; }
            set { this._stepsList = value; }
        }

        // Check to see if StepsList property is set
        internal bool IsSetStepsList()
        {
            return this._stepsList != null && (this._stepsList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property UpgradeName. 
        /// <para>
        /// A string that describes the upgrade.
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
        ///  The current status of the upgrade. The status can take one of the following values:
        /// 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// In Progress
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Succeeded
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Succeeded with Issues
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Failed
        /// </para>
        ///  </li> </ul>
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