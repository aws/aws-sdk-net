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
 * Do not modify this file. This file is generated from the mwaa-serverless-2024-07-26.normal.json service model.
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
namespace Amazon.MWAAServerless.Model
{
    /// <summary>
    /// Configuration for encrypting workflow data at rest and in transit. Amazon Managed
    /// Workflows for Apache Airflow Serverless provides comprehensive encryption capabilities
    /// to protect sensitive workflow data, parameters, and execution logs. When using customer-managed
    /// keys, the service integrates with Amazon Web Services KMS to provide fine-grained
    /// access control and audit capabilities. Encryption is applied consistently across the
    /// distributed execution environment including task containers, metadata storage, and
    /// log streams.
    /// </summary>
    public partial class EncryptionConfiguration
    {
        private string _kmsKeyId;
        private EncryptionType _type;

        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// The ID or ARN of the Amazon Web Services KMS key to use for encryption. Required when
        /// <c>Type</c> is <c>CUSTOMER_MANAGED_KEY</c>.
        /// </para>
        /// </summary>
        public string KmsKeyId
        {
            get { return this._kmsKeyId; }
            set { this._kmsKeyId = value; }
        }

        // Check to see if KmsKeyId property is set
        internal bool IsSetKmsKeyId()
        {
            return this._kmsKeyId != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of encryption to use. Values are <c>AWS_MANAGED_KEY</c> (Amazon Web Services
        /// manages the encryption key) or <c>CUSTOMER_MANAGED_KEY</c> (you provide a KMS key).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public EncryptionType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}