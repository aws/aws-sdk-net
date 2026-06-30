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
 * Do not modify this file. This file is generated from the cleanrooms-2022-02-17.normal.json service model.
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
        private ConfiguredTableAssociationSchemaTypeProperties _configuredTableAssociation;
        private IdMappingTableSchemaTypeProperties _idMappingTable;
        private IntermediateTableSchemaTypeProperties _intermediateTable;

        /// <summary>
        /// Gets and sets the property ConfiguredTableAssociation. 
        /// <para>
        /// The schema type properties for a configured table association.
        /// </para>
        /// </summary>
        public ConfiguredTableAssociationSchemaTypeProperties ConfiguredTableAssociation
        {
            get { return this._configuredTableAssociation; }
            set { this._configuredTableAssociation = value; }
        }

        // Check to see if ConfiguredTableAssociation property is set
        internal bool IsSetConfiguredTableAssociation()
        {
            return this._configuredTableAssociation != null;
        }

        /// <summary>
        /// Gets and sets the property IdMappingTable. 
        /// <para>
        /// The ID mapping table for the schema type properties.
        /// </para>
        /// </summary>
        public IdMappingTableSchemaTypeProperties IdMappingTable
        {
            get { return this._idMappingTable; }
            set { this._idMappingTable = value; }
        }

        // Check to see if IdMappingTable property is set
        internal bool IsSetIdMappingTable()
        {
            return this._idMappingTable != null;
        }

        /// <summary>
        /// Gets and sets the property IntermediateTable. 
        /// <para>
        /// The schema type properties for an intermediate table.
        /// </para>
        /// </summary>
        public IntermediateTableSchemaTypeProperties IntermediateTable
        {
            get { return this._intermediateTable; }
            set { this._intermediateTable = value; }
        }

        // Check to see if IntermediateTable property is set
        internal bool IsSetIntermediateTable()
        {
            return this._intermediateTable != null;
        }

    }
}