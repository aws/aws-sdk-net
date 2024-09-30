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
    /// Container for the parameters to the ListCallerAccessGrants operation.
    /// Returns a list of the access grants that were given to the caller using S3 Access
    /// Grants and that allow the caller to access the S3 data of the Amazon Web Services
    /// account specified in the request.
    /// 
    ///  <dl> <dt>Permissions</dt> <dd> 
    /// <para>
    /// You must have the <c>s3:ListCallerAccessGrants</c> permission to use this operation.
    /// 
    /// </para>
    ///  </dd> </dl>
    /// </summary>
    public partial class ListCallerAccessGrantsRequest : AmazonS3ControlRequest
    {
        private string _accountId;
        private bool? _allowedByApplication;
        private string _grantScope;
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
            return !string.IsNullOrEmpty(this._accountId);
        }

        /// <summary>
        /// Gets and sets the property AllowedByApplication. 
        /// <para>
        /// If this optional parameter is passed in the request, a filter is applied to the results.
        /// The results will include only the access grants for the caller's Identity Center application
        /// or for any other applications (<c>ALL</c>).
        /// </para>
        /// </summary>
        public bool? AllowedByApplication
        {
            get { return this._allowedByApplication; }
            set { this._allowedByApplication = value; }
        }

        // Check to see if AllowedByApplication property is set
        internal bool IsSetAllowedByApplication()
        {
            return this._allowedByApplication.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property GrantScope. 
        /// <para>
        /// The S3 path of the data that you would like to access. Must start with <c>s3://</c>.
        /// You can optionally pass only the beginning characters of a path, and S3 Access Grants
        /// will search for all applicable grants for the path fragment. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2000)]
        public string GrantScope
        {
            get { return this._grantScope; }
            set { this._grantScope = value; }
        }

        // Check to see if GrantScope property is set
        internal bool IsSetGrantScope()
        {
            return this._grantScope != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of access grants that you would like returned in the <c>List Caller
        /// Access Grants</c> response. If the results include the pagination token <c>NextToken</c>,
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
        /// <c>List Caller Access Grants</c> request in order to retrieve the next page of results.
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