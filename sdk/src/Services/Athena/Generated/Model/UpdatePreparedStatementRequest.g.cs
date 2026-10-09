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

namespace Amazon.Athena.Model
{
    /// <summary>
    /// Container for the parameters to the UpdatePreparedStatement operation. Updates a prepared
    /// statement.
    /// </summary>
    public partial class UpdatePreparedStatementRequest : AmazonAthenaRequest
    {
        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the prepared statement.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property QueryStatement. 
        /// <para>
        /// The query string for the prepared statement.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 262144)]
        public string QueryStatement { get; set; }

        /// <summary>
        /// Checks to see if the QueryStatement property is set.
        /// </summary>
        internal bool IsSetQueryStatement() => this.QueryStatement != null;

        /// <summary>
        /// Gets and sets the property StatementName. 
        /// <para>
        /// The name of the prepared statement.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string StatementName { get; set; }

        /// <summary>
        /// Checks to see if the StatementName property is set.
        /// </summary>
        internal bool IsSetStatementName() => this.StatementName != null;

        /// <summary>
        /// Gets and sets the property WorkGroup. 
        /// <para>
        /// The workgroup for the prepared statement.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string WorkGroup { get; set; }

        /// <summary>
        /// Checks to see if the WorkGroup property is set.
        /// </summary>
        internal bool IsSetWorkGroup() => this.WorkGroup != null;
    }
}
