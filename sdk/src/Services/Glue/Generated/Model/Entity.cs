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
    /// An entity supported by a given <c>ConnectionType</c>.
    /// </summary>
    public partial class Entity
    {
        private string _category;
        private Dictionary<string, string> _customProperties = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _description;
        private string _entityName;
        private bool? _isParentEntity;
        private string _label;

        /// <summary>
        /// Gets and sets the property Category. 
        /// <para>
        /// The type of entities that are present in the response. This value depends on the source
        /// connection. For example this is <c>SObjects</c> for Salesforce and <c>databases</c>
        /// or <c>schemas</c> or <c>tables</c> for sources like Amazon Redshift.
        /// </para>
        /// </summary>
        public string Category
        {
            get { return this._category; }
            set { this._category = value; }
        }

        // Check to see if Category property is set
        internal bool IsSetCategory()
        {
            return this._category != null;
        }

        /// <summary>
        /// Gets and sets the property CustomProperties. 
        /// <para>
        /// An optional map of keys which may be returned for an entity by a connector.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> CustomProperties
        {
            get { return this._customProperties; }
            set { this._customProperties = value; }
        }

        // Check to see if CustomProperties property is set
        internal bool IsSetCustomProperties()
        {
            return this._customProperties != null && (this._customProperties.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the entity.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property EntityName. 
        /// <para>
        /// The name of the entity.
        /// </para>
        /// </summary>
        public string EntityName
        {
            get { return this._entityName; }
            set { this._entityName = value; }
        }

        // Check to see if EntityName property is set
        internal bool IsSetEntityName()
        {
            return this._entityName != null;
        }

        /// <summary>
        /// Gets and sets the property IsParentEntity. 
        /// <para>
        /// A Boolean value which helps to determine whether there are sub objects that can be
        /// listed.
        /// </para>
        /// </summary>
        public bool? IsParentEntity
        {
            get { return this._isParentEntity; }
            set { this._isParentEntity = value; }
        }

        // Check to see if IsParentEntity property is set
        internal bool IsSetIsParentEntity()
        {
            return this._isParentEntity.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Label. 
        /// <para>
        /// Label used for the entity.
        /// </para>
        /// </summary>
        public string Label
        {
            get { return this._label; }
            set { this._label = value; }
        }

        // Check to see if Label property is set
        internal bool IsSetLabel()
        {
            return this._label != null;
        }

    }
}