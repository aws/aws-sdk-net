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

namespace Amazon.EMRServerless.Model
{
    /// <summary>
    /// Information about a session, including the session state, configuration, and timestamps.
    /// </summary>
    public partial class Session
    {
        /// <summary>
        /// Gets and sets the property ApplicationId. 
        /// <para>
        /// The ID of the application that the session belongs to.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string ApplicationId { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationId property is set.
        /// </summary>
        internal bool IsSetApplicationId() => this.ApplicationId != null;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the session.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 60, Max = 1024)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property BilledResourceUtilization. 
        /// <para>
        /// The aggregate vCPU, memory, and storage that Amazon Web Services has billed for the
        /// session. The billed resources include a 1-minute minimum usage for workers, plus additional
        /// storage over 20 GB per worker. Note that billed resources do not include usage for
        /// idle pre-initialized workers.
        /// </para>
        /// </summary>
        public ResourceUtilization BilledResourceUtilization { get; set; }

        /// <summary>
        /// Checks to see if the BilledResourceUtilization property is set.
        /// </summary>
        internal bool IsSetBilledResourceUtilization() => this.BilledResourceUtilization != null;

        /// <summary>
        /// Gets and sets the property ConfigurationOverrides. 
        /// <para>
        /// The configuration overrides for the session, including runtime configuration properties.
        /// </para>
        /// </summary>
        public SessionConfigurationOverrides ConfigurationOverrides { get; set; }

        /// <summary>
        /// Checks to see if the ConfigurationOverrides property is set.
        /// </summary>
        internal bool IsSetConfigurationOverrides() => this.ConfigurationOverrides != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The date and time that the session was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property CreatedBy. 
        /// <para>
        /// The IAM principal that created the session.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 2048)]
        public string CreatedBy { get; set; }

        /// <summary>
        /// Checks to see if the CreatedBy property is set.
        /// </summary>
        internal bool IsSetCreatedBy() => this.CreatedBy != null;

        /// <summary>
        /// Gets and sets the property EndedAt. 
        /// <para>
        /// The date and time that the session was terminated or failed.
        /// </para>
        /// </summary>
        public DateTime? EndedAt { get; set; }

        /// <summary>
        /// Checks to see if the EndedAt property is set.
        /// </summary>
        internal bool IsSetEndedAt() => this.EndedAt.HasValue;

        /// <summary>
        /// Gets and sets the property ExecutionRoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the execution role for the session.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 2048)]
        public string ExecutionRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the ExecutionRoleArn property is set.
        /// </summary>
        internal bool IsSetExecutionRoleArn() => this.ExecutionRoleArn != null;

        /// <summary>
        /// Gets and sets the property IdleSince. 
        /// <para>
        /// The date and time that the session became idle.
        /// </para>
        /// </summary>
        public DateTime? IdleSince { get; set; }

        /// <summary>
        /// Checks to see if the IdleSince property is set.
        /// </summary>
        internal bool IsSetIdleSince() => this.IdleSince.HasValue;

        /// <summary>
        /// Gets and sets the property IdleTimeoutMinutes. 
        /// <para>
        /// The idle timeout in minutes for the session. After the session remains idle for this
        /// duration, it is automatically terminated.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1000000)]
        public long? IdleTimeoutMinutes { get; set; }

        /// <summary>
        /// Checks to see if the IdleTimeoutMinutes property is set.
        /// </summary>
        internal bool IsSetIdleTimeoutMinutes() => this.IdleTimeoutMinutes.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The optional name of the session.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property NetworkConfiguration. 
        /// <para>
        /// The network configuration for customer VPC connectivity for the session.
        /// </para>
        /// </summary>
        public NetworkConfiguration NetworkConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the NetworkConfiguration property is set.
        /// </summary>
        internal bool IsSetNetworkConfiguration() => this.NetworkConfiguration != null;

        /// <summary>
        /// Gets and sets the property ReleaseLabel. 
        /// <para>
        /// The Amazon EMR release label associated with the session.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string ReleaseLabel { get; set; }

        /// <summary>
        /// Checks to see if the ReleaseLabel property is set.
        /// </summary>
        internal bool IsSetReleaseLabel() => this.ReleaseLabel != null;

        /// <summary>
        /// Gets and sets the property SessionId. 
        /// <para>
        /// The ID of the session.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string SessionId { get; set; }

        /// <summary>
        /// Checks to see if the SessionId property is set.
        /// </summary>
        internal bool IsSetSessionId() => this.SessionId != null;

        /// <summary>
        /// Gets and sets the property StartedAt. 
        /// <para>
        /// The date and time that the session moved to a running state.
        /// </para>
        /// </summary>
        public DateTime? StartedAt { get; set; }

        /// <summary>
        /// Checks to see if the StartedAt property is set.
        /// </summary>
        internal bool IsSetStartedAt() => this.StartedAt.HasValue;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The state of the session.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public SessionState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;

        /// <summary>
        /// Gets and sets the property StateDetails. 
        /// <para>
        /// Additional details about the current state of the session.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1024)]
        public string StateDetails { get; set; }

        /// <summary>
        /// Checks to see if the StateDetails property is set.
        /// </summary>
        internal bool IsSetStateDetails() => this.StateDetails != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags assigned to the session.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 200)]
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TotalExecutionDurationSeconds. 
        /// <para>
        /// The total execution duration of the session in seconds.
        /// </para>
        /// </summary>
        public long? TotalExecutionDurationSeconds { get; set; }

        /// <summary>
        /// Checks to see if the TotalExecutionDurationSeconds property is set.
        /// </summary>
        internal bool IsSetTotalExecutionDurationSeconds() => this.TotalExecutionDurationSeconds.HasValue;

        /// <summary>
        /// Gets and sets the property TotalResourceUtilization. 
        /// <para>
        /// The aggregate vCPU, memory, and storage resources used from the time the session starts
        /// to execute, until the time the session terminates, rounded up to the nearest second.
        /// </para>
        /// </summary>
        public TotalResourceUtilization TotalResourceUtilization { get; set; }

        /// <summary>
        /// Checks to see if the TotalResourceUtilization property is set.
        /// </summary>
        internal bool IsSetTotalResourceUtilization() => this.TotalResourceUtilization != null;

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The date and time that the session was last updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;
    }
}
