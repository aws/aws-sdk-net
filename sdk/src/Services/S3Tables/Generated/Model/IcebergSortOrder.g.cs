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
    /// Defines the sort order for data within an Iceberg table. Sorting data can improve
    /// query performance by enabling more efficient data skipping.
    /// </summary>
    public partial class IcebergSortOrder
    {
        /// <summary>
        /// Gets and sets the property Fields. 
        /// <para>
        /// The list of sort fields that define how data is sorted within files. Each field specifies
        /// a source field, sort direction, and null ordering. This field is required if <c>writeOrder</c>
        /// is provided.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<IcebergSortField> Fields { get; set; } = AWSConfigs.InitializeCollections ? new List<IcebergSortField>() : null;

        /// <summary>
        /// Checks to see if the Fields property is set.
        /// </summary>
        internal bool IsSetFields() => this.Fields != null && (this.Fields.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property OrderId. 
        /// <para>
        /// The unique identifier for this sort order. If not specified, defaults to <c>1</c>.
        /// The order ID is used by Apache Iceberg to track sort order evolution.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? OrderId { get; set; }

        /// <summary>
        /// Checks to see if the OrderId property is set.
        /// </summary>
        internal bool IsSetOrderId() => this.OrderId.HasValue;
    }
}
