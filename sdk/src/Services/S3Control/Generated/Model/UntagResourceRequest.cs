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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.S3Control.Model
{
    /// <summary>
    /// Container for the parameters to the UntagResource operation.
    /// This operation removes the specified user-defined tags from an S3 resource. You can
    /// pass one or more tag keys. 
    /// 
    ///  <note> 
    /// <para>
    /// This operation is only supported for the following Amazon S3 resources:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/access-points-db-tagging.html">Access
    /// Points for directory buckets</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/access-points-tagging.html">Access
    /// Points for general purpose buckets</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/directory-buckets-tagging.html">Directory
    /// buckets</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/storage-lens-groups.html">Storage
    /// Lens groups</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/access-grants-tagging.html">S3
    /// Access Grants instances, registered locations, and grants</a>.
    /// </para>
    ///  </li> </ul> </note> <dl> <dt>Permissions</dt> <dd> 
    /// <para>
    /// For Storage Lens groups and S3 Access Grants, you must have the <c>s3:UntagResource</c>
    /// permission to use this operation. 
    /// </para>
    ///  
    /// <para>
    /// For more information about the required Storage Lens Groups permissions, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/storage_lens_iam_permissions.html#storage_lens_groups_permissions">Setting
    /// account permissions to use S3 Storage Lens groups</a>.
    /// </para>
    ///  </dd> <dt>Directory bucket permissions</dt> <dd> 
    /// <para>
    /// For directory buckets and access points for directory buckets, you must have the <c>s3express:UntagResource</c>
    /// permission to use this operation. For more information about directory buckets policies
    /// and permissions, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/s3-express-permissions.html">Identity
    /// and Access Management (IAM) for S3 Express One Zone</a> in the <i>Amazon S3 User Guide</i>.
    /// </para>
    ///  </dd> <dt>HTTP Host header syntax</dt> <dd> 
    /// <para>
    ///  <b>Directory buckets </b> - The HTTP Host header syntax is <c>s3express-control.<i>region</i>.amazonaws.com</c>.
    /// </para>
    ///  </dd> </dl> 
    /// <para>
    /// For information about S3 Tagging errors, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/ErrorResponses.html#S3TaggingErrorCodeList">List
    /// of Amazon S3 Tagging error codes</a>.
    /// </para>
    ///  <important> 
    /// <para>
    /// You must URL encode any signed header values that contain spaces. For example, if
    /// your header value is <c>my file.txt</c>, containing two spaces after <c>my</c>, you
    /// must URL encode this value to <c>my%20%20file.txt</c>.
    /// </para>
    ///  </important>
    /// </summary>
    public partial class UntagResourceRequest : AmazonS3ControlRequest
    {
        private string _accountId;
        private string _resourceArn;
        private List<string> _tagKeys = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        ///  The Amazon Web Services account ID that owns the resource that you're trying to remove
        /// the tags from. 
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
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the S3 resource that you're removing tags from.
        /// The tagged resource can be a directory bucket, S3 Storage Lens group or S3 Access
        /// Grants instance, registered location, or grant.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=1011)]
        public string ResourceArn
        {
            get { return this._resourceArn; }
            set { this._resourceArn = value; }
        }

        // Check to see if ResourceArn property is set
        internal bool IsSetResourceArn()
        {
            return this._resourceArn != null;
        }

        /// <summary>
        /// Gets and sets the property TagKeys. 
        /// <para>
        ///  The array of tag key-value pairs that you're trying to remove from of the S3 resource.
        /// 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=50)]
        public List<string> TagKeys
        {
            get { return this._tagKeys; }
            set { this._tagKeys = value; }
        }

        // Check to see if TagKeys property is set
        internal bool IsSetTagKeys()
        {
            return this._tagKeys != null && (this._tagKeys.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}