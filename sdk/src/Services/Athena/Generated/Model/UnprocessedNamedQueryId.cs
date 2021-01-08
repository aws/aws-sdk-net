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
 * Do not modify this file. This file is generated from the athena-2017-05-18.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Athena.Model
{
    /// <summary>
    /// Information about a named query ID that could not be processed.
    /// </summary>
    public partial class UnprocessedNamedQueryId
    {
        private string _errorCode;
        private string _errorMessage;
        private string _namedQueryId;

        /// <summary>
        /// Gets and sets the property ErrorCode. 
        /// <para>
        /// The error code returned when the processing request for the named query failed, if
        /// applicable.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
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
        /// The error message returned when the processing request for the named query failed,
        /// if applicable.
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

        /// <summary>
        /// Gets and sets the property NamedQueryId. 
        /// <para>
        /// The unique identifier of the named query.
        /// </para>
        /// </summary>
        public string NamedQueryId
        {
            get { return this._namedQueryId; }
            set { this._namedQueryId = value; }
        }

        // Check to see if NamedQueryId property is set
        internal bool IsSetNamedQueryId()
        {
            return this._namedQueryId != null;
        }

    }
}