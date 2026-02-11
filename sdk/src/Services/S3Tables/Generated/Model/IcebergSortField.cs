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
 * Do not modify this file. This file is generated from the s3tables-2018-05-10.normal.json service model.
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
namespace Amazon.S3Tables.Model
{
    /// <summary>
    /// Defines a single sort field in an Iceberg sort order specification.
    /// </summary>
    public partial class IcebergSortField
    {
        private IcebergSortDirection _direction;
        private IcebergNullOrder _nullOrder;
        private int? _sourceId;
        private string _transform;

        /// <summary>
        /// Gets and sets the property Direction. 
        /// <para>
        /// The sort direction. Valid values are <c>asc</c> for ascending order or <c>desc</c>
        /// for descending order.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public IcebergSortDirection Direction
        {
            get { return this._direction; }
            set { this._direction = value; }
        }

        // Check to see if Direction property is set
        internal bool IsSetDirection()
        {
            return this._direction != null;
        }

        /// <summary>
        /// Gets and sets the property NullOrder. 
        /// <para>
        /// Specifies how null values are ordered. Valid values are <c>nulls-first</c> to place
        /// nulls before non-null values, or <c>nulls-last</c> to place nulls after non-null values.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public IcebergNullOrder NullOrder
        {
            get { return this._nullOrder; }
            set { this._nullOrder = value; }
        }

        // Check to see if NullOrder property is set
        internal bool IsSetNullOrder()
        {
            return this._nullOrder != null;
        }

        /// <summary>
        /// Gets and sets the property SourceId. 
        /// <para>
        /// The ID of the source schema field to sort by. This must reference a valid field ID
        /// from the table schema.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? SourceId
        {
            get { return this._sourceId; }
            set { this._sourceId = value; }
        }

        // Check to see if SourceId property is set
        internal bool IsSetSourceId()
        {
            return this._sourceId.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Transform. 
        /// <para>
        /// The transform to apply to the source field before sorting. Use <c>identity</c> to
        /// sort by the field value directly, or specify other transforms as needed.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Transform
        {
            get { return this._transform; }
            set { this._transform = value; }
        }

        // Check to see if Transform property is set
        internal bool IsSetTransform()
        {
            return this._transform != null;
        }

    }
}