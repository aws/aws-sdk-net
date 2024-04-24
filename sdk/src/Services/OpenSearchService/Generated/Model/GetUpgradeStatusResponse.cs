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
    /// Container for the response returned by the <c>GetUpgradeStatus</c> operation.
    /// </summary>
    public partial class GetUpgradeStatusResponse : AmazonWebServiceResponse
    {
        private UpgradeStatus _stepStatus;
        private string _upgradeName;
        private UpgradeStep _upgradeStep;

        /// <summary>
        /// Gets and sets the property StepStatus. 
        /// <para>
        /// The status of the current step that an upgrade is on.
        /// </para>
        /// </summary>
        public UpgradeStatus StepStatus
        {
            get { return this._stepStatus; }
            set { this._stepStatus = value; }
        }

        // Check to see if StepStatus property is set
        internal bool IsSetStepStatus()
        {
            return this._stepStatus != null;
        }

        /// <summary>
        /// Gets and sets the property UpgradeName. 
        /// <para>
        /// A string that describes the update.
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
        /// Gets and sets the property UpgradeStep. 
        /// <para>
        /// One of three steps that an upgrade or upgrade eligibility check goes through.
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

    }
}