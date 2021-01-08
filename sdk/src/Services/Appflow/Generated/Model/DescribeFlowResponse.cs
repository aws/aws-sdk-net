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
 * Do not modify this file. This file is generated from the appflow-2020-08-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Appflow.Model
{
    /// <summary>
    /// This is the response object from the DescribeFlow operation.
    /// </summary>
    public partial class DescribeFlowResponse : AmazonWebServiceResponse
    {
        private DateTime? _createdAt;
        private string _createdBy;
        private string _description;
        private List<DestinationFlowConfig> _destinationFlowConfigList = new List<DestinationFlowConfig>();
        private string _flowArn;
        private string _flowName;
        private FlowStatus _flowStatus;
        private string _flowStatusMessage;
        private string _kmsArn;
        private ExecutionDetails _lastRunExecutionDetails;
        private DateTime? _lastUpdatedAt;
        private string _lastUpdatedBy;
        private SourceFlowConfig _sourceFlowConfig;
        private Dictionary<string, string> _tags = new Dictionary<string, string>();
        private List<Task> _tasks = new List<Task>();
        private TriggerConfig _triggerConfig;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        ///  Specifies when the flow was created. 
        /// </para>
        /// </summary>
        public DateTime CreatedAt
        {
            get { return this._createdAt.GetValueOrDefault(); }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CreatedBy. 
        /// <para>
        ///  The ARN of the user who created the flow. 
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string CreatedBy
        {
            get { return this._createdBy; }
            set { this._createdBy = value; }
        }

        // Check to see if CreatedBy property is set
        internal bool IsSetCreatedBy()
        {
            return this._createdBy != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        ///  A description of the flow. 
        /// </para>
        /// </summary>
        [AWSProperty(Max=2048)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property DestinationFlowConfigList. 
        /// <para>
        ///  The configuration that controls how Amazon AppFlow transfers data to the destination
        /// connector. 
        /// </para>
        /// </summary>
        public List<DestinationFlowConfig> DestinationFlowConfigList
        {
            get { return this._destinationFlowConfigList; }
            set { this._destinationFlowConfigList = value; }
        }

        // Check to see if DestinationFlowConfigList property is set
        internal bool IsSetDestinationFlowConfigList()
        {
            return this._destinationFlowConfigList != null && this._destinationFlowConfigList.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property FlowArn. 
        /// <para>
        ///  The flow's Amazon Resource Name (ARN). 
        /// </para>
        /// </summary>
        [AWSProperty(Max=512)]
        public string FlowArn
        {
            get { return this._flowArn; }
            set { this._flowArn = value; }
        }

        // Check to see if FlowArn property is set
        internal bool IsSetFlowArn()
        {
            return this._flowArn != null;
        }

        /// <summary>
        /// Gets and sets the property FlowName. 
        /// <para>
        ///  The specified name of the flow. Spaces are not allowed. Use underscores (_) or hyphens
        /// (-) only. 
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string FlowName
        {
            get { return this._flowName; }
            set { this._flowName = value; }
        }

        // Check to see if FlowName property is set
        internal bool IsSetFlowName()
        {
            return this._flowName != null;
        }

        /// <summary>
        /// Gets and sets the property FlowStatus. 
        /// <para>
        ///  Indicates the current status of the flow. 
        /// </para>
        /// </summary>
        public FlowStatus FlowStatus
        {
            get { return this._flowStatus; }
            set { this._flowStatus = value; }
        }

        // Check to see if FlowStatus property is set
        internal bool IsSetFlowStatus()
        {
            return this._flowStatus != null;
        }

        /// <summary>
        /// Gets and sets the property FlowStatusMessage. 
        /// <para>
        ///  Contains an error message if the flow status is in a suspended or error state. This
        /// applies only to scheduled or event-triggered flows. 
        /// </para>
        /// </summary>
        [AWSProperty(Max=2048)]
        public string FlowStatusMessage
        {
            get { return this._flowStatusMessage; }
            set { this._flowStatusMessage = value; }
        }

        // Check to see if FlowStatusMessage property is set
        internal bool IsSetFlowStatusMessage()
        {
            return this._flowStatusMessage != null;
        }

        /// <summary>
        /// Gets and sets the property KmsArn. 
        /// <para>
        ///  The ARN (Amazon Resource Name) of the Key Management Service (KMS) key you provide
        /// for encryption. This is required if you do not want to use the Amazon AppFlow-managed
        /// KMS key. If you don't provide anything here, Amazon AppFlow uses the Amazon AppFlow-managed
        /// KMS key. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string KmsArn
        {
            get { return this._kmsArn; }
            set { this._kmsArn = value; }
        }

        // Check to see if KmsArn property is set
        internal bool IsSetKmsArn()
        {
            return this._kmsArn != null;
        }

        /// <summary>
        /// Gets and sets the property LastRunExecutionDetails. 
        /// <para>
        ///  Describes the details of the most recent flow run. 
        /// </para>
        /// </summary>
        public ExecutionDetails LastRunExecutionDetails
        {
            get { return this._lastRunExecutionDetails; }
            set { this._lastRunExecutionDetails = value; }
        }

        // Check to see if LastRunExecutionDetails property is set
        internal bool IsSetLastRunExecutionDetails()
        {
            return this._lastRunExecutionDetails != null;
        }

        /// <summary>
        /// Gets and sets the property LastUpdatedAt. 
        /// <para>
        ///  Specifies when the flow was last updated. 
        /// </para>
        /// </summary>
        public DateTime LastUpdatedAt
        {
            get { return this._lastUpdatedAt.GetValueOrDefault(); }
            set { this._lastUpdatedAt = value; }
        }

        // Check to see if LastUpdatedAt property is set
        internal bool IsSetLastUpdatedAt()
        {
            return this._lastUpdatedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastUpdatedBy. 
        /// <para>
        ///  Specifies the user name of the account that performed the most recent update. 
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string LastUpdatedBy
        {
            get { return this._lastUpdatedBy; }
            set { this._lastUpdatedBy = value; }
        }

        // Check to see if LastUpdatedBy property is set
        internal bool IsSetLastUpdatedBy()
        {
            return this._lastUpdatedBy != null;
        }

        /// <summary>
        /// Gets and sets the property SourceFlowConfig. 
        /// <para>
        ///  The configuration that controls how Amazon AppFlow retrieves data from the source
        /// connector. 
        /// </para>
        /// </summary>
        public SourceFlowConfig SourceFlowConfig
        {
            get { return this._sourceFlowConfig; }
            set { this._sourceFlowConfig = value; }
        }

        // Check to see if SourceFlowConfig property is set
        internal bool IsSetSourceFlowConfig()
        {
            return this._sourceFlowConfig != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        ///  The tags used to organize, track, or control access for your flow. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Tasks. 
        /// <para>
        ///  A list of tasks that Amazon AppFlow performs while transferring the data in the flow
        /// run. 
        /// </para>
        /// </summary>
        public List<Task> Tasks
        {
            get { return this._tasks; }
            set { this._tasks = value; }
        }

        // Check to see if Tasks property is set
        internal bool IsSetTasks()
        {
            return this._tasks != null && this._tasks.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property TriggerConfig. 
        /// <para>
        ///  The trigger settings that determine how and when the flow runs. 
        /// </para>
        /// </summary>
        public TriggerConfig TriggerConfig
        {
            get { return this._triggerConfig; }
            set { this._triggerConfig = value; }
        }

        // Check to see if TriggerConfig property is set
        internal bool IsSetTriggerConfig()
        {
            return this._triggerConfig != null;
        }

    }
}