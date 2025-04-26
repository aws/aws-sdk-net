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
 * Do not modify this file. This file is generated from the service-quotas-2019-06-24.normal.json service model.
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
namespace Amazon.ServiceQuotas.Model
{
    /// <summary>
    /// An error that explains why an action did not succeed.
    /// </summary>
    public partial class ErrorReason
    {
        private ErrorCode _errorCode;
        private string _errorMessage;

        /// <summary>
        /// Gets and sets the property ErrorCode. 
        /// <para>
        /// Service Quotas returns the following error values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>DEPENDENCY_ACCESS_DENIED_ERROR</c> - The caller does not have the required permissions
        /// to complete the action. To resolve the error, you must have permission to access the
        /// Amazon Web Services service or quota.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DEPENDENCY_THROTTLING_ERROR</c> - The Amazon Web Services service is throttling
        /// Service Quotas. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DEPENDENCY_SERVICE_ERROR</c> - The Amazon Web Services service is not available.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SERVICE_QUOTA_NOT_AVAILABLE_ERROR</c> - There was an error in Service Quotas.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ErrorCode ErrorCode
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
        /// The error message.
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

    }
}