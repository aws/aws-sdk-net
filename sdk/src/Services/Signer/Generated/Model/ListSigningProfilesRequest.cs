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
 * Do not modify this file. This file is generated from the signer-2017-08-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Signer.Model
{
    /// <summary>
    /// Container for the parameters to the ListSigningProfiles operation.
    /// Lists all available signing profiles in your AWS account. Returns only profiles with
    /// an <code>ACTIVE</code> status unless the <code>includeCanceled</code> request field
    /// is set to <code>true</code>. If additional jobs remain to be listed, AWS Signer returns
    /// a <code>nextToken</code> value. Use this value in subsequent calls to <code>ListSigningJobs</code>
    /// to fetch the remaining values. You can continue calling <code>ListSigningJobs</code>
    /// with your <code>maxResults</code> parameter and with new values that AWS Signer returns
    /// in the <code>nextToken</code> parameter until all of your signing jobs have been returned.
    /// </summary>
    public partial class ListSigningProfilesRequest : AmazonSignerRequest
    {
        private bool? _includeCanceled;
        private int? _maxResults;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property IncludeCanceled. 
        /// <para>
        /// Designates whether to include profiles with the status of <code>CANCELED</code>.
        /// </para>
        /// </summary>
        public bool IncludeCanceled
        {
            get { return this._includeCanceled.GetValueOrDefault(); }
            set { this._includeCanceled = value; }
        }

        // Check to see if IncludeCanceled property is set
        internal bool IsSetIncludeCanceled()
        {
            return this._includeCanceled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of profiles to be returned.
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
        /// Gets and sets the property NextToken. 
        /// <para>
        /// Value for specifying the next set of paginated results to return. After you receive
        /// a response with truncated results, use this parameter in a subsequent request. Set
        /// it to the value of <code>nextToken</code> from the response that you just received.
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