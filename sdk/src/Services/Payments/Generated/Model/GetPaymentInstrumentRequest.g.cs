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

namespace Amazon.Payments.Model
{
    /// <summary>
    /// Container for the parameters to the GetPaymentInstrument operation. Retrieves a payment
    /// instrument on your account, including the details that are specific to its payment
    /// method, such as a card's last four digits. Identify the instrument by its Amazon Resource
    /// Name (ARN) or by its ID. <c>ListPaymentInstruments</c> returns both. <para> To use
    /// this operation, you must have Amazon Web Services Identity and Access Management (IAM)
    /// permission for <c>payments:GetPaymentInstrument</c>. You can scope this permission
    /// to the instrument's ARN. </para>
    /// </summary>
    public partial class GetPaymentInstrumentRequest : AmazonPaymentsRequest
    {
        /// <summary>
        /// Gets and sets the property Identifier. 
        /// <para>
        /// The instrument to retrieve. Specify one of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The Amazon Resource Name (ARN) of the instrument, as <c>ListPaymentInstruments</c>
        /// returns in <c>arn</c>. The ARN must be for an instrument on your account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The ID of the instrument, as <c>ListPaymentInstruments</c> returns in <c>id</c>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string Identifier { get; set; }

        /// <summary>
        /// Checks to see if the Identifier property is set.
        /// </summary>
        internal bool IsSetIdentifier() => this.Identifier != null;
    }
}
