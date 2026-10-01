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

namespace Amazon.IoTSiteWise.Model
{
    /// <summary>
    /// Set this period to specify how long your data is stored in the warm tier before it
    /// is deleted. You can set this only if cold tier is enabled.
    /// </summary>
    public partial class WarmTierRetentionPeriod
    {
        /// <summary>
        /// Gets and sets the property NumberOfDays. 
        /// <para>
        /// The number of days the data is stored in the warm tier.
        /// </para>
        /// </summary>
        public int? NumberOfDays { get; set; }

        /// <summary>
        /// Checks to see if the NumberOfDays property is set.
        /// </summary>
        internal bool IsSetNumberOfDays() => this.NumberOfDays.HasValue;

        /// <summary>
        /// Gets and sets the property Unlimited. 
        /// <para>
        /// If set to true, the data is stored indefinitely in the warm tier.
        /// </para>
        /// </summary>
        public bool? Unlimited { get; set; }

        /// <summary>
        /// Checks to see if the Unlimited property is set.
        /// </summary>
        internal bool IsSetUnlimited() => this.Unlimited.HasValue;
    }
}
