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
    /// This is the response object from the ListObjectAnnotations operation.
    /// </summary>
    public partial class ListObjectAnnotationsResponse : AmazonWebServiceResponse
    {
        private int? _annotationCount;
        private string _annotationPrefix;
        private List<AnnotationEntry> _annotations = AWSConfigs.InitializeCollections ? new List<AnnotationEntry>() : null;
        private string _bucketName;
        private string _continuationToken;
        private string _key;
        private int? _maxAnnotationResults;
        private string _nextContinuationToken;
        private string _objectVersionId;
        private RequestCharged _requestCharged;

        /// <summary>
        /// Gets and sets the property AnnotationCount. 
        /// <para>
        /// The number of annotations returned.
        /// </para>
        /// </summary>
        public int? AnnotationCount
        {
            get { return this._annotationCount; }
            set { this._annotationCount = value; }
        }

        // Check to see if AnnotationCount property is set
        internal bool IsSetAnnotationCount()
        {
            return this._annotationCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AnnotationPrefix. 
        /// <para>
        /// The prefix used to filter the response.
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
        /// Gets and sets the property Annotations. 
        /// <para>
        /// The list of annotations attached to the object.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AnnotationEntry> Annotations
        {
            get { return this._annotations; }
            set { this._annotations = value; }
        }

        // Check to see if Annotations property is set
        internal bool IsSetAnnotations()
        {
            return this._annotations != null && (this._annotations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property BucketName. 
        /// <para>
        /// The bucket name.
        /// </para>
        /// </summary>
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
        /// The continuation token used in this request.
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
        /// Gets and sets the property Key. 
        /// <para>
        /// The object key.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
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
        /// The maximum number of annotations returned in the response.
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
        /// Gets and sets the property NextContinuationToken. 
        /// <para>
        /// The continuation token to use to retrieve the next page of results.
        /// </para>
        /// </summary>
        public string NextContinuationToken
        {
            get { return this._nextContinuationToken; }
            set { this._nextContinuationToken = value; }
        }

        // Check to see if NextContinuationToken property is set
        internal bool IsSetNextContinuationToken()
        {
            return this._nextContinuationToken != null;
        }

        /// <summary>
        /// Gets and sets the property ObjectVersionId. 
        /// <para>
        /// The version ID of the object.
        /// </para>
        /// </summary>
        public string ObjectVersionId
        {
            get { return this._objectVersionId; }
            set { this._objectVersionId = value; }
        }

        // Check to see if ObjectVersionId property is set
        internal bool IsSetObjectVersionId()
        {
            return this._objectVersionId != null;
        }

        /// <summary>
        /// Gets and sets the property RequestCharged.
        /// </summary>
        public RequestCharged RequestCharged
        {
            get { return this._requestCharged; }
            set { this._requestCharged = value; }
        }

        // Check to see if RequestCharged property is set
        internal bool IsSetRequestCharged()
        {
            return this._requestCharged != null;
        }

    }
}