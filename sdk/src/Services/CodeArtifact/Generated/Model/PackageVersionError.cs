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
 * Do not modify this file. This file is generated from the codeartifact-2018-09-22.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CodeArtifact.Model
{
    /// <summary>
    /// An error associated with package.
    /// </summary>
    public partial class PackageVersionError
    {
        private PackageVersionErrorCode _errorCode;
        private string _errorMessage;

        /// <summary>
        /// Gets and sets the property ErrorCode. 
        /// <para>
        ///  The error code associated with the error. Valid error codes are: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>ALREADY_EXISTS</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>MISMATCHED_REVISION</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>MISMATCHED_STATUS</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>NOT_ALLOWED</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>NOT_FOUND</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>SKIPPED</code> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public PackageVersionErrorCode ErrorCode
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
        ///  The error message associated with the error. 
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