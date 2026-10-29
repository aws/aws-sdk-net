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

namespace Amazon.KinesisFirehose.Model
{
    /// <summary>
    /// Describes the configuration of a destination in Apache Iceberg Tables.
    /// </summary>
    public partial class DestinationTableConfiguration
    {
        /// <summary>
        /// Gets and sets the property DestinationDatabaseName. 
        /// <para>
        ///  The name of the Apache Iceberg database. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string DestinationDatabaseName { get; set; }

        /// <summary>
        /// Checks to see if the DestinationDatabaseName property is set.
        /// </summary>
        internal bool IsSetDestinationDatabaseName() => this.DestinationDatabaseName != null;

        /// <summary>
        /// Gets and sets the property DestinationTableName. 
        /// <para>
        ///  Specifies the name of the Apache Iceberg Table. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string DestinationTableName { get; set; }

        /// <summary>
        /// Checks to see if the DestinationTableName property is set.
        /// </summary>
        internal bool IsSetDestinationTableName() => this.DestinationTableName != null;

        /// <summary>
        /// Gets and sets the property PartitionSpec. 
        /// <para>
        /// The partition spec configuration for a table that is used by automatic table creation.
        /// </para>
        ///  
        /// <para>
        /// Amazon Data Firehose is in preview release and is subject to change.
        /// </para>
        /// </summary>
        public PartitionSpec PartitionSpec { get; set; }

        /// <summary>
        /// Checks to see if the PartitionSpec property is set.
        /// </summary>
        internal bool IsSetPartitionSpec() => this.PartitionSpec != null;

        /// <summary>
        /// Gets and sets the property S3ErrorOutputPrefix. 
        /// <para>
        ///  The table specific S3 error output prefix. All the errors that occurred while delivering
        /// to this table will be prefixed with this value in S3 destination. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string S3ErrorOutputPrefix { get; set; }

        /// <summary>
        /// Checks to see if the S3ErrorOutputPrefix property is set.
        /// </summary>
        internal bool IsSetS3ErrorOutputPrefix() => this.S3ErrorOutputPrefix != null;

        /// <summary>
        /// Gets and sets the property UniqueKeys. 
        /// <para>
        ///  A list of unique keys for a given Apache Iceberg table. Firehose will use these for
        /// running Create, Update, or Delete operations on the given Iceberg table. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> UniqueKeys { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the UniqueKeys property is set.
        /// </summary>
        internal bool IsSetUniqueKeys() => this.UniqueKeys != null && (this.UniqueKeys.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
