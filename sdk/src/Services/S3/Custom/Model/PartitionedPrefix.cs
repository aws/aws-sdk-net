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

namespace Amazon.S3.Model
{
    /// <summary>
    /// Amazon S3 keys for log objects are partitioned in the following format:
    /// 
    ///  
    /// <para>
    ///  <code>[DestinationPrefix][SourceAccountId]/[SourceRegion]/[SourceBucket]/[YYYY]/[MM]/[DD]/[YYYY]-[MM]-[DD]-[hh]-[mm]-[ss]-[UniqueString]</code>
    /// 
    /// </para>
    ///  
    /// <para>
    /// PartitionedPrefix defaults to EventTime delivery when server access logs are delivered.
    /// </para>
    /// </summary>
    public partial class PartitionedPrefix
    {
        private PartitionDateSource _partitionDateSource;

        /// <summary>
        /// Gets and sets the property PartitionDateSource. 
        /// <para>
        /// Specifies the partition date source for the partitioned prefix. PartitionDateSource
        /// can be EventTime or DeliveryTime.
        /// </para>
        /// </summary>
        public PartitionDateSource PartitionDateSource
        {
            get { return this._partitionDateSource; }
            set { this._partitionDateSource = value; }
        }

        // Check to see if PartitionDateSource property is set
        internal bool IsSetPartitionDateSource()
        {
            return this._partitionDateSource != null;
        }

    }
}