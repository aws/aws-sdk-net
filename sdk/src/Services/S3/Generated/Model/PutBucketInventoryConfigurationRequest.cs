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
 * Do not modify this file. This file is generated from the s3-2006-03-01.normal.json service model.
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
namespace Amazon.S3.Model
{
    /// <summary>
    /// Container for the parameters to the PutBucketInventoryConfiguration operation.
    /// This implementation of the <c>PUT</c> action adds an S3 Inventory configuration (identified
    /// by the inventory ID) to the bucket. You can have up to 1,000 inventory configurations
    /// per bucket. 
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
    ///  </important> <note> 
    /// <para>
    ///  <b>Directory buckets </b> - For directory buckets, you must make requests for this
    /// API operation to the Regional endpoint. These endpoints support path-style requests
    /// in the format <c>https://s3express-control.<i>region-code</i>.amazonaws.com/<i>bucket-name</i>
    /// </c>. Virtual-hosted-style requests aren't supported. For more information about endpoints
    /// in Availability Zones, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/endpoint-directory-buckets-AZ.html">Regional
    /// and Zonal endpoints for directory buckets in Availability Zones</a> in the <i>Amazon
    /// S3 User Guide</i>. For more information about endpoints in Local Zones, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/s3-lzs-for-directory-buckets.html">Concepts
    /// for directory buckets in Local Zones</a> in the <i>Amazon S3 User Guide</i>.
    /// </para>
    ///  </note> <dl> <dt>Permissions</dt> <dd> 
    /// <para>
    /// To use this operation, you must have permission to perform the <c>s3:PutInventoryConfiguration</c>
    /// action. The bucket owner has this permission by default and can grant this permission
    /// to others. 
    /// </para>
    ///  
    /// <para>
    /// The <c>s3:PutInventoryConfiguration</c> permission allows a user to create an <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/storage-inventory.html">S3
    /// Inventory</a> report that includes all object metadata fields available and to specify
    /// the destination bucket to store the inventory. A user with read access to objects
    /// in the destination bucket can also access all object metadata fields that are available
    /// in the inventory report. 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <b>General purpose bucket permissions</b> - The <c>s3:PutInventoryConfiguration</c>
    /// permission is required in a policy. For more information about general purpose buckets
    /// permissions, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/using-iam-policies.html">Using
    /// Bucket Policies and User Policies</a> in the <i>Amazon S3 User Guide</i>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Directory bucket permissions</b> - To grant access to this API operation, you
    /// must have the <c>s3express:PutInventoryConfiguration</c> permission in an IAM identity-based
    /// policy instead of a bucket policy. For more information about directory bucket policies
    /// and permissions, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/s3-express-security-iam.html">Amazon
    /// Web Services Identity and Access Management (IAM) for S3 Express One Zone</a> in the
    /// <i>Amazon S3 User Guide</i>.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// To restrict access to an inventory report, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/example-bucket-policies.html#example-bucket-policies-s3-inventory">Restricting
    /// access to an Amazon S3 Inventory report</a> in the <i>Amazon S3 User Guide</i>. For
    /// more information about the metadata fields available in S3 Inventory, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/storage-inventory.html#storage-inventory-contents">Amazon
    /// S3 Inventory lists</a> in the <i>Amazon S3 User Guide</i>. For more information about
    /// permissions, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/using-with-s3-actions.html#using-with-s3-actions-related-to-bucket-subresources">Permissions
    /// related to bucket subresource operations</a> and <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/s3-access-control.html">Identity
    /// and access management in Amazon S3</a> in the <i>Amazon S3 User Guide</i>.
    /// </para>
    ///  </dd> <dt>HTTP Host header syntax</dt> <dd> 
    /// <para>
    ///  <b>Directory buckets </b> - The HTTP Host header syntax is <c>s3express-control.<i>region-code</i>.amazonaws.com</c>.
    /// </para>
    ///  </dd> </dl> 
    /// <para>
    ///  <c>PutBucketInventoryConfiguration</c> has the following special errors:
    /// </para>
    ///  <dl> <dt>HTTP 400 Bad Request Error</dt> <dd> 
    /// <para>
    ///  <i>Code:</i> InvalidArgument
    /// </para>
    ///  
    /// <para>
    ///  <i>Cause:</i> Invalid Argument
    /// </para>
    ///  </dd> <dt>HTTP 400 Bad Request Error</dt> <dd> 
    /// <para>
    ///  <i>Code:</i> TooManyConfigurations
    /// </para>
    ///  
    /// <para>
    ///  <i>Cause:</i> You are attempting to create a new configuration but have already reached
    /// the 1,000-configuration limit. 
    /// </para>
    ///  </dd> <dt>HTTP 403 Forbidden Error</dt> <dd> 
    /// <para>
    ///  <i>Cause:</i> You are not the owner of the specified bucket, or you do not have the
    /// <c>s3:PutInventoryConfiguration</c> bucket permission to set the configuration on
    /// the bucket. 
    /// </para>
    ///  </dd> </dl> 
    /// <para>
    /// The following operations are related to <c>PutBucketInventoryConfiguration</c>:
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
    ///  </li> </ul> <important> 
    /// <para>
    /// You must URL encode any signed header values that contain spaces. For example, if
    /// your header value is <c>my file.txt</c>, containing two spaces after <c>my</c>, you
    /// must URL encode this value to <c>my%20%20file.txt</c>.
    /// </para>
    ///  </important>
    /// </summary>
    public partial class PutBucketInventoryConfigurationRequest : AmazonWebServiceRequest
    {
        private string _bucketName;
        private string _expectedBucketOwner;
        private InventoryConfiguration _inventoryConfiguration;
        private string _inventoryId;

