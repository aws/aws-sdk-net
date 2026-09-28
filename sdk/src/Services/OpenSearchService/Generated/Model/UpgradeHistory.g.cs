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

namespace Amazon.OpenSearchService.Model
{
    /// <summary>
    /// History of the last 10 upgrades and upgrade eligibility checks for an Amazon OpenSearch
    /// Service domain.
    /// </summary>
    public partial class UpgradeHistory
    {
        /// <summary>
        /// Gets and sets the property StartTimestamp. 
        /// <para>
        /// UTC timestamp at which the upgrade API call was made, in the format <c>yyyy-MM-ddTHH:mm:ssZ</c>.
        /// </para>
        /// </summary>
        public DateTime? StartTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the StartTimestamp property is set.
        /// </summary>
        internal bool IsSetStartTimestamp() => this.StartTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property StepsList. 
        /// <para>
        /// A list of each step performed as part of a specific upgrade or upgrade eligibility
        /// check.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<UpgradeStepItem> StepsList { get; set; } = AWSConfigs.InitializeCollections ? new List<UpgradeStepItem>() : null;

        /// <summary>
        /// Checks to see if the StepsList property is set.
        /// </summary>
        internal bool IsSetStepsList() => this.StepsList != null && (this.StepsList.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property UpgradeName. 
        /// <para>
        /// A string that describes the upgrade.
        /// </para>
        /// </summary>
        public string UpgradeName { get; set; }

        /// <summary>
        /// Checks to see if the UpgradeName property is set.
        /// </summary>
        internal bool IsSetUpgradeName() => this.UpgradeName != null;

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
        public UpgradeStatus UpgradeStatus { get; set; }

        /// <summary>
        /// Checks to see if the UpgradeStatus property is set.
        /// </summary>
        internal bool IsSetUpgradeStatus() => this.UpgradeStatus != null;
    }
}
