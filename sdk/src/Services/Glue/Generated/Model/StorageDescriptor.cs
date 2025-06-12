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
    /// Describes the physical storage of table data.
    /// </summary>
    public partial class StorageDescriptor
    {
        private List<string> _additionalLocations = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _bucketColumns = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<Column> _columns = AWSConfigs.InitializeCollections ? new List<Column>() : null;
        private bool? _compressed;
        private string _inputFormat;
        private string _location;
        private int? _numberOfBuckets;
        private string _outputFormat;
        private Dictionary<string, string> _parameters = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private SchemaReference _schemaReference;
        private SerDeInfo _serdeInfo;
        private SkewedInfo _skewedInfo;
        private List<Order> _sortColumns = AWSConfigs.InitializeCollections ? new List<Order>() : null;
        private bool? _storedAsSubDirectories;

        /// <summary>
        /// Gets and sets the property AdditionalLocations. 
        /// <para>
        /// A list of locations that point to the path where a Delta table is located.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AdditionalLocations
        {
            get { return this._additionalLocations; }
            set { this._additionalLocations = value; }
        }

        // Check to see if AdditionalLocations property is set
        internal bool IsSetAdditionalLocations()
        {
            return this._additionalLocations != null && (this._additionalLocations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property BucketColumns. 
        /// <para>
        /// A list of reducer grouping columns, clustering columns, and bucketing columns in the
        /// table.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> BucketColumns
        {
            get { return this._bucketColumns; }
            set { this._bucketColumns = value; }
        }

        // Check to see if BucketColumns property is set
        internal bool IsSetBucketColumns()
        {
            return this._bucketColumns != null && (this._bucketColumns.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Columns. 
        /// <para>
        /// A list of the <c>Columns</c> in the table.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Column> Columns
        {
            get { return this._columns; }
            set { this._columns = value; }
        }

        // Check to see if Columns property is set
        internal bool IsSetColumns()
        {
            return this._columns != null && (this._columns.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Compressed. 
        /// <para>
        ///  <c>True</c> if the data in the table is compressed, or <c>False</c> if not.
        /// </para>
        /// </summary>
        public bool? Compressed
        {
            get { return this._compressed; }
            set { this._compressed = value; }
        }

        // Check to see if Compressed property is set
        internal bool IsSetCompressed()
        {
            return this._compressed.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InputFormat. 
        /// <para>
        /// The input format: <c>SequenceFileInputFormat</c> (binary), or <c>TextInputFormat</c>,
        /// or a custom format.
        /// </para>
        /// </summary>
        [AWSProperty(Max=128)]
        public string InputFormat
        {
            get { return this._inputFormat; }
            set { this._inputFormat = value; }
        }

        // Check to see if InputFormat property is set
        internal bool IsSetInputFormat()
        {
            return this._inputFormat != null;
        }

        /// <summary>
        /// Gets and sets the property Location. 
        /// <para>
        /// The physical location of the table. By default, this takes the form of the warehouse
        /// location, followed by the database location in the warehouse, followed by the table
        /// name.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2056)]
        public string Location
        {
            get { return this._location; }
            set { this._location = value; }
        }

        // Check to see if Location property is set
        internal bool IsSetLocation()
        {
            return this._location != null;
        }

        /// <summary>
        /// Gets and sets the property NumberOfBuckets. 
        /// <para>
        /// Must be specified if the table contains any dimension columns.
        /// </para>
        /// </summary>
        public int? NumberOfBuckets
        {
            get { return this._numberOfBuckets; }
            set { this._numberOfBuckets = value; }
        }

        // Check to see if NumberOfBuckets property is set
        internal bool IsSetNumberOfBuckets()
        {
            return this._numberOfBuckets.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OutputFormat. 
        /// <para>
        /// The output format: <c>SequenceFileOutputFormat</c> (binary), or <c>IgnoreKeyTextOutputFormat</c>,
        /// or a custom format.
        /// </para>
        /// </summary>
        [AWSProperty(Max=128)]
        public string OutputFormat
        {
            get { return this._outputFormat; }
            set { this._outputFormat = value; }
        }

        // Check to see if OutputFormat property is set
        internal bool IsSetOutputFormat()
        {
            return this._outputFormat != null;
        }

        /// <summary>
        /// Gets and sets the property Parameters. 
        /// <para>
        /// The user-supplied properties in key-value form.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Parameters
        {
            get { return this._parameters; }
            set { this._parameters = value; }
        }

        // Check to see if Parameters property is set
        internal bool IsSetParameters()
        {
            return this._parameters != null && (this._parameters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

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
        public SchemaReference SchemaReference
        {
            get { return this._schemaReference; }
            set { this._schemaReference = value; }
        }

        // Check to see if SchemaReference property is set
        internal bool IsSetSchemaReference()
        {
            return this._schemaReference != null;
        }

        /// <summary>
        /// Gets and sets the property SerdeInfo. 
        /// <para>
        /// The serialization/deserialization (SerDe) information.
        /// </para>
        /// </summary>
        public SerDeInfo SerdeInfo
        {
            get { return this._serdeInfo; }
            set { this._serdeInfo = value; }
        }

        // Check to see if SerdeInfo property is set
        internal bool IsSetSerdeInfo()
        {
            return this._serdeInfo != null;
        }

        /// <summary>
        /// Gets and sets the property SkewedInfo. 
        /// <para>
        /// The information about values that appear frequently in a column (skewed values).
        /// </para>
        /// </summary>
        public SkewedInfo SkewedInfo
        {
            get { return this._skewedInfo; }
            set { this._skewedInfo = value; }
        }

        // Check to see if SkewedInfo property is set
        internal bool IsSetSkewedInfo()
        {
            return this._skewedInfo != null;
        }

        /// <summary>
        /// Gets and sets the property SortColumns. 
        /// <para>
        /// A list specifying the sort order of each bucket in the table.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Order> SortColumns
        {
            get { return this._sortColumns; }
            set { this._sortColumns = value; }
        }

        // Check to see if SortColumns property is set
        internal bool IsSetSortColumns()
        {
            return this._sortColumns != null && (this._sortColumns.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property StoredAsSubDirectories. 
        /// <para>
        ///  <c>True</c> if the table data is stored in subdirectories, or <c>False</c> if not.
        /// </para>
        /// </summary>
        public bool? StoredAsSubDirectories
        {
            get { return this._storedAsSubDirectories; }
            set { this._storedAsSubDirectories = value; }
        }

        // Check to see if StoredAsSubDirectories property is set
        internal bool IsSetStoredAsSubDirectories()
        {
            return this._storedAsSubDirectories.HasValue; 
        }

    }
}