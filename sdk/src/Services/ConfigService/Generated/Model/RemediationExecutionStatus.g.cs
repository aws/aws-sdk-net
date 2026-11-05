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

namespace Amazon.ConfigService.Model
{
    /// <summary>
    /// Provides details of the current status of the invoked remediation action for that
    /// resource.
    /// </summary>
    public partial class RemediationExecutionStatus
    {
        /// <summary>
        /// Gets and sets the property InvocationTime. 
        /// <para>
        /// Start time when the remediation was executed.
        /// </para>
        /// </summary>
        public DateTime? InvocationTime { get; set; }

        /// <summary>
        /// Checks to see if the InvocationTime property is set.
        /// </summary>
        internal bool IsSetInvocationTime() => this.InvocationTime.HasValue;

        /// <summary>
        /// Gets and sets the property LastUpdatedTime. 
        /// <para>
        /// The time when the remediation execution was last updated.
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedTime { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdatedTime property is set.
        /// </summary>
        internal bool IsSetLastUpdatedTime() => this.LastUpdatedTime.HasValue;

        /// <summary>
        /// Gets and sets the property ResourceKey.
        /// </summary>
        public ResourceKey ResourceKey { get; set; }

        /// <summary>
        /// Checks to see if the ResourceKey property is set.
        /// </summary>
        internal bool IsSetResourceKey() => this.ResourceKey != null;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// ENUM of the values.
        /// </para>
        /// </summary>
        public RemediationExecutionState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;

        /// <summary>
        /// Gets and sets the property StepDetails. 
        /// <para>
        /// Details of every step.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<RemediationExecutionStep> StepDetails { get; set; } = AWSConfigs.InitializeCollections ? new List<RemediationExecutionStep>() : null;

        /// <summary>
        /// Checks to see if the StepDetails property is set.
        /// </summary>
        internal bool IsSetStepDetails() => this.StepDetails != null && (this.StepDetails.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
