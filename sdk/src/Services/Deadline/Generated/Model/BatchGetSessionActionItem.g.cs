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
    /// The details of a session action returned in a batch get operation.
    /// </summary>
    public partial class BatchGetSessionActionItem
    {
        /// <summary>
        /// Gets and sets the property AcquiredLimits. 
        /// <para>
        /// The limits that were acquired for the session action.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AcquiredLimit> AcquiredLimits { get; set; } = AWSConfigs.InitializeCollections ? new List<AcquiredLimit>() : null;

        /// <summary>
        /// Checks to see if the AcquiredLimits property is set.
        /// </summary>
        internal bool IsSetAcquiredLimits() => this.AcquiredLimits != null && (this.AcquiredLimits.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Definition. 
        /// <para>
        /// The session action definition.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public SessionActionDefinition Definition { get; set; }

        /// <summary>
        /// Checks to see if the Definition property is set.
        /// </summary>
        internal bool IsSetDefinition() => this.Definition != null;

        /// <summary>
        /// Gets and sets the property EndedAt. 
        /// <para>
        /// The date and time the resource ended running.
        /// </para>
        /// </summary>
        public DateTime? EndedAt { get; set; }

        /// <summary>
        /// Checks to see if the EndedAt property is set.
        /// </summary>
        internal bool IsSetEndedAt() => this.EndedAt.HasValue;

        /// <summary>
        /// Gets and sets the property FarmId. 
        /// <para>
        /// The farm ID of the session action.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string FarmId { get; set; }

        /// <summary>
        /// Checks to see if the FarmId property is set.
        /// </summary>
        internal bool IsSetFarmId() => this.FarmId != null;

        /// <summary>
        /// Gets and sets the property JobId. 
        /// <para>
        /// The job ID of the session action.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string JobId { get; set; }

        /// <summary>
        /// Checks to see if the JobId property is set.
        /// </summary>
        internal bool IsSetJobId() => this.JobId != null;

        /// <summary>
        /// Gets and sets the property Manifests. 
        /// <para>
        /// The manifests for the session action.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<TaskRunManifestPropertiesResponse> Manifests { get; set; } = AWSConfigs.InitializeCollections ? new List<TaskRunManifestPropertiesResponse>() : null;

        /// <summary>
        /// Checks to see if the Manifests property is set.
        /// </summary>
        internal bool IsSetManifests() => this.Manifests != null && (this.Manifests.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ProcessExitCode. 
        /// <para>
        /// The exit code to apply to the session action.
        /// </para>
        /// </summary>
        [AWSProperty(Min = -2147483648, Max = 2147483647)]
        public int? ProcessExitCode { get; set; }

        /// <summary>
        /// Checks to see if the ProcessExitCode property is set.
        /// </summary>
        internal bool IsSetProcessExitCode() => this.ProcessExitCode.HasValue;

        /// <summary>
        /// Gets and sets the property ProgressMessage. 
        /// <para>
        /// The message that communicates the progress of the session action.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 4096)]
        public string ProgressMessage { get; set; }

        /// <summary>
        /// Checks to see if the ProgressMessage property is set.
        /// </summary>
        internal bool IsSetProgressMessage() => this.ProgressMessage != null;

        /// <summary>
        /// Gets and sets the property ProgressPercent. 
        /// <para>
        /// The completion percentage for the session action.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public float? ProgressPercent { get; set; }

        /// <summary>
        /// Checks to see if the ProgressPercent property is set.
        /// </summary>
        internal bool IsSetProgressPercent() => this.ProgressPercent.HasValue;

        /// <summary>
        /// Gets and sets the property QueueId. 
        /// <para>
        /// The queue ID of the session action.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string QueueId { get; set; }

        /// <summary>
        /// Checks to see if the QueueId property is set.
        /// </summary>
        internal bool IsSetQueueId() => this.QueueId != null;

        /// <summary>
        /// Gets and sets the property SessionActionId. 
        /// <para>
        /// The session action ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string SessionActionId { get; set; }

        /// <summary>
        /// Checks to see if the SessionActionId property is set.
        /// </summary>
        internal bool IsSetSessionActionId() => this.SessionActionId != null;

        /// <summary>
        /// Gets and sets the property SessionId. 
        /// <para>
        /// The session ID for the session action.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string SessionId { get; set; }

        /// <summary>
        /// Checks to see if the SessionId property is set.
        /// </summary>
        internal bool IsSetSessionId() => this.SessionId != null;

        /// <summary>
        /// Gets and sets the property StartedAt. 
        /// <para>
        /// The date and time the resource started running.
        /// </para>
        /// </summary>
        public DateTime? StartedAt { get; set; }

        /// <summary>
        /// Checks to see if the StartedAt property is set.
        /// </summary>
        internal bool IsSetStartedAt() => this.StartedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the session action.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public SessionActionStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property WorkerUpdatedAt. 
        /// <para>
        /// The date and time the resource was updated by a worker.
        /// </para>
        /// </summary>
        public DateTime? WorkerUpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the WorkerUpdatedAt property is set.
        /// </summary>
        internal bool IsSetWorkerUpdatedAt() => this.WorkerUpdatedAt.HasValue;
    }
}
