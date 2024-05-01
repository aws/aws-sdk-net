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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.QLDB.Model
{
    /// <summary>
    /// The encryption settings that are used by a journal export job to write data in an
    /// Amazon Simple Storage Service (Amazon S3) bucket.
    /// </summary>
    public partial class S3EncryptionConfiguration
    {
        private string _kmsKeyArn;
        private S3ObjectEncryptionType _objectEncryptionType;

        /// <summary>
        /// Gets and sets the property KmsKeyArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of a symmetric encryption key in Key Management Service
        /// (KMS). Amazon S3 does not support asymmetric KMS keys.
        /// </para>
        ///  
        /// <para>
        /// You must provide a <c>KmsKeyArn</c> if you specify <c>SSE_KMS</c> as the <c>ObjectEncryptionType</c>.
        /// </para>
        ///  
        /// <para>
        ///  <c>KmsKeyArn</c> is not required if you specify <c>SSE_S3</c> as the <c>ObjectEncryptionType</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=1600)]
        public string KmsKeyArn
        {
            get { return this._kmsKeyArn; }
            set { this._kmsKeyArn = value; }
        }

        // Check to see if KmsKeyArn property is set
        internal bool IsSetKmsKeyArn()
        {
            return this._kmsKeyArn != null;
        }

        /// <summary>
        /// Gets and sets the property ObjectEncryptionType. 
        /// <para>
        /// The Amazon S3 object encryption type.
        /// </para>
        ///  
        /// <para>
        /// To learn more about server-side encryption options in Amazon S3, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/serv-side-encryption.html">Protecting
        /// Data Using Server-Side Encryption</a> in the <i>Amazon S3 Developer Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public S3ObjectEncryptionType ObjectEncryptionType
        {
            get { return this._objectEncryptionType; }
            set { this._objectEncryptionType = value; }
        }

        // Check to see if ObjectEncryptionType property is set
        internal bool IsSetObjectEncryptionType()
        {
            return this._objectEncryptionType != null;
        }

    }
}