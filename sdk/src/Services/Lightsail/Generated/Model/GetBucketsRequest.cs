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
 * Do not modify this file. This file is generated from the lightsail-2016-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Lightsail.Model
{
    /// <summary>
    /// Container for the parameters to the GetBuckets operation.
    /// Returns information about one or more Amazon Lightsail buckets.
    /// 
    ///  
    /// <para>
    /// For more information about buckets, see <a href="https://lightsail.aws.amazon.com/ls/docs/en_us/articles/buckets-in-amazon-lightsail">Buckets
    /// in Amazon Lightsail</a> in the <i>Amazon Lightsail Developer Guide</i>..
    /// </para>
    /// </summary>
    public partial class GetBucketsRequest : AmazonLightsailRequest
    {
        private string _bucketName;
        private bool? _includeConnectedResources;
        private string _pageToken;

        /// <summary>
        /// Gets and sets the property BucketName. 
        /// <para>
        /// The name of the bucket for which to return information.
        /// </para>
        ///  
        /// <para>
        /// When omitted, the response includes all of your buckets in the AWS Region where the
        /// request is made.
        /// </para>
        /// </summary>
        [AWSProperty(Min=3, Max=54)]
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
        /// Gets and sets the property IncludeConnectedResources. 
        /// <para>
        /// A Boolean value that indicates whether to include Lightsail instances that were given
        /// access to the bucket using the <a>SetResourceAccessForBucket</a> action.
        /// </para>
        /// </summary>
        public bool IncludeConnectedResources
        {
            get { return this._includeConnectedResources.GetValueOrDefault(); }
            set { this._includeConnectedResources = value; }
        }

        // Check to see if IncludeConnectedResources property is set
        internal bool IsSetIncludeConnectedResources()
        {
            return this._includeConnectedResources.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PageToken. 
        /// <para>
        /// The token to advance to the next page of results from your request.
        /// </para>
        ///  
        /// <para>
        /// To get a page token, perform an initial <code>GetBuckets</code> request. If your results
        /// are paginated, the response will return a next page token that you can specify as
        /// the page token in a subsequent request.
        /// </para>
        /// </summary>
        public string PageToken
        {
            get { return this._pageToken; }
            set { this._pageToken = value; }
        }

        // Check to see if PageToken property is set
        internal bool IsSetPageToken()
        {
            return this._pageToken != null;
        }

    }
}