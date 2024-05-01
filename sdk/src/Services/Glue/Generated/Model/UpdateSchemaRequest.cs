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
    /// Container for the parameters to the UpdateSchema operation.
    /// Updates the description, compatibility setting, or version checkpoint for a schema
    /// set.
    /// 
    ///  
    /// <para>
    /// For updating the compatibility setting, the call will not validate compatibility for
    /// the entire set of schema versions with the new compatibility setting. If the value
    /// for <c>Compatibility</c> is provided, the <c>VersionNumber</c> (a checkpoint) is also
    /// required. The API will validate the checkpoint version number for consistency.
    /// </para>
    ///  
    /// <para>
    /// If the value for the <c>VersionNumber</c> (checkpoint) is provided, <c>Compatibility</c>
    /// is optional and this can be used to set/reset a checkpoint for the schema.
    /// </para>
    ///  
    /// <para>
    /// This update will happen only if the schema is in the AVAILABLE state.
    /// </para>
    /// </summary>
    public partial class UpdateSchemaRequest : AmazonGlueRequest
    {
        private Compatibility _compatibility;
        private string _description;
        private SchemaId _schemaId;
        private SchemaVersionNumber _schemaVersionNumber;

        /// <summary>
        /// Gets and sets the property Compatibility. 
        /// <para>
        /// The new compatibility setting for the schema.
        /// </para>
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
        /// Gets and sets the property Description. 
        /// <para>
        /// The new description for the schema.
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
        /// Gets and sets the property SchemaVersionNumber. 
        /// <para>
        /// Version number required for check pointing. One of <c>VersionNumber</c> or <c>Compatibility</c>
        /// has to be provided.
        /// </para>
        /// </summary>
        public SchemaVersionNumber SchemaVersionNumber
        {
            get { return this._schemaVersionNumber; }
            set { this._schemaVersionNumber = value; }
        }

        // Check to see if SchemaVersionNumber property is set
        internal bool IsSetSchemaVersionNumber()
        {
            return this._schemaVersionNumber != null;
        }

    }
}