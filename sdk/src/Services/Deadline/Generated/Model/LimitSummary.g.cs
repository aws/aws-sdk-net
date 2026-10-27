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

namespace Amazon.Deadline.Model
{
    /// <summary>
    /// Provides information about a specific limit.
    /// </summary>
    public partial class LimitSummary
    {
        /// <summary>
        /// Gets and sets the property AmountRequirementName. The value that you specify as the
        /// <c>name</c> in the <c>amounts</c> field of the <c>hostRequirements</c> in a step of
        /// a job template to declare the limit requirement.
        /// </summary>
        [AWSProperty(Required = true, Max = 1024)]
        public string AmountRequirementName { get; set; }

        /// <summary>
        /// Checks to see if the AmountRequirementName property is set.
        /// </summary>
        internal bool IsSetAmountRequirementName() => this.AmountRequirementName != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. The Unix timestamp of the date and time that
        /// the limit was created.
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property CreatedBy. The user identifier of the person that created
        /// the limit.
        /// </summary>
        [AWSProperty(Required = true)]
        public string CreatedBy { get; set; }

        /// <summary>
        /// Checks to see if the CreatedBy property is set.
        /// </summary>
        internal bool IsSetCreatedBy() => this.CreatedBy != null;

        /// <summary>
        /// Gets and sets the property CurrentCount. The number of resources from the limit that
        /// are being used by jobs. The result is delayed and may not be the count at the time
        /// that you called the operation.
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 2147483647)]
        public int? CurrentCount { get; set; }

        /// <summary>
        /// Checks to see if the CurrentCount property is set.
        /// </summary>
        internal bool IsSetCurrentCount() => this.CurrentCount.HasValue;

        /// <summary>
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// The name of the limit used in lists to identify the limit.
        /// </para>
        ///  <important> 
        /// <para>
        /// This field can store any content. Escape or encode this content before displaying
        /// it on a webpage or any other system that might interpret the content of this field.
        /// </para>
        ///  </important>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Checks to see if the DisplayName property is set.
        /// </summary>
        internal bool IsSetDisplayName() => this.DisplayName != null;

        /// <summary>
        /// Gets and sets the property FarmId. The unique identifier of the farm that contains
        /// the limit.
        /// </summary>
        [AWSProperty(Required = true)]
        public string FarmId { get; set; }

        /// <summary>
        /// Checks to see if the FarmId property is set.
        /// </summary>
        internal bool IsSetFarmId() => this.FarmId != null;

        /// <summary>
        /// Gets and sets the property LimitId. The unique identifier of the limit.
        /// </summary>
        [AWSProperty(Required = true)]
        public string LimitId { get; set; }

        /// <summary>
        /// Checks to see if the LimitId property is set.
        /// </summary>
        internal bool IsSetLimitId() => this.LimitId != null;

        /// <summary>
        /// Gets and sets the property MaxCount. The maximum number of resources constrained by
        /// this limit. When all of the resources are in use, steps that require the limit won't
        /// be scheduled until the resource is available. The <c>maxValue</c> must not be 0. If
        /// the value is -1, there is no restriction on the number of resources that can be acquired
        /// for this limit.
        /// </summary>
        [AWSProperty(Required = true, Min = -1, Max = 2147483647)]
        public int? MaxCount { get; set; }

        /// <summary>
        /// Checks to see if the MaxCount property is set.
        /// </summary>
        internal bool IsSetMaxCount() => this.MaxCount.HasValue;

        /// <summary>
        /// Gets and sets the property UpdatedAt. The Unix timestamp of the date and time that
        /// the limit was last updated.
        /// </summary>
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property UpdatedBy. The user identifier of the person that last
        /// updated the limit.
        /// </summary>
        public string UpdatedBy { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedBy property is set.
        /// </summary>
        internal bool IsSetUpdatedBy() => this.UpdatedBy != null;
    }
}
