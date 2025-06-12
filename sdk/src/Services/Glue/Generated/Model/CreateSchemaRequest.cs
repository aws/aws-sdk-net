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
    /// Container for the parameters to the CreateSchema operation.
    /// Creates a new schema set and registers the schema definition. Returns an error if
    /// the schema set already exists without actually registering the version.
    /// 
    ///  
    /// <para>
    /// When the schema set is created, a version checkpoint will be set to the first version.
    /// Compatibility mode "DISABLED" restricts any additional schema versions from being
    /// added after the first schema version. For all other compatibility modes, validation
    /// of compatibility settings will be applied only from the second version onwards when
    /// the <c>RegisterSchemaVersion</c> API is used.
    /// </para>
    ///  
    /// <para>
    /// When this API is called without a <c>RegistryId</c>, this will create an entry for
    /// a "default-registry" in the registry database tables, if it is not already present.
    /// </para>
    /// </summary>
    public partial class CreateSchemaRequest : AmazonGlueRequest
    {
        private Compatibility _compatibility;
        private DataFormat _dataFormat;
        private string _description;
        private RegistryId _registryId;
        private string _schemaDefinition;
        private string _schemaName;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property Compatibility. 
        /// <para>
        /// The compatibility mode of the schema. The possible values are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <i>NONE</i>: No compatibility mode applies. You can use this choice in development
        /// scenarios or if you do not know the compatibility mode that you want to apply to schemas.
        /// Any new version added will be accepted without undergoing a compatibility check.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>DISABLED</i>: This compatibility choice prevents versioning for a particular schema.
        /// You can use this choice to prevent future versioning of a schema.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>BACKWARD</i>: This compatibility choice is recommended as it allows data receivers
        /// to read both the current and one previous schema version. This means that for instance,
        /// a new schema version cannot drop data fields or change the type of these fields, so
        /// they can't be read by readers using the previous version.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>BACKWARD_ALL</i>: This compatibility choice allows data receivers to read both
        /// the current and all previous schema versions. You can use this choice when you need
        /// to delete fields or add optional fields, and check compatibility against all previous
        /// schema versions. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>FORWARD</i>: This compatibility choice allows data receivers to read both the
        /// current and one next schema version, but not necessarily later versions. You can use
        /// this choice when you need to add fields or delete optional fields, but only check
        /// compatibility against the last schema version.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>FORWARD_ALL</i>: This compatibility choice allows data receivers to read written
        /// by producers of any new registered schema. You can use this choice when you need to
        /// add fields or delete optional fields, and check compatibility against all previous
        /// schema versions.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>FULL</i>: This compatibility choice allows data receivers to read data written
        /// by producers using the previous or next version of the schema, but not necessarily
        /// earlier or later versions. You can use this choice when you need to add or remove
        /// optional fields, but only check compatibility against the last schema version.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>FULL_ALL</i>: This compatibility choice allows data receivers to read data written
        /// by producers using all previous schema versions. You can use this choice when you
        /// need to add or remove optional fields, and check compatibility against all previous
        /// schema versions.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public Compatibility Compatibility
        {
            get { return this._compatibility; }
            set { this._compatibility = value; }
        }

        // Check to see if Compatibility property is set
        internal bool IsSetCompatibility()
        {
            return this._compatibility != null;
        }

        /// <summary>
        /// Gets and sets the property DataFormat. 
        /// <para>
        /// The data format of the schema definition. Currently <c>AVRO</c>, <c>JSON</c> and <c>PROTOBUF</c>
        /// are supported.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DataFormat DataFormat
        {
            get { return this._dataFormat; }
            set { this._dataFormat = value; }
        }

        // Check to see if DataFormat property is set
        internal bool IsSetDataFormat()
        {
            return this._dataFormat != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// An optional description of the schema. If description is not provided, there will
        /// not be any automatic default value for this.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2048)]
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
        /// Gets and sets the property RegistryId. 
        /// <para>
        ///  This is a wrapper shape to contain the registry identity fields. If this is not provided,
        /// the default registry will be used. The ARN format for the same will be: <c>arn:aws:glue:us-east-2:&lt;customer
        /// id&gt;:registry/default-registry:random-5-letter-id</c>.
        /// </para>
        /// </summary>
        public RegistryId RegistryId
        {
            get { return this._registryId; }
            set { this._registryId = value; }
        }

        // Check to see if RegistryId property is set
        internal bool IsSetRegistryId()
        {
            return this._registryId != null;
        }

        /// <summary>
        /// Gets and sets the property SchemaDefinition. 
        /// <para>
        /// The schema definition using the <c>DataFormat</c> setting for <c>SchemaName</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=170000)]
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
        /// Gets and sets the property SchemaName. 
        /// <para>
        /// Name of the schema to be created of max length of 255, and may only contain letters,
        /// numbers, hyphen, underscore, dollar sign, or hash mark. No whitespace.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
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
        /// Amazon Web Services tags that contain a key value pair and may be searched by console,
        /// command line, or API. If specified, follows the Amazon Web Services tags-on-create
        /// pattern.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}