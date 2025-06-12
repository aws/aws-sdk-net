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
    /// Represents how to produce partition data for a table. Partition data is produced by
    /// transforming columns in a table. Each column transform is represented by a named <c>PartitionField</c>.
    /// 
    /// 
    ///  
    /// <para>
    /// Here is an example of the schema in JSON. 
    /// </para>
    ///  
    /// <para>
    ///  <c>"partitionSpec": { "identity": [ {"sourceName": "column1"}, {"sourceName": "column2"},
    /// {"sourceName": "column3"} ] }</c> 
    /// </para>
    ///  
    /// <para>
    /// Amazon Data Firehose is in preview release and is subject to change.
    /// </para>
    /// </summary>
    public partial class PartitionSpec
    {
        private List<PartitionField> _identity = AWSConfigs.InitializeCollections ? new List<PartitionField>() : null;

        /// <summary>
        /// Gets and sets the property Identity. 
        /// <para>
        ///  List of identity <a href="https://iceberg.apache.org/spec/#partition-transforms">transforms</a>
        /// that performs an identity transformation. The transform takes the source value, and
        /// does not modify it. Result type is the source type.
        /// </para>
        ///  
        /// <para>
        /// Amazon Data Firehose is in preview release and is subject to change.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<PartitionField> Identity
        {
            get { return this._identity; }
            set { this._identity = value; }
        }

        // Check to see if Identity property is set
        internal bool IsSetIdentity()
        {
            return this._identity != null && (this._identity.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}