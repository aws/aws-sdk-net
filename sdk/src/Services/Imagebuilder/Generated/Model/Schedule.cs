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
 * Do not modify this file. This file is generated from the imagebuilder-2019-12-02.normal.json service model.
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
namespace Amazon.Imagebuilder.Model
{
    /// <summary>
    /// A schedule configures when and how often a pipeline will automatically create a new
    /// image.
    /// </summary>
    public partial class Schedule
    {
        private AutoDisablePolicy _autoDisablePolicy;
        private PipelineExecutionStartCondition _pipelineExecutionStartCondition;
        private string _scheduleExpression;
        private string _timezone;

        /// <summary>
        /// Gets and sets the property AutoDisablePolicy. 
        /// <para>
        /// The policy that configures when Image Builder should automatically disable a pipeline
        /// that is failing.
        /// </para>
        /// </summary>
        public AutoDisablePolicy AutoDisablePolicy
        {
            get { return this._autoDisablePolicy; }
            set { this._autoDisablePolicy = value; }
        }

        // Check to see if AutoDisablePolicy property is set
        internal bool IsSetAutoDisablePolicy()
        {
            return this._autoDisablePolicy != null;
        }

        /// <summary>
        /// Gets and sets the property PipelineExecutionStartCondition. 
        /// <para>
        /// The start condition configures when the pipeline should trigger a new image build,
        /// as follows. If no value is set Image Builder defaults to <c>EXPRESSION_MATCH_AND_DEPENDENCY_UPDATES_AVAILABLE</c>.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>EXPRESSION_MATCH_AND_DEPENDENCY_UPDATES_AVAILABLE</c> (default) – When you use
        /// semantic version filters on the base image or components in your image recipe, EC2
        /// Image Builder builds a new image only when there are new versions of the base image
        /// or components in your recipe that match the filter.
        /// </para>
        ///  <note> 
        /// <para>
        /// For semantic version syntax, see <a href="https://docs.aws.amazon.com/imagebuilder/latest/APIReference/API_CreateComponent.html">CreateComponent</a>.
        /// </para>
        ///  </note> </li> <li> 
        /// <para>
        ///  <c>EXPRESSION_MATCH_ONLY</c> – This condition builds a new image every time the CRON
        /// expression matches the current time.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public PipelineExecutionStartCondition PipelineExecutionStartCondition
        {
            get { return this._pipelineExecutionStartCondition; }
            set { this._pipelineExecutionStartCondition = value; }
        }

        // Check to see if PipelineExecutionStartCondition property is set
        internal bool IsSetPipelineExecutionStartCondition()
        {
            return this._pipelineExecutionStartCondition != null;
        }

        /// <summary>
        /// Gets and sets the property ScheduleExpression. 
        /// <para>
        /// The cron expression determines how often EC2 Image Builder evaluates your <c>pipelineExecutionStartCondition</c>.
        /// </para>
        ///  
        /// <para>
        /// For information on how to format a cron expression in Image Builder, see <a href="https://docs.aws.amazon.com/imagebuilder/latest/userguide/image-builder-cron.html">Use
        /// cron expressions in EC2 Image Builder</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string ScheduleExpression
        {
            get { return this._scheduleExpression; }
            set { this._scheduleExpression = value; }
        }

        // Check to see if ScheduleExpression property is set
        internal bool IsSetScheduleExpression()
        {
            return this._scheduleExpression != null;
        }

        /// <summary>
        /// Gets and sets the property Timezone. 
        /// <para>
        /// The timezone that applies to the scheduling expression. For example, "Etc/UTC", "America/Los_Angeles"
        /// in the <a href="https://www.joda.org/joda-time/timezones.html">IANA timezone format</a>.
        /// If not specified this defaults to UTC.
        /// </para>
        /// </summary>
        [AWSProperty(Min=3, Max=100)]
        public string Timezone
        {
            get { return this._timezone; }
            set { this._timezone = value; }
        }

        // Check to see if Timezone property is set
        internal bool IsSetTimezone()
        {
            return this._timezone != null;
        }

    }
}