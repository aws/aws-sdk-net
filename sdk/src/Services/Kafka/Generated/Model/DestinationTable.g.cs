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

namespace Amazon.Kafka.Model
{
    /// <summary>
    /// Configuration of an Apache Iceberg destination table.
    /// </summary>
    public partial class DestinationTable
    {
        /// <summary>
        /// Gets and sets the property DestinationDatabaseName. 
        /// <para>
        /// The name of the destination namespace (database) in the AWS Glue Data Catalog.
        /// </para>
        /// </summary>
        public string DestinationDatabaseName { get; set; }

        /// <summary>
        /// Checks to see if the DestinationDatabaseName property is set.
        /// </summary>
        internal bool IsSetDestinationDatabaseName() => this.DestinationDatabaseName != null;

        /// <summary>
        /// Gets and sets the property DestinationTableName. 
        /// <para>
        /// The name of the destination Apache Iceberg table.
        /// </para>
        /// </summary>
        public string DestinationTableName { get; set; }

        /// <summary>
        /// Checks to see if the DestinationTableName property is set.
        /// </summary>
        internal bool IsSetDestinationTableName() => this.DestinationTableName != null;

        /// <summary>
        /// Gets and sets the property PartitionSpec. 
        /// <para>
        /// The partition specification for the destination table.
        /// </para>
        /// </summary>
        public PartitionSpec PartitionSpec { get; set; }

        /// <summary>
        /// Checks to see if the PartitionSpec property is set.
        /// </summary>
        internal bool IsSetPartitionSpec() => this.PartitionSpec != null;
    }
}
