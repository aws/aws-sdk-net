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
    /// Defines a field in an entity schema for REST connector data sources, specifying the
    /// field name and data type.
    /// </summary>
    public partial class FieldDefinition
    {
        private FieldDataType _fieldDataType;
        private FilterOverrides _filterOverrides;
        private bool? _isNullable;
        private bool? _isOrderable;
        private bool? _isPartitionable;
        private bool? _isQueryable;
        private string _name;
        private string _responseDateFormat;

        /// <summary>
        /// Gets and sets the property FieldDataType. 
        /// <para>
        /// The data type of the field.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public FieldDataType FieldDataType
        {
            get { return this._fieldDataType; }
            set { this._fieldDataType = value; }
        }

        // Check to see if FieldDataType property is set
        internal bool IsSetFieldDataType()
        {
            return this._fieldDataType != null;
        }

        /// <summary>
        /// Gets and sets the property FilterOverrides. 
        /// <para>
        /// Per-field overrides for filter behavior, allowing customization of how filters are
        /// applied to this specific field.
        /// </para>
        /// </summary>
        public FilterOverrides FilterOverrides
        {
            get { return this._filterOverrides; }
            set { this._filterOverrides = value; }
        }

        // Check to see if FilterOverrides property is set
        internal bool IsSetFilterOverrides()
        {
            return this._filterOverrides != null;
        }

        /// <summary>
        /// Gets and sets the property IsNullable. 
        /// <para>
        /// Indicates whether this field can contain null values.
        /// </para>
        /// </summary>
        public bool? IsNullable
        {
            get { return this._isNullable; }
            set { this._isNullable = value; }
        }

        // Check to see if IsNullable property is set
        internal bool IsSetIsNullable()
        {
            return this._isNullable.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IsOrderable. 
        /// <para>
        /// Indicates whether this field can be used for ordering results.
        /// </para>
        /// </summary>
        public bool? IsOrderable
        {
            get { return this._isOrderable; }
            set { this._isOrderable = value; }
        }

        // Check to see if IsOrderable property is set
        internal bool IsSetIsOrderable()
        {
            return this._isOrderable.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IsPartitionable. 
        /// <para>
        /// Indicates whether this field can be used for partitioning queries to the data source.
        /// </para>
        /// </summary>
        public bool? IsPartitionable
        {
            get { return this._isPartitionable; }
            set { this._isPartitionable = value; }
        }

        // Check to see if IsPartitionable property is set
        internal bool IsSetIsPartitionable()
        {
            return this._isPartitionable.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IsQueryable. 
        /// <para>
        /// Indicates whether this field can be used in filter predicates when querying data.
        /// </para>
        /// </summary>
        public bool? IsQueryable
        {
            get { return this._isQueryable; }
            set { this._isQueryable = value; }
        }

        // Check to see if IsQueryable property is set
        internal bool IsSetIsQueryable()
        {
            return this._isQueryable.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the field in the entity schema.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property ResponseDateFormat. 
        /// <para>
        /// The format pattern for parsing date values from API responses. Required when the API
        /// uses a non-ISO-8601 format. Accepts Java <c>DateTimeFormatter</c> patterns (for example,
        /// <c>EEE, d MMM yyyy HH:mm:ss Z</c>), <c>EPOCH_SECONDS</c> for Unix epoch seconds, or
        /// <c>EPOCH_MILLIS</c> for Unix epoch milliseconds.
        /// </para>
        /// </summary>
        public string ResponseDateFormat
        {
            get { return this._responseDateFormat; }
            set { this._responseDateFormat = value; }
        }

        // Check to see if ResponseDateFormat property is set
        internal bool IsSetResponseDateFormat()
        {
            return this._responseDateFormat != null;
        }

    }
}