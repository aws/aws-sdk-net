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
 * Do not modify this file. This file is generated from the kafka-2018-11-14.normal.json service model.
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
        private string _destinationDatabaseName;
        private string _destinationTableName;
        private PartitionSpec _partitionSpec;

        /// <summary>
        /// Gets and sets the property DestinationDatabaseName. 
        /// <para>
        /// The name of the destination namespace (database) in the AWS Glue Data Catalog.
        /// </para>
        /// </summary>
        public string DestinationDatabaseName
        {
            get { return this._destinationDatabaseName; }
            set { this._destinationDatabaseName = value; }
        }

        // Check to see if DestinationDatabaseName property is set
        internal bool IsSetDestinationDatabaseName()
        {
            return this._destinationDatabaseName != null;
        }

        /// <summary>
        /// Gets and sets the property DestinationTableName. 
        /// <para>
        /// The name of the destination Apache Iceberg table.
        /// </para>
        /// </summary>
        public string DestinationTableName
        {
            get { return this._destinationTableName; }
            set { this._destinationTableName = value; }
        }

        // Check to see if DestinationTableName property is set
        internal bool IsSetDestinationTableName()
        {
            return this._destinationTableName != null;
        }

        /// <summary>
        /// Gets and sets the property PartitionSpec. 
        /// <para>
        /// The partition specification for the destination table.
        /// </para>
        /// </summary>
        public PartitionSpec PartitionSpec
        {
            get { return this._partitionSpec; }
            set { this._partitionSpec = value; }
        }

        // Check to see if PartitionSpec property is set
        internal bool IsSetPartitionSpec()
        {
            return this._partitionSpec != null;
        }

    }
}