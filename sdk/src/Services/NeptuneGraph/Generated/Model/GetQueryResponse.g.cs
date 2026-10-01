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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.NeptuneGraph.Model
{
    /// <summary>
    /// This is the response object from the GetQuery operation.
    /// </summary>
    public partial class GetQueryResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property Elapsed. 
        /// <para>
        /// The number of milliseconds the query has been running.
        /// </para>
        /// </summary>
        public int? Elapsed { get; set; }

        /// <summary>
        /// Checks to see if the Elapsed property is set.
        /// </summary>
        internal bool IsSetElapsed() => this.Elapsed.HasValue;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID of the query in question.
        /// </para>
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property QueryString. 
        /// <para>
        /// The query in question.
        /// </para>
        /// </summary>
        public string QueryString { get; set; }

        /// <summary>
        /// Checks to see if the QueryString property is set.
        /// </summary>
        internal bool IsSetQueryString() => this.QueryString != null;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// State of the query.
        /// </para>
        /// </summary>
        public QueryState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;

        /// <summary>
        /// Gets and sets the property Waited. 
        /// <para>
        /// Indicates how long the query waited, in milliseconds.
        /// </para>
        /// </summary>
        public int? Waited { get; set; }

        /// <summary>
        /// Checks to see if the Waited property is set.
        /// </summary>
        internal bool IsSetWaited() => this.Waited.HasValue;
    }
}
