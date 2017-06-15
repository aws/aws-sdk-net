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
 * Do not modify this file. This file is generated from the servicecatalog-2015-12-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ServiceCatalog.Model
{
    /// <summary>
    /// Detailed information about a ProvisionedProduct object.
    /// </summary>
    public partial class ProvisionedProductDetail
    {
        private string _arn;
        private DateTime? _createdTime;
        private string _id;
        private string _idempotencyToken;
        private string _lastRecordId;
        private string _name;
        private ProvisionedProductStatus _status;
        private string _statusMessage;
        private string _type;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The ARN associated with the ProvisionedProduct object.
        /// </para>
        /// </summary>
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedTime. 
        /// <para>
        /// The UTC timestamp of the creation time.
        /// </para>
        /// </summary>
        public DateTime CreatedTime
        {
            get { return this._createdTime.GetValueOrDefault(); }
            set { this._createdTime = value; }
        }

        // Check to see if CreatedTime property is set
        internal bool IsSetCreatedTime()
        {
            return this._createdTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The identifier of the ProvisionedProduct object.
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
        /// Gets and sets the property IdempotencyToken. 
        /// <para>
        /// A token to disambiguate duplicate requests. You can create multiple resources using
        /// the same input in multiple requests, provided that you also specify a different idempotency
        /// token for each request.
        /// </para>
        /// </summary>
        public string IdempotencyToken
        {
            get { return this._idempotencyToken; }
            set { this._idempotencyToken = value; }
        }

        // Check to see if IdempotencyToken property is set
        internal bool IsSetIdempotencyToken()
        {
            return this._idempotencyToken != null;
        }

        /// <summary>
        /// Gets and sets the property LastRecordId. 
        /// <para>
        /// The record identifier of the last request performed on this ProvisionedProduct object.
        /// </para>
        /// </summary>
        public string LastRecordId
        {
            get { return this._lastRecordId; }
            set { this._lastRecordId = value; }
        }

        // Check to see if LastRecordId property is set
        internal bool IsSetLastRecordId()
        {
            return this._lastRecordId != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The user-friendly name of the ProvisionedProduct object.
        /// </para>
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the ProvisionedProduct.
        /// </para>
        ///  
        /// <para>
        ///  <code>AVAILABLE</code> - Stable state, ready to perform any operation. The most recent
        /// action request succeeded and completed.
        /// </para>
        ///  
        /// <para>
        ///  <code>UNDER_CHANGE</code> - Transitive state, operations performed may or may not
        /// have valid results. Wait for an <code>AVAILABLE</code> status before performing operations.
        /// </para>
        ///  
        /// <para>
        ///  <code>TAINTED</code> - Stable state, ready to perform any operation. The stack has
        /// completed the requested operation but is not exactly what was requested. For example,
        /// a request to update to a new version failed and the stack rolled back to the current
        /// version. 
        /// </para>
        ///  
        /// <para>
        ///  <code>ERROR</code> - Something unexpected happened such that the provisioned product
        /// exists but the stack is not running. For example, CloudFormation received an invalid
        /// parameter value and could not launch the stack.
        /// </para>
        /// </summary>
        public ProvisionedProductStatus Status
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
        /// The current status message of the ProvisionedProduct.
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

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of the ProvisionedProduct object.
        /// </para>
        /// </summary>
        public string Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}