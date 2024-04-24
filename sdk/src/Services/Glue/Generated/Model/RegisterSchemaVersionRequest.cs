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
    /// Container for the parameters to the RegisterSchemaVersion operation.
    /// Adds a new version to the existing schema. Returns an error if new version of schema
    /// does not meet the compatibility requirements of the schema set. This API will not
    /// create a new schema set and will return a 404 error if the schema set is not already
    /// present in the Schema Registry.
    /// 
    ///  
    /// <para>
    /// If this is the first schema definition to be registered in the Schema Registry, this
    /// API will store the schema version and return immediately. Otherwise, this call has
    /// the potential to run longer than other operations due to compatibility modes. You
    /// can call the <c>GetSchemaVersion</c> API with the <c>SchemaVersionId</c> to check
    /// compatibility modes.
    /// </para>
    ///  
    /// <para>
    /// If the same schema definition is already stored in Schema Registry as a version, the
    /// schema ID of the existing schema is returned to the caller.
    /// </para>
    /// </summary>
    public partial class RegisterSchemaVersionRequest : AmazonGlueRequest
    {
        private string _schemaDefinition;
        private SchemaId _schemaId;

        /// <summary>
        /// Gets and sets the property SchemaDefinition. 
        /// <para>
        /// The schema definition using the <c>DataFormat</c> setting for the <c>SchemaName</c>.
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