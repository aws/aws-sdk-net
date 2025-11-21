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
 * Do not modify this file. This file is generated from the s3control-2018-08-20.normal.json service model.
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
namespace Amazon.S3Control.Model
{
    /// <summary>
    /// Container for the parameters to the ListAccessGrantsLocations operation.
    /// Returns a list of the locations registered in your S3 Access Grants instance.
    /// 
    ///  <dl> <dt>Permissions</dt> <dd> 
    /// <para>
    /// You must have the <c>s3:ListAccessGrantsLocations</c> permission to use this operation.
    /// 
    /// </para>
    ///  </dd> </dl> <important> 
    /// <para>
    /// You must URL encode any signed header values that contain spaces. For example, if
    /// your header value is <c>my file.txt</c>, containing two spaces after <c>my</c>, you
    /// must URL encode this value to <c>my%20%20file.txt</c>.
    /// </para>
    ///  </important>
    /// </summary>
    public partial class ListAccessGrantsLocationsRequest : AmazonS3ControlRequest
    {
        private string _accountId;
        private string _locationScope;
        private int? _maxResults;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The Amazon Web Services account ID of the S3 Access Grants instance.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=64)]
        public string AccountId
        {
            get { return this._accountId; }
            set { this._accountId = value; }
        }

        // Check to see if AccountId property is set
        internal bool IsSetAccountId()
        {
            return this._accountId != null;
        }

        /// <summary>
        /// Gets and sets the property LocationScope. 
        /// <para>
        /// The S3 path to the location that you are registering. The location scope can be the
        /// default S3 location <c>s3://</c>, the S3 path to a bucket <c>s3://&lt;bucket&gt;</c>,
        /// or the S3 path to a bucket and prefix <c>s3://&lt;bucket&gt;/&lt;prefix&gt;</c>. A
        /// prefix in S3 is a string of characters at the beginning of an object key name used
        /// to organize the objects that you store in your S3 buckets. For example, object key
        /// names that start with the <c>engineering/</c> prefix or object key names that start
        /// with the <c>marketing/campaigns/</c> prefix.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2000)]
        public string LocationScope
        {
            get { return this._locationScope; }
            set { this._locationScope = value; }
        }

        // Check to see if LocationScope property is set
        internal bool IsSetLocationScope()
        {
            return this._locationScope != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of access grants that you would like returned in the <c>List Access
        /// Grants</c> response. If the results include the pagination token <c>NextToken</c>,
        /// make another call using the <c>NextToken</c> to determine if there are more results.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1000)]
        public int? MaxResults
        {
            get { return this._maxResults; }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A pagination token to request the next page of results. Pass this value into a subsequent
        /// <c>List Access Grants Locations</c> request in order to retrieve the next page of
        /// results.
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
            return this._nextToken != null;
        }

    }
}