/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.KeyManagementService.Model
{
    /// <summary>
    /// Container for the parameters to the GenerateRandom operation.
    /// Returns a random byte string that is cryptographically secure.
    /// 
    ///  
    /// <para>
    /// By default, the random byte string is generated in AWS KMS. To generate the byte string
    /// in the AWS CloudHSM cluster that is associated with a <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-store-overview.html">custom
    /// key store</a>, specify the custom key store ID.
    /// </para>
    ///  
    /// <para>
    /// For more information about entropy and random number generation, see the <a href="https://d0.awsstatic.com/whitepapers/KMS-Cryptographic-Details.pdf">AWS
    /// Key Management Service Cryptographic Details</a> whitepaper.
    /// </para>
    /// </summary>
    public partial class GenerateRandomRequest : AmazonKeyManagementServiceRequest
    {
        private string _customKeyStoreId;
        private int? _numberOfBytes;

        /// <summary>
        /// Gets and sets the property CustomKeyStoreId. 
        /// <para>
        /// Generates the random byte string in the AWS CloudHSM cluster that is associated with
        /// the specified <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-store-overview.html">custom
        /// key store</a>. To find the ID of a custom key store, use the <a>DescribeCustomKeyStores</a>
        /// operation.
        /// </para>
        /// </summary>
        public string CustomKeyStoreId
        {
            get { return this._customKeyStoreId; }
            set { this._customKeyStoreId = value; }
        }

        // Check to see if CustomKeyStoreId property is set
        internal bool IsSetCustomKeyStoreId()
        {
            return this._customKeyStoreId != null;
        }

        /// <summary>
        /// Gets and sets the property NumberOfBytes. 
        /// <para>
        /// The length of the byte string.
        /// </para>
        /// </summary>
        public int NumberOfBytes
        {
            get { return this._numberOfBytes.GetValueOrDefault(); }
            set { this._numberOfBytes = value; }
        }

        // Check to see if NumberOfBytes property is set
        internal bool IsSetNumberOfBytes()
        {
            return this._numberOfBytes.HasValue; 
        }

    }
}