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
 * Do not modify this file. This file is generated from the bcm-data-exports-2023-11-26.normal.json service model.
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
namespace Amazon.BCMDataExports.Model
{
    /// <summary>
    /// Container for the parameters to the CreateExport operation.
    /// Creates a data export and specifies the data query, the delivery preference, and any
    /// optional resource tags.
    /// 
    ///  
    /// <para>
    /// A <c>DataQuery</c> consists of both a <c>QueryStatement</c> and <c>TableConfigurations</c>.
    /// </para>
    ///  
    /// <para>
    /// The <c>QueryStatement</c> is an SQL statement. Data Exports only supports a limited
    /// subset of the SQL syntax. For more information on the SQL syntax that is supported,
    /// see <a href="https://docs.aws.amazon.com/cur/latest/userguide/de-data-query.html">Data
    /// query</a>. To view the available tables and columns, see the <a href="https://docs.aws.amazon.com/cur/latest/userguide/de-table-dictionary.html">Data
    /// Exports table dictionary</a>.
    /// </para>
    ///  
    /// <para>
    /// The <c>TableConfigurations</c> is a collection of specified <c>TableProperties</c>
    /// for the table being queried in the <c>QueryStatement</c>. TableProperties are additional
    /// configurations you can provide to change the data and schema of a table. Each table
    /// can have different TableProperties. However, tables are not required to have any TableProperties.
    /// Each table property has a default value that it assumes if not specified. For more
    /// information on table configurations, see <a href="https://docs.aws.amazon.com/cur/latest/userguide/de-data-query.html">Data
    /// query</a>. To view the table properties available for each table, see the <a href="https://docs.aws.amazon.com/cur/latest/userguide/de-table-dictionary.html">Data
    /// Exports table dictionary</a> or use the <c>ListTables</c> API to get a response of
    /// all tables and their available properties.
    /// </para>
    /// </summary>
    public partial class CreateExportRequest : AmazonBCMDataExportsRequest
    {
        private Export _export;
        private List<ResourceTag> _resourceTags = AWSConfigs.InitializeCollections ? new List<ResourceTag>() : null;

        /// <summary>
        /// Gets and sets the property Export. 
        /// <para>
        /// The details of the export, including data query, name, description, and destination
        /// configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Export Export
        {
            get { return this._export; }
            set { this._export = value; }
        }

        // Check to see if Export property is set
        internal bool IsSetExport()
        {
            return this._export != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceTags. 
        /// <para>
        /// An optional list of tags to associate with the specified export. Each tag consists
        /// of a key and a value, and each key must be unique for the resource.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=200)]
        public List<ResourceTag> ResourceTags
        {
            get { return this._resourceTags; }
            set { this._resourceTags = value; }
        }

        // Check to see if ResourceTags property is set
        internal bool IsSetResourceTags()
        {
            return this._resourceTags != null && (this._resourceTags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}