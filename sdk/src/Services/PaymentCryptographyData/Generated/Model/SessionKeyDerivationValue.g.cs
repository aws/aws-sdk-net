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
    /// Parameters to derive session key value using a MAC EMV algorithm.
    /// </summary>
    public partial class SessionKeyDerivationValue
    {
        /// <summary>
        /// Gets and sets the property ApplicationCryptogram. 
        /// <para>
        /// The cryptogram provided by the terminal during transaction processing.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 16, Max = 16)]
        public string ApplicationCryptogram { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationCryptogram property is set.
        /// </summary>
        internal bool IsSetApplicationCryptogram() => this.ApplicationCryptogram != null;

        /// <summary>
        /// Gets and sets the property ApplicationTransactionCounter. 
        /// <para>
        /// The transaction counter that is provided by the terminal during transaction processing.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 4, Max = 4)]
        public string ApplicationTransactionCounter { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationTransactionCounter property is set.
        /// </summary>
        internal bool IsSetApplicationTransactionCounter() => this.ApplicationTransactionCounter != null;
    }
}
