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
    /// Container for the parameters to the PutLifecycleConfiguration operation.
    /// Creates a new lifecycle configuration for the bucket or replaces an existing lifecycle
    /// configuration. Keep in mind that this will overwrite an existing lifecycle configuration,
    /// so if you want to retain any configuration details, they must be included in the new
    /// lifecycle configuration. For information about lifecycle configuration, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/object-lifecycle-mgmt.html">Managing
    /// your storage lifecycle</a>.
    /// 
    ///  <note> 
    /// <para>
    /// Bucket lifecycle configuration now supports specifying a lifecycle rule using an object
    /// key name prefix, one or more object tags, object size, or any combination of these.
    /// Accordingly, this section describes the latest API. The previous version of the API
    /// supported filtering based only on an object key name prefix, which is supported for
    /// backward compatibility. For the related API description, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_PutBucketLifecycle.html">PutBucketLifecycle</a>.
    /// </para>
    ///  </note> <dl> <dt>Rules</dt> <dt>Permissions</dt> <dt>HTTP Host header syntax</dt>
    /// <dd> 
    /// <para>
    /// You specify the lifecycle configuration in your request body. The lifecycle configuration
    /// is specified as XML consisting of one or more rules. An Amazon S3 Lifecycle configuration
    /// can have up to 1,000 rules. This limit is not adjustable.
    /// </para>
    ///  
    /// <para>
    /// Bucket lifecycle configuration supports specifying a lifecycle rule using an object
    /// key name prefix, one or more object tags, object size, or any combination of these.
    /// Accordingly, this section describes the latest API. The previous version of the API
    /// supported filtering based only on an object key name prefix, which is supported for
    /// backward compatibility for general purpose buckets. For the related API description,
    /// see <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_PutBucketLifecycle.html">PutBucketLifecycle</a>.
    /// 
    /// </para>
    ///  <note> 
    /// <para>
    /// Lifecyle configurations for directory buckets only support expiring objects and cancelling
    /// multipart uploads. Expiring of versioned objects,transitions and tag filters are not
    /// supported.
    /// </para>
    ///  </note> 
    /// <para>
    /// A lifecycle rule consists of the following:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// A filter identifying a subset of objects to which the rule applies. The filter can
    /// be based on a key name prefix, object tags, object size, or any combination of these.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// A status indicating whether the rule is in effect.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// One or more lifecycle transition and expiration actions that you want Amazon S3 to
    /// perform on the objects identified by the filter. If the state of your bucket is versioning-enabled
    /// or versioning-suspended, you can have many versions of the same object (one current
    /// version and zero or more noncurrent versions). Amazon S3 provides predefined actions
    /// that you can specify for current and noncurrent object versions.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/object-lifecycle-mgmt.html">Object
    /// Lifecycle Management</a> and <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/intro-lifecycle-rules.html">Lifecycle
    /// Configuration Elements</a>.
    /// </para>
    ///  </dd> <dd> <ul> <li> 
    /// <para>
    ///  <b>General purpose bucket permissions</b> - By default, all Amazon S3 resources are
    /// private, including buckets, objects, and related subresources (for example, lifecycle
    /// configuration and website configuration). Only the resource owner (that is, the Amazon
    /// Web Services account that created it) can access the resource. The resource owner
    /// can optionally grant access permissions to others by writing an access policy. For
    /// this operation, a user must have the <c>s3:PutLifecycleConfiguration</c> permission.
    /// </para>
    ///  
    /// <para>
    /// You can also explicitly deny permissions. An explicit deny also supersedes any other
    /// permissions. If you want to block users or accounts from removing or deleting objects
    /// from your bucket, you must deny them permissions for the following actions:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <c>s3:DeleteObject</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>s3:DeleteObjectVersion</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>s3:PutLifecycleConfiguration</c> 
    /// </para>
    ///  
    /// <para>
    /// For more information about permissions, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/s3-access-control.html">Managing
    /// Access Permissions to Your Amazon S3 Resources</a>.
    /// </para>
    ///  </li> </ul> </li> </ul> <ul> <li> 
    /// <para>
    ///  <b>Directory bucket permissions</b> - You must have the <c>s3express:PutLifecycleConfiguration</c>
    /// permission in an IAM identity-based policy to use this operation. Cross-account access
    /// to this API operation isn't supported. The resource owner can optionally grant access
    /// permissions to others by creating a role or user for them as long as they are within
    /// the same account as the owner and resource.
    /// </para>
    ///  
    /// <para>
    /// For more information about directory bucket policies and permissions, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/s3-express-security-iam.html">Authorizing
    /// Regional endpoint APIs with IAM</a> in the <i>Amazon S3 User Guide</i>.
    /// </para>
    ///  <note> 
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
    ///  </note> </li> </ul> </dd> <dd> 
    /// <para>
    ///  <b>Directory buckets </b> - The HTTP Host header syntax is <c>s3express-control.<i>region</i>.amazonaws.com</c>.
    /// </para>
    ///  
    /// <para>
    /// The following operations are related to <c>PutBucketLifecycleConfiguration</c>:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_GetBucketLifecycleConfiguration.html">GetBucketLifecycleConfiguration</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_DeleteBucketLifecycle.html">DeleteBucketLifecycle</a>
    /// 
    /// </para>
    ///  </li> </ul> </dd> </dl>
    /// </summary>
    public partial class PutLifecycleConfigurationRequest : AmazonWebServiceRequest
    {
        private string _bucketName;
        private ChecksumAlgorithm _checksumAlgorithm;
        private LifecycleConfiguration _configuration;
        private string _expectedBucketOwner;
        private TransitionDefaultMinimumObjectSize _transitionDefaultMinimumObjectSize;

        /// <summary>
        /// Gets and sets the property BucketName. 
        /// <para>
        /// The name of the bucket for which to set the configuration.
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
        /// Gets and sets the property ChecksumAlgorithm. 
        /// <para>
        /// Indicates the algorithm used to create the checksum for the request when you use the
        /// SDK. This header will not provide any additional functionality if you don't use the
        /// SDK. When you send this header, there must be a corresponding <c>x-amz-checksum</c>
        /// or <c>x-amz-trailer</c> header sent. Otherwise, Amazon S3 fails the request with the
        /// HTTP status code <c>400 Bad Request</c>. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/checking-object-integrity.html">Checking
        /// object integrity</a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// If you provide an individual checksum, Amazon S3 ignores any provided <c>ChecksumAlgorithm</c>
        /// parameter.
        /// </para>
        /// </summary>
        public ChecksumAlgorithm ChecksumAlgorithm
        {
            get { return this._checksumAlgorithm; }
            set { this._checksumAlgorithm = value; }
        }

        // Check to see if ChecksumAlgorithm property is set
        internal bool IsSetChecksumAlgorithm()
        {
            return this._checksumAlgorithm != null;
        }

        /// <summary>
        /// Gets and sets the property Configuration. 
        /// <para>
        /// Container for lifecycle rules. You can add as many as 1,000 rules.
        /// </para>
        /// </summary>
        public LifecycleConfiguration Configuration
        {
            get { return this._configuration; }
            set { this._configuration = value; }
        }

        // Check to see if Configuration property is set
        internal bool IsSetConfiguration()
        {
            return this._configuration != null;
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
        /// This parameter applies to general purpose buckets only. It is not supported for directory
        /// bucket lifecycle configurations.
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
            return this._expectedBucketOwner != null;
        }

        /// <summary>
        /// Gets and sets the property TransitionDefaultMinimumObjectSize. 
        /// <para>
        /// Indicates which default minimum object size behavior is applied to the lifecycle configuration.
        /// </para>
        ///  <note> 
        /// <para>
        /// This parameter applies to general purpose buckets only. It is not supported for directory
        /// bucket lifecycle configurations.
        /// </para>
        ///  </note> <ul> <li> 
        /// <para>
        ///  <c>all_storage_classes_128K</c> - Objects smaller than 128 KB will not transition
        /// to any storage class by default. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>varies_by_storage_class</c> - Objects smaller than 128 KB will transition to Glacier
        /// Flexible Retrieval or Glacier Deep Archive storage classes. By default, all other
        /// storage classes will prevent transitions smaller than 128 KB. 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// To customize the minimum object size for any transition you can add a filter that
        /// specifies a custom <c>ObjectSizeGreaterThan</c> or <c>ObjectSizeLessThan</c> in the
        /// body of your transition rule. Custom filters always take precedence over the default
        /// transition behavior.
        /// </para>
        /// </summary>
        public TransitionDefaultMinimumObjectSize TransitionDefaultMinimumObjectSize
        {
            get { return this._transitionDefaultMinimumObjectSize; }
            set { this._transitionDefaultMinimumObjectSize = value; }
        }

        // Check to see if TransitionDefaultMinimumObjectSize property is set
        internal bool IsSetTransitionDefaultMinimumObjectSize()
        {
            return this._transitionDefaultMinimumObjectSize != null;
        }

    }
}