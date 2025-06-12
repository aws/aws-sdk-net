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
    /// A structure that contains the values and structure used to update a partition.
    /// </summary>
    public partial class BatchUpdatePartitionRequestEntry
    {
        private PartitionInput _partitionInput;
        private List<string> _partitionValueList = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property PartitionInput. 
        /// <para>
        /// The structure used to update a partition.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public PartitionInput PartitionInput
        {
            get { return this._partitionInput; }
            set { this._partitionInput = value; }
        }

        // Check to see if PartitionInput property is set
        internal bool IsSetPartitionInput()
        {
            return this._partitionInput != null;
        }

        /// <summary>
        /// Gets and sets the property PartitionValueList. 
        /// <para>
        /// A list of values defining the partitions.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=100)]
        public List<string> PartitionValueList
        {
            get { return this._partitionValueList; }
            set { this._partitionValueList = value; }
        }

        // Check to see if PartitionValueList property is set
        internal bool IsSetPartitionValueList()
        {
            return this._partitionValueList != null && (this._partitionValueList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}