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

namespace Amazon.SecurityAgent.Model
{
    /// <summary>
    /// Capabilities for an integrated Bitbucket repository.
    /// </summary>
    public partial class BitbucketResourceCapabilities
    {
        /// <summary>
        /// Gets and sets the property LeaveComments. 
        /// <para>
        /// Whether to post code review comments on pull requests.
        /// </para>
        /// </summary>
        public bool? LeaveComments { get; set; }

        /// <summary>
        /// Checks to see if the LeaveComments property is set.
        /// </summary>
        internal bool IsSetLeaveComments() => this.LeaveComments.HasValue;

        /// <summary>
        /// Gets and sets the property RemediateCode. 
        /// <para>
        /// Whether to create pull requests with automated fixes.
        /// </para>
        /// </summary>
        public bool? RemediateCode { get; set; }

        /// <summary>
        /// Checks to see if the RemediateCode property is set.
        /// </summary>
        internal bool IsSetRemediateCode() => this.RemediateCode.HasValue;
    }
}
