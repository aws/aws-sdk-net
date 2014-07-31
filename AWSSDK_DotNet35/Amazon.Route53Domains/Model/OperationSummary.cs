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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Route53Domains.Model
{
    /// <summary>
    /// OperationSummary includes the following elements.
    /// </summary>
    public partial class OperationSummary
    {
        private string _operationId;
        private OperationStatus _status;
        private DateTime? _submittedDate;
        private OperationType _type;


        /// <summary>
        /// Gets and sets the property OperationId. 
        /// <para>
        /// Identifier returned to track the requested action.
        /// </para>
        ///  
        /// <para>
        /// Type: String
        /// </para>
        /// </summary>
        public string OperationId
        {
            get { return this._operationId; }
            set { this._operationId = value; }
        }

        // Check to see if OperationId property is set
        internal bool IsSetOperationId()
        {
            return this._operationId != null;
        }


        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the requested operation in the system.
        /// </para>
        ///  
        /// <para>
        /// Type: String
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
        /// Gets and sets the property SubmittedDate. 
        /// <para>
        /// The date when the request was submitted.
        /// </para>
        /// </summary>
        public DateTime SubmittedDate
        {
            get { return this._submittedDate.GetValueOrDefault(); }
            set { this._submittedDate = value; }
        }

        // Check to see if SubmittedDate property is set
        internal bool IsSetSubmittedDate()
        {
            return this._submittedDate.HasValue; 
        }


        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// Type of the action requested.
        /// </para>
        ///  
        /// <para>
        /// Type: String
        /// </para>
        ///  
        /// <para>
        /// Valid values: <code>REGISTER_DOMAIN</code> | <code>DELETE_DOMAIN</code> | <code>TRANSFER_IN_DOMAIN</code>
        /// | <code>UPDATE_DOMAIN_CONTACT</code> | <code>UPDATE_NAMESERVER</code> | <code>CHANGE_PRIVACY_PROTECTION</code>
        /// | <code>DOMAIN_LOCK</code>
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

    }
}