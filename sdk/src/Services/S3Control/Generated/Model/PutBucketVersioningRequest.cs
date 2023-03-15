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
 * Do not modify this file. This file is generated from the s3control-2018-08-20.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.S3Control.Model
{
    /// <summary>
    /// Container for the parameters to the PutBucketVersioning operation.
    /// <note> 
    /// <para>
    /// This operation sets the versioning state for S3 on Outposts buckets only. To set the
    /// versioning state for an S3 bucket, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_PutBucketVersioning.html">PutBucketVersioning</a>
    /// in the <i>Amazon S3 API Reference</i>. 
    /// </para>
    ///  </note> 
    /// <para>
    /// Sets the versioning state for an S3 on Outposts bucket. With S3 Versioning, you can
    /// save multiple distinct copies of your objects and recover from unintended user actions
    /// and application failures.
    /// </para>
    ///  
    /// <para>
    /// You can set the versioning state to one of the following:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <b>Enabled</b> - Enables versioning for the objects in the bucket. All objects added
    /// to the bucket receive a unique version ID.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Suspended</b> - Suspends versioning for the objects in the bucket. All objects
    /// added to the bucket receive the version ID <code>null</code>.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// If you've never set versioning on your bucket, it has no versioning state. In that
    /// case, a <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_GetBucketVersioning.html">
    /// GetBucketVersioning</a> request does not return a versioning state value.
    /// </para>
    ///  
    /// <para>
    /// When you enable S3 Versioning, for each object in your bucket, you have a current
    /// version and zero or more noncurrent versions. You can configure your bucket S3 Lifecycle
    /// rules to expire noncurrent versions after a specified time period. For more information,
    /// see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/S3OutpostsLifecycleManaging.html">
    /// Creating and managing a lifecycle configuration for your S3 on Outposts bucket</a>
    /// in the <i>Amazon S3 User Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// If you have an object expiration lifecycle configuration in your non-versioned bucket
    /// and you want to maintain the same permanent delete behavior when you enable versioning,
    /// you must add a noncurrent expiration policy. The noncurrent expiration lifecycle configuration
    /// will manage the deletes of the noncurrent object versions in the version-enabled bucket.
    /// For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/Versioning.html">Versioning</a>
    /// in the <i>Amazon S3 User Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// All Amazon S3 on Outposts REST API requests for this action require an additional
    /// parameter of <code>x-amz-outpost-id</code> to be passed with the request. In addition,
    /// you must use an S3 on Outposts endpoint hostname prefix instead of <code>s3-control</code>.
    /// For an example of the request syntax for Amazon S3 on Outposts that uses the S3 on
    /// Outposts endpoint hostname prefix and the <code>x-amz-outpost-id</code> derived by
    /// using the access point ARN, see the <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_PutBucketVersioning.html#API_control_PutBucketVersioning_Examples">Examples</a>
    /// section.
    /// </para>
    ///  
    /// <para>
    /// The following operations are related to <code>PutBucketVersioning</code> for S3 on
    /// Outposts.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_GetBucketVersioning.html">GetBucketVersioning</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_PutBucketLifecycleConfiguration.html">PutBucketLifecycleConfiguration</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_GetBucketLifecycleConfiguration.html">GetBucketLifecycleConfiguration</a>
    /// 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class PutBucketVersioningRequest : AmazonS3ControlRequest
    {
        private string _accountId;
        private string _bucket;
        private string _mfa;
        private VersioningConfiguration _versioningConfiguration;

        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The Amazon Web Services account ID of the S3 on Outposts bucket.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=64)]
        public string AccountId
        {
            get { return this._accountId; }
            set { this._accountId = value; }
        }

        // Check to see if AccountId property is set
        internal bool IsSetAccountId()
        {
            return this._accountId != null;
        }

        /// <summary>
        /// Gets and sets the property Bucket. 
        /// <para>
        /// The S3 on Outposts bucket to set the versioning state for.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=3, Max=255)]
        public string Bucket
        {
            get { return this._bucket; }
            set { this._bucket = value; }
        }

        // Check to see if Bucket property is set
        internal bool IsSetBucket()
        {
            return this._bucket != null;
        }

        /// <summary>
        /// Gets and sets the property MFA. 
        /// <para>
        /// The concatenation of the authentication device's serial number, a space, and the value
        /// that is displayed on your authentication device.
        /// </para>
        /// </summary>
        public string MFA
        {
            get { return this._mfa; }
            set { this._mfa = value; }
        }

        // Check to see if MFA property is set
        internal bool IsSetMFA()
        {
            return this._mfa != null;
        }

        /// <summary>
        /// Gets and sets the property VersioningConfiguration. 
        /// <para>
        /// The root-level tag for the <code>VersioningConfiguration</code> parameters.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public VersioningConfiguration VersioningConfiguration
        {
            get { return this._versioningConfiguration; }
            set { this._versioningConfiguration = value; }
        }

        // Check to see if VersioningConfiguration property is set
        internal bool IsSetVersioningConfiguration()
        {
            return this._versioningConfiguration != null;
        }

    }
}