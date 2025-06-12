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
    /// Represents a single step of an upgrade or upgrade eligibility check workflow.
    /// </summary>
    public partial class UpgradeStepItem
    {
        private List<string> _issues = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private double? _progressPercent;
        private UpgradeStep _upgradeStep;
        private UpgradeStatus _upgradeStepStatus;

        /// <summary>
        /// Gets and sets the property Issues. 
        /// <para>
        /// A list of strings containing detailed information about the errors encountered in
        /// a particular step.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Issues
        {
            get { return this._issues; }
            set { this._issues = value; }
        }

        // Check to see if Issues property is set
        internal bool IsSetIssues()
        {
            return this._issues != null && (this._issues.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ProgressPercent. 
        /// <para>
        /// The floating point value representing the progress percentage of a particular step.
        /// </para>
        /// </summary>
        public double? ProgressPercent
        {
            get { return this._progressPercent; }
            set { this._progressPercent = value; }
        }

        // Check to see if ProgressPercent property is set
        internal bool IsSetProgressPercent()
        {
            return this._progressPercent.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UpgradeStep. 
        /// <para>
        ///  One of three steps that an upgrade or upgrade eligibility check goes through: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// PreUpgradeCheck
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Snapshot
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Upgrade
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public UpgradeStep UpgradeStep
        {
            get { return this._upgradeStep; }
            set { this._upgradeStep = value; }
        }

        // Check to see if UpgradeStep property is set
        internal bool IsSetUpgradeStep()
        {
            return this._upgradeStep != null;
        }

        /// <summary>
        /// Gets and sets the property UpgradeStepStatus. 
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
        public UpgradeStatus UpgradeStepStatus
        {
            get { return this._upgradeStepStatus; }
            set { this._upgradeStepStatus = value; }
        }

        // Check to see if UpgradeStepStatus property is set
        internal bool IsSetUpgradeStepStatus()
        {
            return this._upgradeStepStatus != null;
        }

    }
}