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
    /// This is the response object from the TranslateKeyMaterial operation.
    /// </summary>
    public partial class TranslateKeyMaterialResponse : AmazonWebServiceResponse
    {
        private WrappedWorkingKey _wrappedKey;

        /// <summary>
        /// Gets and sets the property WrappedKey. 
        /// <para>
        /// The outgoing KEK wrapped TR31WrappedKeyBlock.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public WrappedWorkingKey WrappedKey
        {
            get { return this._wrappedKey; }
            set { this._wrappedKey = value; }
        }

        // Check to see if WrappedKey property is set
        internal bool IsSetWrappedKey()
        {
            return this._wrappedKey != null;
        }

    }
}