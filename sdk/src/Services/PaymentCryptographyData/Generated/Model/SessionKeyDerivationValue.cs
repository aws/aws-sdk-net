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
 * Do not modify this file. This file is generated from the payment-cryptography-data-2022-02-03.normal.json service model.
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
        private string _applicationCryptogram;
        private string _applicationTransactionCounter;

        /// <summary>
        /// Gets and sets the property ApplicationCryptogram. 
        /// <para>
        /// The cryptogram provided by the terminal during transaction processing.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=16, Max=16)]
        public string ApplicationCryptogram
        {
            get { return this._applicationCryptogram; }
            set { this._applicationCryptogram = value; }
        }

        // Check to see if ApplicationCryptogram property is set
        internal bool IsSetApplicationCryptogram()
        {
            return this._applicationCryptogram != null;
        }

        /// <summary>
        /// Gets and sets the property ApplicationTransactionCounter. 
        /// <para>
        /// The transaction counter that is provided by the terminal during transaction processing.
        /// </para>
        /// </summary>
        [AWSProperty(Min=4, Max=4)]
        public string ApplicationTransactionCounter
        {
            get { return this._applicationTransactionCounter; }
            set { this._applicationTransactionCounter = value; }
        }

        // Check to see if ApplicationTransactionCounter property is set
        internal bool IsSetApplicationTransactionCounter()
        {
            return this._applicationTransactionCounter != null;
        }

    }
}