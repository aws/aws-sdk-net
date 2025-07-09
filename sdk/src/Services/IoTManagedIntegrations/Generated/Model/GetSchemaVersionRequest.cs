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
    /// Container for the parameters to the GetSchemaVersion operation.
    /// Gets a schema version with the provided information.
    /// </summary>
    public partial class GetSchemaVersionRequest : AmazonIoTManagedIntegrationsRequest
    {
        private SchemaVersionFormat _format;
        private string _schemaVersionedId;
        private SchemaVersionType _type;

        /// <summary>
        /// Gets and sets the property Format. 
        /// <para>
        /// The format of the schema version.
        /// </para>
        /// </summary>
        public SchemaVersionFormat Format
        {
            get { return this._format; }
            set { this._format = value; }
        }

        // Check to see if Format property is set
        internal bool IsSetFormat()
        {
            return this._format != null;
        }

        /// <summary>
        /// Gets and sets the property SchemaVersionedId. 
        /// <para>
        /// Schema id with a version specified. If the version is missing, it defaults to latest
        /// version.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=7, Max=128)]
        public string SchemaVersionedId
        {
            get { return this._schemaVersionedId; }
            set { this._schemaVersionedId = value; }
        }

        // Check to see if SchemaVersionedId property is set
        internal bool IsSetSchemaVersionedId()
        {
            return this._schemaVersionedId != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of schema version.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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

    }
}