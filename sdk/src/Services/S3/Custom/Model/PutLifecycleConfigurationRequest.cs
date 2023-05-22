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
    /// Container for the parameters to the PutLifecycleConfiguration operation.
    /// Creates a new lifecycle configuration for the bucket or replaces an existing lifecycle
    /// configuration. For information about lifecycle configuration, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/object-lifecycle-mgmt.html">Managing
    /// your storage lifecycle</a>.
    /// 
    ///  <note> 
    /// <para>
    /// Bucket lifecycle configuration now supports specifying a lifecycle rule using an object
    /// key name prefix, one or more object tags, or a combination of both. Accordingly, this
    /// section describes the latest API. The previous version of the API supported filtering
    /// based only on an object key name prefix, which is supported for backward compatibility.
    /// For the related API description, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_PutBucketLifecycle.html">PutBucketLifecycle</a>.
    /// </para>
    ///  </note> <dl> <dt>Rules</dt> <dd>  
    /// <para>
    /// You specify the lifecycle configuration in your request body. The lifecycle configuration
    /// is specified as XML consisting of one or more rules. An Amazon S3 Lifecycle configuration
    /// can have up to 1,000 rules. This limit is not adjustable. Each rule consists of the
    /// following:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Filter identifying a subset of objects to which the rule applies. The filter can be
    /// based on a key name prefix, object tags, or a combination of both.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Status whether the rule is in effect.
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
    ///  </dd> <dt>Permissions</dt> <dd> 
    /// <para>
    /// By default, all Amazon S3 resources are private, including buckets, objects, and related
    /// subresources (for example, lifecycle configuration and website configuration). Only
    /// the resource owner (that is, the Amazon Web Services account that created it) can
    /// access the resource. The resource owner can optionally grant access permissions to
    /// others by writing an access policy. For this operation, a user must get the s3:PutLifecycleConfiguration
    /// permission.
    /// </para>
    ///  
    /// <para>
    /// You can also explicitly deny permissions. Explicit deny also supersedes any other
    /// permissions. If you want to block users or accounts from removing or deleting objects
    /// from your bucket, you must deny them permissions for the following actions:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// s3:DeleteObject
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// s3:DeleteObjectVersion
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// s3:PutLifecycleConfiguration
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// For more information about permissions, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/s3-access-control.html">Managing
    /// Access Permissions to Your Amazon S3 Resources</a>.
    /// </para>
    ///  </dd> </dl> 
    /// <para>
    /// The following operations are related to <code>PutBucketLifecycleConfiguration</code>:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/lifecycle-configuration-examples.html">Examples
    /// of Lifecycle Configuration</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_GetBucketLifecycleConfiguration.html">GetBucketLifecycleConfiguration</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_DeleteBucketLifecycle.html">DeleteBucketLifecycle</a>
    /// 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class PutLifecycleConfigurationRequest : AmazonWebServiceRequest
    {
        private string bucketName;
        private ChecksumAlgorithm _checksumAlgorithm;
        private LifecycleConfiguration lifecycleConfiguration;
        private string expectedBucketOwner;

        /// <summary>
        /// Gets and sets the property BucketName. 
        /// <para>
        /// The name of the bucket for which to set the configuration.
        /// </para>
        /// </summary>
        public string BucketName
        {
            get { return this.bucketName; }
            set { this.bucketName = value; }
        }

        // Check to see if BucketName property is set
        internal bool IsSetBucketName()
        {
            return this.bucketName != null;
        }

        /// <summary>
        /// Gets and sets the property ChecksumAlgorithm.
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
        /// The lifecycle configuration to be applied.
        /// </summary>
        public LifecycleConfiguration Configuration
        {
            get { return this.lifecycleConfiguration; }
            set { this.lifecycleConfiguration = value; }
        }

        // Check to see if Configuration property is set
        internal bool IsSetConfiguration()
        {
            return this.lifecycleConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property ExpectedBucketOwner. 
        /// <para>
        /// The account ID of the expected bucket owner. If the bucket is owned by a different
        /// account, the request will fail with an HTTP <code>403 (Access Denied)</code> error.
        /// </para>
        /// </summary>
        public string ExpectedBucketOwner
        {
            get { return this.expectedBucketOwner; }
            set { this.expectedBucketOwner = value; }
        }

        // Check to see if ExpectedBucketOwner property is set
        internal bool IsSetExpectedBucketOwner()
        {
            return !String.IsNullOrEmpty(this.expectedBucketOwner);
        }

    }
}
    
