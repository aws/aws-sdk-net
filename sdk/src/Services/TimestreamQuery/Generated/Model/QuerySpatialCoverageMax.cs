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
 * Do not modify this file. This file is generated from the timestream-query-2018-11-01.normal.json service model.
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
namespace Amazon.TimestreamQuery.Model
{
    /// <summary>
    /// Provides insights into the table with the most sub-optimal spatial range scanned by
    /// your query.
    /// </summary>
    public partial class QuerySpatialCoverageMax
    {
        private List<string> _partitionKey = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _tableArn;
        private double? _value;

        /// <summary>
        /// Gets and sets the property PartitionKey. 
        /// <para>
        /// The partition key used for partitioning, which can be a default <c>measure_name</c>
        /// or a <a href="https://docs.aws.amazon.com/timestream/latest/developerguide/customer-defined-partition-keys.html">customer
        /// defined partition key</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> PartitionKey
        {
            get { return this._partitionKey; }
            set { this._partitionKey = value; }
        }

        // Check to see if PartitionKey property is set
        internal bool IsSetPartitionKey()
        {
            return this._partitionKey != null && (this._partitionKey.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TableArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the table with the most sub-optimal spatial pruning.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string TableArn
        {
            get { return this._tableArn; }
            set { this._tableArn = value; }
        }

        // Check to see if TableArn property is set
        internal bool IsSetTableArn()
        {
            return this._tableArn != null;
        }

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// The maximum ratio of spatial coverage.
        /// </para>
        /// </summary>
        public double? Value
        {
            get { return this._value; }
            set { this._value = value; }
        }

        // Check to see if Value property is set
        internal bool IsSetValue()
        {
            return this._value.HasValue; 
        }

    }
}