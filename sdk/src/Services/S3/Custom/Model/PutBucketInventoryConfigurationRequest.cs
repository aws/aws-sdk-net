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

using Amazon.Runtime;

namespace Amazon.S3.Model
{
    /// <summary>
    /// Container for the parameters to the PutBucketRequestPayment operation.
    /// <para>Adds an inventory configuration (identified by the inventory ID) from the bucket.</para>
    /// </summary>
    public partial class PutBucketInventoryConfigurationRequest : AmazonWebServiceRequest
    {
        private string bucketName;
        private string inventoryId;
        private InventoryConfiguration inventoryConfiguration;

        /// <summary>
        /// The name of the bucket where the inventory configuration will be stored.
        /// </summary>
        public string BucketName
        {
            get { return this.bucketName; }
            set { this.bucketName = value; }
        }

        // Check to see if Bucket property is set
        internal bool IsSetBucketName()
        {
            return !(string.IsNullOrEmpty(this.bucketName));
        }

        /// <summary>
        /// Specifies the inventory Id.
        /// </summary>
        public string InventoryId
        {
            get { return this.inventoryId; }
            set { this.inventoryId = value; }
        }

        // Check to see if InventoryId property is set
        internal bool IsSetInventoryId()
        {
            return !(string.IsNullOrEmpty(this.inventoryId));
        }

        /// <summary>
        /// Specifies the inventory configuration.
        /// </summary>
        public InventoryConfiguration InventoryConfiguration
        {
            get { return this.inventoryConfiguration; }
            set { this.inventoryConfiguration = value; }
        }

        // Check to see if InventoryConfiguration property is set
        internal bool IsSetInventoryConfiguration()
        {
            return this.inventoryConfiguration != null;
        }

    }
}
