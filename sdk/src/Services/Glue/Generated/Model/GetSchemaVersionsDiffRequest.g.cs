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
    /// Container for the parameters to the GetSchemaVersionsDiff operation. Fetches the schema
    /// version difference in the specified difference type between two stored schema versions
    /// in the Schema Registry. <para> This API allows you to compare two schema versions
    /// between two schema definitions under the same schema. </para>
    /// </summary>
    public partial class GetSchemaVersionsDiffRequest : AmazonGlueRequest
    {
        /// <summary>
        /// Gets and sets the property FirstSchemaVersionNumber. 
        /// <para>
        /// The first of the two schema versions to be compared.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public SchemaVersionNumber FirstSchemaVersionNumber { get; set; }

        /// <summary>
        /// Checks to see if the FirstSchemaVersionNumber property is set.
        /// </summary>
        internal bool IsSetFirstSchemaVersionNumber() => this.FirstSchemaVersionNumber != null;

        /// <summary>
        /// Gets and sets the property SchemaDiffType. 
        /// <para>
        /// Refers to <c>SYNTAX_DIFF</c>, which is the currently supported diff type.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public SchemaDiffType SchemaDiffType { get; set; }

        /// <summary>
        /// Checks to see if the SchemaDiffType property is set.
        /// </summary>
        internal bool IsSetSchemaDiffType() => this.SchemaDiffType != null;

        /// <summary>
        /// Gets and sets the property SchemaId. 
        /// <para>
        /// This is a wrapper structure to contain schema identity fields. The structure contains:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// SchemaId$SchemaArn: The Amazon Resource Name (ARN) of the schema. One of <c>SchemaArn</c>
        /// or <c>SchemaName</c> has to be provided.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// SchemaId$SchemaName: The name of the schema. One of <c>SchemaArn</c> or <c>SchemaName</c>
        /// has to be provided.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true)]
        public SchemaId SchemaId { get; set; }

        /// <summary>
        /// Checks to see if the SchemaId property is set.
        /// </summary>
        internal bool IsSetSchemaId() => this.SchemaId != null;

        /// <summary>
        /// Gets and sets the property SecondSchemaVersionNumber. 
        /// <para>
        /// The second of the two schema versions to be compared.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public SchemaVersionNumber SecondSchemaVersionNumber { get; set; }

        /// <summary>
        /// Checks to see if the SecondSchemaVersionNumber property is set.
        /// </summary>
        internal bool IsSetSecondSchemaVersionNumber() => this.SecondSchemaVersionNumber != null;
    }
}
