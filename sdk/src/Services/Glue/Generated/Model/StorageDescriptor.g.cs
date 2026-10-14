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

namespace Amazon.Glue.Model
{
    /// <summary>
    /// Describes the physical storage of table data.
    /// </summary>
    public partial class StorageDescriptor
    {
        /// <summary>
        /// Gets and sets the property AdditionalLocations. 
        /// <para>
        /// A list of locations that point to the path where a Delta table is located.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AdditionalLocations { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AdditionalLocations property is set.
        /// </summary>
        internal bool IsSetAdditionalLocations() => this.AdditionalLocations != null && (this.AdditionalLocations.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property BucketColumns. 
        /// <para>
        /// A list of reducer grouping columns, clustering columns, and bucketing columns in the
        /// table.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> BucketColumns { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the BucketColumns property is set.
        /// </summary>
        internal bool IsSetBucketColumns() => this.BucketColumns != null && (this.BucketColumns.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Columns. 
        /// <para>
        /// A list of the <c>Columns</c> in the table.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Column> Columns { get; set; } = AWSConfigs.InitializeCollections ? new List<Column>() : null;

        /// <summary>
        /// Checks to see if the Columns property is set.
        /// </summary>
        internal bool IsSetColumns() => this.Columns != null && (this.Columns.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Compressed. 
        /// <para>
        ///  <c>True</c> if the data in the table is compressed, or <c>False</c> if not.
        /// </para>
        /// </summary>
        public bool? Compressed { get; set; }

        /// <summary>
        /// Checks to see if the Compressed property is set.
        /// </summary>
        internal bool IsSetCompressed() => this.Compressed.HasValue;

        /// <summary>
        /// Gets and sets the property InputFormat. 
        /// <para>
        /// The input format: <c>SequenceFileInputFormat</c> (binary), or <c>TextInputFormat</c>,
        /// or a custom format.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 128)]
        public string InputFormat { get; set; }

        /// <summary>
        /// Checks to see if the InputFormat property is set.
        /// </summary>
        internal bool IsSetInputFormat() => this.InputFormat != null;

        /// <summary>
        /// Gets and sets the property Location. 
        /// <para>
        /// The physical location of the table. By default, this takes the form of the warehouse
        /// location, followed by the database location in the warehouse, followed by the table
        /// name.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2056)]
        public string Location { get; set; }

        /// <summary>
        /// Checks to see if the Location property is set.
        /// </summary>
        internal bool IsSetLocation() => this.Location != null;

        /// <summary>
        /// Gets and sets the property NumberOfBuckets. 
        /// <para>
        /// Must be specified if the table contains any dimension columns.
        /// </para>
        /// </summary>
        public int? NumberOfBuckets { get; set; }

        /// <summary>
        /// Checks to see if the NumberOfBuckets property is set.
        /// </summary>
        internal bool IsSetNumberOfBuckets() => this.NumberOfBuckets.HasValue;

        /// <summary>
        /// Gets and sets the property OutputFormat. 
        /// <para>
        /// The output format: <c>SequenceFileOutputFormat</c> (binary), or <c>IgnoreKeyTextOutputFormat</c>,
        /// or a custom format.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 128)]
        public string OutputFormat { get; set; }

        /// <summary>
        /// Checks to see if the OutputFormat property is set.
        /// </summary>
        internal bool IsSetOutputFormat() => this.OutputFormat != null;

        /// <summary>
        /// Gets and sets the property Parameters. 
        /// <para>
        /// The user-supplied properties in key-value form.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Parameters { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Parameters property is set.
        /// </summary>
        internal bool IsSetParameters() => this.Parameters != null && (this.Parameters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SchemaReference. 
        /// <para>
        /// An object that references a schema stored in the Glue Schema Registry.
        /// </para>
        ///  
        /// <para>
        /// When creating a table, you can pass an empty list of columns for the schema, and instead
        /// use a schema reference.
        /// </para>
        /// </summary>
        public SchemaReference SchemaReference { get; set; }

        /// <summary>
        /// Checks to see if the SchemaReference property is set.
        /// </summary>
        internal bool IsSetSchemaReference() => this.SchemaReference != null;

        /// <summary>
        /// Gets and sets the property SerdeInfo. 
        /// <para>
        /// The serialization/deserialization (SerDe) information.
        /// </para>
        /// </summary>
        public SerDeInfo SerdeInfo { get; set; }

        /// <summary>
        /// Checks to see if the SerdeInfo property is set.
        /// </summary>
        internal bool IsSetSerdeInfo() => this.SerdeInfo != null;

        /// <summary>
        /// Gets and sets the property SkewedInfo. 
        /// <para>
        /// The information about values that appear frequently in a column (skewed values).
        /// </para>
        /// </summary>
        public SkewedInfo SkewedInfo { get; set; }

        /// <summary>
        /// Checks to see if the SkewedInfo property is set.
        /// </summary>
        internal bool IsSetSkewedInfo() => this.SkewedInfo != null;

        /// <summary>
        /// Gets and sets the property SortColumns. 
        /// <para>
        /// A list specifying the sort order of each bucket in the table.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Order> SortColumns { get; set; } = AWSConfigs.InitializeCollections ? new List<Order>() : null;

        /// <summary>
        /// Checks to see if the SortColumns property is set.
        /// </summary>
        internal bool IsSetSortColumns() => this.SortColumns != null && (this.SortColumns.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property StoredAsSubDirectories. 
        /// <para>
        ///  <c>True</c> if the table data is stored in subdirectories, or <c>False</c> if not.
        /// </para>
        /// </summary>
        public bool? StoredAsSubDirectories { get; set; }

        /// <summary>
        /// Checks to see if the StoredAsSubDirectories property is set.
        /// </summary>
        internal bool IsSetStoredAsSubDirectories() => this.StoredAsSubDirectories.HasValue;
    }
}
