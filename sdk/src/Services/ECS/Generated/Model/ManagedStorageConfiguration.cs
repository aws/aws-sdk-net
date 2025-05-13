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
 * Do not modify this file. This file is generated from the ecs-2014-11-13.normal.json service model.
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
namespace Amazon.ECS.Model
{
    /// <summary>
    /// The managed storage configuration for the cluster.
    /// </summary>
    public partial class ManagedStorageConfiguration
    {
        private string _fargateEphemeralStorageKmsKeyId;
        private string _kmsKeyId;

        /// <summary>
        /// Gets and sets the property FargateEphemeralStorageKmsKeyId. 
        /// <para>
        /// Specify the Key Management Service key ID for Fargate ephemeral storage.
        /// </para>
        ///  
        /// <para>
        /// When you specify a <c>fargateEphemeralStorageKmsKeyId</c>, Amazon Web Services Fargate
        /// uses the key to encrypt data at rest in ephemeral storage. For more information about
        /// Fargate ephemeral storage encryption, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/fargate-storage-encryption.html">Customer
        /// managed keys for Amazon Web Services Fargate ephemeral storage for Amazon ECS</a>
        /// in the <i>Amazon Elastic Container Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// The key must be a single Region key.
        /// </para>
        /// </summary>
        public string FargateEphemeralStorageKmsKeyId
        {
            get { return this._fargateEphemeralStorageKmsKeyId; }
            set { this._fargateEphemeralStorageKmsKeyId = value; }
        }

        // Check to see if FargateEphemeralStorageKmsKeyId property is set
        internal bool IsSetFargateEphemeralStorageKmsKeyId()
        {
            return this._fargateEphemeralStorageKmsKeyId != null;
        }

        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// Specify a Key Management Service key ID to encrypt Amazon ECS managed storage.
        /// </para>
        ///  
        /// <para>
        ///  When you specify a <c>kmsKeyId</c>, Amazon ECS uses the key to encrypt data volumes
        /// managed by Amazon ECS that are attached to tasks in the cluster. The following data
        /// volumes are managed by Amazon ECS: Amazon EBS. For more information about encryption
        /// of Amazon EBS volumes attached to Amazon ECS tasks, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/ebs-kms-encryption.html">Encrypt
        /// data stored in Amazon EBS volumes for Amazon ECS</a> in the <i>Amazon Elastic Container
        /// Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// The key must be a single Region key.
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

    }
}