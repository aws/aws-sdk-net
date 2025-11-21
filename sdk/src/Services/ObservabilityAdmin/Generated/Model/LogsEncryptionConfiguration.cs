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
 * Do not modify this file. This file is generated from the observabilityadmin-2018-05-10.normal.json service model.
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
namespace Amazon.ObservabilityAdmin.Model
{
    /// <summary>
    /// Configuration for encrypting centralized log groups. This configuration is only applied
    /// to destination log groups for which the corresponding source log groups are encrypted
    /// using Customer Managed KMS Keys.
    /// </summary>
    public partial class LogsEncryptionConfiguration
    {
        private EncryptionConflictResolutionStrategy _encryptionConflictResolutionStrategy;
        private EncryptionStrategy _encryptionStrategy;
        private string _kmsKeyArn;

        /// <summary>
        /// Gets and sets the property EncryptionConflictResolutionStrategy. 
        /// <para>
        /// Conflict resolution strategy for centralization if the encryption strategy is set
        /// to CUSTOMER_MANAGED and the destination log group is encrypted with an AWS_OWNED KMS
        /// Key. ALLOW lets centralization go through while SKIP prevents centralization into
        /// the destination log group.
        /// </para>
        /// </summary>
        public EncryptionConflictResolutionStrategy EncryptionConflictResolutionStrategy
        {
            get { return this._encryptionConflictResolutionStrategy; }
            set { this._encryptionConflictResolutionStrategy = value; }
        }

        // Check to see if EncryptionConflictResolutionStrategy property is set
        internal bool IsSetEncryptionConflictResolutionStrategy()
        {
            return this._encryptionConflictResolutionStrategy != null;
        }

        /// <summary>
        /// Gets and sets the property EncryptionStrategy. 
        /// <para>
        /// Configuration that determines the encryption strategy of the destination log groups.
        /// CUSTOMER_MANAGED uses the configured KmsKeyArn to encrypt newly created destination
        /// log groups.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public EncryptionStrategy EncryptionStrategy
        {
            get { return this._encryptionStrategy; }
            set { this._encryptionStrategy = value; }
        }

        // Check to see if EncryptionStrategy property is set
        internal bool IsSetEncryptionStrategy()
        {
            return this._encryptionStrategy != null;
        }

        /// <summary>
        /// Gets and sets the property KmsKeyArn. 
        /// <para>
        /// KMS Key arn belonging to the primary destination account and region, to encrypt newly
        /// created central log groups in the primary destination.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1011)]
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

    }
}