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
 * Do not modify this file. This file is generated from the elasticbeanstalk-2010-12-01.normal.json service model.
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
namespace Amazon.ElasticBeanstalk.Model
{
    /// <summary>
    /// The record of a completed or failed managed action.
    /// </summary>
    public partial class ManagedActionHistoryItem
    {
        private string _actionDescription;
        private string _actionId;
        private ActionType _actionType;
        private DateTime? _executedTime;
        private string _failureDescription;
        private FailureType _failureType;
        private DateTime? _finishedTime;
        private ActionHistoryStatus _status;

        /// <summary>
        /// Gets and sets the property ActionDescription. 
        /// <para>
        /// A description of the managed action.
        /// </para>
        /// </summary>
        public string ActionDescription
        {
            get { return this._actionDescription; }
            set { this._actionDescription = value; }
        }

        // Check to see if ActionDescription property is set
        internal bool IsSetActionDescription()
        {
            return this._actionDescription != null;
        }

        /// <summary>
        /// Gets and sets the property ActionId. 
        /// <para>
        /// A unique identifier for the managed action.
        /// </para>
        /// </summary>
        public string ActionId
        {
            get { return this._actionId; }
            set { this._actionId = value; }
        }

        // Check to see if ActionId property is set
        internal bool IsSetActionId()
        {
            return this._actionId != null;
        }

        /// <summary>
        /// Gets and sets the property ActionType. 
        /// <para>
        /// The type of the managed action.
        /// </para>
        /// </summary>
        public ActionType ActionType
        {
            get { return this._actionType; }
            set { this._actionType = value; }
        }

        // Check to see if ActionType property is set
        internal bool IsSetActionType()
        {
            return this._actionType != null;
        }

        /// <summary>
        /// Gets and sets the property ExecutedTime. 
        /// <para>
        /// The date and time that the action started executing.
        /// </para>
        /// </summary>
        public DateTime? ExecutedTime
        {
            get { return this._executedTime; }
            set { this._executedTime = value; }
        }

        // Check to see if ExecutedTime property is set
        internal bool IsSetExecutedTime()
        {
            return this._executedTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FailureDescription. 
        /// <para>
        /// If the action failed, a description of the failure.
        /// </para>
        /// </summary>
        public string FailureDescription
        {
            get { return this._failureDescription; }
            set { this._failureDescription = value; }
        }

        // Check to see if FailureDescription property is set
        internal bool IsSetFailureDescription()
        {
            return this._failureDescription != null;
        }

        /// <summary>
        /// Gets and sets the property FailureType. 
        /// <para>
        /// If the action failed, the type of failure.
        /// </para>
        /// </summary>
        public FailureType FailureType
        {
            get { return this._failureType; }
            set { this._failureType = value; }
        }

        // Check to see if FailureType property is set
        internal bool IsSetFailureType()
        {
            return this._failureType != null;
        }

        /// <summary>
        /// Gets and sets the property FinishedTime. 
        /// <para>
        /// The date and time that the action finished executing.
        /// </para>
        /// </summary>
        public DateTime? FinishedTime
        {
            get { return this._finishedTime; }
            set { this._finishedTime = value; }
        }

        // Check to see if FinishedTime property is set
        internal bool IsSetFinishedTime()
        {
            return this._finishedTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the action.
        /// </para>
        /// </summary>
        public ActionHistoryStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}