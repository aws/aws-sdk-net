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
 * Do not modify this file. This file is generated from the taxsettings-2018-05-10.normal.json service model.
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
namespace Amazon.TaxSettings.Model
{
    /// <summary>
    /// Additional tax information associated with your TRN in Israel.
    /// </summary>
    public partial class IsraelAdditionalInfo
    {
        private IsraelCustomerType _customerType;
        private IsraelDealerType _dealerType;

        /// <summary>
        /// Gets and sets the property CustomerType. 
        /// <para>
        ///  Customer type for your TRN in Israel. The value can be <c>Business</c> or <c>Individual</c>.
        /// Use <c>Business</c>for entities such as not-for-profit and financial institutions.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public IsraelCustomerType CustomerType
        {
            get { return this._customerType; }
            set { this._customerType = value; }
        }

        // Check to see if CustomerType property is set
        internal bool IsSetCustomerType()
        {
            return this._customerType != null;
        }

        /// <summary>
        /// Gets and sets the property DealerType. 
        /// <para>
        ///  Dealer type for your TRN in Israel. If you're not a local authorized dealer with
        /// an Israeli VAT ID, specify your tax identification number so that Amazon Web Services
        /// can send you a compliant tax invoice.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public IsraelDealerType DealerType
        {
            get { return this._dealerType; }
            set { this._dealerType = value; }
        }

        // Check to see if DealerType property is set
        internal bool IsSetDealerType()
        {
            return this._dealerType != null;
        }

    }
}