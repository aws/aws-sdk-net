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
 * Do not modify this file. This file is generated from the cloudfront-2020-05-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudFront.Model
{
    /// <summary>
    /// A list of identifiers for the public keys that CloudFront can use to verify the signatures
    /// of signed URLs and signed cookies.
    /// </summary>
    public partial class KGKeyPairIds
    {
        private string _keyGroupId;
        private KeyPairIds _keyPairIds;

        /// <summary>
        /// Gets and sets the property KeyGroupId. 
        /// <para>
        /// The identifier of the key group that contains the public keys.
        /// </para>
        /// </summary>
        public string KeyGroupId
        {
            get { return this._keyGroupId; }
            set { this._keyGroupId = value; }
        }

        // Check to see if KeyGroupId property is set
        internal bool IsSetKeyGroupId()
        {
            return this._keyGroupId != null;
        }

        /// <summary>
        /// Gets and sets the property KeyPairIds.
        /// </summary>
        public KeyPairIds KeyPairIds
        {
            get { return this._keyPairIds; }
            set { this._keyPairIds = value; }
        }

        // Check to see if KeyPairIds property is set
        internal bool IsSetKeyPairIds()
        {
            return this._keyPairIds != null;
        }

    }
}