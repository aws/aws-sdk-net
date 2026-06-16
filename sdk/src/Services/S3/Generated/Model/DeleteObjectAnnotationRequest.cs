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
    /// Container for the parameters to the DeleteObjectAnnotation operation.
    /// Deletes a specific annotation from an Amazon S3 object. Use the <c>x-amz-object-if-match</c>
    /// header to perform a conditional delete that only succeeds if the object's ETag matches
    /// the provided value, preventing race conditions during concurrent updates.
    /// 
    ///  
    /// <para>
    /// Deleting an annotation is permanent. Annotations are not independently versioned,
    /// so there is no delete marker or way to recover a deleted annotation.
    /// </para>
    ///  
    /// <para>
    /// To use this operation, you must have the <c>s3:DeleteObjectAnnotation</c> permission.
    /// If the object is protected by Object Lock in governance mode, you must also include
    /// the <c>x-amz-bypass-governance-retention</c> header.
    /// </para>
    ///  <note> 
    /// <para>
    /// Annotations are not supported by the following features: S3 Inventory Reports, API
    /// Gateway, S3 Storage Lens, Amazon S3 File Gateway, Amazon FSx, S3 on Outposts, and
    /// S3 Express One Zone (directory buckets).
    /// </para>
    ///  </note> 
    /// <para>
    /// The following operations are related to <c>DeleteObjectAnnotation</c>:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_PutObjectAnnotation.html">PutObjectAnnotation</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_GetObjectAnnotation.html">GetObjectAnnotation</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_ListObjectAnnotations.html">ListObjectAnnotations</a>
    /// 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class DeleteObjectAnnotationRequest : AmazonWebServiceRequest
    {
        private string _annotationName;
        private string _bucketName;
        private string _expectedBucketOwner;
        private string _key;
        private string _objectIfMatch;
        private RequestPayer _requestPayer;
        private string _versionId;

        /// <summary>
        /// Gets and sets the property AnnotationName. 
        /// <para>
        /// The name of the annotation to delete. Annotation names are UTF-8 encoded and cannot
        /// start with <c>aws</c> or <c>s3</c> (case-insensitive).
        /// </para>
        ///  
        /// <para>
        /// Length Constraints: Minimum length of 1. Maximum length of 512 bytes.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string AnnotationName
        {
            get { return this._annotationName; }
            set { this._annotationName = value; }
        }

        // Check to see if AnnotationName property is set
        internal bool IsSetAnnotationName()
        {
            return this._annotationName != null;
        }

        /// <summary>
        /// Gets and sets the property BucketName. 
        /// <para>
        /// The name of the bucket that contains the object.
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
        /// The account ID of the expected bucket owner.
        /// </para>
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
        /// Gets and sets the property Key. 
        /// <para>
        /// The object key.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public string Key
        {
            get { return this._key; }
            set { this._key = value; }
        }

        // Check to see if Key property is set
        internal bool IsSetKey()
        {
            return this._key != null;
        }

        /// <summary>
        /// Gets and sets the property ObjectIfMatch. 
        /// <para>
        /// If specified, the operation only succeeds if the object's ETag matches the provided
        /// value.
        /// </para>
        /// </summary>
        public string ObjectIfMatch
        {
            get { return this._objectIfMatch; }
            set { this._objectIfMatch = value; }
        }

        // Check to see if ObjectIfMatch property is set
        internal bool IsSetObjectIfMatch()
        {
            return this._objectIfMatch != null;
        }

        /// <summary>
        /// Gets and sets the property RequestPayer.
        /// </summary>
        public RequestPayer RequestPayer
        {
            get { return this._requestPayer; }
            set { this._requestPayer = value; }
        }

        // Check to see if RequestPayer property is set
        internal bool IsSetRequestPayer()
        {
            return this._requestPayer != null;
        }

        /// <summary>
        /// Gets and sets the property VersionId. 
        /// <para>
        /// The version ID of the object.
        /// </para>
        /// </summary>
        public string VersionId
        {
            get { return this._versionId; }
            set { this._versionId = value; }
        }

        // Check to see if VersionId property is set
        internal bool IsSetVersionId()
        {
            return this._versionId != null;
        }

    }
}