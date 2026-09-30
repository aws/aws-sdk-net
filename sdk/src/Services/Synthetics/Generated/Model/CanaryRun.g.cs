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

namespace Amazon.Synthetics.Model
{
    /// <summary>
    /// This structure contains the details about one run of one canary.
    /// </summary>
    public partial class CanaryRun
    {
        /// <summary>
        /// Gets and sets the property ArtifactS3Location. 
        /// <para>
        /// The location where the canary stored artifacts from the run. Artifacts include the
        /// log file, screenshots, and HAR files.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string ArtifactS3Location { get; set; }

        /// <summary>
        /// Checks to see if the ArtifactS3Location property is set.
        /// </summary>
        internal bool IsSetArtifactS3Location() => this.ArtifactS3Location != null;

        /// <summary>
        /// Gets and sets the property BrowserType. 
        /// <para>
        /// The browser type associated with this canary run.
        /// </para>
        /// </summary>
        public BrowserType BrowserType { get; set; }

        /// <summary>
        /// Checks to see if the BrowserType property is set.
        /// </summary>
        internal bool IsSetBrowserType() => this.BrowserType != null;

        /// <summary>
        /// Gets and sets the property DryRunConfig. 
        /// <para>
        /// Returns the dry run configurations for a canary.
        /// </para>
        /// </summary>
        public CanaryDryRunConfigOutput DryRunConfig { get; set; }

        /// <summary>
        /// Checks to see if the DryRunConfig property is set.
        /// </summary>
        internal bool IsSetDryRunConfig() => this.DryRunConfig != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// A unique ID that identifies this canary run.
        /// </para>
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property Location. 
        /// <para>
        /// The Amazon Web Services Region where this canary run was executed.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 20)]
        public string Location { get; set; }

        /// <summary>
        /// Checks to see if the Location property is set.
        /// </summary>
        internal bool IsSetLocation() => this.Location != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the canary.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property RetryAttempt. 
        /// <para>
        /// The count in number of the retry attempt.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2)]
        public int? RetryAttempt { get; set; }

        /// <summary>
        /// Checks to see if the RetryAttempt property is set.
        /// </summary>
        internal bool IsSetRetryAttempt() => this.RetryAttempt.HasValue;

        /// <summary>
        /// Gets and sets the property ScheduledRunId. 
        /// <para>
        /// The ID of the scheduled canary run.
        /// </para>
        /// </summary>
        public string ScheduledRunId { get; set; }

        /// <summary>
        /// Checks to see if the ScheduledRunId property is set.
        /// </summary>
        internal bool IsSetScheduledRunId() => this.ScheduledRunId != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of this run.
        /// </para>
        /// </summary>
        public CanaryRunStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property Timeline. 
        /// <para>
        /// A structure that contains the start and end times of this run.
        /// </para>
        /// </summary>
        public CanaryRunTimeline Timeline { get; set; }

        /// <summary>
        /// Checks to see if the Timeline property is set.
        /// </summary>
        internal bool IsSetTimeline() => this.Timeline != null;
    }
}
