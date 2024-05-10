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
 * Do not modify this file. This file is generated from the servicediscovery-2017-03-14.normal.json service model.
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
namespace Amazon.ServiceDiscovery.Model
{
    /// <summary>
    /// A complex type that contains information about an operation that matches the criteria
    /// that you specified in a <a href="https://docs.aws.amazon.com/cloud-map/latest/api/API_ListOperations.html">ListOperations</a>
    /// request.
    /// </summary>
    public partial class OperationSummary
    {
        private string _id;
        private OperationStatus _status;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID for an operation.
        /// </para>
        /// </summary>
        [AWSProperty(Max=255)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the operation. Values include the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>SUBMITTED</b>: This is the initial state immediately after you submit a request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>PENDING</b>: Cloud Map is performing the operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>SUCCESS</b>: The operation succeeded.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>FAIL</b>: The operation failed. For the failure reason, see <c>ErrorMessage</c>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public OperationStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}