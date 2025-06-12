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
 * Do not modify this file. This file is generated from the es-2015-01-01.normal.json service model.
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
        /// The Floating point value representing progress percentage of a particular step.
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
        ///  Represents one of 3 steps that an Upgrade or Upgrade Eligibility Check does through:
        /// <ul> <li>PreUpgradeCheck</li> <li>Snapshot</li> <li>Upgrade</li> </ul> 
        /// </para>
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
        ///  The status of a particular step during an upgrade. The status can take one of the
        /// following values: <ul> <li>In Progress</li> <li>Succeeded</li> <li>Succeeded with
        /// Issues</li> <li>Failed</li> </ul> 
        /// </para>
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