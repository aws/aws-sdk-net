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
    /// The details of a China bank redirect instrument. A retail instrument is registered
    /// with one bank and carries that bank's code. A corporate instrument isn't registered
    /// with a bank.
    /// </summary>
    public partial class CnBankRedirect
    {
        /// <summary>
        /// Gets and sets the property BankCode. 
        /// <para>
        /// The code of the bank that the instrument is registered with. This member is present
        /// only for retail instruments.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string BankCode { get; set; }

        /// <summary>
        /// Checks to see if the BankCode property is set.
        /// </summary>
        internal bool IsSetBankCode() => this.BankCode != null;
    }
}
