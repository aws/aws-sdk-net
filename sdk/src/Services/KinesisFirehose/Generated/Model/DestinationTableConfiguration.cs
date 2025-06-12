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
 * Do not modify this file. This file is generated from the firehose-2015-08-04.normal.json service model.
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
        private string _destinationDatabaseName;
        private string _destinationTableName;
        private PartitionSpec _partitionSpec;
        private string _s3ErrorOutputPrefix;
        private List<string> _uniqueKeys = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property DestinationDatabaseName. 
        /// <para>
        ///  The name of the Apache Iceberg database. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
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
        ///  Specifies the name of the Apache Iceberg Table. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
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
        /// The partition spec configuration for a table that is used by automatic table creation.
        /// </para>
        ///  
        /// <para>
        /// Amazon Data Firehose is in preview release and is subject to change.
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

        /// <summary>
        /// Gets and sets the property S3ErrorOutputPrefix. 
        /// <para>
        ///  The table specific S3 error output prefix. All the errors that occurred while delivering
        /// to this table will be prefixed with this value in S3 destination. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string S3ErrorOutputPrefix
        {
            get { return this._s3ErrorOutputPrefix; }
            set { this._s3ErrorOutputPrefix = value; }
        }

        // Check to see if S3ErrorOutputPrefix property is set
        internal bool IsSetS3ErrorOutputPrefix()
        {
            return this._s3ErrorOutputPrefix != null;
        }

        /// <summary>
        /// Gets and sets the property UniqueKeys. 
        /// <para>
        ///  A list of unique keys for a given Apache Iceberg table. Firehose will use these for
        /// running Create, Update, or Delete operations on the given Iceberg table. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> UniqueKeys
        {
            get { return this._uniqueKeys; }
            set { this._uniqueKeys = value; }
        }

        // Check to see if UniqueKeys property is set
        internal bool IsSetUniqueKeys()
        {
            return this._uniqueKeys != null && (this._uniqueKeys.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}