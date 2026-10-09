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

namespace Amazon.Athena.Model
{
    /// <summary>
    /// The name of a prepared statement that could not be returned.
    /// </summary>
    public partial class UnprocessedPreparedStatementName
    {
        /// <summary>
        /// Gets and sets the property ErrorCode. 
        /// <para>
        /// The error code returned when the request for the prepared statement failed.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// Checks to see if the ErrorCode property is set.
        /// </summary>
        internal bool IsSetErrorCode() => this.ErrorCode != null;

        /// <summary>
        /// Gets and sets the property ErrorMessage. 
        /// <para>
        /// The error message containing the reason why the prepared statement could not be returned.
        /// The following error messages are possible:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>INVALID_INPUT</c> - The name of the prepared statement that was provided is not
        /// valid (for example, the name is too long).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>STATEMENT_NOT_FOUND</c> - A prepared statement with the name provided could not
        /// be found.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>UNAUTHORIZED</c> - The requester does not have permission to access the workgroup
        /// that contains the prepared statement.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string ErrorMessage { get; set; }

        /// <summary>
        /// Checks to see if the ErrorMessage property is set.
        /// </summary>
        internal bool IsSetErrorMessage() => this.ErrorMessage != null;

        /// <summary>
        /// Gets and sets the property StatementName. 
        /// <para>
        /// The name of a prepared statement that could not be returned due to an error.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string StatementName { get; set; }

        /// <summary>
        /// Checks to see if the StatementName property is set.
        /// </summary>
        internal bool IsSetStatementName() => this.StatementName != null;
    }
}
