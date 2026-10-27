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

namespace Amazon.CodeBuild.Model
{
    /// <summary>
    /// Contains information about the sandbox phase.
    /// </summary>
    public partial class SandboxSessionPhase
    {
        /// <summary>
        /// Gets and sets the property Contexts. 
        /// <para>
        ///  An array of <c>PhaseContext</c> objects. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<PhaseContext> Contexts { get; set; } = AWSConfigs.InitializeCollections ? new List<PhaseContext>() : null;

        /// <summary>
        /// Checks to see if the Contexts property is set.
        /// </summary>
        internal bool IsSetContexts() => this.Contexts != null && (this.Contexts.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property DurationInSeconds. 
        /// <para>
        /// How long, in seconds, between the starting and ending times of the sandbox's phase.
        /// </para>
        /// </summary>
        public long? DurationInSeconds { get; set; }

        /// <summary>
        /// Checks to see if the DurationInSeconds property is set.
        /// </summary>
        internal bool IsSetDurationInSeconds() => this.DurationInSeconds.HasValue;

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// When the sandbox phase ended, expressed in Unix time format.
        /// </para>
        /// </summary>
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// Checks to see if the EndTime property is set.
        /// </summary>
        internal bool IsSetEndTime() => this.EndTime.HasValue;

        /// <summary>
        /// Gets and sets the property PhaseStatus. 
        /// <para>
        /// The current status of the sandbox phase. Valid values include:
        /// </para>
        ///  <dl> <dt>FAILED</dt> <dd> 
        /// <para>
        /// The sandbox phase failed.
        /// </para>
        ///  </dd> <dt>FAULT</dt> <dd> 
        /// <para>
        /// The sandbox phase faulted.
        /// </para>
        ///  </dd> <dt>IN_PROGRESS</dt> <dd> 
        /// <para>
        /// The sandbox phase is still in progress.
        /// </para>
        ///  </dd> <dt>STOPPED</dt> <dd> 
        /// <para>
        /// The sandbox phase stopped.
        /// </para>
        ///  </dd> <dt>SUCCEEDED</dt> <dd> 
        /// <para>
        /// The sandbox phase succeeded.
        /// </para>
        ///  </dd> <dt>TIMED_OUT</dt> <dd> 
        /// <para>
        /// The sandbox phase timed out.
        /// </para>
        ///  </dd> </dl>
        /// </summary>
        public StatusType PhaseStatus { get; set; }

        /// <summary>
        /// Checks to see if the PhaseStatus property is set.
        /// </summary>
        internal bool IsSetPhaseStatus() => this.PhaseStatus != null;

        /// <summary>
        /// Gets and sets the property PhaseType. 
        /// <para>
        /// The name of the sandbox phase.
        /// </para>
        /// </summary>
        public string PhaseType { get; set; }

        /// <summary>
        /// Checks to see if the PhaseType property is set.
        /// </summary>
        internal bool IsSetPhaseType() => this.PhaseType != null;

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// When the sandbox phase started, expressed in Unix time format.
        /// </para>
        /// </summary>
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// Checks to see if the StartTime property is set.
        /// </summary>
        internal bool IsSetStartTime() => this.StartTime.HasValue;
    }
}
