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

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// A physical table type for relational data sources.
    /// </summary>
    public partial class RelationalTable
    {
        /// <summary>
        /// Gets and sets the property Catalog. 
        /// <para>
        /// The catalog associated with a table.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string Catalog { get; set; }

        /// <summary>
        /// Checks to see if the Catalog property is set.
        /// </summary>
        internal bool IsSetCatalog() => this.Catalog != null;

        /// <summary>
        /// Gets and sets the property DataSourceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the data source.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string DataSourceArn { get; set; }

        /// <summary>
        /// Checks to see if the DataSourceArn property is set.
        /// </summary>
        internal bool IsSetDataSourceArn() => this.DataSourceArn != null;

        /// <summary>
        /// Gets and sets the property InputColumns. 
        /// <para>
        /// The column schema of the table.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 2048)]
        public List<InputColumn> InputColumns { get; set; } = AWSConfigs.InitializeCollections ? new List<InputColumn>() : null;

        /// <summary>
        /// Checks to see if the InputColumns property is set.
        /// </summary>
        internal bool IsSetInputColumns() => this.InputColumns != null && (this.InputColumns.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the relational table.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Schema. 
        /// <para>
        /// The schema name. This name applies to certain relational database engines.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string Schema { get; set; }

        /// <summary>
        /// Checks to see if the Schema property is set.
        /// </summary>
        internal bool IsSetSchema() => this.Schema != null;
    }
}
