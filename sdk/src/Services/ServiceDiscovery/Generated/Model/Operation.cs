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
 * Do not modify this file. This file is generated from the servicediscovery-2017-03-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ServiceDiscovery.Model
{
    /// <summary>
    /// A complex type that contains information about a specified operation.
    /// </summary>
    public partial class Operation
    {
        private DateTime? _createDate;
        private string _errorCode;
        private string _errorMessage;
        private string _id;
        private OperationStatus _status;
        private Dictionary<string, string> _targets = new Dictionary<string, string>();
        private OperationType _type;
        private DateTime? _updateDate;

        /// <summary>
        /// Gets and sets the property CreateDate. 
        /// <para>
        /// The date and time that the request was submitted, in Unix date/time format and Coordinated
        /// Universal Time (UTC). The value of <code>CreateDate</code> is accurate to milliseconds.
        /// For example, the value <code>1516925490.087</code> represents Friday, January 26,
        /// 2018 12:11:30.087 AM.
        /// </para>
        /// </summary>
        public DateTime CreateDate
        {
            get { return this._createDate.GetValueOrDefault(); }
            set { this._createDate = value; }
        }

        // Check to see if CreateDate property is set
        internal bool IsSetCreateDate()
        {
            return this._createDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ErrorCode. 
        /// <para>
        /// The code associated with <code>ErrorMessage</code>. Values for <code>ErrorCode</code>
        /// include the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>ACCESS_DENIED</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>CANNOT_CREATE_HOSTED_ZONE</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>EXPIRED_TOKEN</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>HOSTED_ZONE_NOT_FOUND</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>INTERNAL_FAILURE</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>INVALID_CHANGE_BATCH</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>THROTTLED_REQUEST</code> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string ErrorCode
        {
            get { return this._errorCode; }
            set { this._errorCode = value; }
        }

        // Check to see if ErrorCode property is set
        internal bool IsSetErrorCode()
        {
            return this._errorCode != null;
        }

        /// <summary>
        /// Gets and sets the property ErrorMessage. 
        /// <para>
        /// If the value of <code>Status</code> is <code>FAIL</code>, the reason that the operation
        /// failed.
        /// </para>
        /// </summary>
        public string ErrorMessage
        {
            get { return this._errorMessage; }
            set { this._errorMessage = value; }
        }

        // Check to see if ErrorMessage property is set
        internal bool IsSetErrorMessage()
        {
            return this._errorMessage != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID of the operation that you want to get information about.
        /// </para>
        /// </summary>
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the operation. Values include the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>SUBMITTED</b>: This is the initial state immediately after you submit a request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>PENDING</b>: Route 53 is performing the operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>SUCCESS</b>: The operation succeeded.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>FAIL</b>: The operation failed. For the failure reason, see <code>ErrorMessage</code>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public OperationStatus Status
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
        /// Gets and sets the property Targets. 
        /// <para>
        /// The name of the target entity that is associated with the operation:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>NAMESPACE</b>: The namespace ID is returned in the <code>ResourceId</code> property.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>SERVICE</b>: The service ID is returned in the <code>ResourceId</code> property.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>INSTANCE</b>: The instance ID is returned in the <code>ResourceId</code> property.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public Dictionary<string, string> Targets
        {
            get { return this._targets; }
            set { this._targets = value; }
        }

        // Check to see if Targets property is set
        internal bool IsSetTargets()
        {
            return this._targets != null && this._targets.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The name of the operation that is associated with the specified ID.
        /// </para>
        /// </summary>
        public OperationType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

        /// <summary>
        /// Gets and sets the property UpdateDate. 
        /// <para>
        /// The date and time that the value of <code>Status</code> changed to the current value,
        /// in Unix date/time format and Coordinated Universal Time (UTC). The value of <code>UpdateDate</code>
        /// is accurate to milliseconds. For example, the value <code>1516925490.087</code> represents
        /// Friday, January 26, 2018 12:11:30.087 AM.
        /// </para>
        /// </summary>
        public DateTime UpdateDate
        {
            get { return this._updateDate.GetValueOrDefault(); }
            set { this._updateDate = value; }
        }

        // Check to see if UpdateDate property is set
        internal bool IsSetUpdateDate()
        {
            return this._updateDate.HasValue; 
        }

    }
}