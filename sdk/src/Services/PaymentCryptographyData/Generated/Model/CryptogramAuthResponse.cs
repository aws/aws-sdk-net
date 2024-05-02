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
    /// Parameters that are required for Authorization Response Cryptogram (ARPC) generation
    /// after Authorization Request Cryptogram (ARQC) verification is successful.
    /// </summary>
    public partial class CryptogramAuthResponse
    {
        private CryptogramVerificationArpcMethod1 _arpcMethod1;
        private CryptogramVerificationArpcMethod2 _arpcMethod2;

        /// <summary>
        /// Gets and sets the property ArpcMethod1. 
        /// <para>
        /// Parameters that are required for ARPC response generation using method1 after ARQC
        /// verification is successful.
        /// </para>
        /// </summary>
        public CryptogramVerificationArpcMethod1 ArpcMethod1
        {
            get { return this._arpcMethod1; }
            set { this._arpcMethod1 = value; }
        }

        // Check to see if ArpcMethod1 property is set
        internal bool IsSetArpcMethod1()
        {
            return this._arpcMethod1 != null;
        }

        /// <summary>
        /// Gets and sets the property ArpcMethod2. 
        /// <para>
        /// Parameters that are required for ARPC response generation using method2 after ARQC
        /// verification is successful.
        /// </para>
        /// </summary>
        public CryptogramVerificationArpcMethod2 ArpcMethod2
        {
            get { return this._arpcMethod2; }
            set { this._arpcMethod2 = value; }
        }

        // Check to see if ArpcMethod2 property is set
        internal bool IsSetArpcMethod2()
        {
            return this._arpcMethod2 != null;
        }

    }
}