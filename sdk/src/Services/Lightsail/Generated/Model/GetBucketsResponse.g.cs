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
    /// This is the response object from the GetBuckets operation.
    /// </summary>
    public partial class GetBucketsResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property AccountLevelBpaSync. 
        /// <para>
        /// An object that describes the synchronization status of the Amazon S3 account-level
        /// block public access feature for your Lightsail buckets.
        /// </para>
        ///  
        /// <para>
        /// For more information about this feature and how it affects Lightsail buckets, see
        /// <a href="https://docs.aws.amazon.com/lightsail/latest/userguide/amazon-lightsail-block-public-access-for-buckets">Block
        /// public access for buckets in Amazon Lightsail</a>.
        /// </para>
        /// </summary>
        public AccountLevelBpaSync AccountLevelBpaSync { get; set; }

        /// <summary>
        /// Checks to see if the AccountLevelBpaSync property is set.
        /// </summary>
        internal bool IsSetAccountLevelBpaSync() => this.AccountLevelBpaSync != null;

        /// <summary>
        /// Gets and sets the property Buckets. 
        /// <para>
        /// An array of objects that describe buckets.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Bucket> Buckets { get; set; } = AWSConfigs.InitializeCollections ? new List<Bucket>() : null;

        /// <summary>
        /// Checks to see if the Buckets property is set.
        /// </summary>
        internal bool IsSetBuckets() => this.Buckets != null && (this.Buckets.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property NextPageToken. 
        /// <para>
        /// The token to advance to the next page of results from your request.
        /// </para>
        ///  
        /// <para>
        /// A next page token is not returned if there are no more results to display.
        /// </para>
        ///  
        /// <para>
        /// To get the next page of results, perform another <c>GetBuckets</c> request and specify
        /// the next page token using the <c>pageToken</c> parameter.
        /// </para>
        /// </summary>
        public string NextPageToken { get; set; }

        /// <summary>
        /// Checks to see if the NextPageToken property is set.
        /// </summary>
        internal bool IsSetNextPageToken() => this.NextPageToken != null;
    }
}
