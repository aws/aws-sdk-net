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

namespace Amazon.LaunchWizard.Model
{
    /// <summary>
    /// Describes workload data.
    /// </summary>
    public partial class WorkloadDataSummary
    {
        /// <summary>
        /// Gets and sets the property AccountConstraints. Optional list of constraints describing
        /// what kind of AWS account is allowed to deploy this workload or deployment pattern.
        /// Within a single list the semantics are OR: an account satisfies the list if it satisfies
        /// any entry. Workload-level and pattern-level lists combine with AND at deployment time.
        /// An absent or empty list at this level means no constraint at this level.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 10)]
        public List<AccountConstraint> AccountConstraints { get; set; } = AWSConfigs.InitializeCollections ? new List<AccountConstraint>() : null;

        /// <summary>
        /// Checks to see if the AccountConstraints property is set.
        /// </summary>
        internal bool IsSetAccountConstraints() => this.AccountConstraints != null && (this.AccountConstraints.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// The display name of the workload data.
        /// </para>
        /// </summary>
        public string DisplayName { get; set; }

        /// <summary>
        /// Checks to see if the DisplayName property is set.
        /// </summary>
        internal bool IsSetDisplayName() => this.DisplayName != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the workload.
        /// </para>
        /// </summary>
        public WorkloadStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property WorkloadName. 
        /// <para>
        /// The name of the workload.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string WorkloadName { get; set; }

        /// <summary>
        /// Checks to see if the WorkloadName property is set.
        /// </summary>
        internal bool IsSetWorkloadName() => this.WorkloadName != null;
    }
}
