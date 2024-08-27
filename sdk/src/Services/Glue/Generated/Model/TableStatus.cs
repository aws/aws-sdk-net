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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
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
namespace Amazon.Glue.Model
{
    /// <summary>
    /// A structure containing information about the state of an asynchronous change to a
    /// table.
    /// </summary>
    public partial class TableStatus
    {
        private ResourceAction _action;
        private StatusDetails _details;
        private ErrorDetail _error;
        private string _requestedBy;
        private DateTime? _requestTime;
        private ResourceState _state;
        private string _updatedBy;
        private DateTime? _updateTime;

        /// <summary>
        /// Gets and sets the property Action. 
        /// <para>
        /// Indicates which action was called on the table, currently only <c>CREATE</c> or <c>UPDATE</c>.
        /// </para>
        /// </summary>
        public ResourceAction Action
        {
            get { return this._action; }
            set { this._action = value; }
        }

        // Check to see if Action property is set
        internal bool IsSetAction()
        {
            return this._action != null;
        }

        /// <summary>
        /// Gets and sets the property Details. 
        /// <para>
        /// A <c>StatusDetails</c> object with information about the requested change.
        /// </para>
        /// </summary>
        public StatusDetails Details
        {
            get { return this._details; }
            set { this._details = value; }
        }

        // Check to see if Details property is set
        internal bool IsSetDetails()
        {
            return this._details != null;
        }

        /// <summary>
        /// Gets and sets the property Error. 
        /// <para>
        /// An error that will only appear when the state is "FAILED". This is a parent level
        /// exception message, there may be different <c>Error</c>s for each dialect.
        /// </para>
        /// </summary>
        public ErrorDetail Error
        {
            get { return this._error; }
            set { this._error = value; }
        }

        // Check to see if Error property is set
        internal bool IsSetError()
        {
            return this._error != null;
        }

        /// <summary>
        /// Gets and sets the property RequestedBy. 
        /// <para>
        /// The ARN of the user who requested the asynchronous change.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string RequestedBy
        {
            get { return this._requestedBy; }
            set { this._requestedBy = value; }
        }

        // Check to see if RequestedBy property is set
        internal bool IsSetRequestedBy()
        {
            return this._requestedBy != null;
        }

        /// <summary>
        /// Gets and sets the property RequestTime. 
        /// <para>
        /// An ISO 8601 formatted date string indicating the time that the change was initiated.
        /// </para>
        /// </summary>
        public DateTime? RequestTime
        {
            get { return this._requestTime; }
            set { this._requestTime = value; }
        }

        // Check to see if RequestTime property is set
        internal bool IsSetRequestTime()
        {
            return this._requestTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// A generic status for the change in progress, such as QUEUED, IN_PROGRESS, SUCCESS,
        /// or FAILED.
        /// </para>
        /// </summary>
        public ResourceState State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

        /// <summary>
        /// Gets and sets the property UpdatedBy. 
        /// <para>
        /// The ARN of the user to last manually alter the asynchronous change (requesting cancellation,
        /// etc).
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string UpdatedBy
        {
            get { return this._updatedBy; }
            set { this._updatedBy = value; }
        }

        // Check to see if UpdatedBy property is set
        internal bool IsSetUpdatedBy()
        {
            return this._updatedBy != null;
        }

        /// <summary>
        /// Gets and sets the property UpdateTime. 
        /// <para>
        /// An ISO 8601 formatted date string indicating the time that the state was last updated.
        /// </para>
        /// </summary>
        public DateTime? UpdateTime
        {
            get { return this._updateTime; }
            set { this._updateTime = value; }
        }

        // Check to see if UpdateTime property is set
        internal bool IsSetUpdateTime()
        {
            return this._updateTime.HasValue; 
        }

    }
}