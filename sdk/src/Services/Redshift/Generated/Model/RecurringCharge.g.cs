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

namespace Amazon.Redshift.Model
{
    /// <summary>
    /// Describes a recurring charge.
    /// </summary>
    public partial class RecurringCharge
    {
        /// <summary>
        /// Gets and sets the property RecurringChargeAmount. 
        /// <para>
        /// The amount charged per the period of time specified by the recurring charge frequency.
        /// </para>
        /// </summary>
        public double? RecurringChargeAmount { get; set; }

        /// <summary>
        /// Checks to see if the RecurringChargeAmount property is set.
        /// </summary>
        internal bool IsSetRecurringChargeAmount() => this.RecurringChargeAmount.HasValue;

        /// <summary>
        /// Gets and sets the property RecurringChargeFrequency. 
        /// <para>
        /// The frequency at which the recurring charge amount is applied.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public string RecurringChargeFrequency { get; set; }

        /// <summary>
        /// Checks to see if the RecurringChargeFrequency property is set.
        /// </summary>
        internal bool IsSetRecurringChargeFrequency() => this.RecurringChargeFrequency != null;
    }
}
