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

namespace Amazon.IoTManagedIntegrations.Model
{
    /// <summary>
    /// List item describing a schema version.
    /// </summary>
    public partial class SchemaVersionListItem
    {
        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the schema version.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 10, Max = 2048)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property Namespace. 
        /// <para>
        /// The name of the schema version.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 3, Max = 12)]
        public string Namespace { get; set; }

        /// <summary>
        /// Checks to see if the Namespace property is set.
        /// </summary>
        internal bool IsSetNamespace() => this.Namespace != null;

        /// <summary>
        /// Gets and sets the property SchemaId. 
        /// <para>
        /// The identifier of the schema version.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 3, Max = 128)]
        public string SchemaId { get; set; }

        /// <summary>
        /// Checks to see if the SchemaId property is set.
        /// </summary>
        internal bool IsSetSchemaId() => this.SchemaId != null;

        /// <summary>
        /// Gets and sets the property SemanticVersion. 
        /// <para>
        /// The schema version. If this is left blank, it defaults to the latest version.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 3, Max = 12)]
        public string SemanticVersion { get; set; }

        /// <summary>
        /// Checks to see if the SemanticVersion property is set.
        /// </summary>
        internal bool IsSetSemanticVersion() => this.SemanticVersion != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of schema version.
        /// </para>
        /// </summary>
        public SchemaVersionType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;

        /// <summary>
        /// Gets and sets the property Visibility. 
        /// <para>
        /// The visibility of the schema version.
        /// </para>
        /// </summary>
        public SchemaVersionVisibility Visibility { get; set; }

        /// <summary>
        /// Checks to see if the Visibility property is set.
        /// </summary>
        internal bool IsSetVisibility() => this.Visibility != null;
    }
}
