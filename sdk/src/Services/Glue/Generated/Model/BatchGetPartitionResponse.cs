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

namespace Amazon.Glue.Model
{
    /// <summary>
    /// This is the response object from the BatchGetPartition operation.
    /// </summary>
    public partial class BatchGetPartitionResponse : AmazonWebServiceResponse
    {
        private List<Partition> _partitions = new List<Partition>();
        private List<PartitionValueList> _unprocessedKeys = new List<PartitionValueList>();

        /// <summary>
        /// Gets and sets the property Partitions. 
        /// <para>
        /// A list of the requested partitions.
        /// </para>
        /// </summary>
        public List<Partition> Partitions
        {
            get { return this._partitions; }
            set { this._partitions = value; }
        }

        // Check to see if Partitions property is set
        internal bool IsSetPartitions()
        {
            return this._partitions != null && this._partitions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property UnprocessedKeys. 
        /// <para>
        /// A list of the partition values in the request for which partitions were not returned.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1000)]
        public List<PartitionValueList> UnprocessedKeys
        {
            get { return this._unprocessedKeys; }
            set { this._unprocessedKeys = value; }
        }

        // Check to see if UnprocessedKeys property is set
        internal bool IsSetUnprocessedKeys()
        {
            return this._unprocessedKeys != null && this._unprocessedKeys.Count > 0; 
        }

    }
}