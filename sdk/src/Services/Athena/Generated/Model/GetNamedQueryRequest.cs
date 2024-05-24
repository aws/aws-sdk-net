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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.Athena.Model
{
    /// <summary>
    /// Container for the parameters to the GetNamedQuery operation.
    /// Returns information about a single query. Requires that you have access to the workgroup
    /// in which the query was saved.
    /// </summary>
    public partial class GetNamedQueryRequest : AmazonAthenaRequest
    {
        private string _namedQueryId;

        /// <summary>
        /// Gets and sets the property NamedQueryId. 
        /// <para>
        /// The unique ID of the query. Use <a>ListNamedQueries</a> to get query IDs.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string NamedQueryId
        {
            get { return this._namedQueryId; }
            set { this._namedQueryId = value; }
        }

        // Check to see if NamedQueryId property is set
        internal bool IsSetNamedQueryId()
        {
            return this._namedQueryId != null;
        }

    }
}