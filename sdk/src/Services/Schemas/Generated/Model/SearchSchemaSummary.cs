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
 * Do not modify this file. This file is generated from the schemas-2019-12-02.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Schemas.Model
{
    /// <summary>
    /// 
    /// </summary>
    public partial class SearchSchemaSummary
    {
        private string _registryName;
        private string _schemaArn;
        private string _schemaName;
        private List<SearchSchemaVersionSummary> _schemaVersions = new List<SearchSchemaVersionSummary>();

        /// <summary>
        /// Gets and sets the property RegistryName. 
        /// <para>
        /// The name of the registry.
        /// </para>
        /// </summary>
        public string RegistryName
        {
            get { return this._registryName; }
            set { this._registryName = value; }
        }

        // Check to see if RegistryName property is set
        internal bool IsSetRegistryName()
        {
            return this._registryName != null;
        }

        /// <summary>
        /// Gets and sets the property SchemaArn. 
        /// <para>
        /// The ARN of the schema.
        /// </para>
        /// </summary>
        public string SchemaArn
        {
            get { return this._schemaArn; }
            set { this._schemaArn = value; }
        }

        // Check to see if SchemaArn property is set
        internal bool IsSetSchemaArn()
        {
            return this._schemaArn != null;
        }

        /// <summary>
        /// Gets and sets the property SchemaName. 
        /// <para>
        /// The name of the schema.
        /// </para>
        /// </summary>
        public string SchemaName
        {
            get { return this._schemaName; }
            set { this._schemaName = value; }
        }

        // Check to see if SchemaName property is set
        internal bool IsSetSchemaName()
        {
            return this._schemaName != null;
        }

        /// <summary>
        /// Gets and sets the property SchemaVersions. 
        /// <para>
        /// An array of schema version summaries.
        /// </para>
        /// </summary>
        public List<SearchSchemaVersionSummary> SchemaVersions
        {
            get { return this._schemaVersions; }
            set { this._schemaVersions = value; }
        }

        // Check to see if SchemaVersions property is set
        internal bool IsSetSchemaVersions()
        {
            return this._schemaVersions != null && this._schemaVersions.Count > 0; 
        }

    }
}