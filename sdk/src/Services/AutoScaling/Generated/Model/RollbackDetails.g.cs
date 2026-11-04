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

namespace Amazon.AutoScaling.Model
{
    /// <summary>
    /// Details about an instance refresh rollback.
    /// </summary>
    public partial class RollbackDetails
    {
        /// <summary>
        /// Gets and sets the property InstancesToUpdateOnRollback. 
        /// <para>
        /// Indicates the value of <c>InstancesToUpdate</c> at the time the rollback started.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? InstancesToUpdateOnRollback { get; set; }

        /// <summary>
        /// Checks to see if the InstancesToUpdateOnRollback property is set.
        /// </summary>
        internal bool IsSetInstancesToUpdateOnRollback() => this.InstancesToUpdateOnRollback.HasValue;

        /// <summary>
        /// Gets and sets the property PercentageCompleteOnRollback. 
        /// <para>
        /// Indicates the value of <c>PercentageComplete</c> at the time the rollback started.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public int? PercentageCompleteOnRollback { get; set; }

        /// <summary>
        /// Checks to see if the PercentageCompleteOnRollback property is set.
        /// </summary>
        internal bool IsSetPercentageCompleteOnRollback() => this.PercentageCompleteOnRollback.HasValue;

        /// <summary>
        /// Gets and sets the property ProgressDetailsOnRollback. 
        /// <para>
        /// Reports progress on replacing instances in an Auto Scaling group that has a warm pool.
        /// This includes separate details for instances in the warm pool and instances in the
        /// Auto Scaling group (the live pool).
        /// </para>
        /// </summary>
        public InstanceRefreshProgressDetails ProgressDetailsOnRollback { get; set; }

        /// <summary>
        /// Checks to see if the ProgressDetailsOnRollback property is set.
        /// </summary>
        internal bool IsSetProgressDetailsOnRollback() => this.ProgressDetailsOnRollback != null;

        /// <summary>
        /// Gets and sets the property RollbackReason. 
        /// <para>
        /// The reason for this instance refresh rollback (for example, whether a manual or automatic
        /// rollback was initiated).
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1023)]
        public string RollbackReason { get; set; }

        /// <summary>
        /// Checks to see if the RollbackReason property is set.
        /// </summary>
        internal bool IsSetRollbackReason() => this.RollbackReason != null;

        /// <summary>
        /// Gets and sets the property RollbackStartTime. 
        /// <para>
        /// The date and time at which the rollback began.
        /// </para>
        /// </summary>
        public DateTime? RollbackStartTime { get; set; }

        /// <summary>
        /// Checks to see if the RollbackStartTime property is set.
        /// </summary>
        internal bool IsSetRollbackStartTime() => this.RollbackStartTime.HasValue;
    }
}
