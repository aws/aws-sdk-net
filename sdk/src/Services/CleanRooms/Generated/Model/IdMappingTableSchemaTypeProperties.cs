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
    /// Additional properties that are specific to the type of the associated schema.
    /// </summary>
    public partial class IdMappingTableSchemaTypeProperties
    {
        private List<IdMappingTableInputSource> _idMappingTableInputSource = AWSConfigs.InitializeCollections ? new List<IdMappingTableInputSource>() : null;

        /// <summary>
        /// Gets and sets the property IdMappingTableInputSource. 
        /// <para>
        /// Defines which ID namespace associations are used to create the ID mapping table.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=2, Max=2)]
        public List<IdMappingTableInputSource> IdMappingTableInputSource
        {
            get { return this._idMappingTableInputSource; }
            set { this._idMappingTableInputSource = value; }
        }

        // Check to see if IdMappingTableInputSource property is set
        internal bool IsSetIdMappingTableInputSource()
        {
            return this._idMappingTableInputSource != null && (this._idMappingTableInputSource.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}