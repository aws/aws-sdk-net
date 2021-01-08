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

namespace Amazon.Imagebuilder.Model
{
    /// <summary>
    /// A schedule configures how often and when a pipeline will automatically create a new
    /// image.
    /// </summary>
    public partial class Schedule
    {
        private PipelineExecutionStartCondition _pipelineExecutionStartCondition;
        private string _scheduleExpression;

        /// <summary>
        /// Gets and sets the property PipelineExecutionStartCondition. 
        /// <para>
        /// The condition configures when the pipeline should trigger a new image build. When
        /// the <code>pipelineExecutionStartCondition</code> is set to <code>EXPRESSION_MATCH_AND_DEPENDENCY_UPDATES_AVAILABLE</code>,
        /// and you use semantic version filters on the source image or components in your image
        /// recipe, EC2 Image Builder will build a new image only when there are new versions
        /// of the image or components in your recipe that match the semantic version filter.
        /// When it is set to <code>EXPRESSION_MATCH_ONLY</code>, it will build a new image every
        /// time the CRON expression matches the current time. For semantic version syntax, see
        /// <a href="https://docs.aws.amazon.com/imagebuilder/latest/APIReference/API_CreateComponent.html">CreateComponent</a>
        /// in the <i> EC2 Image Builder API Reference</i>.
        /// </para>
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
        /// The cron expression determines how often EC2 Image Builder evaluates your <code>pipelineExecutionStartCondition</code>.
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

    }
}