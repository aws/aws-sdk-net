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
 * Do not modify this file. This file is generated from the finspace-data-2020-07-13.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.FinSpaceData.Model
{
    /// <summary>
    /// The structure with error messages.
    /// </summary>
    public partial class ChangesetErrorInfo
    {
        private ErrorCategory _errorCategory;
        private string _errorMessage;

        /// <summary>
        /// Gets and sets the property ErrorCategory. 
        /// <para>
        /// The category of the error.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>VALIDATION</code> – The inputs to this request are invalid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>SERVICE_QUOTA_EXCEEDED</code> – Service quotas have been exceeded. Please contact
        /// AWS support to increase quotas.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ACCESS_DENIED</code> – Missing required permission to perform this request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>RESOURCE_NOT_FOUND</code> – One or more inputs to this request were not found.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>THROTTLING</code> – The system temporarily lacks sufficient resources to process
        /// the request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>INTERNAL_SERVICE_EXCEPTION</code> – An internal service error has occurred.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>CANCELLED</code> – Cancelled.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>USER_RECOVERABLE</code> – A user recoverable error has occurred.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ErrorCategory ErrorCategory
        {
            get { return this._errorCategory; }
            set { this._errorCategory = value; }
        }

        // Check to see if ErrorCategory property is set
        internal bool IsSetErrorCategory()
        {
            return this._errorCategory != null;
        }

        /// <summary>
        /// Gets and sets the property ErrorMessage. 
        /// <para>
        /// The text of the error message.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1000)]
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