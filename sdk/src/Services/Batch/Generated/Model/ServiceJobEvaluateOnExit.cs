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
 * Do not modify this file. This file is generated from the batch-2016-08-10.normal.json service model.
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
    /// Specifies conditions for when to exit or retry a service job based on the exit status
    /// or status reason.
    /// </summary>
    public partial class ServiceJobEvaluateOnExit
    {
        private ServiceJobRetryAction _action;
        private string _onStatusReason;

        /// <summary>
        /// Gets and sets the property Action. 
        /// <para>
        /// The action to take if the service job exits with the specified condition. Valid values
        /// are <c>RETRY</c> and <c>EXIT</c>.
        /// </para>
        /// </summary>
        public ServiceJobRetryAction Action
        {
            get { return this._action; }
            set { this._action = value; }
        }

        // Check to see if Action property is set
        internal bool IsSetAction()
        {
            return this._action != null;
        }

        /// <summary>
        /// Gets and sets the property OnStatusReason. 
        /// <para>
        /// Contains a glob pattern to match against the StatusReason returned for a job. The
        /// pattern can contain up to 512 characters and can contain all printable characters.
        /// It can optionally end with an asterisk (*) so that only the start of the string needs
        /// to be an exact match.
        /// </para>
        /// </summary>
        public string OnStatusReason
        {
            get { return this._onStatusReason; }
            set { this._onStatusReason = value; }
        }

        // Check to see if OnStatusReason property is set
        internal bool IsSetOnStatusReason()
        {
            return this._onStatusReason != null;
        }

    }
}