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
 * Do not modify this file. This file is generated from the iottwinmaker-2021-11-29.normal.json service model.
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
namespace Amazon.IoTTwinMaker.Model
{
    /// <summary>
    /// The metadata transfer job's progress.
    /// </summary>
    public partial class MetadataTransferJobProgress
    {
        private int? _failedCount;
        private int? _skippedCount;
        private int? _succeededCount;
        private int? _totalCount;

        /// <summary>
        /// Gets and sets the property FailedCount. 
        /// <para>
        /// The failed count.
        /// </para>
        /// </summary>
        public int? FailedCount
        {
            get { return this._failedCount; }
            set { this._failedCount = value; }
        }

        // Check to see if FailedCount property is set
        internal bool IsSetFailedCount()
        {
            return this._failedCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SkippedCount. 
        /// <para>
        /// The skipped count.
        /// </para>
        /// </summary>
        public int? SkippedCount
        {
            get { return this._skippedCount; }
            set { this._skippedCount = value; }
        }

        // Check to see if SkippedCount property is set
        internal bool IsSetSkippedCount()
        {
            return this._skippedCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SucceededCount. 
        /// <para>
        /// The succeeded count.
        /// </para>
        /// </summary>
        public int? SucceededCount
        {
            get { return this._succeededCount; }
            set { this._succeededCount = value; }
        }

        // Check to see if SucceededCount property is set
        internal bool IsSetSucceededCount()
        {
            return this._succeededCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TotalCount. 
        /// <para>
        /// The total count. [of what]
        /// </para>
        /// </summary>
        public int? TotalCount
        {
            get { return this._totalCount; }
            set { this._totalCount = value; }
        }

        // Check to see if TotalCount property is set
        internal bool IsSetTotalCount()
        {
            return this._totalCount.HasValue; 
        }

    }
}