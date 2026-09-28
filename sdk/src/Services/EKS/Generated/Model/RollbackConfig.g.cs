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

namespace Amazon.EKS.Model
{
    /// <summary>
    /// The rollback configuration for the cluster version rollback.
    /// </summary>
    public partial class RollbackConfig
    {
        /// <summary>
        /// Gets and sets the property TimeoutMinutes. 
        /// <para>
        /// The length of time in minutes to wait before cancelling the update. Timeout is a minimum-bound
        /// property, meaning the timeout occurs no sooner than the time you specify, but can
        /// occur shortly thereafter. This value can be between 120 (2 hours) and 10080 (7 days).
        /// Default: <c>720</c> (12 hours) if not specified.
        /// </para>
        /// </summary>
        public int? TimeoutMinutes { get; set; }

        /// <summary>
        /// Checks to see if the TimeoutMinutes property is set.
        /// </summary>
        internal bool IsSetTimeoutMinutes() => this.TimeoutMinutes.HasValue;
    }
}