        /// <summary>
        /// Gets and sets the property BucketName. 
        /// <para>
        /// The name of the bucket where the inventory configuration will be stored.
        /// </para>
        ///  
        /// <para>
        ///  <b>Directory buckets </b> - When you use this operation with a directory bucket,
        /// you must use path-style requests in the format <c>https://s3express-control.<i>region-code</i>.amazonaws.com/<i>bucket-name</i>
        /// </c>. Virtual-hosted-style requests aren't supported. Directory bucket names must
        /// be unique in the chosen Zone (Availability Zone or Local Zone). Bucket names must
        /// also follow the format <c> <i>bucket-base-name</i>--<i>zone-id</i>--x-s3</c> (for
        /// example, <c> <i>DOC-EXAMPLE-BUCKET</i>--<i>usw2-az1</i>--x-s3</c>). For information
        /// about bucket naming restrictions, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/directory-bucket-naming-rules.html">Directory
        /// bucket naming rules</a> in the <i>Amazon S3 User Guide</i> 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string BucketName
        {
            get { return this._bucketName; }
            set { this._bucketName = value; }
        }

        // Check to see if BucketName property is set
        internal bool IsSetBucketName()
        {
            return this._bucketName != null;
        }

        /// <summary>
        /// Gets and sets the property ExpectedBucketOwner. 
        /// <para>
        /// The account ID of the expected bucket owner. If the account ID that you provide does
        /// not match the actual owner of the bucket, the request fails with the HTTP status code
        /// <c>403 Forbidden</c> (access denied).
        /// </para>
        ///  <note> 
        /// <para>
        /// For directory buckets, this header is not supported in this API operation. If you
        /// specify this header, the request fails with the HTTP status code <c>501 Not Implemented</c>.
        /// </para>
        ///  </note>
        /// </summary>
        public string ExpectedBucketOwner
        {
            get { return this._expectedBucketOwner; }
            set { this._expectedBucketOwner = value; }
        }

        // Check to see if ExpectedBucketOwner property is set
        internal bool IsSetExpectedBucketOwner()
        {
            return !String.IsNullOrEmpty(this._expectedBucketOwner);
        }

        /// <summary>
        /// Gets and sets the property InventoryConfiguration. 
        /// <para>
        /// Specifies the inventory configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public InventoryConfiguration InventoryConfiguration
        {
            get { return this._inventoryConfiguration; }
            set { this._inventoryConfiguration = value; }
        }

        // Check to see if InventoryConfiguration property is set
        internal bool IsSetInventoryConfiguration()
        {
            return this._inventoryConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property InventoryId. 
        /// <para>
        /// The ID used to identify the inventory configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string InventoryId
        {
            get { return this._inventoryId; }
            set { this._inventoryId = value; }
        }

        // Check to see if InventoryId property is set
        internal bool IsSetInventoryId()
        {
            return this._inventoryId != null;
        }

    }
}