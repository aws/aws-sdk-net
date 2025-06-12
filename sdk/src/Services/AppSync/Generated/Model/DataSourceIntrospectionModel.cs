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
 * Do not modify this file. This file is generated from the appsync-2017-07-25.normal.json service model.
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
namespace Amazon.AppSync.Model
{
    /// <summary>
    /// Contains the introspected data that was retrieved from the data source.
    /// </summary>
    public partial class DataSourceIntrospectionModel
    {
        private List<DataSourceIntrospectionModelField> _fields = AWSConfigs.InitializeCollections ? new List<DataSourceIntrospectionModelField>() : null;
        private List<DataSourceIntrospectionModelIndex> _indexes = AWSConfigs.InitializeCollections ? new List<DataSourceIntrospectionModelIndex>() : null;
        private string _name;
        private DataSourceIntrospectionModelIndex _primaryKey;
        private string _sdl;

        /// <summary>
        /// Gets and sets the property Fields. 
        /// <para>
        /// The <c>DataSourceIntrospectionModelField</c> object data.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DataSourceIntrospectionModelField> Fields
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
        /// Gets and sets the property Indexes. 
        /// <para>
        /// The array of <c>DataSourceIntrospectionModelIndex</c> objects.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DataSourceIntrospectionModelIndex> Indexes
        {
            get { return this._indexes; }
            set { this._indexes = value; }
        }

        // Check to see if Indexes property is set
        internal bool IsSetIndexes()
        {
            return this._indexes != null && (this._indexes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the model. For example, this could be the name of a single table in a
        /// database.
        /// </para>
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property PrimaryKey. 
        /// <para>
        /// The primary key stored as a <c>DataSourceIntrospectionModelIndex</c> object.
        /// </para>
        /// </summary>
        public DataSourceIntrospectionModelIndex PrimaryKey
        {
            get { return this._primaryKey; }
            set { this._primaryKey = value; }
        }

        // Check to see if PrimaryKey property is set
        internal bool IsSetPrimaryKey()
        {
            return this._primaryKey != null;
        }

        /// <summary>
        /// Gets and sets the property Sdl. 
        /// <para>
        /// Contains the output of the SDL that was generated from the introspected types. This
        /// is controlled by the <c>includeModelsSDL</c> parameter of the <c>GetDataSourceIntrospection</c>
        /// operation.
        /// </para>
        /// </summary>
        public string Sdl
        {
            get { return this._sdl; }
            set { this._sdl = value; }
        }

        // Check to see if Sdl property is set
        internal bool IsSetSdl()
        {
            return this._sdl != null;
        }

    }
}