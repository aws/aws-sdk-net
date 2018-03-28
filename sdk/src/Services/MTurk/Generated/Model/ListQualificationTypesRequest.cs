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
 * Do not modify this file. This file is generated from the mturk-requester-2017-01-17.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MTurk.Model
{
    /// <summary>
    /// Container for the parameters to the ListQualificationTypes operation.
    /// The <code>ListQualificationTypes</code> operation returns a list of Qualification
    /// types, filtered by an optional search term.
    /// </summary>
    public partial class ListQualificationTypesRequest : AmazonMTurkRequest
    {
        private int? _maxResults;
        private bool? _mustBeOwnedByCaller;
        private bool? _mustBeRequestable;
        private string _nextToken;
        private string _query;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        ///  The maximum number of results to return in a single call. 
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
        /// Gets and sets the property MustBeOwnedByCaller. 
        /// <para>
        ///  Specifies that only Qualification types that the Requester created are returned.
        /// If false, the operation returns all Qualification types. 
        /// </para>
        /// </summary>
        public bool MustBeOwnedByCaller
        {
            get { return this._mustBeOwnedByCaller.GetValueOrDefault(); }
            set { this._mustBeOwnedByCaller = value; }
        }

        // Check to see if MustBeOwnedByCaller property is set
        internal bool IsSetMustBeOwnedByCaller()
        {
            return this._mustBeOwnedByCaller.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MustBeRequestable. 
        /// <para>
        /// Specifies that only Qualification types that a user can request through the Amazon
        /// Mechanical Turk web site, such as by taking a Qualification test, are returned as
        /// results of the search. Some Qualification types, such as those assigned automatically
        /// by the system, cannot be requested directly by users. If false, all Qualification
        /// types, including those managed by the system, are considered. Valid values are True
        /// | False. 
        /// </para>
        /// </summary>
        public bool MustBeRequestable
        {
            get { return this._mustBeRequestable.GetValueOrDefault(); }
            set { this._mustBeRequestable = value; }
        }

        // Check to see if MustBeRequestable property is set
        internal bool IsSetMustBeRequestable()
        {
            return this._mustBeRequestable.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken.
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
        /// Gets and sets the property Query. 
        /// <para>
        ///  A text query against all of the searchable attributes of Qualification types. 
        /// </para>
        /// </summary>
        public string Query
        {
            get { return this._query; }
            set { this._query = value; }
        }

        // Check to see if Query property is set
        internal bool IsSetQuery()
        {
            return this._query != null;
        }

    }
}