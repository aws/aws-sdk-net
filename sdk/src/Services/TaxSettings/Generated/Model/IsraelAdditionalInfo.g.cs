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

namespace Amazon.TaxSettings.Model
{
    /// <summary>
    /// Additional tax information associated with your TRN in Israel.
    /// </summary>
    public partial class IsraelAdditionalInfo
    {
        /// <summary>
        /// Gets and sets the property CustomerType. 
        /// <para>
        ///  Customer type for your TRN in Israel. The value can be <c>Business</c> or <c>Individual</c>.
        /// Use <c>Business</c>for entities such as not-for-profit and financial institutions.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public IsraelCustomerType CustomerType { get; set; }

        /// <summary>
        /// Checks to see if the CustomerType property is set.
        /// </summary>
        internal bool IsSetCustomerType() => this.CustomerType != null;

        /// <summary>
        /// Gets and sets the property DealerType. 
        /// <para>
        ///  Dealer type for your TRN in Israel. If you're not a local authorized dealer with
        /// an Israeli VAT ID, specify your tax identification number so that Amazon Web Services
        /// can send you a compliant tax invoice.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public IsraelDealerType DealerType { get; set; }

        /// <summary>
        /// Checks to see if the DealerType property is set.
        /// </summary>
        internal bool IsSetDealerType() => this.DealerType != null;
    }
}
