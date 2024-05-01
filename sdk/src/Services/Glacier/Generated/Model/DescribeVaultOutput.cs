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
 * Do not modify this file. This file is generated from the glacier-2012-06-01.normal.json service model.
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
namespace Amazon.Glacier.Model
{
    /// <summary>
    /// Contains the Amazon S3 Glacier response to your request.
    /// </summary>
    public partial class DescribeVaultOutput
    {
        private DateTime? _creationDate;
        private DateTime? _lastInventoryDate;
        private long? _numberOfArchives;
        private long? _sizeInBytes;
        private string _vaultARN;
        private string _vaultName;

        /// <summary>
        /// Gets and sets the property CreationDate. 
        /// <para>
        /// The Universal Coordinated Time (UTC) date when the vault was created. This value should
        /// be a string in the ISO 8601 date format, for example <c>2012-03-20T17:03:43.221Z</c>.
        /// </para>
        /// </summary>
        public DateTime? CreationDate
        {
            get { return this._creationDate; }
            set { this._creationDate = value; }
        }

        // Check to see if CreationDate property is set
        internal bool IsSetCreationDate()
        {
            return this._creationDate != null;
        }

        /// <summary>
        /// Gets and sets the property LastInventoryDate. 
        /// <para>
        /// The Universal Coordinated Time (UTC) date when Amazon S3 Glacier completed the last
        /// vault inventory. This value should be a string in the ISO 8601 date format, for example
        /// <c>2012-03-20T17:03:43.221Z</c>.
        /// </para>
        /// </summary>
        public DateTime? LastInventoryDate
        {
            get { return this._lastInventoryDate; }
            set { this._lastInventoryDate = value; }
        }

        // Check to see if LastInventoryDate property is set
        internal bool IsSetLastInventoryDate()
        {
            return this._lastInventoryDate != null;
        }

        /// <summary>
        /// Gets and sets the property NumberOfArchives. 
        /// <para>
        /// The number of archives in the vault as of the last inventory date. This field will
        /// return <c>null</c> if an inventory has not yet run on the vault, for example if you
        /// just created the vault.
        /// </para>
        /// </summary>
        public long? NumberOfArchives
        {
            get { return this._numberOfArchives; }
            set { this._numberOfArchives = value; }
        }

        // Check to see if NumberOfArchives property is set
        internal bool IsSetNumberOfArchives()
        {
            return this._numberOfArchives.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SizeInBytes. 
        /// <para>
        /// Total size, in bytes, of the archives in the vault as of the last inventory date.
        /// This field will return null if an inventory has not yet run on the vault, for example
        /// if you just created the vault.
        /// </para>
        /// </summary>
        public long? SizeInBytes
        {
            get { return this._sizeInBytes; }
            set { this._sizeInBytes = value; }
        }

        // Check to see if SizeInBytes property is set
        internal bool IsSetSizeInBytes()
        {
            return this._sizeInBytes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property VaultARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the vault.
        /// </para>
        /// </summary>
        public string VaultARN
        {
            get { return this._vaultARN; }
            set { this._vaultARN = value; }
        }

        // Check to see if VaultARN property is set
        internal bool IsSetVaultARN()
        {
            return this._vaultARN != null;
        }

        /// <summary>
        /// Gets and sets the property VaultName. 
        /// <para>
        /// The name of the vault.
        /// </para>
        /// </summary>
        public string VaultName
        {
            get { return this._vaultName; }
            set { this._vaultName = value; }
        }

        // Check to see if VaultName property is set
        internal bool IsSetVaultName()
        {
            return this._vaultName != null;
        }

    }
}