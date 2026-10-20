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

namespace Amazon.ECS.Model
{
    /// <summary>
    /// The amount of ephemeral storage to allocate for the task.
    /// </summary>
    public partial class TaskEphemeralStorage
    {
        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// Specify an Key Management Service key ID to encrypt the ephemeral storage for the
        /// task.
        /// </para>
        /// </summary>
        public string KmsKeyId { get; set; }

        /// <summary>
        /// Checks to see if the KmsKeyId property is set.
        /// </summary>
        internal bool IsSetKmsKeyId() => this.KmsKeyId != null;

        /// <summary>
        /// Gets and sets the property SizeInGiB. 
        /// <para>
        /// The total amount, in GiB, of the ephemeral storage to set for the task. The minimum
        /// supported value is <c>20</c> GiB and the maximum supported value is <c>200</c> GiB.
        /// </para>
        /// </summary>
        public int? SizeInGiB { get; set; }

        /// <summary>
        /// Checks to see if the SizeInGiB property is set.
        /// </summary>
        internal bool IsSetSizeInGiB() => this.SizeInGiB.HasValue;
    }
}
