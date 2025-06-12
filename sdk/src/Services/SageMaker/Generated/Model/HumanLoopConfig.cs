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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
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
namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Describes the work to be performed by human workers.
    /// </summary>
    public partial class HumanLoopConfig
    {
        private string _humanTaskUiArn;
        private PublicWorkforceTaskPrice _publicWorkforceTaskPrice;
        private int? _taskAvailabilityLifetimeInSeconds;
        private int? _taskCount;
        private string _taskDescription;
        private List<string> _taskKeywords = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private int? _taskTimeLimitInSeconds;
        private string _taskTitle;
        private string _workteamArn;

        /// <summary>
        /// Gets and sets the property HumanTaskUiArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the human task user interface.
        /// </para>
        ///  
        /// <para>
        /// You can use standard HTML and Crowd HTML Elements to create a custom worker task template.
        /// You use this template to create a human task UI.
        /// </para>
        ///  
        /// <para>
        /// To learn how to create a custom HTML template, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/a2i-custom-templates.html">Create
        /// Custom Worker Task Template</a>.
        /// </para>
        ///  
        /// <para>
        /// To learn how to create a human task UI, which is a worker task template that can be
        /// used in a flow definition, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/a2i-worker-template-console.html">Create
        /// and Delete a Worker Task Templates</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=1024)]
        public string HumanTaskUiArn
        {
            get { return this._humanTaskUiArn; }
            set { this._humanTaskUiArn = value; }
        }

        // Check to see if HumanTaskUiArn property is set
        internal bool IsSetHumanTaskUiArn()
        {
            return this._humanTaskUiArn != null;
        }

        /// <summary>
        /// Gets and sets the property PublicWorkforceTaskPrice.
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
        /// The length of time that a task remains available for review by human workers.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public int? TaskAvailabilityLifetimeInSeconds
        {
            get { return this._taskAvailabilityLifetimeInSeconds; }
            set { this._taskAvailabilityLifetimeInSeconds = value; }
        }

        // Check to see if TaskAvailabilityLifetimeInSeconds property is set
        internal bool IsSetTaskAvailabilityLifetimeInSeconds()
        {
            return this._taskAvailabilityLifetimeInSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TaskCount. 
        /// <para>
        /// The number of distinct workers who will perform the same task on each object. For
        /// example, if <c>TaskCount</c> is set to <c>3</c> for an image classification labeling
        /// job, three workers will classify each input image. Increasing <c>TaskCount</c> can
        /// improve label accuracy.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=3)]
        public int? TaskCount
        {
            get { return this._taskCount; }
            set { this._taskCount = value; }
        }

        // Check to see if TaskCount property is set
        internal bool IsSetTaskCount()
        {
            return this._taskCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TaskDescription. 
        /// <para>
        /// A description for the human worker task.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
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
        /// Keywords used to describe the task so that workers can discover the task.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=5)]
        public List<string> TaskKeywords
        {
            get { return this._taskKeywords; }
            set { this._taskKeywords = value; }
        }

        // Check to see if TaskKeywords property is set
        internal bool IsSetTaskKeywords()
        {
            return this._taskKeywords != null && (this._taskKeywords.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TaskTimeLimitInSeconds. 
        /// <para>
        /// The amount of time that a worker has to complete a task. The default value is 3,600
        /// seconds (1 hour).
        /// </para>
        /// </summary>
        [AWSProperty(Min=30)]
        public int? TaskTimeLimitInSeconds
        {
            get { return this._taskTimeLimitInSeconds; }
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
        /// A title for the human worker task.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
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
        /// Gets and sets the property WorkteamArn. 
        /// <para>
        /// Amazon Resource Name (ARN) of a team of workers. To learn more about the types of
        /// workforces and work teams you can create and use with Amazon A2I, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/sms-workforce-management.html">Create
        /// and Manage Workforces</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=256)]
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