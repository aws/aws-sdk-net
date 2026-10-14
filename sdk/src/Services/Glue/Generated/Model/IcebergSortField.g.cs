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
    /// Defines a single field within an Iceberg sort order specification, including the source
    /// field, transformation, sort direction, and null value ordering.
    /// </summary>
    public partial class IcebergSortField
    {
        /// <summary>
        /// Gets and sets the property Direction. 
        /// <para>
        /// The sort direction for this field, either ascending or descending.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public IcebergSortDirection Direction { get; set; }

        /// <summary>
        /// Checks to see if the Direction property is set.
        /// </summary>
        internal bool IsSetDirection() => this.Direction != null;

        /// <summary>
        /// Gets and sets the property NullOrder. 
        /// <para>
        /// The ordering behavior for null values in this field, specifying whether nulls should
        /// appear first or last in the sort order.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public IcebergNullOrder NullOrder { get; set; }

        /// <summary>
        /// Checks to see if the NullOrder property is set.
        /// </summary>
        internal bool IsSetNullOrder() => this.NullOrder != null;

        /// <summary>
        /// Gets and sets the property SourceId. 
        /// <para>
        /// The identifier of the source field from the table schema that this sort field is based
        /// on.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? SourceId { get; set; }

        /// <summary>
        /// Checks to see if the SourceId property is set.
        /// </summary>
        internal bool IsSetSourceId() => this.SourceId.HasValue;

        /// <summary>
        /// Gets and sets the property Transform. 
        /// <para>
        /// The transformation function applied to the source field before sorting, such as identity,
        /// bucket, or truncate.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Transform { get; set; }

        /// <summary>
        /// Checks to see if the Transform property is set.
        /// </summary>
        internal bool IsSetTransform() => this.Transform != null;
    }
}
