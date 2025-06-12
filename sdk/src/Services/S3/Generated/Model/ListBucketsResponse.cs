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
    /// This is the response object from the ListBuckets operation.
    /// </summary>
    public partial class ListBucketsResponse : AmazonWebServiceResponse
    {
        private List<S3Bucket> _buckets = AWSConfigs.InitializeCollections ? new List<S3Bucket>() : null;
        private string _continuationToken;
        private Owner _owner;
        private string _prefix;

        /// <summary>
        /// Gets and sets the property Buckets. 
        /// <para>
        /// The list of buckets owned by the requester.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<S3Bucket> Buckets
        {
            get { return this._buckets; }
            set { this._buckets = value; }
        }

        // Check to see if Buckets property is set
        internal bool IsSetBuckets()
        {
            return this._buckets != null && (this._buckets.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ContinuationToken. 
        /// <para>
        ///  <c>ContinuationToken</c> is included in the response when there are more buckets
        /// that can be listed with pagination. The next <c>ListBuckets</c> request to Amazon
        /// S3 can be continued with this <c>ContinuationToken</c>. <c>ContinuationToken</c> is
        /// obfuscated and is not a real bucket.
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
        /// Gets and sets the property Owner. 
        /// <para>
        /// The owner of the buckets listed.
        /// </para>
        /// </summary>
        public Owner Owner
        {
            get { return this._owner; }
            set { this._owner = value; }
        }

        // Check to see if Owner property is set
        internal bool IsSetOwner()
        {
            return this._owner != null;
        }

        /// <summary>
        /// Gets and sets the property Prefix. 
        /// <para>
        /// If <c>Prefix</c> was sent with the request, it is included in the response.
        /// </para>
        ///  
        /// <para>
        /// All bucket names in the response begin with the specified bucket name prefix.
        /// </para>
        /// </summary>
        public string Prefix
        {
            get { return this._prefix; }
            set { this._prefix = value; }
        }

        // Check to see if Prefix property is set
        internal bool IsSetPrefix()
        {
            return this._prefix != null;
        }

    }
}