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
    /// Specifies an array of up to 5 conditions to be met, and an action to take (<c>RETRY</c>
    /// or <c>EXIT</c>) if all conditions are met. If none of the <c>EvaluateOnExit</c> conditions
    /// in a <c>RetryStrategy</c> match, then the job is retried.
    /// </summary>
    public partial class EvaluateOnExit
    {
        /// <summary>
        /// Gets and sets the property Action. 
        /// <para>
        /// Specifies the action to take if all of the specified conditions (<c>onStatusReason</c>,
        /// <c>onReason</c>, and <c>onExitCode</c>) are met. The values aren't case sensitive.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public RetryAction Action { get; set; }

        /// <summary>
        /// Checks to see if the Action property is set.
        /// </summary>
        internal bool IsSetAction() => this.Action != null;

        /// <summary>
        /// Gets and sets the property OnExitCode. 
        /// <para>
        /// Contains a glob pattern to match against the decimal representation of the <c>ExitCode</c>
        /// returned for a job. The pattern can be up to 512 characters long. It can contain only
        /// numbers, and can end with an asterisk (*) so that only the start of the string needs
        /// to be an exact match.
        /// </para>
        ///  
        /// <para>
        /// The string can contain up to 512 characters.
        /// </para>
        /// </summary>
        public string OnExitCode { get; set; }

        /// <summary>
        /// Checks to see if the OnExitCode property is set.
        /// </summary>
        internal bool IsSetOnExitCode() => this.OnExitCode != null;

        /// <summary>
        /// Gets and sets the property OnReason. 
        /// <para>
        /// Contains a glob pattern to match against the <c>Reason</c> returned for a job. The
        /// pattern can contain up to 512 characters. It can contain letters, numbers, periods
        /// (.), colons (:), and white space (including spaces and tabs). It can optionally end
        /// with an asterisk (*) so that only the start of the string needs to be an exact match.
        /// </para>
        /// </summary>
        public string OnReason { get; set; }

        /// <summary>
        /// Checks to see if the OnReason property is set.
        /// </summary>
        internal bool IsSetOnReason() => this.OnReason != null;

        /// <summary>
        /// Gets and sets the property OnStatusReason. 
        /// <para>
        /// Contains a glob pattern to match against the <c>StatusReason</c> returned for a job.
        /// The pattern can contain up to 512 characters. It can contain letters, numbers, periods
        /// (.), colons (:), and white spaces (including spaces or tabs). It can optionally end
        /// with an asterisk (*) so that only the start of the string needs to be an exact match.
        /// </para>
        /// </summary>
        public string OnStatusReason { get; set; }

        /// <summary>
        /// Checks to see if the OnStatusReason property is set.
        /// </summary>
        internal bool IsSetOnStatusReason() => this.OnStatusReason != null;
    }
}
