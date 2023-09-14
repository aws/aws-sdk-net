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
 * Do not modify this file. This file is generated from the entityresolution-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EntityResolution.Model
{
    /// <summary>
    /// Container for the parameters to the CreateSchemaMapping operation.
    /// Creates a schema mapping, which defines the schema of the input customer records table.
    /// The <code>SchemaMapping</code> also provides Entity Resolution with some metadata
    /// about the table, such as the attribute types of the columns and which columns to match
    /// on.
    /// </summary>
    public partial class CreateSchemaMappingRequest : AmazonEntityResolutionRequest
    {
        private string _description;
        private List<SchemaInputAttribute> _mappedInputFields = new List<SchemaInputAttribute>();
        private string _schemaName;
        private Dictionary<string, string> _tags = new Dictionary<string, string>();

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the schema.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=255)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property MappedInputFields. 
        /// <para>
        /// A list of <code>MappedInputFields</code>. Each <code>MappedInputField</code> corresponds
        /// to a column the source data table, and contains column name plus additional information
        /// that Entity Resolution uses for matching.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=2, Max=25)]
        public List<SchemaInputAttribute> MappedInputFields
        {
            get { return this._mappedInputFields; }
            set { this._mappedInputFields = value; }
        }

        // Check to see if MappedInputFields property is set
        internal bool IsSetMappedInputFields()
        {
            return this._mappedInputFields != null && this._mappedInputFields.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SchemaName. 
        /// <para>
        /// The name of the schema. There cannot be multiple <code>SchemaMappings</code> with
        /// the same name.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=255)]
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags used to organize, track, or control access for this resource.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=200)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}