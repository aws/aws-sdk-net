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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
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
namespace Amazon.IoT.Model
{
    /// <summary>
    /// This is the response object from the DeleteCommand operation.
    /// </summary>
    public partial class DeleteCommandResponse : AmazonWebServiceResponse
    {
        private int? _statusCode;

        /// <summary>
        /// Gets and sets the property StatusCode. 
        /// <para>
        /// The status code for the command deletion request. The status code is in the 200 range
        /// for a successful request.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If the command hasn't been deprecated, or has been deprecated for a duration that
        /// is shorter than the maximum time out duration of 12 hours, when calling the <c>DeleteCommand</c>
        /// request, the deletion will be scheduled and a 202 status code will be returned. While
        /// the command is being deleted, it will be in a <c>pendingDeletion</c> state. Once the
        /// time out duration has been reached, the command will be permanently removed from your
        /// account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the command has been deprecated for a duration that is longer than the maximum
        /// time out duration of 12 hours, when calling the <c>DeleteCommand</c> request, the
        /// command will be deleted immediately and a 204 status code will be returned.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public int? StatusCode
        {
            get { return this._statusCode; }
            set { this._statusCode = value; }
        }

        // Check to see if StatusCode property is set
        internal bool IsSetStatusCode()
        {
            return this._statusCode.HasValue; 
        }

    }
}