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

namespace Amazon.PaymentCryptographyData.Model
{
    /// <summary>
    /// Parameter information to use a PEK derived using AS2805.
    /// </summary>
    public partial class As2805PekDerivationAttributes
    {
        /// <summary>
        /// Gets and sets the property SystemTraceAuditNumber. 
        /// <para>
        /// The system trace audit number for the transaction.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 6, Max = 6)]
        public string SystemTraceAuditNumber { get; set; }

        /// <summary>
        /// Checks to see if the SystemTraceAuditNumber property is set.
        /// </summary>
        internal bool IsSetSystemTraceAuditNumber() => this.SystemTraceAuditNumber != null;

        /// <summary>
        /// Gets and sets the property TransactionAmount. 
        /// <para>
        /// The transaction amount for the transaction.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 12, Max = 12)]
        public string TransactionAmount { get; set; }

        /// <summary>
        /// Checks to see if the TransactionAmount property is set.
        /// </summary>
        internal bool IsSetTransactionAmount() => this.TransactionAmount != null;
    }
}
