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
 * Do not modify this file. This file is generated from the datazone-2018-05-10.normal.json service model.
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
namespace Amazon.DataZone.Model
{
    /// <summary>
    /// The relational filter configuration for the data source.
    /// </summary>
    public partial class RelationalFilterConfiguration
    {
        private string _databaseName;
        private List<FilterExpression> _filterExpressions = AWSConfigs.InitializeCollections ? new List<FilterExpression>() : null;
        private string _schemaName;

        /// <summary>
        /// Gets and sets the property DatabaseName. 
        /// <para>
        /// The database name specified in the relational filter configuration for the data source.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string DatabaseName
        {
            get { return this._databaseName; }
            set { this._databaseName = value; }
        }

        // Check to see if DatabaseName property is set
        internal bool IsSetDatabaseName()
        {
            return this._databaseName != null;
        }

        /// <summary>
        /// Gets and sets the property FilterExpressions. 
        /// <para>
        /// The filter expressions specified in the relational filter configuration for the data
        /// source.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<FilterExpression> FilterExpressions
        {
            get { return this._filterExpressions; }
            set { this._filterExpressions = value; }
        }

        // Check to see if FilterExpressions property is set
        internal bool IsSetFilterExpressions()
        {
            return this._filterExpressions != null && (this._filterExpressions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SchemaName. 
        /// <para>
        /// The schema name specified in the relational filter configuration for the data source.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string SchemaName
        {
            get { return this._schemaName; }
            set { this._schemaName = value; }
        }

        // Check to see if SchemaName property is set
        internal bool IsSetSchemaName()
        {
            return this._schemaName != null;
        }

    }
}