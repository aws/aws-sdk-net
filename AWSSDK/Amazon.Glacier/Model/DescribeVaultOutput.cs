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

namespace Amazon.Glacier.Model
{
    /// <summary>
    /// <para>Contains the Amazon Glacier response to your request.</para>
    /// </summary>
    public class DescribeVaultOutput  
    {
        
        private string vaultARN;
        private string vaultName;
        private DateTime? creationDate;
        private DateTime? lastInventoryDate;
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

        /// <summary>
        /// Sets the VaultARN property
        /// </summary>
        /// <param name="vaultARN">The value to set for the VaultARN property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeVaultOutput WithVaultARN(string vaultARN)
        {
            this.vaultARN = vaultARN;
            return this;
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

        /// <summary>
        /// Sets the VaultName property
        /// </summary>
        /// <param name="vaultName">The value to set for the VaultName property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeVaultOutput WithVaultName(string vaultName)
        {
            this.vaultName = vaultName;
            return this;
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
        public DateTime CreationDate
        {
            get { return this.creationDate ?? default(DateTime); }
            set { this.creationDate = value; }
        }

        /// <summary>
        /// Sets the CreationDate property
        /// </summary>
        /// <param name="creationDate">The value to set for the CreationDate property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeVaultOutput WithCreationDate(DateTime creationDate)
        {
            this.creationDate = creationDate;
            return this;
        }
            

        // Check to see if CreationDate property is set
        internal bool IsSetCreationDate()
        {
            return this.creationDate.HasValue;       
        }

        /// <summary>
        /// The UTC date when Amazon Glacier completed the last vault inventory. A string representation of ISO 8601 date format, for example,
        /// "2012-03-20T17:03:43.221Z".
        ///  
        /// </summary>
        public DateTime LastInventoryDate
        {
            get { return this.lastInventoryDate ?? default(DateTime); }
            set { this.lastInventoryDate = value; }
        }

        /// <summary>
        /// Sets the LastInventoryDate property
        /// </summary>
        /// <param name="lastInventoryDate">The value to set for the LastInventoryDate property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeVaultOutput WithLastInventoryDate(DateTime lastInventoryDate)
        {
            this.lastInventoryDate = lastInventoryDate;
            return this;
        }
            

        // Check to see if LastInventoryDate property is set
        internal bool IsSetLastInventoryDate()
        {
            return this.lastInventoryDate.HasValue;       
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

        /// <summary>
        /// Sets the NumberOfArchives property
        /// </summary>
        /// <param name="numberOfArchives">The value to set for the NumberOfArchives property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeVaultOutput WithNumberOfArchives(long numberOfArchives)
        {
            this.numberOfArchives = numberOfArchives;
            return this;
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

        /// <summary>
        /// Sets the SizeInBytes property
        /// </summary>
        /// <param name="sizeInBytes">The value to set for the SizeInBytes property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeVaultOutput WithSizeInBytes(long sizeInBytes)
        {
            this.sizeInBytes = sizeInBytes;
            return this;
        }
            

        // Check to see if SizeInBytes property is set
        internal bool IsSetSizeInBytes()
        {
            return this.sizeInBytes.HasValue;       
        }
    }
}
