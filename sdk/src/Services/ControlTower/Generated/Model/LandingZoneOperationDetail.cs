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
 * Do not modify this file. This file is generated from the controltower-2018-05-10.normal.json service model.
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
namespace Amazon.ControlTower.Model
{
    /// <summary>
    /// Information about a landing zone operation.
    /// </summary>
    public partial class LandingZoneOperationDetail
    {
        private DateTime? _endTime;
        private string _operationIdentifier;
        private LandingZoneOperationType _operationType;
        private DateTime? _startTime;
        private LandingZoneOperationStatus _status;
        private string _statusMessage;

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The landing zone operation end time.
        /// </para>
        /// </summary>
        public DateTime? EndTime
        {
            get { return this._endTime; }
            set { this._endTime = value; }
        }

        // Check to see if EndTime property is set
        internal bool IsSetEndTime()
        {
            return this._endTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OperationIdentifier. 
        /// <para>
        /// The <c>operationIdentifier</c> of the landing zone operation.
        /// </para>
        /// </summary>
        [AWSProperty(Min=36, Max=36)]
        public string OperationIdentifier
        {
            get { return this._operationIdentifier; }
            set { this._operationIdentifier = value; }
        }

        // Check to see if OperationIdentifier property is set
        internal bool IsSetOperationIdentifier()
        {
            return this._operationIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property OperationType. 
        /// <para>
        /// The landing zone operation type. 
        /// </para>
        ///  
        /// <para>
        /// Valid values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>DELETE</c>: The <c>DeleteLandingZone</c> operation. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CREATE</c>: The <c>CreateLandingZone</c> operation. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>UPDATE</c>: The <c>UpdateLandingZone</c> operation. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>RESET</c>: The <c>ResetLandingZone</c> operation. 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public LandingZoneOperationType OperationType
        {
            get { return this._operationType; }
            set { this._operationType = value; }
        }

        // Check to see if OperationType property is set
        internal bool IsSetOperationType()
        {
            return this._operationType != null;
        }

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The landing zone operation start time.
        /// </para>
        /// </summary>
        public DateTime? StartTime
        {
            get { return this._startTime; }
            set { this._startTime = value; }
        }

        // Check to see if StartTime property is set
        internal bool IsSetStartTime()
        {
            return this._startTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Valid values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>SUCCEEDED</c>: The landing zone operation succeeded. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>IN_PROGRESS</c>: The landing zone operation is in progress. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FAILED</c>: The landing zone operation failed. 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public LandingZoneOperationStatus Status
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
        /// Gets and sets the property StatusMessage. 
        /// <para>
        /// If the operation result is FAILED, this string contains a message explaining why the
        /// operation failed.
        /// </para>
        /// </summary>
        public string StatusMessage
        {
            get { return this._statusMessage; }
            set { this._statusMessage = value; }
        }

        // Check to see if StatusMessage property is set
        internal bool IsSetStatusMessage()
        {
            return this._statusMessage != null;
        }

    }
}