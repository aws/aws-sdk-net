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

namespace Amazon.CleanRooms.Model
{
    /// <summary>
    /// Information about the schema type properties.
    /// </summary>
    public partial class SchemaTypeProperties
    {
        /// <summary>
        /// Gets and sets the property ConfiguredTableAssociation. 
        /// <para>
        /// The schema type properties for a configured table association.
        /// </para>
        /// </summary>
        public ConfiguredTableAssociationSchemaTypeProperties ConfiguredTableAssociation { get; set; }

        /// <summary>
        /// Checks to see if the ConfiguredTableAssociation property is set.
        /// </summary>
        internal bool IsSetConfiguredTableAssociation() => this.ConfiguredTableAssociation != null;

        /// <summary>
        /// Gets and sets the property IdMappingTable. 
        /// <para>
        /// The ID mapping table for the schema type properties.
        /// </para>
        /// </summary>
        public IdMappingTableSchemaTypeProperties IdMappingTable { get; set; }

        /// <summary>
        /// Checks to see if the IdMappingTable property is set.
        /// </summary>
        internal bool IsSetIdMappingTable() => this.IdMappingTable != null;

        /// <summary>
        /// Gets and sets the property IntermediateTable. 
        /// <para>
        /// The schema type properties for an intermediate table.
        /// </para>
        /// </summary>
        public IntermediateTableSchemaTypeProperties IntermediateTable { get; set; }

        /// <summary>
        /// Checks to see if the IntermediateTable property is set.
        /// </summary>
        internal bool IsSetIntermediateTable() => this.IntermediateTable != null;
    }
}
