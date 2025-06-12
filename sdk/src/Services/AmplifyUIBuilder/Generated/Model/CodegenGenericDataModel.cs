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
 * Do not modify this file. This file is generated from the amplifyuibuilder-2021-08-11.normal.json service model.
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
namespace Amazon.AmplifyUIBuilder.Model
{
    /// <summary>
    /// Describes a model in a generic data schema.
    /// </summary>
    public partial class CodegenGenericDataModel
    {
        private Dictionary<string, CodegenGenericDataField> _fields = AWSConfigs.InitializeCollections ? new Dictionary<string, CodegenGenericDataField>() : null;
        private bool? _isJoinTable;
        private List<string> _primaryKeys = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property Fields. 
        /// <para>
        /// The fields in the generic data model.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public Dictionary<string, CodegenGenericDataField> Fields
        {
            get { return this._fields; }
            set { this._fields = value; }
        }

        // Check to see if Fields property is set
        internal bool IsSetFields()
        {
            return this._fields != null && (this._fields.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property IsJoinTable. 
        /// <para>
        /// Specifies whether the generic data model is a join table.
        /// </para>
        /// </summary>
        public bool? IsJoinTable
        {
            get { return this._isJoinTable; }
            set { this._isJoinTable = value; }
        }

        // Check to see if IsJoinTable property is set
        internal bool IsSetIsJoinTable()
        {
            return this._isJoinTable.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PrimaryKeys. 
        /// <para>
        /// The primary keys of the generic data model.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> PrimaryKeys
        {
            get { return this._primaryKeys; }
            set { this._primaryKeys = value; }
        }

        // Check to see if PrimaryKeys property is set
        internal bool IsSetPrimaryKeys()
        {
            return this._primaryKeys != null && (this._primaryKeys.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}