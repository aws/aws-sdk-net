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
 * Do not modify this file. This file is generated from the iot-managed-integrations-2025-03-03.normal.json service model.
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
namespace Amazon.IoTManagedIntegrations.Model
{
    /// <summary>
    /// List item describing a schema version.
    /// </summary>
    public partial class SchemaVersionListItem
    {
        private string _description;
        private string _awsNamespace;
        private string _schemaId;
        private string _semanticVersion;
        private SchemaVersionType _type;
        private SchemaVersionVisibility _visibility;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the schema version.
        /// </para>
        /// </summary>
        [AWSProperty(Min=10, Max=2048)]
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
        /// Gets and sets the property Namespace. 
        /// <para>
        /// The name of the schema version.
        /// </para>
        /// </summary>
        [AWSProperty(Min=3, Max=12)]
        public string Namespace
        {
            get { return this._awsNamespace; }
            set { this._awsNamespace = value; }
        }

        // Check to see if Namespace property is set
        internal bool IsSetNamespace()
        {
            return this._awsNamespace != null;
        }

        /// <summary>
        /// Gets and sets the property SchemaId. 
        /// <para>
        /// The identifier of the schema version.
        /// </para>
        /// </summary>
        [AWSProperty(Min=3, Max=128)]
        public string SchemaId
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
        /// Gets and sets the property SemanticVersion. 
        /// <para>
        /// The schema version. If this is left blank, it defaults to the latest version.
        /// </para>
        /// </summary>
        [AWSProperty(Min=3, Max=12)]
        public string SemanticVersion
        {
            get { return this._semanticVersion; }
            set { this._semanticVersion = value; }
        }

        // Check to see if SemanticVersion property is set
        internal bool IsSetSemanticVersion()
        {
            return this._semanticVersion != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of schema version.
        /// </para>
        /// </summary>
        public SchemaVersionType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

        /// <summary>
        /// Gets and sets the property Visibility. 
        /// <para>
        /// The visibility of the schema version.
        /// </para>
        /// </summary>
        public SchemaVersionVisibility Visibility
        {
            get { return this._visibility; }
            set { this._visibility = value; }
        }

        // Check to see if Visibility property is set
        internal bool IsSetVisibility()
        {
            return this._visibility != null;
        }

    }
}