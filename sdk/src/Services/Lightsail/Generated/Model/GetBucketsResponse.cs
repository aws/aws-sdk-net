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
    /// This is the response object from the GetBuckets operation.
    /// </summary>
    public partial class GetBucketsResponse : AmazonWebServiceResponse
    {
        private AccountLevelBpaSync _accountLevelBpaSync;
        private List<Bucket> _buckets = new List<Bucket>();
        private string _nextPageToken;

        /// <summary>
        /// Gets and sets the property AccountLevelBpaSync. 
        /// <para>
        /// An object that describes the synchronization status of the Amazon S3 account-level
        /// block public access feature for your Lightsail buckets.
        /// </para>
        ///  
        /// <para>
        /// For more information about this feature and how it affects Lightsail buckets, see
        /// <a href="https://lightsail.aws.amazon.com/ls/docs/en_us/articles/amazon-lightsail-block-public-access-for-buckets">Block
        /// public access for buckets in Amazon Lightsail</a>.
        /// </para>
        /// </summary>
        public AccountLevelBpaSync AccountLevelBpaSync
        {
            get { return this._accountLevelBpaSync; }
            set { this._accountLevelBpaSync = value; }
        }

        // Check to see if AccountLevelBpaSync property is set
        internal bool IsSetAccountLevelBpaSync()
        {
            return this._accountLevelBpaSync != null;
        }

        /// <summary>
        /// Gets and sets the property Buckets. 
        /// <para>
        /// An array of objects that describe buckets.
        /// </para>
        /// </summary>
        public List<Bucket> Buckets
        {
            get { return this._buckets; }
            set { this._buckets = value; }
        }

        // Check to see if Buckets property is set
        internal bool IsSetBuckets()
        {
            return this._buckets != null && this._buckets.Count > 0; 
        }

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
        /// To get the next page of results, perform another <code>GetBuckets</code> request and
        /// specify the next page token using the <code>pageToken</code> parameter.
        /// </para>
        /// </summary>
        public string NextPageToken
        {
            get { return this._nextPageToken; }
            set { this._nextPageToken = value; }
        }

        // Check to see if NextPageToken property is set
        internal bool IsSetNextPageToken()
        {
            return this._nextPageToken != null;
        }

    }
}