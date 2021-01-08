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
    /// An error entity for the <code>BatchDeleteDelegationByAssessment</code> API. This
    /// is used to provide more meaningful errors than a simple string message.
    /// </summary>
    public partial class BatchDeleteDelegationByAssessmentError
    {
        private string _delegationId;
        private string _errorCode;
        private string _errorMessage;

        /// <summary>
        /// Gets and sets the property DelegationId. 
        /// <para>
        ///  The identifier for the specified delegation. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=36, Max=36)]
        public string DelegationId
        {
            get { return this._delegationId; }
            set { this._delegationId = value; }
        }

        // Check to see if DelegationId property is set
        internal bool IsSetDelegationId()
        {
            return this._delegationId != null;
        }

        /// <summary>
        /// Gets and sets the property ErrorCode. 
        /// <para>
        ///  The error code returned by the <code>BatchDeleteDelegationByAssessment</code> API.
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
        ///  The error message returned by the <code>BatchDeleteDelegationByAssessment</code>
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