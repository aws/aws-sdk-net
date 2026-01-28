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
 * Do not modify this file. This file is generated from the s3control-2018-08-20.normal.json service model.
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
namespace Amazon.S3Control.Model
{
    /// <summary>
    /// With the <c>UpdateObjectEncryption</c> operation, you can atomically update the server-side
    /// encryption type of an existing object in a general purpose bucket without any data
    /// movement.
    /// </summary>
    public partial class S3UpdateObjectEncryptionOperation
    {
        private ObjectEncryption _objectEncryption;

        /// <summary>
        /// Gets and sets the property ObjectEncryption. 
        /// <para>
        /// The updated server-side encryption type for this S3 object. The <c>UpdateObjectEncryption</c>
        /// operation supports the SSE-KMS encryption type.
        /// </para>
        /// </summary>
        public ObjectEncryption ObjectEncryption
        {
            get { return this._objectEncryption; }
            set { this._objectEncryption = value; }
        }

        // Check to see if ObjectEncryption property is set
        internal bool IsSetObjectEncryption()
        {
            return this._objectEncryption != null;
        }

    }
}