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
    /// The updated session action information as it relates to completion and progress of
    /// the session.
    /// </summary>
    public partial class UpdatedSessionActionInfo
    {
        /// <summary>
        /// Gets and sets the property CompletedStatus. The status of the session upon completion.
        /// </summary>
        public CompletedStatus CompletedStatus { get; set; }

        /// <summary>
        /// Checks to see if the CompletedStatus property is set.
        /// </summary>
        internal bool IsSetCompletedStatus() => this.CompletedStatus != null;

        /// <summary>
        /// Gets and sets the property EndedAt. The date and time the resource ended running.
        /// </summary>
        public DateTime? EndedAt { get; set; }

        /// <summary>
        /// Checks to see if the EndedAt property is set.
        /// </summary>
        internal bool IsSetEndedAt() => this.EndedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Manifests. A list of output manifest properties reported
        /// by the worker agent, with each entry corresponding to a manifest property in the job.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 10)]
        public List<TaskRunManifestPropertiesRequest> Manifests { get; set; } = AWSConfigs.InitializeCollections ? new List<TaskRunManifestPropertiesRequest>() : null;

        /// <summary>
        /// Checks to see if the Manifests property is set.
        /// </summary>
        internal bool IsSetManifests() => this.Manifests != null && (this.Manifests.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ProcessExitCode. The process exit code. The default Deadline
        /// Cloud worker agent converts unsigned 32-bit exit codes to signed 32-bit exit codes.
        /// </summary>
        [AWSProperty(Min = -2147483648, Max = 2147483647)]
        public int? ProcessExitCode { get; set; }

        /// <summary>
        /// Checks to see if the ProcessExitCode property is set.
        /// </summary>
        internal bool IsSetProcessExitCode() => this.ProcessExitCode.HasValue;

        /// <summary>
        /// Gets and sets the property ProgressMessage. A message to indicate the progress of
        /// the updated session action.
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 4096)]
        public string ProgressMessage { get; set; }

        /// <summary>
        /// Checks to see if the ProgressMessage property is set.
        /// </summary>
        internal bool IsSetProgressMessage() => this.ProgressMessage != null;

        /// <summary>
        /// Gets and sets the property ProgressPercent. The percentage completed.
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public float? ProgressPercent { get; set; }

        /// <summary>
        /// Checks to see if the ProgressPercent property is set.
        /// </summary>
        internal bool IsSetProgressPercent() => this.ProgressPercent.HasValue;

        /// <summary>
        /// Gets and sets the property StartedAt. The date and time the resource started running.
        /// </summary>
        public DateTime? StartedAt { get; set; }

        /// <summary>
        /// Checks to see if the StartedAt property is set.
        /// </summary>
        internal bool IsSetStartedAt() => this.StartedAt.HasValue;

        /// <summary>
        /// Gets and sets the property UpdatedAt. The updated time.
        /// </summary>
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;
    }
}
