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

namespace Amazon.Batch.Model
{
    /// <summary>
    /// An object that contains the details of a service job that couldn't be terminated by
    /// a <c>TerminateServiceJobs</c> operation.
    /// </summary>
    public partial class TerminateServiceJobsErrorDetail
    {
        /// <summary>
        /// Gets and sets the property Code. 
        /// <para>
        /// An error code that identifies the reason the service job couldn't be terminated. Valid
        /// values are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ValidationException</c> – A service job identifier in the request is malformed
        /// or isn't valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ClientException</c> – The request failed because of a client error.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ThrottlingException</c> – The request was throttled. Retry the request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ServerException</c> – An internal error occurred. Retry the request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AccessDenied</c> – The caller isn't authorized to perform the action on the specified
        /// service job.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Code { get; set; }

        /// <summary>
        /// Checks to see if the Code property is set.
        /// </summary>
        internal bool IsSetCode() => this.Code != null;

        /// <summary>
        /// Gets and sets the property Job. 
        /// <para>
        /// The service job ID of the service job that couldn't be terminated.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Job { get; set; }

        /// <summary>
        /// Checks to see if the Job property is set.
        /// </summary>
        internal bool IsSetJob() => this.Job != null;

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// A message that describes the reason the service job couldn't be terminated.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Message { get; set; }

        /// <summary>
        /// Checks to see if the Message property is set.
        /// </summary>
        internal bool IsSetMessage() => this.Message != null;
    }
}
