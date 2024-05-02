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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
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
namespace Amazon.IoT.Model
{
    /// <summary>
    /// Provides summary counts of how many tasks for findings are in a particular state.
    /// This information is included in the response from DescribeAuditMitigationActionsTask.
    /// </summary>
    public partial class TaskStatisticsForAuditCheck
    {
        private long? _canceledFindingsCount;
        private long? _failedFindingsCount;
        private long? _skippedFindingsCount;
        private long? _succeededFindingsCount;
        private long? _totalFindingsCount;

        /// <summary>
        /// Gets and sets the property CanceledFindingsCount. 
        /// <para>
        /// The number of findings to which the mitigation action task was canceled when applied.
        /// </para>
        /// </summary>
        public long? CanceledFindingsCount
        {
            get { return this._canceledFindingsCount; }
            set { this._canceledFindingsCount = value; }
        }

        // Check to see if CanceledFindingsCount property is set
        internal bool IsSetCanceledFindingsCount()
        {
            return this._canceledFindingsCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FailedFindingsCount. 
        /// <para>
        /// The number of findings for which at least one of the actions failed when applied.
        /// </para>
        /// </summary>
        public long? FailedFindingsCount
        {
            get { return this._failedFindingsCount; }
            set { this._failedFindingsCount = value; }
        }

        // Check to see if FailedFindingsCount property is set
        internal bool IsSetFailedFindingsCount()
        {
            return this._failedFindingsCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SkippedFindingsCount. 
        /// <para>
        /// The number of findings skipped because of filter conditions provided in the parameters
        /// to the command.
        /// </para>
        /// </summary>
        public long? SkippedFindingsCount
        {
            get { return this._skippedFindingsCount; }
            set { this._skippedFindingsCount = value; }
        }

        // Check to see if SkippedFindingsCount property is set
        internal bool IsSetSkippedFindingsCount()
        {
            return this._skippedFindingsCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SucceededFindingsCount. 
        /// <para>
        /// The number of findings for which all mitigation actions succeeded when applied.
        /// </para>
        /// </summary>
        public long? SucceededFindingsCount
        {
            get { return this._succeededFindingsCount; }
            set { this._succeededFindingsCount = value; }
        }

        // Check to see if SucceededFindingsCount property is set
        internal bool IsSetSucceededFindingsCount()
        {
            return this._succeededFindingsCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TotalFindingsCount. 
        /// <para>
        /// The total number of findings to which a task is being applied.
        /// </para>
        /// </summary>
        public long? TotalFindingsCount
        {
            get { return this._totalFindingsCount; }
            set { this._totalFindingsCount = value; }
        }

        // Check to see if TotalFindingsCount property is set
        internal bool IsSetTotalFindingsCount()
        {
            return this._totalFindingsCount.HasValue; 
        }

    }
}