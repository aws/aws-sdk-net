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
 * Do not modify this file. This file is generated from the ds-2015-04-16.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DirectoryService.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeTrusts operation.
    /// Obtains information about the trust relationships for this account.
    /// 
    ///  
    /// <para>
    /// If no input parameters are provided, such as DirectoryId or TrustIds, this request
    /// describes all the trust relationships belonging to the account.
    /// </para>
    /// </summary>
    public partial class DescribeTrustsRequest : AmazonDirectoryServiceRequest
    {
        private string _directoryId;
        private int? _limit;
        private string _nextToken;
        private List<string> _trustIds = new List<string>();

        /// <summary>
        /// Gets and sets the property DirectoryId. 
        /// <para>
        /// The Directory ID of the AWS directory that is a part of the requested trust relationship.
        /// </para>
        /// </summary>
        public string DirectoryId
        {
            get { return this._directoryId; }
            set { this._directoryId = value; }
        }

        // Check to see if DirectoryId property is set
        internal bool IsSetDirectoryId()
        {
            return this._directoryId != null;
        }

        /// <summary>
        /// Gets and sets the property Limit. 
        /// <para>
        /// The maximum number of objects to return.
        /// </para>
        /// </summary>
        public int Limit
        {
            get { return this._limit.GetValueOrDefault(); }
            set { this._limit = value; }
        }

        // Check to see if Limit property is set
        internal bool IsSetLimit()
        {
            return this._limit.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The <i>DescribeTrustsResult.NextToken</i> value from a previous call to <a>DescribeTrusts</a>.
        /// Pass null if this is the first call.
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
        /// Gets and sets the property TrustIds. 
        /// <para>
        /// A list of identifiers of the trust relationships for which to obtain the information.
        /// If this member is null, all trust relationships that belong to the current account
        /// are returned.
        /// </para>
        ///  
        /// <para>
        /// An empty list results in an <code>InvalidParameterException</code> being thrown.
        /// </para>
        /// </summary>
        public List<string> TrustIds
        {
            get { return this._trustIds; }
            set { this._trustIds = value; }
        }

        // Check to see if TrustIds property is set
        internal bool IsSetTrustIds()
        {
            return this._trustIds != null && this._trustIds.Count > 0; 
        }

    }
}