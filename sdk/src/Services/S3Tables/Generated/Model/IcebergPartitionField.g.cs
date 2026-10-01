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

namespace Amazon.S3Tables.Model
{
    /// <summary>
    /// Defines a single partition field in an Iceberg partition specification.
    /// </summary>
    public partial class IcebergPartitionField
    {
        /// <summary>
        /// Gets and sets the property FieldId. 
        /// <para>
        /// An optional unique identifier for this partition field. If not specified, S3 Tables
        /// automatically assigns a field ID.
        /// </para>
        /// </summary>
        public int? FieldId { get; set; }

        /// <summary>
        /// Checks to see if the FieldId property is set.
        /// </summary>
        internal bool IsSetFieldId() => this.FieldId.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name for this partition field. This name is used in the partitioned file paths.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property SourceId. 
        /// <para>
        /// The ID of the source schema field to partition by. This must reference a valid field
        /// ID from the table schema.
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
        /// The partition transform to apply to the source field. Supported transforms include
        /// <c>identity</c>, <c>year</c>, <c>month</c>, <c>day</c>, <c>hour</c>, <c>bucket</c>,
        /// and <c>truncate</c>. For more information, see the <a href="https://iceberg.apache.org/spec/#partition-transforms">Apache
        /// Iceberg partition transforms documentation</a>.
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
