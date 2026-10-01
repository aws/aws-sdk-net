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

namespace Amazon.BillingConductor.Model
{
    /// <summary>
    /// A time range for which the margin summary is effective. The time range can be up to
    /// 12 months.
    /// </summary>
    public partial class BillingPeriodRange
    {
        /// <summary>
        /// Gets and sets the property ExclusiveEndBillingPeriod. 
        /// <para>
        /// The exclusive end billing period that defines a billing period range for the margin
        /// summary. For example, if you choose a billing period that starts in October 2023 and
        /// ends in December 2023, the margin summary will only include data from October 2023
        /// and November 2023.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ExclusiveEndBillingPeriod { get; set; }

        /// <summary>
        /// Checks to see if the ExclusiveEndBillingPeriod property is set.
        /// </summary>
        internal bool IsSetExclusiveEndBillingPeriod() => this.ExclusiveEndBillingPeriod != null;

        /// <summary>
        /// Gets and sets the property InclusiveStartBillingPeriod. 
        /// <para>
        /// The inclusive start billing period that defines a billing period range for the margin
        /// summary.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string InclusiveStartBillingPeriod { get; set; }

        /// <summary>
        /// Checks to see if the InclusiveStartBillingPeriod property is set.
        /// </summary>
        internal bool IsSetInclusiveStartBillingPeriod() => this.InclusiveStartBillingPeriod != null;
    }
}
