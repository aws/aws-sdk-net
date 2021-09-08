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
 * Do not modify this file. This file is generated from the opensearch-2021-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.OpenSearchService.Model
{
    /// <summary>
    /// StorageTypes represents the list of storage-related types and their attributes that
    /// are available for a given InstanceType.
    /// </summary>
    public partial class StorageType
    {
        private string _storageSubTypeName;
        private List<StorageTypeLimit> _storageTypeLimits = new List<StorageTypeLimit>();
        private string _storageTypeName;

        /// <summary>
        /// Gets and sets the property StorageSubTypeName.
        /// </summary>
        public string StorageSubTypeName
        {
            get { return this._storageSubTypeName; }
            set { this._storageSubTypeName = value; }
        }

        // Check to see if StorageSubTypeName property is set
        internal bool IsSetStorageSubTypeName()
        {
            return this._storageSubTypeName != null;
        }

        /// <summary>
        /// Gets and sets the property StorageTypeLimits. 
        /// <para>
        /// Limits that are applicable for the given storage type. 
        /// </para>
        /// </summary>
        public List<StorageTypeLimit> StorageTypeLimits
        {
            get { return this._storageTypeLimits; }
            set { this._storageTypeLimits = value; }
        }

        // Check to see if StorageTypeLimits property is set
        internal bool IsSetStorageTypeLimits()
        {
            return this._storageTypeLimits != null && this._storageTypeLimits.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property StorageTypeName.
        /// </summary>
        public string StorageTypeName
        {
            get { return this._storageTypeName; }
            set { this._storageTypeName = value; }
        }

        // Check to see if StorageTypeName property is set
        internal bool IsSetStorageTypeName()
        {
            return this._storageTypeName != null;
        }

    }
}