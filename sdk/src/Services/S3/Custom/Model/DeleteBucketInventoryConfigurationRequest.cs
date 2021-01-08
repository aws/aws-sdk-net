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

using Amazon.Runtime;
using Amazon.Runtime.Internal;


namespace Amazon.S3.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteInventoryConfiguration operation.
    /// <para>Deletes an inventory configuration (identified by the inventory ID) from the bucket.</para>
    /// </summary>
    public partial class DeleteBucketInventoryConfigurationRequest : AmazonWebServiceRequest
    {
        private string bucketName;
        private string inventoryId;
        private string expectedBucketOwner;

        /// <summary>
        /// The name of the bucket containing the inventory configuration to delete.
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
        /// The ID used to identify the inventory configuration.
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
        /// The account id of the expected bucket owner. 
        /// If the bucket is owned by a different account, the request will fail with an HTTP 403 (Access Denied) error.
        /// </summary>
        public string ExpectedBucketOwner
        {
            get { return this.expectedBucketOwner; }
            set { this.expectedBucketOwner = value; }
        }

        /// <summary>
        /// Checks to see if ExpectedBucketOwner is set.
        /// </summary>
        /// <returns>true, if ExpectedBucketOwner property is set.</returns>
        internal bool IsSetExpectedBucketOwner()
        {
            return !String.IsNullOrEmpty(this.expectedBucketOwner);
        }

    }
}
