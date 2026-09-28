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

namespace Amazon.EKS.Model
{
    /// <summary>
    /// An object representing the term duration and term unit type of your subscription.
    /// This determines the term length of your subscription. Valid values are MONTHS for
    /// term unit and 12 or 36 for term duration, indicating a 12 month or 36 month subscription.
    /// </summary>
    public partial class EksAnywhereSubscriptionTerm
    {
        /// <summary>
        /// Gets and sets the property Duration. 
        /// <para>
        /// The duration of the subscription term. Valid values are 12 and 36, indicating a 12
        /// month or 36 month subscription.
        /// </para>
        /// </summary>
        public int? Duration { get; set; }

        /// <summary>
        /// Checks to see if the Duration property is set.
        /// </summary>
        internal bool IsSetDuration() => this.Duration.HasValue;

        /// <summary>
        /// Gets and sets the property Unit. 
        /// <para>
        /// The term unit of the subscription. Valid value is <c>MONTHS</c>.
        /// </para>
        /// </summary>
        public EksAnywhereSubscriptionTermUnit Unit { get; set; }

        /// <summary>
        /// Checks to see if the Unit property is set.
        /// </summary>
        internal bool IsSetUnit() => this.Unit != null;
    }
}
