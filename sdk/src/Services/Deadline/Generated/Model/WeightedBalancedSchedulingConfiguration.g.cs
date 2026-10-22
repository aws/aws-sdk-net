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
    /// Configuration for weighted balanced scheduling. Workers are assigned to jobs based
    /// on a weighted formula:
    /// 
    ///  
    /// <para>
    ///  <c>weight = (priority * priorityWeight) + (errors * errorWeight) + ((currentTime
    /// - submissionTime) * submissionTimeWeight) + ((renderingTasks - renderingTaskBuffer)
    /// * renderingTaskWeight)</c> 
    /// </para>
    ///  
    /// <para>
    /// The job with the highest calculated weight is scheduled first. Workers are distributed
    /// evenly amongst jobs with the same weight.
    /// </para>
    /// </summary>
    public partial class WeightedBalancedSchedulingConfiguration
    {
        /// <summary>
        /// Gets and sets the property ErrorWeight. 
        /// <para>
        /// The weight applied to the number of errors on a job. A negative value means jobs without
        /// errors are scheduled first. A value of <c>0</c> means errors are ignored. The default
        /// value is <c>-10.0</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = -10000, Max = 10000)]
        public double? ErrorWeight { get; set; }

        /// <summary>
        /// Checks to see if the ErrorWeight property is set.
        /// </summary>
        internal bool IsSetErrorWeight() => this.ErrorWeight.HasValue;

        /// <summary>
        /// Gets and sets the property MaxPriorityOverride. 
        /// <para>
        /// Overrides the weighted scheduling formula for jobs at the maximum priority (100).
        /// When set, jobs with priority 100 are always scheduled first regardless of their calculated
        /// weight. When absent, maximum priority jobs use the standard weighted formula.
        /// </para>
        /// </summary>
        public SchedulingMaxPriorityOverride MaxPriorityOverride { get; set; }

        /// <summary>
        /// Checks to see if the MaxPriorityOverride property is set.
        /// </summary>
        internal bool IsSetMaxPriorityOverride() => this.MaxPriorityOverride != null;

        /// <summary>
        /// Gets and sets the property MinPriorityOverride. 
        /// <para>
        /// Overrides the weighted scheduling formula for jobs at the minimum priority (0). When
        /// set, jobs with priority 0 are always scheduled last regardless of their calculated
        /// weight. When absent, minimum priority jobs use the standard weighted formula.
        /// </para>
        /// </summary>
        public SchedulingMinPriorityOverride MinPriorityOverride { get; set; }

        /// <summary>
        /// Checks to see if the MinPriorityOverride property is set.
        /// </summary>
        internal bool IsSetMinPriorityOverride() => this.MinPriorityOverride != null;

        /// <summary>
        /// Gets and sets the property PriorityWeight. 
        /// <para>
        /// The weight applied to job priority in the scheduling formula. Higher values give more
        /// influence to job priority. A value of <c>0</c> means priority is ignored. The default
        /// value is <c>100.0</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 10000)]
        public double? PriorityWeight { get; set; }

        /// <summary>
        /// Checks to see if the PriorityWeight property is set.
        /// </summary>
        internal bool IsSetPriorityWeight() => this.PriorityWeight.HasValue;

        /// <summary>
        /// Gets and sets the property RenderingTaskBuffer. 
        /// <para>
        /// The rendering task buffer is subtracted from the number of rendering tasks before
        /// applying the rendering task weight. This creates a stickiness effect where workers
        /// prefer to stay with their current job. Higher values make workers stickier. The default
        /// value is <c>1</c>. The buffer is only applied in the weight calculation for a job
        /// if the worker is currently assigned to that job.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1000)]
        public int? RenderingTaskBuffer { get; set; }

        /// <summary>
        /// Checks to see if the RenderingTaskBuffer property is set.
        /// </summary>
        internal bool IsSetRenderingTaskBuffer() => this.RenderingTaskBuffer.HasValue;

        /// <summary>
        /// Gets and sets the property RenderingTaskWeight. 
        /// <para>
        /// The weight applied to the number of tasks currently rendering on a job. A negative
        /// value means jobs that are not already rendering are scheduled next. A value of <c>0</c>
        /// means the rendering state is ignored. The default value is <c>-100.0</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = -10000, Max = 10000)]
        public double? RenderingTaskWeight { get; set; }

        /// <summary>
        /// Checks to see if the RenderingTaskWeight property is set.
        /// </summary>
        internal bool IsSetRenderingTaskWeight() => this.RenderingTaskWeight.HasValue;

        /// <summary>
        /// Gets and sets the property SubmissionTimeWeight. 
        /// <para>
        /// The weight applied to job submission time. A positive value means earlier jobs are
        /// scheduled first. A value of <c>0</c> means submission time is ignored. The default
        /// value is <c>3.0</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 10000)]
        public double? SubmissionTimeWeight { get; set; }

        /// <summary>
        /// Checks to see if the SubmissionTimeWeight property is set.
        /// </summary>
        internal bool IsSetSubmissionTimeWeight() => this.SubmissionTimeWeight.HasValue;
    }
}
