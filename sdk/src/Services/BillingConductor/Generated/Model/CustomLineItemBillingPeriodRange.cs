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
    /// The billing period range in which the custom line item request will be applied.
    /// </summary>
    public partial class CustomLineItemBillingPeriodRange
    {
        private string _exclusiveEndBillingPeriod;
        private string _inclusiveStartBillingPeriod;

        /// <summary>
        /// Gets and sets the property ExclusiveEndBillingPeriod. 
        /// <para>
        /// The inclusive end billing period that defines a billing period range where a custom
        /// line is applied.
        /// </para>
        /// </summary>
        public string ExclusiveEndBillingPeriod
        {
            get { return this._exclusiveEndBillingPeriod; }
            set { this._exclusiveEndBillingPeriod = value; }
        }

        // Check to see if ExclusiveEndBillingPeriod property is set
        internal bool IsSetExclusiveEndBillingPeriod()
        {
            return this._exclusiveEndBillingPeriod != null;
        }

        /// <summary>
        /// Gets and sets the property InclusiveStartBillingPeriod. 
        /// <para>
        /// The inclusive start billing period that defines a billing period range where a custom
        /// line is applied.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string InclusiveStartBillingPeriod
        {
            get { return this._inclusiveStartBillingPeriod; }
            set { this._inclusiveStartBillingPeriod = value; }
        }

        // Check to see if InclusiveStartBillingPeriod property is set
        internal bool IsSetInclusiveStartBillingPeriod()
        {
            return this._inclusiveStartBillingPeriod != null;
        }

    }
}