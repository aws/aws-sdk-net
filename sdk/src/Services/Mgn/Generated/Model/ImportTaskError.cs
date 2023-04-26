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
 * Do not modify this file. This file is generated from the mgn-2020-02-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Mgn.Model
{
    /// <summary>
    /// Import task error.
    /// </summary>
    public partial class ImportTaskError
    {
        private ImportErrorData _errorData;
        private string _errorDateTime;
        private ImportErrorType _errorType;

        /// <summary>
        /// Gets and sets the property ErrorData. 
        /// <para>
        /// Import task error data.
        /// </para>
        /// </summary>
        public ImportErrorData ErrorData
        {
            get { return this._errorData; }
            set { this._errorData = value; }
        }

        // Check to see if ErrorData property is set
        internal bool IsSetErrorData()
        {
            return this._errorData != null;
        }

        /// <summary>
        /// Gets and sets the property ErrorDateTime. 
        /// <para>
        /// Import task error datetime.
        /// </para>
        /// </summary>
        [AWSProperty(Min=19, Max=32)]
        public string ErrorDateTime
        {
            get { return this._errorDateTime; }
            set { this._errorDateTime = value; }
        }

        // Check to see if ErrorDateTime property is set
        internal bool IsSetErrorDateTime()
        {
            return this._errorDateTime != null;
        }

        /// <summary>
        /// Gets and sets the property ErrorType. 
        /// <para>
        /// Import task error type.
        /// </para>
        /// </summary>
        public ImportErrorType ErrorType
        {
            get { return this._errorType; }
            set { this._errorType = value; }
        }

        // Check to see if ErrorType property is set
        internal bool IsSetErrorType()
        {
            return this._errorType != null;
        }

    }
}