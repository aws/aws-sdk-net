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
    /// The configuration for an Iceberg compaction optimizer. This configuration defines
    /// parameters for optimizing the layout of data files in Iceberg tables.
    /// </summary>
    public partial class IcebergCompactionConfiguration
    {
        private int? _deleteFileThreshold;
        private int? _minInputFiles;
        private CompactionStrategy _strategy;

        /// <summary>
        /// Gets and sets the property DeleteFileThreshold. 
        /// <para>
        /// The minimum number of deletes that must be present in a data file to make it eligible
        /// for compaction. This parameter helps optimize compaction by focusing on files that
        /// contain a significant number of delete operations, which can improve query performance
        /// by removing deleted records. If an input is not provided, the default value 1 will
        /// be used.
        /// </para>
        /// </summary>
        public int? DeleteFileThreshold
        {
            get { return this._deleteFileThreshold; }
            set { this._deleteFileThreshold = value; }
        }

        // Check to see if DeleteFileThreshold property is set
        internal bool IsSetDeleteFileThreshold()
        {
            return this._deleteFileThreshold.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MinInputFiles. 
        /// <para>
        /// The minimum number of data files that must be present in a partition before compaction
        /// will actually compact files. This parameter helps control when compaction is triggered,
        /// preventing unnecessary compaction operations on partitions with few files. If an input
        /// is not provided, the default value 100 will be used.
        /// </para>
        /// </summary>
        public int? MinInputFiles
        {
            get { return this._minInputFiles; }
            set { this._minInputFiles = value; }
        }

        // Check to see if MinInputFiles property is set
        internal bool IsSetMinInputFiles()
        {
            return this._minInputFiles.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Strategy. 
        /// <para>
        /// The strategy to use for compaction. Valid values are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>binpack</c>: Combines small files into larger files, typically targeting sizes
        /// over 100MB, while applying any pending deletes. This is the recommended compaction
        /// strategy for most use cases. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>sort</c>: Organizes data based on specified columns which are sorted hierarchically
        /// during compaction, improving query performance for filtered operations. This strategy
        /// is recommended when your queries frequently filter on specific columns. To use this
        /// strategy, you must first define a sort order in your Iceberg table properties using
        /// the <c>sort_order</c> table property.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>z-order</c>: Optimizes data organization by blending multiple attributes into
        /// a single scalar value that can be used for sorting, allowing efficient querying across
        /// multiple dimensions. This strategy is recommended when you need to query data across
        /// multiple dimensions simultaneously. To use this strategy, you must first define a
        /// sort order in your Iceberg table properties using the <c>sort_order</c> table property.
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If an input is not provided, the default value 'binpack' will be used.
        /// </para>
        /// </summary>
        public CompactionStrategy Strategy
        {
            get { return this._strategy; }
            set { this._strategy = value; }
        }

        // Check to see if Strategy property is set
        internal bool IsSetStrategy()
        {
            return this._strategy != null;
        }

    }
}