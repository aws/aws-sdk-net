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
 * Do not modify this file. This file is generated from the billing-2023-09-07.normal.json service model.
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
namespace Amazon.Billing.Model
{
    /// <summary>
    /// An additional charge applied to an Enterprise Support contract.
    /// </summary>
    public partial class AdditionalCharge
    {
        private string _amount;
        private string _chargeType;
        private string _description;

        /// <summary>
        /// Gets and sets the property Amount. 
        /// <para>
        /// The charge amount.
        /// </para>
        /// </summary>
        public string Amount
        {
            get { return this._amount; }
            set { this._amount = value; }
        }

        // Check to see if Amount property is set
        internal bool IsSetAmount()
        {
            return this._amount != null;
        }

        /// <summary>
        /// Gets and sets the property ChargeType. 
        /// <para>
        /// The type of additional charge.
        /// </para>
        /// </summary>
        public string ChargeType
        {
            get { return this._chargeType; }
            set { this._chargeType = value; }
        }

        // Check to see if ChargeType property is set
        internal bool IsSetChargeType()
        {
            return this._chargeType != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the additional charge.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

    }
}