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
 * Do not modify this file. This file is generated from the workdocs-2016-05-01.normal.json service model.
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
namespace Amazon.WorkDocs.Model
{
    /// <summary>
    /// Describes the storage for a user.
    /// </summary>
    public partial class UserStorageMetadata
    {
        private StorageRuleType _storageRule;
        private long? _storageUtilizedInBytes;

        /// <summary>
        /// Gets and sets the property StorageRule. 
        /// <para>
        /// The storage for a user.
        /// </para>
        /// </summary>
        public StorageRuleType StorageRule
        {
            get { return this._storageRule; }
            set { this._storageRule = value; }
        }

        // Check to see if StorageRule property is set
        internal bool IsSetStorageRule()
        {
            return this._storageRule != null;
        }

        /// <summary>
        /// Gets and sets the property StorageUtilizedInBytes. 
        /// <para>
        /// The amount of storage used, in bytes.
        /// </para>
        /// </summary>
        public long? StorageUtilizedInBytes
        {
            get { return this._storageUtilizedInBytes; }
            set { this._storageUtilizedInBytes = value; }
        }

        // Check to see if StorageUtilizedInBytes property is set
        internal bool IsSetStorageUtilizedInBytes()
        {
            return this._storageUtilizedInBytes.HasValue; 
        }

    }
}