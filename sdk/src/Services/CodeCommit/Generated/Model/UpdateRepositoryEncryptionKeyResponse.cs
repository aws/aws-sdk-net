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
 * Do not modify this file. This file is generated from the codecommit-2015-04-13.normal.json service model.
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
namespace Amazon.CodeCommit.Model
{
    /// <summary>
    /// This is the response object from the UpdateRepositoryEncryptionKey operation.
    /// </summary>
    public partial class UpdateRepositoryEncryptionKeyResponse : AmazonWebServiceResponse
    {
        private string _kmsKeyId;
        private string _originalKmsKeyId;
        private string _repositoryId;

        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// The ID of the encryption key.
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
        /// Gets and sets the property OriginalKmsKeyId. 
        /// <para>
        /// The ID of the encryption key formerly used to encrypt and decrypt the repository.
        /// </para>
        /// </summary>
        public string OriginalKmsKeyId
        {
            get { return this._originalKmsKeyId; }
            set { this._originalKmsKeyId = value; }
        }

        // Check to see if OriginalKmsKeyId property is set
        internal bool IsSetOriginalKmsKeyId()
        {
            return this._originalKmsKeyId != null;
        }

        /// <summary>
        /// Gets and sets the property RepositoryId. 
        /// <para>
        /// The ID of the repository.
        /// </para>
        /// </summary>
        public string RepositoryId
        {
            get { return this._repositoryId; }
            set { this._repositoryId = value; }
        }

        // Check to see if RepositoryId property is set
        internal bool IsSetRepositoryId()
        {
            return this._repositoryId != null;
        }

    }
}