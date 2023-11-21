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
    /// Amazon S3 key format for log objects. Only one format, PartitionedPrefix or SimplePrefix,
    /// is allowed.
    /// </summary>
    public partial class TargetObjectKeyFormat
    {
        private PartitionedPrefix _partitionedPrefix;
        private SimplePrefix _simplePrefix;

        /// <summary>
        /// Gets and sets the property PartitionedPrefix. 
        /// <para>
        /// Partitioned S3 key for log objects.
        /// </para>
        /// </summary>
        public PartitionedPrefix PartitionedPrefix
        {
            get { return this._partitionedPrefix; }
            set { this._partitionedPrefix = value; }
        }

        // Check to see if PartitionedPrefix property is set
        internal bool IsSetPartitionedPrefix()
        {
            return this._partitionedPrefix != null;
        }

        /// <summary>
        /// Gets and sets the property SimplePrefix. 
        /// <para>
        /// To use the simple format for S3 keys for log objects. To specify SimplePrefix format,
        /// set SimplePrefix to {}.
        /// </para>
        /// </summary>
        public SimplePrefix SimplePrefix
        {
            get { return this._simplePrefix; }
            set { this._simplePrefix = value; }
        }

        // Check to see if SimplePrefix property is set
        internal bool IsSetSimplePrefix()
        {
            return this._simplePrefix != null;
        }

    }
}