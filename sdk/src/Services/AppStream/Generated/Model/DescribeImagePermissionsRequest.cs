/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the appstream-2016-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AppStream.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeImagePermissions operation.
    /// Retrieves a list that describes the permissions for shared AWS account IDs on a private
    /// image that you own.
    /// </summary>
    public partial class DescribeImagePermissionsRequest : AmazonAppStreamRequest
    {
        private int? _maxResults;
        private string _name;
        private string _nextToken;
        private List<string> _sharedAwsAccountIds = new List<string>();

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum size of each page of results.
        /// </para>
        /// </summary>
        public int MaxResults
        {
            get { return this._maxResults.GetValueOrDefault(); }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the private image for which to describe permissions. The image must be
        /// one that you own. 
        /// </para>
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The pagination token to use to retrieve the next page of results for this operation.
        /// If this value is null, it retrieves the first page.
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

        /// <summary>
        /// Gets and sets the property SharedAwsAccountIds. 
        /// <para>
        /// The 12-digit identifier of one or more AWS accounts with which the image is shared.
        /// </para>
        /// </summary>
        public List<string> SharedAwsAccountIds
        {
            get { return this._sharedAwsAccountIds; }
            set { this._sharedAwsAccountIds = value; }
        }

        // Check to see if SharedAwsAccountIds property is set
        internal bool IsSetSharedAwsAccountIds()
        {
            return this._sharedAwsAccountIds != null && this._sharedAwsAccountIds.Count > 0; 
        }

    }
}