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

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// The query execution identifier and the result output location for the Amazon Athena
    /// query that an Athena step runs.
    /// </summary>
    public partial class AthenaStepMetadata
    {
        /// <summary>
        /// Gets and sets the property QueryExecutionId. 
        /// <para>
        /// The unique identifier of the Amazon Athena query execution that was run by this step
        /// execution.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string QueryExecutionId { get; set; }

        /// <summary>
        /// Checks to see if the QueryExecutionId property is set.
        /// </summary>
        internal bool IsSetQueryExecutionId() => this.QueryExecutionId != null;

        /// <summary>
        /// Gets and sets the property S3OutputLocation. 
        /// <para>
        /// The Amazon S3 location of the Amazon Athena query results. This is the effective output
        /// location reported by <c>GetQueryExecution</c> for the query. This value can be absent
        /// when the query uses Athena managed query results.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string S3OutputLocation { get; set; }

        /// <summary>
        /// Checks to see if the S3OutputLocation property is set.
        /// </summary>
        internal bool IsSetS3OutputLocation() => this.S3OutputLocation != null;
    }
}
