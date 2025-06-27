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
    /// Defines a single partition field within an Iceberg partition specification, including
    /// the source field, transformation function, partition name, and unique identifier.
    /// </summary>
    public partial class IcebergPartitionField
    {
        private int? _fieldId;
        private string _name;
        private int? _sourceId;
        private string _transform;

        /// <summary>
        /// Gets and sets the property FieldId. 
        /// <para>
        /// The unique identifier assigned to this partition field within the Iceberg table's
        /// partition specification.
        /// </para>
        /// </summary>
        public int? FieldId
        {
            get { return this._fieldId; }
            set { this._fieldId = value; }
        }

        // Check to see if FieldId property is set
        internal bool IsSetFieldId()
        {
            return this._fieldId.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the partition field as it will appear in the partitioned table structure.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1024)]
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
        /// Gets and sets the property SourceId. 
        /// <para>
        /// The identifier of the source field from the table schema that this partition field
        /// is based on.
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
        /// The transformation function applied to the source field to create the partition, such
        /// as identity, bucket, truncate, year, month, day, or hour.
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