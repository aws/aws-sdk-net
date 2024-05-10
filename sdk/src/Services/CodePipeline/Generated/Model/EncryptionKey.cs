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
 * Do not modify this file. This file is generated from the codepipeline-2015-07-09.normal.json service model.
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
namespace Amazon.CodePipeline.Model
{
    /// <summary>
    /// Represents information about the key used to encrypt data in the artifact store, such
    /// as an Amazon Web Services Key Management Service (Key Management Service) key.
    /// </summary>
    public partial class EncryptionKey
    {
        private string _id;
        private EncryptionKeyType _type;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID used to identify the key. For an Amazon Web Services KMS key, you can use the
        /// key ID, the key ARN, or the alias ARN.
        /// </para>
        ///  <note> 
        /// <para>
        /// Aliases are recognized only in the account that created the KMS key. For cross-account
        /// actions, you can only use the key ID or key ARN to identify the key. Cross-account
        /// actions involve using the role from the other account (AccountB), so specifying the
        /// key ID will use the key from the other account (AccountB).
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=400)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of encryption key, such as an Amazon Web Services KMS key. When creating
        /// or updating a pipeline, the value must be set to 'KMS'.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public EncryptionKeyType Type
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