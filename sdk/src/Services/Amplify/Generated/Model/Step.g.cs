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

namespace Amazon.Amplify.Model
{
    /// <summary>
    /// Describes an execution step, for an execution job, for an Amplify app.
    /// </summary>
    public partial class Step
    {
        /// <summary>
        /// Gets and sets the property ArtifactsUrl. 
        /// <para>
        ///  The URL to the build artifact for the execution step. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1000)]
        public string ArtifactsUrl { get; set; }

        /// <summary>
        /// Checks to see if the ArtifactsUrl property is set.
        /// </summary>
        internal bool IsSetArtifactsUrl() => this.ArtifactsUrl != null;

        /// <summary>
        /// Gets and sets the property Context. 
        /// <para>
        ///  The context for the current step. Includes a build image if the step is build. 
        /// </para>
        /// </summary>
        public string Context { get; set; }

        /// <summary>
        /// Checks to see if the Context property is set.
        /// </summary>
        internal bool IsSetContext() => this.Context != null;

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        ///  The end date and time of the execution step. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// Checks to see if the EndTime property is set.
        /// </summary>
        internal bool IsSetEndTime() => this.EndTime.HasValue;

        /// <summary>
        /// Gets and sets the property LogUrl. 
        /// <para>
        ///  The URL to the logs for the execution step. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1000)]
        public string LogUrl { get; set; }

        /// <summary>
        /// Checks to see if the LogUrl property is set.
        /// </summary>
        internal bool IsSetLogUrl() => this.LogUrl != null;

        /// <summary>
        /// Gets and sets the property Screenshots. 
        /// <para>
        ///  The list of screenshot URLs for the execution step, if relevant. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Screenshots { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Screenshots property is set.
        /// </summary>
        internal bool IsSetScreenshots() => this.Screenshots != null && (this.Screenshots.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        ///  The start date and time of the execution step. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// Checks to see if the StartTime property is set.
        /// </summary>
        internal bool IsSetStartTime() => this.StartTime.HasValue;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        ///  The status of the execution step. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public JobStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StatusReason. 
        /// <para>
        ///  The reason for the current step status. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1000)]
        public string StatusReason { get; set; }

        /// <summary>
        /// Checks to see if the StatusReason property is set.
        /// </summary>
        internal bool IsSetStatusReason() => this.StatusReason != null;

        /// <summary>
        /// Gets and sets the property StepName. 
        /// <para>
        ///  The name of the execution step. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 255)]
        public string StepName { get; set; }

        /// <summary>
        /// Checks to see if the StepName property is set.
        /// </summary>
        internal bool IsSetStepName() => this.StepName != null;

        /// <summary>
        /// Gets and sets the property TestArtifactsUrl. 
        /// <para>
        ///  The URL to the test artifact for the execution step. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1000)]
        public string TestArtifactsUrl { get; set; }

        /// <summary>
        /// Checks to see if the TestArtifactsUrl property is set.
        /// </summary>
        internal bool IsSetTestArtifactsUrl() => this.TestArtifactsUrl != null;

        /// <summary>
        /// Gets and sets the property TestConfigUrl. 
        /// <para>
        ///  The URL to the test configuration for the execution step. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1000)]
        public string TestConfigUrl { get; set; }

        /// <summary>
        /// Checks to see if the TestConfigUrl property is set.
        /// </summary>
        internal bool IsSetTestConfigUrl() => this.TestConfigUrl != null;
    }
}
