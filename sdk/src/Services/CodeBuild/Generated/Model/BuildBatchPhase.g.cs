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
    /// Contains information about a stage for a batch build.
    /// </summary>
    public partial class BuildBatchPhase
    {
        /// <summary>
        /// Gets and sets the property Contexts. 
        /// <para>
        /// Additional information about the batch build phase. Especially to help troubleshoot
        /// a failed batch build.
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
        /// How long, in seconds, between the starting and ending times of the batch build's phase.
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
        /// When the batch build phase ended, expressed in Unix time format.
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
        /// The current status of the batch build phase. Valid values include:
        /// </para>
        ///  <dl> <dt>FAILED</dt> <dd> 
        /// <para>
        /// The build phase failed.
        /// </para>
        ///  </dd> <dt>FAULT</dt> <dd> 
        /// <para>
        /// The build phase faulted.
        /// </para>
        ///  </dd> <dt>IN_PROGRESS</dt> <dd> 
        /// <para>
        /// The build phase is still in progress.
        /// </para>
        ///  </dd> <dt>STOPPED</dt> <dd> 
        /// <para>
        /// The build phase stopped.
        /// </para>
        ///  </dd> <dt>SUCCEEDED</dt> <dd> 
        /// <para>
        /// The build phase succeeded.
        /// </para>
        ///  </dd> <dt>TIMED_OUT</dt> <dd> 
        /// <para>
        /// The build phase timed out.
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
        /// The name of the batch build phase. Valid values include:
        /// </para>
        ///  <dl> <dt>COMBINE_ARTIFACTS</dt> <dd> 
        /// <para>
        /// Build output artifacts are being combined and uploaded to the output location.
        /// </para>
        ///  </dd> <dt>DOWNLOAD_BATCHSPEC</dt> <dd> 
        /// <para>
        /// The batch build specification is being downloaded.
        /// </para>
        ///  </dd> <dt>FAILED</dt> <dd> 
        /// <para>
        /// One or more of the builds failed.
        /// </para>
        ///  </dd> <dt>IN_PROGRESS</dt> <dd> 
        /// <para>
        /// The batch build is in progress.
        /// </para>
        ///  </dd> <dt>STOPPED</dt> <dd> 
        /// <para>
        /// The batch build was stopped.
        /// </para>
        ///  </dd> <dt>SUBMITTED</dt> <dd> 
        /// <para>
        /// The btach build has been submitted.
        /// </para>
        ///  </dd> <dt>SUCCEEDED</dt> <dd> 
        /// <para>
        /// The batch build succeeded.
        /// </para>
        ///  </dd> </dl>
        /// </summary>
        public BuildBatchPhaseType PhaseType { get; set; }

        /// <summary>
        /// Checks to see if the PhaseType property is set.
        /// </summary>
        internal bool IsSetPhaseType() => this.PhaseType != null;

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// When the batch build phase started, expressed in Unix time format.
        /// </para>
        /// </summary>
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// Checks to see if the StartTime property is set.
        /// </summary>
        internal bool IsSetStartTime() => this.StartTime.HasValue;
    }
}
