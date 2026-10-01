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

namespace Amazon.CleanRoomsML.Model
{
    /// <summary>
    /// Provides information necessary to perform the protected query.
    /// </summary>
    public partial class ProtectedQueryInputParameters
    {
        /// <summary>
        /// Gets and sets the property ComputeConfiguration. 
        /// <para>
        /// Provides configuration information for the workers that will perform the protected
        /// query.
        /// </para>
        /// </summary>
        public ComputeConfiguration ComputeConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ComputeConfiguration property is set.
        /// </summary>
        internal bool IsSetComputeConfiguration() => this.ComputeConfiguration != null;

        /// <summary>
        /// Gets and sets the property ResultFormat. 
        /// <para>
        /// The format in which the query results should be returned. If not specified, defaults
        /// to <c>CSV</c>. 
        /// </para>
        /// </summary>
        public ResultFormat ResultFormat { get; set; }

        /// <summary>
        /// Checks to see if the ResultFormat property is set.
        /// </summary>
        internal bool IsSetResultFormat() => this.ResultFormat != null;

        /// <summary>
        /// Gets and sets the property SqlParameters.
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true)]
        public ProtectedQuerySQLParameters SqlParameters { get; set; }

        /// <summary>
        /// Checks to see if the SqlParameters property is set.
        /// </summary>
        internal bool IsSetSqlParameters() => this.SqlParameters != null;
    }
}
