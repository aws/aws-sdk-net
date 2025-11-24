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
    /// This is the response object from the ListBucketMetricsConfigurations operation.
    /// </summary>
    public partial class ListBucketMetricsConfigurationsResponse : AmazonWebServiceResponse
    {
        private bool? _isTruncated;
        private List<MetricsConfiguration> _metricsConfigurationList = AWSConfigs.InitializeCollections ? new List<MetricsConfiguration>() : null;
        private string _nextToken;
        private string _token;

        /// <summary>
        /// Gets and sets the property IsTruncated. 
        /// <para>
        /// Indicates whether the returned list of metrics configurations is complete. A value
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
        /// Gets and sets the property MetricsConfigurationList. 
        /// <para>
        /// The list of metrics configurations for a bucket.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<MetricsConfiguration> MetricsConfigurationList
        {
            get { return this._metricsConfigurationList; }
            set { this._metricsConfigurationList = value; }
        }

        // Check to see if MetricsConfigurationList property is set
        internal bool IsSetMetricsConfigurationList()
        {
            return this._metricsConfigurationList != null && (this._metricsConfigurationList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The marker used to continue a metrics configuration listing that has been truncated.
        /// Use the <c>NextContinuationToken</c> from a previously truncated list response to
        /// continue the listing. The continuation token is an opaque value that Amazon S3 understands.
        /// </para>
        /// </summary>
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return !string.IsNullOrEmpty(this._nextToken);
        }

        /// <summary>
        /// Gets and sets the property Token. 
        /// <para>
        /// The marker that is used as a starting point for this metrics configuration list response.
        /// This value is present if it was sent in the request.
        /// </para>
        /// </summary>
        public string Token
        {
            get { return this._token; }
            set { this._token = value; }
        }

        // Check to see if Token property is set
        internal bool IsSetToken()
        {
            return !string.IsNullOrEmpty(this._token);
        }

    }
}