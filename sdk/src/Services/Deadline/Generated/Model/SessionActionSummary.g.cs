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
    /// The details of a session action.
    /// </summary>
    public partial class SessionActionSummary
    {
        /// <summary>
        /// Gets and sets the property Definition. The session action definition.
        /// </summary>
        [AWSProperty(Required = true)]
        public SessionActionDefinitionSummary Definition { get; set; }

        /// <summary>
        /// Checks to see if the Definition property is set.
        /// </summary>
        internal bool IsSetDefinition() => this.Definition != null;

        /// <summary>
        /// Gets and sets the property EndedAt. The date and time the resource ended running.
        /// </summary>
        public DateTime? EndedAt { get; set; }

        /// <summary>
        /// Checks to see if the EndedAt property is set.
        /// </summary>
        internal bool IsSetEndedAt() => this.EndedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Manifests. The list of manifest properties that describe
        /// file attachments for the task run.
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
        /// Gets and sets the property ProgressPercent. The completion percentage for the session
        /// action.
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public float? ProgressPercent { get; set; }

        /// <summary>
        /// Checks to see if the ProgressPercent property is set.
        /// </summary>
        internal bool IsSetProgressPercent() => this.ProgressPercent.HasValue;

        /// <summary>
        /// Gets and sets the property SessionActionId. The session action ID.
        /// </summary>
        [AWSProperty(Required = true)]
        public string SessionActionId { get; set; }

        /// <summary>
        /// Checks to see if the SessionActionId property is set.
        /// </summary>
        internal bool IsSetSessionActionId() => this.SessionActionId != null;

        /// <summary>
        /// Gets and sets the property StartedAt. The date and time the resource started running.
        /// </summary>
        public DateTime? StartedAt { get; set; }

        /// <summary>
        /// Checks to see if the StartedAt property is set.
        /// </summary>
        internal bool IsSetStartedAt() => this.StartedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Status. The status of the session action.
        /// </summary>
        [AWSProperty(Required = true)]
        public SessionActionStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property WorkerUpdatedAt. The Linux timestamp of the last date and
        /// time that the session action was updated.
        /// </summary>
        public DateTime? WorkerUpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the WorkerUpdatedAt property is set.
        /// </summary>
        internal bool IsSetWorkerUpdatedAt() => this.WorkerUpdatedAt.HasValue;
    }
}
