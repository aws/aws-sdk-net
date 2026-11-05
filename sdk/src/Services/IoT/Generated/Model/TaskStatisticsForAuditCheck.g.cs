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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        /// <summary>
        /// Gets and sets the property CanceledFindingsCount. 
        /// <para>
        /// The number of findings to which the mitigation action task was canceled when applied.
        /// </para>
        /// </summary>
        public long? CanceledFindingsCount { get; set; }

        /// <summary>
        /// Checks to see if the CanceledFindingsCount property is set.
        /// </summary>
        internal bool IsSetCanceledFindingsCount() => this.CanceledFindingsCount.HasValue;

        /// <summary>
        /// Gets and sets the property FailedFindingsCount. 
        /// <para>
        /// The number of findings for which at least one of the actions failed when applied.
        /// </para>
        /// </summary>
        public long? FailedFindingsCount { get; set; }

        /// <summary>
        /// Checks to see if the FailedFindingsCount property is set.
        /// </summary>
        internal bool IsSetFailedFindingsCount() => this.FailedFindingsCount.HasValue;

        /// <summary>
        /// Gets and sets the property SkippedFindingsCount. 
        /// <para>
        /// The number of findings skipped because of filter conditions provided in the parameters
        /// to the command.
        /// </para>
        /// </summary>
        public long? SkippedFindingsCount { get; set; }

        /// <summary>
        /// Checks to see if the SkippedFindingsCount property is set.
        /// </summary>
        internal bool IsSetSkippedFindingsCount() => this.SkippedFindingsCount.HasValue;

        /// <summary>
        /// Gets and sets the property SucceededFindingsCount. 
        /// <para>
        /// The number of findings for which all mitigation actions succeeded when applied.
        /// </para>
        /// </summary>
        public long? SucceededFindingsCount { get; set; }

        /// <summary>
        /// Checks to see if the SucceededFindingsCount property is set.
        /// </summary>
        internal bool IsSetSucceededFindingsCount() => this.SucceededFindingsCount.HasValue;

        /// <summary>
        /// Gets and sets the property TotalFindingsCount. 
        /// <para>
        /// The total number of findings to which a task is being applied.
        /// </para>
        /// </summary>
        public long? TotalFindingsCount { get; set; }

        /// <summary>
        /// Checks to see if the TotalFindingsCount property is set.
        /// </summary>
        internal bool IsSetTotalFindingsCount() => this.TotalFindingsCount.HasValue;
    }
}
