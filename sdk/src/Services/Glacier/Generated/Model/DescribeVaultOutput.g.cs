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

namespace Amazon.Glacier.Model
{
    /// <summary>
    /// Contains the Amazon Glacier response to your request.
    /// </summary>
    public partial class DescribeVaultOutput
    {
        /// <summary>
        /// Gets and sets the property CreationDate. 
        /// <para>
        /// The Universal Coordinated Time (UTC) date when the vault was created. This value should
        /// be a string in the ISO 8601 date format, for example <c>2012-03-20T17:03:43.221Z</c>.
        /// </para>
        /// </summary>
        public DateTime? CreationDate { get; set; }

        /// <summary>
        /// Checks to see if the CreationDate property is set.
        /// </summary>
        internal bool IsSetCreationDate() => this.CreationDate.HasValue;

        /// <summary>
        /// Gets and sets the property LastInventoryDate. 
        /// <para>
        /// The Universal Coordinated Time (UTC) date when Amazon Glacier completed the last vault
        /// inventory. This value should be a string in the ISO 8601 date format, for example
        /// <c>2012-03-20T17:03:43.221Z</c>.
        /// </para>
        /// </summary>
        public DateTime? LastInventoryDate { get; set; }

        /// <summary>
        /// Checks to see if the LastInventoryDate property is set.
        /// </summary>
        internal bool IsSetLastInventoryDate() => this.LastInventoryDate.HasValue;

        /// <summary>
        /// Gets and sets the property NumberOfArchives. 
        /// <para>
        /// The number of archives in the vault as of the last inventory date. This field will
        /// return <c>null</c> if an inventory has not yet run on the vault, for example if you
        /// just created the vault.
        /// </para>
        /// </summary>
        public long? NumberOfArchives { get; set; }

        /// <summary>
        /// Checks to see if the NumberOfArchives property is set.
        /// </summary>
        internal bool IsSetNumberOfArchives() => this.NumberOfArchives.HasValue;

        /// <summary>
        /// Gets and sets the property SizeInBytes. 
        /// <para>
        /// Total size, in bytes, of the archives in the vault as of the last inventory date.
        /// This field will return null if an inventory has not yet run on the vault, for example
        /// if you just created the vault.
        /// </para>
        /// </summary>
        public long? SizeInBytes { get; set; }

        /// <summary>
        /// Checks to see if the SizeInBytes property is set.
        /// </summary>
        internal bool IsSetSizeInBytes() => this.SizeInBytes.HasValue;

        /// <summary>
        /// Gets and sets the property VaultARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the vault.
        /// </para>
        /// </summary>
        public string VaultARN { get; set; }

        /// <summary>
        /// Checks to see if the VaultARN property is set.
        /// </summary>
        internal bool IsSetVaultARN() => this.VaultARN != null;

        /// <summary>
        /// Gets and sets the property VaultName. 
        /// <para>
        /// The name of the vault.
        /// </para>
        /// </summary>
        public string VaultName { get; set; }

        /// <summary>
        /// Checks to see if the VaultName property is set.
        /// </summary>
        internal bool IsSetVaultName() => this.VaultName != null;
    }
}
