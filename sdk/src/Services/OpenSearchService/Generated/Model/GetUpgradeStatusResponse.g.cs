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
    /// This is the response object from the GetUpgradeStatus operation.
    /// </summary>
    public partial class GetUpgradeStatusResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property StepStatus. 
        /// <para>
        /// The status of the current step that an upgrade is on.
        /// </para>
        /// </summary>
        public UpgradeStatus StepStatus { get; set; }

        /// <summary>
        /// Checks to see if the StepStatus property is set.
        /// </summary>
        internal bool IsSetStepStatus() => this.StepStatus != null;

        /// <summary>
        /// Gets and sets the property UpgradeName. 
        /// <para>
        /// A string that describes the update.
        /// </para>
        /// </summary>
        public string UpgradeName { get; set; }

        /// <summary>
        /// Checks to see if the UpgradeName property is set.
        /// </summary>
        internal bool IsSetUpgradeName() => this.UpgradeName != null;

        /// <summary>
        /// Gets and sets the property UpgradeStep. 
        /// <para>
        /// One of three steps that an upgrade or upgrade eligibility check goes through.
        /// </para>
        /// </summary>
        public UpgradeStep UpgradeStep { get; set; }

        /// <summary>
        /// Checks to see if the UpgradeStep property is set.
        /// </summary>
        internal bool IsSetUpgradeStep() => this.UpgradeStep != null;
    }
}
