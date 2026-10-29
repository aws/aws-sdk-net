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

namespace Amazon.CloudWatchLogs.Model
{
    /// <summary>
    /// Container for the parameters to the PutLogGroupDeletionProtection operation. Enables
    /// or disables deletion protection for the specified log group. When enabled on a log
    /// group, deletion protection blocks all deletion operations until it is explicitly disabled.
    /// <para> For information about the parameters that are common to all actions, see <a
    /// href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/CommonParameters.html">Common
    /// Parameters</a>. </para>
    /// </summary>
    public partial class PutLogGroupDeletionProtectionRequest : AmazonCloudWatchLogsRequest
    {
        /// <summary>
        /// Gets and sets the property DeletionProtectionEnabled. 
        /// <para>
        /// Whether to enable deletion protection.
        /// </para>
        ///  
        /// <para>
        /// Type: Boolean
        /// </para>
        ///  
        /// <para>
        /// Required: Yes
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public bool? DeletionProtectionEnabled { get; set; }

        /// <summary>
        /// Checks to see if the DeletionProtectionEnabled property is set.
        /// </summary>
        internal bool IsSetDeletionProtectionEnabled() => this.DeletionProtectionEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property LogGroupIdentifier. 
        /// <para>
        /// The name or ARN of the log group.
        /// </para>
        ///  
        /// <para>
        /// Type: String
        /// </para>
        ///  
        /// <para>
        /// Length Constraints: Minimum length of 1. Maximum length of 512.
        /// </para>
        ///  
        /// <para>
        /// Pattern: <c>[\.\-_/#A-Za-z0-9]+</c> 
        /// </para>
        ///  
        /// <para>
        /// Required: Yes
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string LogGroupIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the LogGroupIdentifier property is set.
        /// </summary>
        internal bool IsSetLogGroupIdentifier() => this.LogGroupIdentifier != null;
    }
}
