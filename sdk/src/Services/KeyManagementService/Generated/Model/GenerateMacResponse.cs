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
 * Do not modify this file. This file is generated from the kms-2014-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.KeyManagementService.Model
{
    /// <summary>
    /// This is the response object from the GenerateMac operation.
    /// </summary>
    public partial class GenerateMacResponse : AmazonWebServiceResponse
    {
        private string _keyId;
        private MemoryStream _mac;
        private MacAlgorithmSpec _macAlgorithm;

        /// <summary>
        /// Gets and sets the property KeyId. 
        /// <para>
        /// The HMAC KMS key used in the operation.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string KeyId
        {
            get { return this._keyId; }
            set { this._keyId = value; }
        }

        // Check to see if KeyId property is set
        internal bool IsSetKeyId()
        {
            return this._keyId != null;
        }

        /// <summary>
        /// Gets and sets the property Mac. 
        /// <para>
        /// The hash-based message authentication code (HMAC) that was generated for the specified
        /// message, HMAC KMS key, and MAC algorithm.
        /// </para>
        ///  
        /// <para>
        /// This is the standard, raw HMAC defined in <a href="https://datatracker.ietf.org/doc/html/rfc2104">RFC
        /// 2104</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=6144)]
        public MemoryStream Mac
        {
            get { return this._mac; }
            set { this._mac = value; }
        }

        // Check to see if Mac property is set
        internal bool IsSetMac()
        {
            return this._mac != null;
        }

        /// <summary>
        /// Gets and sets the property MacAlgorithm. 
        /// <para>
        /// The MAC algorithm that was used to generate the HMAC.
        /// </para>
        /// </summary>
        public MacAlgorithmSpec MacAlgorithm
        {
            get { return this._macAlgorithm; }
            set { this._macAlgorithm = value; }
        }

        // Check to see if MacAlgorithm property is set
        internal bool IsSetMacAlgorithm()
        {
            return this._macAlgorithm != null;
        }

    }
}