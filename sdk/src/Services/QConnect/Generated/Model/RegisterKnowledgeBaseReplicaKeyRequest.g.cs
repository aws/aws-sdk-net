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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.QConnect.Model
{
    /// <summary>
    /// Container for the parameters to the RegisterKnowledgeBaseReplicaKey operation. Registers
    /// a replica Region KMS key for an Amazon Q in Connect knowledge base. To use this operation,
    /// you must have <c>kms:GenerateDataKey</c> permission on the replica key. You must also
    /// have <c>kms:CreateGrant</c> permission on the primary key.
    /// </summary>
    public partial class RegisterKnowledgeBaseReplicaKeyRequest : AmazonQConnectRequest
    {
        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier that you provide to ensure the idempotency of
        /// the request. If not provided, the Amazon Web Services SDK populates this field. For
        /// more information about idempotency, see <a href="http://aws.amazon.com/builders-library/making-retries-safe-with-idempotent-APIs/">Making
        /// retries safe with idempotent APIs</a>..
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 4096)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property KnowledgeBaseId. 
        /// <para>
        /// The identifier of the knowledge base.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string KnowledgeBaseId { get; set; }

        /// <summary>
        /// Checks to see if the KnowledgeBaseId property is set.
        /// </summary>
        internal bool IsSetKnowledgeBaseId() => this.KnowledgeBaseId != null;

        /// <summary>
        /// Gets and sets the property ReplicaKmsKey. 
        /// <para>
        /// The replica Region KMS key to register for the knowledge base.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ReplicaKmsKey ReplicaKmsKey { get; set; }

        /// <summary>
        /// Checks to see if the ReplicaKmsKey property is set.
        /// </summary>
        internal bool IsSetReplicaKmsKey() => this.ReplicaKmsKey != null;
    }
}
