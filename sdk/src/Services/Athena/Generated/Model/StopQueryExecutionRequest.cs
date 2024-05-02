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
    /// Container for the parameters to the StopQueryExecution operation.
    /// Stops a query execution. Requires you to have access to the workgroup in which the
    /// query ran.
    /// </summary>
    public partial class StopQueryExecutionRequest : AmazonAthenaRequest
    {
        private string _queryExecutionId;

        /// <summary>
        /// Gets and sets the property QueryExecutionId. 
        /// <para>
        /// The unique ID of the query execution to stop.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string QueryExecutionId
        {
            get { return this._queryExecutionId; }
            set { this._queryExecutionId = value; }
        }

        // Check to see if QueryExecutionId property is set
        internal bool IsSetQueryExecutionId()
        {
            return this._queryExecutionId != null;
        }

    }
}