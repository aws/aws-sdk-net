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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
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
    /// Container for the parameters to the GetSchemaVersionsDiff operation.
    /// Fetches the schema version difference in the specified difference type between two
    /// stored schema versions in the Schema Registry.
    /// 
    ///  
    /// <para>
    /// This API allows you to compare two schema versions between two schema definitions
    /// under the same schema.
    /// </para>
    /// </summary>
    public partial class GetSchemaVersionsDiffRequest : AmazonGlueRequest
    {
        private SchemaVersionNumber _firstSchemaVersionNumber;
        private SchemaDiffType _schemaDiffType;
        private SchemaId _schemaId;
        private SchemaVersionNumber _secondSchemaVersionNumber;

        /// <summary>
        /// Gets and sets the property FirstSchemaVersionNumber. 
        /// <para>
        /// The first of the two schema versions to be compared.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public SchemaVersionNumber FirstSchemaVersionNumber
        {
            get { return this._firstSchemaVersionNumber; }
            set { this._firstSchemaVersionNumber = value; }
        }

        // Check to see if FirstSchemaVersionNumber property is set
        internal bool IsSetFirstSchemaVersionNumber()
        {
            return this._firstSchemaVersionNumber != null;
        }

        /// <summary>
        /// Gets and sets the property SchemaDiffType. 
        /// <para>
        /// Refers to <c>SYNTAX_DIFF</c>, which is the currently supported diff type.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public SchemaDiffType SchemaDiffType
        {
            get { return this._schemaDiffType; }
            set { this._schemaDiffType = value; }
        }

        // Check to see if SchemaDiffType property is set
        internal bool IsSetSchemaDiffType()
        {
            return this._schemaDiffType != null;
        }

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
        [AWSProperty(Required=true)]
        public SchemaId SchemaId
        {
            get { return this._schemaId; }
            set { this._schemaId = value; }
        }

        // Check to see if SchemaId property is set
        internal bool IsSetSchemaId()
        {
            return this._schemaId != null;
        }

        /// <summary>
        /// Gets and sets the property SecondSchemaVersionNumber. 
        /// <para>
        /// The second of the two schema versions to be compared.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public SchemaVersionNumber SecondSchemaVersionNumber
        {
            get { return this._secondSchemaVersionNumber; }
            set { this._secondSchemaVersionNumber = value; }
        }

        // Check to see if SecondSchemaVersionNumber property is set
        internal bool IsSetSecondSchemaVersionNumber()
        {
            return this._secondSchemaVersionNumber != null;
        }

    }
}