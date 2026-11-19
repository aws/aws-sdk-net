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

namespace Amazon.CleanRooms.Model
{
    /// <summary>
    /// Details of the error that caused the protected job to fail.
    /// </summary>
    public partial class ProtectedJobError
    {
        /// <summary>
        /// Gets and sets the property Code. 
        /// <para>
        /// A code that identifies the category of the failure. Valid values are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>MALFORMED_SCRIPT</c> – The job script or its execution environment is not valid
        /// (code, imports, entry point, virtual environment, or dependencies).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>RESOURCE_NOT_FOUND</c> – A referenced resource doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>INVALID_RESOURCE</c> – A referenced resource exists, but you can't use it because
        /// its configuration, state, or data is not valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>RESOURCE_ACCESS_DENIED</c> – A required permission is missing for a data source
        /// or resource.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>INSUFFICIENT_COMPUTE</c> – The job exceeded the available compute (memory, disk,
        /// or time).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>TRANSIENT_ERROR</c> – A temporary condition caused the failure, such as throttling
        /// or a network interruption.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>INTERNAL_ERROR</c> – Clean Rooms encountered an unexpected error. If the error
        /// persists, contact AWS Support.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>UNKNOWN_ERROR</c> – The failure couldn't be classified.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information about error codes, see <a href="https://docs.aws.amazon.com/clean-rooms/latest/userguide/error-codes.html">https://docs.aws.amazon.com/clean-rooms/latest/userguide/error-codes.html</a>
        /// in the Clean Rooms User Guide.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Code { get; set; }

        /// <summary>
        /// Checks to see if the Code property is set.
        /// </summary>
        internal bool IsSetCode() => this.Code != null;

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// A description of why the protected job failed.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Message { get; set; }

        /// <summary>
        /// Checks to see if the Message property is set.
        /// </summary>
        internal bool IsSetMessage() => this.Message != null;

        /// <summary>
        /// Gets and sets the property Retry. 
        /// <para>
        /// Contains information about whether running the same protected job again might succeed.
        /// </para>
        /// </summary>
        public RetryInfo Retry { get; set; }

        /// <summary>
        /// Checks to see if the Retry property is set.
        /// </summary>
        internal bool IsSetRetry() => this.Retry != null;
    }
}
