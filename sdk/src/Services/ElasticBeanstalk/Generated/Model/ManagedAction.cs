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
    /// The record of an upcoming or in-progress managed action.
    /// </summary>
    public partial class ManagedAction
    {
        private string _actionDescription;
        private string _actionId;
        private ActionType _actionType;
        private ActionStatus _status;
        private DateTime? _windowStartTime;

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
        /// The type of managed action.
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
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the managed action. If the action is <c>Scheduled</c>, you can apply
        /// it immediately with <a>ApplyEnvironmentManagedAction</a>.
        /// </para>
        /// </summary>
        public ActionStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property WindowStartTime. 
        /// <para>
        /// The start time of the maintenance window in which the managed action will execute.
        /// </para>
        /// </summary>
        public DateTime? WindowStartTime
        {
            get { return this._windowStartTime; }
            set { this._windowStartTime = value; }
        }

        // Check to see if WindowStartTime property is set
        internal bool IsSetWindowStartTime()
        {
            return this._windowStartTime.HasValue; 
        }

    }
}