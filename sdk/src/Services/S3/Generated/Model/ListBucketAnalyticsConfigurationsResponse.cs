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
    /// This is the response object from the ListBucketAnalyticsConfigurations operation.
    /// </summary>
    public partial class ListBucketAnalyticsConfigurationsResponse : AmazonWebServiceResponse
    {
        private List<AnalyticsConfiguration> _analyticsConfigurationList = AWSConfigs.InitializeCollections ? new List<AnalyticsConfiguration>() : null;
        private string _continuationToken;
        private bool? _isTruncated;
        private string _nextContinuationToken;

        /// <summary>
        /// Gets and sets the property AnalyticsConfigurationList. 
        /// <para>
        /// The list of analytics configurations for a bucket.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AnalyticsConfiguration> AnalyticsConfigurationList
        {
            get { return this._analyticsConfigurationList; }
            set { this._analyticsConfigurationList = value; }
        }

        // Check to see if AnalyticsConfigurationList property is set
        internal bool IsSetAnalyticsConfigurationList()
        {
            return this._analyticsConfigurationList != null && (this._analyticsConfigurationList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ContinuationToken. 
        /// <para>
        /// The marker that is used as a starting point for this analytics configuration list
        /// response. This value is present if it was sent in the request.
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
        /// Gets and sets the property IsTruncated. 
        /// <para>
        /// Indicates whether the returned list of analytics configurations is complete. A value
        /// of true indicates that the list is not complete and the NextContinuationToken will
        /// be provided for a subsequent request.
        /// </para>
        /// </summary>
        public bool? IsTruncated
        {
            get { return this._isTruncated; }
            set { this._isTruncated = value; }
        }

        // Check to see if IsTruncated property is set
        internal bool IsSetIsTruncated()
        {
            return this._isTruncated.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextContinuationToken. 
        /// <para>
        ///  <c>NextContinuationToken</c> is sent when <c>isTruncated</c> is true, which indicates
        /// that there are more analytics configurations to list. The next request must include
        /// this <c>NextContinuationToken</c>. The token is obfuscated and is not a usable value.
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

    }
}