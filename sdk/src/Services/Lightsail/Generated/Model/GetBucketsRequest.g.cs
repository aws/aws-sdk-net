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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.Lightsail.Model
{
    /// <summary>
    /// Container for the parameters to the GetBuckets operation. Returns information about
    /// one or more Amazon Lightsail buckets. The information returned includes the synchronization
    /// status of the Amazon Simple Storage Service (Amazon S3) account-level block public
    /// access feature for your Lightsail buckets. <para> For more information about buckets,
    /// see <a href="https://docs.aws.amazon.com/lightsail/latest/userguide/buckets-in-amazon-lightsail">Buckets
    /// in Amazon Lightsail</a> in the <i>Amazon Lightsail Developer Guide</i>. </para>
    /// </summary>
    public partial class GetBucketsRequest : AmazonLightsailRequest
    {
        /// <summary>
        /// Gets and sets the property BucketName. 
        /// <para>
        /// The name of the bucket for which to return information.
        /// </para>
        ///  
        /// <para>
        /// When omitted, the response includes all of your buckets in the Amazon Web Services
        /// Region where the request is made.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 3, Max = 54)]
        public string BucketName { get; set; }

        /// <summary>
        /// Checks to see if the BucketName property is set.
        /// </summary>
        internal bool IsSetBucketName() => this.BucketName != null;

        /// <summary>
        /// Gets and sets the property IncludeConnectedResources. 
        /// <para>
        /// A Boolean value that indicates whether to include Lightsail instances that were given
        /// access to the bucket using the <a href="https://docs.aws.amazon.com/lightsail/2016-11-28/api-reference/API_SetResourceAccessForBucket.html">SetResourceAccessForBucket</a>
        /// action.
        /// </para>
        /// </summary>
        public bool? IncludeConnectedResources { get; set; }

        /// <summary>
        /// Checks to see if the IncludeConnectedResources property is set.
        /// </summary>
        internal bool IsSetIncludeConnectedResources() => this.IncludeConnectedResources.HasValue;

        /// <summary>
        /// Gets and sets the property IncludeCors. 
        /// <para>
        /// A Boolean value that indicates whether to include Lightsail bucket CORS configuration
        /// in the response. For more information, see <a href="https://docs.aws.amazon.com/lightsail/latest/userguide/configure-cors.html">Configuring
        /// cross-origin resource sharing (CORS)</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// This parameter is only supported when getting a single bucket with <c>bucketName</c>
        /// specified. The default value for this parameter is <c>False</c>.
        /// </para>
        ///  </note>
        /// </summary>
        public bool? IncludeCors { get; set; }

        /// <summary>
        /// Checks to see if the IncludeCors property is set.
        /// </summary>
        internal bool IsSetIncludeCors() => this.IncludeCors.HasValue;

        /// <summary>
        /// Gets and sets the property PageToken. 
        /// <para>
        /// The token to advance to the next page of results from your request.
        /// </para>
        ///  
        /// <para>
        /// To get a page token, perform an initial <c>GetBuckets</c> request. If your results
        /// are paginated, the response will return a next page token that you can specify as
        /// the page token in a subsequent request.
        /// </para>
        /// </summary>
        public string PageToken { get; set; }

        /// <summary>
        /// Checks to see if the PageToken property is set.
        /// </summary>
        internal bool IsSetPageToken() => this.PageToken != null;
    }
}
