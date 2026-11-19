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

namespace Amazon.GuardDuty.Model
{
    /// <summary>
    /// Contains reputation information about a threat indicator.
    /// </summary>
    public partial class Reputation
    {
        /// <summary>
        /// Gets and sets the property CurrentDisposition. 
        /// <para>
        /// The current reputation of the indicator.
        /// </para>
        /// </summary>
        public string CurrentDisposition { get; set; }

        /// <summary>
        /// Checks to see if the CurrentDisposition property is set.
        /// </summary>
        internal bool IsSetCurrentDisposition() => this.CurrentDisposition != null;

        /// <summary>
        /// Gets and sets the property FindingTimeDisposition. 
        /// <para>
        /// The reputation of the indicator at the time of the finding.
        /// </para>
        /// </summary>
        public string FindingTimeDisposition { get; set; }

        /// <summary>
        /// Checks to see if the FindingTimeDisposition property is set.
        /// </summary>
        internal bool IsSetFindingTimeDisposition() => this.FindingTimeDisposition != null;

        /// <summary>
        /// Gets and sets the property ReputationComparison. 
        /// <para>
        /// A comparison of the reputation at the time of the finding with the current reputation.
        /// </para>
        /// </summary>
        public string ReputationComparison { get; set; }

        /// <summary>
        /// Checks to see if the ReputationComparison property is set.
        /// </summary>
        internal bool IsSetReputationComparison() => this.ReputationComparison != null;
    }
}
