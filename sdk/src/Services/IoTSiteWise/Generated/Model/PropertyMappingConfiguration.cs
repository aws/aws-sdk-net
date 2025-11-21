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
 * Do not modify this file. This file is generated from the iotsitewise-2019-12-02.normal.json service model.
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
namespace Amazon.IoTSiteWise.Model
{
    /// <summary>
    /// Contains configuration options for mapping properties from an interface asset model
    /// to an asset model where the interface is applied.
    /// </summary>
    public partial class PropertyMappingConfiguration
    {
        private bool? _createMissingProperty;
        private bool? _matchByPropertyName;
        private List<PropertyMapping> _overrides = AWSConfigs.InitializeCollections ? new List<PropertyMapping>() : null;

        /// <summary>
        /// Gets and sets the property CreateMissingProperty. 
        /// <para>
        /// If true, missing properties from the interface asset model are automatically created
        /// in the asset model where the interface is applied.
        /// </para>
        /// </summary>
        public bool? CreateMissingProperty
        {
            get { return this._createMissingProperty; }
            set { this._createMissingProperty = value; }
        }

        // Check to see if CreateMissingProperty property is set
        internal bool IsSetCreateMissingProperty()
        {
            return this._createMissingProperty.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MatchByPropertyName. 
        /// <para>
        /// If true, properties are matched by name between the interface asset model and the
        /// asset model where the interface is applied.
        /// </para>
        /// </summary>
        public bool? MatchByPropertyName
        {
            get { return this._matchByPropertyName; }
            set { this._matchByPropertyName = value; }
        }

        // Check to see if MatchByPropertyName property is set
        internal bool IsSetMatchByPropertyName()
        {
            return this._matchByPropertyName.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Overrides. 
        /// <para>
        /// A list of specific property mappings that override the automatic mapping by name when
        /// an interface is applied to an asset model.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<PropertyMapping> Overrides
        {
            get { return this._overrides; }
            set { this._overrides = value; }
        }

        // Check to see if Overrides property is set
        internal bool IsSetOverrides()
        {
            return this._overrides != null && (this._overrides.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}