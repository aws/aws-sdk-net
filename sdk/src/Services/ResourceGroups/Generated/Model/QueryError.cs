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
 * Do not modify this file. This file is generated from the resource-groups-2017-11-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ResourceGroups.Model
{
    /// <summary>
    /// A two-part error structure that can occur in <code>ListGroupResources</code> or <code>SearchResources</code>
    /// operations on CloudFront stack-based queries. The error occurs if the CloudFront stack
    /// on which the query is based either does not exist, or has a status that renders the
    /// stack inactive. A <code>QueryError</code> occurrence does not necessarily mean that
    /// Resource Groups could not complete the operation, but the resulting group might have
    /// no member resources.
    /// </summary>
    public partial class QueryError
    {
        private QueryErrorCode _errorCode;
        private string _message;

        /// <summary>
        /// Gets and sets the property ErrorCode. 
        /// <para>
        /// Specifies the error code that was raised.
        /// </para>
        /// </summary>
        public QueryErrorCode ErrorCode
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
        /// Gets and sets the property Message. 
        /// <para>
        /// A message that explains the <code>ErrorCode</code> value. Messages might state that
        /// the specified CloudFront stack does not exist (or no longer exists). For <code>CLOUDFORMATION_STACK_INACTIVE</code>,
        /// the message typically states that the CloudFront stack has a status that is not (or
        /// no longer) active, such as <code>CREATE_FAILED</code>.
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

    }
}