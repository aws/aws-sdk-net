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
 * Do not modify this file. This file is generated from the servicediscovery-2017-03-14.normal.json service model.
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
        private string _ownerAccount;
        private OperationStatus _status;
        private Dictionary<string, string> _targets = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private OperationType _type;
        private DateTime? _updateDate;

        /// <summary>
        /// Gets and sets the property CreateDate. 
        /// <para>
        /// The date and time that the request was submitted, in Unix date/time format and Coordinated
        /// Universal Time (UTC). The value of <c>CreateDate</c> is accurate to milliseconds.
        /// For example, the value <c>1516925490.087</c> represents Friday, January 26, 2018 12:11:30.087
        /// AM.
        /// </para>
        /// </summary>
        public DateTime? CreateDate
        {
            get { return this._createDate; }
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
        /// The code associated with <c>ErrorMessage</c>. Values for <c>ErrorCode</c> include
        /// the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ACCESS_DENIED</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CANNOT_CREATE_HOSTED_ZONE</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>EXPIRED_TOKEN</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>HOSTED_ZONE_NOT_FOUND</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>INTERNAL_FAILURE</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>INVALID_CHANGE_BATCH</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>THROTTLED_REQUEST</c> 
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
        /// If the value of <c>Status</c> is <c>FAIL</c>, the reason that the operation failed.
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
        [AWSProperty(Max=255)]
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
        /// Gets and sets the property OwnerAccount. 
        /// <para>
        /// The ID of the Amazon Web Services account that owns the namespace associated with
        /// the operation.
        /// </para>
        /// </summary>
        [AWSProperty(Min=12, Max=12)]
        public string OwnerAccount
        {
            get { return this._ownerAccount; }
            set { this._ownerAccount = value; }
        }

        // Check to see if OwnerAccount property is set
        internal bool IsSetOwnerAccount()
        {
            return this._ownerAccount != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the operation. Values include the following:
        /// </para>
        ///  <dl> <dt>SUBMITTED</dt> <dd> 
        /// <para>
        /// This is the initial state that occurs immediately after you submit a request.
        /// </para>
        ///  </dd> <dt>PENDING</dt> <dd> 
        /// <para>
        /// Cloud Map is performing the operation.
        /// </para>
        ///  </dd> <dt>SUCCESS</dt> <dd> 
        /// <para>
        /// The operation succeeded.
        /// </para>
        ///  </dd> <dt>FAIL</dt> <dd> 
        /// <para>
        /// The operation failed. For the failure reason, see <c>ErrorMessage</c>.
        /// </para>
        ///  </dd> </dl>
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
        /// The name of the target entity that's associated with the operation:
        /// </para>
        ///  <dl> <dt>NAMESPACE</dt> <dd> 
        /// <para>
        /// The namespace ID is returned in the <c>ResourceId</c> property.
        /// </para>
        ///  </dd> <dt>SERVICE</dt> <dd> 
        /// <para>
        /// The service ID is returned in the <c>ResourceId</c> property.
        /// </para>
        ///  </dd> <dt>INSTANCE</dt> <dd> 
        /// <para>
        /// The instance ID is returned in the <c>ResourceId</c> property.
        /// </para>
        ///  </dd> </dl>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Targets
        {
            get { return this._targets; }
            set { this._targets = value; }
        }

        // Check to see if Targets property is set
        internal bool IsSetTargets()
        {
            return this._targets != null && (this._targets.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The name of the operation that's associated with the specified ID.
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
        /// The date and time that the value of <c>Status</c> changed to the current value, in
        /// Unix date/time format and Coordinated Universal Time (UTC). The value of <c>UpdateDate</c>
        /// is accurate to milliseconds. For example, the value <c>1516925490.087</c> represents
        /// Friday, January 26, 2018 12:11:30.087 AM.
        /// </para>
        /// </summary>
        public DateTime? UpdateDate
        {
            get { return this._updateDate; }
            set { this._updateDate = value; }
        }

        // Check to see if UpdateDate property is set
        internal bool IsSetUpdateDate()
        {
            return this._updateDate.HasValue; 
        }

    }
}