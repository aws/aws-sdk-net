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
    /// Defines a field in an entity schema for REST connector data sources, specifying the
    /// field name and data type.
    /// </summary>
    public partial class FieldDefinition
    {
        /// <summary>
        /// Gets and sets the property FieldDataType. 
        /// <para>
        /// The data type of the field.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public FieldDataType FieldDataType { get; set; }

        /// <summary>
        /// Checks to see if the FieldDataType property is set.
        /// </summary>
        internal bool IsSetFieldDataType() => this.FieldDataType != null;

        /// <summary>
        /// Gets and sets the property FilterOverrides. 
        /// <para>
        /// Per-field overrides for filter behavior, allowing customization of how filters are
        /// applied to this specific field.
        /// </para>
        /// </summary>
        public FilterOverrides FilterOverrides { get; set; }

        /// <summary>
        /// Checks to see if the FilterOverrides property is set.
        /// </summary>
        internal bool IsSetFilterOverrides() => this.FilterOverrides != null;

        /// <summary>
        /// Gets and sets the property IsNullable. 
        /// <para>
        /// Indicates whether this field can contain null values.
        /// </para>
        /// </summary>
        public bool? IsNullable { get; set; }

        /// <summary>
        /// Checks to see if the IsNullable property is set.
        /// </summary>
        internal bool IsSetIsNullable() => this.IsNullable.HasValue;

        /// <summary>
        /// Gets and sets the property IsOrderable. 
        /// <para>
        /// Indicates whether this field can be used for ordering results.
        /// </para>
        /// </summary>
        public bool? IsOrderable { get; set; }

        /// <summary>
        /// Checks to see if the IsOrderable property is set.
        /// </summary>
        internal bool IsSetIsOrderable() => this.IsOrderable.HasValue;

        /// <summary>
        /// Gets and sets the property IsPartitionable. 
        /// <para>
        /// Indicates whether this field can be used for partitioning queries to the data source.
        /// </para>
        /// </summary>
        public bool? IsPartitionable { get; set; }

        /// <summary>
        /// Checks to see if the IsPartitionable property is set.
        /// </summary>
        internal bool IsSetIsPartitionable() => this.IsPartitionable.HasValue;

        /// <summary>
        /// Gets and sets the property IsQueryable. 
        /// <para>
        /// Indicates whether this field can be used in filter predicates when querying data.
        /// </para>
        /// </summary>
        public bool? IsQueryable { get; set; }

        /// <summary>
        /// Checks to see if the IsQueryable property is set.
        /// </summary>
        internal bool IsSetIsQueryable() => this.IsQueryable.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the field in the entity schema.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property ResponseDateFormat. 
        /// <para>
        /// The format pattern for parsing date values from API responses. Required when the API
        /// uses a non-ISO-8601 format. Accepts Java <c>DateTimeFormatter</c> patterns (for example,
        /// <c>EEE, d MMM yyyy HH:mm:ss Z</c>), <c>EPOCH_SECONDS</c> for Unix epoch seconds, or
        /// <c>EPOCH_MILLIS</c> for Unix epoch milliseconds.
        /// </para>
        /// </summary>
        public string ResponseDateFormat { get; set; }

        /// <summary>
        /// Checks to see if the ResponseDateFormat property is set.
        /// </summary>
        internal bool IsSetResponseDateFormat() => this.ResponseDateFormat != null;
    }
}
