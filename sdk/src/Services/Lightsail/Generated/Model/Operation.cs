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
 * Do not modify this file. This file is generated from the lightsail-2016-11-28.normal.json service model.
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
namespace Amazon.Lightsail.Model
{
    /// <summary>
    /// Describes the API operation.
    /// </summary>
    public partial class Operation
    {
        private DateTime? _createdAt;
        private string _errorCode;
        private string _errorDetails;
        private string _id;
        private bool? _isTerminal;
        private ResourceLocation _location;
        private string _operationDetails;
        private OperationType _operationType;
        private string _resourceName;
        private ResourceType _resourceType;
        private OperationStatus _status;
        private DateTime? _statusChangedAt;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp when the operation was initialized (<c>1479816991.349</c>).
        /// </para>
        /// </summary>
        public DateTime? CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ErrorCode. 
        /// <para>
        /// The error code.
        /// </para>
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
        /// Gets and sets the property ErrorDetails. 
        /// <para>
        /// The error details.
        /// </para>
        /// </summary>
        public string ErrorDetails
        {
            get { return this._errorDetails; }
            set { this._errorDetails = value; }
        }

        // Check to see if ErrorDetails property is set
        internal bool IsSetErrorDetails()
        {
            return this._errorDetails != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID of the operation.
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
        /// Gets and sets the property IsTerminal. 
        /// <para>
        /// A Boolean value indicating whether the operation is terminal.
        /// </para>
        /// </summary>
        public bool? IsTerminal
        {
            get { return this._isTerminal; }
            set { this._isTerminal = value; }
        }

        // Check to see if IsTerminal property is set
        internal bool IsSetIsTerminal()
        {
            return this._isTerminal.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Location. 
        /// <para>
        /// The Amazon Web Services Region and Availability Zone.
        /// </para>
        /// </summary>
        public ResourceLocation Location
        {
            get { return this._location; }
            set { this._location = value; }
        }

        // Check to see if Location property is set
        internal bool IsSetLocation()
        {
            return this._location != null;
        }

        /// <summary>
        /// Gets and sets the property OperationDetails. 
        /// <para>
        /// Details about the operation (<c>Debian-1GB-Ohio-1</c>).
        /// </para>
        /// </summary>
        public string OperationDetails
        {
            get { return this._operationDetails; }
            set { this._operationDetails = value; }
        }

        // Check to see if OperationDetails property is set
        internal bool IsSetOperationDetails()
        {
            return this._operationDetails != null;
        }

        /// <summary>
        /// Gets and sets the property OperationType. 
        /// <para>
        /// The type of operation. 
        /// </para>
        /// </summary>
        public OperationType OperationType
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
        /// Gets and sets the property ResourceName. 
        /// <para>
        /// The resource name.
        /// </para>
        /// </summary>
        public string ResourceName
        {
            get { return this._resourceName; }
            set { this._resourceName = value; }
        }

        // Check to see if ResourceName property is set
        internal bool IsSetResourceName()
        {
            return this._resourceName != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// The resource type. 
        /// </para>
        /// </summary>
        public ResourceType ResourceType
        {
            get { return this._resourceType; }
            set { this._resourceType = value; }
        }

        // Check to see if ResourceType property is set
        internal bool IsSetResourceType()
        {
            return this._resourceType != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the operation. 
        /// </para>
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
        /// Gets and sets the property StatusChangedAt. 
        /// <para>
        /// The timestamp when the status was changed (<c>1479816991.349</c>).
        /// </para>
        /// </summary>
        public DateTime? StatusChangedAt
        {
            get { return this._statusChangedAt; }
            set { this._statusChangedAt = value; }
        }

        // Check to see if StatusChangedAt property is set
        internal bool IsSetStatusChangedAt()
        {
            return this._statusChangedAt.HasValue; 
        }

    }
}