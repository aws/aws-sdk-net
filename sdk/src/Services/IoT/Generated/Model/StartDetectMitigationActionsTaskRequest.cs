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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IoT.Model
{
    /// <summary>
    /// Container for the parameters to the StartDetectMitigationActionsTask operation.
    /// Starts a Device Defender ML Detect mitigation actions task.
    /// </summary>
    public partial class StartDetectMitigationActionsTaskRequest : AmazonIoTRequest
    {
        private List<string> _actions = new List<string>();
        private string _clientRequestToken;
        private bool? _includeOnlyActiveViolations;
        private bool? _includeSuppressedAlerts;
        private DetectMitigationActionsTaskTarget _target;
        private string _taskId;
        private ViolationEventOccurrenceRange _violationEventOccurrenceRange;

        /// <summary>
        /// Gets and sets the property Actions. 
        /// <para>
        ///  The actions to be performed when a device has unexpected behavior. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=5)]
        public List<string> Actions
        {
            get { return this._actions; }
            set { this._actions = value; }
        }

        // Check to see if Actions property is set
        internal bool IsSetActions()
        {
            return this._actions != null && this._actions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ClientRequestToken. 
        /// <para>
        ///  Each mitigation action task must have a unique client request token. If you try to
        /// create a new task with the same token as a task that already exists, an exception
        /// occurs. If you omit this value, AWS SDKs will automatically generate a unique client
        /// request. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string ClientRequestToken
        {
            get { return this._clientRequestToken; }
            set { this._clientRequestToken = value; }
        }

        // Check to see if ClientRequestToken property is set
        internal bool IsSetClientRequestToken()
        {
            return this._clientRequestToken != null;
        }

        /// <summary>
        /// Gets and sets the property IncludeOnlyActiveViolations. 
        /// <para>
        ///  Specifies to list only active violations. 
        /// </para>
        /// </summary>
        public bool IncludeOnlyActiveViolations
        {
            get { return this._includeOnlyActiveViolations.GetValueOrDefault(); }
            set { this._includeOnlyActiveViolations = value; }
        }

        // Check to see if IncludeOnlyActiveViolations property is set
        internal bool IsSetIncludeOnlyActiveViolations()
        {
            return this._includeOnlyActiveViolations.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IncludeSuppressedAlerts. 
        /// <para>
        ///  Specifies to include suppressed alerts. 
        /// </para>
        /// </summary>
        public bool IncludeSuppressedAlerts
        {
            get { return this._includeSuppressedAlerts.GetValueOrDefault(); }
            set { this._includeSuppressedAlerts = value; }
        }

        // Check to see if IncludeSuppressedAlerts property is set
        internal bool IsSetIncludeSuppressedAlerts()
        {
            return this._includeSuppressedAlerts.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Target. 
        /// <para>
        ///  Specifies the ML Detect findings to which the mitigation actions are applied. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DetectMitigationActionsTaskTarget Target
        {
            get { return this._target; }
            set { this._target = value; }
        }

        // Check to see if Target property is set
        internal bool IsSetTarget()
        {
            return this._target != null;
        }

        /// <summary>
        /// Gets and sets the property TaskId. 
        /// <para>
        ///  The unique identifier of the task. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string TaskId
        {
            get { return this._taskId; }
            set { this._taskId = value; }
        }

        // Check to see if TaskId property is set
        internal bool IsSetTaskId()
        {
            return this._taskId != null;
        }

        /// <summary>
        /// Gets and sets the property ViolationEventOccurrenceRange. 
        /// <para>
        ///  Specifies the time period of which violation events occurred between. 
        /// </para>
        /// </summary>
        public ViolationEventOccurrenceRange ViolationEventOccurrenceRange
        {
            get { return this._violationEventOccurrenceRange; }
            set { this._violationEventOccurrenceRange = value; }
        }

        // Check to see if ViolationEventOccurrenceRange property is set
        internal bool IsSetViolationEventOccurrenceRange()
        {
            return this._violationEventOccurrenceRange != null;
        }

    }
}