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
 * Do not modify this file. This file is generated from the route53domains-2014-05-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

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
        /// </summary>
        [AWSProperty(Required=true, Max=255)]
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
        /// </summary>
        [AWSProperty(Required=true)]
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
        [AWSProperty(Required=true)]
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
        /// </summary>
        [AWSProperty(Required=true)]
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