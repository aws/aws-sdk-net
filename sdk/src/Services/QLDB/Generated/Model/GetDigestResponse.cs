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
 * Do not modify this file. This file is generated from the qldb-2019-01-02.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.QLDB.Model
{
    /// <summary>
    /// This is the response object from the GetDigest operation.
    /// </summary>
    public partial class GetDigestResponse : AmazonWebServiceResponse
    {
        private MemoryStream _digest;
        private ValueHolder _digestTipAddress;

        /// <summary>
        /// Gets and sets the property Digest. 
        /// <para>
        /// The 256-bit hash value representing the digest returned by a <code>GetDigest</code>
        /// request.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=32, Max=32)]
        public MemoryStream Digest
        {
            get { return this._digest; }
            set { this._digest = value; }
        }

        // Check to see if Digest property is set
        internal bool IsSetDigest()
        {
            return this._digest != null;
        }

        /// <summary>
        /// Gets and sets the property DigestTipAddress. 
        /// <para>
        /// The latest block location covered by the digest that you requested. An address is
        /// an Amazon Ion structure that has two fields: <code>strandId</code> and <code>sequenceNo</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true)]
        public ValueHolder DigestTipAddress
        {
            get { return this._digestTipAddress; }
            set { this._digestTipAddress = value; }
        }

        // Check to see if DigestTipAddress property is set
        internal bool IsSetDigestTipAddress()
        {
            return this._digestTipAddress != null;
        }

    }
}