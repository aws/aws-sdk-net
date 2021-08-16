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

using Amazon.Runtime;

namespace Amazon.S3.Model
{
    /// <summary>
    /// Container for the parameters to the PutBucketInventoryConfiguration operation.
    /// This implementation of the <code>PUT</code> action adds an inventory configuration
    /// (identified by the inventory ID) to the bucket. You can have up to 1,000 inventory
    /// configurations per bucket. 
    /// 
    ///  
    /// <para>
    /// Amazon S3 inventory generates inventories of the objects in the bucket on a daily
    /// or weekly basis, and the results are published to a flat file. The bucket that is
    /// inventoried is called the <i>source</i> bucket, and the bucket where the inventory
    /// flat file is stored is called the <i>destination</i> bucket. The <i>destination</i>
    /// bucket must be in the same Amazon Web Services Region as the <i>source</i> bucket.
    /// 
    /// </para>
    ///  
    /// <para>
    /// When you configure an inventory for a <i>source</i> bucket, you specify the <i>destination</i>
    /// bucket where you want the inventory to be stored, and whether to generate the inventory
    /// daily or weekly. You can also configure what object metadata to include and whether
    /// to inventory all object versions or only current versions. For more information, see
    /// <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/storage-inventory.html">Amazon
    /// S3 Inventory</a> in the Amazon S3 User Guide.
    /// </para>
    ///  <important> 
    /// <para>
    /// You must create a bucket policy on the <i>destination</i> bucket to grant permissions
    /// to Amazon S3 to write objects to the bucket in the defined location. For an example
    /// policy, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/example-bucket-policies.html#example-bucket-policies-use-case-9">
    /// Granting Permissions for Amazon S3 Inventory and Storage Class Analysis</a>.
    /// </para>
    ///  </important> 
    /// <para>
    /// To use this operation, you must have permissions to perform the <code>s3:PutInventoryConfiguration</code>
    /// action. The bucket owner has this permission by default and can grant this permission
    /// to others. For more information about permissions, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/using-with-s3-actions.html#using-with-s3-actions-related-to-bucket-subresources">Permissions
    /// Related to Bucket Subresource Operations</a> and <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/s3-access-control.html">Managing
    /// Access Permissions to Your Amazon S3 Resources</a> in the Amazon S3 User Guide.
    /// </para>
    ///  <para class="title"> <b>Special Errors</b> 
    /// </para>
    ///  <ul> <li> <para class="title"> <b>HTTP 400 Bad Request Error</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <i>Code:</i> InvalidArgument
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <i>Cause:</i> Invalid Argument
    /// </para>
    ///  </li> </ul> </li> <li> <para class="title"> <b>HTTP 400 Bad Request Error</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <i>Code:</i> TooManyConfigurations
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <i>Cause:</i> You are attempting to create a new configuration but have already reached
    /// the 1,000-configuration limit. 
    /// </para>
    ///  </li> </ul> </li> <li> <para class="title"> <b>HTTP 403 Forbidden Error</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <i>Code:</i> AccessDenied
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <i>Cause:</i> You are not the owner of the specified bucket, or you do not have the
    /// <code>s3:PutInventoryConfiguration</code> bucket permission to set the configuration
    /// on the bucket. 
    /// </para>
    ///  </li> </ul> </li> </ul> <para class="title"> <b>Related Resources</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_GetBucketInventoryConfiguration.html">GetBucketInventoryConfiguration</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_DeleteBucketInventoryConfiguration.html">DeleteBucketInventoryConfiguration</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_ListBucketInventoryConfigurations.html">ListBucketInventoryConfigurations</a>
    /// 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class PutBucketInventoryConfigurationRequest : AmazonWebServiceRequest
    {
        private string bucketName;
        private string inventoryId;
        private InventoryConfiguration inventoryConfiguration;
        private string expectedBucketOwner;

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

        /// <summary>
        /// The account ID of the expected bucket owner. 
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
