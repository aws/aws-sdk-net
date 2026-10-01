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

namespace Amazon.AppSync.Model
{
    /// <summary>
    /// Contains the introspected data that was retrieved from the data source.
    /// </summary>
    public partial class DataSourceIntrospectionModel
    {
        /// <summary>
        /// Gets and sets the property Fields. 
        /// <para>
        /// The <c>DataSourceIntrospectionModelField</c> object data.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DataSourceIntrospectionModelField> Fields { get; set; } = AWSConfigs.InitializeCollections ? new List<DataSourceIntrospectionModelField>() : null;

        /// <summary>
        /// Checks to see if the Fields property is set.
        /// </summary>
        internal bool IsSetFields() => this.Fields != null && (this.Fields.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Indexes. 
        /// <para>
        /// The array of <c>DataSourceIntrospectionModelIndex</c> objects.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DataSourceIntrospectionModelIndex> Indexes { get; set; } = AWSConfigs.InitializeCollections ? new List<DataSourceIntrospectionModelIndex>() : null;

        /// <summary>
        /// Checks to see if the Indexes property is set.
        /// </summary>
        internal bool IsSetIndexes() => this.Indexes != null && (this.Indexes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the model. For example, this could be the name of a single table in a
        /// database.
        /// </para>
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property PrimaryKey. 
        /// <para>
        /// The primary key stored as a <c>DataSourceIntrospectionModelIndex</c> object.
        /// </para>
        /// </summary>
        public DataSourceIntrospectionModelIndex PrimaryKey { get; set; }

        /// <summary>
        /// Checks to see if the PrimaryKey property is set.
        /// </summary>
        internal bool IsSetPrimaryKey() => this.PrimaryKey != null;

        /// <summary>
        /// Gets and sets the property Sdl. 
        /// <para>
        /// Contains the output of the SDL that was generated from the introspected types. This
        /// is controlled by the <c>includeModelsSDL</c> parameter of the <c>GetDataSourceIntrospection</c>
        /// operation.
        /// </para>
        /// </summary>
        public string Sdl { get; set; }

        /// <summary>
        /// Checks to see if the Sdl property is set.
        /// </summary>
        internal bool IsSetSdl() => this.Sdl != null;
    }
}
