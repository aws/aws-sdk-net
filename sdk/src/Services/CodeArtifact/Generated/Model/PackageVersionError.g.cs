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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.CodeArtifact.Model
{
    /// <summary>
    /// l An error associated with package.
    /// </summary>
    public partial class PackageVersionError
    {
        /// <summary>
        /// Gets and sets the property ErrorCode. 
        /// <para>
        ///  The error code associated with the error. Valid error codes are: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ALREADY_EXISTS</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>MISMATCHED_REVISION</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>MISMATCHED_STATUS</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>NOT_ALLOWED</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>NOT_FOUND</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SKIPPED</c> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public PackageVersionErrorCode ErrorCode { get; set; }

        /// <summary>
        /// Checks to see if the ErrorCode property is set.
        /// </summary>
        internal bool IsSetErrorCode() => this.ErrorCode != null;

        /// <summary>
        /// Gets and sets the property ErrorMessage. 
        /// <para>
        ///  The error message associated with the error. 
        /// </para>
        /// </summary>
        public string ErrorMessage { get; set; }

        /// <summary>
        /// Checks to see if the ErrorMessage property is set.
        /// </summary>
        internal bool IsSetErrorMessage() => this.ErrorMessage != null;
    }
}
