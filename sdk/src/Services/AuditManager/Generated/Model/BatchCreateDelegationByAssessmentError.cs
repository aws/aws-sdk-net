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
 * Do not modify this file. This file is generated from the auditmanager-2017-07-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AuditManager.Model
{
    /// <summary>
    /// An error entity for the <code>BatchCreateDelegationByAssessment</code> API. This
    /// is used to provide more meaningful errors than a simple string message.
    /// </summary>
    public partial class BatchCreateDelegationByAssessmentError
    {
        private CreateDelegationRequest _createDelegationRequest;
        private string _errorCode;
        private string _errorMessage;

        /// <summary>
        /// Gets and sets the property CreateDelegationRequest. 
        /// <para>
        ///  The API request to batch create delegations in AWS Audit Manager. 
        /// </para>
        /// </summary>
        public CreateDelegationRequest CreateDelegationRequest
        {
            get { return this._createDelegationRequest; }
            set { this._createDelegationRequest = value; }
        }

        // Check to see if CreateDelegationRequest property is set
        internal bool IsSetCreateDelegationRequest()
        {
            return this._createDelegationRequest != null;
        }

        /// <summary>
        /// Gets and sets the property ErrorCode. 
        /// <para>
        ///  The error code returned by the <code>BatchCreateDelegationByAssessment</code> API.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min=3, Max=3)]
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
        ///  The error message returned by the <code>BatchCreateDelegationByAssessment</code>
        /// API. 
        /// </para>
        /// </summary>
        [AWSProperty(Max=300)]
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

    }
}