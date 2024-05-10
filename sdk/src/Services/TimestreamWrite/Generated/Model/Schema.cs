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
 * Do not modify this file. This file is generated from the timestream-write-2018-11-01.normal.json service model.
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
namespace Amazon.TimestreamWrite.Model
{
    /// <summary>
    /// A Schema specifies the expected data model of the table.
    /// </summary>
    public partial class Schema
    {
        private List<PartitionKey> _compositePartitionKey = AWSConfigs.InitializeCollections ? new List<PartitionKey>() : null;

        /// <summary>
        /// Gets and sets the property CompositePartitionKey. 
        /// <para>
        /// A non-empty list of partition keys defining the attributes used to partition the table
        /// data. The order of the list determines the partition hierarchy. The name and type
        /// of each partition key as well as the partition key order cannot be changed after the
        /// table is created. However, the enforcement level of each partition key can be changed.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public List<PartitionKey> CompositePartitionKey
        {
            get { return this._compositePartitionKey; }
            set { this._compositePartitionKey = value; }
        }

        // Check to see if CompositePartitionKey property is set
        internal bool IsSetCompositePartitionKey()
        {
            return this._compositePartitionKey != null && (this._compositePartitionKey.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}