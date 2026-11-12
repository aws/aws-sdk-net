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
    /// Contains information about whether running a failed protected query or protected job
    /// again might succeed.
    /// </summary>
    public partial class RetryInfo
    {
        /// <summary>
        /// Gets and sets the property Retryable. 
        /// <para>
        /// Specifies whether running the same request again might succeed. <c>true</c> means
        /// that the failure was transient. <c>false</c> means that running the same request again
        /// is not expected to succeed.
        /// </para>
        /// </summary>
        public bool? Retryable { get; set; }

        /// <summary>
        /// Checks to see if the Retryable property is set.
        /// </summary>
        internal bool IsSetRetryable() => this.Retryable.HasValue;
    }
}
