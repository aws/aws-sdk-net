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
 * Do not modify this file. This file is generated from the neptunedata-2023-08-01.normal.json service model.
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
namespace Amazon.Neptunedata.Model
{
    /// <summary>
    /// This is the response object from the ExecuteGremlinQuery operation.
    /// </summary>
    public partial class ExecuteGremlinQueryResponse : AmazonWebServiceResponse
    {
        private Amazon.Runtime.Documents.Document _meta;
        private string _requestId;
        private Amazon.Runtime.Documents.Document _result;
        private GremlinQueryStatusAttributes _status;

        /// <summary>
        /// Gets and sets the property Meta. 
        /// <para>
        /// Metadata about the Gremlin query.
        /// </para>
        /// </summary>
        public Amazon.Runtime.Documents.Document Meta
        {
            get { return this._meta; }
            set { this._meta = value; }
        }

        // Check to see if Meta property is set
        internal bool IsSetMeta()
        {
            return !this._meta.IsNull();
        }

        /// <summary>
        /// Gets and sets the property RequestId. 
        /// <para>
        /// The unique identifier of the Gremlin query.
        /// </para>
        /// </summary>
        public string RequestId
        {
            get { return this._requestId; }
            set { this._requestId = value; }
        }

        // Check to see if RequestId property is set
        internal bool IsSetRequestId()
        {
            return this._requestId != null;
        }

        /// <summary>
        /// Gets and sets the property Result. 
        /// <para>
        /// The Gremlin query output from the server.
        /// </para>
        /// </summary>
        public Amazon.Runtime.Documents.Document Result
        {
            get { return this._result; }
            set { this._result = value; }
        }

        // Check to see if Result property is set
        internal bool IsSetResult()
        {
            return !this._result.IsNull();
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the Gremlin query.
        /// </para>
        /// </summary>
        public GremlinQueryStatusAttributes Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}