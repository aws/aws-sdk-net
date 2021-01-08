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
 * Do not modify this file. This file is generated from the athena-2017-05-18.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Athena.Model
{
    /// <summary>
    /// This is the response object from the BatchGetNamedQuery operation.
    /// </summary>
    public partial class BatchGetNamedQueryResponse : AmazonWebServiceResponse
    {
        private List<NamedQuery> _namedQueries = new List<NamedQuery>();
        private List<UnprocessedNamedQueryId> _unprocessedNamedQueryIds = new List<UnprocessedNamedQueryId>();

        /// <summary>
        /// Gets and sets the property NamedQueries. 
        /// <para>
        /// Information about the named query IDs submitted.
        /// </para>
        /// </summary>
        public List<NamedQuery> NamedQueries
        {
            get { return this._namedQueries; }
            set { this._namedQueries = value; }
        }

        // Check to see if NamedQueries property is set
        internal bool IsSetNamedQueries()
        {
            return this._namedQueries != null && this._namedQueries.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property UnprocessedNamedQueryIds. 
        /// <para>
        /// Information about provided query IDs.
        /// </para>
        /// </summary>
        public List<UnprocessedNamedQueryId> UnprocessedNamedQueryIds
        {
            get { return this._unprocessedNamedQueryIds; }
            set { this._unprocessedNamedQueryIds = value; }
        }

        // Check to see if UnprocessedNamedQueryIds property is set
        internal bool IsSetUnprocessedNamedQueryIds()
        {
            return this._unprocessedNamedQueryIds != null && this._unprocessedNamedQueryIds.Count > 0; 
        }

    }
}