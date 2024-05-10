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
 * Do not modify this file. This file is generated from the cloud9-2017-09-23.normal.json service model.
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
namespace Amazon.Cloud9.Model
{
    /// <summary>
    /// Information about the current creation or deletion lifecycle state of an Cloud9 development
    /// environment.
    /// </summary>
    public partial class EnvironmentLifecycle
    {
        private string _failureResource;
        private string _reason;
        private EnvironmentLifecycleStatus _status;

        /// <summary>
        /// Gets and sets the property FailureResource. 
        /// <para>
        /// If the environment failed to delete, the Amazon Resource Name (ARN) of the related
        /// Amazon Web Services resource.
        /// </para>
        /// </summary>
        public string FailureResource
        {
            get { return this._failureResource; }
            set { this._failureResource = value; }
        }

        // Check to see if FailureResource property is set
        internal bool IsSetFailureResource()
        {
            return this._failureResource != null;
        }

        /// <summary>
        /// Gets and sets the property Reason. 
        /// <para>
        /// Any informational message about the lifecycle state of the environment.
        /// </para>
        /// </summary>
        public string Reason
        {
            get { return this._reason; }
            set { this._reason = value; }
        }

        // Check to see if Reason property is set
        internal bool IsSetReason()
        {
            return this._reason != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current creation or deletion lifecycle state of the environment.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>CREATING</c>: The environment is in the process of being created.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CREATED</c>: The environment was successfully created.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CREATE_FAILED</c>: The environment failed to be created.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DELETING</c>: The environment is in the process of being deleted.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DELETE_FAILED</c>: The environment failed to delete.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public EnvironmentLifecycleStatus Status
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