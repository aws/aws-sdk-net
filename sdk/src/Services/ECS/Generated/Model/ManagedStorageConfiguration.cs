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
        /// Specify the Key Management Service key ID for the Fargate ephemeral storage.
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
        /// Specify a Amazon Web Services Key Management Service key ID to encrypt the managed
        /// storage.
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