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

namespace Amazon.Batch.Model
{
    /// <summary>
    /// Specifies a set of conditions to be met, and an action to take (<code>RETRY</code>
    /// or <code>EXIT</code>) if all conditions are met.
    /// </summary>
    public partial class EvaluateOnExit
    {
        private RetryAction _action;
        private string _onExitCode;
        private string _onReason;
        private string _onStatusReason;

        /// <summary>
        /// Gets and sets the property Action. 
        /// <para>
        /// Specifies the action to take if all of the specified conditions (<code>onStatusReason</code>,
        /// <code>onReason</code>, and <code>onExitCode</code>) are met. The values are not case
        /// sensitive.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RetryAction Action
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
        /// Gets and sets the property OnExitCode. 
        /// <para>
        /// Contains a glob pattern to match against the decimal representation of the <code>ExitCode</code>
        /// returned for a job. The patten can be up to 512 characters long, can contain only
        /// numbers, and can optionally end with an asterisk (*) so that only the start of the
        /// string needs to be an exact match.
        /// </para>
        /// </summary>
        public string OnExitCode
        {
            get { return this._onExitCode; }
            set { this._onExitCode = value; }
        }

        // Check to see if OnExitCode property is set
        internal bool IsSetOnExitCode()
        {
            return this._onExitCode != null;
        }

        /// <summary>
        /// Gets and sets the property OnReason. 
        /// <para>
        /// Contains a glob pattern to match against the <code>Reason</code> returned for a job.
        /// The patten can be up to 512 characters long, can contain letters, numbers, periods
        /// (.), colons (:), and white space (spaces, tabs), and can optionally end with an asterisk
        /// (*) so that only the start of the string needs to be an exact match.
        /// </para>
        /// </summary>
        public string OnReason
        {
            get { return this._onReason; }
            set { this._onReason = value; }
        }

        // Check to see if OnReason property is set
        internal bool IsSetOnReason()
        {
            return this._onReason != null;
        }

        /// <summary>
        /// Gets and sets the property OnStatusReason. 
        /// <para>
        /// Contains a glob pattern to match against the <code>StatusReason</code> returned for
        /// a job. The patten can be up to 512 characters long, can contain letters, numbers,
        /// periods (.), colons (:), and white space (spaces, tabs). and can optionally end with
        /// an asterisk (*) so that only the start of the string needs to be an exact match.
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