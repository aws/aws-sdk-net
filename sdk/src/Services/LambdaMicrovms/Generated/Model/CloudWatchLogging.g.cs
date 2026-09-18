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

namespace Amazon.LambdaMicrovms.Model
{
    /// <summary>
    /// Configuration for Amazon CloudWatch Logs logging.
    /// </summary>
    public partial class CloudWatchLogging
    {
        /// <summary>
        /// Gets and sets the property LogGroup. 
        /// <para>
        /// The name of the CloudWatch Logs log group to send logs to.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 512)]
        public string LogGroup { get; set; }

        /// <summary>
        /// Checks to see if the LogGroup property is set.
        /// </summary>
        internal bool IsSetLogGroup() => this.LogGroup != null;

        /// <summary>
        /// Gets and sets the property LogStream. 
        /// <para>
        /// The name of the CloudWatch Logs log stream within the log group.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 512)]
        public string LogStream { get; set; }

        /// <summary>
        /// Checks to see if the LogStream property is set.
        /// </summary>
        internal bool IsSetLogStream() => this.LogStream != null;
    }
}
