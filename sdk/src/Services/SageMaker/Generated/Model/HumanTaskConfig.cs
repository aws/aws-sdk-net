/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Information required for human workers to complete a labeling task.
    /// </summary>
    public partial class HumanTaskConfig
    {
        private AnnotationConsolidationConfig _annotationConsolidationConfig;
        private int? _maxConcurrentTaskCount;
        private int? _numberOfHumanWorkersPerDataObject;
        private string _preHumanTaskLambdaArn;
        private PublicWorkforceTaskPrice _publicWorkforceTaskPrice;
        private int? _taskAvailabilityLifetimeInSeconds;
        private string _taskDescription;
        private List<string> _taskKeywords = new List<string>();
        private int? _taskTimeLimitInSeconds;
        private string _taskTitle;
        private UiConfig _uiConfig;
        private string _workteamArn;

        /// <summary>
        /// Gets and sets the property AnnotationConsolidationConfig. 
        /// <para>
        /// Configures how labels are consolidated across human workers.
        /// </para>
        /// </summary>
        public AnnotationConsolidationConfig AnnotationConsolidationConfig
        {
            get { return this._annotationConsolidationConfig; }
            set { this._annotationConsolidationConfig = value; }
        }

        // Check to see if AnnotationConsolidationConfig property is set
        internal bool IsSetAnnotationConsolidationConfig()
        {
            return this._annotationConsolidationConfig != null;
        }

        /// <summary>
        /// Gets and sets the property MaxConcurrentTaskCount. 
        /// <para>
        /// Defines the maximum number of data objects that can be labeled by human workers at
        /// the same time. Each object may have more than one worker at one time.
        /// </para>
        /// </summary>
        public int MaxConcurrentTaskCount
        {
            get { return this._maxConcurrentTaskCount.GetValueOrDefault(); }
            set { this._maxConcurrentTaskCount = value; }
        }

        // Check to see if MaxConcurrentTaskCount property is set
        internal bool IsSetMaxConcurrentTaskCount()
        {
            return this._maxConcurrentTaskCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NumberOfHumanWorkersPerDataObject. 
        /// <para>
        /// The number of human workers that will label an object. 
        /// </para>
        /// </summary>
        public int NumberOfHumanWorkersPerDataObject
        {
            get { return this._numberOfHumanWorkersPerDataObject.GetValueOrDefault(); }
            set { this._numberOfHumanWorkersPerDataObject = value; }
        }

        // Check to see if NumberOfHumanWorkersPerDataObject property is set
        internal bool IsSetNumberOfHumanWorkersPerDataObject()
        {
            return this._numberOfHumanWorkersPerDataObject.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PreHumanTaskLambdaArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of a Lambda function that is run before a data object
        /// is sent to a human worker. Use this function to provide input to a custom labeling
        /// job.
        /// </para>
        /// </summary>
        public string PreHumanTaskLambdaArn
        {
            get { return this._preHumanTaskLambdaArn; }
            set { this._preHumanTaskLambdaArn = value; }
        }

        // Check to see if PreHumanTaskLambdaArn property is set
        internal bool IsSetPreHumanTaskLambdaArn()
        {
            return this._preHumanTaskLambdaArn != null;
        }

        /// <summary>
        /// Gets and sets the property PublicWorkforceTaskPrice. 
        /// <para>
        /// The price that you pay for each task performed by a public worker.
        /// </para>
        /// </summary>
        public PublicWorkforceTaskPrice PublicWorkforceTaskPrice
        {
            get { return this._publicWorkforceTaskPrice; }
            set { this._publicWorkforceTaskPrice = value; }
        }

        // Check to see if PublicWorkforceTaskPrice property is set
        internal bool IsSetPublicWorkforceTaskPrice()
        {
            return this._publicWorkforceTaskPrice != null;
        }

        /// <summary>
        /// Gets and sets the property TaskAvailabilityLifetimeInSeconds. 
        /// <para>
        /// The length of time that a task remains available for labelling by human workers.
        /// </para>
        /// </summary>
        public int TaskAvailabilityLifetimeInSeconds
        {
            get { return this._taskAvailabilityLifetimeInSeconds.GetValueOrDefault(); }
            set { this._taskAvailabilityLifetimeInSeconds = value; }
        }

        // Check to see if TaskAvailabilityLifetimeInSeconds property is set
        internal bool IsSetTaskAvailabilityLifetimeInSeconds()
        {
            return this._taskAvailabilityLifetimeInSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TaskDescription. 
        /// <para>
        /// A description of the task for your human workers.
        /// </para>
        /// </summary>
        public string TaskDescription
        {
            get { return this._taskDescription; }
            set { this._taskDescription = value; }
        }

        // Check to see if TaskDescription property is set
        internal bool IsSetTaskDescription()
        {
            return this._taskDescription != null;
        }

        /// <summary>
        /// Gets and sets the property TaskKeywords. 
        /// <para>
        /// Keywords used to describe the task so that workers on Amazon Mechanical Turk can discover
        /// the task.
        /// </para>
        /// </summary>
        public List<string> TaskKeywords
        {
            get { return this._taskKeywords; }
            set { this._taskKeywords = value; }
        }

        // Check to see if TaskKeywords property is set
        internal bool IsSetTaskKeywords()
        {
            return this._taskKeywords != null && this._taskKeywords.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property TaskTimeLimitInSeconds. 
        /// <para>
        /// The amount of time that a worker has to complete a task.
        /// </para>
        /// </summary>
        public int TaskTimeLimitInSeconds
        {
            get { return this._taskTimeLimitInSeconds.GetValueOrDefault(); }
            set { this._taskTimeLimitInSeconds = value; }
        }

        // Check to see if TaskTimeLimitInSeconds property is set
        internal bool IsSetTaskTimeLimitInSeconds()
        {
            return this._taskTimeLimitInSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TaskTitle. 
        /// <para>
        /// A title for the task for your human workers.
        /// </para>
        /// </summary>
        public string TaskTitle
        {
            get { return this._taskTitle; }
            set { this._taskTitle = value; }
        }

        // Check to see if TaskTitle property is set
        internal bool IsSetTaskTitle()
        {
            return this._taskTitle != null;
        }

        /// <summary>
        /// Gets and sets the property UiConfig. 
        /// <para>
        /// Information about the user interface that workers use to complete the labeling task.
        /// </para>
        /// </summary>
        public UiConfig UiConfig
        {
            get { return this._uiConfig; }
            set { this._uiConfig = value; }
        }

        // Check to see if UiConfig property is set
        internal bool IsSetUiConfig()
        {
            return this._uiConfig != null;
        }

        /// <summary>
        /// Gets and sets the property WorkteamArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the work team assigned to complete the tasks.
        /// </para>
        /// </summary>
        public string WorkteamArn
        {
            get { return this._workteamArn; }
            set { this._workteamArn = value; }
        }

        // Check to see if WorkteamArn property is set
        internal bool IsSetWorkteamArn()
        {
            return this._workteamArn != null;
        }

    }
}