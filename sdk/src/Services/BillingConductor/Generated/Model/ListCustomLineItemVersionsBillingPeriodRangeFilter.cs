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
 * Do not modify this file. This file is generated from the billingconductor-2021-07-30.normal.json service model.
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
    /// A billing period filter that specifies the custom line item versions to retrieve.
    /// </summary>
    public partial class ListCustomLineItemVersionsBillingPeriodRangeFilter
    {
        private string _endBillingPeriod;
        private string _startBillingPeriod;

        /// <summary>
        /// Gets and sets the property EndBillingPeriod. 
        /// <para>
        /// The exclusive end billing period that defines a billing period range where a custom
        /// line item version is applied.
        /// </para>
        /// </summary>
        public string EndBillingPeriod
        {
            get { return this._endBillingPeriod; }
            set { this._endBillingPeriod = value; }
        }

        // Check to see if EndBillingPeriod property is set
        internal bool IsSetEndBillingPeriod()
        {
            return this._endBillingPeriod != null;
        }

        /// <summary>
        /// Gets and sets the property StartBillingPeriod. 
        /// <para>
        /// The inclusive start billing period that defines a billing period range where a custom
        /// line item version is applied.
        /// </para>
        /// </summary>
        public string StartBillingPeriod
        {
            get { return this._startBillingPeriod; }
            set { this._startBillingPeriod = value; }
        }

        // Check to see if StartBillingPeriod property is set
        internal bool IsSetStartBillingPeriod()
        {
            return this._startBillingPeriod != null;
        }

    }
}