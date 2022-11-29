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
    /// Container for the parameters to the GenerateRandom operation.
    /// Returns a random byte string that is cryptographically secure.
    /// 
    ///  
    /// <para>
    /// You must use the <code>NumberOfBytes</code> parameter to specify the length of the
    /// random byte string. There is no default value for string length.
    /// </para>
    ///  
    /// <para>
    /// By default, the random byte string is generated in KMS. To generate the byte string
    /// in the CloudHSM cluster associated with an CloudHSM key store, use the <code>CustomKeyStoreId</code>
    /// parameter.
    /// </para>
    ///  
    /// <para>
    /// Applications in Amazon Web Services Nitro Enclaves can call this operation by using
    /// the <a href="https://github.com/aws/aws-nitro-enclaves-sdk-c">Amazon Web Services
    /// Nitro Enclaves Development Kit</a>. For information about the supporting parameters,
    /// see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/services-nitro-enclaves.html">How
    /// Amazon Web Services Nitro Enclaves use KMS</a> in the <i>Key Management Service Developer
    /// Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// For more information about entropy and random number generation, see <a href="https://docs.aws.amazon.com/kms/latest/cryptographic-details/">Key
    /// Management Service Cryptographic Details</a>.
    /// </para>
    ///  
    /// <para>
    ///  <b>Cross-account use</b>: Not applicable. <code>GenerateRandom</code> does not use
    /// any account-specific resources, such as KMS keys.
    /// </para>
    ///  
    /// <para>
    ///  <b>Required permissions</b>: <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:GenerateRandom</a>
    /// (IAM policy)
    /// </para>
    /// </summary>
    public partial class GenerateRandomRequest : AmazonKeyManagementServiceRequest
    {
        private string _customKeyStoreId;
        private int? _numberOfBytes;

        /// <summary>
        /// Gets and sets the property CustomKeyStoreId. 
        /// <para>
        /// Generates the random byte string in the CloudHSM cluster that is associated with the
        /// specified CloudHSM key store. To find the ID of a custom key store, use the <a>DescribeCustomKeyStores</a>
        /// operation.
        /// </para>
        ///  
        /// <para>
        /// External key store IDs are not valid for this parameter. If you specify the ID of
        /// an external key store, <code>GenerateRandom</code> throws an <code>UnsupportedOperationException</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
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
        /// The length of the random byte string. This parameter is required.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
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