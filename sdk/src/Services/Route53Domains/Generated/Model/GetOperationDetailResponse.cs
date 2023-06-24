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
    /// The GetOperationDetail response includes the following elements.
    /// </summary>
    public partial class GetOperationDetailResponse : AmazonWebServiceResponse
    {
        private string _domainName;
        private DateTime? _lastUpdatedDate;
        private string _message;
        private string _operationId;
        private OperationStatus _status;
        private StatusFlag _statusFlag;
        private DateTime? _submittedDate;
        private OperationType _type;

        /// <summary>
        /// Gets and sets the property DomainName. 
        /// <para>
        /// The name of a domain.
        /// </para>
        /// </summary>
        [AWSProperty(Max=255)]
        public string DomainName
        {
            get { return this._domainName; }
            set { this._domainName = value; }
        }

        // Check to see if DomainName property is set
        internal bool IsSetDomainName()
        {
            return this._domainName != null;
        }

        /// <summary>
        /// Gets and sets the property LastUpdatedDate. 
        /// <para>
        ///  The date when the operation was last updated. 
        /// </para>
        /// </summary>
        public DateTime LastUpdatedDate
        {
            get { return this._lastUpdatedDate.GetValueOrDefault(); }
            set { this._lastUpdatedDate = value; }
        }

        // Check to see if LastUpdatedDate property is set
        internal bool IsSetLastUpdatedDate()
        {
            return this._lastUpdatedDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// Detailed information on the status including possible errors.
        /// </para>
        /// </summary>
        public string Message
        {
            get { return this._message; }
            set { this._message = value; }
        }

        // Check to see if Message property is set
        internal bool IsSetMessage()
        {
            return this._message != null;
        }

        /// <summary>
        /// Gets and sets the property OperationId. 
        /// <para>
        /// The identifier for the operation.
        /// </para>
        /// </summary>
        [AWSProperty(Max=255)]
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
        /// Gets and sets the property StatusFlag. 
        /// <para>
        ///  Lists any outstanding operations that require customer action. Valid values are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>PENDING_ACCEPTANCE</code>: The operation is waiting for acceptance from the
        /// account that is receiving the domain.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>PENDING_CUSTOMER_ACTION</code>: The operation is waiting for customer action,
        /// for example, returning an email.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>PENDING_AUTHORIZATION</code>: The operation is waiting for the form of authorization.
        /// For more information, see <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_domains_ResendOperationAuthorization.html">ResendOperationAuthorization</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>PENDING_PAYMENT_VERIFICATION</code>: The operation is waiting for the payment
        /// method to validate.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>PENDING_SUPPORT_CASE</code>: The operation includes a support case and is waiting
        /// for its resolution.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public StatusFlag StatusFlag
        {
            get { return this._statusFlag; }
            set { this._statusFlag = value; }
        }

        // Check to see if StatusFlag property is set
        internal bool IsSetStatusFlag()
        {
            return this._statusFlag != null;
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
        /// The type of operation that was requested.
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