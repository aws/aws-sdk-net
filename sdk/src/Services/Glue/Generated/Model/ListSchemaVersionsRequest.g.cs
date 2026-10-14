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

namespace Amazon.Glue.Model
{
    /// <summary>
    /// Container for the parameters to the ListSchemaVersions operation. Returns a list of
    /// schema versions that you have created, with minimal information. Schema versions in
    /// Deleted status will not be included in the results. Empty results will be returned
    /// if there are no schema versions available.
    /// </summary>
    public partial class ListSchemaVersionsRequest : AmazonGlueRequest
    {
        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// Maximum number of results required per page. If the value is not supplied, this will
        /// be defaulted to 25 per page.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A continuation token, if this is a continuation call.
        /// </para>
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property SchemaId. 
        /// <para>
        /// This is a wrapper structure to contain schema identity fields. The structure contains:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// SchemaId$SchemaArn: The Amazon Resource Name (ARN) of the schema. Either <c>SchemaArn</c>
        /// or <c>SchemaName</c> and <c>RegistryName</c> has to be provided.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// SchemaId$SchemaName: The name of the schema. Either <c>SchemaArn</c> or <c>SchemaName</c>
        /// and <c>RegistryName</c> has to be provided.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true)]
        public SchemaId SchemaId { get; set; }

        /// <summary>
        /// Checks to see if the SchemaId property is set.
        /// </summary>
        internal bool IsSetSchemaId() => this.SchemaId != null;
    }
}
