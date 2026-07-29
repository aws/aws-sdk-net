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
    /// Container for the parameters to the ListObjectAnnotations operation.
    /// Lists the annotations attached to an Amazon S3 object. Results are paginated, with
    /// a maximum of 1,000 annotations per object. Use the <c>AnnotationPrefix</c> parameter
    /// to filter the results by name prefix.
    /// 
    ///  
    /// <para>
    /// To use this operation, you must have the <c>s3:ListObjectAnnotations</c> permission.
    /// </para>
    ///  <note> 
    /// <para>
    /// Annotations are not supported by the following features: S3 Inventory Reports, API
    /// Gateway, S3 Storage Lens, Amazon S3 File Gateway, Amazon FSx, S3 on Outposts, and
    /// S3 Express One Zone (directory buckets).
    /// </para>
    ///  </note> 
    /// <para>
    /// The following operations are related to <c>ListObjectAnnotations</c>:
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
    ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_DeleteObjectAnnotation.html">DeleteObjectAnnotation</a>
    /// 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class ListObjectAnnotationsRequest : AmazonWebServiceRequest
    {
        private string _annotationPrefix;
        private string _bucketName;
        private string _continuationToken;
        private string _expectedBucketOwner;
        private string _key;
        private int? _maxAnnotationResults;
        private RequestPayer _requestPayer;
        private string _versionId;

        /// <summary>
        /// Gets and sets the property AnnotationPrefix. 
        /// <para>
        /// Filter results to annotations whose name begins with the specified prefix.
        /// </para>
        /// </summary>
        public string AnnotationPrefix
        {
            get { return this._annotationPrefix; }
            set { this._annotationPrefix = value; }
        }

        // Check to see if AnnotationPrefix property is set
        internal bool IsSetAnnotationPrefix()
        {
            return this._annotationPrefix != null;
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
        /// Gets and sets the property ContinuationToken. 
        /// <para>
        /// Continuation token returned by a previous request to retrieve the next page.
        /// </para>
        /// </summary>
        public string ContinuationToken
        {
            get { return this._continuationToken; }
            set { this._continuationToken = value; }
        }

        // Check to see if ContinuationToken property is set
        internal bool IsSetContinuationToken()
        {
            return this._continuationToken != null;
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
        /// Gets and sets the property MaxAnnotationResults. 
        /// <para>
        /// The maximum number of annotations to return in the response. Maximum is 1,000.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
        public int? MaxAnnotationResults
        {
            get { return this._maxAnnotationResults; }
            set { this._maxAnnotationResults = value; }
        }

        // Check to see if MaxAnnotationResults property is set
        internal bool IsSetMaxAnnotationResults()
        {
            return this._maxAnnotationResults.HasValue; 
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