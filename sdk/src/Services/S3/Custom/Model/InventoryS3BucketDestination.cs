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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;


namespace Amazon.S3.Model
{
    /// <summary>
    /// The InventoryS3BucketDestination contains information where the inventory results will be saved in S3.
    /// </summary>
    public class InventoryS3BucketDestination
    {
        private string accountId;
        private string bucketName;
        private string prefix;
        private InventoryFormat inventoryFormat;
        private InventoryEncryption inventoryEncryption;
        /// <summary>
        /// The ID of the account that owns the destination bucket.
        /// </summary>
        public string AccountId
        {
            get { return this.accountId; }
            set { this.accountId = value; }
        }

        /// <summary>
        /// Check to see if AccountId property is set
        /// </summary>
        /// <returns></returns>
        public bool IsSetAccountId()
        {
            return !(string.IsNullOrEmpty(this.accountId));
        }

        /// <summary>
        /// The Amazon resource name (ARN) of the bucket where inventory results will be published.
        /// </summary>
        public string BucketName
        {
            get { return this.bucketName; }
            set { this.bucketName = value; }
        }

        // Check to see if BucketName property is set
        internal bool IsSetBucketName()
        {
            return !(string.IsNullOrEmpty(this.bucketName));
        }
        /// <summary>
        /// The prefix that is prepended to all inventory results.
        /// </summary>
        public string Prefix
        {
            get { return this.prefix; }
            set { this.prefix = value; }
        }


        // Check to see if Prefix property is set
        internal bool IsSetPrefix()
        {
            return !(string.IsNullOrEmpty(this.prefix));
        }

        /// <summary>
        /// Specifies the output format of the inventory results.
        /// </summary>
        public InventoryFormat InventoryFormat
        {
            get { return this.inventoryFormat; }
            set { this.inventoryFormat = value; }
        }

        // Check to see if InventoryFormat property is set
        internal bool IsSetInventoryFormat()
        {
            return this.inventoryFormat != null;
        }

        /// <summary>
        /// Contains the type of server-side encryption used to encrypt the inventory results.
        /// </summary>
        public InventoryEncryption InventoryEncryption
        {
            get { return this.inventoryEncryption; }
            set { this.inventoryEncryption = value; }
        }

        // Check to see if InventoryEncryption property is set
        internal bool IsSetInventoryEncryption()
        {
            return this.inventoryEncryption != null;
        }

    }
}
