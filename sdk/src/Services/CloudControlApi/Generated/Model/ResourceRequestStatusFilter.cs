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
 * Do not modify this file. This file is generated from the cloudcontrol-2021-09-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudControlApi.Model
{
    /// <summary>
    /// The filter criteria to use in determining the requests returned.
    /// </summary>
    public partial class ResourceRequestStatusFilter
    {
        private List<string> _operations = new List<string>();
        private List<string> _operationStatuses = new List<string>();

        /// <summary>
        /// Gets and sets the property Operations. 
        /// <para>
        /// The operation types to include in the filter.
        /// </para>
        /// </summary>
        public List<string> Operations
        {
            get { return this._operations; }
            set { this._operations = value; }
        }

        // Check to see if Operations property is set
        internal bool IsSetOperations()
        {
            return this._operations != null && this._operations.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property OperationStatuses. 
        /// <para>
        /// The operation statuses to include in the filter.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>PENDING</code>: The operation has been requested, but not yet initiated.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>IN_PROGRESS</code>: The operation is currently in progress.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>SUCCESS</code>: The operation has successfully completed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>FAILED</code>: The operation has failed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>CANCEL_IN_PROGRESS</code>: The operation is currently in the process of being
        /// canceled.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>CANCEL_COMPLETE</code>: The operation has been canceled.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public List<string> OperationStatuses
        {
            get { return this._operationStatuses; }
            set { this._operationStatuses = value; }
        }

        // Check to see if OperationStatuses property is set
        internal bool IsSetOperationStatuses()
        {
            return this._operationStatuses != null && this._operationStatuses.Count > 0; 
        }

    }
}