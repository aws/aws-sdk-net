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

namespace Amazon.Elasticsearch.Model
{
    /// <summary>
    /// Represents a single step of the Upgrade or Upgrade Eligibility Check workflow.
    /// </summary>
    public partial class UpgradeStepItem
    {
        /// <summary>
        /// Gets and sets the property Issues. 
        /// <para>
        /// A list of strings containing detailed information about the errors encountered in
        /// a particular step.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Issues { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Issues property is set.
        /// </summary>
        internal bool IsSetIssues() => this.Issues != null && (this.Issues.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ProgressPercent. 
        /// <para>
        /// The Floating point value representing progress percentage of a particular step.
        /// </para>
        /// </summary>
        public double? ProgressPercent { get; set; }

        /// <summary>
        /// Checks to see if the ProgressPercent property is set.
        /// </summary>
        internal bool IsSetProgressPercent() => this.ProgressPercent.HasValue;

        /// <summary>
        /// Gets and sets the property UpgradeStep. 
        /// <para>
        ///  Represents one of 3 steps that an Upgrade or Upgrade Eligibility Check does through:
        /// <ul> <li>PreUpgradeCheck</li> <li>Snapshot</li> <li>Upgrade</li> </ul> 
        /// </para>
        /// </summary>
        public UpgradeStep UpgradeStep { get; set; }

        /// <summary>
        /// Checks to see if the UpgradeStep property is set.
        /// </summary>
        internal bool IsSetUpgradeStep() => this.UpgradeStep != null;

        /// <summary>
        /// Gets and sets the property UpgradeStepStatus. 
        /// <para>
        ///  The status of a particular step during an upgrade. The status can take one of the
        /// following values: <ul> <li>In Progress</li> <li>Succeeded</li> <li>Succeeded with
        /// Issues</li> <li>Failed</li> </ul> 
        /// </para>
        /// </summary>
        public UpgradeStatus UpgradeStepStatus { get; set; }

        /// <summary>
        /// Checks to see if the UpgradeStepStatus property is set.
        /// </summary>
        internal bool IsSetUpgradeStepStatus() => this.UpgradeStepStatus != null;
    }
}
