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
    /// Container for the parameters to the GetSchemaByDefinition operation.
    /// Retrieves a schema by the <c>SchemaDefinition</c>. The schema definition is sent to
    /// the Schema Registry, canonicalized, and hashed. If the hash is matched within the
    /// scope of the <c>SchemaName</c> or ARN (or the default registry, if none is supplied),
    /// that schema’s metadata is returned. Otherwise, a 404 or NotFound error is returned.
    /// Schema versions in <c>Deleted</c> statuses will not be included in the results.
    /// </summary>
    public partial class GetSchemaByDefinitionRequest : AmazonGlueRequest
    {
        private string _schemaDefinition;
        private SchemaId _schemaId;

        /// <summary>
        /// Gets and sets the property SchemaDefinition. 
        /// <para>
        /// The definition of the schema for which schema details are required.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=170000)]
        public string SchemaDefinition
        {
            get { return this._schemaDefinition; }
            set { this._schemaDefinition = value; }
        }

        // Check to see if SchemaDefinition property is set
        internal bool IsSetSchemaDefinition()
        {
            return this._schemaDefinition != null;
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

    }
}