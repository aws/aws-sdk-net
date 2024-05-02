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
    /// Container for the parameters to the DeleteCustomLineItem operation.
    /// Deletes the custom line item identified by the given ARN in the current, or previous
    /// billing period.
    /// </summary>
    public partial class DeleteCustomLineItemRequest : AmazonBillingConductorRequest
    {
        private string _arn;
        private CustomLineItemBillingPeriodRange _billingPeriodRange;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        ///  The ARN of the custom line item to be deleted. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property BillingPeriodRange.
        /// </summary>
        public CustomLineItemBillingPeriodRange BillingPeriodRange
        {
            get { return this._billingPeriodRange; }
            set { this._billingPeriodRange = value; }
        }

        // Check to see if BillingPeriodRange property is set
        internal bool IsSetBillingPeriodRange()
        {
            return this._billingPeriodRange != null;
        }

    }
}