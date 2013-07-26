/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using Amazon.Runtime;

namespace Amazon.Glacier.Model
{
    /// <summary>
    /// <para>Contains the Amazon Glacier response to your request.</para>
    /// </summary>
    public partial class DescribeVaultResult : AmazonWebServiceResponse
    {
        
        private string vaultARN;
        private string vaultName;
        private string creationDate;
        private string lastInventoryDate;
        private long? numberOfArchives;
        private long? sizeInBytes;

        /// <summary>
        /// The Amazon Resource Name (ARN) of the vault.
        ///  
        /// </summary>
        public string VaultARN
        {
            get { return this.vaultARN; }
            set { this.vaultARN = value; }
        }

        // Check to see if VaultARN property is set
        internal bool IsSetVaultARN()
        {
            return this.vaultARN != null;
        }

        /// <summary>
        /// The name of the vault.
        ///  
        /// </summary>
        public string VaultName
        {
            get { return this.vaultName; }
            set { this.vaultName = value; }
        }

        // Check to see if VaultName property is set
        internal bool IsSetVaultName()
        {
            return this.vaultName != null;
        }

        /// <summary>
        /// The UTC date when the vault was created. A string representation of ISO 8601 date format, for example, "2012-03-20T17:03:43.221Z".
        ///  
        /// </summary>
        public string CreationDate
        {
            get { return this.creationDate; }
            set { this.creationDate = value; }
        }

        // Check to see if CreationDate property is set
        internal bool IsSetCreationDate()
        {
            return this.creationDate != null;
        }

        /// <summary>
        /// The UTC date when Amazon Glacier completed the last vault inventory. A string representation of ISO 8601 date format, for example,
        /// "2012-03-20T17:03:43.221Z".
        ///  
        /// </summary>
        public string LastInventoryDate
        {
            get { return this.lastInventoryDate; }
            set { this.lastInventoryDate = value; }
        }

        // Check to see if LastInventoryDate property is set
        internal bool IsSetLastInventoryDate()
        {
            return this.lastInventoryDate != null;
        }

        /// <summary>
        /// The number of archives in the vault as of the last inventory date. This field will return <c>null</c> if an inventory has not yet run on the
        /// vault, for example, if you just created the vault.
        ///  
        /// </summary>
        public long NumberOfArchives
        {
            get { return this.numberOfArchives ?? default(long); }
            set { this.numberOfArchives = value; }
        }

        // Check to see if NumberOfArchives property is set
        internal bool IsSetNumberOfArchives()
        {
            return this.numberOfArchives.HasValue;
        }

        /// <summary>
        /// Total size, in bytes, of the archives in the vault as of the last inventory date. This field will return null if an inventory has not yet
        /// run on the vault, for example, if you just created the vault.
        ///  
        /// </summary>
        public long SizeInBytes
        {
            get { return this.sizeInBytes ?? default(long); }
            set { this.sizeInBytes = value; }
        }

        // Check to see if SizeInBytes property is set
        internal bool IsSetSizeInBytes()
        {
            return this.sizeInBytes.HasValue;
        }
    }
}
