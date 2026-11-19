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

namespace Amazon.MarketplaceAgreement.Model
{
    /// <summary>
    /// Contains details about the free trial of an agreement, including when the free trial
    /// ends.
    /// </summary>
    public partial class FreeTrialSummary
    {
        /// <summary>
        /// Gets and sets the property TrialEndTime. 
        /// <para>
        /// The date and time when the free trial ends. For an agreement that includes both a
        /// free trial and usage-based pricing, the agreement converts to paid usage at this time.
        /// </para>
        /// </summary>
        public DateTime? TrialEndTime { get; set; }

        /// <summary>
        /// Checks to see if the TrialEndTime property is set.
        /// </summary>
        internal bool IsSetTrialEndTime() => this.TrialEndTime.HasValue;
    }
}
