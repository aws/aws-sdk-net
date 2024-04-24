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
 * Do not modify this file. This file is generated from the macie2-2020-01-01.normal.json service model.
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
namespace Amazon.Macie2.Model
{
    /// <summary>
    /// Specifies the status of the Amazon Macie configuration for retrieving occurrences
    /// of sensitive data reported by findings, and the Key Management Service (KMS) key to
    /// use to encrypt sensitive data that's retrieved. When you enable the configuration
    /// for the first time, your request must specify an KMS key. Otherwise, an error occurs.
    /// </summary>
    public partial class RevealConfiguration
    {
        private string _kmsKeyId;
        private RevealStatus _status;

        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// The Amazon Resource Name (ARN), ID, or alias of the KMS key to use to encrypt sensitive
        /// data that's retrieved. The key must be an existing, customer managed, symmetric encryption
        /// key that's enabled in the same Amazon Web Services Region as the Amazon Macie account.
        /// </para>
        ///  
        /// <para>
        /// If this value specifies an alias, it must include the following prefix: alias/. If
        /// this value specifies a key that's owned by another Amazon Web Services account, it
        /// must specify the ARN of the key or the ARN of the key's alias.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
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
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the configuration for the Amazon Macie account. In a response, possible
        /// values are: ENABLED, the configuration is currently enabled for the account; and,
        /// DISABLED, the configuration is currently disabled for the account. In a request, valid
        /// values are: ENABLED, enable the configuration for the account; and, DISABLED, disable
        /// the configuration for the account.
        /// </para>
        ///  <important>
        /// <para>
        /// If you disable the configuration, you also permanently delete current settings that
        /// specify how to access affected S3 objects. If your current access method is ASSUME_ROLE,
        /// Macie also deletes the external ID and role name currently specified for the configuration.
        /// These settings can't be recovered after they're deleted.
        /// </para>
        /// </important>
        /// </summary>
        [AWSProperty(Required=true)]
        public RevealStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}